Public Class BuscarSocios
    Private Sub BuscarSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtVerDNI.Text = Form1.socios(0).Split("*"c)(0)
        txtVerNombre.Text = Form1.socios(0).Split("*"c)(1)
        txtVerSaldo.Text = Form1.socios(0).Split("*"c)(2)


    End Sub
End Class