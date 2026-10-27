<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmitirFactura
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblIdEstadia = New System.Windows.Forms.Label()
        Me.txtIdEstadia = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblTipoFactura = New System.Windows.Forms.Label()
        Me.cboTipoFactura = New System.Windows.Forms.ComboBox()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.lblTotalBruto = New System.Windows.Forms.Label()
        Me.txtTotalBruto = New System.Windows.Forms.TextBox()
        Me.lblAnticipo = New System.Windows.Forms.Label()
        Me.txtAnticipo = New System.Windows.Forms.TextBox()
        Me.lblSaldoPagar = New System.Windows.Forms.Label()
        Me.txtSaldoPagar = New System.Windows.Forms.TextBox()
        Me.lblCuit = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.btnEmitirFactura = New System.Windows.Forms.Button()
        Me.pnlMensajeExito = New System.Windows.Forms.Panel()
        Me.lblMensajeExito = New System.Windows.Forms.Label()
        Me.pnlMensajeError = New System.Windows.Forms.Panel()
        Me.lblMensajeError = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMensajeExito.SuspendLayout()
        Me.pnlMensajeError.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Black
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(460, 50)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(460, 50)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Emisión de Factura"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIdEstadia
        '
        Me.lblIdEstadia.AutoSize = True
        Me.lblIdEstadia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdEstadia.Location = New System.Drawing.Point(35, 75)
        Me.lblIdEstadia.Name = "lblIdEstadia"
        Me.lblIdEstadia.Size = New System.Drawing.Size(111, 15)
        Me.lblIdEstadia.TabIndex = 1
        Me.lblIdEstadia.Text = "Número de Estadía:"
        '
        'txtIdEstadia
        '
        Me.txtIdEstadia.Location = New System.Drawing.Point(170, 72)
        Me.txtIdEstadia.Name = "txtIdEstadia"
        Me.txtIdEstadia.Size = New System.Drawing.Size(150, 23)
        Me.txtIdEstadia.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBuscar.Location = New System.Drawing.Point(330, 71)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 25)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblTipoFactura
        '
        Me.lblTipoFactura.AutoSize = True
        Me.lblTipoFactura.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTipoFactura.Location = New System.Drawing.Point(35, 110)
        Me.lblTipoFactura.Name = "lblTipoFactura"
        Me.lblTipoFactura.Size = New System.Drawing.Size(90, 15)
        Me.lblTipoFactura.TabIndex = 4
        Me.lblTipoFactura.Text = "Tipo de Factura:"
        '
        'cboTipoFactura
        '
        Me.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoFactura.FormattingEnabled = True
        Me.cboTipoFactura.Location = New System.Drawing.Point(170, 107)
        Me.cboTipoFactura.Name = "cboTipoFactura"
        Me.cboTipoFactura.Size = New System.Drawing.Size(245, 23)
        Me.cboTipoFactura.TabIndex = 5
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblConcepto.Location = New System.Drawing.Point(35, 145)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(61, 15)
        Me.lblConcepto.TabIndex = 6
        Me.lblConcepto.Text = "Concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(170, 142)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(245, 23)
        Me.txtConcepto.TabIndex = 7
        '
        'lblTotalBruto
        '
        Me.lblTotalBruto.AutoSize = True
        Me.lblTotalBruto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalBruto.Location = New System.Drawing.Point(35, 180)
        Me.lblTotalBruto.Name = "lblTotalBruto"
        Me.lblTotalBruto.Size = New System.Drawing.Size(67, 15)
        Me.lblTotalBruto.TabIndex = 8
        Me.lblTotalBruto.Text = "Total Bruto:"
        '
        'txtTotalBruto
        '
        Me.txtTotalBruto.Location = New System.Drawing.Point(170, 177)
        Me.txtTotalBruto.Name = "txtTotalBruto"
        Me.txtTotalBruto.ReadOnly = True
        Me.txtTotalBruto.Size = New System.Drawing.Size(245, 23)
        Me.txtTotalBruto.TabIndex = 9
        '
        'lblAnticipo
        '
        Me.lblAnticipo.AutoSize = True
        Me.lblAnticipo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAnticipo.Location = New System.Drawing.Point(35, 215)
        Me.lblAnticipo.Name = "lblAnticipo"
        Me.lblAnticipo.Size = New System.Drawing.Size(107, 15)
        Me.lblAnticipo.TabIndex = 10
        Me.lblAnticipo.Text = "Anticipo ya pagado:"
        '
        'txtAnticipo
        '
        Me.txtAnticipo.Location = New System.Drawing.Point(170, 212)
        Me.txtAnticipo.Name = "txtAnticipo"
        Me.txtAnticipo.ReadOnly = True
        Me.txtAnticipo.Size = New System.Drawing.Size(245, 23)
        Me.txtAnticipo.TabIndex = 11
        '
        'lblSaldoPagar
        '
        Me.lblSaldoPagar.AutoSize = True
        Me.lblSaldoPagar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSaldoPagar.Location = New System.Drawing.Point(35, 250)
        Me.lblSaldoPagar.Name = "lblSaldoPagar"
        Me.lblSaldoPagar.Size = New System.Drawing.Size(89, 15)
        Me.lblSaldoPagar.TabIndex = 12
        Me.lblSaldoPagar.Text = "Saldo a liquidar:"
        '
        'txtSaldoPagar
        '
        Me.txtSaldoPagar.Location = New System.Drawing.Point(170, 247)
        Me.txtSaldoPagar.Name = "txtSaldoPagar"
        Me.txtSaldoPagar.ReadOnly = True
        Me.txtSaldoPagar.Size = New System.Drawing.Size(245, 23)
        Me.txtSaldoPagar.TabIndex = 13
        '
        'lblCuit
        '
        Me.lblCuit.AutoSize = True
        Me.lblCuit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblCuit.Location = New System.Drawing.Point(35, 285)
        Me.lblCuit.Name = "lblCuit"
        Me.lblCuit.Size = New System.Drawing.Size(91, 15)
        Me.lblCuit.TabIndex = 14
        Me.lblCuit.Text = "CUIT (Factura A):"
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(170, 282)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(245, 23)
        Me.txtCuit.TabIndex = 15
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRazonSocial.Location = New System.Drawing.Point(35, 320)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(109, 15)
        Me.lblRazonSocial.TabIndex = 16
        Me.lblRazonSocial.Text = "Nombre / R. Social:"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Location = New System.Drawing.Point(170, 317)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(245, 23)
        Me.txtRazonSocial.TabIndex = 17
        '
        'btnEmitirFactura
        '
        Me.btnEmitirFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnEmitirFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmitirFactura.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEmitirFactura.ForeColor = System.Drawing.Color.White
        Me.btnEmitirFactura.Location = New System.Drawing.Point(170, 295)
        Me.btnEmitirFactura.Name = "btnEmitirFactura"
        Me.btnEmitirFactura.Size = New System.Drawing.Size(245, 38)
        Me.btnEmitirFactura.TabIndex = 18
        Me.btnEmitirFactura.Text = "Emitir Factura"
        Me.btnEmitirFactura.UseVisualStyleBackColor = False
        '
        'pnlMensajeExito
        '
        Me.pnlMensajeExito.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.pnlMensajeExito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMensajeExito.Controls.Add(Me.lblMensajeExito)
        Me.pnlMensajeExito.Location = New System.Drawing.Point(35, 345)
        Me.pnlMensajeExito.Name = "pnlMensajeExito"
        Me.pnlMensajeExito.Size = New System.Drawing.Size(380, 30)
        Me.pnlMensajeExito.TabIndex = 19
        '
        'lblMensajeExito
        '
        Me.lblMensajeExito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMensajeExito.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeExito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblMensajeExito.Location = New System.Drawing.Point(0, 0)
        Me.lblMensajeExito.Name = "lblMensajeExito"
        Me.lblMensajeExito.Size = New System.Drawing.Size(378, 28)
        Me.lblMensajeExito.TabIndex = 0
        Me.lblMensajeExito.Text = "✓ Factura emitida correctamente."
        Me.lblMensajeExito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMensajeError
        '
        Me.pnlMensajeError.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.pnlMensajeError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMensajeError.Controls.Add(Me.lblMensajeError)
        Me.pnlMensajeError.Location = New System.Drawing.Point(35, 383)
        Me.pnlMensajeError.Name = "pnlMensajeError"
        Me.pnlMensajeError.Size = New System.Drawing.Size(380, 30)
        Me.pnlMensajeError.TabIndex = 20
        '
        'lblMensajeError
        '
        Me.lblMensajeError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMensajeError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblMensajeError.Location = New System.Drawing.Point(0, 0)
        Me.lblMensajeError.Name = "lblMensajeError"
        Me.lblMensajeError.Size = New System.Drawing.Size(378, 28)
        Me.lblMensajeError.TabIndex = 0
        Me.lblMensajeError.Text = "⚠ No existe la estadía solicitada."
        Me.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmEmitirFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 430)
        Me.Controls.Add(Me.pnlMensajeError)
        Me.Controls.Add(Me.pnlMensajeExito)
        Me.Controls.Add(Me.btnEmitirFactura)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.lblRazonSocial)
        Me.Controls.Add(Me.txtCuit)
        Me.Controls.Add(Me.lblCuit)
        Me.Controls.Add(Me.txtSaldoPagar)
        Me.Controls.Add(Me.lblSaldoPagar)
        Me.Controls.Add(Me.txtAnticipo)
        Me.Controls.Add(Me.lblAnticipo)
        Me.Controls.Add(Me.txtTotalBruto)
        Me.Controls.Add(Me.lblTotalBruto)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.lblConcepto)
        Me.Controls.Add(Me.cboTipoFactura)
        Me.Controls.Add(Me.lblTipoFactura)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtIdEstadia)
        Me.Controls.Add(Me.lblIdEstadia)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmEmitirFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisión de Factura"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlMensajeExito.ResumeLayout(False)
        Me.pnlMensajeError.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblIdEstadia As System.Windows.Forms.Label
    Friend WithEvents txtIdEstadia As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblTipoFactura As System.Windows.Forms.Label
    Friend WithEvents cboTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalBruto As System.Windows.Forms.Label
    Friend WithEvents txtTotalBruto As System.Windows.Forms.TextBox
    Friend WithEvents lblAnticipo As System.Windows.Forms.Label
    Friend WithEvents txtAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents lblSaldoPagar As System.Windows.Forms.Label
    Friend WithEvents txtSaldoPagar As System.Windows.Forms.TextBox
    Friend WithEvents lblCuit As System.Windows.Forms.Label
    Friend WithEvents txtCuit As System.Windows.Forms.TextBox
    Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents btnEmitirFactura As System.Windows.Forms.Button
    Friend WithEvents pnlMensajeExito As System.Windows.Forms.Panel
    Friend WithEvents lblMensajeExito As System.Windows.Forms.Label
    Friend WithEvents pnlMensajeError As System.Windows.Forms.Panel
    Friend WithEvents lblMensajeError As System.Windows.Forms.Label

End Class