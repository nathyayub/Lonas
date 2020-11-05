<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagamento))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPag = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChbVis = New System.Windows.Forms.CheckBox()
        Me.CboPag = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chbrec = New System.Windows.Forms.CheckBox()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.txtnomecli = New System.Windows.Forms.TextBox()
        Me.btnverificar = New System.Windows.Forms.Button()
        Me.dtpvenc = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtval = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodped = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(155, 225)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 29)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "Valor a Pagar:"
        '
        'TxtPag
        '
        Me.TxtPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPag.Location = New System.Drawing.Point(329, 223)
        Me.TxtPag.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPag.Name = "TxtPag"
        Me.TxtPag.Size = New System.Drawing.Size(137, 30)
        Me.TxtPag.TabIndex = 141
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(17, 225)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 29)
        Me.Label7.TabIndex = 140
        Me.Label7.Text = "A Vista:"
        '
        'ChbVis
        '
        Me.ChbVis.AutoSize = True
        Me.ChbVis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbVis.Location = New System.Drawing.Point(117, 233)
        Me.ChbVis.Margin = New System.Windows.Forms.Padding(4)
        Me.ChbVis.Name = "ChbVis"
        Me.ChbVis.Size = New System.Drawing.Size(18, 17)
        Me.ChbVis.TabIndex = 139
        Me.ChbVis.UseVisualStyleBackColor = True
        '
        'CboPag
        '
        Me.CboPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPag.FormattingEnabled = True
        Me.CboPag.Items.AddRange(New Object() {"Cartão Debito", "Cartão Credito", "Boleto", "Dinheiro", "Cheque", "TED"})
        Me.CboPag.Location = New System.Drawing.Point(262, 175)
        Me.CboPag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboPag.Name = "CboPag"
        Me.CboPag.Size = New System.Drawing.Size(271, 33)
        Me.CboPag.TabIndex = 138
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 178)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 29)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Forma de Pagamento:"
        '
        'chbrec
        '
        Me.chbrec.AutoSize = True
        Me.chbrec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbrec.Location = New System.Drawing.Point(94, 347)
        Me.chbrec.Margin = New System.Windows.Forms.Padding(4)
        Me.chbrec.Name = "chbrec"
        Me.chbrec.Size = New System.Drawing.Size(18, 17)
        Me.chbrec.TabIndex = 121
        Me.chbrec.UseVisualStyleBackColor = True
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.Label10)
        Me.GrpLoc.Controls.Add(Me.BtnOK)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.ForeColor = System.Drawing.Color.White
        Me.GrpLoc.Location = New System.Drawing.Point(22, 382)
        Me.GrpLoc.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpLoc.Size = New System.Drawing.Size(307, 111)
        Me.GrpLoc.TabIndex = 136
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Text = "Localizar"
        Me.GrpLoc.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 37)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 25)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Digite o Código"
        '
        'BtnOK
        '
        Me.BtnOK.ForeColor = System.Drawing.Color.Black
        Me.BtnOK.Location = New System.Drawing.Point(213, 65)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(55, 32)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'TxtLoc
        '
        Me.TxtLoc.Location = New System.Drawing.Point(21, 65)
        Me.TxtLoc.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(183, 30)
        Me.TxtLoc.TabIndex = 0
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.BackColor = System.Drawing.Color.Silver
        Me.BtnAlt.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAlt.FlatAppearance.BorderSize = 2
        Me.BtnAlt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAlt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlt.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(696, 262)
        Me.BtnAlt.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(165, 53)
        Me.BtnAlt.TabIndex = 125
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = False
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.BackColor = System.Drawing.Color.Silver
        Me.BtnSai.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnSai.FlatAppearance.BorderSize = 2
        Me.BtnSai.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSai.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(696, 382)
        Me.BtnSai.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(165, 53)
        Me.BtnSai.TabIndex = 127
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = False
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.BackColor = System.Drawing.Color.Silver
        Me.BtnCan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCan.FlatAppearance.BorderSize = 2
        Me.BtnCan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCan.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(696, 322)
        Me.BtnCan.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(165, 53)
        Me.BtnCan.TabIndex = 126
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnLoc
        '
        Me.BtnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoc.BackColor = System.Drawing.Color.Silver
        Me.BtnLoc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnLoc.FlatAppearance.BorderSize = 2
        Me.BtnLoc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoc.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(696, 200)
        Me.BtnLoc.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(165, 54)
        Me.BtnLoc.TabIndex = 124
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = False
        '
        'BtnExc
        '
        Me.BtnExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExc.BackColor = System.Drawing.Color.Silver
        Me.BtnExc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnExc.FlatAppearance.BorderSize = 2
        Me.BtnExc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExc.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.Location = New System.Drawing.Point(696, 140)
        Me.BtnExc.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(165, 53)
        Me.BtnExc.TabIndex = 123
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = False
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.BackColor = System.Drawing.Color.Silver
        Me.BtnGra.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnGra.FlatAppearance.BorderSize = 2
        Me.BtnGra.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnGra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGra.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(696, 78)
        Me.BtnGra.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(165, 53)
        Me.BtnGra.TabIndex = 122
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = False
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.BackColor = System.Drawing.Color.Silver
        Me.BtnNov.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnNov.FlatAppearance.BorderSize = 2
        Me.BtnNov.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNov.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(696, 17)
        Me.BtnNov.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(165, 53)
        Me.BtnNov.TabIndex = 117
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'txtnomecli
        '
        Me.txtnomecli.Enabled = False
        Me.txtnomecli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomecli.Location = New System.Drawing.Point(419, 76)
        Me.txtnomecli.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnomecli.Name = "txtnomecli"
        Me.txtnomecli.Size = New System.Drawing.Size(245, 30)
        Me.txtnomecli.TabIndex = 135
        '
        'btnverificar
        '
        Me.btnverificar.BackColor = System.Drawing.Color.Silver
        Me.btnverificar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnverificar.FlatAppearance.BorderSize = 2
        Me.btnverificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnverificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnverificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnverificar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverificar.Location = New System.Drawing.Point(356, 76)
        Me.btnverificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnverificar.Name = "btnverificar"
        Me.btnverificar.Size = New System.Drawing.Size(56, 34)
        Me.btnverificar.TabIndex = 118
        Me.btnverificar.Text = "..."
        Me.btnverificar.UseVisualStyleBackColor = False
        '
        'dtpvenc
        '
        Me.dtpvenc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpvenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpvenc.Location = New System.Drawing.Point(245, 285)
        Me.dtpvenc.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpvenc.Name = "dtpvenc"
        Me.dtpvenc.Size = New System.Drawing.Size(167, 30)
        Me.dtpvenc.TabIndex = 120
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 339)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 29)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Pago:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 286)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 29)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Data do Pagamento:"
        '
        'txtval
        '
        Me.txtval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtval.Location = New System.Drawing.Point(181, 128)
        Me.txtval.Margin = New System.Windows.Forms.Padding(4)
        Me.txtval.Name = "txtval"
        Me.txtval.Size = New System.Drawing.Size(137, 30)
        Me.txtval.TabIndex = 119
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 29)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Valor Total:"
        '
        'txtcodped
        '
        Me.txtcodped.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodped.Location = New System.Drawing.Point(231, 77)
        Me.txtcodped.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcodped.Name = "txtcodped"
        Me.txtcodped.Size = New System.Drawing.Size(117, 30)
        Me.txtcodped.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 29)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Código do Pedido:"
        '
        'txtcod
        '
        Me.txtcod.Enabled = False
        Me.txtcod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod.Location = New System.Drawing.Point(269, 27)
        Me.txtcod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(117, 30)
        Me.txtcod.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 29)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Código do Pagamento:"
        '
        'Pagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(879, 511)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtPag)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ChbVis)
        Me.Controls.Add(Me.CboPag)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chbrec)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.txtnomecli)
        Me.Controls.Add(Me.btnverificar)
        Me.Controls.Add(Me.dtpvenc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtval)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcodped)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Pagamento"
        Me.Text = "Pagamento"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtPag As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ChbVis As System.Windows.Forms.CheckBox
    Friend WithEvents CboPag As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chbrec As System.Windows.Forms.CheckBox
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents BtnExc As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents txtnomecli As System.Windows.Forms.TextBox
    Friend WithEvents btnverificar As System.Windows.Forms.Button
    Friend WithEvents dtpvenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtval As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodped As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
