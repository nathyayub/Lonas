<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agendamento
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
        Me.txtnomcli = New System.Windows.Forms.TextBox()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.btnimp = New System.Windows.Forms.Button()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.btncan = New System.Windows.Forms.Button()
        Me.btnloc = New System.Windows.Forms.Button()
        Me.btnexc = New System.Windows.Forms.Button()
        Me.btngra = New System.Windows.Forms.Button()
        Me.btnnov = New System.Windows.Forms.Button()
        Me.txtcodemb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpmed = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpprazomin = New System.Windows.Forms.DateTimePicker()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Txtcodcli = New System.Windows.Forms.TextBox()
        Me.dtpprazomax = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNom = New System.Windows.Forms.Button()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnomcli
        '
        Me.txtnomcli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomcli.Location = New System.Drawing.Point(370, 66)
        Me.txtnomcli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnomcli.Name = "txtnomcli"
        Me.txtnomcli.Size = New System.Drawing.Size(262, 26)
        Me.txtnomcli.TabIndex = 79
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.Label8)
        Me.GrpLoc.Controls.Add(Me.BtnOK)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.Location = New System.Drawing.Point(653, 14)
        Me.GrpLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrpLoc.Size = New System.Drawing.Size(212, 107)
        Me.GrpLoc.TabIndex = 78
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar"
        Me.GrpLoc.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Digite o Código ou Nome"
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(146, 58)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(47, 33)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'TxtLoc
        '
        Me.TxtLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLoc.Location = New System.Drawing.Point(12, 65)
        Me.TxtLoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(126, 26)
        Me.TxtLoc.TabIndex = 0
        '
        'btnimp
        '
        Me.btnimp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnimp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimp.Location = New System.Drawing.Point(872, 332)
        Me.btnimp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnimp.Name = "btnimp"
        Me.btnimp.Size = New System.Drawing.Size(124, 43)
        Me.btnimp.TabIndex = 77
        Me.btnimp.Text = "&Imprimir"
        Me.btnimp.UseVisualStyleBackColor = True
        '
        'btnalt
        '
        Me.btnalt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalt.Location = New System.Drawing.Point(872, 226)
        Me.btnalt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(124, 43)
        Me.btnalt.TabIndex = 76
        Me.btnalt.Text = "&Alterar"
        Me.btnalt.UseVisualStyleBackColor = True
        '
        'btnsair
        '
        Me.btnsair.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsair.Location = New System.Drawing.Point(872, 385)
        Me.btnsair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(124, 43)
        Me.btnsair.TabIndex = 75
        Me.btnsair.Text = "Sai&r"
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'btncan
        '
        Me.btncan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncan.Location = New System.Drawing.Point(872, 279)
        Me.btncan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncan.Name = "btncan"
        Me.btncan.Size = New System.Drawing.Size(124, 43)
        Me.btncan.TabIndex = 74
        Me.btncan.Text = "&Cancelar"
        Me.btncan.UseVisualStyleBackColor = True
        '
        'btnloc
        '
        Me.btnloc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnloc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloc.Location = New System.Drawing.Point(872, 173)
        Me.btnloc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnloc.Name = "btnloc"
        Me.btnloc.Size = New System.Drawing.Size(124, 43)
        Me.btnloc.TabIndex = 73
        Me.btnloc.Text = "&Localizar"
        Me.btnloc.UseVisualStyleBackColor = True
        '
        'btnexc
        '
        Me.btnexc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnexc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexc.Location = New System.Drawing.Point(872, 120)
        Me.btnexc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnexc.Name = "btnexc"
        Me.btnexc.Size = New System.Drawing.Size(124, 43)
        Me.btnexc.TabIndex = 72
        Me.btnexc.Text = "&Excluir"
        Me.btnexc.UseVisualStyleBackColor = True
        '
        'btngra
        '
        Me.btngra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btngra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngra.Location = New System.Drawing.Point(872, 67)
        Me.btngra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btngra.Name = "btngra"
        Me.btngra.Size = New System.Drawing.Size(124, 43)
        Me.btngra.TabIndex = 71
        Me.btngra.Text = "&Gravar"
        Me.btngra.UseVisualStyleBackColor = True
        '
        'btnnov
        '
        Me.btnnov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnnov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnov.Location = New System.Drawing.Point(872, 14)
        Me.btnnov.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnnov.Name = "btnnov"
        Me.btnnov.Size = New System.Drawing.Size(124, 43)
        Me.btnnov.TabIndex = 70
        Me.btnnov.Text = "&Novo"
        Me.btnnov.UseVisualStyleBackColor = True
        '
        'txtcodemb
        '
        Me.txtcodemb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodemb.Location = New System.Drawing.Point(202, 250)
        Me.txtcodemb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcodemb.Name = "txtcodemb"
        Me.txtcodemb.Size = New System.Drawing.Size(188, 26)
        Me.txtcodemb.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 253)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 20)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Código da embarcação"
        '
        'dtpmed
        '
        Me.dtpmed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpmed.Location = New System.Drawing.Point(177, 203)
        Me.dtpmed.Name = "dtpmed"
        Me.dtpmed.Size = New System.Drawing.Size(132, 26)
        Me.dtpmed.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 209)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 20)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Data da Medição"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 112)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Max"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(210, 163)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Mín"
        '
        'dtpprazomin
        '
        Me.dtpprazomin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpprazomin.Location = New System.Drawing.Point(271, 157)
        Me.dtpprazomin.Name = "dtpprazomin"
        Me.dtpprazomin.Size = New System.Drawing.Size(119, 26)
        Me.dtpprazomin.TabIndex = 60
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(88, 22)
        Me.TxtCod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(188, 26)
        Me.TxtCod.TabIndex = 57
        '
        'Txtcodcli
        '
        Me.Txtcodcli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtcodcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcodcli.Location = New System.Drawing.Point(163, 66)
        Me.Txtcodcli.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtcodcli.Name = "Txtcodcli"
        Me.Txtcodcli.Size = New System.Drawing.Size(146, 26)
        Me.Txtcodcli.TabIndex = 58
        '
        'dtpprazomax
        '
        Me.dtpprazomax.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpprazomax.Location = New System.Drawing.Point(271, 107)
        Me.dtpprazomax.Name = "dtpprazomax"
        Me.dtpprazomax.Size = New System.Drawing.Size(119, 26)
        Me.dtpprazomax.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Código do Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 20)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Data de Agendamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Código"
        '
        'BtnNom
        '
        Me.BtnNom.Location = New System.Drawing.Point(317, 66)
        Me.BtnNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNom.Name = "BtnNom"
        Me.BtnNom.Size = New System.Drawing.Size(45, 26)
        Me.BtnNom.TabIndex = 80
        Me.BtnNom.Text = "..."
        Me.BtnNom.UseVisualStyleBackColor = True
        '
        'Agendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 448)
        Me.Controls.Add(Me.BtnNom)
        Me.Controls.Add(Me.txtnomcli)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.btnimp)
        Me.Controls.Add(Me.btnalt)
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.btncan)
        Me.Controls.Add(Me.btnloc)
        Me.Controls.Add(Me.btnexc)
        Me.Controls.Add(Me.btngra)
        Me.Controls.Add(Me.btnnov)
        Me.Controls.Add(Me.txtcodemb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpmed)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpprazomin)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Txtcodcli)
        Me.Controls.Add(Me.dtpprazomax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Agendamento"
        Me.Text = "Agendamento"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnomcli As System.Windows.Forms.TextBox
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents btnimp As System.Windows.Forms.Button
    Friend WithEvents btnalt As System.Windows.Forms.Button
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents btncan As System.Windows.Forms.Button
    Friend WithEvents btnloc As System.Windows.Forms.Button
    Friend WithEvents btnexc As System.Windows.Forms.Button
    Friend WithEvents btngra As System.Windows.Forms.Button
    Friend WithEvents btnnov As System.Windows.Forms.Button
    Friend WithEvents txtcodemb As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpmed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpprazomin As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents Txtcodcli As System.Windows.Forms.TextBox
    Friend WithEvents dtpprazomax As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNom As System.Windows.Forms.Button
End Class
