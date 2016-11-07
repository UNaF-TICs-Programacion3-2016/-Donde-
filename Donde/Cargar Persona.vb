

Public Class F_CPersona

    Public OPersona As New Persona 'Instancia de la Clase Persona 

    Private Sub F_CPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '"With": Ejecuta una serie de acciones que hacen referencia a un nico objeto

        With OPersona ' "Mensajes" Invocacion de Metodos por medio de un Objeto de la Clase

            .CargaCmbox(CmbSexo, CmbEstadoCivil)
            .CargaNombre() = TxtNombre
            .CargaApellido() = TxtApellido
            .CargaDni() = TxtDni
            .CargaTipo() = TxtTipo
            .CargaNumero() = TxtNumero
            .CargaDigitoVerificador() = TxtDigitoVerificador
            .CargaCmbSexoa() = CmbSexo
            .CargaCmbEstadoCivila() = CmbEstadoCivil
            .CargaDtpFNacimientoa() = DtpFNacimiento
            .CargaTabla()

        End With

        'If TxtNombre.Text = "" And TxtApellido.Text = "" And TxtDni.Text = "" And TxtTipo.Text = "" And TxtNumero.Text = "" And TxtDigitoVerificador.Text = "" Then
        '    AceptarCmd.Enabled = False
        'End If

    End Sub

    Private Sub BtnAPersona_Click(sender As Object, e As EventArgs) Handles BtnAPersona.Click

        '"With": Ejecuta una serie de acciones que hacen referencia a un unico objeto

        With OPersona ' "Mensajes" Invocacion de Metodos por medio de un Objeto de la Clase
            .AgregarPersona()
            .CargaNombre() = TxtNombre
            .CargaApellido() = TxtApellido
            .CargaDni() = TxtDni
            .CargaTipo() = TxtTipo
            .CargaNumero() = TxtNumero
            .CargaDigitoVerificador() = TxtDigitoVerificador
            .CargaCmbSexoa() = CmbSexo
            .CargaCmbEstadoCivila() = CmbEstadoCivil
            .CargaDtpFNacimientoa() = DtpFNacimiento
            .CargaTabla()
        End With
        'Me.Close()
        'F_Donde.Show()
    End Sub

    Private Sub BtnCPersona_Click(sender As Object, e As EventArgs) Handles BtnCPersona.Click
        Me.Close()
        F_Donde.Show()
    End Sub
End Class
