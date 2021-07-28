Imports ByteBank.Bibliotecas.Classes.Clientes
Public Class Frm_ContasCorrente
    Public Property Conta As ContaCorrente
    Public Property Retorno As Boolean

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Me.Text = "Conta Corrente"
        Retorno = False
        Lbl_ContaCorrente.Text = "Conta Corrente"

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click

        Retorno = True
        Dim ContaAux As New ContaCorrente(Txt_Agencia.Text, Txt_Conta.Text, Txt_Nome.Text)
        Conta = ContaAux
        Me.Close()

    End Sub

End Class