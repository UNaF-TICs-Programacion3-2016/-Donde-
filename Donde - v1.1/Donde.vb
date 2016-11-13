


Public Class F_Donde
    'Atributos

    Dim OconexionDB As New ConexionBD

    'Metodos (unciones y Procedimientos)

    Private Sub F_Donde_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If OconexionDB.Conectar Then
            MsgBox("Conectado")
            OconexionDB.Cargar_Tabla("Sitio_cab", "sitio_cab", "ID_SITIO")
            MsgBox("Tabla Cargada con Exito")
        Else
            MsgBox("No Conectado")
        End If

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


End Class
