<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CRubros
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
        Me.GB_CPD = New System.Windows.Forms.GroupBox()
        Me.BtnCRAceptar = New System.Windows.Forms.Button()
        Me.Lbl_EstadoCivil = New System.Windows.Forms.Label()
        Me.Lbl_Sexo = New System.Windows.Forms.Label()
        Me.TxtCRubro = New System.Windows.Forms.TextBox()
        Me.TxtCTRubro = New System.Windows.Forms.TextBox()
        Me.GB_CPD.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_CPD
        '
        Me.GB_CPD.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GB_CPD.Controls.Add(Me.TxtCTRubro)
        Me.GB_CPD.Controls.Add(Me.TxtCRubro)
        Me.GB_CPD.Controls.Add(Me.BtnCRAceptar)
        Me.GB_CPD.Controls.Add(Me.Lbl_EstadoCivil)
        Me.GB_CPD.Controls.Add(Me.Lbl_Sexo)
        Me.GB_CPD.Location = New System.Drawing.Point(1, 1)
        Me.GB_CPD.Name = "GB_CPD"
        Me.GB_CPD.Size = New System.Drawing.Size(299, 184)
        Me.GB_CPD.TabIndex = 31
        Me.GB_CPD.TabStop = False
        Me.GB_CPD.Text = "Carga de Datos"
        '
        'BtnCRAceptar
        '
        Me.BtnCRAceptar.Location = New System.Drawing.Point(201, 146)
        Me.BtnCRAceptar.Name = "BtnCRAceptar"
        Me.BtnCRAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCRAceptar.TabIndex = 29
        Me.BtnCRAceptar.Text = "Aceptar"
        Me.BtnCRAceptar.UseVisualStyleBackColor = True
        '
        'Lbl_EstadoCivil
        '
        Me.Lbl_EstadoCivil.AutoSize = True
        Me.Lbl_EstadoCivil.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_EstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EstadoCivil.Location = New System.Drawing.Point(11, 93)
        Me.Lbl_EstadoCivil.Name = "Lbl_EstadoCivil"
        Me.Lbl_EstadoCivil.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_EstadoCivil.TabIndex = 28
        Me.Lbl_EstadoCivil.Text = "Tipo de Rubro"
        '
        'Lbl_Sexo
        '
        Me.Lbl_Sexo.AutoSize = True
        Me.Lbl_Sexo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sexo.Location = New System.Drawing.Point(11, 37)
        Me.Lbl_Sexo.Name = "Lbl_Sexo"
        Me.Lbl_Sexo.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_Sexo.TabIndex = 25
        Me.Lbl_Sexo.Text = "Nuevo Rubro"
        '
        'TxtCRubro
        '
        Me.TxtCRubro.Location = New System.Drawing.Point(63, 53)
        Me.TxtCRubro.Name = "TxtCRubro"
        Me.TxtCRubro.Size = New System.Drawing.Size(213, 20)
        Me.TxtCRubro.TabIndex = 32
        '
        'TxtCTRubro
        '
        Me.TxtCTRubro.Location = New System.Drawing.Point(63, 109)
        Me.TxtCTRubro.Name = "TxtCTRubro"
        Me.TxtCTRubro.Size = New System.Drawing.Size(213, 20)
        Me.TxtCTRubro.TabIndex = 33
        '
        'F_CRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 420)
        Me.Controls.Add(Me.GB_CPD)
        Me.Name = "F_CRubros"
        Me.Text = "Cargar_Rubros"
        Me.GB_CPD.ResumeLayout(False)
        Me.GB_CPD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_CPD As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCRAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtCTRubro As System.Windows.Forms.TextBox
    Friend WithEvents TxtCRubro As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_EstadoCivil As System.Windows.Forms.Label
    Friend WithEvents Lbl_Sexo As System.Windows.Forms.Label
End Class
