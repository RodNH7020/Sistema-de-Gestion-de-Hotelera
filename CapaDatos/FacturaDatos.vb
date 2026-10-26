Imports System.Data
Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class FacturaDatos
    Private ReadOnly conexionBD As New Conexion()

    ' 1. Registrar factura y devolver el ID autogenerado
    Public Function RegistrarFactura(f As Factura) As Integer
        Dim idGenerado As Integer = 0
        Dim query As String = "INSERT INTO Factura (id_estadia, fecha_emision, total) " &
                              "OUTPUT INSERTED.id_factura " &
                              "VALUES (@idEstadia, @fechaEmision, @total)"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idEstadia", f.id_estadia)
                cmd.Parameters.AddWithValue("@fechaEmision", f.fecha_emision)
                cmd.Parameters.AddWithValue("@total", f.total)

                con.Open()
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
        Return idGenerado
    End Function

    ' 2. Registrar cada renglón o ítem en Factura_Detalle
    Public Function RegistrarDetalle(d As Factura_Detalle) As Boolean
        Dim query As String = "INSERT INTO Factura_Detalle (id_factura, cantidad, descripcion, precio_unitario) " &
                              "VALUES (@idFactura, @cantidad, @descripcion, @precioUnitario)"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idFactura", d.id_factura)
                cmd.Parameters.AddWithValue("@cantidad", d.cantidad)
                cmd.Parameters.AddWithValue("@descripcion", d.descripcion)
                cmd.Parameters.AddWithValue("@precioUnitario", d.precio_unitario)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' 3. NUEVO: Verificar si una estadía ya fue facturada (HU-15)
    Public Function ExisteFactura(idEstadia As Integer) As Boolean
        Dim existe As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM Factura WHERE id_estadia = @idEstadia"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idEstadia", idEstadia)
                con.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                existe = (count > 0)
            End Using
        End Using
        Return existe
    End Function

    ' 4. NUEVO: Obtener la cabecera de la factura mediante el ID de la estadía (para el botón Buscar)
    Public Function ObtenerPorEstadia(idEstadia As Integer) As Factura
        Dim fact As Factura = Nothing
        Dim query As String = "SELECT id_factura, id_estadia, fecha_emision, total " &
                              "FROM Factura WHERE id_estadia = @idEstadia"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idEstadia", idEstadia)
                con.Open()
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        fact = New Factura() With {
                            .id_factura = Convert.ToInt32(dr("id_factura")),
                            .id_estadia = Convert.ToInt32(dr("id_estadia")),
                            .fecha_emision = Convert.ToDateTime(dr("fecha_emision")),
                            .total = Convert.ToDecimal(dr("total"))
                        }
                    End If
                End Using
            End Using
        End Using
        Return fact
    End Function

    ' 5. NUEVO: Obtener los renglones del detalle de una factura
    Public Function ObtenerDetallesPorFactura(idFactura As Integer) As List(Of Factura_Detalle)
        Dim lista As New List(Of Factura_Detalle)()
        Dim query As String = "SELECT id_factDetalle, id_factura, cantidad, descripcion, precio_unitario " &
                              "FROM Factura_Detalle WHERE id_factura = @idFactura"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idFactura", idFactura)
                con.Open()
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim det As New Factura_Detalle() With {
                            .id_facDetalle = Convert.ToInt32(dr("id_factDetalle")),
                            .id_factura = Convert.ToInt32(dr("id_factura")),
                            .cantidad = Convert.ToInt32(dr("cantidad")),
                            .descripcion = dr("descripcion").ToString(),
                            .precio_unitario = Convert.ToDecimal(dr("precio_unitario"))
                        }
                        lista.Add(det)
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function

End Class