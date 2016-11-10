Public Class F_CRubros

    Dim OSitioCR As New Sitios

    Private Sub F_CRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '"With": Ejecuta una serie de acciones que hacen referencia a un unico objeto

        With OSitioCR ' "Mensajes" Invocacion de Metodos por medio de un Objeto de la Clase
            
            .CEstadoCodRubroa = TxtCodR
            .CEstadoDescRubroa = TxtCRubro
            .CargaTablaRubro()
            .CEstadoCodTRubroa = TxtCodTR
            .CEstadoDescTRubroa = TxtCTRubro
            .CargaTablaTRubro()

        End With

    End Sub

    Private Sub BtnCRAceptar_Click(sender As Object, e As EventArgs) Handles BtnCRAceptar.Click
        '"With": Ejecuta una serie de acciones que hacen referencia a un nico objeto

        With OSitioCR ' "Mensajes" Invocacion de Metodos por medio de un Objeto de la Clase

            .CEstadoCodRubroa = TxtCodR
            .CEstadoDescRubroa = TxtCRubro
            .AgregarRubro()
            .CEstadoCodTRubroa = TxtCodTR
            .CEstadoDescTRubroa = TxtCTRubro
            .AgregarTipoRubro()

        End With

        'If TxtNombre.Text = "" And TxtApellido.Text = "" And TxtDni.Text = "" And TxtTipo.Text = "" And TxtNumero.Text = "" And TxtDigitoVerificador.Text = "" Then
        '    AceptarCmd.Enabled = False
        'End If

        F_CSitio.Show()
        Me.Close()

    End Sub

    
End Class