

Public Class F_CargaSitio






    Private Sub BtnSCancelar_Click(sender As Object, e As EventArgs) Handles BtnSCancelar.Click
        Me.Close()
        F_Donde.Show()
    End Sub

    Private Sub F_CargaSitio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim OConecion As New ConexionBD

        'OConecion.Conectar()
        'OConecion.Cargar_Tabla("Sitio_cab", "sitio_cab", "ID_SITIO")


        BtnModS.Visible = False
        GBEditar.Visible = False
    End Sub

    Private Sub BtnSAceptar_Click(sender As Object, e As EventArgs) Handles BtnSAceptar.Click
        'Dim OInsertarDatos As New InsertarDatos
        'Dim Datos As New Datos_CEstado

        'Datos.CEstadoStr1 = TxtNombreS.Text
        'Datos.CEstadoDtp1 = DtpFAlta

        'If OInsertarDatos.InsertarDatos(Datos) Then
        '    MsgBox("Datos Guardados")
        'Else
        '    MsgBox("Datos No Guardados")
        'End If

    End Sub
End Class
