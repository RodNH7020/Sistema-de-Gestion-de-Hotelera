Imports CapaDatos
Imports CapaEntidades
Imports SistemaHotelero

Public Class UsuarioNegocio
    Private objUsuarioDatos As New UsuarioDatos()

    ' Lógica de negocio para validar el inicio de sesión (Login)
    Public Function ValidarLogin(nombreUsuario As String, password As String) As Usuario
        ' Regla 1: Validar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(nombreUsuario) OrElse String.IsNullOrWhiteSpace(password) Then
            Throw New ArgumentException("El usuario y la contraseña son obligatorios.")
        End If

        ' Llamar a la capa de datos para verificar credenciales
        Dim usuarioLogueado As Usuario = objUsuarioDatos.ValidarLogin(nombreUsuario, password)

        ' Regla 2: Verificar si el usuario existe y las credenciales son correctas
        If usuarioLogueado Is Nothing Then
            Throw New UnauthorizedAccessException("Usuario o contraseña incorrectos.")
        End If

        Return usuarioLogueado
    End Function
End Class