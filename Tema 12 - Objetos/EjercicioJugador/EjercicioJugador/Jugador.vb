Option Strict On
Public Class Jugador
    Private codigo As String
    Public nombre As String
    Public puntos As Integer
    Private correo As String
    Private saldo As Single

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
        Return Me.codigo + "*" + Me.nombre + "*" + Me.correo + "*" + Me.puntos.ToString() + "*" + Me.saldo.ToString()
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



End Class
