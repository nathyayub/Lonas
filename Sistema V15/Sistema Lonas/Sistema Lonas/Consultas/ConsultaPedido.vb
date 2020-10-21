Public Class ConsultaPedido
    Dim objped As New ClsPedido
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable

    Private Sub ConsultaPedido_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        DgdGrade.DataSource = objped.LocalizarFiltro(TxtCampo.Text)
    End Sub
End Class