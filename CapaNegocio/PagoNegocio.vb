Imports CapaDatos
Imports CapaEntidades
Imports SistemaHotelero

Public Class PagoNegocio
    Private ReadOnly _pagoDatos As New PagoDatos()

    Public Function RegistrarPago(idEstadia As Integer, monto As Decimal, metodoPago As String, tipoPago As String) As String
        ' Panangpatalged kadagiti pagannurotan ti negosio (HU-16)
        If idEstadia <= 0 Then
            Return "Identificador de estadía inválido."
        End If

        If monto <= 0 Then
            Return "El importe del pago debe ser mayor a cero."
        End If

        If String.IsNullOrWhiteSpace(metodoPago) Then
            Return "Debe seleccionar un medio de pago válido."
        End If

        Dim nuevoPago As New Pago() With {
            .id_estadia = idEstadia,
            .monto = monto,
            .fecha_pago = DateTime.Now,
            .metodo_pago = metodoPago,
            .tipo_pago = tipoPago
        }

        Dim exito As Boolean = _pagoDatos.Insertar(nuevoPago)

        If exito Then
            Return "OK"
        Else
            Return "No se pudo registrar el pago en la base de datos."
        End If
    End Function

    Public Function ObtenerTotalPagado(idEstadia As Integer) As Decimal
        If idEstadia <= 0 Then
            Return 0D
        End If
        Return _pagoDatos.ObtenerTotalPagado(idEstadia)
    End Function
End Class