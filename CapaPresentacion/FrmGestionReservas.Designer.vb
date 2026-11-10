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
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grpBusqueda = New System.Windows.Forms.GroupBox()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHabitacion = New System.Windows.Forms.Label()
        Me.cboHabitacion = New System.Windows.Forms.ComboBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.dgvReservas = New System.Windows.Forms.DataGridView()
        Me.grpEstadisticas = New System.Windows.Forms.GroupBox()
        Me.lblTotalReservas = New System.Windows.Forms.Label()
        Me.lblConfirmadas = New System.Windows.Forms.Label()
        Me.lblCanceladas = New System.Windows.Forms.Label()
        Me.lblSumaTarifas = New System.Windows.Forms.Label()
        Me.lblPromedioTarifa = New System.Windows.Forms.Label()
        Me.pnlMensajeExito = New System.Windows.Forms.Panel()
        Me.lblMensajeExito = New System.Windows.Forms.Label()
        Me.pnlMensajeError = New System.Windows.Forms.Panel()
        Me.lblMensajeError = New System.Windows.Forms.Label()
        Me.prtDoc = New System.Drawing.Printing.PrintDocument()
        Me.prtDialog = New System.Windows.Forms.PrintPreviewDialog()

        Me.pnlHeader.SuspendLayout()
        Me.grpBusqueda.SuspendLayout()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEstadisticas.SuspendLayout()
        Me.pnlMensajeExito.SuspendLayout()
        Me.pnlMensajeError.SuspendLayout()
        Me.SuspendLayout()

        ' Header Negro institucional
        Me.pnlHeader.BackColor = System.Drawing.Color.Black
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(990, 50)
        Me.pnlHeader.TabIndex = 0

        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(990, 50)
        Me.lblTitulo.Text = "Gestión y Consulta de Reservas"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' Filtros de Búsqueda
        Me.grpBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
        Me.grpBusqueda.Location = New System.Drawing.Point(20, 60)
        Me.grpBusqueda.Name = "grpBusqueda"
        Me.grpBusqueda.Size = New System.Drawing.Size(950, 85)
        Me.grpBusqueda.TabIndex = 1
        Me.grpBusqueda.TabStop = False
        Me.grpBusqueda.Text = "Filtros de Búsqueda"

        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(15, 23)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(76, 15)
        Me.lblDesde.Text = "Fecha Desde:"

        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaDesde.Location = New System.Drawing.Point(18, 44)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaDesde.TabIndex = 0

        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(128, 23)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(74, 15)
        Me.lblHasta.Text = "Fecha Hasta:"

        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaHasta.Location = New System.Drawing.Point(131, 44)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(100, 23)
        Me.dtpFechaHasta.TabIndex = 1

        Me.lblHabitacion.AutoSize = True
        Me.lblHabitacion.Location = New System.Drawing.Point(240, 23)
        Me.lblHabitacion.Name = "lblHabitacion"
        Me.lblHabitacion.Size = New System.Drawing.Size(68, 15)
        Me.lblHabitacion.Text = "Habitación:"

        Me.cboHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHabitacion.Location = New System.Drawing.Point(243, 44)
        Me.cboHabitacion.Name = "cboHabitacion"
        Me.cboHabitacion.Size = New System.Drawing.Size(175, 23)
        Me.cboHabitacion.TabIndex = 2

        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(428, 23)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(123, 15)
        Me.lblUsuario.Text = "Personal / Recepción:"

        Me.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuario.Location = New System.Drawing.Point(431, 44)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(175, 23)
        Me.cboUsuario.TabIndex = 3

        ' Botón Buscar Rojo Carmesí
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(204, 0, 51)
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(630, 41)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(130, 28)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar / Filtrar"
        Me.btnBuscar.UseVisualStyleBackColor = False

        ' Botón Imprimir Grafito Oscuro
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(775, 41)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(155, 28)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "🖶 Imprimir Reporte"
        Me.btnImprimir.UseVisualStyleBackColor = False

        Me.grpBusqueda.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDesde, Me.dtpFechaDesde, Me.lblHasta, Me.dtpFechaHasta, Me.lblHabitacion, Me.cboHabitacion, Me.lblUsuario, Me.cboUsuario, Me.btnBuscar, Me.btnImprimir})

        ' Grilla de Resultados
        Me.dgvReservas.AllowUserToAddRows = False
        Me.dgvReservas.AllowUserToDeleteRows = False
        Me.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservas.BackgroundColor = System.Drawing.Color.White
        Me.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvReservas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvReservas.Location = New System.Drawing.Point(20, 155)
        Me.dgvReservas.Name = "dgvReservas"
        Me.dgvReservas.ReadOnly = True
        Me.dgvReservas.RowHeadersVisible = False
        Me.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservas.Size = New System.Drawing.Size(950, 255)
        Me.dgvReservas.TabIndex = 2

        ' Recuadro Inferior de Estadísticas
        Me.grpEstadisticas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
        Me.grpEstadisticas.Location = New System.Drawing.Point(20, 420)
        Me.grpEstadisticas.Name = "grpEstadisticas"
        Me.grpEstadisticas.Size = New System.Drawing.Size(950, 68)
        Me.grpEstadisticas.TabIndex = 3
        Me.grpEstadisticas.TabStop = False
        Me.grpEstadisticas.Text = "Resumen y Estadísticas del Período"

        Me.lblTotalReservas.AutoSize = True
        Me.lblTotalReservas.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblTotalReservas.ForeColor = System.Drawing.Color.Black
        Me.lblTotalReservas.Location = New System.Drawing.Point(20, 28)
        Me.lblTotalReservas.Name = "lblTotalReservas"
        Me.lblTotalReservas.Size = New System.Drawing.Size(89, 17)
        Me.lblTotalReservas.Text = "Reservas: 0"

        Me.lblConfirmadas.AutoSize = True
        Me.lblConfirmadas.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblConfirmadas.ForeColor = System.Drawing.Color.FromArgb(21, 87, 36)
        Me.lblConfirmadas.Location = New System.Drawing.Point(155, 28)
        Me.lblConfirmadas.Name = "lblConfirmadas"
        Me.lblConfirmadas.Size = New System.Drawing.Size(107, 17)
        Me.lblConfirmadas.Text = "Confirmadas: 0"

        Me.lblCanceladas.AutoSize = True
        Me.lblCanceladas.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblCanceladas.ForeColor = System.Drawing.Color.FromArgb(204, 0, 51)
        Me.lblCanceladas.Location = New System.Drawing.Point(310, 28)
        Me.lblCanceladas.Name = "lblCanceladas"
        Me.lblCanceladas.Size = New System.Drawing.Size(97, 17)
        Me.lblCanceladas.Text = "Canceladas: 0"

        Me.lblSumaTarifas.AutoSize = True
        Me.lblSumaTarifas.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSumaTarifas.ForeColor = System.Drawing.Color.Black
        Me.lblSumaTarifas.Location = New System.Drawing.Point(460, 28)
        Me.lblSumaTarifas.Name = "lblSumaTarifas"
        Me.lblSumaTarifas.Size = New System.Drawing.Size(161, 17)
        Me.lblSumaTarifas.Text = "Suma Total: $ 0,00"

        Me.lblPromedioTarifa.AutoSize = True
        Me.lblPromedioTarifa.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblPromedioTarifa.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.lblPromedioTarifa.Location = New System.Drawing.Point(710, 28)
        Me.lblPromedioTarifa.Name = "lblPromedioTarifa"
        Me.lblPromedioTarifa.Size = New System.Drawing.Size(185, 17)
        Me.lblPromedioTarifa.Text = "Tarifa Promedio: $ 0,00"

        Me.grpEstadisticas.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblTotalReservas, Me.lblConfirmadas, Me.lblCanceladas, Me.lblSumaTarifas, Me.lblPromedioTarifa})

        ' Banner Verde
        Me.pnlMensajeExito.BackColor = System.Drawing.Color.FromArgb(212, 237, 218)
        Me.pnlMensajeExito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMensajeExito.Controls.Add(Me.lblMensajeExito)
        Me.pnlMensajeExito.Location = New System.Drawing.Point(20, 498)
        Me.pnlMensajeExito.Name = "pnlMensajeExito"
        Me.pnlMensajeExito.Size = New System.Drawing.Size(950, 30)
        Me.pnlMensajeExito.TabIndex = 4
        Me.pnlMensajeExito.Visible = False

        Me.lblMensajeExito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMensajeExito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeExito.ForeColor = System.Drawing.Color.FromArgb(21, 87, 36)
        Me.lblMensajeExito.Location = New System.Drawing.Point(0, 0)
        Me.lblMensajeExito.Name = "lblMensajeExito"
        Me.lblMensajeExito.Size = New System.Drawing.Size(948, 28)
        Me.lblMensajeExito.Text = "✓ Reporte generado correctamente."
        Me.lblMensajeExito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' Banner Rojo
        Me.pnlMensajeError.BackColor = System.Drawing.Color.FromArgb(248, 215, 218)
        Me.pnlMensajeError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMensajeError.Controls.Add(Me.lblMensajeError)
        Me.pnlMensajeError.Location = New System.Drawing.Point(20, 498)
        Me.pnlMensajeError.Name = "pnlMensajeError"
        Me.pnlMensajeError.Size = New System.Drawing.Size(950, 30)
        Me.pnlMensajeError.TabIndex = 5
        Me.pnlMensajeError.Visible = False

        Me.lblMensajeError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMensajeError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeError.ForeColor = System.Drawing.Color.FromArgb(114, 28, 36)
        Me.lblMensajeError.Location = New System.Drawing.Point(0, 0)
        Me.lblMensajeError.Name = "lblMensajeError"
        Me.lblMensajeError.Size = New System.Drawing.Size(948, 28)
        Me.lblMensajeError.Text = "⚠ No existen reservas ni estadías para el período seleccionado."
        Me.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.prtDialog.Document = Me.prtDoc

        ' Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 545)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Reservas - Hotel Tekoha"
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pnlHeader, Me.grpBusqueda, Me.dgvReservas, Me.grpEstadisticas, Me.pnlMensajeExito, Me.pnlMensajeError})

        Me.pnlHeader.ResumeLayout(False)
        Me.grpBusqueda.ResumeLayout(False)
        Me.grpBusqueda.PerformLayout()
        CType(Me.dgvReservas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEstadisticas.ResumeLayout(False)
        Me.grpEstadisticas.PerformLayout()
        Me.pnlMensajeExito.ResumeLayout(False)
        Me.pnlMensajeError.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
End Class