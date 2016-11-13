Imports Oracle.DataAccess.Client

Public Class F_BuscarSitio

    Dim OBuscarSitio As New BuscarDB

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        OBuscarSitio.BuscarDatos()
        DGVBuscarS.DataSource = OBuscarSitio.CopiarRegistroDV()

    End Sub

    
End Class