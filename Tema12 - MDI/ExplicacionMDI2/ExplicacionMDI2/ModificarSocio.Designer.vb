<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarSocio
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
        Me.txtIntroDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIntroDNI
        '
        Me.txtIntroDNI.Location = New System.Drawing.Point(18, 52)
        Me.txtIntroDNI.Name = "txtIntroDNI"
        Me.txtIntroDNI.Size = New System.Drawing.Size(100, 20)
        Me.txtIntroDNI.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Intro DNI socio que desea modificar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar Socio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(301, 27)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(301, 74)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saldo"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(279, 117)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(129, 56)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "Realizar modificacion"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'ModificarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 261)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtIntroDNI)
        Me.Name = "ModificarSocio"
        Me.Text = "ModificarSocio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIntroDNI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnModificar As Button
End Class
