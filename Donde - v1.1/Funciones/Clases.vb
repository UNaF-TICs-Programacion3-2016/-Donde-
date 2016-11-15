Imports Oracle.DataAccess.Client ' Sentencia para importar la Clase OracleDataAcces


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

    Public Function Cargar_Tabla_Sitio(Entidad_p As String, Tabla_p As String, Id_tabla_p As String, NombreSitioa As TextBox, DtpFAltaa As DateTimePicker) As Boolean

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

            NombreSitioa.Text = RegistroDR("SITIO_NOMBRES").ToString
            'CmbRubroa.SelectedIndex = IIf(IsDBNull(Registro("RUBRO")), -1, Registro("RUBRO"))
            'CmbTipoa.SelectedItem = IIf(IsDBNull(Registro("TIPOR")), -1, Registro("TIPOR"))
            DtpFAltaa.Value = IIf(IsDBNull(RegistroDR("F_ALTA")), Date.Now, RegistroDR("F_ALTA"))

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

Public Class Datos_CEstado

    Private Num1, Num2, Num3 As Integer
    Private Str1, Str2, Str3 As String
    Private Cmb1, Cmb2, Cmb3 As ComboBox
    Private Dtp1 As DateTimePicker

    'Metodos de Accesos a los Atributos

    'Camdio de estado al atributo Numerico

    Public Property CEstadoNum1() As Integer

        Get
            Return Num1
        End Get

        Set(ByVal value As Integer)
            Num1 = value
        End Set
    End Property

    'Camdio de estado al atributo Numerico

    Public Property CEstadoNum2() As Integer

        Get
            Return Num2
        End Get

        Set(ByVal value As Integer)
            Num2 = value
        End Set
    End Property

    'Camdio de estado al atributo Numerico

    Public Property CEstadoNum3() As Integer

        Get
            Return Num3
        End Get

        Set(ByVal value As Integer)
            Num3 = value
        End Set
    End Property

    'Camdio de estado al atributo String

    Public Property CEstadoStr1() As String

        Get
            Return Str1
        End Get

        Set(ByVal value As String)
            Str1 = value
        End Set
    End Property

    'Camdio de estado al atributo String

    Public Property CEstadoStr2() As String

        Get
            Return Str2
        End Get

        Set(ByVal value As String)
            Str2 = value
        End Set
    End Property

    'Camdio de estado al atributo String

    Public Property CEstadoStr3() As String

        Get
            Return Str3
        End Get

        Set(ByVal value As String)
            Str3 = value
        End Set
    End Property

    'Camdio de estado al atributo ComboBox

    Public Property CEstadoCmb1() As ComboBox

        Get
            Return Cmb1
        End Get

        Set(ByVal value As ComboBox)
            Cmb1 = value
        End Set

    End Property


    'Camdio de estado al atributo ComboBox

    Public Property CEstadoCmb2() As ComboBox

        Get
            Return Cmb2
        End Get

        Set(ByVal value As ComboBox)
            Cmb2 = value
        End Set

    End Property

    'Camdio de estado al atributo ComboBox

    Public Property CEstadoCmb3() As ComboBox

        Get
            Return Cmb3
        End Get

        Set(ByVal value As ComboBox)
            Cmb3 = value
        End Set

    End Property

    'Camdio de estado al atributo DateTimerPicker

    Public Property CEstadoDtp1() As DateTimePicker

        Get
            Return Dtp1
        End Get

        Set(ByVal value As DateTimePicker)
            Dtp1 = value
        End Set

    End Property





End Class

