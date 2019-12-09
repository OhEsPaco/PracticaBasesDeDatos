Public Class Conferencia
    Private idConferencia As Int32
    Private Fecha_inicio, Fecha_Fin As Date
    Private Siglas, Nombre, Lugar As String
    Sub New()

    End Sub
    Sub New(ByVal idConferencia As Int32, ByVal Siglas As String, ByVal Nombre As String, ByVal Lugar As String, ByVal Fecha_inicio As Date, ByVal Fecha_fin As Date)
        Me.idConferencia = idConferencia
        Me.Siglas = Siglas
        Me.Nombre = Nombre
        Me.Lugar = Lugar
        Me.Fecha_inicio = Fecha_inicio
        Me.Fecha_Fin = Fecha_fin
    End Sub
    Property IdConf As Int32
        Get
            Return idConferencia
        End Get
        Set(value As Int32)
            idConferencia = value
        End Set
    End Property
    Property SiglasConf As String
        Get
            Return Siglas
        End Get
        Set(value As String)

        End Set
    End Property
    Property NombreConf As String
        Get
            Return Nombre
        End Get
        Set(value As String)

        End Set
    End Property
    Property LugarConf As String
        Get
            Return Lugar
        End Get
        Set(value As String)

        End Set
    End Property
    Property InicioConf As Date
        Get
            Return Fecha_inicio
        End Get
        Set(value As Date)

        End Set
    End Property
    Property FinConf As Date
        Get
            Return Fecha_Fin
        End Get
        Set(value As Date)

        End Set
    End Property
    Public Function eliminar() As Integer
        'Elimina una conferencia
        Dim conf As Conferencia = New Conferencia(idConferencia, Siglas, Nombre, Lugar, Fecha_inicio, Fecha_Fin)
        Dim gestor As gestorConferencias = New gestorConferencias()


        Return gestor.delete(conf)
    End Function
    Public Function insertar() As Integer
        'Inserta una conferencia
        Dim conf As Conferencia = New Conferencia(idConferencia, Siglas, Nombre, Lugar, Fecha_inicio, Fecha_Fin)
        Dim gestor As gestorConferencias = New gestorConferencias()
        idConferencia = gestor.insert(conf)
        Return idConferencia
    End Function
    Public Function modificar() As Integer
        'Actualiza una conferencia
        Dim conf As Conferencia = New Conferencia(idConferencia, Siglas, Nombre, Lugar, Fecha_inicio, Fecha_Fin)
        Dim gestor As gestorConferencias = New gestorConferencias()
        Return gestor.update(conf)
    End Function
    Public Function leerConferencia(ByVal idConferencia As Int32) As Conferencia
        'Devuelve una conferencia a partir de su id
        Dim gestor As gestorConferencias = New gestorConferencias()
        Return gestor.read(idConferencia)

    End Function
    Public Function leerTodos() As Collection
        'Lee todas las conferencias
        Dim gestor As gestorConferencias = New gestorConferencias()
        Return gestor.getListaConferencias
    End Function
    Public Function cargarTodos(ByVal rutaBD As String) As Collection
        'Carga las conferencias 
        Dim gestor As gestorConferencias = New gestorConferencias()
        Return gestor.readAll(rutaBD)
    End Function
    Public Function existe(ByVal idConferencia As Int32) As Boolean
        'Retorna true si la conferencia existe
        Dim gestor As gestorConferencias = New gestorConferencias()
        Return gestor.exists(idConferencia)
    End Function
    Public Function notNull() As Boolean
        'Comprueba que ciertos campos no sean null
        Dim isNull As Boolean = False

        If Siglas = "" Then
            isNull = True
        ElseIf Nombre = "" Then
            isNull = True
        ElseIf Lugar = "" Then
            isNull = True
        End If

        Return isNull
    End Function
End Class
