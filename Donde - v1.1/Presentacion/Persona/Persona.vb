Imports Oracle.DataAccess.Client
Public Enum EstadosCiviles As Byte
    Soltero = 0
    Casado = 1
    Separado = 2
    Viudo = 3
End Enum
Public Enum Sexos As Byte
    Femenino = 0
    Masculino = 1
End Enum

'Public Class Persona
'    Inherits ConexionBD
'    Private Nombre, Apellido, DNI, Tipo, Numero, DigitoVerificador As String
'    Private Sexo As Sexos
'    Private EstadoCivil As EstadosCiviles
'    Private DtpFNacimientoa As DateTimePicker

'    Dim New_Id As Long
'    Public Overrides Function Cargar_Tabla(Entidad_p As String, Tabla_p As String, Id_tabla_p As String) As Boolean
'        RegistroDS = New DataSet
'        AdaptadorOA = New OracleDataAdapter("Select * From Persona Where Id_Persona = " + F_Donde.IdPersona.ToString, Conexion)
'        AdaptadorOA.Fill(RegistroDS, "persona_cab")

'        Nombre = RegistroDR("PER_NOMBRES").ToString
'        Apellido = RegistroDR("PER_APELLIDOS").ToString
'        DNI = RegistroDR("DNI").ToString
'        Tipo = Mid$(RegistroDR("PER_CUILT").ToString(), 1, 2)
'        Numero = Mid$(RegistroDR("PER_CUILT").ToString(), 3, 8)
'        DigitoVerificador = Mid$(RegistroDR("PER_CUILT").ToString(), 11, 1)
'        Sexo = IIf(IsDBNull(RegistroDR("SEXO")), -1, RegistroDR("SEXO"))
'        EstadoCivil = IIf(IsDBNull(RegistroDR("ESTADO_CIVIL")), -1, RegistroDR("ESTADO_CIVIL"))
'        DtpFNacimientoa.Value = IIf(IsDBNull(RegistroDR("F_NACIMIENTO")), Date.Now, RegistroDR("F_NACIMIENTO"))
'        Return True
'    End Function
'    Public Sub Insertar()
'        CargarDatosPer()
'        RegistroDS.Tables("persona_cab").Rows.Add(RegistroDR)

'        Try
'            Conexion.Open()
'            Transaction = Conexion.BeginTransaction(IsolationLevel.ReadCommitted)
'            InsertCommand.Connection = Conexion
'            InsertCommand.Transaction = Transaction
'            With InsertCommand
'                'Ejecuto el Insert de Persona
'                .CommandType = CommandType.StoredProcedure
'                .CommandText = "PA_INSERT_PERSONA"
'                .Parameters.Clear()
'                .Parameters.Add(New OracleParameter("pnombre", OracleDbType.Varchar2) With {.Value = RegistroDR("PER_NOMBRES")})
'                .Parameters.Add(New OracleParameter("papellido", OracleDbType.Varchar2) With {.Value = RegistroDR("PER_APELLIDOS")})
'                .Parameters.Add(New OracleParameter("pdni", OracleDbType.Varchar2) With {.Value = RegistroDR("DNI")})
'                .Parameters.Add(New OracleParameter("pcuil", OracleDbType.Varchar2) With {.Value = RegistroDR("PER_CUILT")})
'                .Parameters.Add(New OracleParameter("psexo", OracleDbType.Int32) With {.Value = RegistroDR("SEXO")})
'                .Parameters.Add(New OracleParameter("pestadocivil", OracleDbType.Int32) With {.Value = RegistroDR("ESTADO_CIVIL")})
'                .Parameters.Add(New OracleParameter("pfechanacimiento", OracleDbType.Date) With {.Value = RegistroDR("F_NACIMIENTO")})
'                .Parameters.Add(New OracleParameter("last_id", OracleDbType.Int32, ParameterDirection.Output))
'                .ExecuteNonQuery()
'                MsgBox(.Parameters("last_id").Value)
'                New_Id = Long.Parse(.Parameters("last_id").Value.ToString)
'            End With

'            InsertCommand.Connection = Conexion
'            Transaction.Commit()

'        Catch ex As Exception
'            Transaction.Rollback()
'            MsgBox(ex.Message)
'        Finally
'            Conexion.Close()
'        End Try
'        Try
'            AdaptadorOA.InsertCommand = InsertCommand
'            MessageBox.Show("Los datos se guardaron correctamente.")
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try
'    End Sub
'    Public Sub Update()
'        CargarDatosPer()
'        UpdateCommand.CommandText = "Update Persona_cab 
'            set PER_NOMBRES = :per_Nombres,
'                PER_APELLIDOS = :per_apellidos
'                DNI = :dni,
'                PER_CUILT = :per_cuilt,
'                SEXO = :sexo,
'                ESTADO_CIVIL = :estado_civil,
'                F_NACIMIENTO = :f_nacimiento
'            where Id_Persona = :idpersona"

