Public Class BuscarSocios
    Private Sub BuscarSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtVerDNI.Text = Form1.regSocios(0).Split("*"c)(0)
        txtVerNombre.Text = Form1.regSocios(0).Split("*"c)(1)
        txtVerFecha.Text = Form1.regSocios(0).Split("*"c)(2)
        txtVerSaldo.Text = Form1.regSocios(0).Split("*"c)(3)

        'Volcar registros al listview
        For i As Integer = 0 To Form1.regSocios.Length - 1 Step 1
            If Not Form1.regSocios(i) Is Nothing Then
                '1) Crear listViewItem
                Dim listViewItem As ListViewItem = New ListViewItem(Form1.regSocios(i).Split("*"c))
                '2) Añadirlo al listview
                ListView1.Items.Add(listViewItem)
            Else
                Exit For
            End If

        Next

    End Sub
End Class