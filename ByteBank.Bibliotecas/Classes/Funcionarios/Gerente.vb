Namespace Classes.Funcionarios

    Public Class Gerente
        Inherits FuncionarioAutenticavel

#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"

        Public Sub New(_cpf As String)
            MyBase.New(_cpf, 4000)
        End Sub

#End Region

#Region "MÉTODOS"

        Protected Friend Overrides Function GetBonificacao() As Double

            Return salario * 0.25

        End Function

        Public Overrides Sub AumentarSalario()

            salario = salario * 1.05

        End Sub

#End Region

    End Class

End Namespace


