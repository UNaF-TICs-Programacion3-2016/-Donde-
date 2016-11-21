Public Class F_CargaPersona
    'Dim oPersona As Persona

    Private Sub BtnAgregarD_Click(sender As Object, e As EventArgs) Handles BtnAgregarD.Click
        F_Agregar_Dir.Show()
        F_Agregar_Dir.BtnAceptarP.Visible = True
        F_Agregar_Dir.BtnCancelarP.Visible = True
        F_Agregar_Dir.BtnAceptarS.Visible = False
        F_Agregar_Dir.BtnCancelarS.Visible = False

        Me.Hide()
    End Sub

    Private Sub BtnPCancelar_Click(sender As Object, e As EventArgs) Handles BtnPCancelar.Click
        Me.Close()
        F_Donde.Show()
    End Sub

    Private Sub F_CargaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'oPersona = New Persona
        'oPersona.Cargar_Tabla("Persona_cab", "Persona_cab", "Id_persona")
        'oPersona.Insertar()

        'Cargo Combo Sexo
        CmbSexo.Items.Insert(Sexos.Femenino, Sexos.Femenino.ToString)
        CmbSexo.Items.Insert(Sexos.Masculino, Sexos.Masculino.ToString)

        'Cargo Combo Estado Civil
        CmbECivil.Items.Insert(EstadosCiviles.Soltero, EstadosCiviles.Soltero.ToString)
        CmbECivil.Items.Insert(EstadosCiviles.Casado, EstadosCiviles.Casado.ToString)

    End Sub
End Class