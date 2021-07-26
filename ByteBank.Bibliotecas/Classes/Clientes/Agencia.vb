Imports System.Collections.ObjectModel
Imports ByteBank.Bibliotecas.Classes.Funcionarios

Namespace Classes.Clientes

    Public Class Agencia

#Region "PROPRIEDADES"

        Public ReadOnly Property agencia As Integer
        Private _contasCorrentes As ISet(Of ContaCorrente)

        Public ReadOnly Property ContasCorrentes As IList(Of ContaCorrente)
            Get
                Dim contasCorrentesLista As New List(Of ContaCorrente)(_contasCorrentes)
                Return New ReadOnlyCollection(Of ContaCorrente)(contasCorrentesLista)
            End Get

        End Property

        ' ######################## SIMULAÇÃO ############

        Private Shared m_NumeroClienteFila As Integer
        Public Shared ReadOnly Property NumeroClienteFila As Integer
            Get
                Return m_NumeroClienteFila
            End Get
        End Property

        Private Shared m_TempoTotalFila As Integer
        Public Shared ReadOnly Property TempoTotalFila As Integer
            Get
                Return m_TempoTotalFila
            End Get
        End Property

        Public Property Caixas As List(Of Caixa)
        Public Property Fila As Queue(Of ClienteAgencia)

        Public Property NumeroCliente As Integer

        ' ####################################################

#End Region

#Region "CONSTRUTORES"

        Public Sub New(codigo As Integer)

            agencia = codigo
            _contasCorrentes = New HashSet(Of ContaCorrente)

            ' ######################## SIMULAÇÃO ############

            Caixas = New List(Of Caixa)
            Fila = New Queue(Of ClienteAgencia)
            m_NumeroClienteFila = 0
            m_TempoTotalFila = 0
            NumeroCliente = 0

            ' ####################################################

        End Sub

#End Region

#Region "METODOS"

        Public Sub AbrirContaCorrente(Numero As Integer, Nome As String)

            _contasCorrentes.Add(New ContaCorrente(agencia, Numero, Nome))

        End Sub

        Public Sub FecharContaCorrente(Numero As Integer, Nome As String)

            _contasCorrentes.Remove(New ContaCorrente(agencia, Numero, Nome))

        End Sub

        Public Function BuscaCC(Numero As Integer) As ContaCorrente

            Dim contaBuscar As New ContaCorrente(agencia, Numero)
            For Each conta As ContaCorrente In _contasCorrentes
                If conta.Equals(contaBuscar) Then
                    Return conta
                End If
            Next
            Throw New Exception("Conta não existente")

        End Function

        Public Sub AlterarCC(Numero As Integer, Nome As String)
            For Each conta As ContaCorrente In _contasCorrentes
                If conta.numero = Numero Then
                    conta.titular.nome = Nome
                    Exit For
                End If
            Next

        End Sub

        ' ######################## SIMULAÇÃO ############

        Public Sub EntrarNaFila(_TempoServico As Integer)
            NumeroCliente += 1
            Dim Cliente As New ClienteAgencia(_TempoServico, NumeroCliente)
            Fila.Enqueue(Cliente)

        End Sub

        Public Sub ExecutaAtendimento(_TempoIncremento As Integer)
            For I As Integer = 0 To Caixas.Count - 1
                If Caixas(I).Ocupado = True Then
                    Caixas(I).EfetuarAtendimento(_TempoIncremento)
                End If
            Next
            For I As Integer = 0 To Fila.Count - 1
                Fila(I).AdicionarTempoEspera(_TempoIncremento)
            Next
        End Sub

        Public Sub SairDaFila()
            If Fila.Count > 0 Then
                For I As Integer = 0 To Caixas.Count - 1
                    If Caixas(I).Ocupado = False Then
                        If Fila.Count > 0 Then
                            Dim Cliente As ClienteAgencia = Fila.Dequeue()
                            m_NumeroClienteFila += 1
                            m_TempoTotalFila += Cliente.TempoEspera
                            Caixas(I).IniciarAtendimento(Cliente.TempoServico)
                        End If
                    End If
                Next
            End If
        End Sub

        Public Function TamanhoFila() As Integer
            Return Fila.Count
        End Function

        ' ####################################################

#End Region

    End Class

End Namespace


