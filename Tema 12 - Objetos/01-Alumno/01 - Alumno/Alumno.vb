Option Strict On
Public Class Alumno
    Private dni As String
    Public nombre As String
    Public apellidos As String
    Public edad As Integer
    Public notas() As Single
    Public media As Single

    'Agregar constructores a la clase
    Public Sub New()
        notas = New Single(3) {}
    End Sub

    Public Sub New(dni As String, nombre As String, apellidos As String, edad As Integer)
        Me.dni = dni
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.edad = edad
        notas = New Single(3) {}
    End Sub

    Public Sub New(dni As String, nombre As String, apellidos As String, edad As Integer, numeroNotas As Integer)
        Me.dni = dni
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.edad = edad
        notas = New Single(numeroNotas - 1) {}
    End Sub

    'Función toString
    Public Overrides Function ToString() As String
        Dim notasLocal As String = ""
        For i As Integer = 0 To notas.Length - 1 Step 1
            notasLocal += notas(i).ToString() + " "
        Next
        Return "DNI: " + Me.dni + vbNewLine + "Nombre : " + Me.nombre + vbNewLine + "Apellidos: " + Me.apellidos + vbNewLine + "Edad: " + Me.edad.ToString() + vbNewLine + "Notas: " + notasLocal + vbNewLine + "Media: " + Me.media.ToString()
    End Function

    'Función calcular media

    Public Sub calcularMedia()
        Dim suma As Single = 0

        For i As Integer = 0 To notas.Length - 1 Step 1
            suma += notas(i)
        Next

        Me.media = suma / notas.Length
    End Sub

    Public Sub ponerNotas(nota1 As Single, nota2 As Single, nota3 As Single, nota4 As Single)
        notas(0) = nota1
        notas(1) = nota2
        notas(2) = nota3
        notas(3) = nota4
    End Sub

    'Funciones de acceso: Controlan la info que se guarda en los objetos
    Public Sub setDNI(dnie As String)
        'Validar dni
        If dnie.Length = 9 Then
            Me.dni = dnie
        End If
    End Sub

    Public Function getDNI() As String
        Return Me.dni
    End Function
End Class
