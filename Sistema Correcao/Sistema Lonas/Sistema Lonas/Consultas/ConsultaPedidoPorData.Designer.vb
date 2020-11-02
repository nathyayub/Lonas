<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaPedidoPorData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaPedidoPorData))
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.DtpFin = New System.Windows.Forms.DateTimePicker()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.btnok = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnimprimir = New System.Windows.Forms.Button()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(24, 69)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(1040, 535)
        Me.DgdGrade.TabIndex = 24
        '
        'DtpFin
        '
        Me.DtpFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFin.Location = New System.Drawing.Point(497, 22)
        Me.DtpFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DtpFin.Name = "DtpFin"
        Me.DtpFin.Size = New System.Drawing.Size(135, 30)
        Me.DtpFin.TabIndex = 23
        '
        'DtpIni
        '
        Me.DtpIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(177, 18)
        Me.DtpIni.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(135, 30)
        Me.DtpIni.TabIndex = 22
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.Silver
        Me.btnok.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnok.FlatAppearance.BorderSize = 2
        Me.btnok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.Location = New System.Drawing.Point(732, 11)
        Me.btnok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(151, 49)
        Me.btnok.TabIndex = 21
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(360, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 29)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Data Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Data Inicial:"
        '
        'btnimprimir
        '
        Me.btnimprimir.BackColor = System.Drawing.Color.Silver
        Me.btnimprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnimprimir.FlatAppearance.BorderSize = 2
        Me.btnimprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimir.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimir.Location = New System.Drawing.Point(913, 12)
        Me.btnimprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(151, 49)
        Me.btnimprimir.TabIndex = 25
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.UseVisualStyleBackColor = False
        '
        'ConsultaPedidoPorData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(1085, 629)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.DtpFin)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ConsultaPedidoPorData"
        Me.Text = "Consulta de Pedido por Data"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents DtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
End Class
