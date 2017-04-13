Option Strict On
Imports System.Collections
Module Module1

    Sub Main()
        Dim diccionario As Hashtable = New Hashtable()
        diccionario.Add("38909810P", "Manuel Sánchez")
        diccionario.Add("99999999A", "Ana Santos")
        diccionario.Add("222222222M", "Paula Barrio")

        'Búsqueda a partir de clave

        Dim nombre As String = diccionario("222222222M").ToString()
        Console.WriteLine(nombre)
        '************************** // *************************
        'Recorrer un diccionario

        For Each entrada As DictionaryEntry In diccionario
            Console.WriteLine(entrada.Key.ToString() + " " + entrada.Value.ToString())
        Next

        '************************** // *************************
        'Obtener valores
        Dim valores As ICollection = diccionario.Values

        'Recorrer los valores
        For Each valor As String In valores
            Console.WriteLine(valor)
        Next

        '************************** // *************************
        'Obtener claves

        Dim claves As ICollection = diccionario.Keys
        '  Dim listaClaves As ArrayList = New ArrayList(claves) --> Podríamos guardarlas en una Lista

        'Recorrer los valores
        For Each clave As String In claves
            Console.WriteLine(clave)
        Next

        'Buscar clave
        If diccionario.ContainsKey("12121212") Then

        End If

        'Buscar valor

        If diccionario.ContainsValue("Manuel") Then

        End If

        Console.ReadLine()
    End Sub

End Module
