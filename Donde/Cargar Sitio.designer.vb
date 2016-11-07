<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CSitio
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
        Me.Lbl_FNacimiento = New System.Windows.Forms.Label()
        Me.DtpFAlta = New System.Windows.Forms.DateTimePicker()
        Me.TxtNombreS = New System.Windows.Forms.TextBox()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.GB_CPD = New System.Windows.Forms.GroupBox()
        Me.BtnSAceptar = New System.Windows.Forms.Button()
        Me.BtnSCancelar = New System.Windows.Forms.Button()
        Me.GB_CPBtn = New System.Windows.Forms.GroupBox()
        Me.BtnDAgrRub = New System.Windows.Forms.Button()
        Me.GB_CPD.SuspendLayout()
        Me.GB_CPBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_FNacimiento
        '
        Me.Lbl_FNacimiento.AutoSize = True
        Me.Lbl_FNacimiento.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_FNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FNacimiento.Location = New System.Drawing.Point(76, 162)
        Me.Lbl_FNacimiento.Name = "Lbl_FNacimiento"
        Me.Lbl_FNacimiento.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_FNacimiento.TabIndex = 25
        Me.Lbl_FNacimiento.Text = "Fecha de Alta"
        '
        'DtpFAlta
        '
        Me.DtpFAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFAlta.Location = New System.Drawing.Point(168, 156)
        Me.DtpFAlta.Name = "DtpFAlta"
        Me.DtpFAlta.Size = New System.Drawing.Size(100, 20)
        Me.DtpFAlta.TabIndex = 20
        '
        'TxtNombreS
        '
        Me.TxtNombreS.Location = New System.Drawing.Point(167, 46)
        Me.TxtNombreS.Name = "TxtNombreS"
        Me.TxtNombreS.Size = New System.Drawing.Size(338, 20)
        Me.TxtNombreS.TabIndex = 13
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nombre.Location = New System.Drawing.Point(96, 49)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_Nombre.TabIndex = 29
        Me.Lbl_Nombre.Text = " Nombre/s"
        '
        'GB_CPD
        '
        Me.GB_CPD.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GB_CPD.Controls.Add(Me.TxtNombreS)
        Me.GB_CPD.Controls.Add(Me.Lbl_Nombre)
        Me.GB_CPD.Controls.Add(Me.DtpFAlta)
        Me.GB_CPD.Controls.Add(Me.Lbl_FNacimiento)
        Me.GB_CPD.Location = New System.Drawing.Point(12, 12)
        Me.GB_CPD.Name = "GB_CPD"
        Me.GB_CPD.Size = New System.Drawing.Size(536, 221)
        Me.GB_CPD.TabIndex = 30
        Me.GB_CPD.TabStop = False
        Me.GB_CPD.Text = "Carga de Datos"
        '
        'BtnSAceptar
        '
        Me.BtnSAceptar.Location = New System.Drawing.Point(409, 19)
        Me.BtnSAceptar.Name = "BtnSAceptar"
        Me.BtnSAceptar.Size = New System.Drawing.Size(96, 26)
        Me.BtnSAceptar.TabIndex = 26
        Me.BtnSAceptar.Text = "Aceptar"
        Me.BtnSAceptar.UseVisualStyleBackColor = True
        '
        'BtnSCancelar
        '
        Me.BtnSCancelar.Location = New System.Drawing.Point(210, 20)
        Me.BtnSCancelar.Name = "BtnSCancelar"
        Me.BtnSCancelar.Size = New System.Drawing.Size(104, 25)
        Me.BtnSCancelar.TabIndex = 27
        Me.BtnSCancelar.Text = "Cancelar"
        Me.BtnSCancelar.UseVisualStyleBackColor = True
        '
        'GB_CPBtn
        '
        Me.GB_CPBtn.BackColor = System.Drawing.Color.LightSlateGray
        Me.GB_CPBtn.Controls.Add(Me.BtnDAgrRub)
        Me.GB_CPBtn.Controls.Add(Me.BtnSAceptar)
        Me.GB_CPBtn.Controls.Add(Me.BtnSCancelar)
        Me.GB_CPBtn.Location = New System.Drawing.Point(12, 239)
        Me.GB_CPBtn.Name = "GB_CPBtn"
        Me.GB_CPBtn.Size = New System.Drawing.Size(536, 61)
        Me.GB_CPBtn.TabIndex = 31
        Me.GB_CPBtn.TabStop = False
        '
        'BtnDAgrRub
        '
        Me.BtnDAgrRub.Location = New System.Drawing.Point(37, 20)
        Me.BtnDAgrRub.Name = "BtnDAgrRub"
        Me.BtnDAgrRub.Size = New System.Drawing.Size(104, 25)
        Me.BtnDAgrRub.TabIndex = 28
        Me.BtnDAgrRub.Text = "Agregar Rubro"
        Me.BtnDAgrRub.UseVisualStyleBackColor = True
        '
        'F_CSitio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 338)
        Me.Controls.Add(Me.GB_CPBtn)
        Me.Controls.Add(Me.GB_CPD)
        Me.Name = "F_CSitio"
        Me.Text = "Cargar Sitio"
        Me.GB_CPD.ResumeLayout(False)
        Me.GB_CPD.PerformLayout()
        Me.GB_CPBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_FNacimiento As Label
    Friend WithEvents DtpFAlta As DateTimePicker
    Friend WithEvents TxtNombreS As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents GB_CPD As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnSCancelar As System.Windows.Forms.Button
    Friend WithEvents GB_CPBtn As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDAgrRub As System.Windows.Forms.Button
End Class
