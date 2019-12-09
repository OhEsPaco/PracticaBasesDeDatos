Public Class Autor
    Dim Invest, Articulo, Orden As Int32
    Sub New()

    End Sub
    Sub New(ByVal Invest As Int32, ByVal Articulo As Int32, ByVal Orden As Int32)
        Me.Invest = Invest
        Me.Articulo = Articulo
        Me.Orden = Orden
    End Sub
    Property idInvestigador As Int32
        Get
            Return Invest
        End Get
        Set(value As Int32)

        End Set
    End Property
    Property idArticulo As Int32
        Get
            Return Articulo
        End Get
        Set(value As Int32)

        End Set
    End Property
    Property OrdenAutor As Int32
        Get
            Return Orden
        End Get
        Set(value As Int32)
            Orden = value
        End Set
    End Property


    Public Function eliminar() As Integer
        'Elimina la entrada de autor
        Dim autor As Autor = New Autor(Invest, Articulo, Orden)
        Dim gestor As gestorAutor = New gestorAutor()

        Return gestor.deleteAutor(autor)

    End Function

    Public Function actualizar() As Integer
        'Actualiza la entrada de autor
        Dim autor As Autor = New Autor(Invest, Articulo, Orden)
        Dim gestor As gestorAutor = New gestorAutor()

        Return gestor.update(autor)
    End Function


    Public Function eliminarCoincidenciasArticulo(ByVal idArticulo As Int32) As Integer
        'Elimina las entradas de autor de un articulo
        Dim gestor As gestorAutor = New gestorAutor()

        Return gestor.deleteByCoincidenceArticle(idArticulo)

    End Function

    Public Function insertar() As Integer
        'Inserta una entrada de autor
        Dim autor As Autor = New Autor(Invest, Articulo, Orden)
        Dim gestor As gestorAutor = New gestorAutor()
        Orden = gestor.insert(autor)
        Return Orden
    End Function

    Public Function leerTodos() As Collection
        'Lee todas las entradas de autor
        Dim gestor As gestorAutor = New gestorAutor()
        Return gestor.getListaAutores
    End Function

    Public Function autoresPorInvestigador(ByVal idInvest As Int32) As Collection
        'Retorna las entradas de autor de un investigador
        Dim gestor As gestorAutor = New gestorAutor()
        Return gestor.readByInvest(idInvest)
    End Function

    Public Function autoresPorArticulo(ByVal idArticulo As Int32) As Collection
        'Retorna las entradas de autor de un articulo
        Dim gestor As gestorAutor = New gestorAutor()
        Return gestor.readByArticle(idArticulo)
    End Function

    Public Function arribaOrdenAutor(ByVal idInvest As Int32, ByVal idArticulo As Int32) As Integer
        'Avanza en una posicion el autor del id que recibe en el articulo dado
        Dim autor As Autor = New Autor
        Dim autorAux As Autor = New Autor

        Dim autores As Collection
        autores = autor.autoresPorArticulo(idArticulo)

        If autores.Count > 1 Then
            autor = autores.Item(Convert.ToString(idInvest))

            If autor.OrdenAutor > 1 Then

                For i As Integer = 1 To autores.Count
                    autorAux = autores.Item(i)
                    If autorAux.OrdenAutor = autor.OrdenAutor - 1 Then
                        Exit For
                    End If
                Next

                autor.OrdenAutor = autor.OrdenAutor - 1
                autorAux.OrdenAutor = autorAux.OrdenAutor + 1
                autor.actualizar()
                autorAux.actualizar()

            End If
        End If

        Return autor.OrdenAutor - 1
    End Function
    Public Function abajoOrdenAutor(ByVal idInvest As Int32, ByVal idArticulo As Int32) As Integer
        'Retrocede en una posicion el autor del id que recibe en el articulo dado
        Dim autor As Autor = New Autor
        Dim autorAux As Autor = New Autor

        Dim autores As Collection
        autores = autor.autoresPorArticulo(idArticulo)

        If autores.Count > 1 Then
            autor = autores.Item(Convert.ToString(idInvest))

            If autor.OrdenAutor < autores.Count Then

                For i As Integer = 1 To autores.Count
                    autorAux = autores.Item(i)
                    If autorAux.OrdenAutor = autor.OrdenAutor + 1 Then
                        Exit For
                    End If
                Next

                autor.OrdenAutor = autor.OrdenAutor + 1
                autorAux.OrdenAutor = autorAux.OrdenAutor - 1
                autor.actualizar()
                autorAux.actualizar()

            End If
        End If
        Return autor.OrdenAutor - 1
    End Function

End Class
