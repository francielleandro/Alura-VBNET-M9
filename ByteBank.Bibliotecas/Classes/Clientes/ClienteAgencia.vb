Namespace Classes.Clientes

    Public Class ClienteAgencia

#Region "PROPREIDADES"

        Public Property Nome As String
        Public Property TempoServico As Integer
        Public Property TempoEspera As Integer

#End Region

#Region "CONSTRUTORES"

        Public Sub New(_TempoServico As Integer, Senha As Integer)
            Nome = "Cliente Senha: " + Senha.ToString
            TempoServico = _TempoServico
            TempoEspera = 0
        End Sub

#End Region

#Region "MÉTODOS"

        Public Sub AdicionarTempoEspera(_TempoIncremento As Integer)
            TempoEspera += _TempoIncremento
        End Sub

#End Region

    End Class

End Namespace


