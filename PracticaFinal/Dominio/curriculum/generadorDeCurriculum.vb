Public Class generadorDeCurriculum
    Private idInvest As Int32
    Private curriculum As Collection
    Sub New()


    End Sub

    Public Function generarCurriculum(ByVal idInvest As Int32) As Collection
        curriculum = New Collection()
        Me.idInvest = idInvest

        datosPersonales()
        relacionDeConferencias()
        relacionDeArticulos()


        Return curriculum
    End Function
    Private Sub datosPersonales()
        Dim invest = New Investigador()
        invest = invest.leerInvestigador(idInvest)


        curriculum.Add("Nombre: " & invest.NombreInvestigador)
        curriculum.Add("Apellidos: " & invest.ApellidosInvestigador)
        curriculum.Add("Despacho: " & invest.DespachoInvestigador)
        curriculum.Add("Edificio: " & invest.EdificioInvestigador)
        curriculum.Add("Departamento: " & invest.DepartamentoInvestigador)
        curriculum.Add("Teléfono: " & invest.TelefonoInvestigador)
        curriculum.Add("Email: " & invest.EmailInvestigador)
        curriculum.Add("")

    End Sub

    Private Sub relacionDeConferencias()
        Dim asistente = New Asistente()
        Dim conferencia = New Conferencia()
        Dim asistenteA As Collection = New Collection()

        asistenteA = asistente.asistentesPorInvestigador(idInvest)

        If asistenteA.Count = 0 Then
            curriculum.Add("No ha asistido a ninguna conferencia.")
            curriculum.Add("")
        Else
            For Each asistente In asistenteA
                conferencia = conferencia.leerConferencia(asistente.idConferencia)

                curriculum.Add("Siglas de la conferencia: " & conferencia.SiglasConf)
                curriculum.Add("Nombre de la conferencia: " & conferencia.NombreConf)
                curriculum.Add("Lugar de la conferencia: " & conferencia.LugarConf)
                curriculum.Add("Inicio de la conferencia: " & conferencia.InicioConf)
                curriculum.Add("Final de la conferencia: " & conferencia.FinConf)
                curriculum.Add("")
            Next
        End If


    End Sub

    Private Sub relacionDeArticulos()
        Dim resultado As String = ""
        Dim artic As Articulo = New Articulo
        Dim articAux As Articulo = New Articulo
        Dim autorDe As Collection = New Collection()
        Dim invest As Investigador = New Investigador
        Dim autor As Autor = New Autor
        Dim autorAux As Autor = New Autor
        Dim autoresDelArticulo As Collection = New Collection()
        Dim conf = New Conferencia()
        autorDe = autor.autoresPorInvestigador(idInvest)

        If autorDe.Count = 0 Then
            curriculum.Add("No figura como autor de ningun artículo.")
            curriculum.Add("")
        Else
            For Each autor In autorDe
                resultado = ""

                autoresDelArticulo = New Collection
                autoresDelArticulo = autor.autoresPorArticulo(autor.idArticulo)
                artic = artic.leerArticulo(autor.idArticulo)
                For i As Int32 = 1 To autoresDelArticulo.Count
                    For j As Int32 = 1 To autoresDelArticulo.Count

                        autorAux = autoresDelArticulo.Item(j)
                        If autorAux.OrdenAutor = i Then
                            invest = invest.leerInvestigador(autorAux.idInvestigador)
                            resultado = resultado & invest.ApellidosInvestigador & ", " & invest.NombreInvestigador


                        End If

                    Next
                    If i = autoresDelArticulo.Count Then
                        resultado = resultado & ". "
                    Else
                        resultado = resultado & ", "
                    End If
                Next

                resultado = resultado & artic.TituloArticulo & ". "
                conf = conf.leerConferencia(artic.IdConferencia)
                resultado = resultado & conf.SiglasConf & ": "
                resultado = resultado & conf.NombreConf & ". "
                resultado = resultado & "pp. " & artic.PagInicio & "-" & artic.PagFin & ". "
                resultado = resultado & conf.LugarConf & ". "
                resultado = resultado & conf.InicioConf.Year & ". "
                curriculum.Add(resultado)
                curriculum.Add("")
            Next

        End If

    End Sub
End Class
