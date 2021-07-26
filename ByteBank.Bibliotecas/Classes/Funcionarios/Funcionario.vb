
Namespace Classes.Funcionarios

    Public MustInherit Class Funcionario

#Region "PROPRIEDADES"
        Public Property nome As String

        Private m_cpf As String
        Public ReadOnly Property cpf As String
            Get
                Return m_cpf
            End Get
        End Property

        Private m_salario As Double
        Public Property salario As Double
            Get
                Return m_salario
            End Get
            Protected Set(value As Double)
                m_salario = value
            End Set
        End Property

        Private Shared m_TotalDeFuncionarios As Integer
        Public Shared ReadOnly Property TotalDeFuncionario() As Integer
            Get
                Return m_TotalDeFuncionarios
            End Get
        End Property


#End Region

#Region "CONSTRUTORES"

        Public Sub New(_cpf As String, _Salario As Double)
            m_cpf = _cpf
            m_salario = _Salario
            m_TotalDeFuncionarios += 1
            Console.WriteLine("CONSTRUTOR DA CLASSE FUNCIONARIO")
        End Sub

#End Region

#Region "MÉTODOS"

        'Overridable = substituivel !!!!!!

        Protected Friend MustOverride Function GetBonificacao() As Double

        Public MustOverride Sub AumentarSalario()

#End Region



    End Class

End Namespace












