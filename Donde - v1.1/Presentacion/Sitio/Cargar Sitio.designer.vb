<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CargaSitio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_CargaSitio))
        Me.GB_CPD = New System.Windows.Forms.GroupBox()
        Me.GBEditar = New System.Windows.Forms.GroupBox()
        Me.BtnModS = New System.Windows.Forms.Button()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Lbl_EstadoCivil = New System.Windows.Forms.Label()
        Me.TxtNombreS = New System.Windows.Forms.TextBox()
        Me.Lbl_Sexo = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.CmbSRubro = New System.Windows.Forms.ComboBox()
        Me.DtpFAlta = New System.Windows.Forms.DateTimePicker()
        Me.CmbRubro = New System.Windows.Forms.ComboBox()
        Me.Lbl_FNacimiento = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSCancelar = New System.Windows.Forms.Button()
        Me.BtnSAceptar = New System.Windows.Forms.Button()
        Me.TabPCarga = New System.Windows.Forms.TabControl()
        Me.TabPDireccion = New System.Windows.Forms.TabPage()
        Me.BtnElimD = New System.Windows.Forms.Button()
        Me.BtnModD = New System.Windows.Forms.Button()
        Me.BtnAgregarD = New System.Windows.Forms.Button()
        Me.BtnBuscD = New System.Windows.Forms.Button()
        Me.DGDireccionS = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPContacto = New System.Windows.Forms.TabPage()
        Me.BtnElimC = New System.Windows.Forms.Button()
        Me.BtnModC = New System.Windows.Forms.Button()
        Me.BtnAgregarC = New System.Windows.Forms.Button()
        Me.BtnBuscC = New System.Windows.Forms.Button()
        Me.DGContactoS = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_CPD.SuspendLayout()
        Me.GBEditar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPCarga.SuspendLayout()
        Me.TabPDireccion.SuspendLayout()
        CType(Me.DGDireccionS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPContacto.SuspendLayout()
        CType(Me.DGContactoS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_CPD
        '
        Me.GB_CPD.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GB_CPD.BackgroundImage = CType(resources.GetObject("GB_CPD.BackgroundImage"), System.Drawing.Image)
        Me.GB_CPD.Controls.Add(Me.GBEditar)
        Me.GB_CPD.Controls.Add(Me.LblID)
        Me.GB_CPD.Controls.Add(Me.TxtID)
        Me.GB_CPD.Controls.Add(Me.Lbl_EstadoCivil)
        Me.GB_CPD.Controls.Add(Me.TxtNombreS)
        Me.GB_CPD.Controls.Add(Me.Lbl_Sexo)
        Me.GB_CPD.Controls.Add(Me.Lbl_Nombre)
        Me.GB_CPD.Controls.Add(Me.CmbSRubro)
        Me.GB_CPD.Controls.Add(Me.DtpFAlta)
        Me.GB_CPD.Controls.Add(Me.CmbRubro)
        Me.GB_CPD.Controls.Add(Me.Lbl_FNacimiento)
        Me.GB_CPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CPD.Location = New System.Drawing.Point(0, 2)
        Me.GB_CPD.Name = "GB_CPD"
        Me.GB_CPD.Size = New System.Drawing.Size(593, 154)
        Me.GB_CPD.TabIndex = 30
        Me.GB_CPD.TabStop = False
        Me.GB_CPD.Text = "Carga de Datos"
        '
        'GBEditar
        '
        Me.GBEditar.BackgroundImage = CType(resources.GetObject("GBEditar.BackgroundImage"), System.Drawing.Image)
        Me.GBEditar.Controls.Add(Me.BtnModS)
        Me.GBEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEditar.Location = New System.Drawing.Point(105, 21)
        Me.GBEditar.Name = "GBEditar"
        Me.GBEditar.Size = New System.Drawing.Size(200, 54)
        Me.GBEditar.TabIndex = 38
        Me.GBEditar.TabStop = False
        Me.GBEditar.Text = "Editar Sitio"
        '
        'BtnModS
        '
        Me.BtnModS.Location = New System.Drawing.Point(15, 19)
        Me.BtnModS.Name = "BtnModS"
        Me.BtnModS.Size = New System.Drawing.Size(77, 24)
        Me.BtnModS.TabIndex = 12
        Me.BtnModS.Text = "Modificar"
        Me.BtnModS.UseVisualStyleBackColor = True
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.BackColor = System.Drawing.Color.Transparent
        Me.LblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Location = New System.Drawing.Point(9, 21)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(20, 13)
        Me.LblID.TabIndex = 37
        Me.LblID.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(12, 37)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(46, 20)
        Me.TxtID.TabIndex = 36
        '
        'Lbl_EstadoCivil
        '
        Me.Lbl_EstadoCivil.AutoSize = True
        Me.Lbl_EstadoCivil.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_EstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EstadoCivil.Location = New System.Drawing.Point(238, 104)
        Me.Lbl_EstadoCivil.Name = "Lbl_EstadoCivil"
        Me.Lbl_EstadoCivil.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_EstadoCivil.TabIndex = 35
        Me.Lbl_EstadoCivil.Text = "Sub Rubro"
        '
        'TxtNombreS
        '
        Me.TxtNombreS.Location = New System.Drawing.Point(12, 81)
        Me.TxtNombreS.Name = "TxtNombreS"
        Me.TxtNombreS.Size = New System.Drawing.Size(293, 20)
        Me.TxtNombreS.TabIndex = 13
        '
        'Lbl_Sexo
        '
        Me.Lbl_Sexo.AutoSize = True
        Me.Lbl_Sexo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sexo.Location = New System.Drawing.Point(9, 104)
        Me.Lbl_Sexo.Name = "Lbl_Sexo"
        Me.Lbl_Sexo.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_Sexo.TabIndex = 32
        Me.Lbl_Sexo.Text = "Rubro"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nombre.Location = New System.Drawing.Point(6, 65)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_Nombre.TabIndex = 29
        Me.Lbl_Nombre.Text = " Nombre/s"
        '
        'CmbSRubro
        '
        Me.CmbSRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSRubro.FormattingEnabled = True
        Me.CmbSRubro.Location = New System.Drawing.Point(241, 120)
        Me.CmbSRubro.Name = "CmbSRubro"
        Me.CmbSRubro.Size = New System.Drawing.Size(209, 21)
        Me.CmbSRubro.TabIndex = 34
        '
        'DtpFAlta
        '
        Me.DtpFAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFAlta.Location = New System.Drawing.Point(350, 81)
        Me.DtpFAlta.Name = "DtpFAlta"
        Me.DtpFAlta.Size = New System.Drawing.Size(100, 20)
        Me.DtpFAlta.TabIndex = 20
        '
        'CmbRubro
        '
        Me.CmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRubro.FormattingEnabled = True
        Me.CmbRubro.Location = New System.Drawing.Point(12, 120)
        Me.CmbRubro.Name = "CmbRubro"
        Me.CmbRubro.Size = New System.Drawing.Size(209, 21)
        Me.CmbRubro.TabIndex = 33
        '
        'Lbl_FNacimiento
        '
        Me.Lbl_FNacimiento.AutoSize = True
        Me.Lbl_FNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FNacimiento.Location = New System.Drawing.Point(347, 65)
        Me.Lbl_FNacimiento.Name = "Lbl_FNacimiento"
        Me.Lbl_FNacimiento.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_FNacimiento.TabIndex = 25
        Me.Lbl_FNacimiento.Text = "Fecha de Alta"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.BtnSCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnSAceptar)
        Me.GroupBox1.Controls.Add(Me.TabPCarga)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 259)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'BtnSCancelar
        '
        Me.BtnSCancelar.Location = New System.Drawing.Point(391, 227)
        Me.BtnSCancelar.Name = "BtnSCancelar"
        Me.BtnSCancelar.Size = New System.Drawing.Size(77, 25)
        Me.BtnSCancelar.TabIndex = 27
        Me.BtnSCancelar.Text = "Cancelar"
        Me.BtnSCancelar.UseVisualStyleBackColor = True
        '
        'BtnSAceptar
        '
        Me.BtnSAceptar.Location = New System.Drawing.Point(474, 227)
        Me.BtnSAceptar.Name = "BtnSAceptar"
        Me.BtnSAceptar.Size = New System.Drawing.Size(77, 26)
        Me.BtnSAceptar.TabIndex = 26
        Me.BtnSAceptar.Text = "Aceptar"
        Me.BtnSAceptar.UseVisualStyleBackColor = True
        '
        'TabPCarga
        '
        Me.TabPCarga.Controls.Add(Me.TabPDireccion)
        Me.TabPCarga.Controls.Add(Me.TabPContacto)
        Me.TabPCarga.Location = New System.Drawing.Point(12, 19)
        Me.TabPCarga.Name = "TabPCarga"
        Me.TabPCarga.SelectedIndex = 0
        Me.TabPCarga.Size = New System.Drawing.Size(573, 207)
        Me.TabPCarga.TabIndex = 32
        '
        'TabPDireccion
        '
        Me.TabPDireccion.BackgroundImage = CType(resources.GetObject("TabPDireccion.BackgroundImage"), System.Drawing.Image)
        Me.TabPDireccion.Controls.Add(Me.BtnElimD)
        Me.TabPDireccion.Controls.Add(Me.BtnModD)
        Me.TabPDireccion.Controls.Add(Me.BtnAgregarD)
        Me.TabPDireccion.Controls.Add(Me.BtnBuscD)
        Me.TabPDireccion.Controls.Add(Me.DGDireccionS)
        Me.TabPDireccion.Location = New System.Drawing.Point(4, 22)
        Me.TabPDireccion.Name = "TabPDireccion"
        Me.TabPDireccion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPDireccion.Size = New System.Drawing.Size(565, 181)
        Me.TabPDireccion.TabIndex = 0
        Me.TabPDireccion.Text = "Direccion"
        Me.TabPDireccion.UseVisualStyleBackColor = True
        '
        'BtnElimD
        '
        Me.BtnElimD.Location = New System.Drawing.Point(318, 6)
        Me.BtnElimD.Name = "BtnElimD"
        Me.BtnElimD.Size = New System.Drawing.Size(77, 24)
        Me.BtnElimD.TabIndex = 11
        Me.BtnElimD.Text = "Eliminar "
        Me.BtnElimD.UseVisualStyleBackColor = True
        '
        'BtnModD
        '
        Me.BtnModD.Location = New System.Drawing.Point(189, 6)
        Me.BtnModD.Name = "BtnModD"
        Me.BtnModD.Size = New System.Drawing.Size(77, 24)
        Me.BtnModD.TabIndex = 10
        Me.BtnModD.Text = "Modificar"
        Me.BtnModD.UseVisualStyleBackColor = True
        '
        'BtnAgregarD
        '
        Me.BtnAgregarD.Location = New System.Drawing.Point(43, 6)
        Me.BtnAgregarD.Name = "BtnAgregarD"
        Me.BtnAgregarD.Size = New System.Drawing.Size(77, 24)
        Me.BtnAgregarD.TabIndex = 9
        Me.BtnAgregarD.Text = "Agregar "
        Me.BtnAgregarD.UseVisualStyleBackColor = True
        '
        'BtnBuscD
        '
        Me.BtnBuscD.Location = New System.Drawing.Point(458, 6)
        Me.BtnBuscD.Name = "BtnBuscD"
        Me.BtnBuscD.Size = New System.Drawing.Size(77, 24)
        Me.BtnBuscD.TabIndex = 8
        Me.BtnBuscD.Text = "Buscar"
        Me.BtnBuscD.UseVisualStyleBackColor = True
        '
        'DGDireccionS
        '
        Me.DGDireccionS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDireccionS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DGDireccionS.Location = New System.Drawing.Point(6, 36)
        Me.DGDireccionS.Name = "DGDireccionS"
        Me.DGDireccionS.Size = New System.Drawing.Size(553, 139)
        Me.DGDireccionS.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Calle"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Numero"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Sector"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Manzana"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Casa"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Torre"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Piso"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Departamento"
        Me.Column8.Name = "Column8"
        '
        'TabPContacto
        '
        Me.TabPContacto.BackgroundImage = CType(resources.GetObject("TabPContacto.BackgroundImage"), System.Drawing.Image)
        Me.TabPContacto.Controls.Add(Me.BtnElimC)
        Me.TabPContacto.Controls.Add(Me.BtnModC)
        Me.TabPContacto.Controls.Add(Me.BtnAgregarC)
        Me.TabPContacto.Controls.Add(Me.BtnBuscC)
        Me.TabPContacto.Controls.Add(Me.DGContactoS)
        Me.TabPContacto.Location = New System.Drawing.Point(4, 22)
        Me.TabPContacto.Name = "TabPContacto"
        Me.TabPContacto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPContacto.Size = New System.Drawing.Size(565, 181)
        Me.TabPContacto.TabIndex = 1
        Me.TabPContacto.Text = "Contacto"
        Me.TabPContacto.UseVisualStyleBackColor = True
        '
        'BtnElimC
        '
        Me.BtnElimC.Location = New System.Drawing.Point(318, 6)
        Me.BtnElimC.Name = "BtnElimC"
        Me.BtnElimC.Size = New System.Drawing.Size(77, 24)
        Me.BtnElimC.TabIndex = 7
        Me.BtnElimC.Text = "Eliminar "
        Me.BtnElimC.UseVisualStyleBackColor = True
        '
        'BtnModC
        '
        Me.BtnModC.Location = New System.Drawing.Point(189, 6)
        Me.BtnModC.Name = "BtnModC"
        Me.BtnModC.Size = New System.Drawing.Size(77, 24)
        Me.BtnModC.TabIndex = 6
        Me.BtnModC.Text = "Modificar"
        Me.BtnModC.UseVisualStyleBackColor = True
        '
        'BtnAgregarC
        '
        Me.BtnAgregarC.Location = New System.Drawing.Point(45, 6)
        Me.BtnAgregarC.Name = "BtnAgregarC"
        Me.BtnAgregarC.Size = New System.Drawing.Size(77, 24)
        Me.BtnAgregarC.TabIndex = 5
        Me.BtnAgregarC.Text = "Agregar "
        Me.BtnAgregarC.UseVisualStyleBackColor = True
        '
        'BtnBuscC
        '
        Me.BtnBuscC.Location = New System.Drawing.Point(458, 6)
        Me.BtnBuscC.Name = "BtnBuscC"
        Me.BtnBuscC.Size = New System.Drawing.Size(77, 24)
        Me.BtnBuscC.TabIndex = 4
        Me.BtnBuscC.Text = "Buscar"
        Me.BtnBuscC.UseVisualStyleBackColor = True
        '
        'DGContactoS
        '
        Me.DGContactoS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGContactoS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.DGContactoS.Location = New System.Drawing.Point(6, 36)
        Me.DGContactoS.Name = "DGContactoS"
        Me.DGContactoS.Size = New System.Drawing.Size(553, 139)
        Me.DGContactoS.TabIndex = 0
        '
        'Column9
        '
        Me.Column9.HeaderText = "Celualar"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Fijo"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Email"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Web"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Fax"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "Otro"
        Me.Column14.Name = "Column14"
        '
        'F_CargaSitio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 421)
        Me.Controls.Add(Me.GB_CPD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_CargaSitio"
        Me.Text = "Cargar Sitio"
        Me.GB_CPD.ResumeLayout(False)
        Me.GB_CPD.PerformLayout()
        Me.GBEditar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPCarga.ResumeLayout(False)
        Me.TabPDireccion.ResumeLayout(False)
        CType(Me.DGDireccionS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPContacto.ResumeLayout(False)
        CType(Me.DGContactoS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_FNacimiento As Label
    Friend WithEvents DtpFAlta As DateTimePicker
    Friend WithEvents TxtNombreS As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents GB_CPD As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSCancelar As System.Windows.Forms.Button
    Friend WithEvents Lbl_EstadoCivil As System.Windows.Forms.Label
    Friend WithEvents Lbl_Sexo As System.Windows.Forms.Label
    Friend WithEvents CmbSRubro As System.Windows.Forms.ComboBox
    Friend WithEvents CmbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSAceptar As System.Windows.Forms.Button
    Friend WithEvents TabPCarga As System.Windows.Forms.TabControl
    Friend WithEvents TabPDireccion As System.Windows.Forms.TabPage
    Friend WithEvents BtnElimD As System.Windows.Forms.Button
    Friend WithEvents BtnModD As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarD As System.Windows.Forms.Button
    Friend WithEvents BtnBuscD As System.Windows.Forms.Button
    Friend WithEvents DGDireccionS As System.Windows.Forms.DataGridView
    Friend WithEvents TabPContacto As System.Windows.Forms.TabPage
    Friend WithEvents BtnElimC As System.Windows.Forms.Button
    Friend WithEvents BtnModC As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarC As System.Windows.Forms.Button
    Friend WithEvents BtnBuscC As System.Windows.Forms.Button
    Friend WithEvents DGContactoS As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents BtnModS As System.Windows.Forms.Button
    Friend WithEvents GBEditar As System.Windows.Forms.GroupBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
