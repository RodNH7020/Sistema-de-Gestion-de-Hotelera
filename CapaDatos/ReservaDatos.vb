Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class ReservaDatos
    Private ReadOnly conexion As New Conexion()

    ' Sobrecarga 1: Recibe la entidad e interactúa mediante reflexión dinámica
    Public Overloads Function InsertarReserva(reserva As Object) As Boolean
        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim query As String = "INSERT INTO RESERVA (id_huesped, id_habitacion, fecha_reserva, estado) VALUES (@idHuesped, @idHabitacion, @fechaReserva, @estado)"
            Using cmd As New SqlCommand(query, conn)
                Dim idHuesped As Object = reserva.GetType().GetProperty("id_huesped")?.GetValue(reserva, Nothing)
                Dim idHabitacion As Object = reserva.GetType().GetProperty("id_habitacion")?.GetValue(reserva, Nothing)
                Dim fechaReserva As Object = reserva.GetType().GetProperty("fecha_reserva")?.GetValue(reserva, Nothing)
                Dim estado As Object = reserva.GetType().GetProperty("estado")?.GetValue(reserva, Nothing)

                cmd.Parameters.AddWithValue("@idHuesped", If(idHuesped, 1))
                cmd.Parameters.AddWithValue("@idHabitacion", If(idHabitacion, 1))
                cmd.Parameters.AddWithValue("@fechaReserva", If(fechaReserva, DateTime.Now))
                cmd.Parameters.AddWithValue("@estado", If(estado IsNot Nothing AndAlso Not String.IsNullOrEmpty(estado.ToString()), estado.ToString(), "Confirmada"))
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Sobrecarga 2: Recibe parámetros sueltos
    Public Overloads Function InsertarReserva(idHuesped As Integer, idHabitacion As Integer, fechaReserva As Date, estado As String) As Boolean
        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim query As String = "INSERT INTO RESERVA (id_huesped, id_habitacion, fecha_reserva, estado) VALUES (@idHuesped, @idHabitacion, @fechaReserva, @estado)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idHuesped", idHuesped)
                cmd.Parameters.AddWithValue("@idHabitacion", idHabitacion)
                cmd.Parameters.AddWithValue("@fechaReserva", fechaReserva)
                cmd.Parameters.AddWithValue("@estado", estado)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function CancelarReserva(idReserva As Integer) As Boolean
        Using conn As SqlConnection = conexion.ObtenerConexion()
            conn.Open()
            Dim query As String = "UPDATE RESERVA SET estado = 'Cancelada' WHERE id_reserva = @idReserva"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@idReserva", idReserva)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ListarHabitacionesFiltro() As DataTable
        Dim dt As New DataTable()
        Using conn As SqlConnection = conexion.ObtenerConexion()
            Dim query As String = "SELECT id_habitacion, numero + ' - ' + tipo AS descripcion FROM HABITACION ORDER BY numero"
            Dim da As New SqlDataAdapter(query, conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function FiltrarReservas(fechaDesde As Date, fechaHasta As Date, Optional idHabitacion As Integer = 0) As DataTable
        Dim dt As New DataTable()
        Using conn As SqlConnection = conexion.ObtenerConexion()
            Dim query As String = "
                SELECT 
                    r.id_reserva AS [Nro Reserva],
                    h.nombre + ' ' + h.apellido AS [Huésped],
                    h.dni_pasaporte AS [Documento],
                    hab.numero AS [Habitación],
                    hab.tipo AS [Tipo],
                    hab.precio AS [Tarifa Diaria],
                    r.fecha_reserva AS [Fecha Creación],
                    r.estado AS [Estado]
                FROM RESERVA r
                INNER JOIN HUESPED h ON r.id_huesped = h.id_huesped
                INNER JOIN HABITACION hab ON r.id_habitacion = hab.id_habitacion
                WHERE r.fecha_reserva BETWEEN @desde AND @hasta "

            If idHabitacion > 0 Then
                query &= " AND r.id_habitacion = @idHabitacion "
            End If

            query &= " ORDER BY r.fecha_reserva DESC"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@desde", fechaDesde.Date)
                cmd.Parameters.AddWithValue("@hasta", fechaHasta.Date.AddDays(1).AddSeconds(-1))
                If idHabitacion > 0 Then cmd.Parameters.AddWithValue("@idHabitacion", idHabitacion)

                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function
End Class