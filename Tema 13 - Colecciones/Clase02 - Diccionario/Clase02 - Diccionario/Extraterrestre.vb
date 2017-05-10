Public Class Extraterrestre
    Public planeta As String
    Public edad As Integer

    Public Sub New()

    End Sub

    Public Sub New(planeta As String, edad As Integer)
        Me.planeta = planeta
        Me.edad = edad
    End Sub

    Public Overrides Function ToString() As String
        Return Me.planeta + " " + Me.edad.ToString
    End Function
End Class
