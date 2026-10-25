Imports System.Data
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

    ' Filtrar reservas activas 
    Public Function ListarReservasActivas(Optional filtro As String = "") As DataTable
        Dim dt As New DataTable
        Dim query As String = "SELECT r.id_reservas, h.nombre_completo AS Huésped, hab.numero AS Habitacion, r.fecha_ingreso, r.fecha_salida, r.estado " &
                              "FROM Reserva r " &
                              "INNER JOIN Huesped h ON r.id_huesped = h.id_huesped " &
                              "INNER JOIN Habitacion hab ON r.id_habitacion = hab.id_habitacion " &
                              "WHERE r.estado = 'Activa'"

        If Not String.IsNullOrWhiteSpace(filtro) Then
            query &= " AND (h.nombre_completo LIKE @filtro OR hab.numero LIKE @filtro)"
        End If

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                If Not String.IsNullOrWhiteSpace(filtro) Then
                    cmd.Parameters.AddWithValue("@filtro", "%" & filtro & "%")
                End If
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function
End Class