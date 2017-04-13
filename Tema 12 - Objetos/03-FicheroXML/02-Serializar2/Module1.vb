Imports System.IO
Imports System.Xml.Serialization

Module Module1

    Sub Main()
        Dim v As Vuelo = New Vuelo()

        v.codigo = "234E"
        v.codigoAvion = "Airbus3450"
        v.fecha = New Date(2017, 2, 10)
        v.plazasLibres = 240

        Dim serializador As XmlSerializer = New XmlSerializer(GetType(Vuelo))
        Dim escritor As StreamWriter = New StreamWriter("miArchivo.xml") 'Lo crea y lo guarda en carpeta debug
        serializador.Serialize(escritor, v)
        escritor.Close()


        Console.ReadLine()
    End Sub

End Module
