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
        ' Opciones de Factura A y B
        cboTipoFactura.Items.Clear()
        cboTipoFactura.Items.Add("Factura B (Consumidor Final)")
        cboTipoFactura.Items.Add("Factura A (Responsable Inscripto)")

        ' Ocultar paneles de notificación al inicio
        pnlMensajeExito.Visible = False
        pnlMensajeError.Visible = False
        btnImprimirPdf.Enabled = False

        ' Seleccionar Factura B por defecto (dispara automáticamente SelectedIndexChanged)
        cboTipoFactura.SelectedIndex = 0
    End Sub

    ' Validación: Solo caracteres numéricos en el ID de Estadía
    Private Sub txtIdEstadia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdEstadia.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Manejo dinámico entre Factura A y B
    Private Sub cboTipoFactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoFactura.SelectedIndexChanged
        If cboTipoFactura.SelectedIndex = 1 Then
            ' --- FACTURA A: CUIT y Razón Social activos en blanco para escribir ---
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
            ' --- FACTURA B: Cuadros atenuados con texto gris informativo ---
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

    ' Buscar estadía en base de datos
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

            ' Obtener anticipos previos registrados
            anticipoCalculado = negocioPago.ObtenerTotalPagado(idEst)

            ' Importe total de la estadía
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

    ' Emitir la Factura cumpliendo las reglas de negocio
    Private Sub btnEmitirFactura_Click(sender As Object, e As EventArgs) Handles btnEmitirFactura.Click
        OcultarMensajes()

        If idEstadiaActual <= 0 Then
            MostrarError("Debe buscar una estadía antes de emitir la factura.")
            Return
        End If

        ' Validación fiscal para Factura A
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
            ' Crear lista de detalles según columnas de FACTURA_DETALLE
            Dim listaDetalles As New List(Of Factura_Detalle)()
            Dim detalleItem As New Factura_Detalle() With {
                .cantidad = 1,
                .descripcion = txtConcepto.Text.Trim(),
                .precio_unitario = totalBrutoCalculado
            }
            listaDetalles.Add(detalleItem)

            ' Llamada al método de negocio existente
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

    ' Generar e imprimir PDF
    Private Sub btnImprimirPdf_Click(sender As Object, e As EventArgs) Handles btnImprimirPdf.Click
        Try
            Dim printDlg As New PrintDialog()
            printDlg.Document = docPrint

            docPrint.PrinterSettings.PrinterName = "Microsoft Print to PDF"

            If docPrint.PrinterSettings.IsValid Then
                docPrint.Print()
            Else
                If printDlg.ShowDialog() = DialogResult.OK Then
                    docPrint.Print()
                End If
            End If
        Catch ex As Exception
            MostrarError("No se pudo generar el documento PDF: " & ex.Message)
        End Try
    End Sub

    ' Formato gráfico para el documento de impresión/PDF
    Private Sub docPrint_PrintPage(sender As Object, e As PrintPageEventArgs) Handles docPrint.PrintPage
        Dim g = e.Graphics
        Dim fontTitulo As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim fontSub As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim fontNormal As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim fontBold As New Font("Segoe UI", 10, FontStyle.Bold)

        Dim y As Integer = 50

        ' Encabezado
        g.DrawString("HOTEL SISTEMA HOTELERO", fontTitulo, Brushes.Black, 50, y)
        y += 35
        g.DrawString("COMPROBANTE DE FACTURACIÓN", fontSub, Brushes.Black, 50, y)
        y += 30
        g.DrawLine(Pens.Black, 50, y, 750, y)
        y += 20

        ' Datos generales
        g.DrawString("Fecha de Emisión: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontNormal, Brushes.Black, 50, y)
        g.DrawString("Tipo: " & cboTipoFactura.SelectedItem.ToString(), fontBold, Brushes.Black, 400, y)
        y += 25
        g.DrawString("Estadía N°: " & idEstadiaActual.ToString(), fontNormal, Brushes.Black, 50, y)

        If cboTipoFactura.SelectedIndex = 1 Then
            y += 25
            g.DrawString("CUIT: " & txtCuit.Text.Trim(), fontNormal, Brushes.Black, 50, y)
            g.DrawString("Razón Social: " & txtRazonSocial.Text.Trim(), fontNormal, Brushes.Black, 400, y)
        End If

        y += 35
        g.DrawLine(Pens.Black, 50, y, 750, y)
        y += 20

        ' Valores monetarios
        g.DrawString("Concepto: " & txtConcepto.Text, fontNormal, Brushes.Black, 50, y)
        y += 30
        g.DrawString("Total Bruto: " & txtTotalBruto.Text, fontNormal, Brushes.Black, 50, y)
        y += 25
        g.DrawString("Anticipo Abonado: " & txtAnticipo.Text, fontNormal, Brushes.Black, 50, y)
        y += 30
        g.DrawLine(Pens.Black, 50, y, 750, y)
        y += 15
        g.DrawString("TOTAL A LIQUIDAR: " & txtSaldoPagar.Text, fontSub, Brushes.DarkRed, 50, y)

        e.HasMorePages = False
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
        ' Restablecer estado de Factura según la selección activa
        cboTipoFactura_SelectedIndexChanged(Nothing, Nothing)
    End Sub

End Class