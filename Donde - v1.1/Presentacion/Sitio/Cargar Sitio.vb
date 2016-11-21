

Public Class F_CargaSitio
    Dim oSitios As New Sitios

    Private Sub BtnSCancelar_Click(sender As Object, e As EventArgs) Handles BtnSCancelar.Click
        Me.Close()
        F_Donde.Show()
    End Sub

    Private Sub F_CargaSitio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oSitios.Cargar_Tabla()
        BtnModS.Visible = False
        GBEditar.Visible = False
    End Sub

    Private Sub BtnSAceptar_Click(sender As Object, e As EventArgs) Handles BtnSAceptar.Click
        oSitios.Agregar_Sitio()

    End Sub

    Private Sub BtnAgregarD_Click(sender As Object, e As EventArgs) Handles BtnAgregarD.Click
        F_Agregar_Dir.Show()
        F_Agregar_Dir.BtnAceptarP.Visible = False
        F_Agregar_Dir.BtnCancelarP.Visible = False
        F_Agregar_Dir.BtnAceptarS.Visible = True
        F_Agregar_Dir.BtnCancelarS.Visible = True

        Me.Hide()
    End Sub

    Private Sub BtnModS_Click(sender As Object, e As EventArgs) Handles BtnModS.Click


    End Sub
End Class
