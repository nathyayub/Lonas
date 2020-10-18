<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.MskVal = New System.Windows.Forms.MaskedTextBox()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.ChbPag = New System.Windows.Forms.CheckBox()
        Me.DtaPag = New System.Windows.Forms.DateTimePicker()
        Me.DtaMax = New System.Windows.Forms.DateTimePicker()
        Me.DtaMin = New System.Windows.Forms.DateTimePicker()
        Me.DtaPed = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboPed = New System.Windows.Forms.ComboBox()
        Me.BtnCli = New System.Windows.Forms.Button()
        Me.TxtCli = New System.Windows.Forms.TextBox()
        Me.LblCodCli = New System.Windows.Forms.Label()
        Me.TxtCodCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(125, 34)
        Me.TxtCod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(168, 30)
        Me.TxtCod.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Código"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 192)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Valor Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 246)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Data do Pedido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 302)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 25)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Prazo Minimo de Entrega"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 361)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 25)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Prazo Maximo de Entrega"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 422)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 25)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Data do Pagamento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 486)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 25)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Data do Pagamento"
        '
        'BtnImp
        '
        Me.BtnImp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImp.Location = New System.Drawing.Point(1085, 417)
        Me.BtnImp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(165, 53)
        Me.BtnImp.TabIndex = 58
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = True
        '
        'BtnAlt
        '
        Me.BtnAlt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.Location = New System.Drawing.Point(1085, 295)
        Me.BtnAlt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(165, 53)
        Me.BtnAlt.TabIndex = 57
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = True
        '
        'BtnSai
        '
        Me.BtnSai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.Location = New System.Drawing.Point(1085, 478)
        Me.BtnSai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(165, 53)
        Me.BtnSai.TabIndex = 56
        Me.BtnSai.Text = "Sai&r"
        Me.BtnSai.UseVisualStyleBackColor = True
        '
        'BtnCan
        '
        Me.BtnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.Location = New System.Drawing.Point(1085, 356)
        Me.BtnCan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(165, 53)
        Me.BtnCan.TabIndex = 55
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = True
        '
        'BtnLoc
        '
        Me.BtnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.Location = New System.Drawing.Point(1085, 234)
        Me.BtnLoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(165, 54)
        Me.BtnLoc.TabIndex = 54
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = True
        '
        'BtnExc
        '
        Me.BtnExc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.Location = New System.Drawing.Point(1085, 174)
        Me.BtnExc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(165, 53)
        Me.BtnExc.TabIndex = 53
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = True
        '
        'BtnGra
        '
        Me.BtnGra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.Location = New System.Drawing.Point(1085, 112)
        Me.BtnGra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(165, 53)
        Me.BtnGra.TabIndex = 52
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = True
        '
        'BtnNov
        '
        Me.BtnNov.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.Location = New System.Drawing.Point(1085, 50)
        Me.BtnNov.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(165, 53)
        Me.BtnNov.TabIndex = 51
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = True
        '
        'MskVal
        '
        Me.MskVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskVal.Location = New System.Drawing.Point(139, 188)
        Me.MskVal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MskVal.Mask = "$999999999"
        Me.MskVal.Name = "MskVal"
        Me.MskVal.Size = New System.Drawing.Size(125, 30)
        Me.MskVal.TabIndex = 59
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.Label10)
        Me.GrpLoc.Controls.Add(Me.BtnOK)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.Location = New System.Drawing.Point(731, 18)
        Me.GrpLoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GrpLoc.Size = New System.Drawing.Size(315, 118)
        Me.GrpLoc.TabIndex = 66
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
        Me.Label10.Size = New System.Drawing.Size(229, 25)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Digite o Código ou Nome"
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(213, 65)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(55, 32)
        Me.BtnOK.TabIndex = 1
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'TxtLoc
        '
        Me.TxtLoc.Location = New System.Drawing.Point(21, 65)
        Me.TxtLoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(183, 30)
        Me.TxtLoc.TabIndex = 0
        '
        'ChbPag
        '
        Me.ChbPag.AutoSize = True
        Me.ChbPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbPag.Location = New System.Drawing.Point(280, 422)
        Me.ChbPag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChbPag.Name = "ChbPag"
        Me.ChbPag.Size = New System.Drawing.Size(80, 29)
        Me.ChbPag.TabIndex = 67
        Me.ChbPag.Text = "Pago"
        Me.ChbPag.UseVisualStyleBackColor = True
        '
        'DtaPag
        '
        Me.DtaPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaPag.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaPag.Location = New System.Drawing.Point(256, 480)
        Me.DtaPag.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtaPag.Name = "DtaPag"
        Me.DtaPag.Size = New System.Drawing.Size(200, 30)
        Me.DtaPag.TabIndex = 75
        '
        'DtaMax
        '
        Me.DtaMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaMax.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaMax.Location = New System.Drawing.Point(280, 354)
        Me.DtaMax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtaMax.Name = "DtaMax"
        Me.DtaMax.Size = New System.Drawing.Size(200, 30)
        Me.DtaMax.TabIndex = 74
        '
        'DtaMin
        '
        Me.DtaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaMin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaMin.Location = New System.Drawing.Point(280, 297)
        Me.DtaMin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtaMin.Name = "DtaMin"
        Me.DtaMin.Size = New System.Drawing.Size(200, 30)
        Me.DtaMin.TabIndex = 73
        '
        'DtaPed
        '
        Me.DtaPed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtaPed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtaPed.Location = New System.Drawing.Point(201, 240)
        Me.DtaPed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtaPed.Name = "DtaPed"
        Me.DtaPed.Size = New System.Drawing.Size(200, 30)
        Me.DtaPed.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 92)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 25)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Pedido"
        '
        'CboPed
        '
        Me.CboPed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPed.FormattingEnabled = True
        Me.CboPed.Items.AddRange(New Object() {"Capota", "Fechamento", "Lona"})
        Me.CboPed.Location = New System.Drawing.Point(128, 84)
        Me.CboPed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CboPed.Name = "CboPed"
        Me.CboPed.Size = New System.Drawing.Size(325, 33)
        Me.CboPed.TabIndex = 76
        '
        'BtnCli
        '
        Me.BtnCli.Location = New System.Drawing.Point(230, 133)
        Me.BtnCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCli.Name = "BtnCli"
        Me.BtnCli.Size = New System.Drawing.Size(63, 32)
        Me.BtnCli.TabIndex = 82
        Me.BtnCli.Text = "..."
        Me.BtnCli.UseVisualStyleBackColor = True
        '
        'TxtCli
        '
        Me.TxtCli.Enabled = False
        Me.TxtCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(401, 135)
        Me.TxtCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(248, 30)
        Me.TxtCli.TabIndex = 80
        '
        'LblCodCli
        '
        Me.LblCodCli.AutoSize = True
        Me.LblCodCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodCli.Location = New System.Drawing.Point(315, 138)
        Me.LblCodCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCodCli.Name = "LblCodCli"
        Me.LblCodCli.Size = New System.Drawing.Size(64, 25)
        Me.LblCodCli.TabIndex = 81
        Me.LblCodCli.Text = "Nome"
        '
        'TxtCodCli
        '
        Me.TxtCodCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodCli.Location = New System.Drawing.Point(129, 134)
        Me.TxtCodCli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodCli.Name = "TxtCodCli"
        Me.TxtCodCli.Size = New System.Drawing.Size(72, 30)
        Me.TxtCodCli.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Cliente"
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 546)
        Me.Controls.Add(Me.BtnCli)
        Me.Controls.Add(Me.TxtCli)
        Me.Controls.Add(Me.LblCodCli)
        Me.Controls.Add(Me.TxtCodCli)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CboPed)
        Me.Controls.Add(Me.DtaPag)
        Me.Controls.Add(Me.DtaMax)
        Me.Controls.Add(Me.DtaMin)
        Me.Controls.Add(Me.DtaPed)
        Me.Controls.Add(Me.ChbPag)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.MskVal)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents BtnExc As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents MskVal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents ChbPag As System.Windows.Forms.CheckBox
    Friend WithEvents DtaPag As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtaMax As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtaMin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtaPed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboPed As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCli As System.Windows.Forms.Button
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents LblCodCli As System.Windows.Forms.Label
    Friend WithEvents TxtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
