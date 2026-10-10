Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class ReservaDatos
    Private ReadOnly conexionBD As New Conexion()

    ' Registrar uma reserva (HU-05)
    Public Function Insertar(r As Reserva) As Boolean
        Dim query As String = "INSERT INTO Reserva (id_huesped, id_habitacion, fecha_reserva, fecha_ingreso, fecha_salida, estado) " &
                              "VALUES (@idHuesped, @idHabitacion, @fechaReserva, @fechaIngreso, @fechaSalida, @estado)"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idHuesped", r.id_huesped)
                cmd.Parameters.AddWithValue("@idHabitacion", r.id_habitacion)
                cmd.Parameters.AddWithValue("@fechaReserva", r.fecha_reserva)
                cmd.Parameters.AddWithValue("@fechaIngreso", r.fecha_ingreso)
                cmd.Parameters.AddWithValue("@fechaSalida", r.fecha_salida)
                cmd.Parameters.AddWithValue("@estado", r.estado)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Cancelar reserva (HU-07)
    Public Function CancelarReserva(idReserva As Integer) As Boolean
        Dim query As String = "UPDATE Reserva SET estado = 'Cancelada' WHERE id_reserva = @id"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", idReserva)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
End Class