Public Class FrmMenu
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
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
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
        ConsultaAgendamentoCliente.Show()
        ConsultaAgendamentoCliente.MdiParent = Me
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        ConsultaCliente.Show()
        ConsultaCliente.MdiParent = Me
    End Sub

    Private Sub EmbarcaçãoMarinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmbarcaçãoMarinaToolStripMenuItem.Click
        ConsultaEmbarcacaoMarina.Show()
        ConsultaEmbarcacaoMarina.MdiParent = Me
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

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        ContasApagar.Show()
        ContasApagar.MdiParent = Me
    End Sub
    Private Sub PedidoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PedidoToolStripMenuItem.Click
        ConsultaPedido.Show()
        ConsultaPedido.MdiParent = Me
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub


    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Close()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Close()

    End Sub


    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs)

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
End Class
