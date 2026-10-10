Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class EstadiaDatos
    Private ReadOnly conexionBD As New Conexion()

    ' Registrar Check-In
    Public Function RegistrarCheckIn(e As Estadia) As Boolean
        Dim query As String = "INSERT INTO Estadia (id_reserva, fecha_checkin, estado_pago) " &
                              "VALUES (@idReserva, @checkIn, @estadoPago)"
        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idReserva", e.idReserva)
                cmd.Parameters.AddWithValue("@checkIn", e.fechaCheckIn)
                cmd.Parameters.AddWithValue("@estadoPago", e.estadoPago)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Registrar Check-Out
    Public Function RegistrarCheckOut(idEstadia As Integer, fechaSalida As DateTime) As Boolean
        Dim query As String = "UPDATE Estadia SET fecha_checkout = @salida, estado_pago = 'Finalizada' WHERE id_estadia = @id"
        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@salida", fechaSalida)
                cmd.Parameters.AddWithValue("@id", idEstadia)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Buscar estadía por ID
    Public Function BuscarPorId(idEstadia As Integer) As Estadia
        Dim est As Estadia = Nothing
        Dim query As String = "SELECT * FROM Estadia WHERE id_estadia = @id"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", idEstadia)
                con.Open()
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        est = New Estadia() With {
                            .idEstadia = Convert.ToInt32(dr("id_estadia")),
                            .idReserva = Convert.ToInt32(dr("id_reserva")),
                            .fechaCheckIn = Convert.ToDateTime(dr("fecha_checkin")),
                            .fechaCheckOut = If(IsDBNull(dr("fecha_checkout")), Nothing, Convert.ToDateTime(dr("fecha_checkout"))),
                            .estadoPago = dr("estado_pago").ToString()
                        }
                    End If
                End Using
            End Using
        End Using
        Return est
    End Function
End Class