﻿Public Class Vuelo
    Public codigo As String
    Public codigoAvion As String
    Public fecha As Date
    Public plazasLibres As Short

    Public Sub New(codigo As String, codigoAvion As String, fecha As Date, plazas As Short)
        Me.codigo = codigo
        Me.codigoAvion = codigoAvion
        Me.fecha = fecha
        Me.plazasLibres = plazas
    End Sub

    Public Overrides Function ToString() As String
        Return Me.codigo + " - " + Me.codigoAvion + " - " + fecha.ToShortDateString + " - " + plazasLibres.ToString()
    End Function
End Class
