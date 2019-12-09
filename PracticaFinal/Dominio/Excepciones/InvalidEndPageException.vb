Imports System
Public Class InvalidEndPageException
    'Excepcion si la pagina de fin es menor que la de inicio
    Inherits Exception

    Public Sub New()
    End Sub

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub

    Public Sub New(message As String, inner As Exception)
        MyBase.New(message, inner)
    End Sub
End Class
