Option Strict On
Public Class Sniper
    Public codigo As String
    Public nombre As String
    Public balas As Integer
    Public precision As Single

    Public Sub New()

    End Sub

    Public Sub New(codigo As String, nombre As String, balas As Integer, precision As Single)
        Me.codigo = codigo
        Me.nombre = nombre
        Me.balas = balas
        Me.precision = precision
    End Sub

    Public Function guardarFichero() As String
        Return Me.codigo + "*" + Me.nombre + "*" + Me.balas.ToString() + "*" + Me.precision.ToString()
    End Function

    Public Overrides Function ToString() As String
        Return " Código: " + Me.codigo + " Nombre: " + Me.nombre + " Balas: " + balas.ToString() + " Precision: " + precision.ToString()
    End Function
End Class
