Imports CapaDatos
Imports CapaEntidades
Imports SistemaHotelero

Public Class HuespedNegocio

    ' Instancia de la capa de datos para interactuar con la base de datos
    Private ReadOnly _huespedDatos As New HuespedDatos()

    ''' <summary>
    ''' Valida las reglas de negocio de la HU-10 y registra un nuevo huésped en el sistema.
    ''' </summary>
    Public Function RegistrarHuesped(h As Huesped) As String
        ' 1. Validación de objeto no nulo
        If h Is Nothing Then
            Return "Los datos del huésped no pueden estar vacíos."
        End If

        ' 2. Validación de campos obligatorios (HU-10: Nombre, Apellido y DNI/Pasaporte)
        If String.IsNullOrWhiteSpace(h.nombre) OrElse
           String.IsNullOrWhiteSpace(h.apellido) OrElse
           String.IsNullOrWhiteSpace(h.dni_pasaporte) Then
            Return "Los campos Nombre, Apellido y DNI/Pasaporte son obligatorios."
        End If

        ' 3. Validación de duplicados: Evita registrar un huésped con el mismo documento (HU-10 / RNF#03)
        Dim huespedExistente As Huesped = _huespedDatos.BuscarPorDni(h.dni_pasaporte)
        If huespedExistente IsNot Nothing Then
            Return "Ya existe un huésped registrado con el mismo número de documento o pasaporte."
        End If

        ' 4. Envío a la Capa de Datos para guardar en la base de datos
        Dim guardadoExitoso As Boolean = _huespedDatos.Insertar(h)

        If guardadoExitoso Then
            Return "OK"
        Else
            Return "No se pudo registrar el huésped en la base de datos."
        End If
    End Function

    ''' <summary>
    ''' Obtiene todos los huéspedes registrados para alimentar los ComboBox y grillas del sistema.
    ''' </summary>
    Public Function ListarHuespedes() As List(Of Huesped)
        Return _huespedDatos.ListarTodos()
    End Function

    ''' <summary>
    ''' Permite buscar un huésped específico mediante su documento.
    ''' </summary>
    Public Function BuscarPorDni(dni As String) As Huesped
        If String.IsNullOrWhiteSpace(dni) Then
            Return Nothing
        End If
        Return _huespedDatos.BuscarPorDni(dni)
    End Function

End Class