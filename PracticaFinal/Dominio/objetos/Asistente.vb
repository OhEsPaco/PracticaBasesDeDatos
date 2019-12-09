Public Class Asistente
    Private Conferencia, Invest As Int32
    Sub New()

    End Sub
    Sub New(ByVal Conferencia As Int32, ByVal Invest As Int32)
        Me.Conferencia = Conferencia
        Me.Invest = Invest

    End Sub
    Property idConferencia As Int32
        Get
            Return Conferencia
        End Get
        Set(value As Int32)

        End Set
    End Property
    Property idInvest As Int32
        Get
            Return Invest
        End Get
        Set(value As Int32)

        End Set
    End Property

    Public Function eliminar() As Integer
        'Elimina una asistencia
        Dim asistente As Asistente = New Asistente(Conferencia, Invest)
        Dim gestor As gestorAsiste = New gestorAsiste()

        Return gestor.deleteAsist(asistente)

    End Function

    Public Function eliminarCoincidenciasConferencia(ByVal idConferencia As Int32) As Integer
        'Elimina las asistencias de una conferencia
        Dim asistente As Asistente = New Asistente(idConferencia, 0)
        Dim gestor As gestorAsiste = New gestorAsiste()

        Return gestor.deleteByCoincidenceConference(asistente)

    End Function

    Public Function insertar() As Integer
        'Inserta una asistencia
        Dim asistente As Asistente = New Asistente(Conferencia, Invest)
        Dim gestor As gestorAsiste = New gestorAsiste()
        Return gestor.insert(asistente)

    End Function

    Public Function leerTodos() As Collection
        'Retorna todas las asistencias
        Dim gestor As gestorAsiste = New gestorAsiste()
        Return gestor.getListaAsistentes
    End Function

    Public Function asistentesPorInvestigador(ByVal idInvest As Int32) As Collection
        'Retorna las asistencias de un investigador
        Dim gestor As gestorAsiste = New gestorAsiste()
        Return gestor.readByInvest(idInvest)
    End Function

    Public Function asistentesPorConferencia(ByVal idConf As Int32) As Collection
        'Retorna las asistencias a una conferencia
        Dim gestor As gestorAsiste = New gestorAsiste()
        Return gestor.readByConference(idConf)
    End Function

End Class
