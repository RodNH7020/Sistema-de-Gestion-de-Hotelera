Imports System.Data
Imports CapaDatos

Public Class EstadisticasReservas
    Public Property TotalReservas As Integer
    Public Property TotalConfirmadas As Integer
    Public Property TotalCanceladas As Integer
    Public Property SumaTarifas As Decimal
    Public Property PromedioTarifa As Decimal
End Class

Public Class ReservaNegocio
    Private ReadOnly datos As New ReservaDatos()

    ' Sobrecarga 1: Recibe la entidad Reserva
    Public Overloads Function InsertarReserva(reserva As Object) As Boolean
        If reserva Is Nothing Then
            Throw New ArgumentNullException("Los datos de la reserva no pueden ser nulos.")
        End If
        Return datos.Insertar(reserva)
    End Function

    ' Sobrecarga 2: Recibe parámetros sueltos
    Public Overloads Function InsertarReserva(idHuesped As Integer, idHabitacion As Integer, fechaReserva As Date, Optional estado As String = "Confirmada") As Boolean
        If idHuesped <= 0 OrElse idHabitacion <= 0 Then
            Throw New ArgumentException("Debe seleccionar un huésped y una habitación válidos.")
        End If
        Return datos.InsertarReserva(idHuesped, idHabitacion, fechaReserva, estado)
    End Function

    ' Cancelar / Anular reserva (una única definición unificada)
    Public Function CancelarReserva(idReserva As Integer) As Boolean
        If idReserva <= 0 Then
            Throw New ArgumentException("Debe indicar un número de reserva válido.")
        End If
        Return datos.ActualizarEstado(idReserva, "Cancelada")
    End Function

    ' Listar reservas activas con filtro (para FrmAnularReserva)
    Public Function ListarReservasActivas(Optional filtro As String = "") As DataTable
        Return datos.ListarActivasConFiltro(filtro)
    End Function

    ' Obtener habitaciones para el combo de filtro (para FrmGestionReservas)
    Public Function ObtenerHabitaciones() As DataTable
        Return datos.ListarHabitacionesFiltro()
    End Function

    ' Lista de usuarios para el filtro de la pantalla
    Public Function ObtenerUsuarios() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("id_usuario", GetType(Integer))
        dt.Columns.Add("descripcion", GetType(String))
        Return dt
    End Function

    ' Consulta y cálculo de estadísticas (para FrmGestionReservas)
    Public Function ConsultarReservas(fechaDesde As Date, fechaHasta As Date, idHabitacion As Integer, ByRef stats As EstadisticasReservas) As DataTable
        Dim dt As DataTable = datos.FiltrarReservas(fechaDesde, fechaHasta, idHabitacion)
        stats = New EstadisticasReservas()

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            stats.TotalReservas = dt.Rows.Count
            Dim suma As Decimal = 0D

            For Each fila As DataRow In dt.Rows
                Dim estado As String = fila("Estado").ToString().Trim()
                If estado.Equals("Confirmada", StringComparison.OrdinalIgnoreCase) OrElse estado.Equals("Activa", StringComparison.OrdinalIgnoreCase) Then
                    stats.TotalConfirmadas += 1
                ElseIf estado.Equals("Cancelada", StringComparison.OrdinalIgnoreCase) Then
                    stats.TotalCanceladas += 1
                End If

                If Not IsDBNull(fila("Tarifa Diaria")) Then
                    suma += Convert.ToDecimal(fila("Tarifa Diaria"))
                End If
            Next

            stats.SumaTarifas = suma
            stats.PromedioTarifa = Math.Round(suma / stats.TotalReservas, 2)
        End If

        Return dt
    End Function

End Class