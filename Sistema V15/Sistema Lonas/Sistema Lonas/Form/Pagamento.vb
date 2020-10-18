Public Class Pagamento
    Dim objControle As New ClsControle
    Dim objPag As New ClsPagamento
    Dim novo As Boolean

    Private Sub Pagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        btnverificar.Enabled = False
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        BtnImp.Enabled = False
        GrpLoc.Visible = False
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        objPag.Codigo = Val(txtcod.Text)
        objPag.Pedido = txtcodped.Text
        objPag.Valor = txtval.Text
        objPag.Vencimento = dtpvenc.Text
        objPag.Recebimento = chbrec.Checked
        objPag.Gravar(novo)
        txtcod.Text = objPag.Codigo

        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        txtcod.Enabled = False
        btnverificar.Enabled = True
        txtcodped.Focus()
        novo = True
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objPag.Excluir(txtcod.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        GrpLoc.Visible = True
        TxtLoc.Text = ""
        BtnOK.Enabled = False
        TxtLoc.Focus()
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        txtcod.Enabled = False
        txtcodped.Focus()
        novo = False
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Pagamento_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objPag.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub

    Private Sub mostrar_DadosVindosDaClasse()
        txtcod.Text = objPag.Codigo
        txtcodped.Text = objPag.Pedido
        txtval.Text = objPag.Valor
        dtpvenc.Text = objPag.Vencimento
        chbrec.Checked = objPag.Recebimento
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub btnverificar_Click(sender As Object, e As EventArgs) Handles btnverificar.Click
        ConsultaPedido.quemChamou = Me.Name
        ConsultaPedido.ShowDialog()
    End Sub
End Class