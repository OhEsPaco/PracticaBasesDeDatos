Imports System.Data.OleDb

Public Class gestorArticulos

    Private Shared listaArticulos As Collection = New Collection

    Sub New()

    End Sub

    Public Function delete(ByVal articulo As Articulo) As Integer
        'Elimina un articulo
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("DELETE FROM ARTICULOS WHERE idArticulo =" & articulo.IdArtic & ";")

        'Si hay mas de 0 filas afectadas entonces actualizamos la lista
        If filasAfectadas <> 0 Then
            listaArticulos.Remove(Convert.ToString(articulo.IdArtic))
            Dim gestor = New gestorAutor
            gestor.deleteByCoincidenceArticle(articulo.IdArtic)

        End If

        Return filasAfectadas
    End Function

    Public Function insert(ByVal articulo As Articulo) As Integer
        'Añade un articulo
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim idAsignado As Integer
        Dim reader As OleDbDataReader
        If articulo.PagFin < articulo.PagInicio Then
            Throw New InvalidEndPageException
        End If
        'Lo insertamos
        Agente.modificar("INSERT INTO ARTICULOS (Titulo,Conferencia,pag_inicio,pag_fin) VALUES ('" & articulo.TituloArticulo & "'," & articulo.IdConferencia & "," & articulo.PagInicio & "," & articulo.PagFin & ");")

        'Pedimos el ultimo autonumero asignado
        reader = Agente.leer("SELECT @@IDENTITY;")

        Do While reader.Read()
            idAsignado = reader.GetInt32(0)
        Loop

        'Asignamos el id definitivo
        articulo.IdArtic = idAsignado

        'Lo añadimos a la lista
        listaArticulos.Add(articulo, Convert.ToString(idAsignado))

        'Retornamos el id
        Return idAsignado

    End Function

    Public Function exists(ByVal idArtic As Int32) As Boolean
        'Comprobamos si existe en la lista
        Return listaArticulos.Contains(Convert.ToString(idArtic))
    End Function

    Public Function read(ByVal idArtic As Int32) As Articulo
        'Retornamos desde la colección
        Return listaArticulos.Item(Convert.ToString(idArtic))
    End Function

    Public Function readAll(ByVal RutaBD As String) As Collection
        Dim Agente As AgenteBD = AgenteBD.getAgente(RutaBD)
        Dim reader As OleDbDataReader
        Dim articulo As Articulo

        'Vaciamos la lista de personas
        listaArticulos = New Collection

        'Pedimos todas las personas ordenadas por DNI
        reader = Agente.leer("SELECT * FROM ARTICULOS ORDER BY idArticulo;")

        'Si el reader no está vacio entramos en el bucle
        If reader.HasRows Then

            Do While reader.Read()
                'Creamos personas y las añadimos a la colección mientras haya datos en el reader
                articulo = New Articulo(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4))
                listaArticulos.Add(articulo, Convert.ToString(articulo.IdArtic))
            Loop

        End If

        'Retornamos la colección
        Return listaArticulos

    End Function
    Public Function deleteByCoincidenceConference(ByVal idConf As Int32) As Integer
        'Elimina los articulos de una conferencia
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer
        Dim auxColeccion = New Collection
        Dim auxArticulo = New Articulo()
        Dim autor = New gestorAutor()

        filasAfectadas = Agente.modificar("DELETE FROM ARTICULOS WHERE Conferencia =" & idConf & ";")

        'Si se ha modificado mas de una fila podemos continuar
        If filasAfectadas <> 0 Then

            For i As Integer = 1 To listaArticulos.Count
                'Los articulos que no se correspondan con la conferencia eliminada los guardamos
                'y mandamos borrar los que pertenezcan a la conferencia eliminada
                auxArticulo = listaArticulos.Item(i)

                If auxArticulo.IdConferencia <> idConf Then
                    auxColeccion.Add(auxArticulo, Convert.ToString(auxArticulo.IdArtic))
                Else
                    autor.deleteByCoincidenceArticle(auxArticulo.IdArtic)
                End If

            Next

            'Actualizamos la listaArticulos
            listaArticulos = New Collection

            For i As Integer = 1 To auxColeccion.Count
                auxArticulo = auxColeccion.Item(i)
                listaArticulos.Add(auxArticulo, Convert.ToString(auxArticulo.IdArtic))
            Next
        End If

        'Retornamos las filas afectadas
        Return filasAfectadas

    End Function

    Public Function update(ByVal articulo As Articulo) As Integer
        'Actualiza un articulo en la base de datos
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer
        If articulo.PagFin < articulo.PagInicio Then
            Throw New InvalidEndPageException
        End If


        filasAfectadas = Agente.modificar("UPDATE ARTICULOS SET Titulo = '" & articulo.TituloArticulo & "', Conferencia = " & articulo.IdConferencia & ", pag_inicio = " & articulo.PagInicio & ", pag_fin = " & articulo.PagFin & " WHERE idArticulo = " & articulo.IdArtic & ";")

        'Actualizamos la coleccion
        If filasAfectadas <> 0 Then
            listaArticulos.Remove(Convert.ToString(articulo.IdArtic))
            listaArticulos.Add(articulo, Convert.ToString(articulo.IdArtic))

        End If

        Return filasAfectadas
    End Function

    Public Property getListaArticulos As Collection
        Get
            Return listaArticulos
        End Get
        Set(value As Collection)

        End Set
    End Property
End Class
