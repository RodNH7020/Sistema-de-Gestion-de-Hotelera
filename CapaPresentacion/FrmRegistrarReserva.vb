Imports System.Windows.Forms
Imports CapaEntidades
Imports CapaNegocio
Imports SistemaHotelero

Public Class FrmRegistrarReserva

    Private Sub FrmRegistrarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuramos los calendarios (DateTimePicker)
        ' Evitamos que seleccionen fechas de ingreso anteriores al día de hoy
        dtpFechaIngreso.MinDate = DateTime.Today
        dtpFechaSalida.MinDate = DateTime.Today.AddDays(1)

        ' Cargar datos en los ComboBox (Huéspedes y Habitaciones)
        CargarCombos()
    End Sub

    Private Sub dtpFechaIngreso_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaIngreso.ValueChanged
        ' Regla de calendario inteligente: 
        ' La fecha mínima de salida siempre debe ser al menos el día posterior al ingreso seleccionado
        dtpFechaSalida.MinDate = dtpFechaIngreso.Value.AddDays(1)
    End Sub

    Private Sub CargarCombos()
        Try
            ' Cargar Habitaciones Disponibles
            Dim habitacionNeg As New HabitacionNegocio()
            cboHabitacion.DataSource = habitacionNeg.ListarDisponibles()
            cboHabitacion.DisplayMember = "numero"
            cboHabitacion.ValueMember = "id_habitacion"

            ' Cargar Huéspedes
            Dim huespedNeg As New HuespedNegocio()
            COBHuesped.DataSource = huespedNeg.ListarHuespedes()
            COBHuesped.DisplayMember = "apellido"
            COBHuesped.ValueMember = "id_huesped"

        Catch ex As Exception
            MessageBox.Show("Error al cargar los listados: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BRegistrarReserva_Click(sender As Object, e As EventArgs) Handles BRegistrarReserva.Click
        Try
            ' 1. Validaciones básicas de selección en la UI
            If COBHuesped.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar un huésped.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If cboHabitacion.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar una habitación.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' 2. Crear la entidad de Reserva con los datos de la interfaz
            Dim reserva As New Reserva()

            ' Suponiendo que el ValueMember del combo devuelve el ID numérico:
            reserva.id_huesped = Convert.ToInt32(COBHuesped.SelectedValue)
            reserva.id_habitacion = Convert.ToInt32(cboHabitacion.SelectedValue)

            reserva.id_usuario = SesionActual.IdUsuario

            reserva.fecha_reserva = DateTime.Today

            reserva.fecha_ingreso = dtpFechaIngreso.Value.Date
            reserva.fecha_salida = dtpFechaSalida.Value.Date
            reserva.estado = "Activa"

            ' 3. Instanciar la capa de negocio de reservas que ya teníamos creada
            Dim reservaNeg As New ReservaNegocio()

            ' 4. Ejecutar el registro (esto disparará las validaciones de negocio de fechas)
            Dim resultado As Boolean = reservaNeg.InsertarReserva(reserva)

            If resultado Then
                MessageBox.Show("¡Reserva registrada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        Catch ex As Exception
            ' Captura las excepciones lanzadas por las reglas de negocio (ej. fechas inválidas)
            MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class