Public Class ConsultaDespesasStr

    Dim objdes As New ClsDespesa

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DgdGrade.DataSource = objdes.Localizar_porData(DtpIni.Text, DtpFin.Text)
    End Sub

    Private Sub ConsultaDespesasStr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
    End Sub
End Class