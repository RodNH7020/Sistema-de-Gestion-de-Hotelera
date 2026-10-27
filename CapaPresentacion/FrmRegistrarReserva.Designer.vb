<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarReserva
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New System.Windows.Forms.Panel()
        TRegistrarReserva = New System.Windows.Forms.Label()
        LHuesped = New System.Windows.Forms.Label()
        COBHuesped = New System.Windows.Forms.ComboBox()
        LHabitacion = New System.Windows.Forms.Label()
        cboHabitacion = New System.Windows.Forms.ComboBox()
        LFechaIngreso = New System.Windows.Forms.Label()
        dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        LFechaSalida = New System.Windows.Forms.Label()
        BRegistrarReserva = New System.Windows.Forms.Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Drawing.Color.Black
        Panel1.Controls.Add(TRegistrarReserva)
        Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Panel1.Location = New System.Drawing.Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(800, 50)
        Panel1.TabIndex = 0
        ' 
        ' TRegistrarReserva
        ' 
        TRegistrarReserva.AutoSize = True
        TRegistrarReserva.Font = New System.Drawing.Font("Segoe UI", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        TRegistrarReserva.ForeColor = Drawing.Color.White
        TRegistrarReserva.Location = New System.Drawing.Point(297, 9)
        TRegistrarReserva.Name = "TRegistrarReserva"
        TRegistrarReserva.Size = New System.Drawing.Size(213, 32)
        TRegistrarReserva.TabIndex = 0
        TRegistrarReserva.Text = "Registrar Reserva"
        ' 
        ' LHuesped
        ' 
        LHuesped.AutoSize = True
        LHuesped.Location = New System.Drawing.Point(195, 80)
        LHuesped.Name = "LHuesped"
        LHuesped.Size = New System.Drawing.Size(57, 15)
        LHuesped.TabIndex = 1
        LHuesped.Text = "Huésped:"
        ' 
        ' COBHuesped
        ' 
        COBHuesped.FormattingEnabled = True
        COBHuesped.Location = New System.Drawing.Point(195, 98)
        COBHuesped.Name = "COBHuesped"
        COBHuesped.Size = New System.Drawing.Size(386, 23)
        COBHuesped.TabIndex = 2
        ' 
        ' LHabitacion
        ' 
        LHabitacion.AutoSize = True
        LHabitacion.Location = New System.Drawing.Point(195, 142)
        LHabitacion.Name = "LHabitacion"
        LHabitacion.Size = New System.Drawing.Size(68, 15)
        LHabitacion.TabIndex = 3
        LHabitacion.Text = "Habitación:"
        ' 
        ' cboHabitacion
        ' 
        cboHabitacion.FormattingEnabled = True
        cboHabitacion.Location = New System.Drawing.Point(195, 160)
        cboHabitacion.Name = "cboHabitacion"
        cboHabitacion.Size = New System.Drawing.Size(383, 23)
        cboHabitacion.TabIndex = 4
        ' 
        ' LFechaIngreso
        ' 
        LFechaIngreso.AutoSize = True
        LFechaIngreso.Location = New System.Drawing.Point(195, 207)
        LFechaIngreso.Name = "LFechaIngreso"
        LFechaIngreso.Size = New System.Drawing.Size(99, 15)
        LFechaIngreso.TabIndex = 5
        LFechaIngreso.Text = "Fecha de ingreso:"
        ' 
        ' dtpFechaIngreso
        ' 
        dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short
        dtpFechaIngreso.Location = New System.Drawing.Point(195, 225)
        dtpFechaIngreso.Name = "dtpFechaIngreso"
        dtpFechaIngreso.Size = New System.Drawing.Size(386, 23)
        dtpFechaIngreso.TabIndex = 6
        ' 
        ' dtpFechaSalida
        ' 
        dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short
        dtpFechaSalida.Location = New System.Drawing.Point(195, 289)
        dtpFechaSalida.Name = "dtpFechaSalida"
        dtpFechaSalida.Size = New System.Drawing.Size(386, 23)
        dtpFechaSalida.TabIndex = 8
        ' 
        ' LFechaSalida
        ' 
        LFechaSalida.AutoSize = True
        LFechaSalida.Location = New System.Drawing.Point(195, 271)
        LFechaSalida.Name = "LFechaSalida"
        LFechaSalida.Size = New System.Drawing.Size(90, 15)
        LFechaSalida.TabIndex = 7
        LFechaSalida.Text = "Fecha de salida:"
        ' 
        ' BRegistrarReserva
        ' 
        BRegistrarReserva.BackColor = Drawing.Color.Crimson
        BRegistrarReserva.Font = New System.Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        BRegistrarReserva.ForeColor = Drawing.Color.White
        BRegistrarReserva.Location = New System.Drawing.Point(297, 346)
        BRegistrarReserva.Name = "BRegistrarReserva"
        BRegistrarReserva.Size = New System.Drawing.Size(155, 23)
        BRegistrarReserva.TabIndex = 9
        BRegistrarReserva.Text = "Registrar Reserva"
        BRegistrarReserva.UseVisualStyleBackColor = False
        ' 
        ' FrmRegistrarReserva
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(BRegistrarReserva)
        Controls.Add(dtpFechaSalida)
        Controls.Add(LFechaSalida)
        Controls.Add(dtpFechaIngreso)
        Controls.Add(LFechaIngreso)
        Controls.Add(cboHabitacion)
        Controls.Add(LHabitacion)
        Controls.Add(COBHuesped)
        Controls.Add(LHuesped)
        Controls.Add(Panel1)
        Name = "FrmRegistrarReserva"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TRegistrarReserva As System.Windows.Forms.Label
    Friend WithEvents LHuesped As System.Windows.Forms.Label
    Friend WithEvents COBHuesped As System.Windows.Forms.ComboBox
    Friend WithEvents LHabitacion As System.Windows.Forms.Label
    Friend WithEvents cboHabitacion As System.Windows.Forms.ComboBox
    Friend WithEvents LFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents LFechaSalida As System.Windows.Forms.Label
    Friend WithEvents BRegistrarReserva As System.Windows.Forms.Button
End Class
