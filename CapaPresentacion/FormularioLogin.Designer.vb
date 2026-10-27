<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioLogin
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
        LLogin = New System.Windows.Forms.Label()
        LUsuario = New System.Windows.Forms.Label()
        LContraseña = New System.Windows.Forms.Label()
        TUsuario = New System.Windows.Forms.TextBox()
        TContraseña = New System.Windows.Forms.TextBox()
        BIniciarSesion = New System.Windows.Forms.Button()
        Panel1 = New System.Windows.Forms.Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LLogin
        ' 
        LLogin.Font = New System.Drawing.Font("Segoe UI", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        LLogin.ForeColor = Drawing.SystemColors.Window
        LLogin.Location = New System.Drawing.Point(239, 9)
        LLogin.Name = "LLogin"
        LLogin.Size = New System.Drawing.Size(171, 39)
        LLogin.TabIndex = 0
        LLogin.Text = "Iniciar Sesión"
        ' 
        ' LUsuario
        ' 
        LUsuario.AutoSize = True
        LUsuario.Location = New System.Drawing.Point(192, 102)
        LUsuario.Name = "LUsuario"
        LUsuario.Size = New System.Drawing.Size(50, 15)
        LUsuario.TabIndex = 1
        LUsuario.Text = "Usuario:"
        ' 
        ' LContraseña
        ' 
        LContraseña.AutoSize = True
        LContraseña.Location = New System.Drawing.Point(192, 155)
        LContraseña.Name = "LContraseña"
        LContraseña.Size = New System.Drawing.Size(70, 15)
        LContraseña.TabIndex = 2
        LContraseña.Text = "Contraseña:"
        ' 
        ' TUsuario
        ' 
        TUsuario.Location = New System.Drawing.Point(192, 120)
        TUsuario.Name = "TUsuario"
        TUsuario.Size = New System.Drawing.Size(240, 23)
        TUsuario.TabIndex = 3
        ' 
        ' TContraseña
        ' 
        TContraseña.Location = New System.Drawing.Point(192, 173)
        TContraseña.Name = "TContraseña"
        TContraseña.Size = New System.Drawing.Size(240, 23)
        TContraseña.TabIndex = 4
        TContraseña.UseSystemPasswordChar = True
        ' 
        ' BIniciarSesion
        ' 
        BIniciarSesion.BackColor = Drawing.Color.Crimson
        BIniciarSesion.Font = New System.Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        BIniciarSesion.ForeColor = Drawing.Color.Transparent
        BIniciarSesion.Location = New System.Drawing.Point(249, 223)
        BIniciarSesion.Name = "BIniciarSesion"
        BIniciarSesion.Size = New System.Drawing.Size(116, 23)
        BIniciarSesion.TabIndex = 5
        BIniciarSesion.Text = "Iniciar sesión"
        BIniciarSesion.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Drawing.Color.Black
        Panel1.Controls.Add(LLogin)
        Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Panel1.Location = New System.Drawing.Point(0, 0)
        Panel1.MaximumSize = New System.Drawing.Size(0, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(668, 50)
        Panel1.TabIndex = 6
        ' 
        ' FormularioLogin
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(668, 354)
        Controls.Add(Panel1)
        Controls.Add(BIniciarSesion)
        Controls.Add(TContraseña)
        Controls.Add(TUsuario)
        Controls.Add(LContraseña)
        Controls.Add(LUsuario)
        Name = "FormularioLogin"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LLogin As System.Windows.Forms.Label
    Friend WithEvents LUsuario As System.Windows.Forms.Label
    Friend WithEvents LContraseña As System.Windows.Forms.Label
    Friend WithEvents TUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TContraseña As System.Windows.Forms.TextBox
    Friend WithEvents BIniciarSesion As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
