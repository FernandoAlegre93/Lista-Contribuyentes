<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstPagos = New System.Windows.Forms.ListBox()
        Me.lstContribuyentes = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtboxSuma = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPagos
        '
        Me.lstPagos.FormattingEnabled = True
        Me.lstPagos.Location = New System.Drawing.Point(292, 63)
        Me.lstPagos.Name = "lstPagos"
        Me.lstPagos.Size = New System.Drawing.Size(120, 95)
        Me.lstPagos.TabIndex = 6
        '
        'lstContribuyentes
        '
        Me.lstContribuyentes.FormattingEnabled = True
        Me.lstContribuyentes.Location = New System.Drawing.Point(32, 63)
        Me.lstContribuyentes.Name = "lstContribuyentes"
        Me.lstContribuyentes.Size = New System.Drawing.Size(120, 95)
        Me.lstContribuyentes.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(313, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Ingresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtboxSuma
        '
        Me.txtboxSuma.Location = New System.Drawing.Point(210, 260)
        Me.txtboxSuma.Name = "txtboxSuma"
        Me.txtboxSuma.Size = New System.Drawing.Size(100, 20)
        Me.txtboxSuma.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(105, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Suma de pagos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contribuyentes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pagos:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(32, 326)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Limpiar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(372, 326)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Cerrar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 361)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtboxSuma)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstContribuyentes)
        Me.Controls.Add(Me.lstPagos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPagos As System.Windows.Forms.ListBox
    Friend WithEvents lstContribuyentes As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtboxSuma As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
