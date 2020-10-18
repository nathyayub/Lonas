Public Class ConsultaAgendamentoCliente
    Dim objagen As New ClsAgendamento
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DgdGrade.DataSource = objagen.LocalizarFiltro(TxtCampo.Text)
    End Sub

    Private Sub ConsultaAgendamentoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class