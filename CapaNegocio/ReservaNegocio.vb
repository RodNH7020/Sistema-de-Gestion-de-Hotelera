Imports System.Data
Imports CapaDatos
Imports CapaEntidades
Imports SistemaHotelero

Public Class ReservaNegocio
    Private objReservaDatos As New ReservaDatos()

    Public Function InsertarReserva(r As Reserva) As Boolean
        If r.fecha_ingreso >= r.fecha_salida Then
            Throw New ArgumentException("La fecha de salida debe ser posterior a la fecha de ingreso.")
        End If

        If r.fecha_ingreso.Date < DateTime.Now.Date Then
            Throw New ArgumentException("La fecha de ingreso no puede ser anterior a la fecha actual.")
        End If

        If String.IsNullOrEmpty(r.estado) Then
            r.estado = "Activa"
        End If

        Return objReservaDatos.Insertar(r)
    End Function

    Public Function ListarReservasActivas(filtro As String) As DataTable
        Dim reservaDatos As New ReservaDatos()
        Return reservaDatos.ListarActivasConFiltro(filtro)
    End Function

    Public Function CancelarReserva(idReserva As Integer) As Boolean
        ' Lógica para actualizar el estado de la reserva a "Cancelada" o "Anulada"
        Dim reservaDatos As New ReservaDatos()
        Return reservaDatos.ActualizarEstado(idReserva, "Cancelada")
    End Function
End Class