Public Class Form1
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim ciudad As String = TextBox1.Text

        ListBox1.Items.Add(ciudad)
    End Sub

    Private Sub btnGetItemSelected_Click(sender As Object, e As EventArgs) Handles btnGetItemSelected.Click
        Dim elemento As String = ListBox1.SelectedItem.ToString
        MessageBox.Show("Ciudad seleccionada: " & elemento)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim elemento As String = ListBox1.SelectedItem.ToString
        MessageBox.Show("Ciudad seleccionada: " & elemento)
    End Sub
End Class
