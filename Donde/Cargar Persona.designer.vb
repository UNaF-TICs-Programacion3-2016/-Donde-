﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CPersona
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
        Me.DtpFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_EstadoCivil = New System.Windows.Forms.Label()
        Me.CmbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TxtDigitoVerificador = New System.Windows.Forms.TextBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Lbl_Cuil = New System.Windows.Forms.Label()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.Lbl_Sexo = New System.Windows.Forms.Label()
        Me.Lbl_Dni = New System.Windows.Forms.Label()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.Lbl_Apellido = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.GB_CPD = New System.Windows.Forms.GroupBox()
        Me.CmbBarrio = New System.Windows.Forms.ComboBox()
        Me.CmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.CmbProvincia = New System.Windows.Forms.ComboBox()
        Me.Lbl_Barrio = New System.Windows.Forms.Label()
        Me.Lbl_Localidad = New System.Windows.Forms.Label()
        Me.Lbl_Provincia = New System.Windows.Forms.Label()
        Me.AceptarCmd = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.GB_CPBtn = New System.Windows.Forms.GroupBox()
        Me.GB_CPD.SuspendLayout()
        Me.GB_CPBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_FNacimiento
        '
        Me.Lbl_FNacimiento.AutoSize = True
        Me.Lbl_FNacimiento.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_FNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FNacimiento.Location = New System.Drawing.Point(98, 101)
        Me.Lbl_FNacimiento.Name = "Lbl_FNacimiento"
        Me.Lbl_FNacimiento.Size = New System.Drawing.Size(127, 13)
        Me.Lbl_FNacimiento.TabIndex = 25
        Me.Lbl_FNacimiento.Text = "Fecha de Nacimiento"
        '
        'DtpFNacimiento
        '
        Me.DtpFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFNacimiento.Location = New System.Drawing.Point(101, 121)
        Me.DtpFNacimiento.Name = "DtpFNacimiento"
        Me.DtpFNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.DtpFNacimiento.TabIndex = 23
        '
        'Lbl_EstadoCivil
        '
        Me.Lbl_EstadoCivil.AutoSize = True
        Me.Lbl_EstadoCivil.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_EstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EstadoCivil.Location = New System.Drawing.Point(238, 183)
        Me.Lbl_EstadoCivil.Name = "Lbl_EstadoCivil"
        Me.Lbl_EstadoCivil.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_EstadoCivil.TabIndex = 24
        Me.Lbl_EstadoCivil.Text = "Estado Civil"
        '
        'CmbEstadoCivil
        '
        Me.CmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstadoCivil.FormattingEnabled = True
        Me.CmbEstadoCivil.Location = New System.Drawing.Point(241, 199)
        Me.CmbEstadoCivil.Name = "CmbEstadoCivil"
        Me.CmbEstadoCivil.Size = New System.Drawing.Size(146, 21)
        Me.CmbEstadoCivil.TabIndex = 22
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(277, 160)
        Me.TxtNumero.MaxLength = 8
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(75, 20)
        Me.TxtNumero.TabIndex = 19
        '
        'TxtDigitoVerificador
        '
        Me.TxtDigitoVerificador.Location = New System.Drawing.Point(358, 160)
        Me.TxtDigitoVerificador.MaxLength = 1
        Me.TxtDigitoVerificador.Name = "TxtDigitoVerificador"
        Me.TxtDigitoVerificador.Size = New System.Drawing.Size(21, 20)
        Me.TxtDigitoVerificador.TabIndex = 20
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(241, 160)
        Me.TxtTipo.MaxLength = 2
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(30, 20)
        Me.TxtTipo.TabIndex = 16
        '
        'Lbl_Cuil
        '
        Me.Lbl_Cuil.AutoSize = True
        Me.Lbl_Cuil.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_Cuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cuil.Location = New System.Drawing.Point(238, 144)
        Me.Lbl_Cuil.Name = "Lbl_Cuil"
        Me.Lbl_Cuil.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Cuil.TabIndex = 21
        Me.Lbl_Cuil.Text = "CUIL"
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(99, 160)
        Me.TxtDni.MaxLength = 8
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtDni.TabIndex = 13
        '
        'Lbl_Sexo
        '
        Me.Lbl_Sexo.AutoSize = True
        Me.Lbl_Sexo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sexo.Location = New System.Drawing.Point(96, 183)
        Me.Lbl_Sexo.Name = "Lbl_Sexo"
        Me.Lbl_Sexo.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Sexo.TabIndex = 17
        Me.Lbl_Sexo.Text = "Sexo"
        '
        'Lbl_Dni
        '
        Me.Lbl_Dni.AutoSize = True
        Me.Lbl_Dni.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_Dni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Dni.Location = New System.Drawing.Point(96, 144)
        Me.Lbl_Dni.Name = "Lbl_Dni"
        Me.Lbl_Dni.Size = New System.Drawing.Size(29, 13)
        Me.Lbl_Dni.TabIndex = 18
        Me.Lbl_Dni.Text = "DNI"
        '
        'CmbSexo
        '
        Me.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Location = New System.Drawing.Point(99, 199)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(100, 21)
        Me.CmbSexo.TabIndex = 15
        '
        'Lbl_Apellido
        '
        Me.Lbl_Apellido.AutoSize = True
        Me.Lbl_Apellido.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_Apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Apellido.Location = New System.Drawing.Point(98, 23)
        Me.Lbl_Apellido.Name = "Lbl_Apellido"
        Me.Lbl_Apellido.Size = New System.Drawing.Size(64, 13)
        Me.Lbl_Apellido.TabIndex = 14
        Me.Lbl_Apellido.Text = "Apellido/s"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(101, 39)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(338, 20)
        Me.TxtApellido.TabIndex = 12
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(101, 78)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(338, 20)
        Me.TxtNombre.TabIndex = 28
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nombre.Location = New System.Drawing.Point(96, 62)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_Nombre.TabIndex = 29
        Me.Lbl_Nombre.Text = " Nombre/s"
        '
        'GB_CPD
        '
        Me.GB_CPD.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GB_CPD.Controls.Add(Me.CmbBarrio)
        Me.GB_CPD.Controls.Add(Me.CmbLocalidad)
        Me.GB_CPD.Controls.Add(Me.CmbProvincia)
        Me.GB_CPD.Controls.Add(Me.Lbl_Barrio)
        Me.GB_CPD.Controls.Add(Me.Lbl_Localidad)
        Me.GB_CPD.Controls.Add(Me.Lbl_Provincia)
        Me.GB_CPD.Controls.Add(Me.TxtNombre)
        Me.GB_CPD.Controls.Add(Me.Lbl_Nombre)
        Me.GB_CPD.Controls.Add(Me.Lbl_Cuil)
        Me.GB_CPD.Controls.Add(Me.Lbl_Apellido)
        Me.GB_CPD.Controls.Add(Me.Lbl_Sexo)
        Me.GB_CPD.Controls.Add(Me.Lbl_EstadoCivil)
        Me.GB_CPD.Controls.Add(Me.Lbl_Dni)
        Me.GB_CPD.Controls.Add(Me.DtpFNacimiento)
        Me.GB_CPD.Controls.Add(Me.Lbl_FNacimiento)
        Me.GB_CPD.Controls.Add(Me.CmbEstadoCivil)
        Me.GB_CPD.Controls.Add(Me.TxtApellido)
        Me.GB_CPD.Controls.Add(Me.TxtNumero)
        Me.GB_CPD.Controls.Add(Me.CmbSexo)
        Me.GB_CPD.Controls.Add(Me.TxtDigitoVerificador)
        Me.GB_CPD.Controls.Add(Me.TxtDni)
        Me.GB_CPD.Controls.Add(Me.TxtTipo)
        Me.GB_CPD.Location = New System.Drawing.Point(12, 12)
        Me.GB_CPD.Name = "GB_CPD"
        Me.GB_CPD.Size = New System.Drawing.Size(536, 274)
        Me.GB_CPD.TabIndex = 30
        Me.GB_CPD.TabStop = False
        Me.GB_CPD.Text = "Carga de Datos"
        '
        'CmbBarrio
        '
        Me.CmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBarrio.FormattingEnabled = True
        Me.CmbBarrio.Location = New System.Drawing.Point(295, 241)
        Me.CmbBarrio.Name = "CmbBarrio"
        Me.CmbBarrio.Size = New System.Drawing.Size(91, 21)
        Me.CmbBarrio.TabIndex = 35
        '
        'CmbLocalidad
        '
        Me.CmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLocalidad.FormattingEnabled = True
        Me.CmbLocalidad.Location = New System.Drawing.Point(198, 241)
        Me.CmbLocalidad.Name = "CmbLocalidad"
        Me.CmbLocalidad.Size = New System.Drawing.Size(73, 21)
        Me.CmbLocalidad.TabIndex = 34
        '
        'CmbProvincia
        '
        Me.CmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProvincia.FormattingEnabled = True
        Me.CmbProvincia.Location = New System.Drawing.Point(99, 241)
        Me.CmbProvincia.Name = "CmbProvincia"
        Me.CmbProvincia.Size = New System.Drawing.Size(84, 21)
        Me.CmbProvincia.TabIndex = 33
        '
        'Lbl_Barrio
        '
        Me.Lbl_Barrio.AutoSize = True
        Me.Lbl_Barrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Barrio.Location = New System.Drawing.Point(292, 223)
        Me.Lbl_Barrio.Name = "Lbl_Barrio"
        Me.Lbl_Barrio.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Barrio.TabIndex = 32
        Me.Lbl_Barrio.Text = "Barrio"
        '
        'Lbl_Localidad
        '
        Me.Lbl_Localidad.AutoSize = True
        Me.Lbl_Localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Localidad.Location = New System.Drawing.Point(197, 223)
        Me.Lbl_Localidad.Name = "Lbl_Localidad"
        Me.Lbl_Localidad.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_Localidad.TabIndex = 31
        Me.Lbl_Localidad.Text = "Localidad"
        '
        'Lbl_Provincia
        '
        Me.Lbl_Provincia.AutoSize = True
        Me.Lbl_Provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Provincia.Location = New System.Drawing.Point(98, 223)
        Me.Lbl_Provincia.Name = "Lbl_Provincia"
        Me.Lbl_Provincia.Size = New System.Drawing.Size(60, 13)
        Me.Lbl_Provincia.TabIndex = 30
        Me.Lbl_Provincia.Text = "Provincia"
        '
        'AceptarCmd
        '
        Me.AceptarCmd.Location = New System.Drawing.Point(409, 19)
        Me.AceptarCmd.Name = "AceptarCmd"
        Me.AceptarCmd.Size = New System.Drawing.Size(96, 26)
        Me.AceptarCmd.TabIndex = 26
        Me.AceptarCmd.Text = "Aceptar"
        Me.AceptarCmd.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(227, 20)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(104, 25)
        Me.Cancelar.TabIndex = 27
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'GB_CPBtn
        '
        Me.GB_CPBtn.BackColor = System.Drawing.Color.LightSlateGray
        Me.GB_CPBtn.Controls.Add(Me.AceptarCmd)
        Me.GB_CPBtn.Controls.Add(Me.Cancelar)
        Me.GB_CPBtn.Location = New System.Drawing.Point(12, 292)
        Me.GB_CPBtn.Name = "GB_CPBtn"
        Me.GB_CPBtn.Size = New System.Drawing.Size(536, 61)
        Me.GB_CPBtn.TabIndex = 31
        Me.GB_CPBtn.TabStop = False
        '
        'F_CPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 365)
        Me.Controls.Add(Me.GB_CPBtn)
        Me.Controls.Add(Me.GB_CPD)
        Me.Name = "F_CPersona"
        Me.Text = "Cargar Persona"
        Me.GB_CPD.ResumeLayout(False)
        Me.GB_CPD.PerformLayout()
        Me.GB_CPBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_FNacimiento As Label
    Friend WithEvents DtpFNacimiento As DateTimePicker
    Friend WithEvents Lbl_EstadoCivil As Label
    Friend WithEvents CmbEstadoCivil As ComboBox
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents TxtDigitoVerificador As TextBox
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents Lbl_Cuil As Label
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents Lbl_Sexo As Label
    Friend WithEvents Lbl_Dni As Label
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents Lbl_Apellido As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents GB_CPD As System.Windows.Forms.GroupBox
    Friend WithEvents AceptarCmd As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents GB_CPBtn As System.Windows.Forms.GroupBox
    Friend WithEvents CmbBarrio As ComboBox
    Friend WithEvents CmbLocalidad As ComboBox
    Friend WithEvents CmbProvincia As ComboBox
    Friend WithEvents Lbl_Barrio As Label
    Friend WithEvents Lbl_Localidad As Label
    Friend WithEvents Lbl_Provincia As Label
End Class
