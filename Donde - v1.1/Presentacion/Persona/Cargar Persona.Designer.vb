<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CargaPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_CargaPersona))
        Me.GB_CPD = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextDigVerif = New System.Windows.Forms.TextBox()
        Me.TextTipo = New System.Windows.Forms.TextBox()
        Me.TextNumero = New System.Windows.Forms.TextBox()
        Me.TextDniP = New System.Windows.Forms.TextBox()
        Me.TextNombreP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBEditar = New System.Windows.Forms.GroupBox()
        Me.BtnModP = New System.Windows.Forms.Button()
        Me.LblID = New System.Windows.Forms.Label()
        Me.TxtIDP = New System.Windows.Forms.TextBox()
        Me.Lbl_EstadoCivil = New System.Windows.Forms.Label()
        Me.TxtAppellidoP = New System.Windows.Forms.TextBox()
        Me.Lbl_Sexo = New System.Windows.Forms.Label()
        Me.Lbl_Nombre = New System.Windows.Forms.Label()
        Me.CmbECivil = New System.Windows.Forms.ComboBox()
        Me.DtpFNac = New System.Windows.Forms.DateTimePicker()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.Lbl_FNacimiento = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPCancelar = New System.Windows.Forms.Button()
        Me.BtnPAceptar = New System.Windows.Forms.Button()
        Me.TabPCarga = New System.Windows.Forms.TabControl()
        Me.TabPDireccion = New System.Windows.Forms.TabPage()
        Me.BtnElimD = New System.Windows.Forms.Button()
        Me.BtnModD = New System.Windows.Forms.Button()
        Me.BtnAgregarD = New System.Windows.Forms.Button()
        Me.BtnBuscD = New System.Windows.Forms.Button()
        Me.DGDireccion = New System.Windows.Forms.DataGridView()
        Me.TabPContacto = New System.Windows.Forms.TabPage()
        Me.BtnElimC = New System.Windows.Forms.Button()
        Me.BtnModC = New System.Windows.Forms.Button()
        Me.BtnAgregarC = New System.Windows.Forms.Button()
        Me.BtnBuscC = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB_CPD.SuspendLayout()
        Me.GBEditar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPCarga.SuspendLayout()
        Me.TabPDireccion.SuspendLayout()
        CType(Me.DGDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPContacto.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_CPD
        '
        Me.GB_CPD.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GB_CPD.BackgroundImage = CType(resources.GetObject("GB_CPD.BackgroundImage"), System.Drawing.Image)
        Me.GB_CPD.Controls.Add(Me.Label3)
        Me.GB_CPD.Controls.Add(Me.Label2)
        Me.GB_CPD.Controls.Add(Me.TextDigVerif)
        Me.GB_CPD.Controls.Add(Me.TextTipo)
        Me.GB_CPD.Controls.Add(Me.TextNumero)
        Me.GB_CPD.Controls.Add(Me.TextDniP)
        Me.GB_CPD.Controls.Add(Me.TextNombreP)
        Me.GB_CPD.Controls.Add(Me.Label1)
        Me.GB_CPD.Controls.Add(Me.GBEditar)
        Me.GB_CPD.Controls.Add(Me.LblID)
        Me.GB_CPD.Controls.Add(Me.TxtIDP)
        Me.GB_CPD.Controls.Add(Me.Lbl_EstadoCivil)
        Me.GB_CPD.Controls.Add(Me.TxtAppellidoP)
        Me.GB_CPD.Controls.Add(Me.Lbl_Sexo)
        Me.GB_CPD.Controls.Add(Me.Lbl_Nombre)
        Me.GB_CPD.Controls.Add(Me.CmbECivil)
        Me.GB_CPD.Controls.Add(Me.DtpFNac)
        Me.GB_CPD.Controls.Add(Me.CmbSexo)
        Me.GB_CPD.Controls.Add(Me.Lbl_FNacimiento)
        Me.GB_CPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CPD.Location = New System.Drawing.Point(0, 0)
        Me.GB_CPD.Name = "GB_CPD"
        Me.GB_CPD.Size = New System.Drawing.Size(593, 219)
        Me.GB_CPD.TabIndex = 34
        Me.GB_CPD.TabStop = False
        Me.GB_CPD.Text = "Carga de Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(241, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "CUILT"
        '
        'TextDigVerif
        '
        Me.TextDigVerif.Location = New System.Drawing.Point(417, 142)
        Me.TextDigVerif.Name = "TextDigVerif"
        Me.TextDigVerif.Size = New System.Drawing.Size(33, 20)
        Me.TextDigVerif.TabIndex = 44
        '
        'TextTipo
        '
        Me.TextTipo.Location = New System.Drawing.Point(241, 142)
        Me.TextTipo.Name = "TextTipo"
        Me.TextTipo.Size = New System.Drawing.Size(40, 20)
        Me.TextTipo.TabIndex = 43
        '
        'TextNumero
        '
        Me.TextNumero.Location = New System.Drawing.Point(287, 142)
        Me.TextNumero.Name = "TextNumero"
        Me.TextNumero.Size = New System.Drawing.Size(124, 20)
        Me.TextNumero.TabIndex = 42
        '
        'TextDniP
        '
        Me.TextDniP.Location = New System.Drawing.Point(241, 98)
        Me.TextDniP.Name = "TextDniP"
        Me.TextDniP.Size = New System.Drawing.Size(124, 20)
        Me.TextDniP.TabIndex = 41
        '
        'TextNombreP
        '
        Me.TextNombreP.Location = New System.Drawing.Point(12, 142)
        Me.TextNombreP.Name = "TextNombreP"
        Me.TextNombreP.Size = New System.Drawing.Size(209, 20)
        Me.TextNombreP.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = " Nombre/s"
        '
        'GBEditar
        '
        Me.GBEditar.BackgroundImage = CType(resources.GetObject("GBEditar.BackgroundImage"), System.Drawing.Image)
        Me.GBEditar.Controls.Add(Me.BtnModP)
        Me.GBEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEditar.Location = New System.Drawing.Point(105, 21)
        Me.GBEditar.Name = "GBEditar"
        Me.GBEditar.Size = New System.Drawing.Size(200, 54)
        Me.GBEditar.TabIndex = 38
        Me.GBEditar.TabStop = False
        Me.GBEditar.Text = "Editar Sitio"
        '
        'BtnModP
        '
        Me.BtnModP.Location = New System.Drawing.Point(15, 19)
        Me.BtnModP.Name = "BtnModP"
        Me.BtnModP.Size = New System.Drawing.Size(77, 24)
        Me.BtnModP.TabIndex = 12
        Me.BtnModP.Text = "Modificar"
        Me.BtnModP.UseVisualStyleBackColor = True
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
        'TxtIDP
        '
        Me.TxtIDP.Location = New System.Drawing.Point(12, 37)
        Me.TxtIDP.Name = "TxtIDP"
        Me.TxtIDP.Size = New System.Drawing.Size(46, 20)
        Me.TxtIDP.TabIndex = 36
        '
        'Lbl_EstadoCivil
        '
        Me.Lbl_EstadoCivil.AutoSize = True
        Me.Lbl_EstadoCivil.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_EstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EstadoCivil.Location = New System.Drawing.Point(347, 176)
        Me.Lbl_EstadoCivil.Name = "Lbl_EstadoCivil"
        Me.Lbl_EstadoCivil.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_EstadoCivil.TabIndex = 35
        Me.Lbl_EstadoCivil.Text = "Estado Civil"
        '
        'TxtAppellidoP
        '
        Me.TxtAppellidoP.Location = New System.Drawing.Point(12, 98)
        Me.TxtAppellidoP.Name = "TxtAppellidoP"
        Me.TxtAppellidoP.Size = New System.Drawing.Size(209, 20)
        Me.TxtAppellidoP.TabIndex = 13
        '
        'Lbl_Sexo
        '
        Me.Lbl_Sexo.AutoSize = True
        Me.Lbl_Sexo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sexo.Location = New System.Drawing.Point(239, 176)
        Me.Lbl_Sexo.Name = "Lbl_Sexo"
        Me.Lbl_Sexo.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_Sexo.TabIndex = 32
        Me.Lbl_Sexo.Text = "Sexo"
        '
        'Lbl_Nombre
        '
        Me.Lbl_Nombre.AutoSize = True
        Me.Lbl_Nombre.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nombre.Location = New System.Drawing.Point(13, 82)
        Me.Lbl_Nombre.Name = "Lbl_Nombre"
        Me.Lbl_Nombre.Size = New System.Drawing.Size(64, 13)
        Me.Lbl_Nombre.TabIndex = 29
        Me.Lbl_Nombre.Text = "Apellido/s"
        '
        'CmbECivil
        '
        Me.CmbECivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbECivil.FormattingEnabled = True
        Me.CmbECivil.Location = New System.Drawing.Point(350, 192)
        Me.CmbECivil.Name = "CmbECivil"
        Me.CmbECivil.Size = New System.Drawing.Size(101, 21)
        Me.CmbECivil.TabIndex = 34
        '
        'DtpFNac
        '
        Me.DtpFNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFNac.Location = New System.Drawing.Point(12, 193)
        Me.DtpFNac.Name = "DtpFNac"
        Me.DtpFNac.Size = New System.Drawing.Size(100, 20)
        Me.DtpFNac.TabIndex = 20
        '
        'CmbSexo
        '
        Me.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Location = New System.Drawing.Point(242, 192)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(82, 21)
        Me.CmbSexo.TabIndex = 33
        '
        'Lbl_FNacimiento
        '
        Me.Lbl_FNacimiento.AutoSize = True
        Me.Lbl_FNacimiento.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_FNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FNacimiento.Location = New System.Drawing.Point(9, 177)
        Me.Lbl_FNacimiento.Name = "Lbl_FNacimiento"
        Me.Lbl_FNacimiento.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_FNacimiento.TabIndex = 25
        Me.Lbl_FNacimiento.Text = "Fecha de Alta"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.BtnPCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnPAceptar)
        Me.GroupBox1.Controls.Add(Me.TabPCarga)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 225)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 259)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'BtnPCancelar
        '
        Me.BtnPCancelar.Location = New System.Drawing.Point(391, 227)
        Me.BtnPCancelar.Name = "BtnPCancelar"
        Me.BtnPCancelar.Size = New System.Drawing.Size(77, 25)
        Me.BtnPCancelar.TabIndex = 27
        Me.BtnPCancelar.Text = "Cancelar"
        Me.BtnPCancelar.UseVisualStyleBackColor = True
        '
        'BtnPAceptar
        '
        Me.BtnPAceptar.Location = New System.Drawing.Point(474, 227)
        Me.BtnPAceptar.Name = "BtnPAceptar"
        Me.BtnPAceptar.Size = New System.Drawing.Size(77, 26)
        Me.BtnPAceptar.TabIndex = 26
        Me.BtnPAceptar.Text = "Aceptar"
        Me.BtnPAceptar.UseVisualStyleBackColor = True
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
        Me.TabPDireccion.Controls.Add(Me.DGDireccion)
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
        'DGDireccion
        '
        Me.DGDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDireccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DGDireccion.Location = New System.Drawing.Point(6, 36)
        Me.DGDireccion.Name = "DGDireccion"
        Me.DGDireccion.Size = New System.Drawing.Size(553, 139)
        Me.DGDireccion.TabIndex = 0
        '
        'TabPContacto
        '
        Me.TabPContacto.BackgroundImage = CType(resources.GetObject("TabPContacto.BackgroundImage"), System.Drawing.Image)
        Me.TabPContacto.Controls.Add(Me.BtnElimC)
        Me.TabPContacto.Controls.Add(Me.BtnModC)
        Me.TabPContacto.Controls.Add(Me.BtnAgregarC)
        Me.TabPContacto.Controls.Add(Me.BtnBuscC)
        Me.TabPContacto.Controls.Add(Me.DataGridView1)
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(553, 139)
        Me.DataGridView1.TabIndex = 0
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
        Me.Column7.HeaderText = "Departamento"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Piso"
        Me.Column8.Name = "Column8"
        '
        'F_CargaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 484)
        Me.Controls.Add(Me.GB_CPD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "F_CargaPersona"
        Me.Text = "Cargar_Persona"
        Me.GB_CPD.ResumeLayout(False)
        Me.GB_CPD.PerformLayout()
        Me.GBEditar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPCarga.ResumeLayout(False)
        Me.TabPDireccion.ResumeLayout(False)
        CType(Me.DGDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPContacto.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_CPD As System.Windows.Forms.GroupBox
    Friend WithEvents GBEditar As System.Windows.Forms.GroupBox
    Friend WithEvents BtnModP As System.Windows.Forms.Button
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents TxtIDP As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_EstadoCivil As System.Windows.Forms.Label
    Friend WithEvents TxtAppellidoP As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Sexo As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents CmbECivil As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_FNacimiento As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnPAceptar As System.Windows.Forms.Button
    Friend WithEvents TabPCarga As System.Windows.Forms.TabControl
    Friend WithEvents TabPDireccion As System.Windows.Forms.TabPage
    Friend WithEvents BtnElimD As System.Windows.Forms.Button
    Friend WithEvents BtnModD As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarD As System.Windows.Forms.Button
    Friend WithEvents BtnBuscD As System.Windows.Forms.Button
    Friend WithEvents DGDireccion As System.Windows.Forms.DataGridView
    Friend WithEvents TabPContacto As System.Windows.Forms.TabPage
    Friend WithEvents BtnElimC As System.Windows.Forms.Button
    Friend WithEvents BtnModC As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarC As System.Windows.Forms.Button
    Friend WithEvents BtnBuscC As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextDigVerif As System.Windows.Forms.TextBox
    Friend WithEvents TextTipo As System.Windows.Forms.TextBox
    Friend WithEvents TextNumero As System.Windows.Forms.TextBox
    Friend WithEvents TextDniP As System.Windows.Forms.TextBox
    Friend WithEvents TextNombreP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
