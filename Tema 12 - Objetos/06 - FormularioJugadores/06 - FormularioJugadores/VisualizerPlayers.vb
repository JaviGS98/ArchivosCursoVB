Public Class VisualizerPlayers
    Private Sub VisualizerPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Recorrer matriz players y volcr codigos al listbox
        For Each j As Jugador In Form1.jugadores
            If j Is Nothing Then
                Exit For
            Else
                ListBox1.Items.Add(j.getCodigo())
            End If

        Next


        'Cargar el ListView
        For Each j As Jugador In Form1.jugadores
            If Not j Is Nothing Then
                Dim tokens() As String = j.ToString().Split("*"c)
                Dim listViewItem As ListViewItem = New ListViewItem(tokens)
                ListView1.Items.Add(listViewItem)
                listViewItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Else
                Exit For
            End If

        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Volcar a la caja de texto datos jugador
        'Primero busco por código
        Dim pos As Integer = Jugador.getPosJugador(Form1.jugadores, ListBox1.SelectedItem.ToString())

        txtNombre.Text = Form1.jugadores(pos).nombre
        txtCorreo.Text = Form1.jugadores(pos).getCodigo()
        txtSaldo.Text = Convert.ToInt32(Form1.jugadores(pos).puntos)
        txtPuntos.Text = Convert.ToSingle(Form1.jugadores(pos).getSaldo())
    End Sub
End Class