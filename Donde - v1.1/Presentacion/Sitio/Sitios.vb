Imports Oracle.DataAccess.Client
Public Class Sitios
    Inherits ConexionBD
    Private Nombre As String
    Private F_Alta, F_Baja As Date
    Dim Rela_RuBro As ComboBox
    Dim NewId As Long
    Public Overrides Sub Cargar_Tabla()
        AdaptadorOA = New OracleDataAdapter("Select * From Sitio_cab Where Id_Sitio = " + F_Donde.IdSitio.ToString, Conexion)
        AdaptadorOA.Fill(RegistroDS, "Sitio_cab")
        If F_Donde.Accion = TipoAccion.Alta Then
            RegistroDR = RegistroDS.Tables("Sitio_cab").NewRow()
            RegistroDR("Id_Sitio") = -1
        Else
            RegistroDR = RegistroDS.Tables("Sitio_cab").Rows.Item(0)
        End If

        Nombre = RegistroDR("SITIO_NOMBES").ToString
        F_Alta = IIf(IsDBNull(RegistroDR("F_ALTA")), Date.Now, RegistroDR("F_ALTA"))
        Rela_RuBro.SelectedIndex = IIf(IsDBNull(RegistroDR("RELA_RUBRO")), -1, RegistroDR("RELA_RUBRO"))

    End Sub

    Public Sub Agregar_Sitio()

        RegistroDR("SITIO_NOMBRES") = Nombre
        RegistroDR("F_ALTA") = F_Alta
        RegistroDR("RELA_RUBRO") = (Rela_RuBro.SelectedIndex)

        If F_Donde.Accion = TipoAccion.Alta Then
            RegistroDS.Tables("Sitio_cab").Rows.Add(RegistroDR)
        ElseIf F_Donde.Accion = TipoAccion.Baja Then
            RegistroDS.Tables("Sitio_cab").Rows.Remove(RegistroDR)
        End If
        Try
            Conexion.Open()
            Transaction = Conexion.BeginTransaction(IsolationLevel.ReadCommitted)
            InsertCommand.Connection = Conexion
            InsertCommand.Transaction = Transaction
            With InsertCommand
                'Ejecuto el Insert de Persona
                .CommandType = CommandType.StoredProcedure
                .CommandText = "PA_INSERT_SITIO"
                .Parameters.Clear()
                .Parameters.Add(New OracleParameter("pSitio_nombres", OracleDbType.Varchar2) With {.Value = RegistroDR("SITIO_NOMBRES")})
                .Parameters.Add(New OracleParameter("F_alta", OracleDbType.Varchar2) With {.Value = RegistroDR("F_ALTA")})
                .Parameters.Add(New OracleParameter("Rela_rubro", OracleDbType.Varchar2) With {.Value = RegistroDR("RELA_RUBRO")})
                .Parameters.Add(New OracleParameter("last_id", OracleDbType.Int32, ParameterDirection.Output))
                .ExecuteNonQuery()
                MsgBox(.Parameters("last_id").Value)
                NewId = Long.Parse(.Parameters("last_id").Value.ToString)
            End With

            InsertCommand.Connection = Conexion
            Transaction.Commit()
        Catch ex As Exception
            Transaction.Rollback()
            MsgBox(ex.Message)
        Finally
            Conexion.Close()
        End Try
        AdaptadorOA.InsertCommand = InsertCommand

    End Sub
    Public Sub ListarSitios(Lista_Registro As DataGridView)
        Conectar()
        Try
            AdaptadorOA = New OracleDataAdapter("Select * From Sitio_cab", Conexion)
            AdaptadorOA.Fill(RegistroDS, "Sitio_cab")
            Lista_Registro.DataSource = RegistroDS.Tables("Sitio_cab")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

End Class
