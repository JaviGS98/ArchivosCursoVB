Module Module1

    Sub Main()
        Dim conjunto As HashSet(Of String) = New HashSet(Of String)()
        conjunto.Add("Gutiérrez Fernández Raúl")
        conjunto.Add("Sánchez cantón María")
        conjunto.Add("Alvarez Castro Rafael")
        conjunto.Add("Ildigo López Asunción")
        conjunto.Add("Estevez Estevez Sonia")
        conjunto.Add("Berssali Camez Brubo")
        conjunto.Add("Dalisio Iraizoz Gorka")
        conjunto.Add("Ildigo López Asunción")


        For Each p As String In conjunto
            Console.WriteLine(p)
        Next

        Console.WriteLine()
        Console.WriteLine("Ahora trabajaremos con un SortedSet:")
        Console.WriteLine()
        'Conjunto ordenado
        Dim conjuntoOrdenado As SortedSet(Of String) = New SortedSet(Of String)()
        conjuntoOrdenado.Add("Gutiérrez Fernández Raúl")
        conjuntoOrdenado.Add("Sánchez cantón María")
        conjuntoOrdenado.Add("Alvarez Castro Rafael")
        conjuntoOrdenado.Add("Ildigo López Asunción")
        conjuntoOrdenado.Add("Estevez Estevez Sonia")
        conjuntoOrdenado.Add("Berssali Camez Brubo")
        conjuntoOrdenado.Add("Dalisio Iraizoz Gorka")
        conjuntoOrdenado.Add("Ildigo López Asunción")


        For Each p As String In conjuntoOrdenado
            Console.WriteLine(p)
        Next




        Console.ReadLine()
    End Sub

End Module
