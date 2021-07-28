Imports ByteBank.Bibliotecas.Classes.Clientes
Public Class Frm_ManutencaoCCListView
    Dim ListaContas As New List(Of ContaCorrente)

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Manutenção Conta Corrente"
        Grp_Lista.Text = "Lista de Contas Correntes"
        Grp_CriterioOrdenacao.Text = "Critério de Ordenação"
        Rb_Conta.Text = "Conta"
        Rb_Nome.Text = "Nome"
        Rb_Saldo.Text = "Saldo"
        InicializacaoContas()
        FormatarListView()
        CriarColunas()
        AtualizarListView()
    End Sub

    Sub InicializacaoContas()
        ' Previamente configuramos algumas contas
        ListaContas.Add(New ContaCorrente(277, 144323, "João da Silva"))
        ListaContas.Add(New ContaCorrente(277, 155532, "Pedro Alcantara"))
        ListaContas.Add(New ContaCorrente(277, 233224, "Julia Mattos"))
        ListaContas.Add(New ContaCorrente(277, 983323, "Cláudia Organa"))
        ListaContas.Add(New ContaCorrente(277, 788233, "José Firmino"))
        ListaContas.Add(New ContaCorrente(277, 322352, "Julio de Castilho"))
    End Sub

    Sub FormatarListView()
        ' Formatar o ListView

        Lvw_Contas.View = View.Details
        Lvw_Contas.LabelEdit = False
        Lvw_Contas.AllowColumnReorder = False
        Lvw_Contas.FullRowSelect = True
        Lvw_Contas.GridLines = True

    End Sub

    Sub CriarColunas()
        ' Configurar colunas

        Lvw_Contas.Columns.Add("Conta Corrente", 100, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Correntista", 150, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Saldo em R$", 100, HorizontalAlignment.Center)
    End Sub

    Sub AtualizarListView()

        ' Inclusao dos elementos

        Lvw_Contas.Items.Clear()

        For I As Integer = 0 To ListaContas.Count - 1
            Dim vContaNumero As String = ListaContas(I).agencia.ToString +
                "-" + ListaContas(I).numero.ToString
            Dim Linha As New ListViewItem
            Linha.Name = vContaNumero
            Linha.Text = vContaNumero
            Linha.SubItems.Add(ListaContas(I).titular.nome)
            Linha.SubItems.Add(ListaContas(I).saldo.ToString)
            Lvw_Contas.Items.Add(Linha)
        Next

    End Sub

    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        Dim F As New Frm_ContasCorrente
        F.ShowDialog()
        If F.Retorno Then
            ListaContas.Add(F.Conta)
            AtualizarListView()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim ListaContasExcluir As New List(Of ContaCorrente)
        For I As Integer = 0 To Lvw_Contas.Items.Count - 1
            If Lvw_Contas.Items(I).Selected Then
                Dim ContaExcluir As ContaCorrente
                ContaExcluir = ListaContas(I)
                ListaContasExcluir.Add(ContaExcluir)
            End If
        Next

        If ListaContasExcluir.Count > 0 Then
            For I As Integer = 0 To ListaContasExcluir.Count - 1
                Dim ContaExcluir As ContaCorrente
                ContaExcluir = ListaContasExcluir(I)
                ListaContas.Remove(ContaExcluir)
            Next
            AtualizarListView()
        End If

    End Sub

    Private Sub Rb_Conta_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Conta.CheckedChanged

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContas _
            .OrderBy(Function(conta As ContaCorrente) conta.agencia) _
            .OrderBy(Function(conta As ContaCorrente) conta.numero)

        AtualizaListaContas(ListaAuxiliar)

    End Sub

    Private Sub Rb_Nome_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Nome.CheckedChanged

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContas _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        AtualizaListaContas(ListaAuxiliar)

    End Sub

    Private Sub Rb_Saldo_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Saldo.CheckedChanged

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContas _
            .OrderBy(Function(conta As ContaCorrente) conta.saldo)

        AtualizaListaContas(ListaAuxiliar)

    End Sub

    Sub AtualizaListaContas(ListaAuxiliar As IEnumerable(Of ContaCorrente))

        ListaContas = New List(Of ContaCorrente)

        For I As Integer = 0 To ListaAuxiliar.Count - 1
            ListaContas.Add(ListaAuxiliar(I))
        Next

        AtualizarListView()

    End Sub
End Class