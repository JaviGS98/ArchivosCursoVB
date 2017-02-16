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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtResumen = New System.Windows.Forms.TextBox()
        Me.btnLeerMatriz = New System.Windows.Forms.Button()
        Me.txtDatosMatriz = New System.Windows.Forms.TextBox()
        Me.txtBuscarDNI = New System.Windows.Forms.TextBox()
        Me.btnBuscarDNI = New System.Windows.Forms.Button()
        Me.lblBuscarDNI = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Edad:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(120, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(120, 129)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 6
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(120, 85)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtDNI.TabIndex = 5
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(120, 179)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 20)
        Me.txtEdad.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(296, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 56)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Registrar datos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResumen
        '
        Me.txtResumen.Location = New System.Drawing.Point(296, 49)
        Me.txtResumen.Multiline = True
        Me.txtResumen.Name = "txtResumen"
        Me.txtResumen.Size = New System.Drawing.Size(198, 124)
        Me.txtResumen.TabIndex = 90
        '
        'btnLeerMatriz
        '
        Me.btnLeerMatriz.Location = New System.Drawing.Point(454, 193)
        Me.btnLeerMatriz.Name = "btnLeerMatriz"
        Me.btnLeerMatriz.Size = New System.Drawing.Size(103, 56)
        Me.btnLeerMatriz.TabIndex = 99
        Me.btnLeerMatriz.Text = "Mostrar registros guardados"
        Me.btnLeerMatriz.UseVisualStyleBackColor = True
        '
        'txtDatosMatriz
        '
        Me.txtDatosMatriz.Location = New System.Drawing.Point(573, 12)
        Me.txtDatosMatriz.Multiline = True
        Me.txtDatosMatriz.Name = "txtDatosMatriz"
        Me.txtDatosMatriz.Size = New System.Drawing.Size(371, 187)
        Me.txtDatosMatriz.TabIndex = 90
        '
        'txtBuscarDNI
        '
        Me.txtBuscarDNI.Location = New System.Drawing.Point(673, 242)
        Me.txtBuscarDNI.Name = "txtBuscarDNI"
        Me.txtBuscarDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarDNI.TabIndex = 100
        '
        'btnBuscarDNI
        '
        Me.btnBuscarDNI.Location = New System.Drawing.Point(682, 284)
        Me.btnBuscarDNI.Name = "btnBuscarDNI"
        Me.btnBuscarDNI.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarDNI.TabIndex = 101
        Me.btnBuscarDNI.Text = "Buscar DNI"
        Me.btnBuscarDNI.UseVisualStyleBackColor = True
        '
        'lblBuscarDNI
        '
        Me.lblBuscarDNI.AutoSize = True
        Me.lblBuscarDNI.Location = New System.Drawing.Point(672, 206)
        Me.lblBuscarDNI.Name = "lblBuscarDNI"
        Me.lblBuscarDNI.Size = New System.Drawing.Size(126, 13)
        Me.lblBuscarDNI.TabIndex = 102
        Me.lblBuscarDNI.Text = "Introduzca DNI a buscar:"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 326)
        Me.Controls.Add(Me.lblBuscarDNI)
        Me.Controls.Add(Me.btnBuscarDNI)
        Me.Controls.Add(Me.txtBuscarDNI)
        Me.Controls.Add(Me.btnLeerMatriz)
        Me.Controls.Add(Me.txtDatosMatriz)
        Me.Controls.Add(Me.txtResumen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtResumen As TextBox
    Friend WithEvents btnLeerMatriz As Button
    Friend WithEvents txtDatosMatriz As TextBox
    Friend WithEvents txtBuscarDNI As TextBox
    Friend WithEvents btnBuscarDNI As Button
    Friend WithEvents lblBuscarDNI As Label
End Class
