Public Class F_CargaPersona


    Private Sub BtnAgregarD_Click(sender As Object, e As EventArgs) Handles BtnAgregarD.Click
        F_Agregar_Dir.Show()
        Me.Close()
    End Sub

    Private Sub BtnPCancelar_Click(sender As Object, e As EventArgs) Handles BtnPCancelar.Click
        Me.Close()
        F_Donde.Show()
    End Sub
End Class