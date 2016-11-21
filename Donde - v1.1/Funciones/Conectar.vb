Imports Oracle.DataAccess.Client ' Sentencia para importar la Clase OracleDataAcces

Public MustInherit Class ConexionBD

    Friend Accion As TipoAccion
    'Esquema Desconectado

    'Oracle.DataAcces.Client
    Protected Conexion As New OracleConnection
    Protected AdaptadorOA As OracleDataAdapter
    'Oracle.System.Data
    Protected RegistroDS As New DataSet
    Protected RegistroDR As DataRow
    Protected InsertCommand, UpdateCommand, DeleteCommand As OracleCommand
    Protected Transaction As OracleTransaction

    Public Overridable Function Conectar() As Boolean
        Dim Estado As Boolean = True
        Try
            Conexion.ConnectionString = ("Data Source=localhost;User Id=Donde;Password=123;")
        Catch ex As Exception
            MsgBox(ex.Message)
            Estado = False
        End Try
        Return Estado
    End Function
    Public MustOverride Sub Cargar_Tabla()
    Public Overridable Property CopiarRegistroDS() As DataSet
        Get
            Return RegistroDS
        End Get
        Set(ByVal value As DataSet)
            RegistroDS = value
        End Set
    End Property

End Class







