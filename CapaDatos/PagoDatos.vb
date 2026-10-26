Imports System.Data
Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class PagoDatos
    Private ReadOnly conexionBD As New Conexion()


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


    Public Function ObtenerTotalPagado(idEstadia As Integer) As Decimal
        Dim total As Decimal = 0D
        Dim query As String = "SELECT ISNULL(SUM(monto), 0) FROM Pago WHERE id_estadia = @idEstadia"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idEstadia", idEstadia)
                con.Open()
                total = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using

        Return total
    End Function


    Public Function ListarPorEstadia(idEstadia As Integer) As List(Of Pago)
        Dim lista As New List(Of Pago)()
        Dim query As String = "SELECT id_pago, id_estadia, monto, fecha_pago, metodo_pago, tipo_pago " &
                              "FROM Pago WHERE id_estadia = @idEstadia"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idEstadia", idEstadia)
                con.Open()
                Using dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        Dim pg As New Pago() With {
                            .id_pago = Convert.ToInt32(dr("id_pago")),
                            .id_estadia = Convert.ToInt32(dr("id_estadia")),
                            .monto = Convert.ToDecimal(dr("monto")),
                            .fecha_pago = Convert.ToDateTime(dr("fecha_pago")),
                            .metodo_pago = dr("metodo_pago").ToString(),
                            .tipo_pago = dr("tipo_pago").ToString()
                        }
                        lista.Add(pg)
                    End While
                End Using
            End Using
        End Using

        Return lista
    End Function

End Class