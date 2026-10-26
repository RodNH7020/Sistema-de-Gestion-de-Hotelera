Imports CapaDatos
Imports CapaEntidades
Imports SistemaHotelero

Public Class FacturaNegocio
    Private ReadOnly _facturaDatos As New FacturaDatos()
    Private ReadOnly _estadiaDatos As New EstadiaDatos()
    Private ReadOnly _pagoDatos As New PagoDatos()

    ''' <summary>
    ''' Karkuluen ti Subtotal, IVA (21%), ken Kabuklan maibatay iti Factura A wenno B
    ''' </summary>
    Public Sub CalcularTotales(totalBruto As Decimal, tipoFactura As String, ByRef netoGravado As Decimal, ByRef iva As Decimal, ByRef totalFinal As Decimal)
        If tipoFactura.Trim().ToUpper() = "A" Then
            ' Factura A: mailasin ti 21% nga IVA
            netoGravado = Math.Round(totalBruto / 1.21D, 2)
            iva = Math.Round(totalBruto - netoGravado, 2)
            totalFinal = totalBruto
        Else
            ' Factura B: consumidor final (nairamanen ti IVA)
            netoGravado = totalBruto
            iva = 0D
            totalFinal = totalBruto
        End If
    End Sub

    ''' <summary>
    ''' Patalgedan dagiti pagalagadan sakbay a maidulin ti factura (HU-15)
    ''' </summary>
    Public Function EmitirFactura(idEstadia As Integer, total As Decimal, detalles As List(Of Factura_Detalle)) As String
        If idEstadia <= 0 Then
            Return "El número de estadía es inválido."
        End If

        ' 1. Kitaen no adda dayta nga estadía
        Dim est As Estadia = _estadiaDatos.BuscarPorId(idEstadia)
        If est Is Nothing Then
            Return "La estadía no existe."
        End If

        ' 2. Regla HU-15: Masapul a nalpasen ti check-out
        If Not est.estadoPago.Equals("Finalizada", StringComparison.OrdinalIgnoreCase) Then
            Return "Primero debe registrarse el check-out para poder facturar."
        End If

        ' 3. Masapul a saan a doble ti panaka-facturar
        If _facturaDatos.ExisteFactura(idEstadia) Then
            Return "Esta estadía ya posee una factura emitida."
        End If

        ' 4. Iyadipen ti ulo ti Factura
        Dim nuevaFactura As New Factura() With {
            .id_estadia = idEstadia,
            .fecha_emision = DateTime.Now,
            .total = total
        }

        Dim idFacturaGenerada As Integer = _facturaDatos.RegistrarFactura(nuevaFactura)
        If idFacturaGenerada <= 0 Then
            Return "Error al registrar la factura en la base de datos."
        End If

        ' 5. Ipasdek ti tunggal linya ti detalye
        If detalles IsNot Nothing Then
            For Each item In detalles
                item.id_factura = idFacturaGenerada
                _facturaDatos.RegistrarDetalle(item)
            Next
        End If

        Return "OK"
    End Function

    ''' <summary>
    ''' Alaen ti nailukat a bayad tapno maikkat iti pagbayadan
    ''' </summary>
    Public Function ObtenerAnticipoPagado(idEstadia As Integer) As Decimal
        If idEstadia <= 0 Then
            Return 0D
        End If
        Return _pagoDatos.ObtenerTotalPagado(idEstadia)
    End Function
End Class