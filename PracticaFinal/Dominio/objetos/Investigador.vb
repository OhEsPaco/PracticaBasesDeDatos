Public Class Investigador
    Private idInvest As Int32
    Private Nombre, Apellidos, Despacho, Edificio, Departamento, Telefono, Email As String
    Sub New()

    End Sub
    Sub New(ByVal idInvest As Int32, ByVal Nombre As String, ByVal Apellidos As String, ByVal Despacho As String, ByVal Edificio As String, ByVal Departamento As String, ByVal Telefono As String, ByVal Email As String)

        Me.idInvest = idInvest
        Me.Nombre = Nombre
        Me.Apellidos = Apellidos
        Me.Despacho = Despacho
        Me.Edificio = Edificio
        Me.Departamento = Departamento
        Me.Telefono = Telefono
        Me.Email = Email

    End Sub

    Property IdInvestigador As Int32
        Get
            Return idInvest
        End Get
        Set(value As Int32)
            idInvest = value
        End Set
    End Property
    Property NombreInvestigador As String
        Get
            Return Nombre
        End Get
        Set(value As String)

        End Set
    End Property
    Property ApellidosInvestigador As String
        Get
            Return Apellidos
        End Get
        Set(value As String)

        End Set
    End Property
    Property DespachoInvestigador As String
        Get
            Return Despacho
        End Get
        Set(value As String)

        End Set
    End Property
    Property EdificioInvestigador As String
        Get
            Return Edificio
        End Get
        Set(value As String)

        End Set
    End Property
    Property DepartamentoInvestigador As String
        Get
            Return Departamento
        End Get
        Set(value As String)

        End Set
    End Property
    Property TelefonoInvestigador As String
        Get
            Return Telefono
        End Get
        Set(value As String)

        End Set
    End Property
    Property EmailInvestigador As String
        Get
            Return Email
        End Get
        Set(value As String)

        End Set
    End Property
    Public Function eliminar() As Integer
        'Elimina un investigador
        Dim invest As Investigador = New Investigador(idInvest, Nombre, Apellidos, Despacho, Edificio, Departamento, Telefono, Email)
        Dim gestor As gestorInvestigadores = New gestorInvestigadores()

        Return gestor.delete(invest)


    End Function
    Public Function insertar() As Integer
        'Inserta un investigador
        Dim invest As Investigador = New Investigador(idInvest, Nombre, Apellidos, Despacho, Edificio, Departamento, Telefono, Email)
        Dim gestor As gestorInvestigadores = New gestorInvestigadores()

        Return gestor.insert(invest)
    End Function
    Public Function modificar() As Integer
        'Modifica un investigador
        Dim invest As Investigador = New Investigador(idInvest, Nombre, Apellidos, Despacho, Edificio, Departamento, Telefono, Email)
        Dim gestor As gestorInvestigadores = New gestorInvestigadores()

        Return gestor.update(invest)
    End Function
    Public Function notNull() As Boolean
        'Comprueba que ciertos campos no sean null
        Dim isNull As Boolean = False

        If Nombre = "" Then
            isNull = True
        ElseIf Apellidos = "" Then
            isNull = True
        ElseIf Despacho = "" Then
            isNull = True
        ElseIf Edificio = "" Then
            isNull = True
        ElseIf Departamento = "" Then
            isNull = True
        ElseIf Telefono = "" Then
            isNull = True
        ElseIf Email = "" Then
            isNull = True

        End If

        Return isNull
    End Function
    Public Function leerInvestigador(ByVal idInvest As Int32) As Investigador
        'Retorna un investigador por un id
        Dim gestor As gestorInvestigadores = New gestorInvestigadores()
        Return gestor.read(idInvest)

    End Function
    Public Function leerTodos() As Collection
        'Retorna todos los investigadores
        Dim gestor As gestorInvestigadores = New gestorInvestigadores()
        Return gestor.getListaInvestigadores
    End Function
    Public Function cargarTodos(ByVal rutaBD As String) As Collection
        'Carga los investigadores
        Dim gestor As gestorInvestigadores = New gestorInvestigadores()
        Return gestor.readAll(rutaBD)
    End Function
    Public Function existe(ByVal idInvest As Int32) As Boolean
        'Devuelve true si el id corresponde a algun investigador
        Dim gestor As gestorInvestigadores = New gestorInvestigadores()
        Return gestor.exists(idInvest)
    End Function
End Class
