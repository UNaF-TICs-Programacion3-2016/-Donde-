Public Class F_Agregar_Dir

    Private Sub BtnCancelarP_Click(sender As Object, e As EventArgs) Handles BtnCancelarP.Click
        Me.Close()
        F_CargaPersona.Show()
    End Sub

    Private Sub BtnAceptarP_Click(sender As Object, e As EventArgs) Handles BtnAceptarP.Click
        F_CargaPersona.DGDireccion.Rows.Add(TxtCalle.Text, TxtNum.Text, TxtSector.Text, TxtMza.Text, TxtCasa.Text, TxtTorre.Text, TxtPiso.Text, TxtDpto.Text)
        MsgBox("Direccion Agregada con Exito")

        If MsgBox("¿Desea Agregar Otra Direccion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Me.Close()
            F_CargaPersona.Show()
        Else
            TxtCalle.Text = ""
            TxtNum.Text = ""
            TxtSector.Text = ""
            TxtMza.Text = ""
            TxtCasa.Text = ""
            TxtTorre.Text = ""
            TxtDpto.Text = ""
            TxtPiso.Text = ""
        End If
    End Sub

    

    Private Sub BtnCancelarS_Click(sender As Object, e As EventArgs) Handles BtnCancelarS.Click
        Me.Hide()
        F_CargaSitio.Show()
    End Sub

    Private Sub BtnAceptarS_Click(sender As Object, e As EventArgs) Handles BtnAceptarS.Click
        F_CargaSitio.DGDireccionS.Rows.Add(TxtCalle.Text, TxtNum.Text, TxtSector.Text, TxtMza.Text, TxtCasa.Text, TxtTorre.Text, TxtPiso.Text, TxtDpto.Text)
        MsgBox("Direccion Agregada con Exito")

        If MsgBox("¿Desea Agregar Otra Direccion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Me.Close()
            F_CargaSitio.Show()
        Else
            TxtCalle.Text = ""
            TxtNum.Text = ""
            TxtSector.Text = ""
            TxtMza.Text = ""
            TxtCasa.Text = ""
            TxtTorre.Text = ""
            TxtDpto.Text = ""
            TxtPiso.Text = ""
        End If
    End Sub

    

End Class