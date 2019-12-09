Imports System.Data.OleDb

Public Class gestorInvestigadores
    Private Shared listaInvestigadores As Collection = New Collection
    Sub New()

    End Sub
    Public Function delete(ByVal investigador As Investigador) As Integer
        'Elimina un investigador, sus entradas de autor y sus asistencias
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("DELETE FROM INVESTIGADORES WHERE idInvest =" & investigador.IdInvestigador & ";")
        If filasAfectadas <> 0 Then
            listaInvestigadores.Remove(Convert.ToString(investigador.IdInvestigador))
            Dim gestorAsistente As gestorAsiste = New gestorAsiste()
            gestorAsistente.deleteByCoincidenceInvest(investigador.IdInvestigador)
            Dim gestorAut As gestorAutor = New gestorAutor()
            gestorAut.deleteByCoincidenceInvest(investigador.IdInvestigador)
        End If
        Return filasAfectadas

    End Function

    Public Function insert(ByVal investigador As Investigador) As Integer
        'Inserta un autor y asigna una ID
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim idAsignado As Integer
        Dim reader As OleDbDataReader
        Agente.modificar("INSERT INTO INVESTIGADORES (Nombre,Apellidos,Despacho,Edificio,Departamento,Teléfono,Email) VALUES ('" & investigador.NombreInvestigador & "','" & investigador.ApellidosInvestigador & "','" & investigador.DespachoInvestigador & "','" & investigador.EdificioInvestigador & "','" & investigador.DepartamentoInvestigador & "','" & investigador.TelefonoInvestigador & "','" & investigador.EmailInvestigador & "');")

        reader = Agente.leer("SELECT @@IDENTITY;")
        Do While reader.Read()
            idAsignado = reader.GetInt32(0)
        Loop
        investigador.IdInvestigador = idAsignado
        listaInvestigadores.Add(investigador, Convert.ToString(idAsignado))

        Return idAsignado
    End Function
    Public Function exists(ByVal idInvest As Int32) As Boolean
        'Retorna true si el investigador existe
        Return listaInvestigadores.Contains(Convert.ToString(idInvest))
    End Function
    Public Function read(ByVal idInvest As Int32) As Investigador

        'Retornamos desde la colección
        Return listaInvestigadores.Item(Convert.ToString(idInvest))

    End Function
    Public Function readAll(ByVal RutaBD As String) As Collection
        'Actualiza la lista de investigadores y la retorna
        Dim Agente As AgenteBD = AgenteBD.getAgente(RutaBD)
        Dim reader As OleDbDataReader
        Dim investigador As Investigador

        'Vaciamos la lista de investigadores
        listaInvestigadores = New Collection

        'Pedimos todas los investigadores ordenados por id
        reader = Agente.leer("SELECT * FROM INVESTIGADORES ORDER BY idInvest;")

        'Si el reader no está vacio entramos en el bucle
        If reader.HasRows Then

            Do While reader.Read()
                'Creamos investigadores y los añadimos a la colección mientras haya datos en el reader
                investigador = New Investigador(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7))
                listaInvestigadores.Add(investigador, Convert.ToString(investigador.IdInvestigador))
            Loop

        End If

        'Retornamos la colección
        Return listaInvestigadores

    End Function


    Public Function update(ByVal investigador As Investigador) As Integer
        'Actualizamos un investigador
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("UPDATE INVESTIGADORES SET Nombre = '" & investigador.NombreInvestigador & "', Apellidos = '" & investigador.ApellidosInvestigador & "', Despacho = '" & investigador.DespachoInvestigador & "', Edificio = '" & investigador.EdificioInvestigador & "', Departamento = '" & investigador.DepartamentoInvestigador & "', Teléfono = '" & investigador.TelefonoInvestigador & "', Email = '" & investigador.EmailInvestigador & "' WHERE idInvest = " & investigador.IdInvestigador & ";")
        If filasAfectadas <> 0 Then
            listaInvestigadores.Remove(Convert.ToString(investigador.IdInvestigador))
            listaInvestigadores.Add(investigador, Convert.ToString(investigador.IdInvestigador))

        End If
        Return filasAfectadas

    End Function

    Public Property getListaInvestigadores As Collection
        Get
            Return listaInvestigadores
        End Get
        Set(value As Collection)

        End Set
    End Property
End Class