'        UpdateCommand.Connection = Conexion

'        UpdateCommand.Parameters.Add(New OracleParameter(":per_Nombres", OracleDbType.Varchar2, 0, "PER_NOMBRES"))
'        UpdateCommand.Parameters.Add(New OracleParameter(":per_apellidos", OracleDbType.Varchar2, 0, "PER_APELLIDOS"))
'        UpdateCommand.Parameters.Add(New OracleParameter(":dni", OracleDbType.Varchar2, 8, "DNI"))
'        UpdateCommand.Parameters.Add(New OracleParameter(":per_cuilt", OracleDbType.Varchar2, 13, "PER_CUILT"))
'        UpdateCommand.Parameters.Add(New OracleParameter(":sexo", OracleDbType.Byte, 0, "SEXO"))
'        UpdateCommand.Parameters.Add(New OracleParameter(":estado_civil", OracleDbType.Byte, 0, "ESTADO_CIVIL"))
'        UpdateCommand.Parameters.Add(New OracleParameter(":f_nacimiento", OracleDbType.Date, 0, "F_NACIMIENTO"))
'        UpdateCommand.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int32, 0, "ID_PERSONA"))

'        AdaptadorOA.UpdateCommand = UpdateCommand
'        Try
'            AdaptadorOA.Update(RegistroDS, "persona_cab")
'            MessageBox.Show("Los datos se actualizaron correctamente.")
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try

'    End Sub
'    Public Sub Delete()
'        DeleteCommand.CommandText = "Delete * From Persona_cab Where Id_Persona = :idpersona"

'        DeleteCommand.Connection = Conexion

'        DeleteCommand.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int32, 0, "ID_PERSONA"))

'        AdaptadorOA.DeleteCommand = DeleteCommand

'        MessageBox.Show("El registro se eliminó correctamente.")

'    End Sub
'    Public Sub CargarDatosPer()
'        Dim CUILSTR As String
'        CUILSTR = Tipo + Numero + DigitoVerificador

'        RegistroDR("PER_NOMBRES") = Nombre
'        RegistroDR("PER_APELLIDOS") = Apellido
'        RegistroDR("DNI") = DNI
'        RegistroDR("PER_CUILT") = CUILSTR
'        RegistroDR("SEXO") = CType(Sexo, Sexos)
'        RegistroDR("ESTADO_CIVIL") = CType(EstadoCivil, EstadosCiviles)
'        RegistroDR("F_NACIMIENTO") = DtpFNacimientoa.Value
'    End Sub

'    Public Property CargaNombre() As String
'        Get
'            Return Nombre
'        End Get
'        Set(ByVal value As String)
'            Nombre = value
'        End Set
'    End Property
'    Public Property CargaApellido() As String
'        Get
'            Return Apellido
'        End Get
'        Set(ByVal value As String)
'            Apellido = value
'        End Set
'    End Property
'    Public Property CargaDni() As String
'        Get
'            Return DNI
'        End Get
'        Set(ByVal value As String)
'            DNI = value
'        End Set
'    End Property
'    Public Property CargaTipo() As String
'        Get
'            Return Tipo
'        End Get
'        Set(ByVal value As String)
'            Tipo = value
'        End Set
'    End Property
'    Public Property CargaNumero() As String
'        Get
'            Return Numero
'        End Get
'        Set(ByVal value As String)
'            Numero = value
'        End Set
'    End Property
'    Public Property CargaDigitoVerificador() As String
'        Get
'            Return DigitoVerificador
'        End Get
'        Set(ByVal value As String)
'            DigitoVerificador = value
'        End Set
'    End Property
'    Public Property CargaEstadoCivil() As EstadosCiviles
'        Get
'            Return EstadoCivil
'        End Get
'        Set(ByVal value As EstadosCiviles)
'            EstadoCivil = value
'        End Set
'    End Property
'    Public Property CargaSexo() As Sexos
'        Get
'            Return Sexo
'        End Get
'        Set(ByVal value As Sexos)
'            Sexo = value
'        End Set
'    End Property
'    Public Property CargarFecha() As DateTimePicker
'        Get
'            Return DtpFNacimientoa
'        End Get
'        Set(ByVal value As DateTimePicker)
'            DtpFNacimientoa = value
'        End Set
'    End Property
'End Class
