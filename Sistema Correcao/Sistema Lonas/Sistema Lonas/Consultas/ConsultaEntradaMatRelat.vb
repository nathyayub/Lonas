Public Class ConsultaEntradaMatRelat
    Dim objEntM As New ClsEntradaMateriais

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Dim rpt As New CrpEntradaMat
        rpt.SetDataSource(DgdGrade.DataSource)
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Entrada de Materiais"
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        DgdGrade.DataSource = objEntM.Localizar_porData(DtpIni.Text, DtpFin.Text)
    End Sub
End Class