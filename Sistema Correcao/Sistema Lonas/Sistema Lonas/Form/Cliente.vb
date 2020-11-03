Public Class Cliente
    Dim objControle As New ClsControle
    Dim objCli As New ClsCliente
    Dim novo As Boolean
    Public quemchamou As String = ""
    Public campochave As Integer

    Private Sub Cliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        GrpLoc.Visible = False
        TxtEst.Enabled = False
        TxtCid.Enabled = False
        TxtBai.Enabled = False
        TxtEnd.Enabled = False
        TxtCom.Enabled = False
        btnConsultarCep.Enabled = False
       
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtIns.Enabled = False
        mskCNPJ.Enabled = True
        TxtIns.Enabled = True
        TxtEst.Enabled = False
        TxtCid.Enabled = False
        TxtBai.Enabled = False
        TxtEnd.Enabled = False
        TxtCom.Enabled = False
        btnConsultarCep.Enabled = True
        TxtNom.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click

        If TxtNom.Text = "" Then
            MsgBox("Digite o nome do cliente!")
            TxtNom.Focus()
        ElseIf MskTel.Text = "" And TxtEma.Text = "" Then
            MsgBox("Digite o telefone ou e-mail do cliente!")
            MskTel.Focus()
        ElseIf mskCpf.Text = "" And mskCNPJ.Text = "" Then
            MsgBox("Digite o CPF ou o CNPJ dp cliente!")
            mskCpf.Focus()
        ElseIf mskCNPJ.Text <> "" And TxtIns.Text = "" Then
            MsgBox("Digite a Inscrição Estadual do cliente!")
            TxtIns.Focus()
        ElseIf TxtEma.Text = "" Then
            MsgBox("Digite o email do cliente!")
            mskCpf.Focus()
        ElseIf TxtEnd.Text = "" Then
            MsgBox("Digite o endereço do cliente!")
            TxtEnd.Focus()
        ElseIf TxtBai.Text = "" Then
            MsgBox("Digite o bairro do cliente!")
            TxtBai.Focus()
        ElseIf TxtEst.Text = "" Then
            MsgBox("Digite o estado do cliente!")
            TxtEst.Focus()
        ElseIf TxtCid.Text = "" Then
            MsgBox("Digite a cidade do cliente!")
            TxtCid.Focus()
        ElseIf TxtCep.Text = "" Then
            MsgBox("Digite o CEP do cliente!")
            TxtCep.Focus()
        Else
            If objControle.Testar_vazio(Me) <> True Then

                objCli.Codigo = Val(TxtCod.Text)
                objCli.Nome = TxtNom.Text
                objCli.Telefone = MskTel.Text

                objCli.CNPJ = mskCNPJ.Text
                objCli.Inscricao = TxtIns.Text

                objCli.Cpf = mskCpf.Text


                objCli.Email = TxtEma.Text
                objCli.Endereco = TxtEnd.Text
                objCli.Complemento = TxtCom.Text
                objCli.Bairro = TxtBai.Text
                objCli.Estado = TxtEst.Text
                objCli.Cidade = TxtCid.Text
                objCli.Cep = TxtCep.Text

                objCli.Gravar(novo)
                TxtCod.Text = objCli.Codigo
                objControle.habilitar_tela(Me, False)
                objControle.habilitar_botoes(Me, True)
            End If
        End If
        btnConsultarCep.Enabled = False

    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        GrpLoc.Visible = True
        TxtLoc.Text = ""
        BtnOK.Enabled = False
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Cliente_Load(Nothing, Nothing)
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objCli.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
            objControle.habilitar_tela(Me, False)

        End If
        TxtLoc.Text = ""
        btnConsultarCep.Enabled = False
        TxtLoc.Focus()
    End Sub

    Private Sub mostrar_DadosVindosDaClasse()
        TxtCod.Text = objCli.Codigo
        TxtNom.Text = objCli.Nome
        MskTel.Text = objCli.Telefone
        mskCpf.Text = objCli.Cpf
        TxtEma.Text = objCli.Email
        TxtEnd.Text = objCli.Endereco
        TxtCom.Text = objCli.Complemento
        TxtBai.Text = objCli.Bairro
        TxtEst.Text = objCli.Estado
        TxtCid.Text = objCli.Cidade
        TxtCep.Text = objCli.Cep
        mskCNPJ.Text = objCli.CNPJ
        TxtIns.Text = objCli.Inscricao

    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objCli.Excluir(TxtCod.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
        End If
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        GrpLoc.Visible = False
        TxtCod.Enabled = False
        TxtEst.Enabled = False
        TxtCid.Enabled = False
        TxtBai.Enabled = False
        TxtEnd.Enabled = False
        TxtCom.Enabled = False
        btnConsultarCep.Enabled = True

        TxtNom.Focus()
        GrpLoc.Visible = False
        novo = False
    End Sub


    Private Sub TxtCNPJ_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    



    Private Sub BtnImp_Click(sender As Object, e As EventArgs)
        Dim rpt As New CrpClientes
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Cliente "
        rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub TxtCep_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub btnConsultarCep_Click(sender As Object, e As EventArgs) Handles btnConsultarCep.Click
        Try
            Dim Ws = New WsCep.AtendeClienteClient()
            Dim Resposta = Ws.consultaCEP(TxtCep.Text)
            TxtEnd.Text = Resposta.end
            TxtCom.Text = Resposta.complemento2
            TxtBai.Text = Resposta.bairro
            TxtEst.Text = Resposta.uf
            TxtCid.Text = Resposta.cidade
        Catch ex As Exception
            MsgBox("Erro ao encontrar CEP.", vbCritical)
        End Try
    End Sub

  
    Private Sub mskCNPJ_TextChanged(sender As Object, e As EventArgs) Handles mskCNPJ.TextChanged
        If mskCNPJ.Text <> "" Then
            mskCpf.Enabled = False
            TxtIns.Enabled = True
        Else
            mskCpf.Enabled = True
            TxtIns.Enabled = False
        End If
    End Sub

    Private Sub TxtCpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskCpf.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub mskCpf_TextChanged(sender As Object, e As EventArgs) Handles mskCpf.TextChanged
        If mskCpf.Text <> "" Then
            mskCNPJ.Enabled = False
            TxtIns.Enabled = False
        Else
            mskCNPJ.Enabled = True
            TxtIns.Enabled = False
        End If

    End Sub
End Class
