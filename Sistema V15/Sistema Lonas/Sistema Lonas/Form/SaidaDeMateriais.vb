﻿Public Class SaidaDeMateriais
    Dim objControle As New ClsControle
    Dim objSai As New ClsSaidaDeMaterial
    Dim novo As Boolean
    Dim objMat As New ClsCadastroMateriais

    Public quemchamou As String = ""
    Public campochave As Integer

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        For x = 0 To DgdGrade.Rows.Count - 1

            objSai.Material = DgdGrade.Rows(x).Cells(0).Value
            objSai.Quantidade = DgdGrade.Rows(x).Cells(2).Value
            objSai.Data = DgdGrade.Rows(x).Cells(3).Value

            objSai.Gravar()

        Next

    End Sub

    Private Sub SaidaDeMateriais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnMat.Enabled = False
        BtnEst.Enabled = False
    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        BtnMat.Enabled = True
        BtnEst.Enabled = True
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        SaidaDeMateriais_Load(Nothing, Nothing)
        DgdGrade.Rows.Clear()
        TxtRet.Text = ""
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        Me.Close()
    End Sub

    Private Sub BtnFun_Click(sender As Object, e As EventArgs)
        ConsultaFuncionario.quemChamou = Me.Name
        ConsultaFuncionario.ShowDialog()
    End Sub

    Private Sub BtnMat_Click(sender As Object, e As EventArgs) Handles BtnMat.Click
        ConsultaMateriais.quemChamou = Me.Name
        ConsultaMateriais.ShowDialog()
    End Sub

    Private Sub BtnEst_Click(sender As Object, e As EventArgs) Handles BtnEst.Click

        If TxtCodMat.Text = "" Or TxtNomMat.Text = "" Or TxtRet.Text = "" Or DtaRet.Text = "" Then
            MessageBox.Show("Todos os campos são obrigatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtCodMat.Focus()
        Else
            DgdGrade.Rows.Add(TxtCodMat.Text, TxtNomMat.Text, TxtRet.Text, DtaRet.Text)
            objMat.baixarEstoque(TxtCodMat.Text, TxtRet.Text)
            TxtCodMat.Clear()
            TxtNomMat.Clear()
            TxtRet.Clear()
            BtnGra.Enabled = True
        End If
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If DgdGrade.Rows.Count <> 0 Then
            objMat.atualizarEstoque(DgdGrade.CurrentRow.Cells(0).Value, DgdGrade.CurrentRow.Cells(2).Value)
            DgdGrade.Rows.RemoveAt(DgdGrade.CurrentCell.RowIndex)
        End If
    End Sub
End Class