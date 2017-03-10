<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGuardarRegistro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnIrAlPrimero = New System.Windows.Forms.Button()
        Me.btnRetroceder = New System.Windows.Forms.Button()
        Me.btnAvanzar = New System.Windows.Forms.Button()
        Me.btnIrUltimo = New System.Windows.Forms.Button()
        Me.txtVisorNombre = New System.Windows.Forms.TextBox()
        Me.txtVisorEdad = New System.Windows.Forms.TextBox()
        Me.txtVisorCorreo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEdadBuscar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardarRegistro
        '
        Me.btnGuardarRegistro.Location = New System.Drawing.Point(98, 200)
        Me.btnGuardarRegistro.Name = "btnGuardarRegistro"
        Me.btnGuardarRegistro.Size = New System.Drawing.Size(114, 46)
        Me.btnGuardarRegistro.TabIndex = 4
        Me.btnGuardarRegistro.Text = "Guardar Registro"
        Me.btnGuardarRegistro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Correo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(112, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(112, 89)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 20)
        Me.txtEdad.TabIndex = 2
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(112, 137)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreo.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnGuardarRegistro)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 264)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Usuario"
        '
        'btnIrAlPrimero
        '
        Me.btnIrAlPrimero.Location = New System.Drawing.Point(28, 211)
        Me.btnIrAlPrimero.Name = "btnIrAlPrimero"
        Me.btnIrAlPrimero.Size = New System.Drawing.Size(75, 23)
        Me.btnIrAlPrimero.TabIndex = 6
        Me.btnIrAlPrimero.Text = "<<"
        Me.btnIrAlPrimero.UseVisualStyleBackColor = True
        '
        'btnRetroceder
        '
        Me.btnRetroceder.Location = New System.Drawing.Point(119, 211)
        Me.btnRetroceder.Name = "btnRetroceder"
        Me.btnRetroceder.Size = New System.Drawing.Size(75, 23)
        Me.btnRetroceder.TabIndex = 7
        Me.btnRetroceder.Text = "<"
        Me.btnRetroceder.UseVisualStyleBackColor = True
        '
        'btnAvanzar
        '
        Me.btnAvanzar.Location = New System.Drawing.Point(200, 211)
        Me.btnAvanzar.Name = "btnAvanzar"
        Me.btnAvanzar.Size = New System.Drawing.Size(75, 23)
        Me.btnAvanzar.TabIndex = 8
        Me.btnAvanzar.Text = ">"
        Me.btnAvanzar.UseVisualStyleBackColor = True
        '
        'btnIrUltimo
        '
        Me.btnIrUltimo.Location = New System.Drawing.Point(281, 211)
        Me.btnIrUltimo.Name = "btnIrUltimo"
        Me.btnIrUltimo.Size = New System.Drawing.Size(75, 23)
        Me.btnIrUltimo.TabIndex = 9
        Me.btnIrUltimo.Text = ">>"
        Me.btnIrUltimo.UseVisualStyleBackColor = True
        '
        'txtVisorNombre
        '
        Me.txtVisorNombre.Location = New System.Drawing.Point(188, 24)
        Me.txtVisorNombre.Name = "txtVisorNombre"
        Me.txtVisorNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtVisorNombre.TabIndex = 1
        '
        'txtVisorEdad
        '
        Me.txtVisorEdad.Location = New System.Drawing.Point(188, 80)
        Me.txtVisorEdad.Name = "txtVisorEdad"
        Me.txtVisorEdad.Size = New System.Drawing.Size(44, 20)
        Me.txtVisorEdad.TabIndex = 2
        '
        'txtVisorCorreo
        '
        Me.txtVisorCorreo.Location = New System.Drawing.Point(188, 131)
        Me.txtVisorCorreo.Name = "txtVisorCorreo"
        Me.txtVisorCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtVisorCorreo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Edad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Correo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVisorCorreo)
        Me.GroupBox2.Controls.Add(Me.btnIrUltimo)
        Me.GroupBox2.Controls.Add(Me.txtVisorEdad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnAvanzar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtVisorNombre)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnRetroceder)
        Me.GroupBox2.Controls.Add(Me.btnIrAlPrimero)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 254)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Visor REgistros"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(331, 316)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(248, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Intro Correo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(455, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nombre"
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.Location = New System.Drawing.Point(527, 297)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreBuscar.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(455, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Edad"
        '
        'txtEdadBuscar
        '
        Me.txtEdadBuscar.Location = New System.Drawing.Point(527, 336)
        Me.txtEdadBuscar.Name = "txtEdadBuscar"
        Me.txtEdadBuscar.Size = New System.Drawing.Size(44, 20)
        Me.txtEdadBuscar.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(621, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(621, 374)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "Eliminar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 450)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEdadBuscar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNombreBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardarRegistro As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnIrAlPrimero As Button
    Friend WithEvents btnRetroceder As Button
    Friend WithEvents btnAvanzar As Button
    Friend WithEvents btnIrUltimo As Button
    Friend WithEvents txtVisorNombre As TextBox
    Friend WithEvents txtVisorEdad As TextBox
    Friend WithEvents txtVisorCorreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNombreBuscar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEdadBuscar As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
End Class
