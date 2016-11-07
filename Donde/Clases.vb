Imports Oracle.DataAccess.Client ' Sentencia para importar la clase OracleDataAcces
Public Class Persona
    Private Nombre, Apellido, Dni, Tipo, Numero, DigitoVerificador As TextBox
    Private CmbSexoa, CmbEstadoCivila As ComboBox
    Private DtpFNacimientoa As DateTimePicker

    Public Conexion As New OracleConnection("Data Source=localhost;User Id=Prueba_db;Password=jjbm5526;")
    Dim Adaptador As OracleDataAdapter
    Dim PersonaDS As New DataSet
    Dim Registro As DataRow
    'Carga los combobox del formulario Carga Personas
    Public Sub CargarCombobox(CmbSexop As ComboBox, CmbEcivilp As ComboBox)
        'Cargara el combobox Sexo
        CmbSexop.Items.Insert(Sexo.Femenino, Sexo.Femenino.ToString)
        CmbSexop.Items.Insert(Sexo.Masculino, Sexo.Masculino.ToString)
        'Cargara el Combobox Estado Civil
        CmbEcivilp.Items.Insert(EstadoCivil.Soltero, EstadoCivil.Soltero.ToString)
        CmbEcivilp.Items.Insert(EstadoCivil.Casado, EstadoCivil.Casado.ToString)
        CmbEcivilp.Items.Insert(EstadoCivil.Separado, EstadoCivil.Separado.ToString)
        CmbEcivilp.Items.Insert(EstadoCivil.Viudo, EstadoCivil.Viudo.ToString)
    End Sub
    'Carga Datos en Memoria a la Tabla Persona_Cab
    Public Sub CargarTabla()
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
        CmbEstadoCivila.SelectedIndex = IIf(IsDBNull(Registro("ESTADO_CIVIL")), -1, Registro("ESTADO_CIVIL"))
        DtpFNacimientoa.Value = IIf(IsDBNull(Registro("F_NACIMIENTO")), Date.Now, Registro("F_NACIMIENTO"))

        'Bloquea los Textbox segun la condicion
        Apellido.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        Nombre.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        Dni.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        Tipo.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        Numero.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        DigitoVerificador.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        DtpFNacimientoa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        CmbSexoa.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        CmbEstadoCivila.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
    End Sub
    'Carga Los datos para pasarlos a la BD
    Public Sub AgregarPersona()

        Dim InsertCmd As New OracleCommand
        Dim UpdateCmd As New OracleCommand
        Dim DeleteCmd As New OracleCommand

        Registro("PER_NOMBRES") = Nombre.Text
        Registro("PER_APELLIDOS") = Apellido.Text
        Registro("DNI") = Dni.Text
        Registro("PER_CUILT") = Tipo.Text + Numero.Text + DigitoVerificador.Text
        Registro("SEXO") = CType(CmbSexoa.SelectedIndex, Sexo)
        Registro("ESTADO_CIVIL") = CType(CmbEstadoCivila.SelectedIndex, EstadoCivil)
        Registro("F_NACIMIENTO") = DtpFNacimientoa.Value

        If F_Donde.Accion = TipoAccion.Alta Then
            PersonaDS.Tables("persona_cab").Rows.Add(Registro)
        ElseIf F_Donde.Accion = TipoAccion.Baja Then
            PersonaDS.Tables("persona_cab").Rows.Remove(Registro)
        End If

        InsertCmd.CommandText = "Insert Into Persona_cab " +
           "VALUES (:id_persona,:apellido,:nombre,:dni,:cuil,:sexo,:estadocivil,:fechanacimiento)"
        UpdateCmd.CommandText = "Update Persona " +
            "set Per_Nombre = :nombre," +
               " Per_Apellido = :apellido," +
               " Dni = :dni," +
                "Per_CUILT = :cuil," +
                "Sexo = :sexo," +
                "Estado_Civil = :estadocivil," +
                "F_Nacimiento = :fechanacimiento" +
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
    End Sub
    Public Shared Function ValidarCuil(pTipo As TextBox, pNumero As TextBox, pDigitoVerifivador As TextBox) As Boolean
        Dim CUILStr As String
        Dim Suma As Double
        Dim Resto As Double
        CUILStr = pTipo.Text + "" + pNumero.Text + "" + pDigitoVerifivador.Text

        Suma = (Mid(CUILStr, 1, 1) * 5) +
            (Mid(CUILStr, 2, 1) * 4) +
            (Mid(CUILStr, 3, 1) * 3) +
            (Mid(CUILStr, 4, 1) * 2) +
            (Mid(CUILStr, 5, 1) * 7) +
            (Mid(CUILStr, 6, 1) * 6) +
            (Mid(CUILStr, 7, 1) * 5) +
            (Mid(CUILStr, 8, 1) * 4) +
            (Mid(CUILStr, 9, 1) * 3) +
            (Mid(CUILStr, 10, 1) * 2)

        Resto = Suma Mod 11

        If Resto = 0 And Mid(CUILStr, 11, 1) = 0 Then
            Return True
        ElseIf Resto = 1 And Mid(CUILStr, 11, 1) = 0 Then
            Return False
        ElseIf Mid(CUILStr, 11, 1) = (11 - Resto) Then
            Return True
        End If
        Return False

    End Function
    Public Property CargarNombre() As TextBox
        Get
            Return Nombre
        End Get
        Set(ByVal value As TextBox)
            Nombre = value
        End Set
    End Property
    Public Property CargarApellido() As TextBox
        Get
            Return Apellido
        End Get
        Set(ByVal value As TextBox)
            Apellido = value
        End Set
    End Property
    Public Property CargarDni() As TextBox
        Get
            Return Dni
        End Get
        Set(ByVal value As TextBox)
            Dni = value
        End Set
    End Property
    Public Property CargarTipo() As TextBox
        Get
            Return Tipo
        End Get
        Set(ByVal value As TextBox)
            Tipo = value
        End Set
    End Property
    Public Property CargarNumero() As TextBox
        Get
            Return Numero
        End Get
        Set(ByVal value As TextBox)
            Numero = value
        End Set
    End Property
    Public Property CargarDigitoVerificador() As TextBox
        Get
            Return DigitoVerificador
        End Get
        Set(ByVal value As TextBox)
            DigitoVerificador = value
        End Set
    End Property
    Public Property CargarEstadoCivil() As ComboBox
        Get
            Return CmbEstadoCivila
        End Get
        Set(ByVal value As ComboBox)
            CmbEstadoCivila = value
        End Set
    End Property
    Public Property CargarSexo() As ComboBox
        Get
            Return CmbSexoa
        End Get
        Set(ByVal value As ComboBox)
            CmbSexoa = value
        End Set
    End Property
    Public Property CargarFecha() As DateTimePicker
        Get
            Return DtpFNacimientoa
        End Get
        Set(ByVal value As DateTimePicker)
            DtpFNacimientoa = value
        End Set
    End Property
End Class

Public Class Sitios


End Class