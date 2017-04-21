Imports System.IO
Module Module1

    Sub Main()
        'Dim v As Vuelo = New Vuelo()

        'v.setCodigo("AW34")
        'v.codigoAvion = "Airbus7893"
        'v.fecha = New Date(2017, 3, 20)
        'v.plazasLibres = 290

        'Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("miArchivo.txt", True)

        'escritor.WriteLine(v.getCodigo() & "*" & v.codigoAvion & "*" & v.fecha.ToShortDateString & "*" & v.plazasLibres)
        'escritor.Close()

        ''Para recuperar vuelos del fichero

        'Dim vuelos(9) As Vuelo
        'Dim i As Integer = 0
        'Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader("miArchivo.txt")

        'While Not lector.EndOfStream
        '    If vuelos(i) Is Nothing Then
        '        'Reconstruir objeto a partir de String
        '        Dim propiedadesVuelo() As String = lector.ReadLine().Split("*")
        '        Dim vuelo As Vuelo = New Vuelo()
        '        vuelo.codigo = propiedadesVuelo(0)
        '        vuelo.codigoAvion = propiedadesVuelo(1)
        '        vuelo.fecha = New Date() 'Falta reconstruir la fecha

        '        vuelo.plazasLibres = propiedadesVuelo(3)

        '        vuelos(i) = vuelo
        '        i += 1
        '    End If
        'End While

        ''Comprobación

        'For Each vuelo As Vuelo In vuelos
        '    If Not vuelo Is Nothing Then
        '        Console.WriteLine(vuelo.codigo)

        '    End If
        'Next



        'Crear vuelos
        Dim v As Vuelo = New Vuelo()
        Dim v2 As Vuelo = New Vuelo("ER34", "Airbus456", New Date(2017, 4, 21), 450)

        'dar valores a v
        v.setCodigo("WE3")
        v.codigoAvion = "Boeing708"
        v.fecha = New Date(2017, 3, 20)
        v.plazasLibres = 300
        'Comprobar que v2 está correcto
        Console.WriteLine(v2)
        Console.ReadLine()


        Console.ReadLine()
    End Sub

End Module
