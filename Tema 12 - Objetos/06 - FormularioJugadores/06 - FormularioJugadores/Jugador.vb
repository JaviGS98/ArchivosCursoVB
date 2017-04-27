Public Class Jugador
    Private codigo As String
    Public nombre As String
    Public puntos As Integer
    Private correo As String
    Private saldo As Single
    Private Shared competicion As String

    Public Sub New()
        saldo = 100
    End Sub

    Public Sub New(codigo As String, nombre As String, correo As String, saldo As Single)
        'If codigo.Length >= 4 Then
        '    Me.codigo = codigo
        'End If

        setCodigo(codigo)
        Me.nombre = nombre
        'If correo.Contains("@") Then
        '    Me.correo = correo
        'End If
        setCorreo(correo)
        Me.saldo = saldo
    End Sub

    Public Overrides Function ToString() As String
        Return Me.codigo + "*" + Me.nombre + "*" + Me.correo + "*" + Me.puntos.ToString() + "*" + Me.saldo.ToString() + "*" + competicion
    End Function

    'Funciones de acceso
    'Función set: Escribir el código

    Public Sub setCodigo(cod As String)

        If cod.Length >= 4 Then
            Me.codigo = cod
        Else

            '   Throw New Exception("Codigo no guardado")
        End If
    End Sub

    'Función set para el correo
    Public Sub setCorreo(corr As String)
        If corr.Contains("@") Then
            Me.correo = corr
        Else
            '  Throw New Exception("Correo no guardado")
        End If
    End Sub

    'Funciones de lectura
    'Get para leer codigo

    Public Function getCodigo() As String
        Return Me.codigo
    End Function

    Public Function getCorreo() As String
        Return Me.correo
    End Function

    'Funciones acceso saldo
    'Escribir saldo: No puede ser negativo
    Public Sub setSaldo(num As Single)
        If num >= 0 Then
            Me.saldo = num
        End If
    End Sub

    'Lectura de saldo
    Public Function getSaldo() As Single
        Return Me.saldo
    End Function

    'Funciones de acceso a atributo Shared
    Public Shared Sub setCompeticion(competicion As String)
        Jugador.competicion = competicion
    End Sub

    Public Shared Function getCompeticion() As String
        Return Jugador.competicion
    End Function

    'Comparar puntos de dos jugadores

    Public Shared Function getJugadorConMasPuntos(j1 As Jugador, j2 As Jugador) As Jugador
        If j1.puntos > j2.puntos Then
            Return j1
        Else
            Return j2
        End If
    End Function

    Public Shared Sub printInfo()
        Console.WriteLine("Clase creada por RamonRS")
    End Sub

    Public Shared Sub guardarJugador(matriz() As Jugador, j As Jugador)
        For i As Integer = 0 To matriz.Length - 1 Step 1
            If matriz(i) Is Nothing Then
                matriz(i) = j
                Exit For
            End If
        Next
    End Sub

    Public Shared Function getPosJugador(matriz() As Jugador, codigo As String) As Integer
        Dim posicion As Integer = -1

        For i As Integer = 0 To matriz.Length - 1 Step 1
            If (matriz(i).getCodigo() = codigo) Then
                posicion = i
                Exit For
            End If
        Next
        Return posicion
    End Function


End Class
