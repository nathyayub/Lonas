Public Class ConsultaDespesasStr

    Dim objdes As New ClsDespesa
    Private Sub ConsultaDespesasStr_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DgdGrade.DataSource = objdes.Localizar_porData(DtpIni.Text, DtpFin.Text)
    End Sub
End Class