Imports System.Data.OleDb


Public Class AgenteBD


    'Variables de la clase
    Private Shared CadConexion As String = “Provider=Microsoft.ACE.OLEDB.12.0; Data Source=“
    Private Shared mConexion As OleDbConnection
    Private Shared mInstancia As AgenteBD = Nothing

    Private Sub New()

        'Constructor

        mConexion = New OleDbConnection(CadConexion)
        mConexion.Open()


    End Sub

    Public Shared Function getAgente(ByVal rutaBD As String) As AgenteBD
        'No es posible llamar al constructor porque es privado
        'así que hay que requerir una instancia de AgenteBD desde
        'aqui. 
        'Si no existe, la crea. Si existe, devuelve siempre la misma.

        If mInstancia Is Nothing Then
            CadConexion = CadConexion & rutaBD
            mInstancia = New AgenteBD()
        End If

        'Retornamos la instancia
        Return mInstancia

    End Function

    Public Function leer(ByVal sql As String) As OleDbDataReader

        'Ejecutamos una consulta de escritura
        Dim com As New OleDbCommand(sql, mConexion)

        'Retornamos un OleDbDataReader
        Return com.ExecuteReader()

    End Function

    Public Function modificar(ByVal sql As String) As Integer

        'Ejecutamos una consulta de escritura
        Dim com As New OleDbCommand(sql, mConexion)

        'Retornamos el numero de filas afectadas
        Return com.ExecuteNonQuery()

    End Function

End Class
