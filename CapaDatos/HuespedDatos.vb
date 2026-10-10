Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class HuespedDatos
    Private ReadOnly conexionBD As New Conexion()

    ' Registrar un huésped nuevo (HU-10)
    Public Function Insertar(h As Huesped) As Boolean
        Dim query As String = "INSERT INTO Huesped (nombre, apellido, dni_pasaporte, telefono, email, barrio, calle, numero) " &
                              "VALUES (@nombre, @apellido, @dni, @telefono, @email, @barrio, @calle, @numero)"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@nombre", h.nombre)
                cmd.Parameters.AddWithValue("@apellido", h.apellido)
                cmd.Parameters.AddWithValue("@dni", h.dni_pasaporte)
                cmd.Parameters.AddWithValue("@telefono", If(h.telefono, DBNull.Value))
                cmd.Parameters.AddWithValue("@email", If(h.email, DBNull.Value))
                cmd.Parameters.AddWithValue("@barrio", If(h.barrio, DBNull.Value))
                cmd.Parameters.AddWithValue("@calle", If(h.calle, DBNull.Value))
                cmd.Parameters.AddWithValue("@numero", If(h.numero, DBNull.Value))

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Buscar huésped por DNI para evitar duplicados (RNF#03 / HU-10)
    Public Function BuscarPorDni(dni As String) As Huesped
        Dim h As Huesped = Nothing
        Dim query As String = "SELECT * FROM Huesped WHERE dni_pasaporte = @dni"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@dni", dni)
                con.Open()
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        h = New Huesped() With {
                            .id_huesped = Convert.ToInt32(dr("id_huesped")),
                            .nombre = dr("nombre").ToString(),
                            .apellido = dr("apellido").ToString(),
                            .dni_pasaporte = dr("dni_pasaporte").ToString(),
                            .telefono = dr("telefono").ToString(),
                            .email = dr("email").ToString()
                        }
                    End If
                End Using
            End Using
        End Using
        Return h
    End Function
End Class