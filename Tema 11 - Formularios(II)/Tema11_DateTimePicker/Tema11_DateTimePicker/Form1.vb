Option Strict On
Public Class Form1
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'Obtener la fecha
        Dim fecha As Date = DateTimePicker1.Value
        TextBox1.Text = fecha.Day.ToString
        TextBox1.Text += " " + fecha.DayOfWeek.ToString
        TextBox2.Text = fecha.Month.ToString
        TextBox3.Text = fecha.Year.ToString
        TextBox4.Text = Convert.ToString(DateDiff(DateInterval.Day, fecha, Date.Today))
        MessageBox.Show(Date.Today.ToShortTimeString)
    End Sub
End Class
