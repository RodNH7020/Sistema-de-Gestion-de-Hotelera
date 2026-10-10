Public Class Pago
    Public Property id_pago As Integer
    Public Property id_estadia As Integer
    Public Property monto As Decimal
    Public Property fecha_pago As DateTime
    Public Property metodo_pago As String '"Efectivo", "Tarjeta de Crédito", "Transferencia Bancaria"'
    Public Property tipo_pago As String '"Total", "Parcial"' 
End Class
