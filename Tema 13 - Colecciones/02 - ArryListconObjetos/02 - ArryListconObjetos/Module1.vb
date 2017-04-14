Option Strict On
Module Module1

    Sub Main()
        Dim vuelos As ArrayList = New ArrayList()
        vuelos.Add(New Vuelo("AW34", "Airbus230", New Date(2017, 5, 20), 250))
        vuelos.Add(New Vuelo("AQ14", "Boeing747", New Date(2017, 5, 20), 300))
        vuelos.Add(New Vuelo("ZW34", "Airbus2000", New Date(2017, 6, 10), 190))
        vuelos.Add(New Vuelo("BB14", "Boeing90", New Date(2017, 7, 9), 310))

        vuelos.Item(0).




        'Internamente son objects por lo que a veces tendremos que convertirlos
        'Imaginémonos que queremos modificar el codigo del avión que ocupa las posición 0
        Dim vuelo As Vuelo = CType(vuelos.Item(0), Vuelo)

        vuelo.codigoAvion = "PL10"

        'Poner a 300 todas las plazas
        For i As Integer = 0 To vuelos.Count - 1 Step 1
            CType(vuelos(i), Vuelo).plazasLibres = 300
        Next
        'Con un For each es más fácil

        For Each v As Vuelo In vuelos
            v.plazasLibres = 300
        Next


    End Sub

End Module
