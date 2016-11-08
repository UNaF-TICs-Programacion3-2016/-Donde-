

Public Class F_CSitio

    Public OSitio As New Sitios 'Instancia de la Clase Sitio 

    Private Sub F_CSitio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '"With": Ejecuta una serie de acciones que hacen referencia a un nico objeto

        With OSitio ' "Mensajes" Invocacion de Metodos por medio de un Objeto de la Clase
            .CargaCmbRubroa() = CmbRubro
            .CargaCmbTipoRa() = CmbTrubro
            .CargaRubro()
            .CargaTRubro()
            .CargaNombreSitio() = TxtNombreS
            .CargaDtpFAltaa() = DtpFAlta
            .CargaTablaSitio()

        End With

        'If TxtNombre.Text = "" And TxtApellido.Text = "" And TxtDni.Text = "" And TxtTipo.Text = "" And TxtNumero.Text = "" And TxtDigitoVerificador.Text = "" Then
        '    AceptarCmd.Enabled = False
        'End If

    End Sub

    Private Sub BtnSAceptar_Click(sender As Object, e As EventArgs) Handles BtnSAceptar.Click

        '"With": Ejecuta una serie de acciones que hacen referencia a un unico objeto

        With OSitio ' "Mensajes" Invocacion de Metodos por medio de un Objeto de la Clase
            .AgregarSitio()
            .CargaNombreSitio() = TxtNombreS
            .CargaDtpFAltaa() = DtpFAlta
            .CargaTablaSitio()
        End With
        'Me.Close()
        'F_Donde.Show()
    End Sub

    Private Sub BtnSCancelar_Click(sender As Object, e As EventArgs) Handles BtnSCancelar.Click
        Me.Close()
        F_Donde.Show()
    End Sub


    Private Sub BtnDAgrRub_Click(sender As Object, e As EventArgs) Handles BtnDAgrRub.Click
        F_Donde.IdRubro = -1
        F_Donde.Accion = TipoAccion.Alta
        F_CRubros.Show()
        Me.Close()
    End Sub
End Class
