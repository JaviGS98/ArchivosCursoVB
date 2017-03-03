Public Class Form1
    Dim numero1, numero2, resultado As Double
    Dim operacion As Char

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        numero2 = TextBox1.Text


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click, Button4.Click
        'Obtener el botón que ha sido pulsado
        Dim b As Button = CType(sender, Button)
        TextBox1.Text += b.Text
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        numero1 = Convert.ToDouble(TextBox1.Text)
        TextBox1.Text = ""
        operacion = "+"c
    End Sub
End Class
