Imports System.Windows.Forms
Imports CapaNegocio
Imports SistemaHotelero

Public Class FormularioLogin

    Private Sub BIniciarSesion_Click(sender As Object, e As EventArgs) Handles BIniciarSesion.Click
        ' 1. Validación de campos vacíos en la capa de presentación (UI)
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

        ' 2. Proceso de autenticación
        Try
            ' Instanciamos la capa de negocio de usuarios
            Dim usuarioNeg As New UsuarioNegocio()

            ' Validamos contra la base de datos usando el método que armamos en la capa de negocio
            Dim userLogueado As Usuario = usuarioNeg.ValidarLogin(TUsuario.Text.Trim(), TContraseña.Text.Trim())

            If userLogueado IsNot Nothing Then
                MessageBox.Show("¡Bienvenido al sistema, " & userLogueado.nombreUsuario & "!",
                            "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Aquí posteriormente abriremos el formulario principal o de reservas
                ' Dim frmReserva As New FrmRegistrarReserva()
                ' frmReserva.Show()

                ' Ocultamos la ventana de login actual
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TContraseña.Clear()
            TUsuario.Focus()
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LLogin_Click(sender As Object, e As EventArgs) Handles LLogin.Click

    End Sub
End Class