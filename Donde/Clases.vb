Imports Oracle.DataAccess.Client ' Sentencia para importar la Clase OracleDataAcces

Public Enum EstadoCivil As Byte 'Enumeracion para selecionar el tipo de Estado Civil
    Soltero = 0
    Casado = 1
    Divorciado = 2
    Viudo = 3
    No_Definido = 4
End Enum

Public Enum Sexo As Byte 'Enumeracion para selecionar el tipo de Sexo
    Femenino = 0
    Masculino = 1
End Enum

Public Enum Rubros As Byte 'Enumeracion para selecionar el tipo de Sexo
    Comidas = 0
    Alquiler = 1
End Enum


Public Class Persona

    'Relacion de Agregacion

    Private Nombre, Apellido, Dni, Tipo, Numero, DigitoVerificador As TextBox
    Private CmbSexoa, CmbEstadoCivila As ComboBox
    Private DtpFNacimientoa As DateTimePicker

    'Esquema Desconectado

    'Oracle.DataAcces.Client
    Public Conexion As New OracleConnection("Data Source=localhost;User Id=Dorian;Password=123456789;")
    Dim Adaptador As OracleDataAdapter
    'Oracle.System.Data
    Dim PersonaDS As New DataSet
    Dim Registro As DataRow

    'Metodos Generales(Funciones y Procedimientos)


    Public Sub CargaCmbox(ByRef CmbSexop As ComboBox, ByRef CmbECivil As ComboBox) 'Relacion de Uso

        'Cargo Combo Sexo
        CmbSexop.Items.Insert(Sexo.Femenino, Sexo.Femenino.ToString)
        CmbSexop.Items.Insert(Sexo.Masculino, Sexo.Masculino.ToString)

        'Cargo Combo Estado Civil
        CmbECivil.Items.Insert(EstadoCivil.Soltero, EstadoCivil.Soltero.ToString)
        CmbECivil.Items.Insert(EstadoCivil.Casado, EstadoCivil.Casado.ToString)
        CmbECivil.Items.Insert(EstadoCivil.Divorciado, EstadoCivil.Divorciado.ToString)
        CmbECivil.Items.Insert(EstadoCivil.Viudo, EstadoCivil.Viudo.ToString)

    End Sub

    Public Sub CargaTabla()

        'Carga en Memoria Principal de la Tabla Persona_Cab
        Adaptador = New OracleDataAdapter("Select * From Persona_cab Where Id_Persona = " + F_Donde.IdPersona.ToString, Conexion)
        Adaptador.Fill(PersonaDS, "persona_cab")
        If F_Donde.Accion = TipoAccion.Alta Then
            Registro = PersonaDS.Tables("persona_cab").NewRow()
            Registro("ID_PERSONA") = -1
        Else
            Registro = PersonaDS.Tables("persona_cab").Rows.Item(0)
        End If

        Nombre.Text = Registro("PER_NOMBRES").ToString
        Apellido.Text = Registro("PER_APELLIDOS").ToString
        Dni.Text = Registro("DNI").ToString
        Tipo.Text = Mid$(Registro("PER_CUILT").ToString(), 1, 2)
        Numero.Text = Mid$(Registro("PER_CUILT").ToString(), 3, 8)
        DigitoVerificador.Text = Mid$(Registro("PER_CUILT").ToString(), 11, 1)
        CmbSexoa.SelectedIndex = IIf(IsDBNull(Registro("SEXO")), -1, Registro("SEXO"))
        CmbEstadoCivila.SelectedItem = IIf(IsDBNull(Registro("ESTADO_CIVIL")), -1, Registro("ESTADO_CIVIL"))
        DtpFNacimientoa.Value = IIf(IsDBNull(Registro("F_NACIMIENTO")), Date.Now, Registro("F_NACIMIENTO"))

        'Bloque de los texbox segun la condicion
        Nombre.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        Apellido.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        Dni.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        Tipo.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        Numero.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        DigitoVerificador.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        DtpFNacimientoa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        CmbSexoa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        CmbEstadoCivila.Enabled = (F_Donde.Accion <> TipoAccion.Baja)


    End Sub

    Public Sub AgregarPersona()

        Dim Conexion As New OracleConnection("Data Source=localhost;User Id=Dorian;Password=123456789;")

        'Oracle.DataAccess()
        'DataAdapter(Objetos)
        Dim InsertCmd As New OracleCommand
        Dim UpdateCmd As New OracleCommand
        Dim DeleteCmd As New OracleCommand

        Registro("PER_NOMBRES") = Nombre.Text
        Registro("PER_APELLIDOS") = Apellido.Text
        Registro("DNI") = CInt(Dni.Text)
        Registro("PER_CUILT") = Tipo.Text + Numero.Text + DigitoVerificador.Text
        Registro("SEXO") = CType(CmbSexoa.SelectedIndex, Sexo)
        Registro("ESTADO_CIVIL") = CType(CmbEstadoCivila.SelectedIndex, EstadoCivil)
        Registro("F_NACIMIENTO") = DtpFNacimientoa.Value

        If F_Donde.Accion = TipoAccion.Alta Then
            PersonaDS.Tables("persona_cab").Rows.Add(Registro)
        ElseIf F_Donde.Accion = TipoAccion.Baja Then
            PersonaDS.Tables("persona_cab").Rows.Remove(Registro)
        End If

        InsertCmd.CommandText = "Insert Into Persona_cab " + _
           "VALUES (:id_persona,:apellido,:nombre,:dni,:cuil,:sexo,:estadocivil,:fechanacimiento)"
        UpdateCmd.CommandText = "Update Persona " + _
            "set Per_Nombre = :nombre," + _
               " Per_Apellido = :apellido," + _
               " Dni = :dni," + _
                "Per_CUILT = :cuil," + _
                "Sexo = :sexo," + _
                "Estado_Civil = :estadocivil," + _
                "F_Nacimiento = :fechanacimiento" + _
            "where Id_Persona = :id_persona"

        DeleteCmd.CommandText = "Delete * From Persona_cab Where Id_Persona = :id_persona"

        InsertCmd.Connection = Conexion
        UpdateCmd.Connection = Conexion
        DeleteCmd.Connection = Conexion

        InsertCmd.Parameters.Add(New OracleParameter(":id_persona", OracleDbType.Int32, 0, "ID_PERSONA"))
        InsertCmd.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 0, "PER_NOMBRES"))
        InsertCmd.Parameters.Add(New OracleParameter(":apellido", OracleDbType.Varchar2, 0, "PER_APELLIDOS"))
        InsertCmd.Parameters.Add(New OracleParameter(":dni", OracleDbType.Varchar2, 0, "DNI"))
        InsertCmd.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Varchar2, 0, "PER_CUILT"))
        InsertCmd.Parameters.Add(New OracleParameter(":sexo", OracleDbType.Byte, 0, "SEXO"))
        InsertCmd.Parameters.Add(New OracleParameter(":estadocivil", OracleDbType.Byte, 0, "ESTADO_CIVIL"))
        InsertCmd.Parameters.Add(New OracleParameter(":fechanacimiento", OracleDbType.Date, 0, "F_NACIMIENTO"))

        UpdateCmd.Parameters.Add(New OracleParameter(":id_persona", OracleDbType.Int32, 0, "ID_PERSONA"))
        UpdateCmd.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 0, "PER_NOMBRE"))
        UpdateCmd.Parameters.Add(New OracleParameter(":apellido", OracleDbType.Varchar2, 0, "PER_APELLIDO"))
        UpdateCmd.Parameters.Add(New OracleParameter(":dni", OracleDbType.Varchar2, 8, "DNI"))
        UpdateCmd.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Varchar2, 13, "PER_CUILT"))
        UpdateCmd.Parameters.Add(New OracleParameter(":sexo", OracleDbType.Byte, 0, "SEXO"))
        UpdateCmd.Parameters.Add(New OracleParameter(":estadocivil", OracleDbType.Byte, 0, "ESTADO_CIVIL"))
        UpdateCmd.Parameters.Add(New OracleParameter(":fechanacimiento", OracleDbType.Date, 0, "F_NACIMIENTO"))


        DeleteCmd.Parameters.Add(New OracleParameter(":id_persona", OracleDbType.Int32, 0, "ID_PERSONA"))

        Adaptador.InsertCommand = InsertCmd
        Adaptador.UpdateCommand = UpdateCmd
        Adaptador.DeleteCommand = DeleteCmd
        Try
            Adaptador.Update(PersonaDS, "persona_cab")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If F_Donde.Accion = TipoAccion.Alta Then
            MessageBox.Show("Los datos se guardaron correctamente.")
        ElseIf F_Donde.Accion = TipoAccion.Modificacion Then
            MessageBox.Show("Los datos se actualizaron correctamente.")
        Else
            MessageBox.Show("El registro se eliminó correctamente.")
        End If
        '    'F_Donde.CargarComboPersonas()
        '    'Me.Close()

    End Sub

   
    'Metodos de Accesos a los Atributos

    Public Property CargaNombre() As TextBox

        Get
            Return Nombre
        End Get

        Set(ByVal value As TextBox)
            Nombre = value
        End Set
    End Property

    Public Property CargaApellido() As TextBox

        Get
            Return Apellido
        End Get

        Set(ByVal value As TextBox)
            Apellido = value
        End Set
    End Property

    Public Property CargaDni() As TextBox

        Get
            Return Dni
        End Get

        Set(ByVal value As TextBox)
            Dni = value
        End Set
    End Property

    Public Property CargaTipo() As TextBox

        Get
            Return Tipo
        End Get

        Set(ByVal value As TextBox)
            Tipo = value
        End Set
    End Property

    Public Property CargaNumero() As TextBox

        Get
            Return Numero
        End Get

        Set(ByVal value As TextBox)
            Numero = value
        End Set
    End Property

    Public Property CargaDigitoVerificador() As TextBox

        Get
            Return DigitoVerificador
        End Get

        Set(ByVal value As TextBox)
            DigitoVerificador = value
        End Set
    End Property

    Public WriteOnly Property CargaCmbSexoa() As ComboBox

        Set(ByVal value As ComboBox)
            CmbSexoa = value
        End Set

    End Property

    Public WriteOnly Property CargaCmbEstadoCivila() As ComboBox

        Set(ByVal value As ComboBox)
            CmbEstadoCivila = value
        End Set

    End Property

    Public WriteOnly Property CargaDtpFNacimientoa() As DateTimePicker

        Set(ByVal value As DateTimePicker)
            DtpFNacimientoa = value
        End Set

    End Property



