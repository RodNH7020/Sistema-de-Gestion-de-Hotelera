Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class FacturaDatos
    Private ReadOnly conexionBD As New Conexion()

    ' Registrar factura y devolver el ID autogenerado
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

    ' Registrar cada renglón o ítem en Factura_Detalle
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
End Class