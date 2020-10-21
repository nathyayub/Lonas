Public Class ConsultaPedidoPorData
    Dim objpedi As New ClsPedido

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        DgdGrade.DataSource = objpedi.Localizar_porData(DtpIni.Text, DtpFin.Text)
    End Sub
End Class