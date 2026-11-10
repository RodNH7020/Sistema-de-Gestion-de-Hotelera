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

    ' Sobrecarga 1: Recibe la entidad como Object para evitar conflictos de tipos
    Public Overloads Function InsertarReserva(reserva As Object) As Boolean
        If reserva Is Nothing Then
            Throw New ArgumentNullException("Los datos de la reserva no pueden ser nulos.")
        End If
        Return datos.InsertarReserva(reserva)
    End Function

    ' Sobrecarga 2: Recibe parámetros sueltos
    Public Overloads Function InsertarReserva(idHuesped As Integer, idHabitacion As Integer, fechaReserva As Date, Optional estado As String = "Confirmada") As Boolean
        If idHuesped <= 0 OrElse idHabitacion <= 0 Then
            Throw New ArgumentException("Debe seleccionar un huésped y una habitación válidos.")
        End If
        Return datos.InsertarReserva(idHuesped, idHabitacion, fechaReserva, estado)
    End Function

    ' Cancelar reserva
    Public Function CancelarReserva(idReserva As Integer) As Boolean
        If idReserva <= 0 Then
            Throw New ArgumentException("Debe indicar un número de reserva válido.")
        End If
        Return datos.CancelarReserva(idReserva)
    End Function

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

    Public Function ConsultarReservas(fechaDesde As Date, fechaHasta As Date, idHabitacion As Integer, ByRef stats As EstadisticasReservas) As DataTable
        If fechaHasta < fechaDesde Then
            Throw New ArgumentException("La 'Fecha Hasta' no puede ser anterior a la 'Fecha Desde'.")
        End If

        Dim dt As DataTable = datos.FiltrarReservas(fechaDesde, fechaHasta, idHabitacion)

        stats = New EstadisticasReservas()
        stats.TotalReservas = dt.Rows.Count
        Dim sumaTarifas As Decimal = 0D

        For Each row As DataRow In dt.Rows
            Dim estado As String = row("Estado").ToString().Trim().ToLower()
            ' Cuenta Confirmada, Activa y Finalizada como reservas efectivas
            If estado = "confirmada" Or estado = "activa" Or estado = "finalizada" Then
                stats.TotalConfirmadas += 1
            ElseIf estado = "cancelada" Or estado = "anulada" Then
                stats.TotalCanceladas += 1
            End If

            If Not IsDBNull(row("Tarifa Diaria")) Then
                sumaTarifas += Convert.ToDecimal(row("Tarifa Diaria"))
            End If
        Next

        stats.SumaTarifas = sumaTarifas
        stats.PromedioTarifa = If(stats.TotalReservas > 0, Math.Round(sumaTarifas / stats.TotalReservas, 2), 0D)

        Return dt
    End Function
End Class