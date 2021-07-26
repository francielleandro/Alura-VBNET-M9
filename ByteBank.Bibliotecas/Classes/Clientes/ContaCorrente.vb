
Namespace Classes.Clientes


    ''' <summary>
    ''' Esta classe representa uma conta corrente aberta pelo cliente do banco ByteBank
    ''' </summary>
    Public Class ContaCorrente
        Implements IComparable

#Region "PROPRIEDADES"

        Private Shared m_TaxaOperacao As Integer
        Public Shared ReadOnly Property TaxaOperacao As Integer
            Get
                Return m_TaxaOperacao
            End Get
        End Property

        Private Shared m_TotalDeContasCriadas As Integer
        Public Shared ReadOnly Property TotalDeContasCriadas As Integer
            Get
                Return m_TotalDeContasCriadas
            End Get
        End Property

        Public Property titular As Cliente

        Public ReadOnly Property numero As Integer

        Private m_NumeroSaquesErrados As Integer
        Public Property NumeroSaquesErrados As Integer
            Get
                Return m_NumeroSaquesErrados
            End Get
            Private Set(value As Integer)
                m_NumeroSaquesErrados = value
            End Set
        End Property

        Private m_NumeroTransferenciasErradas As Integer
        Public Property NumeroTransferenciasErradas As Integer
            Get
                Return m_NumeroTransferenciasErradas
            End Get
            Private Set(value As Integer)
                m_NumeroTransferenciasErradas = value
            End Set
        End Property

        Public ReadOnly Property agencia As Integer

        Private m_saldo As Double = 100
        Public Property saldo As Double
            Get
                Return m_saldo
            End Get
            Set(value As Double)
                If value <= 0 Then
                    m_saldo = 0
                Else
                    m_saldo = value
                End If
            End Set
        End Property


#End Region

#Region "CONSTRUTORES"

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Este construtor instancia uma nova classe contacorrente, Devemos passar como parametro o número da agencia e número da conta
        ''' </summary>
        ''' <param name="CodigoAgencia">Representa o código da agencia expresso em número inteiro. Este valor deve ser maior que zero. O parametro será atribuido a propriedade <see cref="agencia"/></param>
        ''' <param name="NumeroConta">Representa o código da conta corrente expresso em número inteiro. Este valor deve ser maior que zero. O parametro será atribuido a propriedade <see cref="numero"/></param>
        Public Sub New(CodigoAgencia As Integer, NumeroConta As Integer)

            If (CodigoAgencia <= 0) Then

                Dim vParametro As String
                vParametro = NameOf(CodigoAgencia)

                Dim Erro As New ArgumentException("Código da agência menor que zero !!!!", vParametro)
                Throw Erro

            ElseIf (NumeroConta <= 0) Then

                Dim vParametro As String
                vParametro = NameOf(NumeroConta)

                Dim Erro As New ArgumentException("Número da conta menor que zero !!!!", vParametro)
                Throw Erro

            End If

            agencia = CodigoAgencia
            Me.numero = NumeroConta
            m_TotalDeContasCriadas += 1

            m_TaxaOperacao = 30 / m_TotalDeContasCriadas

        End Sub

        Public Sub New(CodigoAgencia As Integer, NumeroConta As Integer, NomeCliente As String)

            If (CodigoAgencia <= 0) Then

                Dim vParametro As String
                vParametro = NameOf(CodigoAgencia)

                Dim Erro As New ArgumentException("Código da agência menor que zero !!!!", vParametro)
                Throw Erro

            ElseIf (NumeroConta <= 0) Then

                Dim vParametro As String
                vParametro = NameOf(NumeroConta)

                Dim Erro As New ArgumentException("Número da conta menor que zero !!!!", vParametro)
                Throw Erro

            ElseIf (NomeCliente = "") Then

                Dim vParametro As String
                vParametro = NameOf(NomeCliente)

                Dim Erro As New ArgumentException("Nome do Cliente em branco !!!!", vParametro)
                Throw Erro

            End If

            agencia = CodigoAgencia
            Me.numero = NumeroConta
            m_TotalDeContasCriadas += 1

            m_TaxaOperacao = 30 / m_TotalDeContasCriadas

            Dim Cliente As New Cliente
            Cliente.nome = NomeCliente

            titular = Cliente

        End Sub


#End Region

#Region "MÉTODOS"

        ''' <summary>
        ''' Representa a ação de sacar valores do saldo da conta corrente. 
        ''' </summary>
        ''' <exception cref="ArgumentException">Esta exceção irá aconetcer quando o <paramref name="ValorSacado"/> for menor que zero.</exception> 
        ''' <exception cref="ValorSacadoMenorSaldoException">Esta exceção irá acontecer se o vaor de <see cref="m_saldo"/> for menor que o <paramref name="ValorSacado"/>. </exception>
        ''' <param name="ValorSacado">Valor a ser sacado da conta e será atualizado na propriedade <see cref="m_saldo"/>. É um integer</param>
        ''' <param name="ValorLabel">Valor que representa o tipo de mensagem de alerta que deverá ser exibida ao usuário. É um string.</param>
        Public Sub Sacar(ValorSacado As Double, ValorLabel As String)

            If ValorSacado < 0 Then
                m_NumeroSaquesErrados += 1
                Throw New ArgumentException("Valor " + ValorLabel + " é negativo. " + ValorSacado.ToString, NameOf(ValorSacado))
            End If

            If m_saldo < ValorSacado Then
                Dim vMensagem As String
                vMensagem = "Valor " + ValorLabel + " é maior que o saldo"
                m_NumeroSaquesErrados += 1
                Throw New ValorSacadoMenorSaldoException(ValorSacado, m_saldo, vMensagem)

            Else
                m_saldo -= ValorSacado
            End If


        End Sub

        Public Sub Depositar(ValorDepositado As Double)

            m_saldo += ValorDepositado

        End Sub

        Public Sub Transferir(ValorTransferencia As Double,
                                   ContaDestino As ContaCorrente)

            Try
                Sacar(ValorTransferencia, "da transferencia")
            Catch ex As ValorSacadoMenorSaldoException
                m_NumeroTransferenciasErradas += 1
                Throw New OperacaoFinanceiraException("Operação não realizada", ex)

            Catch ex As ArgumentException
                m_NumeroTransferenciasErradas += 1
                Throw

            End Try
            ContaDestino.Depositar(ValorTransferencia)

        End Sub

        Public Overrides Function Equals(obj As Object) As Boolean

            Dim outraConta As New ContaCorrente()
            outraConta = TryCast(obj, ContaCorrente)
            If outraConta Is Nothing Then
                Return False
            End If
            If outraConta.agencia = agencia And outraConta.numero = numero Then
                Return True
            End If
            Return False

        End Function

        Public Overrides Function GetHashCode() As Integer
            Return agencia.GetHashCode And numero.GetHashCode
        End Function

        Public Overrides Function ToString() As String

            Return $"Agencia: {agencia.ToString} Conta: {numero.ToString} Nome: {titular.nome}"

        End Function

        Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo

            Dim outraConta As New ContaCorrente()
            outraConta = TryCast(obj, ContaCorrente)
            Return titular.nome.CompareTo(outraConta.titular.nome)
        End Function

#End Region


    End Class

End Namespace



