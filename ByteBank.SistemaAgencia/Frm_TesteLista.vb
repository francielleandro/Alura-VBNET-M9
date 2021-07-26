Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.Bibliotecas.Classes.Criterios

Public Class Frm_TesteLista
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Lista As New List(Of Integer)
        Lista.Add(10)
        Lista.Add(12)
        Lista.Add(8)
        Lista.Add(2)

        MsgBox(Lista.Contains(8))

        Lista.Sort()

        MsgBox(Lista(0))
        MsgBox(Lista(1))
        MsgBox(Lista(2))
        MsgBox(Lista(3))

        Dim ListaS As New List(Of String)
        ListaS.Add("João")
        ListaS.Add("Pedro")
        ListaS.Add("Antonio")
        ListaS.Add("Beatriz")

        MsgBox(ListaS.Contains("Pedro"))

        ListaS.Sort()

        MsgBox(ListaS(0))
        MsgBox(ListaS(1))
        MsgBox(ListaS(2))
        MsgBox(ListaS(3))


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Lista As List(Of Integer)
        Lista = New List(Of Integer)

        Dim Conjunto As ISet(Of Integer)
        Conjunto = New HashSet(Of Integer)

        Lista.Add(25)
        Lista.Add(12)
        Lista.Add(8)

        Conjunto.Add(25)
        Conjunto.Add(12)
        Conjunto.Add(8)

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", Conjunto))

        Lista.Remove(12)
        Lista.Add(2)

        Conjunto.Remove(12)
        Conjunto.Add(2)

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", Conjunto))

        Lista.Add(2)
        Conjunto.Add(2)

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", Conjunto))

        Lista.Sort()

        Dim ListaTemporaria As New List(Of Integer)(Conjunto)
        ListaTemporaria.Sort()

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", ListaTemporaria))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim ag As New Agencia(277)

        ag.AbrirContaCorrente(17777, "Marília")
        ag.AbrirContaCorrente(22222, "Márcia")
        ag.AbrirContaCorrente(3333, "Victor")

        MsgBox("Contas correntes da agencia: " +
               ag.agencia.ToString + " Contas: " + String.Join(" | ", ag.ContasCorrentes))

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Dim ListaDias As New List(Of String)
        'ListaDias.Add("Segunda")
        'ListaDias.Add("Terça")
        'ListaDias.Add("Quinta")
        'ListaDias.Add("Sexta")
        'ListaDias.Add("Sábado")

        'MsgBox(String.Join(" , ", ListaDias))

        'ListaDias.Add("Quarta")

        'MsgBox(String.Join(" , ", ListaDias))


        Dim ListaDiasLink As New LinkedList(Of String)

        Dim D4 As LinkedListNode(Of String) = ListaDiasLink.AddFirst("Quarta")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D2 As LinkedListNode(Of String) = ListaDiasLink.AddBefore(D4, "Segunda")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D3 As LinkedListNode(Of String) = ListaDiasLink.AddBefore(D4, "Terça")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D6 As LinkedListNode(Of String) = ListaDiasLink.AddAfter(D4, "Sexta")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D7 As LinkedListNode(Of String) = ListaDiasLink.AddAfter(D6, "Sábado")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D5 As LinkedListNode(Of String) = ListaDiasLink.AddBefore(D6, "Quinta")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D1 As LinkedListNode(Of String) = ListaDiasLink.AddFirst("Domingo")
        MsgBox(String.Join(" , ", ListaDiasLink))

        MsgBox("A lista linked possui " + ListaDiasLink.Count.ToString + " elementos.")

        For i As Integer = 0 To ListaDiasLink.Count - 1
            MsgBox(ListaDiasLink(i))
        Next

        MsgBox(String.Join(" , ", ListaDiasLink))
        ListaDiasLink.Remove(D1)
        MsgBox(String.Join(" , ", ListaDiasLink))
        ListaDiasLink.Remove("Quarta")
        MsgBox(String.Join(" , ", ListaDiasLink))

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim Paginas As New Stack(Of String)
        Paginas.Push("Página 1")
        Paginas.Push("Página 2")
        Paginas.Push("Página 3")
        Paginas.Push("Página 4")
        Paginas.Push("Página 5")
        MsgBox(String.Join(" , ", Paginas))
        Dim X As String = Paginas.Pop()
        MsgBox(String.Join(" , ", Paginas))
        Dim Y As String = Paginas.Peek()
        MsgBox(String.Join(" , ", Paginas))
        MsgBox(X + " - " + Y)

        Dim PaginasRevertidas = Paginas.Reverse
        MsgBox(String.Join(" , ", Paginas))
        MsgBox(String.Join(" , ", PaginasRevertidas))

        For I As Integer = 0 To Paginas.Count - 1
            MsgBox(Paginas(I))
        Next

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Conta1 As New ContaCorrente(277, 223444, "João")
        Conta1.Depositar(10000)

        Dim Conta2 As New ContaCorrente(277, 255645, "Pedro")
        Conta2.Depositar(5000)

        Dim Conta3 As New ContaCorrente(500, 166323, "Alberto")
        Conta3.Depositar(7000)

        Dim ListaContasCorrentes As New List(Of ContaCorrente)

        ListaContasCorrentes.Add(Conta1)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta2)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta3)

        MsgBox("Lista de contas original: " + String.Join(",",
        ListaContasCorrentes))

        'Dim ListaAuxiliar As New List(Of ContaCorrente)

        'For I As Integer = 0 To ListaContasCorrentes.Count - 1

        '    If Not (ListaContasCorrentes(I) Is Nothing) Then

        '        ListaAuxiliar.Add(ListaContasCorrentes(I))

        '    End If

        'Next

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
        .Where(Function(conta As ContaCorrente) Not (conta Is Nothing))

        ' ListaContasCorrentes.Sort(New CriterioContaCorrenteNome())
        Dim X As IEnumerable(Of ContaCorrente) = ListaAuxiliar _
        .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        MsgBox("Lista de contas ordenada por nome: " + String.Join(",", X))

        'ListaContasCorrentes.Sort(New CriterioContaCorrenteSaldo())
        Dim y As IEnumerable(Of ContaCorrente) =
        ListaAuxiliar.OrderBy(Function(conta As ContaCorrente) conta.saldo)

        MsgBox("Lista de contas ordenada por saldo: " + String.Join(",", y))

        'ListaContasCorrentes.Sort(New CriterioContaCorrenteAgenciaNumero())
        Dim z As IEnumerable(Of ContaCorrente) = ListaAuxiliar _
        .OrderBy(Function(conta As ContaCorrente) conta.agencia) _
        .OrderBy(Function(conta As ContaCorrente) conta.numero)

        MsgBox("Lista de contas ordenada por agencia/numero: " +
        String.Join(",", ListaContasCorrentes))

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Conta1 As New ContaCorrente(277, 223444, "João")
        Conta1.Depositar(10000)

        Dim Conta2 As New ContaCorrente(277, 255645, "Pedro")
        Conta2.Depositar(5000)

        Dim Conta3 As New ContaCorrente(500, 166323, "Alberto")
        Conta3.Depositar(7000)

        Dim ListaContasCorrentes As New List(Of ContaCorrente)

        ListaContasCorrentes.Add(Conta1)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta2)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta3)

        Dim ListaContasCorrentes2 As New List(Of ContaCorrente)

        ListaContasCorrentes2.Add(Conta1)
        ListaContasCorrentes2.Add(Conta2)
        ListaContasCorrentes2.Add(Conta3)

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
            .Where(Function(conta As ContaCorrente) Not (conta Is Nothing)) _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        Dim MaiorSaldo2 As Double = ListaContasCorrentes _
            .Where(Function(conta As ContaCorrente) Not (conta Is Nothing)) _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome) _
            .Min(Function(conta As ContaCorrente) conta.saldo)

        MsgBox("Lista de contas ordenada por nome: " + String.Join(",", ListaAuxiliar))

        Dim MenorSaldo As Double = ListaAuxiliar.Min(Function(conta As ContaCorrente) conta.saldo)
        MsgBox("O menor saldo é de: " + MenorSaldo.ToString)

        Dim MaiorSaldo As Double = ListaAuxiliar.Max(Function(conta As ContaCorrente) conta.saldo)
        MsgBox("O maior saldo é de: " + MaiorSaldo.ToString)

        Dim ListaAuxiliarComcatenada As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
            .Where(Function(conta As ContaCorrente) Not (conta Is Nothing)) _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome) _
            .Concat(ListaContasCorrentes2)

        MsgBox("Lista de contas concatenadas " + String.Join(",", ListaAuxiliarComcatenada))

        Dim ListaAuxiliarComcatenada2 As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
            .Where(Function(conta As ContaCorrente) Not (conta Is Nothing)) _
            .Concat(ListaContasCorrentes2) _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        MsgBox("Lista de contas concatenadas " + String.Join(",", ListaAuxiliarComcatenada2))
    End Sub
End Class