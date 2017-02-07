Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "En este ejemplo cuando se clica en el botón se " & vbNewLine & "debe mostrar un mensaje con el texto del botón que ha sido pulsado." + vbNewLine +
        " Entonces los 4 botones hacen lo mismo, en lugar de programar 4 funciones" & vbNewLine & "vamos a programar una que pregunte " + vbNewLine + "qué botón fué pulsado y muestre entonces su texto"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        'Obtener botón que generó el evento
        Dim boton As Button = CType(sender, Button)

        MessageBox.Show("Fue pulsado el " & boton.Text)


    End Sub
End Class
