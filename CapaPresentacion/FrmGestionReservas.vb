Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports CapaNegocio

Public Class FrmGestionReservas
    Private ReadOnly negocio As New ReservaNegocio()
    Private dtUltimaConsulta As DataTable
    Private statsActuales As EstadisticasReservas

    Private Sub FrmGestionReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaDesde.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dtpFechaHasta.Value = DateTime.Now

        ' Encabezado negro para la grilla
        dgvReservas.EnableHeadersVisualStyles = False
        dgvReservas.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        dgvReservas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvReservas.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        dgvReservas.DefaultCellStyle.Font = New Font("Segoe UI", 8.5!)
        dgvReservas.RowTemplate.Height = 25

        CargarFiltros()
        EjecutarBusqueda()
    End Sub

    Private Sub CargarFiltros()
        Try
            ' Cargar Habitaciones
            Dim dtHab As DataTable = negocio.ObtenerHabitaciones()
            Dim filaTodasHab As DataRow = dtHab.NewRow()
            filaTodasHab("id_habitacion") = 0
            filaTodasHab("descripcion") = "— Todas las Habitaciones —"
            dtHab.Rows.InsertAt(filaTodasHab, 0)

            cboHabitacion.DataSource = dtHab
            cboHabitacion.DisplayMember = "descripcion"
            cboHabitacion.ValueMember = "id_habitacion"
            cboHabitacion.SelectedIndex = 0

            ' Cargar Usuarios
            Dim dtUsu As DataTable = negocio.ObtenerUsuarios()
            Dim filaTodosUsu As DataRow = dtUsu.NewRow()
            filaTodosUsu("id_usuario") = 0
            filaTodosUsu("descripcion") = "— Todos los Usuarios —"
            dtUsu.Rows.InsertAt(filaTodosUsu, 0)

            cboUsuario.DataSource = dtUsu
            cboUsuario.DisplayMember = "descripcion"
            cboUsuario.ValueMember = "id_usuario"
            cboUsuario.SelectedIndex = 0
        Catch ex As Exception
            MostrarError("Error al cargar filtros: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        EjecutarBusqueda()
    End Sub

    Private Sub EjecutarBusqueda()
        Dim fDesde As Date = dtpFechaDesde.Value.Date
        Dim fHasta As Date = dtpFechaHasta.Value.Date

        If fHasta < fDesde Then
            MostrarError("La Fecha Hasta no puede ser anterior a la Fecha Desde.")
            Return
        End If

        Try
            Dim idHab As Integer = 0
            If cboHabitacion.SelectedValue IsNot Nothing Then
                Integer.TryParse(cboHabitacion.SelectedValue.ToString(), idHab)
            End If

            dtUltimaConsulta = negocio.ConsultarReservas(fDesde, fHasta, idHab, statsActuales)
            dgvReservas.DataSource = dtUltimaConsulta

            If dgvReservas.Columns.Contains("Tarifa Diaria") Then
                dgvReservas.Columns("Tarifa Diaria").DefaultCellStyle.Format = "C2"
            End If

            ' Actualización de estadísticas en el panel inferior
            lblTotalReservas.Text = "Reservas: " & statsActuales.TotalReservas
            lblConfirmadas.Text = "Confirmadas: " & statsActuales.TotalConfirmadas
            lblCanceladas.Text = "Canceladas: " & statsActuales.TotalCanceladas
            lblSumaTarifas.Text = "Suma Total: " & statsActuales.SumaTarifas.ToString("C2")
            lblPromedioTarifa.Text = "Tarifa Promedio: " & statsActuales.PromedioTarifa.ToString("C2")

            If dtUltimaConsulta.Rows.Count = 0 Then
                MostrarError("No existen reservas ni estadías para el período seleccionado.")
            Else
                MostrarExito("✓ Reporte generado correctamente (" & dtUltimaConsulta.Rows.Count & " registros).")
            End If

        Catch ex As Exception
            MostrarError("Error: " & ex.Message)
        End Try
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

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If dtUltimaConsulta Is Nothing OrElse dtUltimaConsulta.Rows.Count = 0 Then
            MessageBox.Show("No hay datos cargados para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        prtDialog.WindowState = FormWindowState.Maximized
        prtDialog.ShowDialog()
    End Sub

    Private Sub prtDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles prtDoc.PrintPage
        Dim fuenteTitulo As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim fuenteSubtitulo As New Font("Segoe UI", 9.5F, FontStyle.Regular)
        Dim fuenteEncabezado As New Font("Segoe UI", 9, FontStyle.Bold)
        Dim fuenteCuerpo As New Font("Segoe UI", 8.5F, FontStyle.Regular)
        Dim fuenteTotales As New Font("Segoe UI", 9.5F, FontStyle.Bold)

        Dim y As Integer = 40
        Dim margenIzq As Integer = 40

        e.Graphics.DrawString("HOTEL TEKOHA - REPORTE DE GESTIÓN Y RESERVAS", fuenteTitulo, Brushes.Black, margenIzq, y)
        y += 25
        e.Graphics.DrawString("Período: " & dtpFechaDesde.Value.ToShortDateString() & " al " & dtpFechaHasta.Value.ToShortDateString() & " | Generado: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuenteSubtitulo, Brushes.DimGray, margenIzq, y)
        y += 20
        e.Graphics.DrawLine(Pens.Black, margenIzq, y, 780, y)
        y += 15

        e.Graphics.DrawString("Nro", fuenteEncabezado, Brushes.Black, margenIzq, y)
        e.Graphics.DrawString("Huésped", fuenteEncabezado, Brushes.Black, margenIzq + 40, y)
        e.Graphics.DrawString("Habitación", fuenteEncabezado, Brushes.Black, margenIzq + 230, y)
        e.Graphics.DrawString("Tarifa", fuenteEncabezado, Brushes.Black, margenIzq + 360, y)
        e.Graphics.DrawString("Fecha Creación", fuenteEncabezado, Brushes.Black, margenIzq + 480, y)
        e.Graphics.DrawString("Estado", fuenteEncabezado, Brushes.Black, margenIzq + 630, y)
        y += 20
        e.Graphics.DrawLine(Pens.LightGray, margenIzq, y, 780, y)
        y += 8

        For Each fila As DataRow In dtUltimaConsulta.Rows
            If y > 980 Then Exit For

            e.Graphics.DrawString(fila("Nro Reserva").ToString(), fuenteCuerpo, Brushes.Black, margenIzq, y)
            e.Graphics.DrawString(fila("Huésped").ToString(), fuenteCuerpo, Brushes.Black, margenIzq + 40, y)
            e.Graphics.DrawString(fila("Habitación").ToString() & " (" & fila("Tipo").ToString() & ")", fuenteCuerpo, Brushes.Black, margenIzq + 230, y)
            e.Graphics.DrawString(Convert.ToDecimal(fila("Tarifa Diaria")).ToString("C2"), fuenteCuerpo, Brushes.Black, margenIzq + 360, y)
            e.Graphics.DrawString(Convert.ToDateTime(fila("Fecha Creación")).ToShortDateString(), fuenteCuerpo, Brushes.Black, margenIzq + 480, y)
            e.Graphics.DrawString(fila("Estado").ToString(), fuenteCuerpo, Brushes.Black, margenIzq + 630, y)

            y += 20
        Next

        y += 15
        e.Graphics.DrawLine(Pens.Black, margenIzq, y, 780, y)
        y += 10
        e.Graphics.DrawString("Total Reservas: " & statsActuales.TotalReservas & "  |  Confirmadas: " & statsActuales.TotalConfirmadas & "  |  Canceladas: " & statsActuales.TotalCanceladas, fuenteTotales, Brushes.Black, margenIzq, y)
        y += 20
        e.Graphics.DrawString("Suma Total de Tarifas: " & statsActuales.SumaTarifas.ToString("C2") & "  |  Tarifa Promedio: " & statsActuales.PromedioTarifa.ToString("C2"), fuenteTotales, Brushes.DarkBlue, margenIzq, y)
    End Sub
End Class