Imports CapaDatos
Imports CapaEntidades
Imports SistemaHotelero

Public Class HabitacionNegocio

    ' Instancia de la capa de datos para interactuar con la base de datos
    Private ReadOnly _habitacionDatos As New HabitacionDatos()

    ''' <summary>
    ''' Valida las reglas de negocio y registra una nueva habitación (HU-01)
    ''' </summary>
    Public Function RegistrarHabitacion(hab As Habitacion) As String
        ' 1. Validación de objeto no nulo
        If hab Is Nothing Then
            Return "Los datos de la habitación no pueden estar vacíos."
        End If

        ' 2. Validación del número de habitación (HU-01)
        If hab.numero <= 0 Then
            Return "El número de habitación es inválido."
        End If

        ' 3. Validación del tipo de habitación (HU-04)
        If String.IsNullOrWhiteSpace(hab.tipo) Then
            Return "La categoría o tipo de habitación es obligatoria."
        End If

        ' 4. Validación del precio (HU-01)
        If hab.precio <= 0 Then
            Return "El precio debe ser mayor a cero."
        End If

        ' 5. Validación de duplicados: evita registrar un número que ya exista (HU-01)
        Dim todasLasHabitaciones As List(Of Habitacion) = _habitacionDatos.ListarTodas()
        If todasLasHabitaciones.Any(Function(h) h.numero = hab.numero) Then
            Return "Ya existe una habitación registrada con ese número."
        End If

        ' 6. Asignar estado inicial si viene vacío (por defecto: "Disponible")
        If String.IsNullOrWhiteSpace(hab.estado) Then
            hab.estado = "Disponible"
        End If

        ' 7. Envío a la Capa de Datos para guardar en la base de datos
        Dim guardadoExitoso As Boolean = _habitacionDatos.Insertar(hab)

        If guardadoExitoso Then
            Return "OK"
        Else
            Return "No se pudo registrar la habitación en la base de datos."
        End If
    End Function

    ''' <summary>
    ''' Obtiene todas las habitaciones registradas en el sistema
    ''' </summary>
    Public Function ListarTodas() As List(Of Habitacion)
        Return _habitacionDatos.ListarTodas()
    End Function

    ''' <summary>
    ''' Retorna únicamente las habitaciones que se encuentran con estado "Disponible" (HU-03, HU-08)
    ''' </summary>
    Public Function ListarDisponibles() As List(Of Habitacion)
        Dim todas As List(Of Habitacion) = _habitacionDatos.ListarTodas()
        Return todas.Where(Function(h) h.estado.Equals("Disponible", StringComparison.OrdinalIgnoreCase)).ToList()
    End Function

    ''' <summary>
    ''' Actualiza el estado de la habitación asegurando que sea un estado permitido (HU-03)
    ''' </summary>
    Public Function CambiarEstado(idHabitacion As Integer, nuevoEstado As String) As String
        If idHabitacion <= 0 Then
            Return "El identificador de la habitación es inválido."
        End If

        If String.IsNullOrWhiteSpace(nuevoEstado) Then
            Return "El nuevo estado no puede estar vacío."
        End If

        ' Validación de consistencia según los estados del sistema
        Dim estadosValidos As String() = {"Disponible", "Ocupada", "En limpieza"}
        If Not estadosValidos.Contains(nuevoEstado) Then
            Return "El estado indicado no es válido."
        End If

        Dim actualizado As Boolean = _habitacionDatos.ActualizarEstado(idHabitacion, nuevoEstado)

        If actualizado Then
            Return "OK"
        Else
            Return "No se pudo actualizar el estado de la habitación."
        End If
    End Function

    ''' <summary>
    ''' Permite buscar una habitación mediante su número visible (HU-03)
    ''' </summary>
    Public Function BuscarPorNumero(numero As Integer) As Habitacion
        If numero <= 0 Then
            Return Nothing
        End If

        Dim todas As List(Of Habitacion) = _habitacionDatos.ListarTodas()
        Return todas.FirstOrDefault(Function(h) h.numero = numero)
    End Function

End Class