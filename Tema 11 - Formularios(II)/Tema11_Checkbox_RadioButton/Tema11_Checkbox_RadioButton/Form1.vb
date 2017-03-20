Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'COmprobar si está seleccionado
        If CheckBox1.Checked Then
            ListBox1.Items.Add(CheckBox1.Text)
        Else
            ListBox1.Items.Remove(CheckBox1.Text)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        'COmprobar si está seleccionado
        If CheckBox2.Checked Then
            ListBox1.Items.Add(CheckBox2.Text)
        Else
            ListBox1.Items.Remove(CheckBox2.Text)
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'COmprobar si está seleccionado
        If CheckBox3.Checked Then
            ListBox1.Items.Add(CheckBox3.Text)
        Else
            ListBox1.Items.Remove(CheckBox3.Text)
        End If
    End Sub
End Class
