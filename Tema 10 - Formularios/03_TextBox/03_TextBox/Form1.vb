Public Class Form1
    'Variables para recoger datos form
    Dim nombre As String
    Dim correo As String
    Dim dni As String
    Dim edad As Byte
    'Variable string para guardar todos los datos en una matriz
    ' y posteriormente en el fichero
    Dim registro As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Recoger datos de cajas de texto
        nombre = txtNombre.Text
        dni = txtDNI.Text
        edad = Convert.ToByte(txtEdad.Text)
        correo = txtEmail.Text

        'Pasar todo a String
        registro = nombre + "*" + dni + "*" + correo + "*" + edad.ToString()
        txtResumen.Text += registro
        'Código para guardar en fichero
        'queda para vosotros

        MessageBox.Show("Registro creado con éxito")
        'Limpiar cajas de texto después de guardar registro
        txtNombre.Text = ""
        txtEmail.Text = ""
        txtEdad.Text = ""
        txtDNI.Text = ""

        'Poner el foco en la primera caja de texto
        txtNombre.Focus()
    End Sub
End Class
