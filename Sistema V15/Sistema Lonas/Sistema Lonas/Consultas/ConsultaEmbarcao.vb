Public Class ConsultaEmbarcao

    Dim objemb As New ClsEmbarcacao
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable
    Private Sub ConsultaEmbarcao_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub


    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objemb.LocalizarFiltro(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "AGENDAMENTO" Then
            Agendamento.txtcodemb.Text = DgdGrade.CurrentRow.Cells(0).Value
            Agendamento.txtEmbarcacao.Text = DgdGrade.CurrentRow.Cells(1).Value
        Else
            Agendamento.quemchamou = Me.Name
            Agendamento.Show()
        End If

        quemChamou = ""
        Me.Close()
    End Sub


    Private Sub ConsultaEmbarcao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class