Imports ByteBank.Bibliotecas.Classes.Clientes

Namespace Classes.Criterios

    Public Class CriterioContaCorrenteAgenciaNumero
        Implements IComparer(Of ContaCorrente)

        Public Function Compare(x As ContaCorrente, y As ContaCorrente) As Integer Implements IComparer(Of ContaCorrente).Compare

            ' SE X < Y ---> -1
            ' SE X = Y ---> 0
            ' SE X > Y ---> 1

            Dim vAgenciaX As String = x.agencia.ToString
            Dim vContaX As String = x.numero.ToString

            Dim vAgenciaY As String = y.agencia.ToString
            Dim vContaY As String = y.numero.ToString

            Dim vCriterioX As String = vAgenciaX + "-" + vContaX
            Dim vCriterioY As String = vAgenciaY + "-" + vContaY

            If vCriterioX < vCriterioY Then
                Return -1
            End If
            If vCriterioX = vCriterioY Then
                Return 0
            End If
            Return 1

            'Return x.titular.nome.CompareTo(y.titular.nome)

        End Function

    End Class

End Namespace