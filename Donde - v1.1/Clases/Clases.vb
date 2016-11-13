Imports Oracle.DataAccess.Client ' Sentencia para importar la Clase OracleDataAcces

Public Enum TipoAccion As Byte 'Enumeracion para selecionar el tipo de accion a realizar por el usuario
    Alta = 1
    Modificacion = 2
    Baja = 3
End Enum




Public Class ConexionBD

    Friend Accion As TipoAccion
    'Friend IdPersona As Long

    'Esquema Desconectado

    'Oracle.DataAcces.Client
    Public Conexion As OracleConnection
    Dim AdaptadorOA As OracleDataAdapter
    'Oracle.System.Data
    Dim RegistroDS As New DataSet
    Dim RegistroDR As DataRow


    Public Function Conectar() As Boolean

        Dim Estado As Boolean = True

        Try
            Conexion = New OracleConnection("Data Source=localhost;User Id=Sitio;Password=123456789;")

        Catch ex As Exception
            MsgBox(ex.Message)
            Estado = False
        End Try

        Return Estado

    End Function

    Public Function Cargar_Tabla(Entidad_p As String, Tabla_p As String, Id_tabla_p As String) As Boolean

        Dim Estado As Boolean = True

        Try
            'Carga en Memoria Principal de la Tabla Persona_Cab
            AdaptadorOA = New OracleDataAdapter("Select * From " + Entidad_p, Conexion)
            AdaptadorOA.Fill(RegistroDS, Tabla_p)
            If Accion = TipoAccion.Alta Then
                RegistroDR = RegistroDS.Tables(Tabla_p).NewRow()
                RegistroDR(Id_tabla_p) = -1
            Else
                RegistroDR = RegistroDS.Tables(Tabla_p).Rows.Item(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Estado = False
        End Try

        Return Estado

    End Function


    Public Property CopiarRegistroDS() As DataSet
        Get
            Return RegistroDS
        End Get
        Set(ByVal value As DataSet)
            RegistroDS = value
        End Set
    End Property

End Class


Public Class BuscarDB

    'Atributos
    Dim OconexionBD As New ConexionBD
    Dim RegistroDV As New DataView


    'Metodos(Funciones y Procedimientos)

    Public Sub BuscarDatos()

        Try

            OconexionBD.Conectar()
            OconexionBD.Cargar_Tabla("Sitio_cab", "sitio_cab", "ID_SITIO")
            RegistroDV.Table = OconexionBD.CopiarRegistroDS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Public Property CopiarRegistroDV() As DataView
        Get
            Return RegistroDV
        End Get
        Set(ByVal value As DataView)
            RegistroDV = value
        End Set
    End Property



End Class