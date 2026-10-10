Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class UsuarioDatos
    Private ReadOnly conexionBD As New Conexion()

    ' Validar login (HU-20)
    Public Function ValidarLogin(nombreUsuario As String, contrasena As String) As Usuario
        Dim user As Usuario = Nothing
        Dim query As String = "SELECT * FROM Usuario WHERE nombre_usuario = @usuario AND contrasena = @pass AND estado = 1"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@usuario", nombreUsuario)
                cmd.Parameters.AddWithValue("@pass", contrasena)

                con.Open()
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        user = New Usuario() With {
                            .idUsuario = Convert.ToInt32(dr("id_usuario")),
                            .nombreUsuario = dr("nombre_usuario").ToString(),
                            .clave = dr("contrasena").ToString(),
                            .rol = dr("rol").ToString(),
                            .estado = Convert.ToBoolean(dr("estado"))
                        }
                    End If
                End Using
            End Using
        End Using
        Return user
    End Function

    ' Registrar nuevo usuario (HU-19)
    Public Function Insertar(u As Usuario) As Boolean
        Dim query As String = "INSERT INTO Usuario (nombre_usuario, contrasena, rol, estado) " &
                              "VALUES (@usuario, @pass, @rol, @estado)"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@usuario", u.nombreUsuario)
                cmd.Parameters.AddWithValue("@pass", u.clave)
                cmd.Parameters.AddWithValue("@rol", u.rol)
                cmd.Parameters.AddWithValue("@estado", u.estado)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
End Class