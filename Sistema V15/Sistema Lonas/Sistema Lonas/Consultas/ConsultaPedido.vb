Public Class ConsultaPedido
    Dim objped As New ClsPedido
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable
 
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        DgdGrade.DataSource = objped.LocalizarFiltro(TxtCampo.Text)
    End Sub

    Private Sub ConsultaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub
End Class