End Class

Public Class Sitios

    'Relacion de Agregacion

    Private NombreSitioa, DescRubroa, CodRubroa, DescTRubroa, CodTRubroa As TextBox
    Private CmbRubroa, CmbTipoRa As ComboBox
    Private DtpFAltaa As DateTimePicker

    'Esquema Desconectado

    'Oracle.DataAcces.Client
    Public Conexion As New OracleConnection("Data Source=localhost;User Id=Sitio;Password=123456789;")
    Dim Adaptador As OracleDataAdapter
    'Oracle.System.Data
    Dim SitioDS As New DataSet
    Public RubroDS, TRubroDS As New DataSet
    Dim Registro, Registro1 As DataRow
    

    'Metodos Generales(Funciones y Procedimientos)

    Public Sub CargaTablaSitio()

        'Carga en Memoria Principal de la Tabla Persona_Cab
        Adaptador = New OracleDataAdapter("Select * From Sitio_cab Where Id_Sitio = " + F_Donde.IdSitio.ToString, Conexion)
        Adaptador.Fill(SitioDS, "sitio_cab")
        If F_Donde.Accion = TipoAccion.Alta Then
            Registro = SitioDS.Tables("sitio_cab").NewRow()
            Registro("ID_SITIO") = -1
        Else
            Registro = SitioDS.Tables("sitio_cab").Rows.Item(0)
        End If

        NombreSitioa.Text = Registro("SITIO_NOMBRES").ToString
        'CmbRubroa.SelectedIndex = IIf(IsDBNull(Registro("RUBRO")), -1, Registro("RUBRO"))
        'CmbTipoa.SelectedItem = IIf(IsDBNull(Registro("TIPOR")), -1, Registro("TIPOR"))
        DtpFAltaa.Value = IIf(IsDBNull(Registro("F_ALTA")), Date.Now, Registro("F_ALTA"))

        'Bloque de los texbox segun la condicion
        NombreSitioa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        'CmbRubroa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        'CmbTipoa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        DtpFAltaa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        


    End Sub

    Public Sub CargaTablaRubro()

        'Carga en Memoria Principal de la Tabla Rubro
        Adaptador = New OracleDataAdapter("Select * From Rubro Where Id_Rubro = " + F_Donde.IdRubro.ToString, Conexion)
        Adaptador.Fill(RubroDS, "rubro")


        If F_Donde.Accion = TipoAccion.Alta Then
            Registro1 = RubroDS.Tables("rubro").NewRow()
            Registro1("ID_RUBRO") = -1
        Else
            Registro1 = RubroDS.Tables("rubro").Rows.Item(0)
        End If

        CodRubroa.Text = Registro1("CODIGO").ToString
        DescRubroa.Text = Registro1("DESCRIPCION").ToString

        'Bloque de los texbox segun la condicion
        CodRubroa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        DescRubroa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)

    End Sub

    Public Sub CargaTablaTRubro()

        'Carga en Memoria Principal de la Tabla Tipo_Rubro
        Adaptador = New OracleDataAdapter("Select * From Tipo_Rubro Where Id_Tiporubro = " + F_Donde.IdSitio.ToString, Conexion)
        Adaptador.Fill(TRubroDS, "tipo_rubro")
        If F_Donde.Accion = TipoAccion.Alta Then
            Registro = TRubroDS.Tables("tipo_rubro").NewRow()
            Registro("ID_TIPORUBRO") = -1
        Else
            Registro = TRubroDS.Tables("tipo_rubro").Rows.Item(0)
        End If

        CodTRubroa.Text = Registro("CODIGO").ToString
        DescTRubroa.Text = Registro("DESCRIPCION").ToString

        'Bloque de los texbox segun la condicion
        CodTRubroa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        DescTRubroa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)




    End Sub
    'Carga de los combobox desde la Base de Datos

    Public Sub CargaCmbRubro()

        'Esquema Desconectado

        'Oracle.DataAcces.Client
        Dim Conexion As New OracleConnection()
        Dim AdaptadorR As New OracleDataAdapter("Select * From Rubro", Conexion)
        'Oracle.System.Data
        Dim RubroDS As New DataSet

        Try
            Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=Sitio;" _
                                        + "Password=123456789;"

            AdaptadorR.Fill(RubroDS, "Rubro")
            CmbRubroa.DataSource = RubroDS.Tables("Rubro")
            CmbRubroa.DisplayMember = "Descripcion"
            CmbRubroa.ValueMember = "Id_Rubro"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub CargaCmbTRubro()

        'Esquema Desconectado

        'Oracle.DataAcces.Client
        Dim Conexion As New OracleConnection()
        Dim AdaptadorTR As New OracleDataAdapter("Select * From Tipo_Rubro", Conexion)
        'Oracle.System.Data
        Dim TipoRDS As New DataSet

        Try
            Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=Sitio;" _
                                        + "Password=123456789;"

            AdaptadorTR.Fill(TipoRDS, "Tipo_Rubro")
            CmbTipoRa.DataSource = TipoRDS.Tables("Tipo_Rubro")
            CmbTipoRa.DisplayMember = "Descripcion"
            CmbTipoRa.ValueMember = "Id_Tiporubro"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    'Carga de un nuevo Rubro en la Base de Datos
    Public Sub AgregarRubro()
        'Oracle.DataAccess()
        'DataAdapter(Objetos)
        Dim InsertCmd As New OracleCommand
        Dim UpdateCmd As New OracleCommand
        Dim DeleteCmd As New OracleCommand

        Registro1("CODIGO") = CodRubroa.Text
        Registro1("DESCRIPCION") = DescRubroa.Text


        If F_Donde.Accion = TipoAccion.Alta Then
            RubroDS.Tables("rubro").Rows.Add(Registro1)
        ElseIf F_Donde.Accion = TipoAccion.Baja Then
            RubroDS.Tables("rubro").Rows.Remove(Registro1)
        End If

        InsertCmd.CommandText = "Insert Into rubro (id_rubro,codigo,descripcion) " + _
           "VALUES (:id_rubro,:codigo,:descripcion)"
        UpdateCmd.CommandText = "Update Rubro " + _
            "set Codigo = :codigo," + _
                "Descripcion = :descripcion" + _
            "where Id_Rubro = :id_rubro"

        DeleteCmd.CommandText = "Delete * From Rubro Where Id_Rubro = :id_rubro"

        InsertCmd.Connection = Conexion
        UpdateCmd.Connection = Conexion
        DeleteCmd.Connection = Conexion

        InsertCmd.Parameters.Add(New OracleParameter(":id_rubro", OracleDbType.Int32, 0, "ID_RUBRO"))
        InsertCmd.Parameters.Add(New OracleParameter(":codigo", OracleDbType.Int32, 0, "CODIGO"))
        InsertCmd.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 30, "DESCRIPCION"))

        UpdateCmd.Parameters.Add(New OracleParameter(":id_rubro", OracleDbType.Int32, 0, "ID_RUBRO"))
        UpdateCmd.Parameters.Add(New OracleParameter(":codigo", OracleDbType.Int32, 0, "CODIGO"))
        UpdateCmd.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 30, "DESCRIPCION"))


        DeleteCmd.Parameters.Add(New OracleParameter(":id_rubro", OracleDbType.Int32, 0, "ID_RUBRO"))

        Adaptador.InsertCommand = InsertCmd
        Adaptador.UpdateCommand = UpdateCmd
        Adaptador.DeleteCommand = DeleteCmd
        Try
            Adaptador.Update(RubroDS, "RUBRO")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If F_Donde.Accion = TipoAccion.Alta Then
            MessageBox.Show("Los datos se guardaron correctamente.")
        ElseIf F_Donde.Accion = TipoAccion.Modificacion Then
            MessageBox.Show("Los datos se actualizaron correctamente.")
        Else
            MessageBox.Show("El registro se eliminó correctamente.")
        End If

    End Sub

    'Carga de un nuevo Tipo de Rubro en la Base de Datos
    Public Sub AgregarTipoRubro()
        'Oracle.DataAccess()
        'DataAdapter(Objetos)
        Dim InsertCmd As New OracleCommand
        Dim UpdateCmd As New OracleCommand
        Dim DeleteCmd As New OracleCommand

       

        Registro("CODIGO") = CodTRubroa.Text
        Registro("DESCRIPCION") = DescTRubroa.Text


        If F_Donde.Accion = TipoAccion.Alta Then
            TRubroDS.Tables("tipo_rubro").Rows.Add(Registro)
        ElseIf F_Donde.Accion = TipoAccion.Baja Then
            TRubroDS.Tables("tipo_rubro").Rows.Remove(Registro)
        End If

        InsertCmd.CommandText = "Insert Into tipo_rubro (id_tiporubro,codigo,descripcion) " + _
           "VALUES (:id_tiporubro,:codigo,:descripcion)"
        UpdateCmd.CommandText = "Update Rubro " + _
            "set Codigo = :codigo," + _
                "Descripcion = :descripcion" + _
            "where Id_Rubro = :id_tiporubro"

        DeleteCmd.CommandText = "Delete * From Rubro Where Id_TipoRubro = :id_tiporubro"

        InsertCmd.Connection = Conexion
        UpdateCmd.Connection = Conexion
        DeleteCmd.Connection = Conexion

        InsertCmd.Parameters.Add(New OracleParameter(":id_tiporubro", OracleDbType.Int32, 0, "ID_TIPORUBRO"))
        InsertCmd.Parameters.Add(New OracleParameter(":codigo", OracleDbType.Int32, 0, "CODIGO"))
        InsertCmd.Parameters.Add(New OracleParameter(":descrpcion", OracleDbType.Varchar2, 0, "DESCRIPCION"))

        UpdateCmd.Parameters.Add(New OracleParameter(":id_tiporubro", OracleDbType.Int32, 0, "ID_TIPORUBRO"))
        UpdateCmd.Parameters.Add(New OracleParameter(":codigo", OracleDbType.Int32, 0, "CODIGO"))
        UpdateCmd.Parameters.Add(New OracleParameter(":descripcion", OracleDbType.Varchar2, 0, "DESCRIPCION"))


        DeleteCmd.Parameters.Add(New OracleParameter(":id_tiporubro", OracleDbType.Int32, 0, "ID_TIPORUBRO"))

        Adaptador.InsertCommand = InsertCmd
        Adaptador.UpdateCommand = UpdateCmd
        Adaptador.DeleteCommand = DeleteCmd
        Try
            Adaptador.Update(TRubroDS, "TIPO_RUBRO")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If F_Donde.Accion = TipoAccion.Alta Then
            MessageBox.Show("Los datos se guardaron correctamente.")
        ElseIf F_Donde.Accion = TipoAccion.Modificacion Then
            MessageBox.Show("Los datos se actualizaron correctamente.")
        Else
            MessageBox.Show("El registro se eliminó correctamente.")
        End If

    End Sub

    'Carga de un nuevo Sitio en la Base de Datos 

    Public Sub AgregarSitio()

        Dim Conexion As New OracleConnection("Data Source=localhost;User Id=Sitio;Password=123456789;")

        'Oracle.DataAccess()
        'DataAdapter(Objetos)
        Dim InsertCmd As New OracleCommand
        Dim UpdateCmd As New OracleCommand
        Dim DeleteCmd As New OracleCommand

        Registro("SITIO_NOMBRES") = NombreSitioa.Text
        Registro("F_ALTA") = DtpFAltaa.Value
        'Registro("RUBRO") = CType(CmbRubroa.SelectedIndex, Rubros)
        'Registro("ESTADO_CIVIL") = CType(CmbEstadoCivila.SelectedIndex, EstadoCivil)


        If F_Donde.Accion = TipoAccion.Alta Then
            SitioDS.Tables("sitio_cab").Rows.Add(Registro)
        ElseIf F_Donde.Accion = TipoAccion.Baja Then
            SitioDS.Tables("sitio_cab").Rows.Remove(Registro)
        End If

        InsertCmd.CommandText = "Insert Into Sitio_cab " + _
           "VALUES (:id_sitio,:nombre,:falta)"
        UpdateCmd.CommandText = "Update Sitio " + _
            "set Sitio_Nombres = :nombre," + _
                "F_Alta = :falta" + _
            "where Id_Sitio = :id_sitio"

        DeleteCmd.CommandText = "Delete * From Sitio_cab Where Id_Sitio = :id_sitio"

        InsertCmd.Connection = Conexion
        UpdateCmd.Connection = Conexion
        DeleteCmd.Connection = Conexion

        InsertCmd.Parameters.Add(New OracleParameter(":id_sitio", OracleDbType.Int32, 0, "ID_SITIO"))
        InsertCmd.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 0, "SITIO_NOMBRES"))
        InsertCmd.Parameters.Add(New OracleParameter(":falta", OracleDbType.Date, 0, "F_ALTA"))

        UpdateCmd.Parameters.Add(New OracleParameter(":id_sitio", OracleDbType.Int32, 0, "ID_SITIO"))
        UpdateCmd.Parameters.Add(New OracleParameter(":nombre", OracleDbType.Varchar2, 0, "SITIO_NOMBRES"))
        UpdateCmd.Parameters.Add(New OracleParameter(":falta", OracleDbType.Date, 0, "F_ALTA"))


        DeleteCmd.Parameters.Add(New OracleParameter(":id_sitio", OracleDbType.Int32, 0, "ID_SITIO"))

        Adaptador.InsertCommand = InsertCmd
        Adaptador.UpdateCommand = UpdateCmd
        Adaptador.DeleteCommand = DeleteCmd
        Try
            Adaptador.Update(SitioDS, "Sitio_cab")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If F_Donde.Accion = TipoAccion.Alta Then
            MessageBox.Show("Los datos se guardaron correctamente.")
        ElseIf F_Donde.Accion = TipoAccion.Modificacion Then
            MessageBox.Show("Los datos se actualizaron correctamente.")
        Else
            MessageBox.Show("El registro se eliminó correctamente.")
        End If
        '    'F_Donde.CargarComboPersonas()
        '    'Me.Close()

    End Sub


    'Metodos de Accesos a los Atributos

    'Camdio de estado al atributo

    Public Property CargaNombreSitio() As TextBox

        Get
            Return NombreSitioa
        End Get

        Set(ByVal value As TextBox)
            NombreSitioa = value
        End Set
    End Property

    'Camdio de estado al atributo

    Public WriteOnly Property CargaDtpFAltaa() As DateTimePicker

        Set(ByVal value As DateTimePicker)
            DtpFAltaa = value
        End Set

    End Property

    'Camdio de estado al atributo

    Public Property CargaCmbRubroa() As ComboBox

        Get
            Return CmbRubroa
        End Get

        Set(ByVal value As ComboBox)
            CmbRubroa = value
        End Set

    End Property

    'Camdio de estado al atributo

    Public Property CargaCmbTipoRa() As ComboBox

        Get
            Return CmbTipoRa
        End Get

        Set(ByVal value As ComboBox)
            CmbTipoRa = value
        End Set

    End Property

    'Camdio de estado al atributo

    Public Property CEstadoDescRubroa() As TextBox
        Get
            Return DescRubroa
        End Get

        Set(ByVal value As TextBox)
            DescRubroa = value
        End Set

    End Property

    'Camdio de estado al atributo

    Public Property CEstadoCodRubroa() As TextBox
        Get
            Return CodRubroa
        End Get
        Set(ByVal value As TextBox)
            CodRubroa = value
        End Set

    End Property

    'Camdio de estado al atributo

    Public Property CEstadoCodTRubroa() As TextBox
        Get
            Return CodTRubroa
        End Get
        Set(ByVal value As TextBox)
            CodTRubroa = value
        End Set

    End Property

    'Camdio de estado al atributo

    Public Property CEstadoDescTRubroa() As TextBox
        Get
            Return DescTRubroa
        End Get
        Set(ByVal value As TextBox)
            DescTRubroa = value
        End Set

    End Property




End Class



