Imports System.Drawing
Imports System.Windows.Forms
Imports CapaNegocio
Imports SistemaHotelero

Public Class FormularioLogin
    Private claveVisible As Boolean = False

    Private Sub FormularioLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientSize = New Size(920, 560)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Text = "LOGIN - Hotel Tekoha"
        Me.AcceptButton = BIniciarSesion
        TUsuario.Focus()
    End Sub

    ' Botón ojito para mostrar / ocultar contraseña
    Private Sub btnVerClave_Click(sender As Object, e As EventArgs) Handles btnVerClave.Click
        claveVisible = Not claveVisible
        If claveVisible Then
            TContraseña.UseSystemPasswordChar = False
            btnVerClave.BackColor = Color.Gainsboro
        Else
            TContraseña.UseSystemPasswordChar = True
            btnVerClave.BackColor = Color.WhiteSmoke
        End If
        TContraseña.Focus()
    End Sub

    Private Sub BIniciarSesion_Click(sender As Object, e As EventArgs) Handles BIniciarSesion.Click
        If String.IsNullOrWhiteSpace(TUsuario.Text) Then
            MessageBox.Show("Por favor, ingrese su nombre de usuario.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TUsuario.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TContraseña.Text) Then
            MessageBox.Show("Por favor, ingrese su contraseña.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TContraseña.Focus()
            Exit Sub
        End If

        Try
            Dim usuarioNeg As New UsuarioNegocio()
            Dim userLogueado As Usuario = usuarioNeg.ValidarLogin(TUsuario.Text.Trim(), TContraseña.Text.Trim())

            If userLogueado IsNot Nothing Then
                MessageBox.Show("¡Bienvenido al sistema, " & userLogueado.nombreUsuario & "!",
                                "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim menuPrincipal As New FrmMenuPrincipal()
                menuPrincipal.UsuarioActual = userLogueado.nombreUsuario
                menuPrincipal.RolActual = userLogueado.rol
                menuPrincipal.Show()

                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TContraseña.Clear()
            TUsuario.Focus()
        End Try
    End Sub

    Private Sub lblSubtituloMarca_Click(sender As Object, e As EventArgs) Handles lblSubtituloMarca.Click

    End Sub

    Private Sub lblSubtituloLogin_Click(sender As Object, e As EventArgs) Handles lblSubtituloLogin.Click

    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click

    End Sub
End Class