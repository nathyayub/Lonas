<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaidaDeMateriais
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
        Me.BtnMat = New System.Windows.Forms.Button()
        Me.DtaRet = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnEst = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.TxtRet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomMat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodMat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeMinima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoReabastecimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMat
        '
        Me.BtnMat.Location = New System.Drawing.Point(371, 11)
        Me.BtnMat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMat.Name = "BtnMat"
        Me.BtnMat.Size = New System.Drawing.Size(63, 32)
        Me.BtnMat.TabIndex = 144
        Me.BtnMat.Text = "..."
        Me.BtnMat.UseVisualStyleBackColor = True
        '
        'DtaRet
        '
        Me.DtaRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaRet.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaRet.Location = New System.Drawing.Point(250, 112)
        Me.DtaRet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtaRet.Name = "DtaRet"
        Me.DtaRet.Size = New System.Drawing.Size(200, 30)
        Me.DtaRet.TabIndex = 143
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 117)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 25)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Data da Baixa"
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(1120, 202)
        Me.BtnAlt.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(165, 53)
        Me.BtnAlt.TabIndex = 141
        Me.BtnAlt.Text = "Sair"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(1120, 141)
        Me.BtnCan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(165, 53)
        Me.BtnCan.TabIndex = 140
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnEst
        '
        Me.BtnEst.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEst.Location = New System.Drawing.Point(501, 109)
        Me.BtnEst.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEst.Name = "BtnEst"
        Me.BtnEst.Size = New System.Drawing.Size(62, 41)
        Me.BtnEst.TabIndex = 139
        Me.BtnEst.Text = "OK"
        Me.BtnEst.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(1120, 80)
        Me.BtnGra.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(165, 53)
        Me.BtnGra.TabIndex = 138
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(1120, 18)
        Me.BtnNov.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(165, 53)
        Me.BtnNov.TabIndex = 137
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'TxtRet
        '
        Me.TxtRet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRet.Location = New System.Drawing.Point(250, 65)
        Me.TxtRet.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRet.Name = "TxtRet"
        Me.TxtRet.Size = New System.Drawing.Size(172, 30)
        Me.TxtRet.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 25)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Quantidade Retirada"
        '
        'TxtNomMat
        '
        Me.TxtNomMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomMat.Location = New System.Drawing.Point(645, 15)
        Me.TxtNomMat.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomMat.Name = "TxtNomMat"
        Me.TxtNomMat.Size = New System.Drawing.Size(270, 30)
        Me.TxtNomMat.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(459, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Nome do Material"
        '
        'TxtCodMat
        '
        Me.TxtCodMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodMat.Location = New System.Drawing.Point(250, 13)
        Me.TxtCodMat.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodMat.Name = "TxtCodMat"
        Me.TxtCodMat.Size = New System.Drawing.Size(89, 30)
        Me.TxtCodMat.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Código do Material"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Material, Me.QuantidadeMinima, Me.UltimoReabastecimento})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(12, 175)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(802, 345)
        Me.DgdGrade.TabIndex = 130
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Codigo"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 81
        '
        'Material
        '
        Me.Material.DataPropertyName = "CodProd"
        Me.Material.HeaderText = "Material"
        Me.Material.Name = "Material"
        Me.Material.Width = 87
        '
        'QuantidadeMinima
        '
        Me.QuantidadeMinima.DataPropertyName = "QtdSaida"
        Me.QuantidadeMinima.HeaderText = "Quantidade Retirada"
        Me.QuantidadeMinima.Name = "QuantidadeMinima"
        Me.QuantidadeMinima.Width = 154
        '
        'UltimoReabastecimento
        '
        Me.UltimoReabastecimento.DataPropertyName = "DtSaida"
        Me.UltimoReabastecimento.HeaderText = "Data Da Baixa"
        Me.UltimoReabastecimento.Name = "UltimoReabastecimento"
        Me.UltimoReabastecimento.Width = 117
        '
        'SaidaDeMateriais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 542)
        Me.Controls.Add(Me.BtnMat)
        Me.Controls.Add(Me.DtaRet)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnEst)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.TxtRet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNomMat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCodMat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgdGrade)
        Me.Name = "SaidaDeMateriais"
        Me.Text = "SaidaDeMateriais"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMat As System.Windows.Forms.Button
    Friend WithEvents DtaRet As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnEst As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents TxtRet As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNomMat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCodMat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeMinima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimoReabastecimento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
