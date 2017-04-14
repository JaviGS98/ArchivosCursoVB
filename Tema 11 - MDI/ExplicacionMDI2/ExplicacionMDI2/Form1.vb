Imports System.IO
Public Class Form1
    'VARIABLES ACCESIBLES PARA TODOS LOS FORMS
    Public Shared socios(99) As String
    Public Shared ruta As String = Directory.GetCurrentDirectory() + "\socios.txt"



    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        '1-Declarar variable tipo formulario
        Dim buscarSocio As BuscarSocios = New BuscarSocios()
        '2-Abrir el formulario
        'Indico que Form1 es el padre de buscarSocio
        buscarSocio.MdiParent = Me
        buscarSocio.WindowState = FormWindowState.Maximized
        buscarSocio.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ESCRIBO CÓDIGO DE ACCESO AL FICHERO
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim i As Integer

        While Not lector.EndOfStream
            socios(i) = lector.ReadLine
            i += 1
        End While
        lector.Close()

    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        'Declarar variable
        Dim addSocio As AñadirSocio = New AñadirSocio()
        addSocio.MdiParent = Me
        addSocio.Show()
    End Sub

    Private Sub MlodificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MlodificarToolStripMenuItem.Click
        Dim modificar As ModificarSocio = New ModificarSocio()
        modificar.MdiParent = Me
        modificar.Show()
    End Sub
End Class
