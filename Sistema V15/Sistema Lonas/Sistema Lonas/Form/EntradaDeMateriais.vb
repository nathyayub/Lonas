﻿Public Class EntradaDeMateriais
    Dim objControle As New ClsControle
    Dim objEnt As New ClsEntradaMateriais
    Dim novo As Boolean
    Dim objMat As New ClsCadastroMateriais

    Public quemchamou As String = ""
    Public campochave As Integer

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If TxtCodMat.Text = "" Then
            MsgBox("Digite o código do produto!")
            TxtCodMat.Focus()
        ElseIf TxtCom.Text = "" Then
            MsgBox("Digite a quantidade comprada!")
            TxtCom.Focus()
        ElseIf MskVal.Text = "" Then
            MsgBox("Digite o valor da unidade ou metro!")
            MskVal.Focus()
        ElseIf TxtCodFor.Text = "" Then
            MsgBox("Digite o código do fornecedor!")
            TxtCodFor.Focus()
        Else
            For x = 0 To DgdGrade.Rows.Count - 1

                objEnt.Material = DgdGrade.Rows(x).Cells(0).Value


                objEnt.Quantidade = DgdGrade.Rows(x).Cells(2).Value

                objEnt.Valor = DgdGrade.Rows(x).Cells(3).Value

                objEnt.Data = DgdGrade.Rows(x).Cells(4).Value

                objEnt.Fornecedor = DgdGrade.Rows(x).Cells(5).Value

                objEnt.Gravar()


            Next
        End If
    End Sub

    Private Sub EntradaDeMateriais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.habilitar_tela(Me, False)
        objControle.habilitar_botoes(Me, True)
        BtnMat.Enabled = False
        BtnFor.Enabled = False
        BtnEst.Enabled = False



    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.habilitar_tela(Me, True)
        BtnMat.Enabled = True
        BtnFor.Enabled = True
        BtnEst.Enabled = True


    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        EntradaDeMateriais_Load(Nothing, Nothing)
        DgdGrade.Rows.Clear()
        MskVal.Text = ""
        TxtCom.Text = ""
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        Me.Close()
    End Sub

    Private Sub BtnFor_Click(sender As Object, e As EventArgs) Handles BtnFor.Click
        ConsultaFornecedor.quemChamou = Me.Name
        ConsultaFornecedor.ShowDialog()
    End Sub

    Private Sub BtnFun_Click(sender As Object, e As EventArgs)
        ConsultaFuncionario.quemChamou = Me.Name
        ConsultaFuncionario.ShowDialog()
    End Sub

    Private Sub BtnMat_Click(sender As Object, e As EventArgs) Handles BtnMat.Click
        ConsultaMateriais.quemChamou = Me.Name
        ConsultaMateriais.ShowDialog()
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub BtnEst_Click(sender As Object, e As EventArgs) Handles BtnEst.Click
        If TxtNomMat.Text = "" Or TxtCom.Text = "" Or DtaBai.Text = "" Or TxtCodFor.Text = "" Then
            MessageBox.Show("Todos os campos são obrigatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNomMat.Focus()
        Else
            DgdGrade.Rows.Add(TxtCodMat.Text, TxtNomMat.Text, TxtCom.Text, MskVal.Text, DtaBai.Text, TxtCodFor.Text)
            objMat.atualizarEstoque(TxtCodMat.Text, TxtCom.Text)
            TxtCodMat.Clear()
            TxtNomMat.Clear()
            TxtCodFor.Clear()
            TxtNomFor.Clear()

            BtnEst.Enabled = True
            BtnGra.Enabled = True

        End If



    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If DgdGrade.Rows.Count <> 0 Then
            objMat.baixarEstoque(DgdGrade.CurrentRow.Cells(0).Value, DgdGrade.CurrentRow.Cells(2).Value)
            DgdGrade.Rows.RemoveAt(DgdGrade.CurrentCell.RowIndex)
        End If
    End Sub
End Class