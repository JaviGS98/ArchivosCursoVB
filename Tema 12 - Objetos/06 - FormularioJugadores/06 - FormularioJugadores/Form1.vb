Option Strict On
Imports System.IO

Public Class Form1
    Public Shared jugadores(99) As Jugador
    Public Shared ruta As String = Directory.GetCurrentDirectory() + "/jugadores.txt"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Volcar registros del fichero
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)

        While Not lector.EndOfStream
            Dim tokens() As String = lector.ReadLine().Split("*"c)
            Dim j As Jugador = New Jugador()

            j.setCodigo(tokens(0))
            j.nombre = tokens(1)
            j.setCorreo(tokens(2))
            j.puntos = Convert.ToInt32(tokens(3))
            j.setSaldo(Convert.ToSingle(tokens(4)))
            Jugador.guardarJugador(jugadores, j)


        End While
        lector.Close()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim formCrearJugador As CrearJugador = New CrearJugador()
        formCrearJugador.MdiParent = Me
        formCrearJugador.Show()
        formCrearJugador.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub VerJugadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerJugadoresToolStripMenuItem.Click
        Dim v As VisualizerPlayers = New VisualizerPlayers()
        v.MdiParent = Me
        v.Show()
        v.WindowState = FormWindowState.Maximized
    End Sub
End Class
