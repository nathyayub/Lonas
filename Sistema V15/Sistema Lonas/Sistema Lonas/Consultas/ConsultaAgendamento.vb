Public Class ConsultaAgendamento

    Dim objagen As New ClsAgendamento
    Private Sub ConsultaAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        DgdGrade.DataSource = objagen.LocalizarFiltro(TxtCampo.Text)
    End Sub
End Class