Imports CapaDatos
Imports CapaEntidades
Imports SistemaHotelero

Public Class EstadiaNegocio

    ' Instancias hacia la capa de datos
    Private ReadOnly _estadiaDatos As New EstadiaDatos()
    Private ReadOnly _habitacionDatos As New HabitacionDatos()

    ''' <summary>
    ''' Registra el Check-In formalizando el ingreso del huésped y ocupando la habitación (HU-11, HU-12)
    ''' </summary>
    ''' <param name="idReserva">ID de la reserva asociada</param>
    ''' <param name="idHabitacion">ID de la habitación asignada</param>
    ''' <returns>"OK" si se registró con éxito o el mensaje de validación correspondiente</returns>
    Public Function RegistrarCheckIn(idReserva As Integer, idHabitacion As Integer) As String
        ' 1. Validación de identificadores
        If idReserva <= 0 Then
            Return "Debe ingresar un número de reserva válido."
        End If

        If idHabitacion <= 0 Then
            Return "Debe especificar una habitación para la estadía."
        End If

        ' 2. Validación de disponibilidad de la habitación
        Dim habitaciones As List(Of Habitacion) = _habitacionDatos.ListarTodas()
        Dim hab As Habitacion = habitaciones.FirstOrDefault(Function(h) h.id_habitacion = idHabitacion)

        If hab Is Nothing Then
            Return "La habitación seleccionada no existe."
        End If

        If Not hab.estado.Equals("Disponible", StringComparison.OrdinalIgnoreCase) Then
            Return "La habitación seleccionada no está disponible (estado actual: " & hab.estado & ")."
        End If

        ' 3. Construcción del objeto Estadia
        Dim nuevaEstadia As New Estadia() With {
            .idReserva = idReserva,
            .fechaCheckIn = DateTime.Now,
            .estadoPago = "Pendiente"
        }

        ' 4. Guardar estadía en la base de datos
        Dim checkInGuardado As Boolean = _estadiaDatos.RegistrarCheckIn(nuevaEstadia)

        If Not checkInGuardado Then
            Return "Error al registrar el Check-In en la base de datos."
        End If

        ' 5. Actualizar el estado de la habitación a 'Ocupada'
        _habitacionDatos.ActualizarEstado(idHabitacion, "Ocupada")

        Return "OK"
    End Function

    ''' <summary>
    ''' Registra el Check-Out, finaliza la estadía y libera la habitación (HU-14)
    ''' </summary>
    ''' <param name="idEstadia">ID de la estadía a finalizar</param>
    ''' <param name="idHabitacion">ID de la habitación a desocupar</param>
    ''' <returns>"OK" si el egreso fue correcto o el detalle del error</returns>
    Public Function RegistrarCheckOut(idEstadia As Integer, idHabitacion As Integer) As String
        ' 1. Validación de identificador
        If idEstadia <= 0 Then
            Return "Debe ingresar un número de estadía válido."
        End If

        ' 2. Verificar existencia de la estadía
        Dim estadiaActual As Estadia = _estadiaDatos.BuscarPorId(idEstadia)
        If estadiaActual Is Nothing Then
            Return "La estadía solicitada no existe."
        End If

        ' 3. Verificar que no haya finalizado previamente
        If estadiaActual.estadoPago.Equals("Finalizada", StringComparison.OrdinalIgnoreCase) Then
            Return "Esta estadía ya se encuentra finalizada."
        End If

        ' 4. Registrar salida en la base de datos
        Dim checkOutGuardado As Boolean = _estadiaDatos.RegistrarCheckOut(idEstadia, DateTime.Now)

        If Not checkOutGuardado Then
            Return "Error al registrar la salida de la estadía."
        End If

        ' 5. Cambiar el estado de la habitación a 'Disponible'
        If idHabitacion > 0 Then
            _habitacionDatos.ActualizarEstado(idHabitacion, "Disponible")
        End If

        Return "OK"
    End Function

    ''' <summary>
    ''' Consulta los datos de una estadía existente por su identificador
    ''' </summary>
    Public Function BuscarPorId(idEstadia As Integer) As Estadia
        If idEstadia <= 0 Then
            Return Nothing
        End If

        Return _estadiaDatos.BuscarPorId(idEstadia)
    End Function

End Class