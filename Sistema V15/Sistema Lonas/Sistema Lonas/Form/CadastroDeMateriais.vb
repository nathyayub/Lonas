Public Class CadastroDeMateriais
    Dim objControle As New ClsControle
    Dim objCad As New ClsCadastroMateriais
    Dim novo As Boolean

    Public quemchamou As String = ""
    Public campochave As Integer

    Private Sub CadasrtroDeMateriais_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub CadastroDeMateriais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        BtnImp.Enabled = False
        GrpLoc.Visible = False
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If TxtNom.Text = "" Or CboUni.SelectedItem.ToString = "" Or TxtDes.Text = "" Or TxtMin.Text = "" Or TxtMax.Text = "" Then
            MsgBox("Todos os campos são obrigatorios")
        Else
            objCad.Codigo = Val(TxtCod.Text)
            objCad.NomeMaterial = TxtNom.Text
            objCad.UnidadeMedida = CboUni.SelectedItem.ToString
            objCad.Descricao = TxtDes.Text
            objCad.QuantidadeMinima = TxtMin.Text
            objCad.QuantidadeMaxima = TxtMax.Text
            objCad.Gravar(novo)
            TxtCod.Text = objCad.Codigo

            objControle.habilitar_tela(Me, False)
            objControle.habilitar_botoes(Me, True)
        End If
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
        CadastroDeMateriais_Load(Nothing, Nothing)
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objCad.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub

    Private Sub mostrar_DadosVindosDaClasse()
        TxtCod.Text = objCad.Codigo
        TxtNom.Text = objCad.NomeMaterial
        CboUni.SelectedItem = objCad.UnidadeMedida
        TxtDes.Text = objCad.Descricao
        TxtMin.Text = objCad.QuantidadeMinima
        TxtMax.Text = objCad.QuantidadeMaxima

    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objCad.Excluir(TxtCod.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = False
    End Sub

    
End Class