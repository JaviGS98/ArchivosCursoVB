Option Strict On
Module Module1

    Sub Main()
        'ArrayList Genérico: List
        Dim nombres As List(Of String) = New List(Of String)()
        nombres.Add("Pedro Gutierrez")

        Dim n As String = nombres(0)

        Dim lista As ArrayList = New ArrayList()
        lista.Add(New Factura("dasd21", 34))
        lista.Add(New Factura("aasd", 899))
        lista.Add("234121")

        'For Each f As Factura In lista
        '    Console.WriteLine(f.referencia)
        'Next

        For i As Integer = 0 To lista.Count - 1 Step 1
            ' If lista(i).GetType() = GetType(Factura) Then
            Console.WriteLine(CType(lista(i), Factura).referencia)
            ' End If

        Next

        Dim facturas As List(Of Factura) = New List(Of Factura)()

        facturas.Add(New Factura("323423", 566))
        facturas.Add(New Factura("123123", 900))

        For i As Integer = 0 To facturas.Count - 1 Step 1
            Console.WriteLine(facturas(i).referencia)
        Next

        Console.ReadLine()
    End Sub

End Module
