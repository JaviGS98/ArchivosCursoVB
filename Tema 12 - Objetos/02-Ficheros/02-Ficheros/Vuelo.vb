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

End Class
