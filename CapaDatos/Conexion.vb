Imports Microsoft.Data.SqlClient

Public Class Conexion
    Private ReadOnly Cadena As String = "Data Source=.\SQLEXPRESS;Initial Catalog=SistemaHotelero;Integrated Security=True;"

    Public Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(Cadena)
    End Function
End Class