Module Module1

    Sub Main()
        Dim peliculas As List(Of String) = New List(Of String)()
        Console.WriteLine("La capacidad actual es: " & peliculas.Capacity)
        peliculas.Add("Regreso al Futuro")
        Console.WriteLine("La capacidad actual es: " & peliculas.Capacity)
        peliculas.Add("Alien")
        Console.WriteLine("La capacidad actual es: " & peliculas.Capacity)
        peliculas.Add("Shutter Island")
        Console.WriteLine("La capacidad actual es: " & peliculas.Capacity)
        peliculas.Add("Abyss")
        Console.WriteLine("La capacidad actual es: " & peliculas.Capacity)
        peliculas.Add("Desafio total")
        Console.WriteLine("La capacidad actual es: " & peliculas.Capacity)

        'Para ajustar la capacidad al número real de elementos utilizamos la función trimExcess
        peliculas.TrimExcess()
        Console.WriteLine("Después de ajustar la capacidad actual es: " & peliculas.Capacity)
        'Al acceder a una posición ya devuelve un String
        Console.WriteLine(peliculas(0).Substring(3))


        Console.ReadLine()

    End Sub

End Module
