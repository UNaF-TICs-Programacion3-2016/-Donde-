Imports Oracle.DataAccess.Client
Public Class F_CPersona
    Private oPersona As New Persona

    Private Sub F_CPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombosDir()
        With oPersona
            .CargarCombobox(CmbSexo, CmbEstadoCivil) 'Carga los Cmb Con Items
            .CargarNombre = TxtNombre
            .CargarApellido = TxtApellido
            .CargarDni = TxtDni
            .CargarTipo = TxtTipo
            .CargarNumero = TxtNumero
            .CargarDigitoVerificador = TxtDigitoVerificador
            .CargarSexo = CmbSexo
            .CargarEstadoCivil = CmbEstadoCivil
            .CargarFecha = DtpFNacimiento
            .CargarTabla()
        End With

    End Sub
    Private Sub AceptarCmd_Click(sender As Object, e As EventArgs) Handles AceptarCmd.Click
        With oPersona
            .CargarNombre = TxtNombre
            .CargarApellido = TxtApellido
            .CargarDni = TxtDni
            .CargarTipo = TxtTipo
            .CargarNumero = TxtNumero
            .CargarDigitoVerificador = TxtDigitoVerificador
            .CargarSexo = CmbSexo
            .CargarEstadoCivil = CmbEstadoCivil
            .CargarFecha = DtpFNacimiento
        End With
        'Verifica si todos los datos son ingresados
        If ValidacionesDeTextBoxs() = False Then
            MsgBox("Complete los Campos Restantes")
            Exit Sub
        End If
        'Verifica si el CUIL ingresado es correcto
        If Persona.ValidarCuil(TxtTipo, TxtNumero, TxtDigitoVerificador) = True Then
            MsgBox("El CUIL es Valido")
        Else
            MsgBox("El CUIL NO es Valido")
            oPersona.CargarTabla()
            Exit Sub
        End If
        'Agrega una persona a la tabla
        oPersona.AgregarPersona()
        'Vuelve a cargar la tabla para una nueva persona
        oPersona.CargarTabla()
        'Me.Close()
    End Sub
    'Validacion para cada textboxs'''''Si uno de los textboxs no contiene datos no guardara los datos
    Public Function ValidacionesDeTextBoxs() As Boolean
        If Nothing = (TxtApellido.Text) And
            Nothing=(TxtNombre.Text) And
            Nothing=(TxtDni.Text) And
            Nothing=(TxtTipo.Text) And
            Nothing=(TxtNumero.Text) And
            Nothing=(TxtDigitoVerificador.Text) Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Sub CargarCombosDir()
        Dim Conexion As New Oracleconnection
        Dim ProvinciaDS As New DataSet
        Dim Adaptador As New OracleDataAdapter("Select * From Provincia", Conexion)
        Try
            Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=Direccion;" _
                                        + "Password=jjbm5526;"

            Adaptador.Fill(ProvinciaDS, "Provincia")
            CmbProvincia.DataSource = ProvinciaDS.Tables("Provincia")
            CmbProvincia.DisplayMember = "Nombre"
            CmbProvincia.ValueMember = "ID_Provincia"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        F_Donde.Show()
        Me.Close()
    End Sub
End Class