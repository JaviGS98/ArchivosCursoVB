Option Strict On
Imports System.IO

Public Class AñadirSocio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nuevoSocio As String = txtDNI.Text + "*" + txtNombre.Text + "*" + txtSaldo.Text
        'Escribirlo en el fichero
        Dim escritor As StreamWriter = New StreamWriter(Form1.ruta, True)
        escritor.WriteLine(nuevoSocio)
        escritor.Close()

        'Actualizar la matriz
        For i As Integer = 0 To Form1.socios.Length - 1 Step 1
            If Form1.socios(i) Is Nothing Then
                Form1.socios(i) = nuevoSocio
                Exit For
            End If
        Next

        'Actualizar listbox
        volcarNombres.PerformClick()
    End Sub

    Private Sub volcarNombres_Click(sender As Object, e As EventArgs) Handles volcarNombres.Click
        ListBox1.Items.Clear()

        For Each socio As String In Form1.socios
            If Not socio Is Nothing Then
                ListBox1.Items.Add(socio.Split("*"c)(1))
            Else
                Exit For
            End If
        Next
    End Sub
End Class