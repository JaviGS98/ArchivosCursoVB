Option Strict On
Imports System.IO
Public Class Form1
    Dim nombre As String
    Dim edad As Integer
    Dim correo As String
    Dim ruta As String = Directory.GetCurrentDirectory() + "\datos.txt"
    Dim registros(99) As String
    Dim contadorPos As Integer = 0
    Private Sub btnGuardarRegistro_Click(sender As Object, e As EventArgs) Handles btnGuardarRegistro.Click
        nombre = txtNombre.Text
        edad = Convert.ToInt32(txtEdad.Text)
        correo = txtCorreo.Text

        'Escribir en el fichero
        Dim escritor As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(ruta, True)
        Dim registro As String = nombre + "*" + edad.ToString() + "*" + correo

        escritor.WriteLine(registro)
        escritor.Close()

        'Limpiar cajas de texto
        txtNombre.Text = ""
        txtEdad.Text = ""
        txtCorreo.Text = ""

        'Poner el foco en caja de texto
        txtNombre.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Leer el ficher y volcar registros a matriz local
        Dim lector As StreamReader = My.Computer.FileSystem.OpenTextFileReader(ruta)
        Dim pos As Integer = 0

        While Not lector.EndOfStream
            If registros(pos) = Nothing Then
                registros(pos) = lector.ReadLine()
                pos += 1
            End If
        End While
        lector.Close()

        'Volcar al visor de registros el primer registro
        Dim trozos() As String = registros(0).Split("*"c)
        txtVisorNombre.Text = trozos(0)
        txtVisorEdad.Text = trozos(1)
        txtVisorCorreo.Text = trozos(2)
    End Sub

    Private Sub btnAvanzar_Click(sender As Object, e As EventArgs) Handles btnAvanzar.Click
        contadorPos += 1
        Try
            Dim trozos() As String = registros(contadorPos).Split("*"c)
            txtVisorNombre.Text = trozos(0)
            txtVisorEdad.Text = trozos(1)
            txtVisorCorreo.Text = trozos(2)
        Catch ex As Exception
            MessageBox.Show("No hay mas registros")
        End Try

    End Sub

    Private Sub btnIrUltimo_Click(sender As Object, e As EventArgs) Handles btnIrUltimo.Click
        contadorPos = contarRegistros() - 1
        Dim trozos() As String = registros(contadorPos).Split("*"c)
        txtVisorNombre.Text = trozos(0)
        txtVisorEdad.Text = trozos(1)
        txtVisorCorreo.Text = trozos(2)
    End Sub

    Private Function contarRegistros() As Integer
        Dim contador As Integer = 0

        For i As Integer = 0 To registros.Length - 1 Step 1
            If Not registros(i) Is Nothing Then
                contador += 1
            Else
                Exit For
            End If
        Next

        Return contador
    End Function

    Private Sub btnIrAlPrimero_Click(sender As Object, e As EventArgs) Handles btnIrAlPrimero.Click
        'Volcar al visor de registros el primer registro
        contadorPos = 0
        Dim trozos() As String = registros(contadorPos).Split("*"c)
        txtVisorNombre.Text = trozos(0)
        txtVisorEdad.Text = trozos(1)
        txtVisorCorreo.Text = trozos(2)
    End Sub

    Private Sub btnRetroceder_Click(sender As Object, e As EventArgs) Handles btnRetroceder.Click
        If contadorPos > 0 Then
            contadorPos -= 1

            Dim trozos() As String = registros(contadorPos).Split("*"c)
            txtVisorNombre.Text = trozos(0)
            txtVisorEdad.Text = trozos(1)
            txtVisorCorreo.Text = trozos(2)
        Else
            Dim trozos() As String = registros(0).Split("*"c)
            txtVisorNombre.Text = trozos(0)
            txtVisorEdad.Text = trozos(1)
            txtVisorCorreo.Text = trozos(2)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Dim correo As String = TextBox1.Text

        'If correo = "" Then
        '    txtEdadBuscar.Text = ""
        '    txtNombreBuscar.Text = ""
        'Else
        '    'Buscar correo en matriz

        '    For Each reg As String In registros
        '        If Not reg Is Nothing Then
        '            If reg.Contains(correo) Then
        '                Dim trozos() As String = reg.Split("*"c)
        '                txtNombreBuscar.Text = trozos(0)
        '                txtEdadBuscar.Text = trozos(1)
        '            End If
        '        Else
        '            Exit For
        '        End If
        '    Next
        'End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim correo As String = TextBox1.Text
        Dim ultimoReg As Integer = contarRegistros() - 1
        For i As Integer = 0 To ultimoReg Step 1
            Dim trozos() As String = registros(i).Split("*"c)
            If trozos(2) = correo Then
                txtNombreBuscar.Text = trozos(0)
                txtEdadBuscar.Text = trozos(1)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim respuesta As DialogResult = MessageBox.Show("Esta seguro ??", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If respuesta = DialogResult.Yes Then
            'Codigo de caragarse al jicho
            MessageBox.Show("USuario eliminado")
        End If
    End Sub
End Class
