Option Strict On
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim alumno As String = TextBox1.Text
        'Añadir un string al listbox
        ListBox1.Items.Add(TextBox1.Text)
        ComboBox1.Items.Add(alumno)

        'Limpiar el listbox
        ComboBox1.Items.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Obtener elemento seleccionado
        Dim alumno As String = ListBox1.SelectedItem.ToString()
        MessageBox.Show(alumno)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim alumno As String = ListBox1.SelectedItem.ToString()
        ' MessageBox.Show(alumno)
        'Volcar el nombre a una caja de texto 
        ' y el apellido a otra

        Dim trozos() As String = alumno.Split(" "c)
        TextBox2.Text = trozos(0)
        TextBox3.Text = trozos(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nombre As String = TextBox4.Text

        ListBox1.Items.Remove(nombre)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each elemento As String In ListBox1.Items
            MessageBox.Show(elemento)
        Next
    End Sub
End Class
