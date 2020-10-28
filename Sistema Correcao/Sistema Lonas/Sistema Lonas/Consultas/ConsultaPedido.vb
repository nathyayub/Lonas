Public Class ConsultaPedido
    Dim objPed As New ClsPedido
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable

    Private Sub ConsultaPedido_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objPed.LocalizarFiltro(TxtCampo.Text)
    End Sub

End Class