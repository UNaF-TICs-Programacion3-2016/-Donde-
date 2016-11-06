Imports Oracle.DataAccess.Client

Public Enum EstadoCivil As Byte
    Soltero = 0
    Casado = 1
    Separado = 2
    Viudo = 3
End Enum

Public Enum Sexo As Byte
    Femenino = 0
    Masculino = 1
End Enum



Public Class F_CPersona

    Public OPersona As New Persona

    Public Conexion As New OracleConnection("Data Source=localhost;User Id=Dorian;Password=123456789;")

    Dim Adaptador As OracleDataAdapter
    Dim PersonaDS As New DataSet
    Dim Registro As DataRow

    Private Sub F_CPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OPersona.CargaCmbox(CmbSexo, CmbEstadoCivil)

        Adaptador = New OracleDataAdapter("Select * From Persona_cab Where Id_Persona = " + F_Donde.IdPersona.ToString, Conexion)
        Adaptador.Fill(PersonaDS, "persona_cab")
        If F_Donde.Accion = TipoAccion.Alta Then
            Registro = PersonaDS.Tables("persona_cab").NewRow()
            Registro("ID_PERSONA") = -1
        Else
            Registro = PersonaDS.Tables("persona_cab").Rows.Item(0)
        End If

        TxtNombre.Text = Registro("PER_NOMBRES").ToString
        TxtApellido.Text = Registro("PER_APELLIDOS").ToString
        TxtDni.Text = Registro("DNI").ToString
        TxtTipo.Text = Mid$(Registro("PER_CUILT").ToString(), 1, 2)
        TxtNumero.Text = Mid$(Registro("PER_CUILT").ToString(), 3, 8)
        TxtDigitoVerificador.Text = Mid$(Registro("PER_CUILT").ToString(), 11, 1)
        CmbSexo.SelectedIndex = IIf(IsDBNull(Registro("SEXO")), -1, Registro("SEXO"))
        CmbEstadoCivil.SelectedIndex = IIf(IsDBNull(Registro("ESTADO_CIVIL")), -1, Registro("ESTADO_CIVIL"))
        DtpFNacimiento.Value = IIf(IsDBNull(Registro("F_NACIMIENTO")), Date.Now, Registro("F_NACIMIENTO"))

        TxtApellido.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        TxtApellido.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        TxtDni.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        TxtTipo.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        TxtNumero.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        TxtDigitoVerificador.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        DtpFNacimiento.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        CmbSexo.Enabled = (F_Donde.Accion <> TipoAccion.Baja)
        CmbEstadoCivil.Enabled = (F_Donde.Accion <> TipoAccion.Baja)

    End Sub

    Private Sub AceptarCmd_Click(sender As Object, e As EventArgs) Handles AceptarCmd.Click
        'Oracle.DataAccess 
        'DataAdapter (Objetos)
        Dim InsertCmd As New OracleCommand
        Dim UpdateCmd As New OracleCommand
        Dim DeleteCmd As New OracleCommand

        Registro("PER_NOMBRES") = TxtNombre.Text
        Registro("PER_APELLIDOS") = TxtApellido.Text
        Registro("DNI") = CInt(TxtDni.Text)
        Registro("PER_CUILT") = TxtTipo.Text + TxtNumero.Text + TxtDigitoVerificador.Text
        Registro("SEXO") = CType(CmbSexo.SelectedIndex, Sexo)
        Registro("ESTADO_CIVIL") = CType(CmbEstadoCivil.SelectedIndex, EstadoCivil)
        Registro("F_NACIMIENTO") = DtpFNacimiento.Value

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
        'F_Donde.CargarComboPersonas()
        'Me.Close()
    End Sub
End Class
