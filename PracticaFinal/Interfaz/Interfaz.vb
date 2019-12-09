Public Class Interfaz
    '//////////////////////////////BARRA DE HERRAMIENTAS/////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub AcercaDeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        'Boton de informacion
        MsgBox("Curricula Vitarum" & Chr(10) & "Francisco Manuel García Sánchez-Belmonte" & Chr(10) & "Angel Loro Mosqueda", 64, "Acerca de:")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'Botón de salir
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿Desea salir?", 36, "Salir de la aplicación")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub AbrirBBDDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirBBDDToolStripMenuItem.Click
        'Boton abrir bbdd
        Dim cadena As String = ""
        'Creamos un OpenFileDialog con su titulo y su filtro correspondiente
        Dim dialogoAbrirBBDD As New OpenFileDialog()
        dialogoAbrirBBDD.Filter = "Base de Datos|*.accdb"
        dialogoAbrirBBDD.Title = "Selecciona una BBDD"

        Try
            'Lanzamos el dialogo y comprobamos si se elige un archivo
            If dialogoAbrirBBDD.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                'Guardamos la cadena
                cadena = dialogoAbrirBBDD.FileName()
                'Cargamos los investigadores, las conferencias y los articulos
                Dim invest As Investigador = New Investigador()
                invest.cargarTodos(cadena)
                Dim conf As Conferencia = New Conferencia()
                conf.cargarTodos("")
                Dim artic As Articulo = New Articulo()
                artic.cargarTodos("")

                'Actualizamos la pestaña de investigadores
                actualizarTabInvestigadores()

                'Desactivar el botón
                AbrirBBDDToolStripMenuItem.Enabled = False

                'Activar la interfaz
                Tabs.Enabled = True
            End If

        Catch Ex As Exception

            'Si no se puede abrir el archivo lanzamos un MsgBox
            MsgBox("Imposible abrir el archivo.", 16, "Error")

        End Try


    End Sub


    '////////////////////////////////////////////////////FIN BARRA DE HERRAMIENTAS///////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////ACTUALIZACION DE LAS PESTAÑAS/////////////////////////////////////////////////////////////////////////////////////////
    Private Sub Tabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tabs.SelectedIndexChanged
        'Cuando una pestaña es seleccionada se lanza una rutina de actualizacion

        If Tabs.SelectedTab Is Tab_Investigadores Then
            actualizarTabInvestigadores()
        End If
        If Tabs.SelectedTab Is Tab_Conferencias Then
            actualizarTabConferencias()
        End If
        If Tabs.SelectedTab Is Tab_Articulos Then
            actualizarTabArticulos()
        End If
        If Tabs.SelectedTab Is Tab_Curriculums Then
            actualizarInvestigadorCurComboBox()
            CurriculumCurTextBox.Clear()
        End If
    End Sub


    Private Sub actualizarTabArticulos()
        'Actualizacion de la pestaña de articulos
        limpiarDatosArtGroupBox()
        OrdenArtListBox.Items.Clear()
        AutoresArtCheckedListBox.Items.Clear()
        ArticulosArtListBox.Items.Clear()
        actualizarArticulosArtListBox()

        If ArticulosArtListBox.Items.Count <> 0 Then
            ArticulosArtListBox.SelectedIndex = 0
            Dim matriz() As String = Split(ArticulosArtListBox.SelectedItem.ToString())
            Dim artic = New Articulo
            artic = artic.leerArticulo(matriz.First)

            actualizarDatosArtGroupBox(artic)
            actualizarAutoresArtCheckedListBox(artic)
            ActualizarOrdenArtListBoxAutor()
        Else
            actualizarAutoresArtCheckedListBox()
        End If

    End Sub

    Private Sub actualizarTabConferencias()
        'Actualizacion de la pestaña de conferencias
        AsistentesConfCheckedListBox.Items.Clear()
        ArticulosConfListBox.Items.Clear()
        limpiarDatosConfGroupBox()
        actualizarConferenciasConfListBox()

        If ConferenciasConfListBox.Items.Count <> 0 Then
            ConferenciasConfListBox.SelectedIndex = 0
            Dim matriz() As String = Split(ConferenciasConfListBox.SelectedItem.ToString())
            Dim conf As Conferencia = New Conferencia
            conf = conf.leerConferencia(matriz.First)

            actualizarDatosConfGroupBox(conf)
            actualizarAsistentesConfCheckedListBox(conf)
            ActualizarArticulosConfListBox(conf)
        Else
            actualizarAsistentesConfCheckedListBox()

        End If
    End Sub

    Private Sub actualizarTabInvestigadores()
        'Actualizacion de la pestaña de investigadores
        conferenciasInvCheckedListBox.Items.Clear()
        ArticulosInvCheckedListBox.Items.Clear()
        limpiarDatosInvGroupBox()
        actualizarInvestigadoresInvListBox()

        If InvestigadoresInvListBox.Items.Count <> 0 Then
            InvestigadoresInvListBox.SelectedIndex = 0

            Dim matriz() As String = Split(InvestigadoresInvListBox.SelectedItem.ToString())
            Dim invest As Investigador = New Investigador

            invest = invest.leerInvestigador(matriz.First)
            actualizarDatosInvGroupBox(invest)
            actualizarConferenciasInvCheckedListBox(invest)
            actualizarArticulosInvCheckedListBox(invest)
        Else

            actualizarConferenciasInvCheckedListBox()
            actualizarArticulosInvCheckedListBox()

        End If

    End Sub

    '//////////////////////////////////FIN ACTUALIZACION DE LAS PESTAÑAS/////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '///////////////////////////////////////////////////PESTAÑA INVESTIGADORES///////////////////////////////////////////////////////////////////////////////
    Private Sub actualizarArticulosInvCheckedListBox(ByVal invest As Investigador)
        Dim autor = New Autor
        Dim articulo = New Articulo()
        Dim esAutor = New Collection

        esAutor = autor.autoresPorInvestigador(invest.IdInvestigador)

        ArticulosInvCheckedListBox.Items.Clear()

        For i As Integer = 1 To articulo.leerTodos.Count
            articulo = articulo.leerTodos.Item(i)
            ArticulosInvCheckedListBox.Items.Add(articulo.IdArtic & " " & articulo.TituloArticulo)

        Next

        For i As Integer = 1 To articulo.leerTodos.Count
            articulo = articulo.leerTodos.Item(i)

            If esAutor.Contains(articulo.IdArtic) Then

                ArticulosInvCheckedListBox.SetItemChecked(i - 1, True)

            End If
        Next
    End Sub

    Private Sub actualizarArticulosInvCheckedListBox()
        Dim articulo = New Articulo()

        ArticulosInvCheckedListBox.Items.Clear()

        For i As Integer = 1 To articulo.leerTodos.Count
            articulo = articulo.leerTodos.Item(i)
            ArticulosInvCheckedListBox.Items.Add(articulo.IdArtic & " " & articulo.TituloArticulo)

        Next

    End Sub
    Private Sub ArticulosInvCheckedListBox_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ArticulosInvCheckedListBox.ItemCheck

        If IsNothing(ArticulosInvCheckedListBox.SelectedItem) = False And IDInvTextBox.Text <> "" Then
            Dim matriz() As String = Split(ArticulosInvCheckedListBox.SelectedItem.ToString())

            Dim autor = New Autor(IDInvTextBox.Text, matriz.First, 0)

            If e.CurrentValue = CheckState.Unchecked Then
                autor.insertar()
            Else
                autor.eliminar()
            End If

        End If

    End Sub
    Private Sub conferenciasInvCheckedListBox_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles conferenciasInvCheckedListBox.ItemCheck

        If IsNothing(conferenciasInvCheckedListBox.SelectedItem) = False And IDInvTextBox.Text <> "" Then
            Dim matriz() As String = Split(conferenciasInvCheckedListBox.SelectedItem.ToString())

            Dim asistente = New Asistente(Convert.ToInt32(matriz.First), IDInvTextBox.Text)

            If e.CurrentValue = CheckState.Unchecked Then
                asistente.insertar()
            Else
                asistente.eliminar()
            End If

        End If

    End Sub

    Private Sub EditModeInvButton_Click(sender As Object, e As EventArgs) Handles EditModeInvButton.Click
        If DatosInvGroupBox.Enabled = False Then
            DatosInvGroupBox.Enabled = True
            ButtonsInvGroupBox.Enabled = True
            lowerInvGroupBox.Enabled = True
        Else
            DatosInvGroupBox.Enabled = False
            ButtonsInvGroupBox.Enabled = False
            lowerInvGroupBox.Enabled = False
        End If
    End Sub

    Private Sub LimpiarInvButton_Click(sender As Object, e As EventArgs) Handles LimpiarInvButton.Click
        limpiarDatosInvGroupBox()
        InvestigadoresInvListBox.ClearSelected()
        actualizarConferenciasInvCheckedListBox()
        actualizarArticulosInvCheckedListBox()

    End Sub
    Private Sub actualizarInvestigadoresInvListBox()

        Dim invest = New Investigador

        InvestigadoresInvListBox.Items.Clear()

        For i As Integer = 1 To invest.leerTodos.Count
            invest = invest.leerTodos.Item(i)
            InvestigadoresInvListBox.Items.Add(invest.IdInvestigador & " " & invest.NombreInvestigador & " " & invest.ApellidosInvestigador)
        Next

    End Sub


    Private Sub InvestigadoresInvListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvestigadoresInvListBox.SelectedIndexChanged
        Dim invest = New Investigador

        If IsNothing(InvestigadoresInvListBox.SelectedItem) = False Then
            Dim matriz() As String = Split(InvestigadoresInvListBox.SelectedItem.ToString())
            invest = invest.leerInvestigador(Convert.ToInt32(matriz.First))
            actualizarDatosInvGroupBox(invest)
            actualizarConferenciasInvCheckedListBox(invest)
            actualizarArticulosInvCheckedListBox(invest)
        Else
            actualizarConferenciasInvCheckedListBox()
            actualizarArticulosInvCheckedListBox()
        End If

    End Sub

    Private Sub AnadirInvButton_Click(sender As Object, e As EventArgs) Handles AnadirInvButton.Click
        Dim invest = New Investigador
        Dim idInvestigador As Integer = 0
        invest = New Investigador(0, StrConv(NombreInvTextBox.Text, VbStrConv.ProperCase), StrConv(ApellidosInvTextBox.Text, VbStrConv.ProperCase), StrConv(DespachoInvTextBox.Text, VbStrConv.ProperCase), StrConv(EdificioInvTextBox.Text, VbStrConv.ProperCase), StrConv(DepartamentoInvTextBox.Text, VbStrConv.ProperCase), StrConv(TelefonoInvTextBox.Text, VbStrConv.ProperCase), StrConv(EmailInvTextBox.Text, VbStrConv.Lowercase))
        If invest.notNull() = True Then
            MsgBox("No puede haber campos vacios.", 48, "Error")

        Else
            invest.insertar()
            actualizarDatosInvGroupBox(invest)
            actualizarInvestigadoresInvListBox()
            actualizarConferenciasInvCheckedListBox()
            actualizarArticulosInvCheckedListBox()
        End If

    End Sub

    Private Sub actualizarDatosInvGroupBox(ByVal invest As Investigador)
        IDInvTextBox.Text = invest.IdInvestigador
        NombreInvTextBox.Text = invest.NombreInvestigador
        ApellidosInvTextBox.Text = invest.ApellidosInvestigador
        DespachoInvTextBox.Text = invest.DespachoInvestigador
        EdificioInvTextBox.Text = invest.EdificioInvestigador
        DepartamentoInvTextBox.Text = invest.DepartamentoInvestigador
        TelefonoInvTextBox.Text = invest.TelefonoInvestigador
        EmailInvTextBox.Text = invest.EmailInvestigador
    End Sub

    Private Sub limpiarDatosInvGroupBox()
        IDInvTextBox.Text = ""
        NombreInvTextBox.Text = ""
        ApellidosInvTextBox.Text = ""
        DespachoInvTextBox.Text = ""
        EdificioInvTextBox.Text = ""
        DepartamentoInvTextBox.Text = ""
        TelefonoInvTextBox.Text = ""
        EmailInvTextBox.Text = ""
    End Sub

    Private Sub actualizarConferenciasInvCheckedListBox(ByVal invest As Investigador)
        Dim asistente = New Asistente
        Dim conferencia = New Conferencia()
        Dim asiste = New Collection
        asiste = asistente.asistentesPorInvestigador(invest.IdInvestigador)

        conferenciasInvCheckedListBox.Items.Clear()

        For i As Integer = 1 To conferencia.leerTodos.Count
            conferencia = conferencia.leerTodos.Item(i)
            conferenciasInvCheckedListBox.Items.Add(conferencia.IdConf & " " & conferencia.SiglasConf & " " & conferencia.NombreConf)

        Next

        For i As Integer = 1 To conferencia.leerTodos.Count
            conferencia = conferencia.leerTodos.Item(i)
            If asiste.Contains(conferencia.IdConf) Then
                conferenciasInvCheckedListBox.SetItemChecked(i - 1, True)
            End If
        Next
    End Sub
    Private Sub actualizarConferenciasInvCheckedListBox()

        Dim conferencia = New Conferencia()

        conferenciasInvCheckedListBox.Items.Clear()

        For i As Integer = 1 To conferencia.leerTodos.Count
            conferencia = conferencia.leerTodos.Item(i)
            conferenciasInvCheckedListBox.Items.Add(conferencia.IdConf & " " & conferencia.SiglasConf & " " & conferencia.NombreConf)

        Next

    End Sub

    Private Sub EliminarInvButton_Click(sender As Object, e As EventArgs) Handles EliminarInvButton.Click
        Dim invest = New Investigador

        If IsNumeric(IDInvTextBox.Text) = False Then
            'MSG BOX NO ES UN NUMERO
            MsgBox("El ID no es un numero.", 48, "Error")
        ElseIf invest.existe(Convert.ToInt32(IDInvTextBox.Text)) = False Then

            '48 Exclamation
            MsgBox("El ID no está en el sistema.", 48, "Error")

        Else

            'Creamos una persona con los datos de los campos de texto
            invest = New Investigador(Convert.ToInt32(IDInvTextBox.Text), StrConv(NombreInvTextBox.Text, VbStrConv.ProperCase), StrConv(ApellidosInvTextBox.Text, VbStrConv.ProperCase), StrConv(DespachoInvTextBox.Text, VbStrConv.ProperCase), StrConv(EdificioInvTextBox.Text, VbStrConv.ProperCase), StrConv(DepartamentoInvTextBox.Text, VbStrConv.ProperCase), StrConv(TelefonoInvTextBox.Text, VbStrConv.ProperCase), StrConv(EmailInvTextBox.Text, VbStrConv.ProperCase))

            'Mostramos un mensaje de confirmacion
            '4 YesNO + 32 Question + 256 DefaultButton2
            If MsgBox("¿Desea eliminar este investigador?" & Chr(10) & "ID: " & invest.IdInvestigador & Chr(10) & "Nombre: " & invest.NombreInvestigador & Chr(10) & "Apellido: " & invest.ApellidosInvestigador, 292, "¿Borrar?") = MsgBoxResult.Yes Then

                'Eliminamos a la persona

                If invest.eliminar() = 0 Then
                    'Error eliminando
                    MsgBox("Error al eliminar.", 48, "Error")
                Else

                    actualizarConferenciasInvCheckedListBox()
                    actualizarArticulosInvCheckedListBox()
                    'Limpiamos los campos
                    limpiarDatosInvGroupBox()

                End If
                'Actualizamos el listbox
                actualizarInvestigadoresInvListBox()


            End If

        End If
    End Sub

    Private Sub ModificarInvButton_Click(sender As Object, e As EventArgs) Handles ModificarInvButton.Click
        Dim invest = New Investigador
        If IsNumeric(IDInvTextBox.Text) = False Then
            'MSG BOX NO ES UN NUMERO
            MsgBox("El ID no es un numero.", 48, "Error")
        ElseIf Convert.ToInt32(IDInvTextBox.Text) < 0 Then
            MsgBox("El ID no puede ser negativo.", 48, "Error")

        ElseIf invest.existe(Convert.ToInt32(IDInvTextBox.Text)) = False Then
            'MSG BOX ID NO EXISTE
            MsgBox("Este ID no existe.", 48, "Error")
        Else
            invest = New Investigador(Convert.ToInt32(IDInvTextBox.Text), StrConv(NombreInvTextBox.Text, VbStrConv.ProperCase), StrConv(ApellidosInvTextBox.Text, VbStrConv.ProperCase), StrConv(DespachoInvTextBox.Text, VbStrConv.ProperCase), StrConv(EdificioInvTextBox.Text, VbStrConv.ProperCase), StrConv(DepartamentoInvTextBox.Text, VbStrConv.ProperCase), StrConv(TelefonoInvTextBox.Text, VbStrConv.ProperCase), StrConv(EmailInvTextBox.Text, VbStrConv.Lowercase))
            If invest.notNull() = True Then
                MsgBox("No puede haber campos vacios.", 48, "Error")

            ElseIf invest.modificar() = 0 Then
                'Error Añadiendo
                MsgBox("Error al añadir.", 48, "Error")
            Else
                actualizarDatosInvGroupBox(invest)
            End If
        End If

        actualizarInvestigadoresInvListBox()
    End Sub
    '//////////////////////////////////FIN PESTAÑA INVESTIGADORES////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////CONFERENCIAS//////////////////////////////////////////////////////
    Private Sub LimpiarConfButton_Click(sender As Object, e As EventArgs) Handles LimpiarConfButton.Click
        limpiarDatosConfGroupBox()
        ArticulosConfListBox.Items.Clear()

        actualizarAsistentesConfCheckedListBox()

    End Sub

    Private Sub actualizarAsistentesConfCheckedListBox(ByVal conf As Conferencia)
        Dim asistente = New Asistente
        Dim investigador = New Investigador()
        Dim asiste = New Collection
        asiste = asistente.asistentesPorConferencia(conf.IdConf)

        AsistentesConfCheckedListBox.Items.Clear()

        For i As Integer = 1 To investigador.leerTodos.Count
            investigador = investigador.leerTodos.Item(i)
            AsistentesConfCheckedListBox.Items.Add(investigador.IdInvestigador & " " & investigador.NombreInvestigador & " " & investigador.ApellidosInvestigador)

        Next

        For i As Integer = 1 To investigador.leerTodos.Count
            investigador = investigador.leerTodos.Item(i)
            If asiste.Contains(investigador.IdInvestigador) Then

                AsistentesConfCheckedListBox.SetItemChecked(i - 1, True)

            End If
        Next
    End Sub

    Private Sub actualizarAsistentesConfCheckedListBox()

        Dim investigador = New Investigador()

        AsistentesConfCheckedListBox.Items.Clear()

        For i As Integer = 1 To investigador.leerTodos.Count
            investigador = investigador.leerTodos.Item(i)
            AsistentesConfCheckedListBox.Items.Add(investigador.IdInvestigador & " " & investigador.NombreInvestigador & " " & investigador.ApellidosInvestigador)

        Next

    End Sub

    Private Sub AsistentesConfCheckedListBox_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles AsistentesConfCheckedListBox.ItemCheck

        If IsNothing(AsistentesConfCheckedListBox.SelectedItem) = False And IDConfTextBox.Text <> "" Then
            Dim matriz() As String = Split(AsistentesConfCheckedListBox.SelectedItem.ToString())

            Dim asistente = New Asistente(IDConfTextBox.Text, Convert.ToInt32(matriz.First))

            If e.CurrentValue = CheckState.Unchecked Then
                asistente.insertar()
            Else
                asistente.eliminar()
            End If

        End If

    End Sub

    Private Sub ActualizarArticulosConfListBox(ByVal conf As Conferencia)

        Dim artic = New Articulo

        'Vaciamos el ListBox
        ArticulosConfListBox.Items.Clear()

        'Añadimos los items
        For i As Integer = 1 To artic.leerTodos.Count
            artic = artic.leerTodos.Item(i)

            If artic.IdConferencia = conf.IdConf Then
                ArticulosConfListBox.Items.Add(artic.IdArtic & " " & artic.TituloArticulo)
            End If

        Next

    End Sub

    Private Sub ModificarConfButton_Click(sender As Object, e As EventArgs) Handles ModificarConfButton.Click
        Dim conf = New Conferencia
        If IsNumeric(IDConfTextBox.Text) = False Then
            'MSG BOX NO ES UN NUMERO
            MsgBox("El ID no es un numero.", 48, "Error")
        ElseIf Convert.ToInt32(IDConfTextBox.Text) < 0 Then
            MsgBox("El ID no puede ser negativo.", 48, "Error")
        ElseIf conf.existe(Convert.ToInt32(IDConfTextBox.Text)) = False Then
            'MSG BOX ID NO EXISTE
            MsgBox("Este ID no existe.", 48, "Error")
        Else
            Try
                conf = New Conferencia(Convert.ToInt32(IDConfTextBox.Text), StrConv(SiglasConfTextBox.Text, VbStrConv.Uppercase), StrConv(NombreConfTextBox.Text, VbStrConv.ProperCase), StrConv(LugarConfTextBox.Text, VbStrConv.ProperCase), CDate(InicioConfTextBox.Text), CDate(FinConfTextBox.Text))
                If conf.notNull = True Then
                    MsgBox("No puede haber campos vacios.", 48, "Error")

                ElseIf conf.modificar() = 0 Then
                    'Error Añadiendo
                    MsgBox("Error al añadir.", 48, "Error")
                Else
                    actualizarDatosConfGroupBox(conf)
                End If
            Catch ex As System.InvalidCastException
                MsgBox("Error en el formato de la fecha.", 48, "Error")
            Catch ex As InvalidDateException
                MsgBox("Error entre la correlacion de fechas.", 48, "Error")
                conf = conf.leerConferencia(Convert.ToInt32(IDConfTextBox.Text))
                InicioConfTextBox.Value = conf.InicioConf
                FinConfTextBox.Value = conf.FinConf

                InicioConfTextBox.Text = conf.InicioConf
                FinConfTextBox.Text = conf.FinConf

            End Try

        End If

        actualizarConferenciasConfListBox()
    End Sub

    Private Sub AnadirConfButton_Click(sender As Object, e As EventArgs) Handles AnadirConfButton.Click
        Dim conf = New Conferencia
        Dim idAsignado As Int32 = 0

        Try
            conf = New Conferencia(0, StrConv(SiglasConfTextBox.Text, VbStrConv.Uppercase), StrConv(NombreConfTextBox.Text, VbStrConv.ProperCase), StrConv(LugarConfTextBox.Text, VbStrConv.ProperCase), CDate(InicioConfTextBox.Text), CDate(FinConfTextBox.Text))

            If conf.notNull = True Then
                MsgBox("No puede haber campos vacios.", 48, "Error")
            Else
                conf.insertar()

                actualizarDatosConfGroupBox(conf)
                actualizarAsistentesConfCheckedListBox()
                ArticulosConfListBox.Items.Clear()
            End If

        Catch ex As InvalidDateException
            MsgBox("La fecha de fin no puede ser menor que la de inicio.", 48, "Error")
        End Try

        actualizarConferenciasConfListBox()
    End Sub
    Private Sub actualizarDatosConfGroupBox(ByVal conf As Conferencia)
        IDConfTextBox.Text = conf.IdConf
        NombreConfTextBox.Text = conf.NombreConf
        SiglasConfTextBox.Text = conf.SiglasConf
        LugarConfTextBox.Text = conf.LugarConf

        InicioConfTextBox.Value = conf.InicioConf
        FinConfTextBox.Value = conf.FinConf

        InicioConfTextBox.Text = conf.InicioConf
        FinConfTextBox.Text = conf.FinConf
    End Sub
    Private Sub limpiarDatosConfGroupBox()
        IDConfTextBox.Text = ""
        NombreConfTextBox.Text = ""
        SiglasConfTextBox.Text = ""
        LugarConfTextBox.Text = ""

        InicioConfTextBox.Value = DateTime.Today
        FinConfTextBox.Value = DateTime.Today

        InicioConfTextBox.Text = DateTime.Today
        FinConfTextBox.Text = DateTime.Today

    End Sub

    Private Sub EliminarConfButton_Click(sender As Object, e As EventArgs) Handles EliminarConfButton.Click
        Dim conf = New Conferencia

        If IsNumeric(IDConfTextBox.Text) = False Then
            'MSG BOX NO ES UN NUMERO
            MsgBox("El ID no es un numero.", 48, "Error")
        ElseIf conf.existe(Convert.ToInt32(IDConfTextBox.Text)) = False Then

            '48 Exclamation
            MsgBox("El ID no está en el sistema.", 48, "Error")

        Else

            'Creamos una conferencia con los datos de los campos de texto
            conf = New Conferencia(Convert.ToInt32(IDConfTextBox.Text), StrConv(SiglasConfTextBox.Text, VbStrConv.ProperCase), StrConv(NombreConfTextBox.Text, VbStrConv.ProperCase), StrConv(LugarConfTextBox.Text, VbStrConv.ProperCase), CDate(InicioConfTextBox.Text), CDate(FinConfTextBox.Text))

            'Mostramos un mensaje de confirmacion
            '4 YesNO + 32 Question + 256 DefaultButton2
            If MsgBox("¿Desea eliminar esta conferencia?" & Chr(10) & "Esto eliminará todos los articulos de esta conferencia." & Chr(10) & "ID: " & conf.IdConf & Chr(10) & "Siglas: " & conf.SiglasConf & Chr(10) & "Nombre: " & conf.NombreConf, 292, "¿Borrar?") = MsgBoxResult.Yes Then

                'Eliminamos conferencia

                If conf.eliminar() = 0 Then
                    'Error eliminando
                    MsgBox("Error al eliminar.", 48, "Error")
                Else

                    actualizarAsistentesConfCheckedListBox()
                    ArticulosConfListBox.Items.Clear()
                End If
                'Actualizamos el listbox
                actualizarConferenciasConfListBox()

                'Limpiamos los campos
                limpiarDatosConfGroupBox()
            End If

        End If
    End Sub
    Private Sub ConferenciasConfListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConferenciasConfListBox.SelectedIndexChanged
        Dim conf = New Conferencia

        'Controla en que item del listbox hacemos click
        If IsNothing(ConferenciasConfListBox.SelectedItem) = False Then
            Dim matriz() As String = Split(ConferenciasConfListBox.SelectedItem.ToString())
            conf = conf.leerConferencia(Convert.ToInt32(matriz.First))
            actualizarDatosConfGroupBox(conf)
            actualizarAsistentesConfCheckedListBox(conf)
            ActualizarArticulosConfListBox(conf)
        End If
    End Sub

    Private Sub actualizarConferenciasConfListBox()
        Dim conf = New Conferencia

        'Vaciamos el ListBox
        ConferenciasConfListBox.Items.Clear()

        'Añadimos los items
        For i As Integer = 1 To conf.leerTodos.Count
            conf = conf.leerTodos.Item(i)
            ConferenciasConfListBox.Items.Add(conf.IdConf & " " & conf.SiglasConf & " " & conf.NombreConf)
        Next

    End Sub

    Private Sub EditModeConfButton_Click(sender As Object, e As EventArgs) Handles EditModeConfButton.Click
        If DatosConfGroupBox.Enabled = False Then
            DatosConfGroupBox.Enabled = True
            ButtonsConfGroupBox.Enabled = True
            lowerConfGroupBox.Enabled = True
        Else
            DatosConfGroupBox.Enabled = False
            ButtonsConfGroupBox.Enabled = False
            lowerConfGroupBox.Enabled = False
        End If
    End Sub

    Private Sub actualizarConferenciaArtComboBox()
        Dim conf = New Conferencia

        'Vaciamos el Combobox
        ConferenciaArtComboBox.Items.Clear()

        'Añadimos los items
        For i As Integer = 1 To conf.leerTodos.Count
            conf = conf.leerTodos.Item(i)
            ConferenciaArtComboBox.Items.Add(conf.IdConf & " " & conf.SiglasConf & " " & conf.NombreConf)
        Next
    End Sub


    '////////////////////////////////////////////////FIN PESTAÑA CONFERENCIAS////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '//////////////////////////////////////////////////////////////////////////////////////ARTICULOS/////////////////////////////////////////////////////////

    Private Sub ActualizarOrdenArtListBoxAutor()
        Dim coleccionAutores As Collection
        OrdenArtListBox.Items.Clear()
        Dim autor = New Autor
        Dim invest = New Investigador
        coleccionAutores = autor.autoresPorArticulo(IDArtTextBox.Text)
        If coleccionAutores.Count <> 0 Then
            For i As Int32 = 1 To coleccionAutores.Count
                For j As Int32 = 1 To coleccionAutores.Count

                    autor = coleccionAutores.Item(j)
                    If autor.OrdenAutor = i Then
                        invest = invest.leerInvestigador(autor.idInvestigador)
                        OrdenArtListBox.Items.Add(invest.IdInvestigador & " " & invest.NombreInvestigador & " " & invest.ApellidosInvestigador)

                    End If

                Next
            Next
        End If

    End Sub


    Private Sub AutoresArtCheckedListBox_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles AutoresArtCheckedListBox.ItemCheck

        If IsNothing(AutoresArtCheckedListBox.SelectedItem) = False Then
            Dim matriz() As String = Split(AutoresArtCheckedListBox.SelectedItem.ToString())

            Dim autor = New Autor(matriz.First, IDArtTextBox.Text, 0)


            If e.CurrentValue = CheckState.Unchecked Then
                autor.insertar()
                ActualizarOrdenArtListBoxAutor()
            Else
                autor.eliminar()
                ActualizarOrdenArtListBoxAutor()
            End If

        End If

    End Sub
    Private Sub actualizarAutoresArtCheckedListBox(ByVal artic As Articulo)
        Dim autor = New Autor
        Dim autores = New Collection
        Dim investigador = New Investigador

        autores = autor.autoresPorArticulo(artic.IdArtic)
        AutoresArtCheckedListBox.Items.Clear()

        For i As Integer = 1 To investigador.leerTodos.Count
            investigador = investigador.leerTodos.Item(i)
            AutoresArtCheckedListBox.Items.Add(investigador.IdInvestigador & " " & investigador.NombreInvestigador & " " & investigador.ApellidosInvestigador)
        Next

        For i As Integer = 1 To investigador.leerTodos.Count
            investigador = investigador.leerTodos.Item(i)
            If autores.Contains(investigador.IdInvestigador) Then
                AutoresArtCheckedListBox.SetItemChecked(i - 1, True)
            End If
        Next

    End Sub

    Private Sub actualizarAutoresArtCheckedListBox()

        Dim investigador = New Investigador

        AutoresArtCheckedListBox.Items.Clear()

        For i As Integer = 1 To investigador.leerTodos.Count
            investigador = investigador.leerTodos.Item(i)
            AutoresArtCheckedListBox.Items.Add(investigador.IdInvestigador & " " & investigador.NombreInvestigador & " " & investigador.ApellidosInvestigador)
        Next

    End Sub
    Private Sub actualizarArticulosArtListBox()

        Dim artic = New Articulo

        'Vaciamos el ListBox
        ArticulosArtListBox.Items.Clear()

        'Añadimos los items
        For i As Integer = 1 To artic.leerTodos.Count
            artic = artic.leerTodos.Item(i)
            ArticulosArtListBox.Items.Add(artic.IdArtic & " " & artic.TituloArticulo)
        Next

    End Sub

    Private Sub ArticulosArtListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArticulosArtListBox.SelectedIndexChanged
        Dim artic = New Articulo

        If IsNothing(ArticulosArtListBox.SelectedItem) = False Then
            Dim matriz() As String = Split(ArticulosArtListBox.SelectedItem.ToString())
            artic = artic.leerArticulo(Convert.ToInt32(matriz.First))
            actualizarDatosArtGroupBox(artic)
            actualizarAutoresArtCheckedListBox(artic)
            ActualizarOrdenArtListBoxAutor()

        End If

    End Sub


    Private Sub actualizarDatosArtGroupBox(ByVal artic As Articulo)
        Dim conf As Conferencia = New Conferencia
        conf = conf.leerConferencia(artic.IdConferencia)
        IDArtTextBox.Text = artic.IdArtic
        TituloArtTextBox.Text = artic.TituloArticulo
        PagInicioArtTextBox.Text = artic.PagInicio
        PagFinArtTextBox.Text = artic.PagFin
        ConferenciaArtComboBox.Text = conf.IdConf & " " & conf.SiglasConf & " " & conf.NombreConf

    End Sub


    Private Sub ModificarArtButton_Click(sender As Object, e As EventArgs) Handles ModificarArtButton.Click
        Dim artic = New Articulo
        Dim matriz() As String

        If IsNumeric(IDArtTextBox.Text) = False Then
            'MSG BOX NO ES UN NUMERO
            MsgBox("El ID no es un numero.", 48, "Error")
        ElseIf Convert.ToInt32(IDArtTextBox.Text) < 0 Then
            MsgBox("El ID no puede ser negativo.", 48, "Error")

        ElseIf artic.existe(Convert.ToInt32(IDArtTextBox.Text)) = False Then
            'MSG BOX ID NO EXISTE
            MsgBox("Este ID no existe.", 48, "Error")
        Else
            Try
                matriz = Split(ConferenciaArtComboBox.SelectedItem.ToString())
                Dim idConf As String = Convert.ToInt32(matriz.First)
                artic = New Articulo(Convert.ToInt32(IDArtTextBox.Text), StrConv(TituloArtTextBox.Text, VbStrConv.ProperCase), idConf, Convert.ToInt32(PagInicioArtTextBox.Text), Convert.ToInt32(PagFinArtTextBox.Text))

                If artic.notNull = True Then
                    MsgBox("No puede haber campos vacios.", 48, "Error")
                ElseIf artic.modificar() = 0 Then
                    'Error Añadiendo
                    MsgBox("Error al añadir.", 48, "Error")
                Else
                    actualizarDatosArtGroupBox(artic)
                End If
            Catch ex As System.InvalidCastException
                MsgBox("Error en el formato de los campos.", 48, "Error")
            Catch ex1 As System.NullReferenceException
                MsgBox("La conferencia no puede estar vacia.", 48, "Error")
            Catch ex2 As InvalidEndPageException
                MsgBox("La pagina de fin no puede ser menor que la de inicio.", 48, "Error")
                artic = artic.leerArticulo(Convert.ToInt32(IDArtTextBox.Text))
                PagInicioArtTextBox.Text = artic.PagInicio
                PagFinArtTextBox.Text = artic.PagFin
            End Try

        End If

        actualizarArticulosArtListBox()
    End Sub


    Private Sub AnadirArtButton_Click(sender As Object, e As EventArgs) Handles AnadirArtButton.Click
        Dim artic = New Articulo
        Dim idAsignado As Int32 = 0
        Dim matriz() As String
        Try

            If ConferenciaArtComboBox.SelectedItem.ToString <> "" Then
                matriz = Split(ConferenciaArtComboBox.SelectedItem.ToString())

                Dim idConf As String = Convert.ToInt32(matriz.First)
                artic = New Articulo(0, StrConv(TituloArtTextBox.Text, VbStrConv.ProperCase), idConf, Convert.ToInt32(PagInicioArtTextBox.Text), Convert.ToInt32(PagFinArtTextBox.Text))
                If artic.notNull = False Then
                    artic.insertar()

                    actualizarDatosArtGroupBox(artic)
                    OrdenArtListBox.Items.Clear()
                    actualizarAutoresArtCheckedListBox()

                Else
                    MsgBox("El titulo no debe estar vacio.", 48, "Error")
                End If

            Else
                MsgBox("La conferencia no puede estar vacia.", 48, "Error")
            End If


        Catch ex As System.InvalidCastException
            MsgBox("Error en el formato.", 48, "Error")
        Catch ex1 As System.NullReferenceException
            MsgBox("La conferencia no puede estar vacia.", 48, "Error")
        Catch ex2 As InvalidEndPageException
            MsgBox("La pagina de fin no puede ser menor que la de inicio.", 48, "Error")

        End Try


        actualizarArticulosArtListBox()

    End Sub

    Private Sub EliminarArtButton_Click(sender As Object, e As EventArgs) Handles EliminarArtButton.Click
        Dim artic = New Articulo

        If IsNumeric(IDArtTextBox.Text) = False Then
            'MSG BOX NO ES UN NUMERO
            MsgBox("El ID no es un numero.", 48, "Error")
        Else
            Dim matriz() As String = Split(ConferenciaArtComboBox.SelectedItem.ToString())

            Dim idConf As Int32 = Convert.ToInt32(matriz.First)
            artic = New Articulo(IDArtTextBox.Text, StrConv(TituloArtTextBox.Text, VbStrConv.ProperCase), idConf, Convert.ToInt32(PagInicioArtTextBox.Text), Convert.ToInt32(PagFinArtTextBox.Text))

            'Mostramos un mensaje de confirmacion
            '4 YesNO + 32 Question + 256 DefaultButton2
            If MsgBox("¿Desea eliminar este articulo?" & Chr(10) & "ID: " & IDArtTextBox.Text & Chr(10) & "Titulo: " & artic.TituloArticulo, 292, "¿Borrar?") = MsgBoxResult.Yes Then

                'Eliminamos el articulo
                If artic.eliminar() = 0 Then
                    'Error eliminando
                    MsgBox("Error al eliminar.", 48, "Error")
                Else
                    OrdenArtListBox.Items.Clear()
                    actualizarAutoresArtCheckedListBox()
                End If
                'Actualizamos el listbox
                actualizarArticulosArtListBox()
                'Limpiamos los campos
                limpiarDatosArtGroupBox()
            End If

        End If
    End Sub
    Private Sub ArribaArtButton_Click(sender As Object, e As EventArgs) Handles ArribaArtButton.Click

        If IsNothing(OrdenArtListBox.SelectedItem) = False Then
            Dim matriz() As String = Split(OrdenArtListBox.SelectedItem.ToString())
            Dim autor As Autor = New Autor
            Dim index As Int32

            index = autor.arribaOrdenAutor(Convert.ToInt32(matriz.First), IDArtTextBox.Text)
            ActualizarOrdenArtListBoxAutor()
            OrdenArtListBox.SelectedIndex = index
        End If

    End Sub


    Private Sub AbajoArtButton_Click(sender As Object, e As EventArgs) Handles AbajoArtButton.Click

        If IsNothing(OrdenArtListBox.SelectedItem) = False Then
            Dim matriz() As String = Split(OrdenArtListBox.SelectedItem.ToString())
            Dim autor As Autor = New Autor
            Dim index As Int32

            index = autor.abajoOrdenAutor(Convert.ToInt32(matriz.First), IDArtTextBox.Text)
            ActualizarOrdenArtListBoxAutor()
            OrdenArtListBox.SelectedIndex = index
        End If

    End Sub

    Private Sub editModeArtButton_click(sender As Object, e As EventArgs) Handles editModeArtButton.Click
        If DatosArtGroupBox.Enabled = True Then
            DatosArtGroupBox.Enabled = False
            lowerArtGroupBox.Enabled = False
            buttonArtGroupBox.Enabled = False

        Else
            DatosArtGroupBox.Enabled = True
            lowerArtGroupBox.Enabled = True
            buttonArtGroupBox.Enabled = True
        End If
    End Sub

    Private Sub limpiarCurButton_Click(sender As Object, e As EventArgs) Handles limpiarCurButton.Click

        limpiarDatosArtGroupBox()
    End Sub

    Private Sub limpiarDatosArtGroupBox()
        IDArtTextBox.Text = ""
        TituloArtTextBox.Text = ""
        PagInicioArtTextBox.Text = 1
        PagFinArtTextBox.Text = 1
        actualizarConferenciaArtComboBox()
    End Sub
    '////////////////////////////////////////////////FIN PESTAÑA ARTICULOS///////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PESTAÑA CURRICULUMS////////////////////////////////////////////////////////////////////////////////
    Private Sub actualizarInvestigadorCurComboBox()
        Dim invest = New Investigador

        'Vaciamos el Combobox
        InvestigadorCurComboBox.Items.Clear()

        'Añadimos los items
        For i As Integer = 1 To invest.leerTodos.Count
            invest = invest.leerTodos.Item(i)
            InvestigadorCurComboBox.Items.Add(invest.IdInvestigador & " " & invest.NombreInvestigador & " " & invest.ApellidosInvestigador)
        Next
    End Sub
    Private Sub InvestigadorCurComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InvestigadorCurComboBox.SelectedIndexChanged
        Dim gen = New generadorDeCurriculum
        Dim lineas As Collection
        Dim matriz() As String = Split(InvestigadorCurComboBox.SelectedItem.ToString())
        lineas = gen.generarCurriculum(Convert.ToInt32(matriz.First))
        Dim linea As String
        CurriculumCurTextBox.Text = ""
        For Each linea In lineas
            CurriculumCurTextBox.AppendText(linea)
            CurriculumCurTextBox.AppendText(Chr(10))
        Next
    End Sub

End Class
'/////////////////////////////////////////////////////FIN PESTAÑA CURRICULUMS////////////////////////////////////////////////////////////////////////////////