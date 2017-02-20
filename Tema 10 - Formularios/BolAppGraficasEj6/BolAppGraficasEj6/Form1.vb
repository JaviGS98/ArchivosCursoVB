Option Strict On
Public Class Form1

    'Declaración variables
    Dim gradosCentigrados, gradosFahrenheit As Double

    Private Sub txtCentigrados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCentigrados.KeyPress, txtFahrenheit.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            'Obtengo el control que generó el evento
            Dim caja As TextBox = CType(sender, TextBox)

            If caja.Name = "txtCentigrados" Then
                gradosCentigrados = Convert.ToDouble(txtCentigrados.Text)
                gradosFahrenheit = gradosCentigrados + 10

                txtFahrenheit.Text = gradosFahrenheit.ToString()
            Else
                gradosFahrenheit = Convert.ToDouble(txtFahrenheit.Text)
                gradosCentigrados = gradosFahrenheit - 10

                txtCentigrados.Text = gradosCentigrados.ToString
            End If
        End If


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

        End If
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click

        'Comprobar si hay texto en caja 1
        If txtCentigrados.Text <> "" Then
            gradosCentigrados = Convert.ToDouble(txtCentigrados.Text)
            gradosFahrenheit = gradosCentigrados + 10

            txtFahrenheit.Text = gradosFahrenheit.ToString()
            txtCentigrados.Text = ""



        ElseIf txtFahrenheit.Text <> "" Then
            gradosFahrenheit = Convert.ToDouble(txtFahrenheit.Text)
            gradosCentigrados = gradosFahrenheit - 10

            txtCentigrados.Text = gradosCentigrados.ToString
            txtFahrenheit.Text = ""

        End If
    End Sub
End Class
