Imports Oracle.DataAccess.Client

Public Enum EstadoCivil As Byte
    Soltero = 0
    Casado = 1
End Enum

Public Enum Sexo As Byte
    Femenino = 0
    Masculino = 1
End Enum

Public Class F_CPersona

    Public Conexion As New OracleConnection("Data Source=localhost;User Id=Dorian;Password=123456789;")

    Dim Adaptador As OracleDataAdapter
    Dim PersonaDS As New DataSet
    Dim Registro As DataRow

    Private Sub F_CPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargo Combo Sexo
        CmbSexo.Items.Insert(Sexo.Femenino, Sexo.Femenino.ToString)
        CmbSexo.Items.Insert(Sexo.Masculino, Sexo.Masculino.ToString)

        'Cargo Combo Estado Civil
        CmbEstadoCivil.Items.Insert(EstadoCivil.Soltero, EstadoCivil.Soltero.ToString)
        CmbEstadoCivil.Items.Insert(EstadoCivil.Casado, EstadoCivil.Casado.ToString)

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






    
End Class
