<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TMenu = New System.Windows.Forms.Label()
        Me.pnlBarraUsuario = New System.Windows.Forms.Panel()
        Me.lblUsuarioActivo = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.picRegistrar = New System.Windows.Forms.PictureBox()
        Me.btnMenuRegistrar = New System.Windows.Forms.Button()
        Me.picAnular = New System.Windows.Forms.PictureBox()
        Me.btnMenuAnular = New System.Windows.Forms.Button()
        Me.picCheckInOut = New System.Windows.Forms.PictureBox()
        Me.btnMenuCheckInOut = New System.Windows.Forms.Button()
        Me.picHabitaciones = New System.Windows.Forms.PictureBox()
        Me.btnMenuHabitaciones = New System.Windows.Forms.Button()
        Me.picEmitirFactura = New System.Windows.Forms.PictureBox()
        Me.btnMenuEmitirFactura = New System.Windows.Forms.Button()
        Me.picGestionReservas = New System.Windows.Forms.PictureBox()
        Me.btnMenuGestionReservas = New System.Windows.Forms.Button()
        Me.picRegistrarPago = New System.Windows.Forms.PictureBox()
        Me.btnMenuRegistrarPago = New System.Windows.Forms.Button()
        Me.picOpcion8 = New System.Windows.Forms.PictureBox()
        Me.btnOpcion8 = New System.Windows.Forms.Button()

        Me.Panel1.SuspendLayout()
        Me.pnlBarraUsuario.SuspendLayout()
        CType(Me.picRegistrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAnular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckInOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEmitirFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGestionReservas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRegistrarPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOpcion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' =========================================================
        ' 1. BARRA SUPERIOR NEGRA
        ' =========================================================
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 60)
        Me.Panel1.TabIndex = 0

        Me.TMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TMenu.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TMenu.ForeColor = System.Drawing.Color.White
        Me.TMenu.Location = New System.Drawing.Point(0, 0)
        Me.TMenu.Name = "TMenu"
        Me.TMenu.Size = New System.Drawing.Size(920, 60)
        Me.TMenu.Text = "HOTEL TEKOHA - Menú Principal"
        Me.TMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' =========================================================
        ' 2. FRANJA DE USUARIO ACTIVO Y CERRAR SESIÓN (#282828)
        ' =========================================================
        Me.pnlBarraUsuario.BackColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Me.pnlBarraUsuario.Controls.Add(Me.lblUsuarioActivo)
        Me.pnlBarraUsuario.Controls.Add(Me.btnCerrarSesion)
        Me.pnlBarraUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraUsuario.Location = New System.Drawing.Point(0, 60)
        Me.pnlBarraUsuario.Name = "pnlBarraUsuario"
        Me.pnlBarraUsuario.Size = New System.Drawing.Size(920, 40)
        Me.pnlBarraUsuario.TabIndex = 1

        Me.lblUsuarioActivo.AutoSize = True
        Me.lblUsuarioActivo.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsuarioActivo.ForeColor = System.Drawing.Color.White
        Me.lblUsuarioActivo.Location = New System.Drawing.Point(45, 11)
        Me.lblUsuarioActivo.Name = "lblUsuarioActivo"
        Me.lblUsuarioActivo.Size = New System.Drawing.Size(270, 19)
        Me.lblUsuarioActivo.TabIndex = 0
        Me.lblUsuarioActivo.Text = "Usuario: Rodrigo   |   Rol: Administrador"

        Me.btnCerrarSesion.BackColor = System.Drawing.Color.Crimson
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Location = New System.Drawing.Point(755, 6)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(120, 28)
        Me.btnCerrarSesion.TabIndex = 1
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False

        ' =========================================================
        ' FILA 1 - COLUMNA 1: REGISTRAR RESERVA
        ' =========================================================
        Me.picRegistrar.BackColor = System.Drawing.Color.White
        Me.picRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRegistrar.Location = New System.Drawing.Point(45, 130)
        Me.picRegistrar.Name = "picRegistrar"
        Me.picRegistrar.Padding = New System.Windows.Forms.Padding(10)
        Me.picRegistrar.Size = New System.Drawing.Size(185, 130)
        Me.picRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRegistrar.TabIndex = 2
        Me.picRegistrar.TabStop = False

        Me.btnMenuRegistrar.BackColor = System.Drawing.Color.Crimson
        Me.btnMenuRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuRegistrar.FlatAppearance.BorderSize = 0
        Me.btnMenuRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuRegistrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnMenuRegistrar.Location = New System.Drawing.Point(45, 265)
        Me.btnMenuRegistrar.Name = "btnMenuRegistrar"
        Me.btnMenuRegistrar.Size = New System.Drawing.Size(185, 42)
        Me.btnMenuRegistrar.TabIndex = 3
        Me.btnMenuRegistrar.Text = "Registrar Reserva"
        Me.btnMenuRegistrar.UseVisualStyleBackColor = False

        ' =========================================================
        ' FILA 1 - COLUMNA 2: ANULAR RESERVA
        ' =========================================================
        Me.picAnular.BackColor = System.Drawing.Color.White
        Me.picAnular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAnular.Location = New System.Drawing.Point(260, 130)
        Me.picAnular.Name = "picAnular"
        Me.picAnular.Padding = New System.Windows.Forms.Padding(10)
        Me.picAnular.Size = New System.Drawing.Size(185, 130)
        Me.picAnular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAnular.TabIndex = 4
        Me.picAnular.TabStop = False

        Me.btnMenuAnular.BackColor = System.Drawing.Color.Crimson
        Me.btnMenuAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuAnular.FlatAppearance.BorderSize = 0
        Me.btnMenuAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuAnular.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuAnular.ForeColor = System.Drawing.Color.White
        Me.btnMenuAnular.Location = New System.Drawing.Point(260, 265)
        Me.btnMenuAnular.Name = "btnMenuAnular"
        Me.btnMenuAnular.Size = New System.Drawing.Size(185, 42)
        Me.btnMenuAnular.TabIndex = 5
        Me.btnMenuAnular.Text = "Anular Reserva"
        Me.btnMenuAnular.UseVisualStyleBackColor = False

        ' =========================================================
        ' FILA 1 - COLUMNA 3: OPCIÓN 3
        ' =========================================================
        Me.picCheckInOut.BackColor = System.Drawing.Color.White
        Me.picCheckInOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCheckInOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCheckInOut.Location = New System.Drawing.Point(475, 130)
        Me.picCheckInOut.Name = "picCheckInOut"
        Me.picCheckInOut.Padding = New System.Windows.Forms.Padding(10)
        Me.picCheckInOut.Size = New System.Drawing.Size(185, 130)
        Me.picCheckInOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheckInOut.TabIndex = 6
        Me.picCheckInOut.TabStop = False

        Me.btnMenuCheckInOut.BackColor = System.Drawing.Color.Crimson
        Me.btnMenuCheckInOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuCheckInOut.FlatAppearance.BorderSize = 0
        Me.btnMenuCheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuCheckInOut.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuCheckInOut.ForeColor = System.Drawing.Color.White
        Me.btnMenuCheckInOut.Location = New System.Drawing.Point(475, 265)
        Me.btnMenuCheckInOut.Name = "btnMenuCheckInOut"
        Me.btnMenuCheckInOut.Size = New System.Drawing.Size(185, 42)
        Me.btnMenuCheckInOut.TabIndex = 7
        Me.btnMenuCheckInOut.Text = "Opción 3"
        Me.btnMenuCheckInOut.UseVisualStyleBackColor = False

        ' =========================================================
        ' FILA 1 - COLUMNA 4: OPCIÓN 4
        ' =========================================================
        Me.picHabitaciones.BackColor = System.Drawing.Color.White
        Me.picHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picHabitaciones.Location = New System.Drawing.Point(690, 130)
        Me.picHabitaciones.Name = "picHabitaciones"
        Me.picHabitaciones.Padding = New System.Windows.Forms.Padding(10)
        Me.picHabitaciones.Size = New System.Drawing.Size(185, 130)
        Me.picHabitaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHabitaciones.TabIndex = 8
        Me.picHabitaciones.TabStop = False

        Me.btnMenuHabitaciones.BackColor = System.Drawing.Color.Crimson
        Me.btnMenuHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuHabitaciones.FlatAppearance.BorderSize = 0
        Me.btnMenuHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuHabitaciones.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuHabitaciones.ForeColor = System.Drawing.Color.White
        Me.btnMenuHabitaciones.Location = New System.Drawing.Point(690, 265)
        Me.btnMenuHabitaciones.Name = "btnMenuHabitaciones"
        Me.btnMenuHabitaciones.Size = New System.Drawing.Size(185, 42)
        Me.btnMenuHabitaciones.TabIndex = 9
        Me.btnMenuHabitaciones.Text = "Opción 4"
        Me.btnMenuHabitaciones.UseVisualStyleBackColor = False

        ' =========================================================
        ' FILA 2 - COLUMNA 1: EMITIR FACTURA
        ' =========================================================
        Me.picEmitirFactura.BackColor = System.Drawing.Color.White
        Me.picEmitirFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEmitirFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picEmitirFactura.Location = New System.Drawing.Point(45, 340)
        Me.picEmitirFactura.Name = "picEmitirFactura"
        Me.picEmitirFactura.Padding = New System.Windows.Forms.Padding(10)
        Me.picEmitirFactura.Size = New System.Drawing.Size(185, 130)
        Me.picEmitirFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEmitirFactura.TabIndex = 10
        Me.picEmitirFactura.TabStop = False

        Me.btnMenuEmitirFactura.BackColor = System.Drawing.Color.Crimson
        Me.btnMenuEmitirFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuEmitirFactura.FlatAppearance.BorderSize = 0
        Me.btnMenuEmitirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuEmitirFactura.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuEmitirFactura.ForeColor = System.Drawing.Color.White
        Me.btnMenuEmitirFactura.Location = New System.Drawing.Point(45, 475)
        Me.btnMenuEmitirFactura.Name = "btnMenuEmitirFactura"
        Me.btnMenuEmitirFactura.Size = New System.Drawing.Size(185, 42)
        Me.btnMenuEmitirFactura.TabIndex = 11
        Me.btnMenuEmitirFactura.Text = "Emitir Factura"
        Me.btnMenuEmitirFactura.UseVisualStyleBackColor = False

        ' =========================================================
        ' FILA 2 - COLUMNA 2: GESTIÓN RESERVAS
        ' =========================================================
        Me.picGestionReservas.BackColor = System.Drawing.Color.White
        Me.picGestionReservas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGestionReservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picGestionReservas.Location = New System.Drawing.Point(260, 340)
        Me.picGestionReservas.Name = "picGestionReservas"
        Me.picGestionReservas.Padding = New System.Windows.Forms.Padding(10)
        Me.picGestionReservas.Size = New System.Drawing.Size(185, 130)
        Me.picGestionReservas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGestionReservas.TabIndex = 12
        Me.picGestionReservas.TabStop = False

        Me.btnMenuGestionReservas.BackColor = System.Drawing.Color.Crimson
        Me.btnMenuGestionReservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuGestionReservas.FlatAppearance.BorderSize = 0
        Me.btnMenuGestionReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuGestionReservas.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuGestionReservas.ForeColor = System.Drawing.Color.White
        Me.btnMenuGestionReservas.Location = New System.Drawing.Point(260, 475)
        Me.btnMenuGestionReservas.Name = "btnMenuGestionReservas"
        Me.btnMenuGestionReservas.Size = New System.Drawing.Size(185, 42)
        Me.btnMenuGestionReservas.TabIndex = 13
        Me.btnMenuGestionReservas.Text = "Gestión Reservas"
        Me.btnMenuGestionReservas.UseVisualStyleBackColor = False

        ' =========================================================
        ' FILA 2 - COLUMNA 3: OPCIÓN 7
        ' =========================================================
        Me.picRegistrarPago.BackColor = System.Drawing.Color.White
        Me.picRegistrarPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRegistrarPago.Location = New System.Drawing.Point(475, 340)
        Me.picRegistrarPago.Name = "picRegistrarPago"
        Me.picRegistrarPago.Padding = New System.Windows.Forms.Padding(10)
        Me.picRegistrarPago.Size = New System.Drawing.Size(185, 130)
        Me.picRegistrarPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRegistrarPago.TabIndex = 14
        Me.picRegistrarPago.TabStop = False

        Me.btnMenuRegistrarPago.BackColor = System.Drawing.Color.Crimson
        Me.btnMenuRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuRegistrarPago.FlatAppearance.BorderSize = 0
        Me.btnMenuRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuRegistrarPago.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMenuRegistrarPago.ForeColor = System.Drawing.Color.White
        Me.btnMenuRegistrarPago.Location = New System.Drawing.Point(475, 475)
        Me.btnMenuRegistrarPago.Name = "btnMenuRegistrarPago"
        Me.btnMenuRegistrarPago.Size = New System.Drawing.Size(185, 42)
        Me.btnMenuRegistrarPago.TabIndex = 15
        Me.btnMenuRegistrarPago.Text = "Opción 7"
        Me.btnMenuRegistrarPago.UseVisualStyleBackColor = False

        ' =========================================================
        ' FILA 2 - COLUMNA 4: OPCIÓN 8
        ' =========================================================
        Me.picOpcion8.BackColor = System.Drawing.Color.White
        Me.picOpcion8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picOpcion8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picOpcion8.Location = New System.Drawing.Point(690, 340)
        Me.picOpcion8.Name = "picOpcion8"
        Me.picOpcion8.Padding = New System.Windows.Forms.Padding(10)
        Me.picOpcion8.Size = New System.Drawing.Size(185, 130)
        Me.picOpcion8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOpcion8.TabIndex = 16
        Me.picOpcion8.TabStop = False

        Me.btnOpcion8.BackColor = System.Drawing.Color.Crimson
        Me.btnOpcion8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpcion8.FlatAppearance.BorderSize = 0
        Me.btnOpcion8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpcion8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOpcion8.ForeColor = System.Drawing.Color.White
        Me.btnOpcion8.Location = New System.Drawing.Point(690, 475)
        Me.btnOpcion8.Name = "btnOpcion8"
        Me.btnOpcion8.Size = New System.Drawing.Size(185, 42)
        Me.btnOpcion8.TabIndex = 17
        Me.btnOpcion8.Text = "Opción 8"
        Me.btnOpcion8.UseVisualStyleBackColor = False

        ' =========================================================
        ' VENTANA PRINCIPAL
        ' =========================================================
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(242, 242, 242)
        Me.ClientSize = New System.Drawing.Size(920, 560)
        Me.Controls.Add(Me.btnOpcion8)
        Me.Controls.Add(Me.picOpcion8)
        Me.Controls.Add(Me.btnMenuRegistrarPago)
        Me.Controls.Add(Me.picRegistrarPago)
        Me.Controls.Add(Me.btnMenuGestionReservas)
        Me.Controls.Add(Me.picGestionReservas)
        Me.Controls.Add(Me.btnMenuEmitirFactura)
        Me.Controls.Add(Me.picEmitirFactura)
        Me.Controls.Add(Me.btnMenuHabitaciones)
        Me.Controls.Add(Me.picHabitaciones)
        Me.Controls.Add(Me.btnMenuCheckInOut)
        Me.Controls.Add(Me.picCheckInOut)
        Me.Controls.Add(Me.btnMenuAnular)
        Me.Controls.Add(Me.picAnular)
        Me.Controls.Add(Me.btnMenuRegistrar)
        Me.Controls.Add(Me.picRegistrar)
        Me.Controls.Add(Me.pnlBarraUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal - Hotel Tekoha"

        Me.Panel1.ResumeLayout(False)
        Me.pnlBarraUsuario.ResumeLayout(False)
        Me.pnlBarraUsuario.PerformLayout()
        CType(Me.picRegistrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAnular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckInOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEmitirFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGestionReservas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRegistrarPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOpcion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TMenu As System.Windows.Forms.Label
    Friend WithEvents pnlBarraUsuario As System.Windows.Forms.Panel
    Friend WithEvents lblUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents picRegistrar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenuRegistrar As System.Windows.Forms.Button
    Friend WithEvents picAnular As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenuAnular As System.Windows.Forms.Button
    Friend WithEvents picCheckInOut As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenuCheckInOut As System.Windows.Forms.Button
    Friend WithEvents picHabitaciones As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenuHabitaciones As System.Windows.Forms.Button
    Friend WithEvents picEmitirFactura As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenuEmitirFactura As System.Windows.Forms.Button
    Friend WithEvents picGestionReservas As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenuGestionReservas As System.Windows.Forms.Button
    Friend WithEvents picRegistrarPago As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenuRegistrarPago As System.Windows.Forms.Button
    Friend WithEvents picOpcion8 As System.Windows.Forms.PictureBox
    Friend WithEvents btnOpcion8 As System.Windows.Forms.Button
End Class