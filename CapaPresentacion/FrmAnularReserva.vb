Imports System.Windows.Forms
Imports CapaNegocio

Public Class FrmAnularReserva

    Private Sub FrmAnularReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar todas las reservas activas al abrir la ventana
        CargarGrilla("")
    End Sub

    Private Sub CargarGrilla(filtro As String)
        Try
            Dim reservaNeg As New ReservaNegocio()
            ' Asumiendo que pasas el filtro al negocio:
            ' dgvReservas.DataSource = reservaNeg.ListarReservasActivas(filtro)
        Catch ex As Exception
            MessageBox.Show("Error al cargar las reservas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento que se dispara automáticamente cada vez que el usuario escribe en el buscador
    Private Sub TBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBuscar.TextChanged
        CargarGrilla(TBuscar.Text.Trim())
    End Sub

    Private Sub BAnularReserva_Click(sender As Object, e As EventArgs) Handles BAnularReserva.Click
        ' 1. Validar que haya una fila seleccionada
        If dgvReservas.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, seleccione una reserva de la tabla para cancelar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Obtener el ID de la reserva y el nombre del huésped desde la fila seleccionada
        Dim fila As DataGridViewRow = dgvReservas.SelectedRows(0)
        Dim idReserva As Integer = Convert.ToInt32(fila.Cells("id_reservas").Value)
        Dim nombreHuesped As Object = fila.Cells("Huésped").Value

        ' 3. Confirmación de seguridad
        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de cancelar la reserva del huésped " & nombreHuesped.ToString() & "?",
                                                           "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmacion = DialogResult.Yes Then
            Try
                Dim reservaNeg As New ReservaNegocio()
                If reservaNeg.CancelarReserva(idReserva) Then
                    MessageBox.Show("Reserva cancelada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Recargar la grilla limpia
                    CargarGrilla(TBuscar.Text.Trim())
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class