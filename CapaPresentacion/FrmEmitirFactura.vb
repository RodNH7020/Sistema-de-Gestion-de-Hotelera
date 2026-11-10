Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports CapaDatos
Imports CapaEntidades
Imports CapaNegocio
Imports SistemaHotelero

Public Class FrmEmitirFactura

    Private ReadOnly negocioFactura As New FacturaNegocio()
    Private ReadOnly negocioPago As New PagoNegocio()
    Private ReadOnly estadiaDatos As New EstadiaDatos()
    Private WithEvents docPrint As New PrintDocument()

    Private totalBrutoCalculado As Decimal = 0D
    Private anticipoCalculado As Decimal = 0D
    Private saldoPendiente As Decimal = 0D
    Private idEstadiaActual As Integer = 0

    Private Sub FrmEmitirFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipoFactura.Items.Clear()
        cboTipoFactura.Items.Add("Factura B (Consumidor Final)")
        cboTipoFactura.Items.Add("Factura A (Responsable Inscripto)")

        pnlMensajeExito.Visible = False
        pnlMensajeError.Visible = False
        btnImprimirPdf.Enabled = False

        cboTipoFactura.SelectedIndex = 0
    End Sub

    Private Sub txtIdEstadia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdEstadia.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboTipoFactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoFactura.SelectedIndexChanged
        If cboTipoFactura.SelectedIndex = 1 Then
            txtCuit.Enabled = True
            txtRazonSocial.Enabled = True
            txtCuit.ReadOnly = False
            txtRazonSocial.ReadOnly = False
            txtCuit.BackColor = Color.White
            txtRazonSocial.BackColor = Color.White
            txtCuit.ForeColor = Color.Black
            txtRazonSocial.ForeColor = Color.Black
            txtCuit.Text = ""
            txtRazonSocial.Text = ""
            txtCuit.Focus()
        Else
            txtCuit.Enabled = True
            txtRazonSocial.Enabled = True
            txtCuit.ReadOnly = True
            txtRazonSocial.ReadOnly = True
            txtCuit.BackColor = Color.FromArgb(240, 240, 240)
            txtRazonSocial.BackColor = Color.FromArgb(240, 240, 240)
            txtCuit.ForeColor = Color.Gray
            txtRazonSocial.ForeColor = Color.Gray
            txtCuit.Text = "— No requerido —"
            txtRazonSocial.Text = "— Consumidor Final —"
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        OcultarMensajes()

        If String.IsNullOrWhiteSpace(txtIdEstadia.Text) Then
            MostrarError("Por favor, ingrese un número de estadía.")
            txtIdEstadia.Focus()
            Return
        End If

        Dim idEst As Integer
        If Not Integer.TryParse(txtIdEstadia.Text.Trim(), idEst) OrElse idEst <= 0 Then
            MostrarError("El número de estadía debe ser un valor numérico válido.")
            Return
        End If

        Try
            Dim est As Estadia = estadiaDatos.BuscarPorId(idEst)
            If est Is Nothing Then
                MostrarError("No existe la estadía solicitada.")
                LimpiarCampos()
                Return
            End If

            idEstadiaActual = idEst
            anticipoCalculado = negocioPago.ObtenerTotalPagado(idEst)
            totalBrutoCalculado = 250000D
            saldoPendiente = Math.Max(0D, totalBrutoCalculado - anticipoCalculado)

            txtConcepto.Text = "Hospedaje y Servicios - Estadía N° " & idEst.ToString()
            txtTotalBruto.Text = totalBrutoCalculado.ToString("C2")
            txtAnticipo.Text = anticipoCalculado.ToString("C2")
            txtSaldoPagar.Text = saldoPendiente.ToString("C2")

            btnImprimirPdf.Enabled = False

        Catch ex As Exception
            MostrarError("Error al consultar la estadía: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEmitirFactura_Click(sender As Object, e As EventArgs) Handles btnEmitirFactura.Click
        OcultarMensajes()

        If idEstadiaActual <= 0 Then
            MostrarError("Debe buscar una estadía antes de emitir la factura.")
            Return
        End If

        Dim cuitAEnviar As String = ""
        Dim razonAEnviar As String = ""

        If cboTipoFactura.SelectedIndex = 1 Then
            If String.IsNullOrWhiteSpace(txtCuit.Text) OrElse txtCuit.Text.StartsWith("—") OrElse
               String.IsNullOrWhiteSpace(txtRazonSocial.Text) OrElse txtRazonSocial.Text.StartsWith("—") Then
                MostrarError("Para Factura A debe completar el CUIT y la Razón Social.")
                Return
            End If
            cuitAEnviar = txtCuit.Text.Trim()
            razonAEnviar = txtRazonSocial.Text.Trim()
        End If

        Try
            Dim listaDetalles As New List(Of Factura_Detalle)()
            Dim detalleItem As New Factura_Detalle() With {
                .cantidad = 1,
                .descripcion = txtConcepto.Text.Trim(),
                .precio_unitario = totalBrutoCalculado
            }
            listaDetalles.Add(detalleItem)

            Dim resultado As String = negocioFactura.EmitirFactura(idEstadiaActual, totalBrutoCalculado, listaDetalles)

            If resultado = "OK" Then
                MostrarExito("✓ Factura emitida correctamente.")
                btnImprimirPdf.Enabled = True
            Else
                MostrarError(resultado)
            End If

        Catch ex As Exception
            MostrarError("Error al emitir factura: " & ex.Message)
        End Try
    End Sub

    Private Sub btnImprimirPdf_Click(sender As Object, e As EventArgs) Handles btnImprimirPdf.Click
        Try
            Dim vistaPrevia As New PrintPreviewDialog()
            vistaPrevia.Document = docPrint
            vistaPrevia.WindowState = FormWindowState.Maximized
            vistaPrevia.ShowDialog()
        Catch ex As Exception
            MostrarError("No se pudo generar el documento PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub docPrint_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docPrint.PrintPage
        Dim g As Graphics = e.Graphics
        Dim penBorde As New Pen(Color.Black, 1.5F)
        Dim penFino As New Pen(Color.Black, 0.8F)
        Dim penGris As New Pen(Color.LightGray, 0.8F)

        Dim fLetraCentral As New Font("Arial", 22, FontStyle.Bold)
        Dim fTitulo As New Font("Arial", 14, FontStyle.Bold)
        Dim fBold As New Font("Arial", 9, FontStyle.Bold)
        Dim fRegular As New Font("Arial", 8.5F, FontStyle.Regular)
        Dim fMini As New Font("Arial", 7, FontStyle.Regular)
        Dim fMiniBold As New Font("Arial", 7, FontStyle.Bold)
        Dim fTotal As New Font("Arial", 12, FontStyle.Bold)

        Dim x As Integer = 40
        Dim y As Integer = 40
        Dim ancho As Integer = 740

        ' 1. Marco exterior
        g.DrawRectangle(penBorde, x, y, ancho, 1000)

        ' 2. Cuadro letra central
        Dim esFacturaA As Boolean = (cboTipoFactura.SelectedIndex = 1)
        Dim letraTipo As String = If(esFacturaA, "A", "B")
        Dim codTipo As String = If(esFacturaA, "COD. 01", "COD. 06")

        Dim centroX As Integer = x + (ancho \ 2)
        Dim anchoBox As Integer = 46
        Dim altoBox As Integer = 42
        Dim boxX As Integer = centroX - (anchoBox \ 2)

        g.FillRectangle(Brushes.WhiteSmoke, boxX, y, anchoBox, altoBox)
        g.DrawRectangle(penBorde, boxX, y, anchoBox, altoBox)

        Dim sfCentro As New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
        g.DrawString(letraTipo, fLetraCentral, Brushes.Black, New RectangleF(boxX, y + 2, anchoBox, altoBox - 14), sfCentro)
        g.DrawRectangle(penFino, boxX, y + altoBox - 14, anchoBox, 14)
        g.DrawString(codTipo, fMiniBold, Brushes.Black, New RectangleF(boxX, y + altoBox - 14, anchoBox, 14), sfCentro)

        g.DrawLine(penBorde, centroX, y + altoBox, centroX, y + 160)

        ' Datos Hotel Tekoha
        g.DrawString("HOTEL TEKOHA", fTitulo, Brushes.Black, x + 15, y + 15)
        g.DrawString("Razón Social: Hotel Tekoha S.R.L.", fMiniBold, Brushes.Black, x + 15, y + 38)
        g.DrawString("Dirección: Costanera Gral. San Martín 1250", fRegular, Brushes.Black, x + 15, y + 54)
        g.DrawString("Corrientes (3400) - Corrientes, Argentina", fRegular, Brushes.Black, x + 15, y + 70)
        g.DrawString("Tel: (0379) 442-8899 | Web: www.hoteltekoha.com.ar", fMini, Brushes.Black, x + 15, y + 86)
        g.DrawString("E-mail: facturacion@hoteltekoha.com.ar", fMini, Brushes.Black, x + 15, y + 102)
        g.DrawString("I.V.A. RESPONSABLE INSCRIPTO", fBold, Brushes.Black, x + 15, y + 130)

        ' Datos Factura
        g.DrawString("FACTURA", fTitulo, Brushes.Black, centroX + 30, y + 15)
        Dim nroFactura As String = "N° 0001 - " & idEstadiaActual.ToString().PadLeft(8, "0"c)
        g.DrawString(nroFactura, fTitulo, Brushes.Black, centroX + 30, y + 40)

        g.DrawString("Fecha de Emisión: " & DateTime.Now.ToString("dd/MM/yyyy"), fBold, Brushes.Black, centroX + 30, y + 70)
        g.DrawString("C.U.I.T.: 30-71464172-3", fRegular, Brushes.Black, centroX + 30, y + 90)
        g.DrawString("Ingresos Brutos: 30-71464172-3", fRegular, Brushes.Black, centroX + 30, y + 106)
        g.DrawString("Inicio de Actividades: 10/2014", fRegular, Brushes.Black, centroX + 30, y + 122)

        g.DrawLine(penBorde, x, y + 160, x + ancho, y + 160)

        ' 3. Cliente
        Dim yCli As Integer = y + 165
        Dim clienteNombre As String = If(esFacturaA, txtRazonSocial.Text.Trim(), "CONSUMIDOR FINAL")
        Dim clienteCuit As String = If(esFacturaA, txtCuit.Text.Trim(), "—")
        Dim condicionIva As String = If(esFacturaA, "Responsable Inscripto", "Consumidor Final")

        g.DrawString("Señor(es): " & clienteNombre, fBold, Brushes.Black, x + 15, yCli)
        g.DrawString("CUIT / Documento: " & clienteCuit, fRegular, Brushes.Black, centroX + 30, yCli)
        yCli += 20

        g.DrawString("Domicilio: Pellegrini 1450 - Corrientes", fRegular, Brushes.Black, x + 15, yCli)
        g.DrawString("Condición de IVA: " & condicionIva, fRegular, Brushes.Black, centroX + 30, yCli)
        yCli += 20

        g.DrawString("Condiciones de Venta: Contado [X]  Tarjeta/Transf. [ ]   |   Estadía N°: " & idEstadiaActual, fRegular, Brushes.Black, x + 15, yCli)
        yCli += 25
        g.DrawLine(penBorde, x, yCli, x + ancho, yCli)

        ' 4. Grilla
        Dim yTabla As Integer = yCli
        Dim altoHeaderTabla As Integer = 24

        g.FillRectangle(Brushes.Gainsboro, x, yTabla, ancho, altoHeaderTabla)
        g.DrawRectangle(penBorde, x, yTabla, ancho, altoHeaderTabla)

        g.DrawString("CANT.", fBold, Brushes.Black, x + 10, yTabla + 5)
        g.DrawString("DESCRIPCIÓN / CONCEPTO", fBold, Brushes.Black, x + 80, yTabla + 5)
        g.DrawString("P. UNITARIO", fBold, Brushes.Black, x + 510, yTabla + 5)
        g.DrawString("IMPORTE", fBold, Brushes.Black, x + 640, yTabla + 5)

        g.DrawLine(penFino, x + 65, yTabla, x + 65, yTabla + 580)
        g.DrawLine(penFino, x + 490, yTabla, x + 490, yTabla + 580)
        g.DrawLine(penFino, x + 620, yTabla, x + 620, yTabla + 580)

        Dim yItem As Integer = yTabla + altoHeaderTabla + 12
        g.DrawString("1", fRegular, Brushes.Black, x + 25, yItem)
        g.DrawString(If(String.IsNullOrEmpty(txtConcepto.Text), "Servicio de Hospedaje y Estadía", txtConcepto.Text), fRegular, Brushes.Black, x + 80, yItem)
        g.DrawString(totalBrutoCalculado.ToString("C2"), fRegular, Brushes.Black, x + 500, yItem)
        g.DrawString(totalBrutoCalculado.ToString("C2"), fRegular, Brushes.Black, x + 630, yItem)
        yItem += 26

        If anticipoCalculado > 0 Then
            g.DrawString("1", fRegular, Brushes.Black, x + 25, yItem)
            g.DrawString("Deducción de Anticipo abonado al momento del Check-in (50%)", fRegular, Brushes.Black, x + 80, yItem)
            g.DrawString("-" & anticipoCalculado.ToString("C2"), fRegular, Brushes.Black, x + 500, yItem)
            g.DrawString("-" & anticipoCalculado.ToString("C2"), fRegular, Brushes.Black, x + 630, yItem)
            yItem += 26
        End If

        Dim yFinTabla As Integer = yTabla + 580
        g.DrawLine(penBorde, x, yFinTabla, x + ancho, yFinTabla)

        ' 5. Totales
        Dim yTotales As Integer = yFinTabla
        Dim altoTotales As Integer = 50

        g.FillRectangle(Brushes.WhiteSmoke, x + 450, yTotales, 290, altoTotales)
        g.DrawRectangle(penBorde, x + 450, yTotales, 290, altoTotales)

        g.DrawString("TOTAL A PAGAR: ", fTotal, Brushes.DarkBlue, x + 460, yTotales + 15)
        g.DrawString(saldoPendiente.ToString("C2"), fTotal, Brushes.DarkRed, x + 600, yTotales + 15)

        ' 6. Código de Barras y CAI
        Dim yPie As Integer = yTotales + altoTotales + 15
        Dim barX As Integer = x + 20
        For i As Integer = 0 To 85
            Dim grosor As Integer = If(i Mod 3 = 0, 3, 1)
            g.FillRectangle(Brushes.Black, barX, yPie, grosor, 35)
            barX += grosor + 2
        Next
        g.DrawString("3071464172306000142513082377220261215", fMini, Brushes.Black, x + 20, yPie + 38)

        Dim boxCaiX As Integer = x + 480
        g.DrawRectangle(penFino, boxCaiX, yPie, 240, 48)
        g.DrawString("C.A.I. N°: 42513082377220", fBold, Brushes.Black, boxCaiX + 10, yPie + 8)
        g.DrawString("Fecha de Vto. C.A.I.: 15/12/2026", fBold, Brushes.Black, boxCaiX + 10, yPie + 26)

        Dim yLegal As Integer = yPie + 60
        g.DrawLine(penGris, x, yLegal, x + ancho, yLegal)
        g.DrawString("ORIGINAL BLANCO - Comprobante oficial de facturación. Hotel Tekoha S.R.L.", fMini, Brushes.DimGray, x + 15, yLegal + 5)
    End Sub

    Private Sub MostrarExito(msg As String)
        pnlMensajeError.Visible = False
        lblMensajeExito.Text = msg
        pnlMensajeExito.Visible = True
    End Sub

    Private Sub MostrarError(msg As String)
        pnlMensajeExito.Visible = False
        lblMensajeError.Text = "⚠ " & msg
        pnlMensajeError.Visible = True
    End Sub

    Private Sub OcultarMensajes()
        pnlMensajeExito.Visible = False
        pnlMensajeError.Visible = False
    End Sub

    Private Sub LimpiarCampos()
        idEstadiaActual = 0
        txtConcepto.Clear()
        txtTotalBruto.Clear()
        txtAnticipo.Clear()
        txtSaldoPagar.Clear()
        btnImprimirPdf.Enabled = False
        cboTipoFactura_SelectedIndexChanged(Nothing, Nothing)
    End Sub

End Class