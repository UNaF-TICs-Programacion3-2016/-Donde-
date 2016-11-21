
Public Enum TipoAccion As Byte 'Enumeracion para selecionar el tipo de accion a realizar por el usuario
    Alta = 1
    Modificacion = 2
    Baja = 3
End Enum
Public Class F_Donde
    'Atributos
    Friend Accion As TipoAccion
    Friend IdPersona, IdSitio As Long

    'Metodos (unciones y Procedimientos)

    Private Sub F_Donde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnDSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        F_CargaSitio.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub


    Private Sub RubroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RubroToolStripMenuItem.Click
        F_CargaRubros.Show()
        F_CargaRubros.GBSubRubro.Visible = False
        Me.Hide()
    End Sub

    Private Sub SubRubroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubRubroToolStripMenuItem.Click
        F_CargaRubros.Show()
        F_CargaRubros.GBRubro.Visible = False
        Me.Hide()
    End Sub


    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        F_BuscarSitio.Show()
        Me.Hide()
    End Sub

    Private Sub SitioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SitioToolStripMenuItem1.Click
        F_CargaSitio.Show()
        Me.Hide()
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        F_CargaPersona.Show()
        Me.Hide()
    End Sub
End Class
