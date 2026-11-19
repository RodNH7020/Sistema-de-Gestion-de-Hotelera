<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionReservas
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents picIconoHeader As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblSubtituloHeader As System.Windows.Forms.Label
    Friend WithEvents grpBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHabitacion As System.Windows.Forms.Label
    Friend WithEvents cboHabitacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents dgvReservas As System.Windows.Forms.DataGridView
    Friend WithEvents grpEstadisticas As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalReservas As System.Windows.Forms.Label
    Friend WithEvents lblConfirmadas As System.Windows.Forms.Label
    Friend WithEvents lblCanceladas As System.Windows.Forms.Label
    Friend WithEvents lblSumaTarifas As System.Windows.Forms.Label
    Friend WithEvents lblPromedioTarifa As System.Windows.Forms.Label
    Friend WithEvents pnlMensajeExito As System.Windows.Forms.Panel
    Friend WithEvents lblMensajeExito As System.Windows.Forms.Label
    Friend WithEvents pnlMensajeError As System.Windows.Forms.Panel
    Friend WithEvents lblMensajeError As System.Windows.Forms.Label
    Friend WithEvents prtDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents prtDialog As System.Windows.Forms.PrintPreviewDialog

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionReservas))
        pnlHeader = New System.Windows.Forms.Panel()
        lblSubtituloHeader = New System.Windows.Forms.Label()
        lblTitulo = New System.Windows.Forms.Label()
        picIconoHeader = New System.Windows.Forms.PictureBox()
        grpBusqueda = New System.Windows.Forms.GroupBox()
        lblDesde = New System.Windows.Forms.Label()
        dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        lblHasta = New System.Windows.Forms.Label()
        dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        lblHabitacion = New System.Windows.Forms.Label()
        cboHabitacion = New System.Windows.Forms.ComboBox()
        lblUsuario = New System.Windows.Forms.Label()
        cboUsuario = New System.Windows.Forms.ComboBox()
        btnBuscar = New System.Windows.Forms.Button()
        btnImprimir = New System.Windows.Forms.Button()
        dgvReservas = New System.Windows.Forms.DataGridView()
        grpEstadisticas = New System.Windows.Forms.GroupBox()
        lblTotalReservas = New System.Windows.Forms.Label()
        lblConfirmadas = New System.Windows.Forms.Label()
        lblCanceladas = New System.Windows.Forms.Label()
        lblSumaTarifas = New System.Windows.Forms.Label()
        lblPromedioTarifa = New System.Windows.Forms.Label()
        pnlMensajeExito = New System.Windows.Forms.Panel()
        lblMensajeExito = New System.Windows.Forms.Label()
        pnlMensajeError = New System.Windows.Forms.Panel()
        lblMensajeError = New System.Windows.Forms.Label()
        prtDoc = New Drawing.Printing.PrintDocument()
        prtDialog = New System.Windows.Forms.PrintPreviewDialog()
        pnlHeader.SuspendLayout()
        CType(picIconoHeader, ComponentModel.ISupportInitialize).BeginInit()
        grpBusqueda.SuspendLayout()
        CType(dgvReservas, ComponentModel.ISupportInitialize).BeginInit()
        grpEstadisticas.SuspendLayout()
        pnlMensajeExito.SuspendLayout()
        pnlMensajeError.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Drawing.Color.FromArgb(CByte(24), CByte(24), CByte(24))
        pnlHeader.Controls.Add(lblSubtituloHeader)
        pnlHeader.Controls.Add(lblTitulo)
        pnlHeader.Controls.Add(picIconoHeader)
        pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New System.Drawing.Size(920, 56)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubtituloHeader
        ' 
        lblSubtituloHeader.AutoSize = True
        lblSubtituloHeader.Font = New System.Drawing.Font("Segoe UI", 8.5F)
        lblSubtituloHeader.ForeColor = Drawing.Color.Silver
        lblSubtituloHeader.Location = New System.Drawing.Point(74, 33)
        lblSubtituloHeader.Name = "lblSubtituloHeader"
        lblSubtituloHeader.Size = New System.Drawing.Size(295, 15)
        lblSubtituloHeader.TabIndex = 2
        lblSubtituloHeader.Text = "Hotel Tekoha • Control de ocupación, tarifas y reportes"
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.5F, Drawing.FontStyle.Bold)
        lblTitulo.ForeColor = Drawing.Color.White
        lblTitulo.Location = New System.Drawing.Point(72, 7)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(308, 28)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "Gestión y Consulta de Reservas"
        ' 
        ' picIconoHeader
        ' 
        picIconoHeader.BackColor = Drawing.Color.Transparent
        picIconoHeader.Image = My.Resources.Resources.Gemini_Generated_Image_hn4yfghn4yfghn4y_removebg_preview
        picIconoHeader.Location = New System.Drawing.Point(-16, -9)
        picIconoHeader.Name = "picIconoHeader"
        picIconoHeader.Size = New System.Drawing.Size(116, 78)
        picIconoHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        picIconoHeader.TabIndex = 0
        picIconoHeader.TabStop = False
        ' 
        ' grpBusqueda
        ' 
        grpBusqueda.BackColor = Drawing.Color.White
        grpBusqueda.Controls.Add(lblDesde)
        grpBusqueda.Controls.Add(dtpFechaDesde)
        grpBusqueda.Controls.Add(lblHasta)
        grpBusqueda.Controls.Add(dtpFechaHasta)
        grpBusqueda.Controls.Add(lblHabitacion)
        grpBusqueda.Controls.Add(cboHabitacion)
        grpBusqueda.Controls.Add(lblUsuario)
        grpBusqueda.Controls.Add(cboUsuario)
        grpBusqueda.Controls.Add(btnBuscar)
        grpBusqueda.Controls.Add(btnImprimir)
        grpBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Bold)
        grpBusqueda.ForeColor = Drawing.Color.FromArgb(CByte(40), CByte(40), CByte(40))
        grpBusqueda.Location = New System.Drawing.Point(20, 66)
        grpBusqueda.Name = "grpBusqueda"
        grpBusqueda.Size = New System.Drawing.Size(880, 82)
        grpBusqueda.TabIndex = 1
        grpBusqueda.TabStop = False
        grpBusqueda.Text = "Filtros de Búsqueda"
        ' 
        ' lblDesde
        ' 
        lblDesde.AutoSize = True
        lblDesde.Font = New System.Drawing.Font("Segoe UI", 8.5F, Drawing.FontStyle.Bold)
        lblDesde.Location = New System.Drawing.Point(14, 22)
        lblDesde.Name = "lblDesde"
        lblDesde.Size = New System.Drawing.Size(80, 15)
        lblDesde.TabIndex = 0
        lblDesde.Text = "Fecha Desde:"
        ' 
        ' dtpFechaDesde
        ' 
        dtpFechaDesde.CalendarMonthBackground = Drawing.Color.White
        dtpFechaDesde.CalendarTitleBackColor = Drawing.Color.FromArgb(CByte(24), CByte(24), CByte(24))
        dtpFechaDesde.CalendarTitleForeColor = Drawing.Color.White
        dtpFechaDesde.CalendarTrailingForeColor = Drawing.Color.Gray
        dtpFechaDesde.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short
        dtpFechaDesde.Location = New System.Drawing.Point(14, 42)
        dtpFechaDesde.Name = "dtpFechaDesde"
        dtpFechaDesde.Size = New System.Drawing.Size(102, 23)
        dtpFechaDesde.TabIndex = 0
        ' 
        ' lblHasta
        ' 
        lblHasta.AutoSize = True
        lblHasta.Font = New System.Drawing.Font("Segoe UI", 8.5F, Drawing.FontStyle.Bold)
        lblHasta.Location = New System.Drawing.Point(126, 22)
        lblHasta.Name = "lblHasta"
        lblHasta.Size = New System.Drawing.Size(76, 15)
        lblHasta.TabIndex = 1
        lblHasta.Text = "Fecha Hasta:"
        ' 
        ' dtpFechaHasta
        ' 
        dtpFechaHasta.CalendarMonthBackground = Drawing.Color.White
        dtpFechaHasta.CalendarTitleBackColor = Drawing.Color.FromArgb(CByte(24), CByte(24), CByte(24))
        dtpFechaHasta.CalendarTitleForeColor = Drawing.Color.White
        dtpFechaHasta.CalendarTrailingForeColor = Drawing.Color.Gray
        dtpFechaHasta.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short
        dtpFechaHasta.Location = New System.Drawing.Point(126, 42)
        dtpFechaHasta.Name = "dtpFechaHasta"
        dtpFechaHasta.Size = New System.Drawing.Size(102, 23)
        dtpFechaHasta.TabIndex = 1
        ' 
        ' lblHabitacion
        ' 
        lblHabitacion.AutoSize = True
        lblHabitacion.Font = New System.Drawing.Font("Segoe UI", 8.5F, Drawing.FontStyle.Bold)
        lblHabitacion.Location = New System.Drawing.Point(238, 22)
        lblHabitacion.Name = "lblHabitacion"
        lblHabitacion.Size = New System.Drawing.Size(69, 15)
        lblHabitacion.TabIndex = 2
        lblHabitacion.Text = "Habitación:"
        ' 
        ' cboHabitacion
        ' 
        cboHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboHabitacion.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        cboHabitacion.Location = New System.Drawing.Point(238, 42)
        cboHabitacion.Name = "cboHabitacion"
        cboHabitacion.Size = New System.Drawing.Size(170, 23)
        cboHabitacion.TabIndex = 2
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New System.Drawing.Font("Segoe UI", 8.5F, Drawing.FontStyle.Bold)
        lblUsuario.Location = New System.Drawing.Point(418, 22)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New System.Drawing.Size(126, 15)
        lblUsuario.TabIndex = 3
        lblUsuario.Text = "Personal / Recepción:"
        ' 
        ' cboUsuario
        ' 
        cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        cboUsuario.Location = New System.Drawing.Point(418, 42)
        cboUsuario.Name = "cboUsuario"
        cboUsuario.Size = New System.Drawing.Size(165, 23)
        cboUsuario.TabIndex = 3
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Drawing.Color.Crimson
        btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Bold)
        btnBuscar.ForeColor = Drawing.Color.White
        btnBuscar.Location = New System.Drawing.Point(596, 39)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New System.Drawing.Size(125, 29)
        btnBuscar.TabIndex = 4
        btnBuscar.Text = "Buscar / Filtrar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnImprimir
        ' 
        btnImprimir.BackColor = Drawing.Color.FromArgb(CByte(35), CByte(35), CByte(35))
        btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        btnImprimir.FlatAppearance.BorderSize = 0
        btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnImprimir.Font = New System.Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Bold)
        btnImprimir.ForeColor = Drawing.Color.White
        btnImprimir.Location = New System.Drawing.Point(730, 39)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New System.Drawing.Size(136, 29)
        btnImprimir.TabIndex = 5
        btnImprimir.Text = "Imprimir Reporte"
        btnImprimir.UseVisualStyleBackColor = False
        ' 
        ' dgvReservas
        ' 
        dgvReservas.AllowUserToAddRows = False
        dgvReservas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Drawing.Color.FromArgb(CByte(248), CByte(249), CByte(250))
        dgvReservas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvReservas.BackgroundColor = Drawing.Color.White
        dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        dgvReservas.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        dgvReservas.GridColor = Drawing.Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgvReservas.Location = New System.Drawing.Point(20, 158)
        dgvReservas.Name = "dgvReservas"
        dgvReservas.ReadOnly = True
        dgvReservas.RowHeadersVisible = False
        dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvReservas.Size = New System.Drawing.Size(880, 265)
        dgvReservas.TabIndex = 2
        ' 
        ' grpEstadisticas
        ' 
        grpEstadisticas.BackColor = Drawing.Color.White
        grpEstadisticas.Controls.Add(lblTotalReservas)
        grpEstadisticas.Controls.Add(lblConfirmadas)
        grpEstadisticas.Controls.Add(lblCanceladas)
        grpEstadisticas.Controls.Add(lblSumaTarifas)
        grpEstadisticas.Controls.Add(lblPromedioTarifa)
        grpEstadisticas.Font = New System.Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Bold)
        grpEstadisticas.ForeColor = Drawing.Color.FromArgb(CByte(40), CByte(40), CByte(40))
        grpEstadisticas.Location = New System.Drawing.Point(20, 432)
        grpEstadisticas.Name = "grpEstadisticas"
        grpEstadisticas.Size = New System.Drawing.Size(880, 64)
        grpEstadisticas.TabIndex = 3
        grpEstadisticas.TabStop = False
        grpEstadisticas.Text = "Resumen y Estadísticas del Período"
        ' 
        ' lblTotalReservas
        ' 
        lblTotalReservas.AutoSize = True
        lblTotalReservas.Font = New System.Drawing.Font("Segoe UI", 9.5F, Drawing.FontStyle.Bold)
        lblTotalReservas.ForeColor = Drawing.Color.FromArgb(CByte(24), CByte(24), CByte(24))
        lblTotalReservas.Location = New System.Drawing.Point(18, 27)
        lblTotalReservas.Name = "lblTotalReservas"
        lblTotalReservas.Size = New System.Drawing.Size(77, 17)
        lblTotalReservas.TabIndex = 0
        lblTotalReservas.Text = "Reservas: 0"
        ' 
        ' lblConfirmadas
        ' 
        lblConfirmadas.AutoSize = True
        lblConfirmadas.Font = New System.Drawing.Font("Segoe UI", 9.5F, Drawing.FontStyle.Bold)
        lblConfirmadas.ForeColor = Drawing.Color.FromArgb(CByte(21), CByte(115), CByte(71))
        lblConfirmadas.Location = New System.Drawing.Point(145, 27)
        lblConfirmadas.Name = "lblConfirmadas"
        lblConfirmadas.Size = New System.Drawing.Size(101, 17)
        lblConfirmadas.TabIndex = 1
        lblConfirmadas.Text = "Confirmadas: 0"
        ' 
        ' lblCanceladas
        ' 
        lblCanceladas.AutoSize = True
        lblCanceladas.Font = New System.Drawing.Font("Segoe UI", 9.5F, Drawing.FontStyle.Bold)
        lblCanceladas.ForeColor = Drawing.Color.Crimson
        lblCanceladas.Location = New System.Drawing.Point(295, 27)
        lblCanceladas.Name = "lblCanceladas"
        lblCanceladas.Size = New System.Drawing.Size(91, 17)
        lblCanceladas.TabIndex = 2
        lblCanceladas.Text = "Canceladas: 0"
        ' 
        ' lblSumaTarifas
        ' 
        lblSumaTarifas.AutoSize = True
        lblSumaTarifas.Font = New System.Drawing.Font("Segoe UI", 9.5F, Drawing.FontStyle.Bold)
        lblSumaTarifas.ForeColor = Drawing.Color.FromArgb(CByte(24), CByte(24), CByte(24))
        lblSumaTarifas.Location = New System.Drawing.Point(435, 27)
        lblSumaTarifas.Name = "lblSumaTarifas"
        lblSumaTarifas.Size = New System.Drawing.Size(121, 17)
        lblSumaTarifas.TabIndex = 3
        lblSumaTarifas.Text = "Suma Total: $ 0,00"
        ' 
        ' lblPromedioTarifa
        ' 
        lblPromedioTarifa.AutoSize = True
        lblPromedioTarifa.Font = New System.Drawing.Font("Segoe UI", 9.5F, Drawing.FontStyle.Bold)
        lblPromedioTarifa.ForeColor = Drawing.Color.FromArgb(CByte(60), CByte(60), CByte(60))
        lblPromedioTarifa.Location = New System.Drawing.Point(665, 27)
        lblPromedioTarifa.Name = "lblPromedioTarifa"
        lblPromedioTarifa.Size = New System.Drawing.Size(151, 17)
        lblPromedioTarifa.TabIndex = 4
        lblPromedioTarifa.Text = "Tarifa Promedio: $ 0,00"
        ' 
        ' pnlMensajeExito
        ' 
        pnlMensajeExito.BackColor = Drawing.Color.FromArgb(CByte(212), CByte(237), CByte(218))
        pnlMensajeExito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlMensajeExito.Controls.Add(lblMensajeExito)
        pnlMensajeExito.Location = New System.Drawing.Point(20, 506)
        pnlMensajeExito.Name = "pnlMensajeExito"
        pnlMensajeExito.Size = New System.Drawing.Size(880, 32)
        pnlMensajeExito.TabIndex = 4
        pnlMensajeExito.Visible = False
        ' 
        ' lblMensajeExito
        ' 
        lblMensajeExito.Dock = System.Windows.Forms.DockStyle.Fill
        lblMensajeExito.Font = New System.Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Bold)
        lblMensajeExito.ForeColor = Drawing.Color.FromArgb(CByte(21), CByte(87), CByte(36))
        lblMensajeExito.Location = New System.Drawing.Point(0, 0)
        lblMensajeExito.Name = "lblMensajeExito"
        lblMensajeExito.Size = New System.Drawing.Size(878, 30)
        lblMensajeExito.TabIndex = 0
        lblMensajeExito.Text = "✓ Reporte generado correctamente."
        lblMensajeExito.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' pnlMensajeError
        ' 
        pnlMensajeError.BackColor = Drawing.Color.FromArgb(CByte(248), CByte(215), CByte(218))
        pnlMensajeError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pnlMensajeError.Controls.Add(lblMensajeError)
        pnlMensajeError.Location = New System.Drawing.Point(20, 506)
        pnlMensajeError.Name = "pnlMensajeError"
        pnlMensajeError.Size = New System.Drawing.Size(880, 32)
        pnlMensajeError.TabIndex = 5
        pnlMensajeError.Visible = False
        ' 
        ' lblMensajeError
        ' 
        lblMensajeError.Dock = System.Windows.Forms.DockStyle.Fill
        lblMensajeError.Font = New System.Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Bold)
        lblMensajeError.ForeColor = Drawing.Color.FromArgb(CByte(114), CByte(28), CByte(36))
        lblMensajeError.Location = New System.Drawing.Point(0, 0)
        lblMensajeError.Name = "lblMensajeError"
        lblMensajeError.Size = New System.Drawing.Size(878, 30)
        lblMensajeError.TabIndex = 0
        lblMensajeError.Text = "⚠ No existen reservas ni estadías para el período seleccionado."
        lblMensajeError.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' prtDoc
        ' 
        ' 
        ' prtDialog
        ' 
        prtDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        prtDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        prtDialog.ClientSize = New System.Drawing.Size(400, 300)
        prtDialog.Document = prtDoc
        prtDialog.Enabled = True
        prtDialog.Icon = CType(resources.GetObject("prtDialog.Icon"), Drawing.Icon)
        prtDialog.Name = "prtDialog"
        prtDialog.Visible = False
        ' 
        ' FrmGestionReservas
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = Drawing.Color.FromArgb(CByte(245), CByte(246), CByte(248))
        ClientSize = New System.Drawing.Size(920, 560)
        Controls.Add(pnlHeader)
        Controls.Add(grpBusqueda)
        Controls.Add(dgvReservas)
        Controls.Add(grpEstadisticas)
        Controls.Add(pnlMensajeExito)
        Controls.Add(pnlMensajeError)
        Font = New System.Drawing.Font("Segoe UI", 9.0F)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmGestionReservas"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Gestión y Reporte de Reservas - Hotel Tekoha"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(picIconoHeader, ComponentModel.ISupportInitialize).EndInit()
        grpBusqueda.ResumeLayout(False)
        grpBusqueda.PerformLayout()
        CType(dgvReservas, ComponentModel.ISupportInitialize).EndInit()
        grpEstadisticas.ResumeLayout(False)
        grpEstadisticas.PerformLayout()
        pnlMensajeExito.ResumeLayout(False)
        pnlMensajeError.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
End Class