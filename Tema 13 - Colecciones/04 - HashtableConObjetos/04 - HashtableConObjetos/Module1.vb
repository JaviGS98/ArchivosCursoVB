Option Strict On
Module Module1

    Sub Main()
        Dim vuelosDiccionario As Hashtable = New Hashtable()

        Dim v1 As Vuelo = New Vuelo("AW34", "Airbus230", New Date(2017, 5, 20), 250)
        Dim v2 As Vuelo = New Vuelo("AQ14", "Boeing747", New Date(2017, 5, 20), 300)
        Dim v3 As Vuelo = New Vuelo("ZW34", "Airbus2000", New Date(2017, 6, 10), 190)

        'Añadir al diccionario utilizando como clave el código del avión

        vuelosDiccionario.Add(v1.codigo, v1)
        vuelosDiccionario.Add(v2.codigo, v2)
        vuelosDiccionario.Add(v3.codigo, v3)

        'Buscar un vuelo por código
        Dim vuelo As Vuelo = CType(vuelosDiccionario("AW34"), Vuelo)
        Console.WriteLine(vuelo)
        For Each entrada As DictionaryEntry In vuelosDiccionario
            Console.WriteLine(CType(entrada.Value, Vuelo))
        Next


        Console.ReadLine()

        'En muchas ocasiones interesa pasar una lista a un Diccionario
        Dim vuelos As ArrayList = New ArrayList()
        vuelos.Add(New Vuelo("AW34", "Airbus230", New Date(2017, 5, 20), 250))
        vuelos.Add(New Vuelo("AQ14", "Boeing747", New Date(2017, 5, 20), 300))
        vuelos.Add(New Vuelo("ZW34", "Airbus2000", New Date(2017, 6, 10), 190))
        vuelos.Add(New Vuelo("BB14", "Boeing90", New Date(2017, 7, 9), 310))

        Dim dic As Hashtable = New Hashtable()

        For Each v As Vuelo In vuelos
            vuelosDiccionario.Add(v.codigo, v)
        Next

    End Sub

End Module
