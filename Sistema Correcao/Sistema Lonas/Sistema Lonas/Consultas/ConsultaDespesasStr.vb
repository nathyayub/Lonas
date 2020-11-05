Public Class ConsultaDespesasStr

    Dim objdes As New ClsDespesa
    Private Sub ConsultaDespesasStr_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DgdGrade.DataSource = objdes.Localizar_porData(DtpIni.Text, DtpFin.Text)
    End Sub

    Private Sub btnimprimir_Click_1(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Dim rpt As New CrpDespesas
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório Financeiro"
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub
End Class
