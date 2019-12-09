Imports System.Data.OleDb

Public Class gestorAutor
    Sub New()

    End Sub

    Public Function deleteByCoincidenceInvest(ByVal idInvest As Int32) As Integer
        'Elimina un autor y actualiza los ordenes de los autores de los articulos donde aparezca 
        'este autor
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer
        Dim reader As OleDbDataReader
        Dim orden As Integer = 1
        Dim coleccion As Collection = readByInvest(idInvest)
        Dim auxAutor As Autor = New Autor()
        filasAfectadas = Agente.modificar("DELETE FROM AUTOR WHERE Invest =" & idInvest & ";")

        For i As Integer = 1 To coleccion.Count

            auxAutor = coleccion.Item(i)
            reader = Agente.leer("SELECT * FROM AUTOR WHERE Articulo = " & auxAutor.idArticulo & " ORDER BY Orden;")
            If reader.HasRows Then

                Do While reader.Read()
                    Agente.modificar("UPDATE AUTOR SET Orden = " & orden & " WHERE Invest = " & reader.GetInt32(0) & " AND Articulo = " & reader.GetInt32(1) & " AND Orden = " & reader.GetInt32(2) & ";")
                    orden = orden + 1

                Loop

            End If

            orden = 1

        Next

        Return filasAfectadas

    End Function

    Public Function update(ByVal autor As Autor) As Integer
        'Actualiza un autor en la base de datos
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("UPDATE AUTOR SET Orden = " & autor.OrdenAutor & " WHERE Invest = " & autor.idInvestigador & " AND Articulo = " & autor.idArticulo & ";")


        Return filasAfectadas
    End Function

    Public Function readByInvest(ByVal idInvest As Int32) As Collection
        'Retorna las entradas de autor correspondientes a un investigador
        Dim coleccion As Collection = New Collection()
        Dim reader As OleDbDataReader
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim autor = New Autor()
        reader = Agente.leer("SELECT * FROM AUTOR WHERE Invest = " & idInvest & " ORDER BY Invest;")
        If reader.HasRows Then

            Do While reader.Read()
                'Creamos autores y los añadimos a la colección mientras haya datos en el reader
                autor = New Autor(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2))
                coleccion.Add(autor, Convert.ToString(autor.idArticulo))
            Loop

        End If

        'Retornamos desde la colección
        Return coleccion
    End Function

    Public Function readByArticle(ByVal idArticulo As Int32) As Collection
        'Retorna las entradas de autor que contengan un articulo concreto
        Dim coleccion As Collection = New Collection()
        Dim reader As OleDbDataReader
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim autor As Autor = New Autor()
        reader = Agente.leer("SELECT * FROM AUTOR WHERE Articulo = " & idArticulo & " ORDER BY Orden;")
        If reader.HasRows Then

            Do While reader.Read()
                'Creamos autores y los añadimos a la colección mientras haya datos en el reader
                autor = New Autor(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2))
                coleccion.Add(autor, Convert.ToString(autor.idInvestigador))
            Loop

        End If
        '
        'Retornamos desde la colección
        Return coleccion

    End Function

    Public Function readAll(ByVal RutaBD As String) As Collection
        'Retorna todas las entradas de autor
        Dim Agente As AgenteBD = AgenteBD.getAgente(RutaBD)
        Dim reader As OleDbDataReader
        Dim autor As Autor = New Autor()
        Dim listaAutores As Collection = New Collection()

        'Pedimos todas los autores ordenados por investigador
        reader = Agente.leer("SELECT * FROM AUTOR ORDER BY Invest;")

        'Si el reader no está vacio entramos en el bucle
        If reader.HasRows Then

            Do While reader.Read()
                'Creamos autores y los añadimos a la colección mientras haya datos en el reader
                autor = New Autor(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2))
                listaAutores.Add(autor)
            Loop

        End If

        'Retornamos la colección
        Return listaAutores

    End Function
    Public Function deleteByCoincidenceArticle(ByVal idArticulo As Int32) As Integer
        'Eliminamos todas las entradas de autor de un articulo
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("DELETE FROM AUTOR WHERE Articulo =" & idArticulo & ";")

        Return filasAfectadas

    End Function

    Public Function deleteAutor(ByVal autor As Autor) As Integer
        'Elimina una entrada de autor concreta y actualiza el resto de los autores
        'de ese articulo
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer
        Dim orden As Integer = 1
        Dim reader As OleDbDataReader

        filasAfectadas = Agente.modificar("DELETE FROM AUTOR WHERE Invest = " & autor.idInvestigador & " AND Articulo = " & autor.idArticulo & ";")

        reader = Agente.leer("SELECT * FROM AUTOR WHERE Articulo = " & autor.idArticulo & " ORDER BY Orden;")
        If reader.HasRows Then

            Do While reader.Read()
                Agente.modificar("UPDATE AUTOR SET Orden = " & orden & " WHERE Invest = " & reader.GetInt32(0) & " AND Articulo = " & reader.GetInt32(1) & " AND Orden = " & reader.GetInt32(2) & ";")
                orden = orden + 1

            Loop

        End If



        Return filasAfectadas
    End Function

    Public Function insert(ByVal autor As Autor) As Integer
        'Inserta y añade un id a una entrada de autor
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim orden As Integer = 1
        Dim reader As OleDbDataReader
        reader = Agente.leer("SELECT COUNT (Articulo) FROM AUTOR WHERE Articulo = " & autor.idArticulo & ";")
        If reader.HasRows Then

            Do While reader.Read()

                orden = reader.GetInt32(0) + 1

            Loop

        End If

        Agente.modificar("INSERT INTO AUTOR (Invest, Articulo, Orden) VALUES (" & autor.idInvestigador & ", " & autor.idArticulo & ", " & orden & ");")

        Return orden
    End Function
    Public Property getListaAutores As Collection
        Get
            Return readAll("")
        End Get
        Set(value As Collection)

        End Set
    End Property
End Class
