<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPrincipal
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
        TMenu = New System.Windows.Forms.Label()
        btnMenuRegistrar = New System.Windows.Forms.Button()
        btnMenuAnular = New System.Windows.Forms.Button()
        btnCerrarSesion = New System.Windows.Forms.Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Drawing.Color.Black
        Panel1.Controls.Add(TMenu)
        Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Panel1.Location = New System.Drawing.Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(800, 50)
        Panel1.TabIndex = 2
        ' 
        ' TMenu
        ' 
        TMenu.AutoSize = True
        TMenu.Font = New System.Drawing.Font("Segoe UI", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        TMenu.ForeColor = Drawing.Color.White
        TMenu.Location = New System.Drawing.Point(297, 9)
        TMenu.Name = "TMenu"
        TMenu.Size = New System.Drawing.Size(188, 32)
        TMenu.TabIndex = 0
        TMenu.Text = "Menú Principal"
        ' 
        ' btnMenuRegistrar
        ' 
        btnMenuRegistrar.BackColor = Drawing.Color.Crimson
        btnMenuRegistrar.Font = New System.Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnMenuRegistrar.ForeColor = Drawing.Color.White
        btnMenuRegistrar.Location = New System.Drawing.Point(297, 118)
        btnMenuRegistrar.Name = "btnMenuRegistrar"
        btnMenuRegistrar.Size = New System.Drawing.Size(175, 40)
        btnMenuRegistrar.TabIndex = 7
        btnMenuRegistrar.Text = "Registrar reserva"
        btnMenuRegistrar.UseVisualStyleBackColor = False
        ' 
        ' btnMenuAnular
        ' 
        btnMenuAnular.BackColor = Drawing.Color.Crimson
        btnMenuAnular.Font = New System.Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnMenuAnular.ForeColor = Drawing.Color.White
        btnMenuAnular.Location = New System.Drawing.Point(297, 164)
        btnMenuAnular.Name = "btnMenuAnular"
        btnMenuAnular.Size = New System.Drawing.Size(175, 40)
        btnMenuAnular.TabIndex = 8
        btnMenuAnular.Text = "Anular Reserva"
        btnMenuAnular.UseVisualStyleBackColor = False
        ' 
        ' btnCerrarSesion
        ' 
        btnCerrarSesion.BackColor = Drawing.Color.Crimson
        btnCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        btnCerrarSesion.ForeColor = Drawing.Color.White
        btnCerrarSesion.Location = New System.Drawing.Point(297, 359)
        btnCerrarSesion.Name = "btnCerrarSesion"
        btnCerrarSesion.Size = New System.Drawing.Size(175, 40)
        btnCerrarSesion.TabIndex = 9
        btnCerrarSesion.Text = "Cerrar sesión"
        btnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' FrmMenuPrincipal
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(btnCerrarSesion)
        Controls.Add(btnMenuAnular)
        Controls.Add(btnMenuRegistrar)
        Controls.Add(Panel1)
        Name = "FrmMenuPrincipal"
        Text = "FrmMenuPrincipal"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TMenu As System.Windows.Forms.Label
    Friend WithEvents btnMenuRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnMenuAnular As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
End Class
