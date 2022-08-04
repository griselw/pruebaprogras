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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtRojo = New System.Windows.Forms.Button()
        Me.btnmorado = New System.Windows.Forms.Button()
        Me.btnamarillo = New System.Windows.Forms.Button()
        Me.btnazul = New System.Windows.Forms.Button()
        Me.btnverde = New System.Windows.Forms.Button()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtRojo
        '
        Me.txtRojo.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRojo.Location = New System.Drawing.Point(87, 82)
        Me.txtRojo.Name = "txtRojo"
        Me.txtRojo.Size = New System.Drawing.Size(128, 38)
        Me.txtRojo.TabIndex = 0
        Me.txtRojo.Text = "Rojo"
        Me.txtRojo.UseVisualStyleBackColor = True
        '
        'btnmorado
        '
        Me.btnmorado.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmorado.Location = New System.Drawing.Point(87, 424)
        Me.btnmorado.Name = "btnmorado"
        Me.btnmorado.Size = New System.Drawing.Size(128, 38)
        Me.btnmorado.TabIndex = 1
        Me.btnmorado.Text = "morado"
        Me.btnmorado.UseVisualStyleBackColor = True
        '
        'btnamarillo
        '
        Me.btnamarillo.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnamarillo.Location = New System.Drawing.Point(87, 339)
        Me.btnamarillo.Name = "btnamarillo"
        Me.btnamarillo.Size = New System.Drawing.Size(128, 38)
        Me.btnamarillo.TabIndex = 2
        Me.btnamarillo.Text = "amarillo"
        Me.btnamarillo.UseVisualStyleBackColor = True
        '
        'btnazul
        '
        Me.btnazul.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnazul.Location = New System.Drawing.Point(87, 260)
        Me.btnazul.Name = "btnazul"
        Me.btnazul.Size = New System.Drawing.Size(128, 38)
        Me.btnazul.TabIndex = 3
        Me.btnazul.Text = "azul"
        Me.btnazul.UseVisualStyleBackColor = True
        '
        'btnverde
        '
        Me.btnverde.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverde.Location = New System.Drawing.Point(87, 171)
        Me.btnverde.Name = "btnverde"
        Me.btnverde.Size = New System.Drawing.Size(128, 38)
        Me.btnverde.TabIndex = 4
        Me.btnverde.Text = "verde"
        Me.btnverde.UseVisualStyleBackColor = True
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(245, 82)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(512, 380)
        Me.txtColores.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ravie", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(352, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 63)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "colores"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(870, 524)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.btnverde)
        Me.Controls.Add(Me.btnazul)
        Me.Controls.Add(Me.btnamarillo)
        Me.Controls.Add(Me.btnmorado)
        Me.Controls.Add(Me.txtRojo)
        Me.Name = "Form1"
        Me.Text = "colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRojo As Button
    Friend WithEvents btnmorado As Button
    Friend WithEvents btnamarillo As Button
    Friend WithEvents btnazul As Button
    Friend WithEvents btnverde As Button
    Friend WithEvents txtColores As TextBox
    Friend WithEvents Label1 As Label
End Class
