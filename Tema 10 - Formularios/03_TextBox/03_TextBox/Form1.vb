Option Strict On
Imports System.IO
Public Class Form1
    'Variables para recoger datos form
    Dim nombre As String
    Dim correo As String
    Dim dni As String
    Dim edad As Byte
    'Variable string para guardar todos los datos en una matriz
    ' y posteriormente en el fichero
    Dim registro As String
    Dim registros(99) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Recoger datos de cajas de texto
        nombre = txtNombre.Text
        dni = txtDNI.Text
        edad = Convert.ToByte(txtEdad.Text)
        correo = txtEmail.Text

        'Pasar todo a String
        registro = nombre + "*" + dni + "*" + correo + "*" + edad.ToString()
        'Guardar en la primera posicion vacía de la matriz registros

        For i As Integer = 0 To registros.Length - 1 Step 1
            If registros(i) Is Nothing Then
                registros(i) = registro
                Exit For
            End If
        Next

        'txtResumen.Text += registro
        'Código para guardar en fichero
        'queda para vosotros
        Dim escritor As StreamWriter
        Try
            escritor = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\usuario\Desktop\datos.txt", True)
            escritor.WriteLine(registro)
            escritor.Close()
            MessageBox.Show("Registro guardado con éxito")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Limpiar cajas de texto después de guardar registro
        txtNombre.Text = ""
        txtEmail.Text = ""
        txtEdad.Text = ""
        txtDNI.Text = ""

        'Poner el foco en la primera caja de texto
        txtNombre.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Acceso a fichero datos.txt para lectura
        Dim lector As StreamReader
        Try
            lector = My.Computer.FileSystem.OpenTextFileReader("C:\Users\usuario\Desktop\datos.txt")
            Dim indice As Integer = 0
            While Not lector.EndOfStream
                If registros(indice) Is Nothing Then
                    registros(indice) = lector.ReadLine()
                    indice += 1
                End If
            End While
            lector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLeerMatriz.Click
        txtDatosMatriz.Text = ""
        For Each reg As String In registros
            If Not reg Is Nothing Then
                txtDatosMatriz.Text += reg + vbNewLine
            Else
                Exit For
            End If
        Next
    End Sub

    Private Sub btnBuscarDNI_Click(sender As Object, e As EventArgs) Handles btnBuscarDNI.Click
        Dim dni As String = txtBuscarDNI.Text
        Dim encontrado As Boolean = False
        'Buscar el dni en la matriz registros
        For Each reg As String In registros
            If Not reg Is Nothing Then
                Dim cachitos() As String = reg.Split("*"c)
                If cachitos(1) = dni Then
                    MessageBox.Show("Encontrado pertenece a " + cachitos(0))
                    encontrado = True
                    Exit For

                End If

            Else
                Exit For
            End If

        Next

        If Not encontrado Then
            MessageBox.Show("No encontrado")
        End If
    End Sub
End Class
