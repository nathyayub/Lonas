Public Class Marina
    Dim objControle As New ClsControle
    Dim objmar As New ClsMarina
    Dim novo As Boolean
    Public quemchamou As String = ""
    Public campochave As Integer
    Private Sub Marina_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub marina1_Activated(sender As Object, e As EventArgs)
        If quemchamou.ToUpper = "CONSULTAEMBACAOMARINA" Then
            objmar.LocalizarPorCodigoOuNome(campochave)
            Call mostrar_DadosVindosDaClasse()
            quemchamou = ""
        End If
    End Sub

    Private Sub Marina_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnAlt.Enabled = False
        BtnExc.Enabled = False
        BtnImp.Enabled = False
        GrpLoc.Visible = False
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If txtnomeE.Text = "" Then
            MsgBox("Digite o nome da marina!")
            txtnomeE.Focus()
        ElseIf txtEnde.Text = "" Then
            MsgBox("Digite o endereço da marina!")
            txtEnde.Focus()
        ElseIf txtbairro.Text = "" Then
            MsgBox("Digite o bairro da marina!")
            txtbairro.Focus()
        ElseIf txtcidade.Text = "" Then
            MsgBox("Digite a cidade da marina!")
            txtcidade.Focus()
        ElseIf txtestado.Text = "" Then
            MsgBox("Digite o estado da marina!")
            txtestado.Focus()
        ElseIf txtcep.Text = "" Then
            MsgBox("Digite o CEP da marina!")
            txtcep.Focus()

        Else

            objmar.Codigo = Val(txtcodigo.Text)
            objmar.NomeEmpresa = txtnomeE.Text
            objmar.Endereco = txtEnde.Text
            objmar.Complemento = txtcomp.Text
            objmar.bairro = txtbairro.Text
            objmar.cidade = txtcidade.Text
            objmar.estado = txtestado.Text
            objmar.CEP = txtcep.Text

            objmar.Gravar(novo)
            txtcodigo.Text = objmar.Codigo

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
        Marina_Load_1(Nothing, Nothing)
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
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        txtcodigo.Enabled = False
        txtnomeE.Focus()
        GrpLoc.Visible = False
        novo = False
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        objControle.habilitar_botoes(Me, False)
        txtcodigo.Enabled = False
        txtnomeE.Focus()
        novo = True
    End Sub

    Private Sub txtcep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcep.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub txtcep_TextChanged(sender As Object, e As EventArgs) Handles txtcep.TextChanged

    End Sub
End Class
