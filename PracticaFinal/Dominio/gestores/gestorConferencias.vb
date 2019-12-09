Imports System.Data.OleDb

Public Class gestorConferencias
    Private Shared listaConferencias As Collection = New Collection
    Sub New()

    End Sub
    Public Function delete(ByVal conferencia As Conferencia) As Integer
        'Elimina una conferencia, las entradas de asistente de esa conferencia y los articulos de esa conferencia
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer

        filasAfectadas = Agente.modificar("DELETE FROM CONFERENCIAS WHERE idConferencia =" & conferencia.IdConf & ";")
        If filasAfectadas <> 0 Then
            listaConferencias.Remove(Convert.ToString(conferencia.IdConf))
            Dim gestorAsist As gestorAsiste = New gestorAsiste
            gestorAsist.deleteByCoincidenceConference(conferencia.IdConf)

            Dim gestorArtic = New gestorArticulos
            gestorArtic.deleteByCoincidenceConference(conferencia.IdConf)


        End If
        Return filasAfectadas

    End Function

    Public Function insert(ByVal conferencia As Conferencia) As Integer
        'Inserta una conferencia y asigna un id
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim idAsignado As Integer
        Dim reader As OleDbDataReader
        If (conferencia.InicioConf > conferencia.FinConf) Then
            Throw New InvalidDateException()

        End If
        Agente.modificar("INSERT INTO CONFERENCIAS (Siglas, Nombre, Lugar, Fecha_inicio, Fecha_Fin) VALUES ('" & conferencia.SiglasConf & "','" & conferencia.NombreConf & "','" & conferencia.LugarConf & "','" & conferencia.InicioConf & "','" & conferencia.FinConf & "');")
        reader = Agente.leer("SELECT @@IDENTITY;")
        Do While reader.Read()
            idAsignado = reader.GetInt32(0)
        Loop
        conferencia.IdConf = idAsignado

        listaConferencias.Add(conferencia, Convert.ToString(idAsignado))

        Return idAsignado
    End Function
    Public Function exists(ByVal idConferencia As Int32) As Boolean
        'Retorna true si la conferencia existe
        Return listaConferencias.Contains(Convert.ToString(idConferencia))
    End Function
    Public Function read(ByVal idConferencia As Int32) As Conferencia

        'Retornamos desde la colección
        Return listaConferencias.Item(Convert.ToString(idConferencia))

    End Function
    Public Function readAll(ByVal RutaBD As String) As Collection
        'Actualiza la lista de conferencias y la retorna
        Dim Agente As AgenteBD = AgenteBD.getAgente(RutaBD)
        Dim reader As OleDbDataReader
        Dim conferencia As Conferencia

        'Vaciamos la lista de conferencias
        listaConferencias = New Collection

        'Pedimos todas las conferencias ordenadas por id
        reader = Agente.leer("SELECT * FROM CONFERENCIAS ORDER BY idConferencia;")

        'Si el reader no está vacio entramos en el bucle
        If reader.HasRows Then

            Do While reader.Read()
                'Creamos conferencia y las añadimos a la colección mientras haya datos en el reader
                conferencia = New Conferencia(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5))
                listaConferencias.Add(conferencia, Convert.ToString(conferencia.IdConf))
            Loop

        End If

        'Retornamos la colección
        Return listaConferencias

    End Function


    Public Function update(ByVal conferencia As Conferencia) As Integer
        'Actualiza una conferencia
        Dim Agente As AgenteBD = AgenteBD.getAgente("")
        Dim filasAfectadas As Integer
        If (conferencia.InicioConf > conferencia.FinConf) Then
            Throw New InvalidDateException()

        End If
        filasAfectadas = Agente.modificar("UPDATE CONFERENCIAS SET Siglas = '" & conferencia.SiglasConf & "',Nombre = '" & conferencia.NombreConf & "',Lugar = '" & conferencia.LugarConf & "', Fecha_inicio = " & conferencia.InicioConf & ",Fecha_fin = " & conferencia.FinConf & " WHERE idConferencia = " & conferencia.IdConf & ";")
        If filasAfectadas <> 0 Then
            listaConferencias.Remove(Convert.ToString(conferencia.IdConf))
            listaConferencias.Add(conferencia, Convert.ToString(conferencia.IdConf))
        End If
        Return filasAfectadas

    End Function

    Public Property getListaConferencias As Collection
        Get
            Return listaConferencias
        End Get
        Set(value As Collection)

        End Set
    End Property
End Class
