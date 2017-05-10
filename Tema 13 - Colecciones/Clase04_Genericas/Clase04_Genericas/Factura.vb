Public Class Factura
    Public referencia As String
    Public importe As Double

    Public Sub New(ref As String, importe As Double)
        referencia = ref
        Me.importe = importe
    End Sub
End Class
