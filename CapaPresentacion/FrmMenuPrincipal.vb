Imports System.Windows.Forms

Public Class FrmMenuPrincipal
    Private Sub btnMenuRegistrar_Click(sender As Object, e As EventArgs) Handles btnMenuRegistrar.Click
        Dim frmRegistrar As New FrmRegistrarReserva()
        frmRegistrar.ShowDialog() ' ShowDialog bloquea el menú hasta que cierren la ventana de registro (opcional)
    End Sub

    Private Sub btnMenuAnular_Click(sender As Object, e As EventArgs) Handles btnMenuAnular.Click
        ' Instanciamos y mostramos el formulario de anulación
        Dim frmAnular As New FrmAnularReserva()
        frmAnular.ShowDialog()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            ' Mostramos nuevamente el login y cerramos el menú actual
            Dim frmLogin As New FormularioLogin()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class