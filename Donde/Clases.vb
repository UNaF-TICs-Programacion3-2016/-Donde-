Imports Oracle.DataAccess.Client ' Sentencia para importar la Clase OracleDataAcces



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
        CmbECivil.Items.Insert(EstadoCivil.Separado, EstadoCivil.Separado.ToString)
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
        Apellido.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
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


End Class



