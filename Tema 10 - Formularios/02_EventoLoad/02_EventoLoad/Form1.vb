Public Class Form1
    'Zona de declaración de variables globales al formulario
    Dim prueba As String
    Dim edad As Integer
    'Función manejadora evento load: Aquí introducimos código
    'para que se ejecute al arrancar la aplicación
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Podríamos inicializar aquí las variables:
        prueba = "Mensaje de bienvenida"
        edad = 24
        MessageBox.Show(prueba)

    End Sub

    Private Sub btnPulsar_Click(sender As Object, e As EventArgs) Handles btnPulsar.Click
        MessageBox.Show("Botón pulsado")
    End Sub


    Private Sub moverRatonSobrebtnPulsar(sender As Object, e As EventArgs) Handles btnPulsar.MouseMove
        btnPulsar.BackColor = Color.Beige
    End Sub
    Private Sub btnPulsar_MouseLeave(sender As Object, e As EventArgs) Handles btnPulsar.MouseLeave
        btnPulsar.BackColor = Color.Gainsboro
    End Sub
End Class
