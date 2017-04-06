Public Class AñadirSocio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Dim rutaSeleccionada As String = OpenFileDialog1.FileName()
        PictureBox1.Image = Image.FromFile(rutaSeleccionada)
    End Sub
End Class