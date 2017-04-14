Module Module1

    Sub Main()
        Dim vuelos As Dictionary(Of String, Vuelo) = New Dictionary(Of String, Vuelo)()

        Dim v As Vuelo = New Vuelo("AW34", "Airbus230", New Date(2017, 5, 20), 250)
        Dim v2 As Vuelo = New Vuelo("AQ14", "Boeing747", New Date(2017, 5, 20), 300)
        Dim v3 As Vuelo = New Vuelo("ZW34", "Airbus2000", New Date(2017, 6, 10), 190)

        'Guardar vuelos en el diccionario

        vuelos.Add(v.codigo, v)
        vuelos.Add(v2.codigo, v2)
        vuelos.Add(v3.codigo, v3)

        'Recorrer dictionary

        For Each kvp As KeyValuePair(Of String, Vuelo) In vuelos
            Console.WriteLine(kvp.Key & " - " & kvp.Value.ToString())
        Next
        'Buscar por clave

        Dim vuelo As Vuelo = vuelos("AW34")


        'Eliminar una entrada en el diccionario
        vuelos.Remove("ZW34")

        For Each kvp As KeyValuePair(Of String, Vuelo) In vuelos
            Console.WriteLine(kvp.Key & " - " & kvp.Value.ToString())
        Next
        Console.ReadLine()
    End Sub

End Module
