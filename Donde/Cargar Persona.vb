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
    Private oPersona As New Persona

    Private Sub F_CPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If TxtApellido.Text = "" And + _
            TxtNombre.Text = "" And + _
            TxtDni.Text = "" And + _
            TxtTipo.Text = "" And + _
            TxtNumero.Text = "" And + _
            TxtDigitoVerificador.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class