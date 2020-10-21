Public Class Marina
    Dim objControle As New ClsControle
    Dim objmar As New ClsMarina
    Dim novo As Boolean
    Public quemchamou As String = ""
    Public campochave As Integer

    Private Sub marina_Activated(sender As Object, e As EventArgs)
        If quemchamou.ToUpper = "CONSULTAEMBACAOMARINA" Then
            objmar.LocalizarPorCodigoOuNome(campochave)
            Call mostrar_DadosVindosDaClasse()
            quemchamou = ""
        End If

        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub marina_Load(sender As Object, e As EventArgs)
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        BtnImp.Enabled = False
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
        marina_Load(Nothing, Nothing)
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOK.Enabled = False
        Else
            BtnOK.Enabled = True
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If objmar.LocalizarPorCodigoOuNome(TxtLoc.Text) = True Then
            Call mostrar_DadosVindosDaClasse()
            objControle.habilitar_botoes(Me, True)
        End If
        TxtLoc.Text = ""
        TxtLoc.Focus()
    End Sub

    Private Sub mostrar_DadosVindosDaClasse()
        txtcodigo.Text = objmar.Codigo
        txtnomeE.Text = objmar.NomeEmpresa
        txtEnde.Text = objmar.Endereco
        txtcomp.Text = objmar.Complemento
        txtbairro.Text = objmar.bairro
        txtcidade.Text = objmar.cidade
        txtestado.Text = objmar.estado
        txtcep.Text = objmar.CEP

    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objmar.Excluir(txtcodigo.Text) = True Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub


    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click

    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click

    End Sub

    Private Sub Marina_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
