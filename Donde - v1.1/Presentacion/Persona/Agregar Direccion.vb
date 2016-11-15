Public Class F_Agregar_Dir

    Private Sub BtnCancelarP_Click(sender As Object, e As EventArgs) Handles BtnCancelarP.Click
        Me.Close()
        F_CargaPersona.Show()
    End Sub

    Private Sub BtnAceptarP_Click(sender As Object, e As EventArgs) Handles BtnAceptarP.Click
        F_CargaPersona.DGDireccion.Rows.Add(TxtCalle.Text, CDbl(TxtNum.Text), CChar(TxtSector.Text), CChar(TxtMza.Text), CChar(TxtCasa.Text))
        MsgBox("Direccion Agregada con Exito")

        If MsgBox("¿Desea Agregar Otra Direccion?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Me.Close()
            F_CargaPersona.Show()
        End If
    End Sub
End Class