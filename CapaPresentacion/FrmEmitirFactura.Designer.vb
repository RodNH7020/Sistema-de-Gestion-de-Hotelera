<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmitirFactura
    Inherits System.Windows.Forms.Form

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
        txtIdEstadia = New System.Windows.Forms.TextBox()
        btnBuscarEstadia = New System.Windows.Forms.Button()
        cboTipoFactura = New System.Windows.Forms.ComboBox()
        txtTotalBruto = New System.Windows.Forms.TextBox()
        txtAnticipo = New System.Windows.Forms.TextBox()
        txtSaldoPagar = New System.Windows.Forms.TextBox()
        btnEmitir = New System.Windows.Forms.Button()
        lblIdEstadia = New System.Windows.Forms.Label()
        lblTipoFactura = New System.Windows.Forms.Label()
        lblTotalBruto = New System.Windows.Forms.Label()
        lblAnticipo = New System.Windows.Forms.Label()
        lblSaldoPagar = New System.Windows.Forms.Label()
        SuspendLayout()
        ' 
        ' txtIdEstadia
        ' 
        txtIdEstadia.Location = New System.Drawing.Point(160, 30)
        txtIdEstadia.Name = "txtIdEstadia"
        txtIdEstadia.Size = New System.Drawing.Size(120, 23)
        txtIdEstadia.TabIndex = 0
        ' 
        ' btnBuscarEstadia
        ' 
        btnBuscarEstadia.Location = New System.Drawing.Point(290, 29)
        btnBuscarEstadia.Name = "btnBuscarEstadia"
        btnBuscarEstadia.Size = New System.Drawing.Size(80, 25)
        btnBuscarEstadia.TabIndex = 1
        btnBuscarEstadia.Text = "Buscar"
        btnBuscarEstadia.UseVisualStyleBackColor = True
        ' 
        ' cboTipoFactura
        ' 
        cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboTipoFactura.FormattingEnabled = True
        cboTipoFactura.Location = New System.Drawing.Point(160, 75)
        cboTipoFactura.Name = "cboTipoFactura"
        cboTipoFactura.Size = New System.Drawing.Size(210, 23)
        cboTipoFactura.TabIndex = 2
        ' 
        ' txtTotalBruto
        ' 
        txtTotalBruto.Location = New System.Drawing.Point(160, 120)
        txtTotalBruto.Name = "txtTotalBruto"
        txtTotalBruto.ReadOnly = True
        txtTotalBruto.Size = New System.Drawing.Size(210, 23)
        txtTotalBruto.TabIndex = 3
        ' 
        ' txtAnticipo
        ' 
        txtAnticipo.Location = New System.Drawing.Point(160, 165)
        txtAnticipo.Name = "txtAnticipo"
        txtAnticipo.ReadOnly = True
        txtAnticipo.Size = New System.Drawing.Size(210, 23)
        txtAnticipo.TabIndex = 4
        ' 
        ' txtSaldoPagar
        ' 
        txtSaldoPagar.Location = New System.Drawing.Point(160, 210)
        txtSaldoPagar.Name = "txtSaldoPagar"
        txtSaldoPagar.ReadOnly = True
        txtSaldoPagar.Size = New System.Drawing.Size(210, 23)
        txtSaldoPagar.TabIndex = 5
        ' 
        ' btnEmitir
        ' 
        btnEmitir.BackColor = System.Drawing.Color.ForestGreen
        btnEmitir.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
        btnEmitir.ForeColor = System.Drawing.Color.White
        btnEmitir.Location = New System.Drawing.Point(160, 260)
        btnEmitir.Name = "btnEmitir"
        btnEmitir.Size = New System.Drawing.Size(210, 35)
        btnEmitir.TabIndex = 6
        btnEmitir.Text = "Emitir Factura"
        btnEmitir.UseVisualStyleBackColor = False
        ' 
        ' lblIdEstadia
        ' 
        lblIdEstadia.AutoSize = True
        lblIdEstadia.Location = New System.Drawing.Point(30, 33)
        lblIdEstadia.Name = "lblIdEstadia"
        lblIdEstadia.Size = New System.Drawing.Size(81, 15)
        lblIdEstadia.TabIndex = 7
        lblIdEstadia.Text = "N° de Estadía:"
        ' 
        ' lblTipoFactura
        ' 
        lblTipoFactura.AutoSize = True
        lblTipoFactura.Location = New System.Drawing.Point(30, 78)
        lblTipoFactura.Name = "lblTipoFactura"
        lblTipoFactura.Size = New System.Drawing.Size(91, 15)
        lblTipoFactura.TabIndex = 8
        lblTipoFactura.Text = "Tipo de Factura:"
        ' 
        ' lblTotalBruto
        ' 
        lblTotalBruto.AutoSize = True
        lblTotalBruto.Location = New System.Drawing.Point(30, 123)
        lblTotalBruto.Name = "lblTotalBruto"
        lblTotalBruto.Size = New System.Drawing.Size(68, 15)
        lblTotalBruto.TabIndex = 9
        lblTotalBruto.Text = "Total Bruto:"
        ' 
        ' lblAnticipo
        ' 
        lblAnticipo.AutoSize = True
        lblAnticipo.Location = New System.Drawing.Point(30, 168)
        lblAnticipo.Name = "lblAnticipo"
        lblAnticipo.Size = New System.Drawing.Size(115, 15)
        lblAnticipo.TabIndex = 10
        lblAnticipo.Text = "Anticipo ya pagado:"
        ' 
        ' lblSaldoPagar
        ' 
        lblSaldoPagar.AutoSize = True
        lblSaldoPagar.Location = New System.Drawing.Point(30, 213)
        lblSaldoPagar.Name = "lblSaldoPagar"
        lblSaldoPagar.Size = New System.Drawing.Size(87, 15)
        lblSaldoPagar.TabIndex = 11
        lblSaldoPagar.Text = "Saldo a liquidar:"
        ' 
        ' FrmEmitirFactura
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(420, 330)
        Controls.Add(lblSaldoPagar)
        Controls.Add(lblAnticipo)
        Controls.Add(lblTotalBruto)
        Controls.Add(lblTipoFactura)
        Controls.Add(lblIdEstadia)
        Controls.Add(btnEmitir)
        Controls.Add(txtSaldoPagar)
        Controls.Add(txtAnticipo)
        Controls.Add(txtTotalBruto)
        Controls.Add(cboTipoFactura)
        Controls.Add(btnBuscarEstadia)
        Controls.Add(txtIdEstadia)
        Name = "FrmEmitirFactura"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Emisión de Factura"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIdEstadia As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarEstadia As System.Windows.Forms.Button
    Friend WithEvents cboTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents txtTotalBruto As System.Windows.Forms.TextBox
    Friend WithEvents txtAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoPagar As System.Windows.Forms.TextBox
    Friend WithEvents btnEmitir As System.Windows.Forms.Button
    Friend WithEvents lblIdEstadia As System.Windows.Forms.Label
    Friend WithEvents lblTipoFactura As System.Windows.Forms.Label
    Friend WithEvents lblTotalBruto As System.Windows.Forms.Label
    Friend WithEvents lblAnticipo As System.Windows.Forms.Label
    Friend WithEvents lblSaldoPagar As System.Windows.Forms.Label
End Class