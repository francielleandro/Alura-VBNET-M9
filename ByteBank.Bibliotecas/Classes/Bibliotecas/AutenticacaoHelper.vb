
Namespace Classes.Bibliotecas

    Friend Class AutenticacaoHelper

        Public Function Autenticar(senhaTentativa As String, senhaUsuario As String) As Boolean
            If senhaUsuario = senhaTentativa Then
                Return True
            End If
            Return False

            'Dim X As New ModificadoresTeste
            'X.MetodoPublico()
            'X.MetodoPrivado()
            'X.MetodoProtegico()
            'X.MetodoInterno()

        End Function

    End Class

End Namespace



