Option Strict On
Module Module1

    Sub Main()
        Dim et As Extraterrestre = New Extraterrestre("MiCasa", 1000)
        Dim predator As Extraterrestre = New Extraterrestre("PlanetaPredator", 2000)
        Dim alien As Extraterrestre = New Extraterrestre("IES Salceda", 5000)

        Dim alienigenas As ArrayList = New ArrayList()
        alienigenas.Add(et)
        alienigenas.Add(predator)
        alienigenas.Add(alien)

        For Each e As Extraterrestre In alienigenas
            Console.WriteLine(e.planeta)
        Next

        Dim ex As Extraterrestre = CType(alienigenas(0), Extraterrestre)

        'DICCIONARIOS: HASHTABLE
        Dim diccionario As Hashtable = New Hashtable()

        diccionario.Add("12345678A", "Angel Muñiz")
        diccionario.Add("12345678B", 9)
        diccionario.Add("12345678C", "Nuria Otero")
        diccionario.Add("1", et)
        Try
            diccionario.Add("12345678C", "Pedro Pedrooooo")
        Catch exc As Exception
            Console.WriteLine("No se ha podido agregar porque clave repetida!!!!")
        End Try


        'Búsqueda por dni

        Dim nombre As String = diccionario("12345678B").ToString()
        Dim extraterrestre As Extraterrestre = CType(diccionario("1"), Extraterrestre)

        Console.WriteLine(nombre)

        'Recorrer un hashtable
        For Each entrada As DictionaryEntry In diccionario
            Console.WriteLine(entrada.Key.ToString & " " & entrada.Value.ToString)
        Next

        'Recorrer sólo las claves
        For Each clave As String In diccionario.Keys
            Console.WriteLine(clave)
        Next

        'Recorrer sólo los valores
        'For Each valor As String In diccionario.Values
        '    Console.WriteLine(valor)
        'Next

        'COmprobar si existe una clave o un valor
        If diccionario.ContainsKey("12312312") Then
            Console.WriteLine("Ya esta guardada")
        Else
            'diccionario.Add("12312312","dasfasdfasd")
        End If

        If diccionario.ContainsValue(9) Then

        End If

        Dim gmi As ArrayList = New ArrayList
        gmi.Add("Martin Posada")
        gmi.Add("Mateo Perez")
        gmi.Add("Victor Dos Santos")
        gmi.Add("David Villar")


        Dim colegio As Hashtable = New Hashtable()

        colegio.Add("AS34", gmi)

        Dim lista As ArrayList = CType(colegio("AS34"), ArrayList)

        'Eliminar un eleento de un diccionario
        diccionario.Remove("12345678A")

        Dim diccionarioOrdenado As SortedList = New SortedList
        diccionarioOrdenado.Add(10, "Pepe")
        diccionarioOrdenado.Add(5, "Quique")
        diccionarioOrdenado.Add(8, "Maria")

        For Each entrada As DictionaryEntry In diccionarioOrdenado
            Console.WriteLine(entrada.Key.ToString & " " & entrada.Value.ToString)
        Next

        Console.ReadLine()
    End Sub

End Module
