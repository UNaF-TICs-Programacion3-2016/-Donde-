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
            .AgregarPersona()
        End With

    End Sub

    Private Sub TxtDni_TextChanged(sender As Object, e As EventArgs) Handles TxtDni.TextChanged

    End Sub
End Class