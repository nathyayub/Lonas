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

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub DgdGrade_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentDoubleClick
        If quemChamou.ToUpper = "PAGAMENTO" Then
            Pagamento.txtcodped.Text = DgdGrade.CurrentRow.Cells(1).Value
            Pagamento.txtnomecli.Text = DgdGrade.CurrentRow.Cells(3).Value
        Else
            Pedidos.quemchamou = Me.Name
            Pedidos.Show()
        End If
        quemChamou = ""
        Me.Close()

    End Sub
End Class
