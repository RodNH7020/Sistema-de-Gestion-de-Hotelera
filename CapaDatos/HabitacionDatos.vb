Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class HabitacionDatos
    Private ReadOnly conexionBD As New Conexion()

    ' Listar habitaciones con su estado (HU-03 / Prototipos)
    Public Function ListarTodas() As List(Of Habitacion)
        Dim lista As New List(Of Habitacion)()
        Dim query As String = "SELECT id_habitacion, numero, tipo, precio, estado FROM Habitacion"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                con.Open()
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim hab As New Habitacion() With {
                            .id_habitacion = Convert.ToInt32(dr("id_habitacion")),
                            .numero = Convert.ToInt32(dr("numero")),
                            .tipo = dr("tipo").ToString(),
                            .precio = Convert.ToDecimal(dr("precio")),
                            .estado = dr("estado").ToString()
                        }
                        lista.Add(hab)
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function

    ' Cambiar estado: "Disponible", "Ocupada", "En limpieza" (HU-03 / Check-In / Check-Out)
    Public Function ActualizarEstado(idHabitacion As Integer, nuevoEstado As String) As Boolean
        Dim query As String = "UPDATE Habitacion SET estado = @estado WHERE id_habitacion = @id"
        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@estado", nuevoEstado)
                cmd.Parameters.AddWithValue("@id", idHabitacion)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Alta de nueva habitación (HU-01)
    Public Function Insertar(hab As Habitacion) As Boolean
        Dim query As String = "INSERT INTO Habitacion (numero, tipo, precio, estado) " &
                              "VALUES (@numero, @tipo, @precio, @estado)"
        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@numero", hab.numero)
                cmd.Parameters.AddWithValue("@tipo", hab.tipo)
                cmd.Parameters.AddWithValue("@precio", hab.precio)
                cmd.Parameters.AddWithValue("@estado", hab.estado)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
End Class