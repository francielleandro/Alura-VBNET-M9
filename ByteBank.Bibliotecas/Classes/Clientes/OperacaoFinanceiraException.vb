Namespace Classes.Clientes

    Public Class OperacaoFinanceiraException
        Inherits Exception

#Region "CONSTRUTORES"

        Sub New()

        End Sub

        Sub New(Message As String)
            MyBase.New(Message)

        End Sub

        Sub New(Message As String, excecaoInterna As Exception)
            MyBase.New(Message, excecaoInterna)

        End Sub

#End Region

    End Class

End Namespace


