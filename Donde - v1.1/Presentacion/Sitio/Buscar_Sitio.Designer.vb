<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BuscarSitio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_BuscarSitio))
        Me.DGVBuscarS = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GBBuscarS = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BuscarPorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DirreccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DireccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DueñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubRubroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGVBuscarS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBBuscarS.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVBuscarS
        '
        Me.DGVBuscarS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBuscarS.Location = New System.Drawing.Point(15, 29)
        Me.DGVBuscarS.Name = "DGVBuscarS"
        Me.DGVBuscarS.Size = New System.Drawing.Size(365, 150)
        Me.DGVBuscarS.TabIndex = 0
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(311, 242)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "Trer Tabla"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'GBBuscarS
        '
        Me.GBBuscarS.BackgroundImage = CType(resources.GetObject("GBBuscarS.BackgroundImage"), System.Drawing.Image)
        Me.GBBuscarS.Controls.Add(Me.DGVBuscarS)
        Me.GBBuscarS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBBuscarS.Location = New System.Drawing.Point(6, 41)
        Me.GBBuscarS.Name = "GBBuscarS"
        Me.GBBuscarS.Size = New System.Drawing.Size(398, 195)
        Me.GBBuscarS.TabIndex = 2
        Me.GBBuscarS.TabStop = False
        Me.GBBuscarS.Text = "Resultado de la Busqueda"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(404, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuscarPorToolStripMenuItem
        '
        Me.BuscarPorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DirreccionToolStripMenuItem, Me.DireccionToolStripMenuItem, Me.DueñoToolStripMenuItem, Me.RubroToolStripMenuItem, Me.SubRubroToolStripMenuItem})
        Me.BuscarPorToolStripMenuItem.Name = "BuscarPorToolStripMenuItem"
        Me.BuscarPorToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BuscarPorToolStripMenuItem.Text = "Buscar por"
        '
        'DirreccionToolStripMenuItem
        '
        Me.DirreccionToolStripMenuItem.Name = "DirreccionToolStripMenuItem"
        Me.DirreccionToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DirreccionToolStripMenuItem.Text = "Nombre"
        '
        'DireccionToolStripMenuItem
        '
        Me.DireccionToolStripMenuItem.Name = "DireccionToolStripMenuItem"
        Me.DireccionToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DireccionToolStripMenuItem.Text = "Direccion"
        '
        'DueñoToolStripMenuItem
        '
        Me.DueñoToolStripMenuItem.Name = "DueñoToolStripMenuItem"
        Me.DueñoToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DueñoToolStripMenuItem.Text = "Dueño"
        '
        'RubroToolStripMenuItem
        '
        Me.RubroToolStripMenuItem.Name = "RubroToolStripMenuItem"
        Me.RubroToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.RubroToolStripMenuItem.Text = "Rubro"
        '
        'SubRubroToolStripMenuItem
        '
        Me.SubRubroToolStripMenuItem.Name = "SubRubroToolStripMenuItem"
        Me.SubRubroToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SubRubroToolStripMenuItem.Text = "Sub Rubro"
        '
        'F_BuscarSitio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(404, 277)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GBBuscarS)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "F_BuscarSitio"
        Me.Text = "Buscar_Sitio"
        CType(Me.DGVBuscarS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBBuscarS.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVBuscarS As System.Windows.Forms.DataGridView
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents GBBuscarS As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BuscarPorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirreccionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DireccionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DueñoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubRubroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
