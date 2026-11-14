Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class ReservaDatos
    Private ReadOnly conexion As New Conexion()

    ' Registrar uma reserva (HU-05)
    Public Function Insertar(r As Reserva) As Boolean
        Dim query As String = "INSERT INTO Reserva (id_huesped, id_habitacion, id_usuario, fecha_reserva, fecha_ingreso, fecha_salida, estado) " &
                          "VALUES (@idHuesped, @idHabitacion, @idUsuario, @fechaReserva, @fechaIngreso, @fechaSalida, @estado)"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idHuesped", r.id_huesped)
                cmd.Parameters.AddWithValue("@idHabitacion", r.id_habitacion)

                ' Si id_usuario es mayor a 0 lo guarda, sino inserta NULL en la base de datos
                If r.id_usuario > 0 Then
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = r.id_usuario
                Else
                    cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = DBNull.Value
                End If

                cmd.Parameters.Add("@fechaReserva", SqlDbType.Date).Value = r.fecha_reserva
                cmd.Parameters.Add("@fechaIngreso", SqlDbType.Date).Value = r.fecha_ingreso
                cmd.Parameters.Add("@fechaSalida", SqlDbType.Date).Value = r.fecha_salida
                cmd.Parameters.AddWithValue("@estado", r.estado)

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

    Public Function ListarActivasConFiltro(filtro As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT r.id_reserva, " &
                          "(h.nombre + ' ' + h.apellido) AS Huésped, " &
                          "hab.numero AS Habitacion, " &
                          "r.fecha_ingreso, r.fecha_salida, r.estado, " &
                          "ISNULL(u.nombre_usuario, 'Sistema') AS Recepcionista " &
                          "FROM RESERVA r " &
                          "INNER JOIN HUESPED h ON r.id_huesped = h.id_huesped " &
                          "INNER JOIN HABITACION hab ON r.id_habitacion = hab.id_habitacion " &
                          "LEFT JOIN USUARIO u ON r.id_usuario = u.id_usuario " &
                          "WHERE r.estado = 'Activa' AND " &
                          "(h.nombre LIKE @filtro OR h.apellido LIKE @filtro OR hab.numero LIKE @filtro)"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@filtro", "%" & filtro & "%")
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function ActualizarEstado(idReserva As Integer, nuevoEstado As String) As Boolean
        Dim query As String = "UPDATE RESERVA SET estado = @estado WHERE id_reserva = @id"
        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@estado", nuevoEstado)
                cmd.Parameters.AddWithValue("@id", idReserva)
                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
End Class