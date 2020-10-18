<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaDeMateriais
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
        Me.MskVal = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnMat = New System.Windows.Forms.Button()
        Me.DtaBai = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnEst = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.BtnFor = New System.Windows.Forms.Button()
        Me.TxtNomFor = New System.Windows.Forms.TextBox()
        Me.LblCodCli = New System.Windows.Forms.Label()
        Me.TxtCodFor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomMat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodMat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeMinima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoReabastecimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MskVal
        '
        Me.MskVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskVal.Location = New System.Drawing.Point(250, 110)
        Me.MskVal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MskVal.Mask = "$999999999"
        Me.MskVal.Name = "MskVal"
        Me.MskVal.Size = New System.Drawing.Size(125, 30)
        Me.MskVal.TabIndex = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Valor Total"
        '
        'BtnMat
        '
        Me.BtnMat.Location = New System.Drawing.Point(371, 16)
        Me.BtnMat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMat.Name = "BtnMat"
        Me.BtnMat.Size = New System.Drawing.Size(63, 32)
        Me.BtnMat.TabIndex = 123
        Me.BtnMat.Text = "..."
        Me.BtnMat.UseVisualStyleBackColor = True
        '
        'DtaBai
        '
        Me.DtaBai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaBai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaBai.Location = New System.Drawing.Point(250, 151)
        Me.DtaBai.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtaBai.Name = "DtaBai"
        Me.DtaBai.Size = New System.Drawing.Size(200, 30)
        Me.DtaBai.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 156)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 25)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Data da Compra"
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(1158, 204)
        Me.BtnAlt.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(165, 53)
        Me.BtnAlt.TabIndex = 120
        Me.BtnAlt.Text = "Sair"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(1158, 143)
        Me.BtnCan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(165, 53)
        Me.BtnCan.TabIndex = 119
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnEst
        '
        Me.BtnEst.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEst.Location = New System.Drawing.Point(1018, 199)
        Me.BtnEst.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEst.Name = "BtnEst"
        Me.BtnEst.Size = New System.Drawing.Size(62, 32)
        Me.BtnEst.TabIndex = 118
        Me.BtnEst.Text = "OK"
        Me.BtnEst.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(1158, 82)
        Me.BtnGra.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(165, 53)
        Me.BtnGra.TabIndex = 117
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(1158, 20)
        Me.BtnNov.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(165, 53)
        Me.BtnNov.TabIndex = 116
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'BtnFor
        '
        Me.BtnFor.Location = New System.Drawing.Point(514, 199)
        Me.BtnFor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnFor.Name = "BtnFor"
        Me.BtnFor.Size = New System.Drawing.Size(63, 32)
        Me.BtnFor.TabIndex = 115
        Me.BtnFor.Text = "..."
        Me.BtnFor.UseVisualStyleBackColor = True
        '
        'TxtNomFor
        '
        Me.TxtNomFor.Enabled = False
        Me.TxtNomFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomFor.Location = New System.Drawing.Point(823, 201)
        Me.TxtNomFor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomFor.Name = "TxtNomFor"
        Me.TxtNomFor.Size = New System.Drawing.Size(168, 30)
        Me.TxtNomFor.TabIndex = 113
        '
        'LblCodCli
        '
        Me.LblCodCli.AutoSize = True
        Me.LblCodCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodCli.Location = New System.Drawing.Point(599, 204)
        Me.LblCodCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodCli.Name = "LblCodCli"
        Me.LblCodCli.Size = New System.Drawing.Size(196, 25)
        Me.LblCodCli.TabIndex = 114
        Me.LblCodCli.Text = "Nome do Fornecedor"
        '
        'TxtCodFor
        '
        Me.TxtCodFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodFor.Location = New System.Drawing.Point(250, 199)
        Me.TxtCodFor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodFor.Name = "TxtCodFor"
        Me.TxtCodFor.Size = New System.Drawing.Size(217, 30)
        Me.TxtCodFor.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 204)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Fornecedor"
        '
        'TxtCom
        '
        Me.TxtCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCom.Location = New System.Drawing.Point(250, 70)
        Me.TxtCom.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCom.Name = "TxtCom"
        Me.TxtCom.Size = New System.Drawing.Size(172, 30)
        Me.TxtCom.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 25)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Quantidade Comprada"
        '
        'TxtNomMat
        '
        Me.TxtNomMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomMat.Location = New System.Drawing.Point(645, 20)
        Me.TxtNomMat.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomMat.Name = "TxtNomMat"
        Me.TxtNomMat.Size = New System.Drawing.Size(270, 30)
        Me.TxtNomMat.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(459, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Nome do Material"
        '
        'TxtCodMat
        '
        Me.TxtCodMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodMat.Location = New System.Drawing.Point(250, 18)
        Me.TxtCodMat.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodMat.Name = "TxtCodMat"
        Me.TxtCodMat.Size = New System.Drawing.Size(89, 30)
        Me.TxtCodMat.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Código do Material"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Material, Me.QuantidadeMinima, Me.ValorEnt, Me.UltimoReabastecimento, Me.Fornecedor})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(12, 248)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(955, 345)
        Me.DgdGrade.TabIndex = 104
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 81
        '
        'Material
        '
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.Width = 87
        '
        'QuantidadeMinima
        '
        Me.QuantidadeMinima.HeaderText = "Quantidade Comprada"
        Me.QuantidadeMinima.Name = "QuantidadeMinima"
        Me.QuantidadeMinima.Width = 164
        '
        'ValorEnt
        '
        Me.ValorEnt.HeaderText = "Valor do maretial"
        Me.ValorEnt.Name = "ValorEnt"
        Me.ValorEnt.Width = 132
        '
        'UltimoReabastecimento
        '
        Me.UltimoReabastecimento.HeaderText = "Data Comprada"
        Me.UltimoReabastecimento.Name = "UltimoReabastecimento"
        Me.UltimoReabastecimento.Width = 125
        '
        'Fornecedor
        '
        Me.Fornecedor.HeaderText = "Fornecedor"
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.Width = 110
        '
        'EntradaDeMateriais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1336, 618)
        Me.Controls.Add(Me.MskVal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnMat)
        Me.Controls.Add(Me.DtaBai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnEst)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.BtnFor)
        Me.Controls.Add(Me.TxtNomFor)
        Me.Controls.Add(Me.LblCodCli)
        Me.Controls.Add(Me.TxtCodFor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNomMat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCodMat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdGrade)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "EntradaDeMateriais"
        Me.Text = "EntradaDeMateriais"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MskVal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnMat As System.Windows.Forms.Button
    Friend WithEvents DtaBai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnEst As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents BtnFor As System.Windows.Forms.Button
    Friend WithEvents TxtNomFor As System.Windows.Forms.TextBox
    Friend WithEvents LblCodCli As System.Windows.Forms.Label
    Friend WithEvents TxtCodFor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNomMat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCodMat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeMinima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorEnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimoReabastecimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
