Namespace Classes.Funcionarios

    Public Class Caixa

#Region "PROPRIEDADES"

        Public Property Nome As String
        Public Property Ocupado As Boolean
        Public Property TempoAtendimento As Integer
        Public Property TempoMaximo As Integer

#End Region

#Region "CONSTRUTORES"

        Public Sub New(_Nome As String)
            Nome = _Nome
            Ocupado = False
        End Sub

#End Region

#Region "MÉTODOS"

        Public Sub IniciarAtendimento(_TempoServico As Integer)
            TempoMaximo = _TempoServico
            Ocupado = True
            TempoAtendimento = 0
        End Sub

        Public Sub EfetuarAtendimento(_TempoIncremento As Integer)
            If Ocupado = True Then
                TempoAtendimento += _TempoIncremento
                If TempoAtendimento >= TempoMaximo Then
                    Ocupado = False
                End If
            End If
        End Sub

        Public Function MostrarStatus() As String
            Dim vStatus As String = "Caixa " + Nome
            If Ocupado Then
                vStatus += " Ocupado."
            Else
                vStatus += " Livre."
            End If
            Return vStatus
        End Function

#End Region

    End Class


End Namespace

