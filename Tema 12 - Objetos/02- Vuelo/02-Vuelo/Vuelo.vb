Public Class Vuelo
    Private codigo As String
    Public codigoAvion As String
    Public fecha As Date
    Public plazasLibres As Short

    'Constructor por defecto
    Public Sub New()

    End Sub

    'Constructor que recibe todos los argumentos
    Public Sub New(codigo As String, codigoAvion As String, fecha As Date, plazas As Short)
        'Validar que el código tiene un dígito: llamamos a la 
        'función setCodigo programada más abajo
        setCodigo(codigo)
        Me.codigoAvion = codigoAvion
        Me.fecha = fecha
        Me.plazasLibres = plazas
    End Sub
    'Sobreescribir el toString
    Public Overrides Function ToString() As String
        Return Me.codigo + "*" + Me.codigoAvion + "*" + Me.fecha.ToShortDateString + "*" + Me.plazasLibres.ToString()
    End Function
    'Añadir funciones de acceso para el código
    'Controlar que el código del vuelo tenga al menos un dígito
    'set: codigo
    Public Sub setCodigo(c As String)
        Dim contador As Integer
        For i As Integer = 0 To c.Length - 1 Step 1
            If Char.IsDigit(c(i)) Then
                contador += 1
                Exit For

            End If
        Next

        If contador > 0 Then
            Me.codigo = c
        End If
    End Sub

    Public Function getCodigo() As String
        Return Me.codigo
    End Function

    '******************************************************************************************//
                                            '25 ABRIL 2017
    '*******************            FUNCIONES CON MATRICES          ***************************//

    Public Shared Sub guardarVuelo(vuelos() As Vuelo, vuelo As Vuelo)

        'Buscar si el código del vuelo ya está en la matriz
        If getPosVueloByCodigo(vuelos, vuelo.getCodigo()) < 0 Then
            For i As Integer = 0 To vuelos.Length - 1 Step 1
                If vuelos(i) Is Nothing Then
                    vuelos(i) = vuelo
                    Exit For
                End If
            Next
        Else
            Console.WriteLine("Ya existe un vuelo con ese código")

        End If



    End Sub

    Public Shared Function getPosVueloByCodigo(vuelos() As Vuelo, codigo As String) As Integer
        Dim posicion As Integer = -1

        Dim numeroVuelos As Integer = contarVuelos(vuelos)
        For i As Integer = 0 To numeroVuelos - 1 Step 1
            If vuelos(i).getCodigo = codigo Then
                posicion = i
                Exit For
            End If
        Next
        Return posicion
    End Function

    Public Shared Function contarVuelos(vuelos() As Vuelo)
        Dim contador As Integer = 0
        For Each v As Vuelo In vuelos
            If Not v Is Nothing Then
                contador += 1
            Else
                Exit For
            End If
        Next
        Return contador
    End Function
End Class
