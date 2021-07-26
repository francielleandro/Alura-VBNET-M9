Imports System.Collections.ObjectModel

Namespace Classes.Clientes

    Public Class AgenciaDic


#Region "PROPRIEDADES"

        Public ReadOnly Property agencia As Integer

        Private _ContasCorrentes As IDictionary(Of Integer, ContaCorrente)

        Public ReadOnly Property ContasCorrentes As IDictionary(Of Integer, ContaCorrente)
            Get
                Return _ContasCorrentes
            End Get

        End Property

#End Region

#Region "CONSTRUTORES"

        Public Sub New(codigo As Integer)

            agencia = codigo
            _ContasCorrentes = New Dictionary(Of Integer, ContaCorrente)

        End Sub

#End Region

#Region "METODOS"

        Public Sub AbrirContaCorrente(Numero As Integer, Nome As String)

            _ContasCorrentes.Add(Numero, New ContaCorrente(agencia, Numero, Nome))

        End Sub

        Public Sub FecharContaCorrente(Numero As Integer, Nome As String)

            _ContasCorrentes.Remove(Numero)

        End Sub

        Public Function BuscaCC(Numero As Integer) As ContaCorrente

            Return _ContasCorrentes(Numero)

        End Function

        Public Sub AlterarCC(Numero As Integer, Nome As String)

            _ContasCorrentes(Numero).titular.nome = Nome

        End Sub


#End Region

    End Class

End Namespace


