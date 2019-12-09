Imports System.Data.OleDb

Public Class gestorAsiste

    Sub New()

    End Sub
    Public Function deleteByCoincidenceInvest(ByVal idInvest As Int32) As Integer
        'Eliminamos todas las asistencias de un investigador
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("DELETE FROM ASISTE WHERE Invest =" & idInvest & ";")

        Return filasAfectadas

    End Function
    Public Function deleteByCoincidenceConference(ByVal idConference) As Integer
        'Eliminamos todas las asistencias a una conferencia
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("DELETE FROM ASISTE WHERE Conferencia =" & idConference & ";")

        Return filasAfectadas

    End Function
    Public Function deleteAsist(ByVal asistente As Asistente) As Integer
        'Eliminamos una asistencia concreta
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("DELETE FROM ASISTE WHERE Conferencia = " & asistente.idConferencia & " AND Invest = " & asistente.idInvest & ";")

        Return filasAfectadas

    End Function
    Public Function insert(ByVal asistente As Asistente) As Integer
        'Añadimos una nueva asistencia
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("INSERT INTO ASISTE (Conferencia,Invest) VALUES (" & asistente.idConferencia & "," & asistente.idInvest & ");")

        Return filasAfectadas
    End Function

    Public Function readByConference(ByVal idConferencia As Int32) As Collection
        'Leemos las asistencias a una conferencia
        Dim coleccion As Collection = New Collection()
        Dim reader As OleDbDataReader
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim asistente As Asistente = New Asistente()
        reader = Agente.leer("SELECT * FROM ASISTE WHERE Conferencia = " & idConferencia & " ORDER BY Conferencia;")
        If reader.HasRows Then

            Do While reader.Read()
                'Creamos aistencias y las añadimos a la colección mientras haya datos en el reader
                asistente = New Asistente(reader.GetInt32(0), reader.GetInt32(1))
                coleccion.Add(asistente, Convert.ToString(asistente.idInvest))
            Loop

        End If

        'Retornamos la colección
        Return coleccion

    End Function
    Public Function readByInvest(ByVal idInvest As Int32) As Collection
        'Leemos las asistencias de un investigador
        Dim coleccion As Collection = New Collection()
        Dim reader As OleDbDataReader
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim asistente As Asistente = New Asistente()
        reader = Agente.leer("SELECT * FROM ASISTE WHERE Invest = " & idInvest & " ORDER BY Invest;")
        If reader.HasRows Then

            Do While reader.Read()
                'Creamos asistencias y las añadimos a la colección mientras haya datos en el reader
                asistente = New Asistente(reader.GetInt32(0), reader.GetInt32(1))
                coleccion.Add(asistente, Convert.ToString(asistente.idConferencia))
            Loop

        End If
        '
        'Retornamos la colección
        Return coleccion

    End Function
    Public Function readAll(ByVal RutaBD As String) As Collection
        'Leemos todas las asistencias
        Dim Agente As AgenteBD = AgenteBD.getAgente(RutaBD)
        Dim reader As OleDbDataReader
        Dim asistente As Asistente
        Dim listaAsistentes As Collection = New Collection()

        'Vaciamos la lista de asistencias
        listaAsistentes = New Collection

        'Pedimos todas las asistencias ordenadas por conferencia
        reader = Agente.leer("SELECT * FROM ASISTE ORDER BY Conferencia;")

        'Si el reader no está vacio entramos en el bucle
        If reader.HasRows Then

            Do While reader.Read()
                'Creamos asistencias y las añadimos a la colección mientras haya datos en el reader
                asistente = New Asistente(reader.GetInt32(0), reader.GetInt32(1))
                listaAsistentes.Add(asistente)
            Loop

        End If

        'Retornamos la colección
        Return listaAsistentes

    End Function


    Public Property getListaAsistentes As Collection
        Get
            Return readAll("")
        End Get
        Set(value As Collection)

        End Set
    End Property
End Class
