<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnularReserva
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
        LBuscar = New System.Windows.Forms.Label()
        TBuscar = New System.Windows.Forms.TextBox()
        BAnularReserva = New System.Windows.Forms.Button()
        dgvReservas = New System.Windows.Forms.DataGridView()
        Panel1.SuspendLayout()
        CType(dgvReservas, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.TabIndex = 1
        ' 
        ' TRegistrarReserva
        ' 
        TRegistrarReserva.AutoSize = True
        TRegistrarReserva.Font = New System.Drawing.Font("Segoe UI", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        TRegistrarReserva.ForeColor = Drawing.Color.White
        TRegistrarReserva.Location = New System.Drawing.Point(297, 9)
        TRegistrarReserva.Name = "TRegistrarReserva"
        TRegistrarReserva.Size = New System.Drawing.Size(187, 32)
        TRegistrarReserva.TabIndex = 0
        TRegistrarReserva.Text = "Anular Reserva"
        ' 
        ' LBuscar
        ' 
        LBuscar.AutoSize = True
        LBuscar.Location = New System.Drawing.Point(269, 104)
        LBuscar.Name = "LBuscar"
        LBuscar.Size = New System.Drawing.Size(153, 15)
        LBuscar.TabIndex = 3
        LBuscar.Text = "Buscar Huéped/Habitación:"
        ' 
        ' TBuscar
        ' 
        TBuscar.Location = New System.Drawing.Point(269, 122)
        TBuscar.Name = "TBuscar"
        TBuscar.Size = New System.Drawing.Size(240, 23)
        TBuscar.TabIndex = 4
        ' 
        ' BAnularReserva
        ' 
        BAnularReserva.BackColor = Drawing.Color.Crimson
        BAnularReserva.Font = New System.Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        BAnularReserva.ForeColor = Drawing.Color.White
        BAnularReserva.Location = New System.Drawing.Point(327, 363)
        BAnularReserva.Name = "BAnularReserva"
        BAnularReserva.Size = New System.Drawing.Size(116, 23)
        BAnularReserva.TabIndex = 5
        BAnularReserva.Text = "Anular Reserva"
        BAnularReserva.UseVisualStyleBackColor = False
        ' 
        ' dgvReservas
        ' 
        dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReservas.Location = New System.Drawing.Point(269, 170)
        dgvReservas.Name = "dgvReservas"
        dgvReservas.Size = New System.Drawing.Size(240, 150)
        dgvReservas.TabIndex = 6
        ' 
        ' FrmAnularReserva
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(dgvReservas)
        Controls.Add(BAnularReserva)
        Controls.Add(TBuscar)
        Controls.Add(LBuscar)
        Controls.Add(Panel1)
        Name = "FrmAnularReserva"
        Text = "FrmAnularReserva"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvReservas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TRegistrarReserva As System.Windows.Forms.Label
    Friend WithEvents LBuscar As System.Windows.Forms.Label
    Friend WithEvents TBuscar As System.Windows.Forms.TextBox
    Friend WithEvents BAnularReserva As System.Windows.Forms.Button
    Friend WithEvents dgvReservas As System.Windows.Forms.DataGridView
End Class
