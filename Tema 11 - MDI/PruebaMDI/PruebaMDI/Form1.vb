Option Strict On
Public Class Form1

    Public Shared regSocios(99) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As LoginForm1 = New LoginForm1()
        'Abrir form en modal
        login.ShowDialog()

        'ESCRIBIR CÓDIGO DE RECUPERACIÓN DATOS FICHERO
        regSocios(0) = "12345678Q*Maria Casal*19/Febrero/1990*990.45"
        regSocios(1) = "90909090R*Marcos Sánchez*08/Marzo/2001*1240.5"
        regSocios(2) = "90909090R*Marcos Sánchez*08/Marzo/2001*1240.5"
        regSocios(3) = "90909090R*Marcos Sánchez*08/Marzo/2001*1240.5"
        regSocios(4) = "90909090R*Marcos Sánchez*08/Marzo/2001*1240.5"

        regSocios(5) = "90909090R*Marcos Sánchez*08/Marzo/2001*1240.5"
        regSocios(6) = "90909090R*Marcos Sánchez*08/Marzo/2001*1240.5"


    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim buscarSocios As BuscarSocios = New BuscarSocios()
        'Indicar que el padre es Form1
        buscarSocios.MdiParent = Me
        buscarSocios.Show()
        buscarSocios.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        Dim añadirSocio As AñadirSocio = New AñadirSocio()
        añadirSocio.MdiParent = Me
        añadirSocio.Show()
    End Sub


End Class
