Public Class ConsultaPedidoPorData
    Dim objpedi As New ClsPedido
    Private Sub ConsultaPedidoPorData_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        DgdGrade.DataSource = objpedi.Localizar_porData(DtpIni.Text, DtpFin.Text)
    End Sub

    Private Sub ConsultaPedidoPorData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DtpIni_ValueChanged(sender As Object, e As EventArgs) Handles DtpIni.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class