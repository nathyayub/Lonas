<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Materiais
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
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMaterial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeAtual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeMinima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantidadeMaxima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoReabastecimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Material, Me.TipoMaterial, Me.Fornecedor, Me.QuantidadeAtual, Me.QuantidadeMinima, Me.QuantidadeMaxima, Me.UltimoReabastecimento})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(18, 169)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(1171, 345)
        Me.DgdGrade.TabIndex = 56
        '
        'txtNum
        '
        Me.txtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(18, 72)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(217, 30)
        Me.txtNum.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Digite o nome ou código do material"
        '
        'BtnNov
        '
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(279, 69)
        Me.BtnNov.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(55, 36)
        Me.BtnNov.TabIndex = 57
        Me.BtnNov.Text = "OK"
        Me.BtnNov.UseVisualStyleBackColor = True
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
        'TipoMaterial
        '
        Me.TipoMaterial.HeaderText = "Tipo do Material"
        Me.TipoMaterial.Name = "TipoMaterial"
        Me.TipoMaterial.Width = 127
        '
        'Fornecedor
        '
        Me.Fornecedor.HeaderText = "Fornecedor"
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.Width = 110
        '
        'QuantidadeAtual
        '
        Me.QuantidadeAtual.HeaderText = "Quantidade Atual"
        Me.QuantidadeAtual.Name = "QuantidadeAtual"
        Me.QuantidadeAtual.Width = 135
        '
        'QuantidadeMinima
        '
        Me.QuantidadeMinima.HeaderText = "Quantidade Mínima"
        Me.QuantidadeMinima.Name = "QuantidadeMinima"
        Me.QuantidadeMinima.Width = 145
        '
        'QuantidadeMaxima
        '
        Me.QuantidadeMaxima.HeaderText = "Quantidade Maxima"
        Me.QuantidadeMaxima.Name = "QuantidadeMaxima"
        Me.QuantidadeMaxima.Width = 148
        '
        'UltimoReabastecimento
        '
        Me.UltimoReabastecimento.HeaderText = "Data do Último Reabastecimento"
        Me.UltimoReabastecimento.Name = "UltimoReabastecimento"
        Me.UltimoReabastecimento.Width = 222
        '
        'Materiais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 666)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Materiais"
        Me.Text = "Materiais"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Material As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoMaterial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeAtual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeMinima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantidadeMaxima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimoReabastecimento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
