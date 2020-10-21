Public Class ConsultaEmbarcacaoMarina
    Dim objmar As New ClsMarina
    Public quemChamou As String = ""
    Dim objdtLimpo As New DataTable

    Private Property FrmMenu As Form

    Private Sub ConsultaEmbarcacaoMarina_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        ''   If TxtCampo.Text <> "" Then
        DgdGrade.DataSource = objmar.LocalizarFiltro(TxtCampo.Text)
        '' End If
    End Sub
    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If quemChamou.ToUpper = "MARINA" Then
            Marina.txtcodigo.Text = DgdGrade.CurrentRow.Cells(0).Value
        Else
            Embarcacao.campochave = DgdGrade.CurrentRow.Cells(0).Value
            Embarcacao.quemchamou = Me.Name
            Embarcacao.Show()
            Embarcacao.MdiParent = FrmMenu
        End If
        quemChamou = ""
        Me.Close()
    End Sub

    Private Sub FrmConCLi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtCampo.Text = ""
    End Sub
End Class