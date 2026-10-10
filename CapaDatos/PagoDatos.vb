Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class PagoDatos
    Private ReadOnly conexionBD As New Conexion()

    ' Registrar pago o anticipo
    Public Function Insertar(p As Pago) As Boolean
        Dim query As String = "INSERT INTO Pago (id_estadia, fecha_pago, monto, metodo_pago, tipo_pago) " &
                              "VALUES (@idEstadia, @fechaPago, @monto, @metodoPago, @tipoPago)"
        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idEstadia", p.id_estadia)
                cmd.Parameters.AddWithValue("@fechaPago", p.fecha_pago)
                cmd.Parameters.AddWithValue("@monto", p.monto)
                cmd.Parameters.AddWithValue("@metodoPago", p.metodo_pago)
                cmd.Parameters.AddWithValue("@tipoPago", p.tipo_pago)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
End Class