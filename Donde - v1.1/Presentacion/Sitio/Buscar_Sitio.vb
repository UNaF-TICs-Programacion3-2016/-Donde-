Imports Oracle.DataAccess.Client

Public Class F_BuscarSitio

    'Dim oBuscarBD As New BuscarDB
    Dim oSitios As New Sitios
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        oSitios.ListarSitios(DGVBuscarS)
    End Sub


    Private Sub DGVBuscarS_DoubleClick(sender As Object, e As EventArgs) Handles DGVBuscarS.DoubleClick

        Try
            F_CargaSitio.TxtID.Text = DGVBuscarS.Rows(DGVBuscarS.CurrentRow.Index).Cells(0).Value
            F_CargaSitio.TxtNombreS.Text = DGVBuscarS.Rows(DGVBuscarS.CurrentRow.Index).Cells(1).Value
            ' F_CargaSitio.DtpFAlta = DGVBuscarS.Rows(DGVBuscarS.CurrentRow.Index).Cells(2).Value
            F_CargaSitio.Show()
            F_CargaSitio.BtnModS.Visible = True
            F_CargaSitio.GBEditar.Visible = True
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class