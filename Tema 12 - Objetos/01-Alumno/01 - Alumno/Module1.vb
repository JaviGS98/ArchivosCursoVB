Option Strict On
Module Module1

    Sub Main()
        'Creo un alumno le pongo notas y calculo la media

        Dim alumno20Abril As Alumno = New Alumno("1111111W", "Pedro", "Díaz", 35)

        'Modificar el DNI
        alumno20Abril.setDNI("123456789")

        'Poner notas
        alumno20Abril.ponerNotas(10, 3, 6, 10)
        'Calcular la media
        alumno20Abril.calcularMedia()

        Console.WriteLine(alumno20Abril)

        'Mostrar el DNI

        Console.WriteLine(alumno20Abril.getDNI())





        Console.ReadLine()
    End Sub

End Module
