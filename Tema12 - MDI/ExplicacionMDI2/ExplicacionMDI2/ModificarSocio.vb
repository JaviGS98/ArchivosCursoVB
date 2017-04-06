Public Class ModificarSocio
    Dim pos As Integer = -1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dni As String = txtIntroDNI.Text
        Dim encontrado As Boolean = False

        For i As Integer = 0 To Form1.socios.Length - 1
            If Form1.socios(i).Split("*"c)(0) = dni Then
                pos = i
                txtNombre.Text = Form1.socios(i).Split("*"c)(1)
                txtSaldo.Text = Form1.socios(i).Split("*"c)(2)
                Exit For
            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Creo registro con datos modificados
        Dim socioModificado As String = txtIntroDNI.Text + "*" + txtNombre.Text + "*" + txtSaldo.Text
        Form1.socios(pos) = socioModificado

        'Actualizar el fichero
        Dim escritor As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Form1.ruta, False)

        For Each registro In Form1.socios
            If Not registro Is Nothing Then
                escritor.WriteLine(registro)
            Else
                Exit For
            End If
        Next
        escritor.Close()

    End Sub
End Class