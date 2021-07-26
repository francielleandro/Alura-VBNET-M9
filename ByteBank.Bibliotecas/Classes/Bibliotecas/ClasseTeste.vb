Namespace Classes.Bibliotecas

    Public Class ClasseTeste

        Sub Teste()

            'Dim X As New ModificadoresTeste
            'X.MetodoPublico()
            'X.MetodoPrivado()
            'X.MetodoProtegico()

        End Sub

    End Class

    Public Class ClassDerivada
        Inherits ModificadoresTeste

        Sub Teste2()

            MetodoProtegico()

        End Sub

    End Class

    Public Class ModificadoresTeste

        Sub Teste()

            Dim X As New ModificadoresTeste
            X.MetodoPublico()
            X.MetodoPrivado()
            X.MetodoProtegico()
            X.MetodoInterno()

        End Sub

        Public Sub MetodoPublico()

            ' Método acessado pela propria classe, pela classe do mesmo projeto 
            ' e por classes de outros projetos

        End Sub

        Private Sub MetodoPrivado()

            ' Método acessado pela propria classe, não é acessaod pela classe do mesmo projeto 
            ' e não é acessado por classes de outros projetos.

        End Sub

        Protected Sub MetodoProtegico()

            ' Método acessado pela propria classe, não é acessaod pela classe do mesmo projeto 
            ' e não é acessado por classes de outros projetos. Mas pode ser acessado pelas
            ' classes derivadas.

        End Sub

        Friend Sub MetodoInterno()

            ' Método acessado pela propria classe, acxessado pela classe do mesmo projeto 
            ' e não é acessado por classes de outros projetos.

        End Sub

    End Class

End Namespace



