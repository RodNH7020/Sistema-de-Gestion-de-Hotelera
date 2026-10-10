Imports CapaEntidades
Imports Microsoft.Data.SqlClient
Imports SistemaHotelero

Public Class ConsumoDatos
    Private ReadOnly conexionBD As New Conexion()

    ' Registrar un consumo extra
    Public Function Insertar(c As Consumo) As Boolean
        Dim query As String = "INSERT INTO Consumo (id_estadia, descripcion, fecha, monto) " &
                              "VALUES (@idEstadia, @descripcion, @fecha, @monto)"
        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idEstadia", c.id_estadia)
                cmd.Parameters.AddWithValue("@descripcion", c.descripcion)
                cmd.Parameters.AddWithValue("@fecha", c.fecha)
                cmd.Parameters.AddWithValue("@monto", c.monto)

                con.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    ' Obtener total de consumos acumulados de una estadía
    Public Function ObtenerTotalConsumos(idEstadia As Integer) As Decimal
        Dim total As Decimal = 0
        Dim query As String = "SELECT ISNULL(SUM(monto), 0) FROM Consumo WHERE id_estadia = @idEstadia"

        Using con As SqlConnection = conexionBD.ObtenerConexion()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@idEstadia", idEstadia)
                con.Open()
                total = Convert.ToDecimal(cmd.ExecuteScalar())
            End Using
        End Using
        Return total
    End Function
End Class