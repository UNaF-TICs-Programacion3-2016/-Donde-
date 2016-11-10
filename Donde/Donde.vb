
Public Enum TipoAccion As Byte 'Enumeracion para selecionar el tipo de accion a realizar por el usuario
    Alta = 1
    Modificacion = 2
    Baja = 3
End Enum

Public Class F_Donde

    Friend Accion As TipoAccion
    Friend IdPersona As Long
    Friend IdSitio As Long
    Friend IdRubro As Long
    Friend IdTRubro As Long

    ' Llama al formolario para realizar la carga de los datos de una perosna a la Base de Datos
    Private Sub Btn_AP_Click(sender As Object, e As EventArgs) Handles Btn_AP.Click
        IdPersona = -1
        Accion = TipoAccion.Alta
        F_CPersona.Show()
        Me.Hide()
    End Sub

    ' Llama al formolario para realizar la carga de los datos de un Sitio a la Base de Datos
    Private Sub Btn_AS_Click(sender As Object, e As EventArgs) Handles Btn_AS.Click
        IdSitio = -1
        Accion = TipoAccion.Alta
        F_CSitio.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDSalir_Click(sender As Object, e As EventArgs) Handles BtnDSalir.Click
        Me.Close()
    End Sub

    
End Class
