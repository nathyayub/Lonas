Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class FrmMenu





    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DtsDolar As String
        Dim DtsEuro As String
        Dim cotacaoService = New WsCotacao.FachadaWSSGSService()
        DtsDolar = cotacaoService.getUltimoValorVO(10813).ultimoValor.svalor
        DtsEuro = cotacaoService.getUltimoValorVO(21620).ultimoValor.svalor

        TxtDolarCota.Text = ("R$" + DtsDolar)
        txtEuroCota.Text = ("R$" + DtsEuro)

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Cliente.Show()
        Cliente.MdiParent = Me
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Funcionarios.Show()
        Funcionarios.MdiParent = Me
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Agendamento.Show()
        Agendamento.MdiParent = Me
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Materiais.Show()
        Materiais.MdiParent = Me
    End Sub
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Embarcacao.Show()
        Embarcacao.MdiParent = Me
    End Sub
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Pedidos.Show()
        Pedidos.MdiParent = Me
    End Sub
    Private Sub AgendamentoMediçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendamentoMediçãoToolStripMenuItem.Click
        ConsultaAgendamento.Show()
        ConsultaAgendamento.MdiParent = Me
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        ConsultaCliente.Show()
        ConsultaCliente.MdiParent = Me
    End Sub

    Private Sub MarinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarinaToolStripMenuItem.Click
        ConsultaMarina.Show()
        ConsultaMarina.MdiParent = Me
    End Sub
    Private Sub PedidoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ConsultaPedido.Show()
        ConsultaPedido.MdiParent = Me
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs)
        Fornecedor.Show()
        Fornecedor.MdiParent = Me
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Pagamento.Show()
        Pagamento.MdiParent = Me
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles TooMarina.Click
        Marina.Show()
        Marina.MdiParent = Me
    End Sub
    Private Sub PedidoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PedidoToolStripMenuItem.Click
        ConsultaPedido.Show()
        ConsultaPedido.MdiParent = Me
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Close()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub DespesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespesasToolStripMenuItem.Click
        ConsultaDespesasStr.Show()
        ConsultaDespesasStr.MdiParent = Me
    End Sub

    Private Sub CadastroDeMateriaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeMateriaisToolStripMenuItem.Click
        CadastroDeMateriais.Show()
        CadastroDeMateriais.MdiParent = Me
    End Sub

    Private Sub EntradaDeMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeMaterialToolStripMenuItem.Click
        EntradaDeMateriais.Show()
        EntradaDeMateriais.MdiParent = Me
    End Sub

    Private Sub EstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstoqueToolStripMenuItem.Click
        Materiais.Show()
        Materiais.MdiParent = Me
    End Sub

    Private Sub SaídaDeMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaídaDeMaterialToolStripMenuItem.Click
        SaidaDeMateriais.Show()
        SaidaDeMateriais.MdiParent = Me
    End Sub

    Private Sub ToolStripButton10_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        Fornecedor.Show()
        Fornecedor.MdiParent = Me
    End Sub


    Private Sub RelátorioGeralDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim rpt As New CrpClientes
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Cliente "
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub EvolucaçãoProdutoToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        ContasApagar.Show()
        ContasApagar.MdiParent = Me
    End Sub

    Private Sub PedidoPorDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoPorDataToolStripMenuItem.Click
        ConsultaPedidoPorData.Show()
        ConsultaPedidoPorData.MdiParent = Me
    End Sub

    Private Sub EmbarcaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarcaçãoToolStripMenuItem.Click
        CoEmbarcacao.Show()
        CoEmbarcacao.MdiParent = Me
    End Sub


    Private Sub FuncionariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionariosToolStripMenuItem.Click
        ConsultaFuncionario.Show()
        ConsultaFuncionario.MdiParent = Me
    End Sub

    Private Sub EstoqueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstoqueToolStripMenuItem1.Click
        Materiais.Show()
        Materiais.MdiParent = Me
    End Sub

    Private Sub RelátorioPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelátorioPedidoToolStripMenuItem.Click
        Dim rpt As New CrpPedidos
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Pedidos"
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub RelátorioFornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelátorioFornecedorToolStripMenuItem.Click
        Dim rpt As New CrpFornecedor
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Fornecedores"
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub SaídaDeMateriaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaídaDeMateriaisToolStripMenuItem.Click
        ConsultaSaidaMatRelat.Show()
        ConsultaSaidaMatRelat.MdiParent = Me
    End Sub

    Private Sub EntradaDeMateriaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeMateriaisToolStripMenuItem.Click
        ConsultaEntradaMatRelat.Show()
        ConsultaEntradaMatRelat.MdiParent = Me
    End Sub

    Private Sub RelátorioClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelátorioClienteToolStripMenuItem.Click
        Dim rpt As New CrpClientes
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Clientes"
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub RelátorioEmbacaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelátorioEmbacaçãoToolStripMenuItem.Click
        Dim rpt As New CrpEmbarcacao
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Embarcação"
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub RelátorioGeralDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelátorioGeralDePedidosToolStripMenuItem.Click
        Dim rpt As New CrpPedidos
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Pedidos "
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub RelátorioDePedidosPorDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelátorioDePedidosPorDataToolStripMenuItem.Click
        ConsultaPedidoPorData.Show()
        ConsultaPedidoPorData.MdiParent = Me
    End Sub

    Private Sub RelátorioGeralDeDespesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelátorioGeralDeDespesasToolStripMenuItem.Click
        Dim rpt As New CrpDespesas
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Lonas Timoneiros"
        rpt.SummaryInfo.ReportComments = "Relatório de Despesas "
        'rpt.Refresh()
        FrmImp.ShowDialog()
    End Sub

    Private Sub RelátorioDeDespesasPorDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelátorioDeDespesasPorDataToolStripMenuItem.Click
        ConsultaDespesasStr.Show()
        ConsultaDespesasStr.MdiParent = Me
    End Sub
    Private Sub FrmMenu_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        FrmLogin.Close()
    End Sub

End Class
