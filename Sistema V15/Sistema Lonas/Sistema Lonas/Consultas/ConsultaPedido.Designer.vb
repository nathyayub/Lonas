<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaPedido
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtCampo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.CodPed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValPedTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataPet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PraMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PraMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DtPag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnok = New System.Windows.Forms.Button()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCampo
        '
        Me.TxtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampo.Location = New System.Drawing.Point(12, 53)
        Me.TxtCampo.Name = "TxtCampo"
        Me.TxtCampo.Size = New System.Drawing.Size(109, 26)
        Me.TxtCampo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Digite o código do pedido"
        '
        'DgdGrade
        '
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodPed, Me.CodCli, Me.NomCli, Me.Tel, Me.ValPedTot, Me.DataPet, Me.PraMin, Me.PraMax, Me.Pago, Me.DtPag})
        Me.DgdGrade.Location = New System.Drawing.Point(12, 106)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.Size = New System.Drawing.Size(1196, 264)
        Me.DgdGrade.TabIndex = 9
        '
        'CodPed
        '
        Me.CodPed.DataPropertyName = "CodPed"
        Me.CodPed.HeaderText = "Código do Pedido"
        Me.CodPed.Name = "CodPed"
        '
        'CodCli
        '
        Me.CodCli.DataPropertyName = "CodCli"
        Me.CodCli.HeaderText = "Código do Cliente"
        Me.CodCli.Name = "CodCli"
        '
        'NomCli
        '
        Me.NomCli.DataPropertyName = "NomCli"
        Me.NomCli.HeaderText = "Nome do Cliente"
        Me.NomCli.Name = "NomCli"
        '
        'Tel
        '
        Me.Tel.DataPropertyName = "Tel"
        Me.Tel.HeaderText = "Telefone do Cliente"
        Me.Tel.Name = "Tel"
        '
        'ValPedTot
        '
        Me.ValPedTot.DataPropertyName = "ValPedTot"
        Me.ValPedTot.HeaderText = "Valor Total"
        Me.ValPedTot.Name = "ValPedTot"
        '
        'DataPet
        '
        Me.DataPet.DataPropertyName = "DataPed"
        Me.DataPet.HeaderText = "Data do Pedido"
        Me.DataPet.Name = "DataPet"
        '
        'PraMin
        '
        Me.PraMin.DataPropertyName = "PraMin"
        Me.PraMin.HeaderText = "Prazo Mínimo"
        Me.PraMin.Name = "PraMin"
        '
        'PraMax
        '
        Me.PraMax.DataPropertyName = "PraMax"
        Me.PraMax.HeaderText = "Prazo Máximo"
        Me.PraMax.Name = "PraMax"
        '
        'Pago
        '
        Me.Pago.DataPropertyName = "Pago"
        Me.Pago.HeaderText = "Pago"
        Me.Pago.Name = "Pago"
        Me.Pago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DtPag
        '
        Me.DtPag.DataPropertyName = "DtPag"
        Me.DtPag.HeaderText = "Data do Pagamento"
        Me.DtPag.Name = "DtPag"
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(127, 53)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(110, 27)
        Me.btnok.TabIndex = 10
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'ConsultaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 407)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.TxtCampo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ConsultaPedido"
        Me.Text = "ConsultaPedido"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents CodPed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomCli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValPedTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataPet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PraMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PraMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pago As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DtPag As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
