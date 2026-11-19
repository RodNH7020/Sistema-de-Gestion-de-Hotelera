<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioLogin
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioLogin))
        PanelIzquierdo = New System.Windows.Forms.Panel()
        lblSubtituloMarca = New System.Windows.Forms.Label()
        picLogo = New System.Windows.Forms.PictureBox()
        PanelDerecho = New System.Windows.Forms.Panel()
        BIniciarSesion = New System.Windows.Forms.Button()
        btnVerClave = New System.Windows.Forms.Button()
        TContraseña = New System.Windows.Forms.TextBox()
        LContraseña = New System.Windows.Forms.Label()
        TUsuario = New System.Windows.Forms.TextBox()
        LUsuario = New System.Windows.Forms.Label()
        lblSubtituloLogin = New System.Windows.Forms.Label()
        LLogin = New System.Windows.Forms.Label()
        PanelIzquierdo.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        PanelDerecho.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelIzquierdo
        ' 
        PanelIzquierdo.BackColor = Drawing.Color.FromArgb(CByte(24), CByte(24), CByte(24))
        PanelIzquierdo.Controls.Add(lblSubtituloMarca)
        PanelIzquierdo.Controls.Add(picLogo)
        PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left
        PanelIzquierdo.Location = New System.Drawing.Point(0, 0)
        PanelIzquierdo.Name = "PanelIzquierdo"
        PanelIzquierdo.Size = New System.Drawing.Size(420, 560)
        PanelIzquierdo.TabIndex = 0
        ' 
        ' lblSubtituloMarca
        ' 
        lblSubtituloMarca.Font = New System.Drawing.Font("Segoe UI", 9.5F)
        lblSubtituloMarca.ForeColor = Drawing.Color.Silver
        lblSubtituloMarca.Location = New System.Drawing.Point(37, 426)
        lblSubtituloMarca.Name = "lblSubtituloMarca"
        lblSubtituloMarca.Size = New System.Drawing.Size(350, 45)
        lblSubtituloMarca.TabIndex = 1
        lblSubtituloMarca.Text = "Sistema Integral de Gestión Hotelera" & vbCrLf & "Corrientes, Argentina"
        lblSubtituloMarca.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' picLogo
        ' 
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Drawing.Image)
        picLogo.Location = New System.Drawing.Point(-88, 0)
        picLogo.Name = "picLogo"
        picLogo.Size = New System.Drawing.Size(593, 493)
        picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 0
        picLogo.TabStop = False
        ' 
        ' PanelDerecho
        ' 
        PanelDerecho.BackColor = Drawing.Color.White
        PanelDerecho.Controls.Add(BIniciarSesion)
        PanelDerecho.Controls.Add(btnVerClave)
        PanelDerecho.Controls.Add(TContraseña)
        PanelDerecho.Controls.Add(LContraseña)
        PanelDerecho.Controls.Add(TUsuario)
        PanelDerecho.Controls.Add(LUsuario)
        PanelDerecho.Controls.Add(lblSubtituloLogin)
        PanelDerecho.Controls.Add(LLogin)
        PanelDerecho.Dock = System.Windows.Forms.DockStyle.Fill
        PanelDerecho.Location = New System.Drawing.Point(420, 0)
        PanelDerecho.Name = "PanelDerecho"
        PanelDerecho.Size = New System.Drawing.Size(500, 560)
        PanelDerecho.TabIndex = 1
        ' 
        ' BIniciarSesion
        ' 
        BIniciarSesion.BackColor = Drawing.Color.Crimson
        BIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        BIniciarSesion.FlatAppearance.BorderSize = 0
        BIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BIniciarSesion.Font = New System.Drawing.Font("Segoe UI", 11.0F, Drawing.FontStyle.Bold)
        BIniciarSesion.ForeColor = Drawing.Color.White
        BIniciarSesion.Location = New System.Drawing.Point(78, 345)
        BIniciarSesion.Name = "BIniciarSesion"
        BIniciarSesion.Size = New System.Drawing.Size(340, 42)
        BIniciarSesion.TabIndex = 7
        BIniciarSesion.Text = "INICIAR SESIÓN"
        BIniciarSesion.UseVisualStyleBackColor = False
        ' 
        ' btnVerClave
        ' 
        btnVerClave.BackColor = Drawing.Color.WhiteSmoke
        btnVerClave.Cursor = System.Windows.Forms.Cursors.Hand
        btnVerClave.FlatAppearance.BorderColor = Drawing.Color.Silver
        btnVerClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnVerClave.Font = New System.Drawing.Font("Segoe UI Emoji", 11.0F)
        btnVerClave.Location = New System.Drawing.Point(378, 280)
        btnVerClave.Name = "btnVerClave"
        btnVerClave.Size = New System.Drawing.Size(40, 27)
        btnVerClave.TabIndex = 6
        btnVerClave.TabStop = False
        btnVerClave.Text = "👁"
        btnVerClave.UseVisualStyleBackColor = False
        ' 
        ' TContraseña
        ' 
        TContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        TContraseña.Font = New System.Drawing.Font("Segoe UI", 11.0F)
        TContraseña.Location = New System.Drawing.Point(78, 280)
        TContraseña.Name = "TContraseña"
        TContraseña.Size = New System.Drawing.Size(298, 27)
        TContraseña.TabIndex = 5
        TContraseña.UseSystemPasswordChar = True
        ' 
        ' LContraseña
        ' 
        LContraseña.AutoSize = True
        LContraseña.Font = New System.Drawing.Font("Segoe UI", 10.0F, Drawing.FontStyle.Bold)
        LContraseña.ForeColor = Drawing.Color.FromArgb(CByte(45), CByte(45), CByte(45))
        LContraseña.Location = New System.Drawing.Point(78, 255)
        LContraseña.Name = "LContraseña"
        LContraseña.Size = New System.Drawing.Size(88, 19)
        LContraseña.TabIndex = 4
        LContraseña.Text = "Contraseña:"
        ' 
        ' TUsuario
        ' 
        TUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        TUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0F)
        TUsuario.Location = New System.Drawing.Point(78, 205)
        TUsuario.Name = "TUsuario"
        TUsuario.Size = New System.Drawing.Size(340, 27)
        TUsuario.TabIndex = 3
        ' 
        ' LUsuario
        ' 
        LUsuario.AutoSize = True
        LUsuario.Font = New System.Drawing.Font("Segoe UI", 10.0F, Drawing.FontStyle.Bold)
        LUsuario.ForeColor = Drawing.Color.FromArgb(CByte(45), CByte(45), CByte(45))
        LUsuario.Location = New System.Drawing.Point(78, 180)
        LUsuario.Name = "LUsuario"
        LUsuario.Size = New System.Drawing.Size(64, 19)
        LUsuario.TabIndex = 2
        LUsuario.Text = "Usuario:"
        ' 
        ' lblSubtituloLogin
        ' 
        lblSubtituloLogin.Font = New System.Drawing.Font("Segoe UI", 9.5F)
        lblSubtituloLogin.ForeColor = Drawing.Color.DimGray
        lblSubtituloLogin.Location = New System.Drawing.Point(78, 128)
        lblSubtituloLogin.Name = "lblSubtituloLogin"
        lblSubtituloLogin.Size = New System.Drawing.Size(340, 23)
        lblSubtituloLogin.TabIndex = 1
        lblSubtituloLogin.Text = "Ingrese sus datos para acceder al sistema"
        ' 
        ' LLogin
        ' 
        LLogin.Font = New System.Drawing.Font("Segoe UI", 20.0F, Drawing.FontStyle.Bold)
        LLogin.ForeColor = Drawing.Color.FromArgb(CByte(24), CByte(24), CByte(24))
        LLogin.Location = New System.Drawing.Point(75, 85)
        LLogin.Name = "LLogin"
        LLogin.Size = New System.Drawing.Size(350, 42)
        LLogin.TabIndex = 0
        LLogin.Text = "INICIO DE SESIÓN"
        LLogin.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' FormularioLogin
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(920, 560)
        Controls.Add(PanelDerecho)
        Controls.Add(PanelIzquierdo)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormularioLogin"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "LOGIN - Hotel Tekoha"
        PanelIzquierdo.ResumeLayout(False)
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        PanelDerecho.ResumeLayout(False)
        PanelDerecho.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelIzquierdo As System.Windows.Forms.Panel
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblSubtituloMarca As System.Windows.Forms.Label
    Friend WithEvents PanelDerecho As System.Windows.Forms.Panel
    Friend WithEvents LLogin As System.Windows.Forms.Label
    Friend WithEvents lblSubtituloLogin As System.Windows.Forms.Label
    Friend WithEvents LUsuario As System.Windows.Forms.Label
    Friend WithEvents TUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LContraseña As System.Windows.Forms.Label
    Friend WithEvents TContraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnVerClave As System.Windows.Forms.Button
    Friend WithEvents BIniciarSesion As System.Windows.Forms.Button
End Class