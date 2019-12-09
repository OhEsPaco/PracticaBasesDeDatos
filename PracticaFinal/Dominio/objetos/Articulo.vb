Public Class Articulo
    Private idArticulo As Int32
    Private Conferencia As Int32
    Private pag_inicio As Int32
    Private pag_fin As Int32
    Private Titulo As String
    Sub New()

    End Sub
    Sub New(ByVal idArticulo As Int32, ByVal Titulo As String, ByVal Conferencia As Int32, ByVal pag_inicio As Int32, ByVal pag_fin As Int32)
        Me.idArticulo = idArticulo
        Me.Titulo = Titulo
        Me.Conferencia = Conferencia
        Me.pag_inicio = pag_inicio
        Me.pag_fin = pag_fin
    End Sub

    Property IdArtic As Int32
        Get
            Return idArticulo
        End Get
        Set(value As Int32)
            idArticulo = value
        End Set
    End Property
    Property TituloArticulo As String
        Get
            Return Titulo
        End Get
        Set(value As String)

        End Set
    End Property
    Property IdConferencia As Int32
        Get
            Return Conferencia
        End Get
        Set(value As Int32)

        End Set
    End Property
    Property PagInicio As Int32
        Get
            Return pag_inicio
        End Get
        Set(value As Int32)

        End Set
    End Property
    Property PagFin As Int32
        Get
            Return pag_fin
        End Get
        Set(value As Int32)

        End Set
    End Property



    Public Function eliminar() As Integer
        'Elimina un articulo y las entradas en la tabla de autor para ese articulo
        Dim artic As Articulo = New Articulo(idArticulo, Titulo, Conferencia, pag_inicio, pag_fin)
        Dim gestor As gestorArticulos = New gestorArticulos()

        Return gestor.delete(artic)
    End Function
    Public Function insertar() As Integer
        'Inserta un articulo
        Dim artic As Articulo = New Articulo(idArticulo, Titulo, Conferencia, pag_inicio, pag_fin)
        Dim gestor As gestorArticulos = New gestorArticulos()


        idArticulo = gestor.insert(artic)

        Return idArticulo
    End Function
    Public Function modificar() As Integer
        'Modifica un articulo
        Dim artic As Articulo = New Articulo(idArticulo, Titulo, Conferencia, pag_inicio, pag_fin)
        Dim gestor As gestorArticulos = New gestorArticulos()


        Return gestor.update(artic)
    End Function
    Public Function notNull() As Boolean
        'Comprueba que ciertos campos no sean null
        Dim isNull As Boolean = False

        If Titulo = "" Then
            isNull = True

        End If

        Return isNull
    End Function
    Public Function leerArticulo(ByVal idArtic As Int32) As Articulo
        'retorna un articulo por su id
        Dim gestor As gestorArticulos = New gestorArticulos()
        Return gestor.read(idArtic)

    End Function
    Public Function leerTodos() As Collection
        'Retorna todos los articulos
        Dim gestor As gestorArticulos = New gestorArticulos()
        Return gestor.getListaArticulos
    End Function
    Public Function cargarTodos(ByVal rutaBD As String) As Collection
        'Carga todos los articulos. Se le puede pasar la ruta de la base de datos si
        'no se pasó ya.
        Dim gestor As gestorArticulos = New gestorArticulos()
        Return gestor.readAll(rutaBD)
    End Function
    Public Function existe(ByVal idArtic As Int32) As Boolean
        Dim gestor As gestorArticulos = New gestorArticulos()
        Return gestor.exists(idArtic)
    End Function

End Class
