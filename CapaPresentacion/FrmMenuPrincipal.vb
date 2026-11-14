Imports System.ComponentModel
Imports System.Windows.Forms

Public Class FrmMenuPrincipal

    ' Propiedades que reciben los datos desde FormularioLogin
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property UsuarioActual As String = "Rodrigo"

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property RolActual As String = "Administrador"

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuarioActivo.Text = $"Usuario: {UsuarioActual}   |   Función: {RolActual}"
    End Sub

    Private Sub btnMenuRegistrar_Click(sender As Object, e As EventArgs) Handles btnMenuRegistrar.Click, picRegistrar.Click
        Dim frmRegistrar As New FrmRegistrarReserva()
        frmRegistrar.ShowDialog()
    End Sub

    Private Sub btnMenuAnular_Click(sender As Object, e As EventArgs) Handles btnMenuAnular.Click, picAnular.Click
        Dim frmAnular As New FrmAnularReserva()
        frmAnular.ShowDialog()
    End Sub

    Private Sub btnMenuGestionReservas_Click(sender As Object, e As EventArgs) Handles btnMenuGestionReservas.Click, picGestionReservas.Click
        Dim frmGestion As New FrmGestionReservas()
        frmGestion.ShowDialog()
    End Sub

    Private Sub btnMenuEmitirFactura_Click(sender As Object, e As EventArgs) Handles btnMenuEmitirFactura.Click, picEmitirFactura.Click
        Dim frmFactura As New FrmEmitirFactura()
        frmFactura.ShowDialog()
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Dim frmLogin As New FormularioLogin()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

End Class