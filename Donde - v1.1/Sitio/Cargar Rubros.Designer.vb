<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CargaRubros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_CargaRubros))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnAceptarR = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GBRubro = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GBSubRubro = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelaR = New System.Windows.Forms.Button()
        Me.GBRubro.SuspendLayout()
        Me.GBSubRubro.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(20, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 20)
        Me.TextBox1.TabIndex = 0
        '
        'BtnAceptarR
        '
        Me.BtnAceptarR.Location = New System.Drawing.Point(172, 287)
        Me.BtnAceptarR.Name = "BtnAceptarR"
        Me.BtnAceptarR.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptarR.TabIndex = 1
        Me.BtnAceptarR.Text = "Aceptar"
        Me.BtnAceptarR.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(18, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(18, 37)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(229, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(20, 79)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(74, 20)
        Me.TextBox4.TabIndex = 4
        '
        'GBRubro
        '
        Me.GBRubro.BackgroundImage = CType(resources.GetObject("GBRubro.BackgroundImage"), System.Drawing.Image)
        Me.GBRubro.Controls.Add(Me.Label3)
        Me.GBRubro.Controls.Add(Me.Label4)
        Me.GBRubro.Controls.Add(Me.TextBox1)
        Me.GBRubro.Controls.Add(Me.TextBox4)
        Me.GBRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBRubro.Location = New System.Drawing.Point(0, 12)
        Me.GBRubro.Name = "GBRubro"
        Me.GBRubro.Size = New System.Drawing.Size(257, 105)
        Me.GBRubro.TabIndex = 5
        Me.GBRubro.TabStop = False
        Me.GBRubro.Text = "Ingresa Nuevo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Rubro"
        '
        'GBSubRubro
        '
        Me.GBSubRubro.BackgroundImage = CType(resources.GetObject("GBSubRubro.BackgroundImage"), System.Drawing.Image)
        Me.GBSubRubro.Controls.Add(Me.Label2)
        Me.GBSubRubro.Controls.Add(Me.Label1)
        Me.GBSubRubro.Controls.Add(Me.TextBox3)
        Me.GBSubRubro.Controls.Add(Me.TextBox2)
        Me.GBSubRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSubRubro.Location = New System.Drawing.Point(0, 129)
        Me.GBSubRubro.Name = "GBSubRubro"
        Me.GBSubRubro.Size = New System.Drawing.Size(257, 105)
        Me.GBSubRubro.TabIndex = 0
        Me.GBSubRubro.TabStop = False
        Me.GBSubRubro.Text = "Ingresa Nuevo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Codigo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sub Rubro"
        '
        'BtnCancelaR
        '
        Me.BtnCancelaR.Location = New System.Drawing.Point(91, 287)
        Me.BtnCancelaR.Name = "BtnCancelaR"
        Me.BtnCancelaR.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelaR.TabIndex = 6
        Me.BtnCancelaR.Text = "Cancelar"
        Me.BtnCancelaR.UseVisualStyleBackColor = True
        '
        'F_CargaRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(259, 322)
        Me.Controls.Add(Me.BtnCancelaR)
        Me.Controls.Add(Me.BtnAceptarR)
        Me.Controls.Add(Me.GBRubro)
        Me.Controls.Add(Me.GBSubRubro)
        Me.Name = "F_CargaRubros"
        Me.Text = "Carga de Rubros "
        Me.GBRubro.ResumeLayout(False)
        Me.GBRubro.PerformLayout()
        Me.GBSubRubro.ResumeLayout(False)
        Me.GBSubRubro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnAceptarR As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GBRubro As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GBSubRubro As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelaR As System.Windows.Forms.Button
End Class
