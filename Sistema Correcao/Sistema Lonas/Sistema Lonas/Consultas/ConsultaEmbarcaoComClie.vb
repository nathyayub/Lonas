Public Class ConsultaEmbarcaoComClie
    Dim objControle As New ClsControle
    Dim objemb As New ClsEmbarcacao
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable


    Private Sub ConsultaEmbarcao_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0

        If Agendamento.Txtcodcli.TextLength <> 0 Then
            TxtCampo.Text = Agendamento.Txtcodcli.Text
        ElseIf Agendamento.Txtcodcli.Text = "" Then
            TxtCampo.Text = ""
        End If
        


    End Sub

    Private Sub TxtCampo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCampo.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objemb.LocalizarFiltro(TxtCampo.Text)

    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "AGENDAMENTO" Then
            Agendamento.txtcodemb.Text = DgdGrade.CurrentRow.Cells(0).Value
            Agendamento.txtEmbarcacao.Text = DgdGrade.CurrentRow.Cells(2).Value
        Else
            Agendamento.quemchamou = Me.Name
            Agendamento.Show()
        End If

        quemChamou = ""
        Me.Close()
    End Sub

    
End Class