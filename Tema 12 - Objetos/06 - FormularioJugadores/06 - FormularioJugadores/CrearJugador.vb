Imports System.IO

Public Class CrearJugador
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j As Jugador = New Jugador()
        j.setCodigo(txtCodigo.Text)
        j.nombre = txtNombre.Text
        j.setCorreo(txtCorreo.Text)
        j.setSaldo(Convert.ToSingle(txtSaldo.Text))

        'Guardarlo en la matriz
        Jugador.guardarJugador(Form1.jugadores, j)

        'Guardarlo en el Fichero

        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Form1.ruta, True)
        escritor.WriteLine(j)
        escritor.Close()
    End Sub

    Private Sub CrearJugador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class