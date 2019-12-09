<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Interfaz
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interfaz))
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.Tab_Investigadores = New System.Windows.Forms.TabPage()
        Me.lowerInvGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.conferenciasInvCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.ArticulosInvCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.ButtonsInvGroupBox = New System.Windows.Forms.GroupBox()
        Me.ModificarInvButton = New System.Windows.Forms.Button()
        Me.AnadirInvButton = New System.Windows.Forms.Button()
        Me.LimpiarInvButton = New System.Windows.Forms.Button()
        Me.EliminarInvButton = New System.Windows.Forms.Button()
        Me.DatosInvGroupBox = New System.Windows.Forms.GroupBox()
        Me.IDInvTextBox = New System.Windows.Forms.TextBox()
        Me.NombreInvTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ApellidosInvTextBox = New System.Windows.Forms.TextBox()
        Me.DespachoInvTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EdificioInvTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DepartamentoInvTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TelefonoInvTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmailInvTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EditModeInvButton = New System.Windows.Forms.Button()
        Me.InvestigadoresInvListBox = New System.Windows.Forms.ListBox()
        Me.Tab_Conferencias = New System.Windows.Forms.TabPage()
        Me.lowerConfGroupBox = New System.Windows.Forms.GroupBox()
        Me.ArticulosConfListBox = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AsistentesConfCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.ButtonsConfGroupBox = New System.Windows.Forms.GroupBox()
        Me.ModificarConfButton = New System.Windows.Forms.Button()
        Me.AnadirConfButton = New System.Windows.Forms.Button()
        Me.LimpiarConfButton = New System.Windows.Forms.Button()
        Me.EliminarConfButton = New System.Windows.Forms.Button()
        Me.DatosConfGroupBox = New System.Windows.Forms.GroupBox()
        Me.InicioConfTextBox = New System.Windows.Forms.DateTimePicker()
        Me.FinConfTextBox = New System.Windows.Forms.DateTimePicker()
        Me.IDConfTextBox = New System.Windows.Forms.TextBox()
        Me.SiglasConfTextBox = New System.Windows.Forms.TextBox()
        Me.NombreConfTextBox = New System.Windows.Forms.TextBox()
        Me.LugarConfTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.EditModeConfButton = New System.Windows.Forms.Button()
        Me.ConferenciasConfListBox = New System.Windows.Forms.ListBox()
        Me.Tab_Articulos = New System.Windows.Forms.TabPage()
        Me.lowerArtGroupBox = New System.Windows.Forms.GroupBox()
        Me.AbajoArtButton = New System.Windows.Forms.Button()
        Me.OrdenArtListBox = New System.Windows.Forms.ListBox()
        Me.ArribaArtButton = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.AutoresArtCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.buttonArtGroupBox = New System.Windows.Forms.GroupBox()
        Me.ModificarArtButton = New System.Windows.Forms.Button()
        Me.AnadirArtButton = New System.Windows.Forms.Button()
        Me.limpiarCurButton = New System.Windows.Forms.Button()
        Me.EliminarArtButton = New System.Windows.Forms.Button()
        Me.DatosArtGroupBox = New System.Windows.Forms.GroupBox()
        Me.PagFinArtTextBox = New System.Windows.Forms.NumericUpDown()
        Me.PagInicioArtTextBox = New System.Windows.Forms.NumericUpDown()
        Me.ConferenciaArtComboBox = New System.Windows.Forms.ComboBox()
        Me.IDArtTextBox = New System.Windows.Forms.TextBox()
        Me.TituloArtTextBox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.editModeArtButton = New System.Windows.Forms.Button()
        Me.ArticulosArtListBox = New System.Windows.Forms.ListBox()
        Me.Tab_Curriculums = New System.Windows.Forms.TabPage()
        Me.InvestigadorCurComboBox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CurriculumCurTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirBBDDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tabs.SuspendLayout()
        Me.Tab_Investigadores.SuspendLayout()
        Me.lowerInvGroupBox.SuspendLayout()
        Me.ButtonsInvGroupBox.SuspendLayout()
        Me.DatosInvGroupBox.SuspendLayout()
        Me.Tab_Conferencias.SuspendLayout()
        Me.lowerConfGroupBox.SuspendLayout()
        Me.ButtonsConfGroupBox.SuspendLayout()
        Me.DatosConfGroupBox.SuspendLayout()
        Me.Tab_Articulos.SuspendLayout()
        Me.lowerArtGroupBox.SuspendLayout()
        Me.buttonArtGroupBox.SuspendLayout()
        Me.DatosArtGroupBox.SuspendLayout()
        CType(Me.PagFinArtTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagInicioArtTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Curriculums.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.Tab_Investigadores)
        Me.Tabs.Controls.Add(Me.Tab_Conferencias)
        Me.Tabs.Controls.Add(Me.Tab_Articulos)
        Me.Tabs.Controls.Add(Me.Tab_Curriculums)
        Me.Tabs.Enabled = False
        Me.Tabs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabs.Location = New System.Drawing.Point(0, 27)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(822, 561)
        Me.Tabs.TabIndex = 0
        '
        'Tab_Investigadores
        '
        Me.Tab_Investigadores.Controls.Add(Me.lowerInvGroupBox)
        Me.Tab_Investigadores.Controls.Add(Me.ButtonsInvGroupBox)
        Me.Tab_Investigadores.Controls.Add(Me.DatosInvGroupBox)
        Me.Tab_Investigadores.Controls.Add(Me.EditModeInvButton)
        Me.Tab_Investigadores.Controls.Add(Me.InvestigadoresInvListBox)
        Me.Tab_Investigadores.Location = New System.Drawing.Point(4, 26)
        Me.Tab_Investigadores.Name = "Tab_Investigadores"
        Me.Tab_Investigadores.Size = New System.Drawing.Size(814, 531)
        Me.Tab_Investigadores.TabIndex = 1
        Me.Tab_Investigadores.Text = "Investigadores"
        Me.Tab_Investigadores.UseVisualStyleBackColor = True
        '
        'lowerInvGroupBox
        '
        Me.lowerInvGroupBox.Controls.Add(Me.Label10)
        Me.lowerInvGroupBox.Controls.Add(Me.Label9)
        Me.lowerInvGroupBox.Controls.Add(Me.conferenciasInvCheckedListBox)
        Me.lowerInvGroupBox.Controls.Add(Me.ArticulosInvCheckedListBox)
        Me.lowerInvGroupBox.Enabled = False
        Me.lowerInvGroupBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lowerInvGroupBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.lowerInvGroupBox.Location = New System.Drawing.Point(5, 285)
        Me.lowerInvGroupBox.Name = "lowerInvGroupBox"
        Me.lowerInvGroupBox.Size = New System.Drawing.Size(799, 237)
        Me.lowerInvGroupBox.TabIndex = 30
        Me.lowerInvGroupBox.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(400, 22)
        Me.Label10.MaximumSize = New System.Drawing.Size(392, 21)
        Me.Label10.MinimumSize = New System.Drawing.Size(392, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(392, 21)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Articulos de los que es autor"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 22)
        Me.Label9.MaximumSize = New System.Drawing.Size(392, 21)
        Me.Label9.MinimumSize = New System.Drawing.Size(392, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(392, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Conferencias a las que asiste"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'conferenciasInvCheckedListBox
        '
        Me.conferenciasInvCheckedListBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.conferenciasInvCheckedListBox.FormattingEnabled = True
        Me.conferenciasInvCheckedListBox.HorizontalScrollbar = True
        Me.conferenciasInvCheckedListBox.Location = New System.Drawing.Point(5, 56)
        Me.conferenciasInvCheckedListBox.Name = "conferenciasInvCheckedListBox"
        Me.conferenciasInvCheckedListBox.Size = New System.Drawing.Size(392, 172)
        Me.conferenciasInvCheckedListBox.TabIndex = 5
        '
        'ArticulosInvCheckedListBox
        '
        Me.ArticulosInvCheckedListBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ArticulosInvCheckedListBox.FormattingEnabled = True
        Me.ArticulosInvCheckedListBox.HorizontalScrollbar = True
        Me.ArticulosInvCheckedListBox.Location = New System.Drawing.Point(401, 56)
        Me.ArticulosInvCheckedListBox.Name = "ArticulosInvCheckedListBox"
        Me.ArticulosInvCheckedListBox.Size = New System.Drawing.Size(392, 172)
        Me.ArticulosInvCheckedListBox.TabIndex = 4
        '
        'ButtonsInvGroupBox
        '
        Me.ButtonsInvGroupBox.Controls.Add(Me.ModificarInvButton)
        Me.ButtonsInvGroupBox.Controls.Add(Me.AnadirInvButton)
        Me.ButtonsInvGroupBox.Controls.Add(Me.LimpiarInvButton)
        Me.ButtonsInvGroupBox.Controls.Add(Me.EliminarInvButton)
        Me.ButtonsInvGroupBox.Enabled = False
        Me.ButtonsInvGroupBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonsInvGroupBox.Location = New System.Drawing.Point(627, 98)
        Me.ButtonsInvGroupBox.Name = "ButtonsInvGroupBox"
        Me.ButtonsInvGroupBox.Size = New System.Drawing.Size(177, 181)
        Me.ButtonsInvGroupBox.TabIndex = 29
        Me.ButtonsInvGroupBox.TabStop = False
        '
        'ModificarInvButton
        '
        Me.ModificarInvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificarInvButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarInvButton.Location = New System.Drawing.Point(7, 102)
        Me.ModificarInvButton.Name = "ModificarInvButton"
        Me.ModificarInvButton.Size = New System.Drawing.Size(164, 30)
        Me.ModificarInvButton.TabIndex = 23
        Me.ModificarInvButton.Text = "Modificar"
        Me.ModificarInvButton.UseVisualStyleBackColor = True
        '
        'AnadirInvButton
        '
        Me.AnadirInvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnadirInvButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnadirInvButton.Location = New System.Drawing.Point(7, 143)
        Me.AnadirInvButton.Name = "AnadirInvButton"
        Me.AnadirInvButton.Size = New System.Drawing.Size(164, 27)
        Me.AnadirInvButton.TabIndex = 22
        Me.AnadirInvButton.Text = "Añadir"
        Me.AnadirInvButton.UseVisualStyleBackColor = True
        '
        'LimpiarInvButton
        '
        Me.LimpiarInvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LimpiarInvButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimpiarInvButton.Location = New System.Drawing.Point(6, 18)
        Me.LimpiarInvButton.Name = "LimpiarInvButton"
        Me.LimpiarInvButton.Size = New System.Drawing.Size(164, 30)
        Me.LimpiarInvButton.TabIndex = 21
        Me.LimpiarInvButton.Text = "Limpiar"
        Me.LimpiarInvButton.UseVisualStyleBackColor = True
        '
        'EliminarInvButton
        '
        Me.EliminarInvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarInvButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarInvButton.Location = New System.Drawing.Point(6, 61)
        Me.EliminarInvButton.Name = "EliminarInvButton"
        Me.EliminarInvButton.Size = New System.Drawing.Size(164, 27)
        Me.EliminarInvButton.TabIndex = 19
        Me.EliminarInvButton.Text = "Eliminar"
        Me.EliminarInvButton.UseVisualStyleBackColor = True
        '
        'DatosInvGroupBox
        '
        Me.DatosInvGroupBox.Controls.Add(Me.IDInvTextBox)
        Me.DatosInvGroupBox.Controls.Add(Me.NombreInvTextBox)
        Me.DatosInvGroupBox.Controls.Add(Me.Label8)
        Me.DatosInvGroupBox.Controls.Add(Me.ApellidosInvTextBox)
        Me.DatosInvGroupBox.Controls.Add(Me.DespachoInvTextBox)
        Me.DatosInvGroupBox.Controls.Add(Me.Label7)
        Me.DatosInvGroupBox.Controls.Add(Me.EdificioInvTextBox)
        Me.DatosInvGroupBox.Controls.Add(Me.Label6)
        Me.DatosInvGroupBox.Controls.Add(Me.DepartamentoInvTextBox)
        Me.DatosInvGroupBox.Controls.Add(Me.Label5)
        Me.DatosInvGroupBox.Controls.Add(Me.TelefonoInvTextBox)
        Me.DatosInvGroupBox.Controls.Add(Me.Label4)
        Me.DatosInvGroupBox.Controls.Add(Me.EmailInvTextBox)
        Me.DatosInvGroupBox.Controls.Add(Me.Label3)
        Me.DatosInvGroupBox.Controls.Add(Me.Label1)
        Me.DatosInvGroupBox.Controls.Add(Me.Label2)
        Me.DatosInvGroupBox.Enabled = False
        Me.DatosInvGroupBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.DatosInvGroupBox.Location = New System.Drawing.Point(223, 1)
        Me.DatosInvGroupBox.Name = "DatosInvGroupBox"
        Me.DatosInvGroupBox.Size = New System.Drawing.Size(398, 278)
        Me.DatosInvGroupBox.TabIndex = 28
        Me.DatosInvGroupBox.TabStop = False
        '
        'IDInvTextBox
        '
        Me.IDInvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDInvTextBox.Enabled = False
        Me.IDInvTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDInvTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.IDInvTextBox.Location = New System.Drawing.Point(143, 19)
        Me.IDInvTextBox.Name = "IDInvTextBox"
        Me.IDInvTextBox.ReadOnly = True
        Me.IDInvTextBox.Size = New System.Drawing.Size(249, 26)
        Me.IDInvTextBox.TabIndex = 1
        '
        'NombreInvTextBox
        '
        Me.NombreInvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreInvTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreInvTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.NombreInvTextBox.Location = New System.Drawing.Point(143, 51)
        Me.NombreInvTextBox.Name = "NombreInvTextBox"
        Me.NombreInvTextBox.Size = New System.Drawing.Size(249, 26)
        Me.NombreInvTextBox.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Email"
        '
        'ApellidosInvTextBox
        '
        Me.ApellidosInvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApellidosInvTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosInvTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ApellidosInvTextBox.Location = New System.Drawing.Point(143, 83)
        Me.ApellidosInvTextBox.Name = "ApellidosInvTextBox"
        Me.ApellidosInvTextBox.Size = New System.Drawing.Size(249, 26)
        Me.ApellidosInvTextBox.TabIndex = 3
        '
        'DespachoInvTextBox
        '
        Me.DespachoInvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DespachoInvTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DespachoInvTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.DespachoInvTextBox.Location = New System.Drawing.Point(143, 115)
        Me.DespachoInvTextBox.Name = "DespachoInvTextBox"
        Me.DespachoInvTextBox.Size = New System.Drawing.Size(249, 26)
        Me.DespachoInvTextBox.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Teléfono"
        '
        'EdificioInvTextBox
        '
        Me.EdificioInvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EdificioInvTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdificioInvTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.EdificioInvTextBox.Location = New System.Drawing.Point(143, 147)
        Me.EdificioInvTextBox.Name = "EdificioInvTextBox"
        Me.EdificioInvTextBox.Size = New System.Drawing.Size(249, 26)
        Me.EdificioInvTextBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Departamento"
        '
        'DepartamentoInvTextBox
        '
        Me.DepartamentoInvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DepartamentoInvTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartamentoInvTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.DepartamentoInvTextBox.Location = New System.Drawing.Point(143, 179)
        Me.DepartamentoInvTextBox.Name = "DepartamentoInvTextBox"
        Me.DepartamentoInvTextBox.Size = New System.Drawing.Size(249, 26)
        Me.DepartamentoInvTextBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Edificio"
        '
        'TelefonoInvTextBox
        '
        Me.TelefonoInvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TelefonoInvTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoInvTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.TelefonoInvTextBox.Location = New System.Drawing.Point(143, 211)
        Me.TelefonoInvTextBox.Name = "TelefonoInvTextBox"
        Me.TelefonoInvTextBox.Size = New System.Drawing.Size(249, 26)
        Me.TelefonoInvTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Despacho"
        '
        'EmailInvTextBox
        '
        Me.EmailInvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailInvTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailInvTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.EmailInvTextBox.Location = New System.Drawing.Point(143, 243)
        Me.EmailInvTextBox.Name = "EmailInvTextBox"
        Me.EmailInvTextBox.Size = New System.Drawing.Size(249, 26)
        Me.EmailInvTextBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'EditModeInvButton
        '
        Me.EditModeInvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditModeInvButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditModeInvButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.EditModeInvButton.Location = New System.Drawing.Point(627, 11)
        Me.EditModeInvButton.Name = "EditModeInvButton"
        Me.EditModeInvButton.Size = New System.Drawing.Size(177, 81)
        Me.EditModeInvButton.TabIndex = 26
        Me.EditModeInvButton.Text = "Edit mode"
        Me.EditModeInvButton.UseVisualStyleBackColor = True
        '
        'InvestigadoresInvListBox
        '
        Me.InvestigadoresInvListBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.InvestigadoresInvListBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.InvestigadoresInvListBox.FormattingEnabled = True
        Me.InvestigadoresInvListBox.HorizontalScrollbar = True
        Me.InvestigadoresInvListBox.ItemHeight = 19
        Me.InvestigadoresInvListBox.Location = New System.Drawing.Point(5, 9)
        Me.InvestigadoresInvListBox.Name = "InvestigadoresInvListBox"
        Me.InvestigadoresInvListBox.Size = New System.Drawing.Size(212, 270)
        Me.InvestigadoresInvListBox.TabIndex = 25
        '
        'Tab_Conferencias
        '
        Me.Tab_Conferencias.Controls.Add(Me.lowerConfGroupBox)
        Me.Tab_Conferencias.Controls.Add(Me.ButtonsConfGroupBox)
        Me.Tab_Conferencias.Controls.Add(Me.DatosConfGroupBox)
        Me.Tab_Conferencias.Controls.Add(Me.EditModeConfButton)
        Me.Tab_Conferencias.Controls.Add(Me.ConferenciasConfListBox)
        Me.Tab_Conferencias.Location = New System.Drawing.Point(4, 26)
        Me.Tab_Conferencias.Name = "Tab_Conferencias"
        Me.Tab_Conferencias.Size = New System.Drawing.Size(814, 531)
        Me.Tab_Conferencias.TabIndex = 2
        Me.Tab_Conferencias.Text = "Conferencias"
        Me.Tab_Conferencias.UseVisualStyleBackColor = True
        '
        'lowerConfGroupBox
        '
        Me.lowerConfGroupBox.Controls.Add(Me.ArticulosConfListBox)
        Me.lowerConfGroupBox.Controls.Add(Me.Label11)
        Me.lowerConfGroupBox.Controls.Add(Me.Label12)
        Me.lowerConfGroupBox.Controls.Add(Me.AsistentesConfCheckedListBox)
        Me.lowerConfGroupBox.Enabled = False
        Me.lowerConfGroupBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lowerConfGroupBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.lowerConfGroupBox.Location = New System.Drawing.Point(5, 247)
        Me.lowerConfGroupBox.Name = "lowerConfGroupBox"
        Me.lowerConfGroupBox.Size = New System.Drawing.Size(799, 275)
        Me.lowerConfGroupBox.TabIndex = 35
        Me.lowerConfGroupBox.TabStop = False
        '
        'ArticulosConfListBox
        '
        Me.ArticulosConfListBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ArticulosConfListBox.FormattingEnabled = True
        Me.ArticulosConfListBox.HorizontalScrollbar = True
        Me.ArticulosConfListBox.ItemHeight = 19
        Me.ArticulosConfListBox.Location = New System.Drawing.Point(401, 56)
        Me.ArticulosConfListBox.Name = "ArticulosConfListBox"
        Me.ArticulosConfListBox.Size = New System.Drawing.Size(392, 213)
        Me.ArticulosConfListBox.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(400, 22)
        Me.Label11.MaximumSize = New System.Drawing.Size(392, 21)
        Me.Label11.MinimumSize = New System.Drawing.Size(392, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(392, 21)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Articulos de esta conferencia"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 22)
        Me.Label12.MaximumSize = New System.Drawing.Size(392, 21)
        Me.Label12.MinimumSize = New System.Drawing.Size(392, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(392, 21)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Asistentes"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AsistentesConfCheckedListBox
        '
        Me.AsistentesConfCheckedListBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.AsistentesConfCheckedListBox.FormattingEnabled = True
        Me.AsistentesConfCheckedListBox.HorizontalScrollbar = True
        Me.AsistentesConfCheckedListBox.Location = New System.Drawing.Point(5, 56)
        Me.AsistentesConfCheckedListBox.Name = "AsistentesConfCheckedListBox"
        Me.AsistentesConfCheckedListBox.Size = New System.Drawing.Size(392, 214)
        Me.AsistentesConfCheckedListBox.TabIndex = 5
        '
        'ButtonsConfGroupBox
        '
        Me.ButtonsConfGroupBox.Controls.Add(Me.ModificarConfButton)
        Me.ButtonsConfGroupBox.Controls.Add(Me.AnadirConfButton)
        Me.ButtonsConfGroupBox.Controls.Add(Me.LimpiarConfButton)
        Me.ButtonsConfGroupBox.Controls.Add(Me.EliminarConfButton)
        Me.ButtonsConfGroupBox.Enabled = False
        Me.ButtonsConfGroupBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.ButtonsConfGroupBox.Location = New System.Drawing.Point(627, 52)
        Me.ButtonsConfGroupBox.Name = "ButtonsConfGroupBox"
        Me.ButtonsConfGroupBox.Size = New System.Drawing.Size(177, 189)
        Me.ButtonsConfGroupBox.TabIndex = 34
        Me.ButtonsConfGroupBox.TabStop = False
        '
        'ModificarConfButton
        '
        Me.ModificarConfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificarConfButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarConfButton.Location = New System.Drawing.Point(6, 99)
        Me.ModificarConfButton.Name = "ModificarConfButton"
        Me.ModificarConfButton.Size = New System.Drawing.Size(164, 30)
        Me.ModificarConfButton.TabIndex = 25
        Me.ModificarConfButton.Text = "Modificar"
        Me.ModificarConfButton.UseVisualStyleBackColor = True
        '
        'AnadirConfButton
        '
        Me.AnadirConfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnadirConfButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnadirConfButton.Location = New System.Drawing.Point(6, 140)
        Me.AnadirConfButton.Name = "AnadirConfButton"
        Me.AnadirConfButton.Size = New System.Drawing.Size(164, 27)
        Me.AnadirConfButton.TabIndex = 24
        Me.AnadirConfButton.Text = "Añadir"
        Me.AnadirConfButton.UseVisualStyleBackColor = True
        '
        'LimpiarConfButton
        '
        Me.LimpiarConfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LimpiarConfButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LimpiarConfButton.Location = New System.Drawing.Point(6, 18)
        Me.LimpiarConfButton.Name = "LimpiarConfButton"
        Me.LimpiarConfButton.Size = New System.Drawing.Size(164, 30)
        Me.LimpiarConfButton.TabIndex = 21
        Me.LimpiarConfButton.Text = "Limpiar"
        Me.LimpiarConfButton.UseVisualStyleBackColor = True
        '
        'EliminarConfButton
        '
        Me.EliminarConfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarConfButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarConfButton.Location = New System.Drawing.Point(6, 57)
        Me.EliminarConfButton.Name = "EliminarConfButton"
        Me.EliminarConfButton.Size = New System.Drawing.Size(164, 27)
        Me.EliminarConfButton.TabIndex = 19
        Me.EliminarConfButton.Text = "Eliminar"
        Me.EliminarConfButton.UseVisualStyleBackColor = True
        '
        'DatosConfGroupBox
        '
        Me.DatosConfGroupBox.Controls.Add(Me.InicioConfTextBox)
        Me.DatosConfGroupBox.Controls.Add(Me.FinConfTextBox)
        Me.DatosConfGroupBox.Controls.Add(Me.IDConfTextBox)
        Me.DatosConfGroupBox.Controls.Add(Me.SiglasConfTextBox)
        Me.DatosConfGroupBox.Controls.Add(Me.NombreConfTextBox)
        Me.DatosConfGroupBox.Controls.Add(Me.LugarConfTextBox)
        Me.DatosConfGroupBox.Controls.Add(Me.Label15)
        Me.DatosConfGroupBox.Controls.Add(Me.Label16)
        Me.DatosConfGroupBox.Controls.Add(Me.Label17)
        Me.DatosConfGroupBox.Controls.Add(Me.Label18)
        Me.DatosConfGroupBox.Controls.Add(Me.Label19)
        Me.DatosConfGroupBox.Controls.Add(Me.Label20)
        Me.DatosConfGroupBox.Enabled = False
        Me.DatosConfGroupBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.DatosConfGroupBox.Location = New System.Drawing.Point(223, 1)
        Me.DatosConfGroupBox.Name = "DatosConfGroupBox"
        Me.DatosConfGroupBox.Size = New System.Drawing.Size(398, 240)
        Me.DatosConfGroupBox.TabIndex = 33
        Me.DatosConfGroupBox.TabStop = False
        '
        'InicioConfTextBox
        '
        Me.InicioConfTextBox.Location = New System.Drawing.Point(143, 145)
        Me.InicioConfTextBox.Name = "InicioConfTextBox"
        Me.InicioConfTextBox.Size = New System.Drawing.Size(249, 25)
        Me.InicioConfTextBox.TabIndex = 18
        '
        'FinConfTextBox
        '
        Me.FinConfTextBox.Location = New System.Drawing.Point(143, 177)
        Me.FinConfTextBox.Name = "FinConfTextBox"
        Me.FinConfTextBox.Size = New System.Drawing.Size(249, 25)
        Me.FinConfTextBox.TabIndex = 17
        '
        'IDConfTextBox
        '
        Me.IDConfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDConfTextBox.Enabled = False
        Me.IDConfTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDConfTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.IDConfTextBox.Location = New System.Drawing.Point(143, 19)
        Me.IDConfTextBox.Name = "IDConfTextBox"
        Me.IDConfTextBox.ReadOnly = True
        Me.IDConfTextBox.Size = New System.Drawing.Size(249, 26)
        Me.IDConfTextBox.TabIndex = 1
        '
        'SiglasConfTextBox
        '
        Me.SiglasConfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SiglasConfTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiglasConfTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.SiglasConfTextBox.Location = New System.Drawing.Point(143, 51)
        Me.SiglasConfTextBox.Name = "SiglasConfTextBox"
        Me.SiglasConfTextBox.Size = New System.Drawing.Size(249, 26)
        Me.SiglasConfTextBox.TabIndex = 2
        '
        'NombreConfTextBox
        '
        Me.NombreConfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreConfTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreConfTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.NombreConfTextBox.Location = New System.Drawing.Point(143, 83)
        Me.NombreConfTextBox.Name = "NombreConfTextBox"
        Me.NombreConfTextBox.Size = New System.Drawing.Size(249, 26)
        Me.NombreConfTextBox.TabIndex = 3
        '
        'LugarConfTextBox
        '
        Me.LugarConfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LugarConfTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LugarConfTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.LugarConfTextBox.Location = New System.Drawing.Point(143, 115)
        Me.LugarConfTextBox.Name = "LugarConfTextBox"
        Me.LugarConfTextBox.Size = New System.Drawing.Size(249, 26)
        Me.LugarConfTextBox.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 19)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Fin"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 19)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Inicio"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 118)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 19)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Lugar"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(10, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 19)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Nombre"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 19)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "ID"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 19)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Siglas"
        '
        'EditModeConfButton
        '
        Me.EditModeConfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditModeConfButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditModeConfButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.EditModeConfButton.Location = New System.Drawing.Point(627, 11)
        Me.EditModeConfButton.Name = "EditModeConfButton"
        Me.EditModeConfButton.Size = New System.Drawing.Size(177, 35)
        Me.EditModeConfButton.TabIndex = 32
        Me.EditModeConfButton.Text = "Edit mode"
        Me.EditModeConfButton.UseVisualStyleBackColor = True
        '
        'ConferenciasConfListBox
        '
        Me.ConferenciasConfListBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ConferenciasConfListBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ConferenciasConfListBox.FormattingEnabled = True
        Me.ConferenciasConfListBox.HorizontalScrollbar = True
        Me.ConferenciasConfListBox.ItemHeight = 19
        Me.ConferenciasConfListBox.Location = New System.Drawing.Point(5, 9)
        Me.ConferenciasConfListBox.Name = "ConferenciasConfListBox"
        Me.ConferenciasConfListBox.Size = New System.Drawing.Size(212, 232)
        Me.ConferenciasConfListBox.TabIndex = 31
        '
        'Tab_Articulos
        '
        Me.Tab_Articulos.Controls.Add(Me.lowerArtGroupBox)
        Me.Tab_Articulos.Controls.Add(Me.buttonArtGroupBox)
        Me.Tab_Articulos.Controls.Add(Me.DatosArtGroupBox)
        Me.Tab_Articulos.Controls.Add(Me.editModeArtButton)
        Me.Tab_Articulos.Controls.Add(Me.ArticulosArtListBox)
        Me.Tab_Articulos.Location = New System.Drawing.Point(4, 26)
        Me.Tab_Articulos.Name = "Tab_Articulos"
        Me.Tab_Articulos.Size = New System.Drawing.Size(814, 531)
        Me.Tab_Articulos.TabIndex = 3
        Me.Tab_Articulos.Text = "Articulos"
        Me.Tab_Articulos.UseVisualStyleBackColor = True
        '
        'lowerArtGroupBox
        '
        Me.lowerArtGroupBox.Controls.Add(Me.AbajoArtButton)
        Me.lowerArtGroupBox.Controls.Add(Me.OrdenArtListBox)
        Me.lowerArtGroupBox.Controls.Add(Me.ArribaArtButton)
        Me.lowerArtGroupBox.Controls.Add(Me.Label21)
        Me.lowerArtGroupBox.Controls.Add(Me.Label22)
        Me.lowerArtGroupBox.Controls.Add(Me.AutoresArtCheckedListBox)
        Me.lowerArtGroupBox.Enabled = False
        Me.lowerArtGroupBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lowerArtGroupBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.lowerArtGroupBox.Location = New System.Drawing.Point(5, 226)
        Me.lowerArtGroupBox.Name = "lowerArtGroupBox"
        Me.lowerArtGroupBox.Size = New System.Drawing.Size(799, 296)
        Me.lowerArtGroupBox.TabIndex = 35
        Me.lowerArtGroupBox.TabStop = False
        '
        'AbajoArtButton
        '
        Me.AbajoArtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AbajoArtButton.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbajoArtButton.Image = CType(resources.GetObject("AbajoArtButton.Image"), System.Drawing.Image)
        Me.AbajoArtButton.Location = New System.Drawing.Point(772, 173)
        Me.AbajoArtButton.Name = "AbajoArtButton"
        Me.AbajoArtButton.Size = New System.Drawing.Size(19, 116)
        Me.AbajoArtButton.TabIndex = 23
        Me.AbajoArtButton.Text = "↓"
        Me.AbajoArtButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.AbajoArtButton.UseVisualStyleBackColor = True
        '
        'OrdenArtListBox
        '
        Me.OrdenArtListBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.OrdenArtListBox.FormattingEnabled = True
        Me.OrdenArtListBox.HorizontalScrollbar = True
        Me.OrdenArtListBox.ItemHeight = 19
        Me.OrdenArtListBox.Location = New System.Drawing.Point(400, 57)
        Me.OrdenArtListBox.Name = "OrdenArtListBox"
        Me.OrdenArtListBox.Size = New System.Drawing.Size(372, 232)
        Me.OrdenArtListBox.TabIndex = 22
        '
        'ArribaArtButton
        '
        Me.ArribaArtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArribaArtButton.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArribaArtButton.Image = CType(resources.GetObject("ArribaArtButton.Image"), System.Drawing.Image)
        Me.ArribaArtButton.Location = New System.Drawing.Point(772, 57)
        Me.ArribaArtButton.Name = "ArribaArtButton"
        Me.ArribaArtButton.Size = New System.Drawing.Size(19, 116)
        Me.ArribaArtButton.TabIndex = 20
        Me.ArribaArtButton.Text = "↑"
        Me.ArribaArtButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ArribaArtButton.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(400, 22)
        Me.Label21.MaximumSize = New System.Drawing.Size(392, 21)
        Me.Label21.MinimumSize = New System.Drawing.Size(392, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(392, 21)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Orden de los autores"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(5, 22)
        Me.Label22.MaximumSize = New System.Drawing.Size(392, 21)
        Me.Label22.MinimumSize = New System.Drawing.Size(392, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(392, 21)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Autores"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AutoresArtCheckedListBox
        '
        Me.AutoresArtCheckedListBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.AutoresArtCheckedListBox.FormattingEnabled = True
        Me.AutoresArtCheckedListBox.HorizontalScrollbar = True
        Me.AutoresArtCheckedListBox.Location = New System.Drawing.Point(5, 56)
        Me.AutoresArtCheckedListBox.Name = "AutoresArtCheckedListBox"
        Me.AutoresArtCheckedListBox.Size = New System.Drawing.Size(392, 235)
        Me.AutoresArtCheckedListBox.TabIndex = 5
        '
        'buttonArtGroupBox
        '
        Me.buttonArtGroupBox.Controls.Add(Me.ModificarArtButton)
        Me.buttonArtGroupBox.Controls.Add(Me.AnadirArtButton)
        Me.buttonArtGroupBox.Controls.Add(Me.limpiarCurButton)
        Me.buttonArtGroupBox.Controls.Add(Me.EliminarArtButton)
        Me.buttonArtGroupBox.Enabled = False
        Me.buttonArtGroupBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.buttonArtGroupBox.Location = New System.Drawing.Point(627, 51)
        Me.buttonArtGroupBox.Name = "buttonArtGroupBox"
        Me.buttonArtGroupBox.Size = New System.Drawing.Size(177, 171)
        Me.buttonArtGroupBox.TabIndex = 34
        Me.buttonArtGroupBox.TabStop = False
        '
        'ModificarArtButton
        '
        Me.ModificarArtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModificarArtButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModificarArtButton.Location = New System.Drawing.Point(7, 97)
        Me.ModificarArtButton.Name = "ModificarArtButton"
        Me.ModificarArtButton.Size = New System.Drawing.Size(164, 30)
        Me.ModificarArtButton.TabIndex = 27
        Me.ModificarArtButton.Text = "Modificar"
        Me.ModificarArtButton.UseVisualStyleBackColor = True
        '
        'AnadirArtButton
        '
        Me.AnadirArtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnadirArtButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnadirArtButton.Location = New System.Drawing.Point(7, 138)
        Me.AnadirArtButton.Name = "AnadirArtButton"
        Me.AnadirArtButton.Size = New System.Drawing.Size(164, 27)
        Me.AnadirArtButton.TabIndex = 26
        Me.AnadirArtButton.Text = "Añadir"
        Me.AnadirArtButton.UseVisualStyleBackColor = True
        '
        'limpiarCurButton
        '
        Me.limpiarCurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.limpiarCurButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiarCurButton.Location = New System.Drawing.Point(6, 18)
        Me.limpiarCurButton.Name = "limpiarCurButton"
        Me.limpiarCurButton.Size = New System.Drawing.Size(164, 30)
        Me.limpiarCurButton.TabIndex = 21
        Me.limpiarCurButton.Text = "Limpiar"
        Me.limpiarCurButton.UseVisualStyleBackColor = True
        '
        'EliminarArtButton
        '
        Me.EliminarArtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarArtButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarArtButton.Location = New System.Drawing.Point(6, 55)
        Me.EliminarArtButton.Name = "EliminarArtButton"
        Me.EliminarArtButton.Size = New System.Drawing.Size(164, 27)
        Me.EliminarArtButton.TabIndex = 19
        Me.EliminarArtButton.Text = "Eliminar"
        Me.EliminarArtButton.UseVisualStyleBackColor = True
        '
        'DatosArtGroupBox
        '
        Me.DatosArtGroupBox.Controls.Add(Me.PagFinArtTextBox)
        Me.DatosArtGroupBox.Controls.Add(Me.PagInicioArtTextBox)
        Me.DatosArtGroupBox.Controls.Add(Me.ConferenciaArtComboBox)
        Me.DatosArtGroupBox.Controls.Add(Me.IDArtTextBox)
        Me.DatosArtGroupBox.Controls.Add(Me.TituloArtTextBox)
        Me.DatosArtGroupBox.Controls.Add(Me.Label26)
        Me.DatosArtGroupBox.Controls.Add(Me.Label27)
        Me.DatosArtGroupBox.Controls.Add(Me.Label28)
        Me.DatosArtGroupBox.Controls.Add(Me.Label29)
        Me.DatosArtGroupBox.Controls.Add(Me.Label30)
        Me.DatosArtGroupBox.Enabled = False
        Me.DatosArtGroupBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.DatosArtGroupBox.Location = New System.Drawing.Point(223, 1)
        Me.DatosArtGroupBox.Name = "DatosArtGroupBox"
        Me.DatosArtGroupBox.Size = New System.Drawing.Size(398, 221)
        Me.DatosArtGroupBox.TabIndex = 33
        Me.DatosArtGroupBox.TabStop = False
        '
        'PagFinArtTextBox
        '
        Me.PagFinArtTextBox.Location = New System.Drawing.Point(143, 117)
        Me.PagFinArtTextBox.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.PagFinArtTextBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PagFinArtTextBox.Name = "PagFinArtTextBox"
        Me.PagFinArtTextBox.Size = New System.Drawing.Size(249, 25)
        Me.PagFinArtTextBox.TabIndex = 16
        Me.PagFinArtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PagFinArtTextBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PagInicioArtTextBox
        '
        Me.PagInicioArtTextBox.Location = New System.Drawing.Point(143, 85)
        Me.PagInicioArtTextBox.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.PagInicioArtTextBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PagInicioArtTextBox.Name = "PagInicioArtTextBox"
        Me.PagInicioArtTextBox.Size = New System.Drawing.Size(249, 25)
        Me.PagInicioArtTextBox.TabIndex = 15
        Me.PagInicioArtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PagInicioArtTextBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ConferenciaArtComboBox
        '
        Me.ConferenciaArtComboBox.BackColor = System.Drawing.Color.White
        Me.ConferenciaArtComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConferenciaArtComboBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ConferenciaArtComboBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ConferenciaArtComboBox.FormattingEnabled = True
        Me.ConferenciaArtComboBox.Location = New System.Drawing.Point(143, 148)
        Me.ConferenciaArtComboBox.Name = "ConferenciaArtComboBox"
        Me.ConferenciaArtComboBox.Size = New System.Drawing.Size(249, 27)
        Me.ConferenciaArtComboBox.TabIndex = 14
        '
        'IDArtTextBox
        '
        Me.IDArtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IDArtTextBox.Enabled = False
        Me.IDArtTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDArtTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.IDArtTextBox.Location = New System.Drawing.Point(143, 19)
        Me.IDArtTextBox.Name = "IDArtTextBox"
        Me.IDArtTextBox.ReadOnly = True
        Me.IDArtTextBox.Size = New System.Drawing.Size(249, 26)
        Me.IDArtTextBox.TabIndex = 1
        '
        'TituloArtTextBox
        '
        Me.TituloArtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TituloArtTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloArtTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.TituloArtTextBox.Location = New System.Drawing.Point(143, 51)
        Me.TituloArtTextBox.Name = "TituloArtTextBox"
        Me.TituloArtTextBox.Size = New System.Drawing.Size(249, 26)
        Me.TituloArtTextBox.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(10, 150)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(102, 19)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "Conferencia"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(10, 118)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(71, 19)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Pag. Fin"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(10, 86)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 19)
        Me.Label28.TabIndex = 11
        Me.Label28.Text = "Pag. Inicio"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(10, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(25, 19)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "ID"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(10, 54)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(52, 19)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Titulo"
        '
        'editModeArtButton
        '
        Me.editModeArtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editModeArtButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editModeArtButton.ForeColor = System.Drawing.Color.DarkOrange
        Me.editModeArtButton.Location = New System.Drawing.Point(627, 11)
        Me.editModeArtButton.Name = "editModeArtButton"
        Me.editModeArtButton.Size = New System.Drawing.Size(177, 35)
        Me.editModeArtButton.TabIndex = 32
        Me.editModeArtButton.Text = "Edit mode"
        Me.editModeArtButton.UseVisualStyleBackColor = True
        '
        'ArticulosArtListBox
        '
        Me.ArticulosArtListBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ArticulosArtListBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.ArticulosArtListBox.FormattingEnabled = True
        Me.ArticulosArtListBox.HorizontalScrollbar = True
        Me.ArticulosArtListBox.ItemHeight = 19
        Me.ArticulosArtListBox.Location = New System.Drawing.Point(5, 9)
        Me.ArticulosArtListBox.Name = "ArticulosArtListBox"
        Me.ArticulosArtListBox.Size = New System.Drawing.Size(212, 213)
        Me.ArticulosArtListBox.TabIndex = 31
        '
        'Tab_Curriculums
        '
        Me.Tab_Curriculums.Controls.Add(Me.InvestigadorCurComboBox)
        Me.Tab_Curriculums.Controls.Add(Me.Label13)
        Me.Tab_Curriculums.Controls.Add(Me.CurriculumCurTextBox)
        Me.Tab_Curriculums.Location = New System.Drawing.Point(4, 26)
        Me.Tab_Curriculums.Name = "Tab_Curriculums"
        Me.Tab_Curriculums.Size = New System.Drawing.Size(814, 531)
        Me.Tab_Curriculums.TabIndex = 4
        Me.Tab_Curriculums.Text = "Curriculums"
        Me.Tab_Curriculums.UseVisualStyleBackColor = True
        '
        'InvestigadorCurComboBox
        '
        Me.InvestigadorCurComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InvestigadorCurComboBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.InvestigadorCurComboBox.ForeColor = System.Drawing.Color.DarkOrange
        Me.InvestigadorCurComboBox.FormattingEnabled = True
        Me.InvestigadorCurComboBox.Location = New System.Drawing.Point(99, 12)
        Me.InvestigadorCurComboBox.Name = "InvestigadorCurComboBox"
        Me.InvestigadorCurComboBox.Size = New System.Drawing.Size(711, 25)
        Me.InvestigadorCurComboBox.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label13.Location = New System.Drawing.Point(8, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Investigador"
        '
        'CurriculumCurTextBox
        '
        Me.CurriculumCurTextBox.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.CurriculumCurTextBox.Location = New System.Drawing.Point(8, 46)
        Me.CurriculumCurTextBox.Multiline = True
        Me.CurriculumCurTextBox.Name = "CurriculumCurTextBox"
        Me.CurriculumCurTextBox.ReadOnly = True
        Me.CurriculumCurTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CurriculumCurTextBox.Size = New System.Drawing.Size(802, 476)
        Me.CurriculumCurTextBox.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirBBDDToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(63, 21)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AbrirBBDDToolStripMenuItem
        '
        Me.AbrirBBDDToolStripMenuItem.Image = CType(resources.GetObject("AbrirBBDDToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirBBDDToolStripMenuItem.Name = "AbrirBBDDToolStripMenuItem"
        Me.AbrirBBDDToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AbrirBBDDToolStripMenuItem.Text = "Abrir BBDD"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem1})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(78, 21)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de..."
        '
        'Interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 587)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Interfaz"
        Me.Text = "Curricula Vitarum"
        Me.Tabs.ResumeLayout(False)
        Me.Tab_Investigadores.ResumeLayout(False)
        Me.lowerInvGroupBox.ResumeLayout(False)
        Me.lowerInvGroupBox.PerformLayout()
        Me.ButtonsInvGroupBox.ResumeLayout(False)
        Me.DatosInvGroupBox.ResumeLayout(False)
        Me.DatosInvGroupBox.PerformLayout()
        Me.Tab_Conferencias.ResumeLayout(False)
        Me.lowerConfGroupBox.ResumeLayout(False)
        Me.lowerConfGroupBox.PerformLayout()
        Me.ButtonsConfGroupBox.ResumeLayout(False)
        Me.DatosConfGroupBox.ResumeLayout(False)
        Me.DatosConfGroupBox.PerformLayout()
        Me.Tab_Articulos.ResumeLayout(False)
        Me.lowerArtGroupBox.ResumeLayout(False)
        Me.lowerArtGroupBox.PerformLayout()
        Me.buttonArtGroupBox.ResumeLayout(False)
        Me.DatosArtGroupBox.ResumeLayout(False)
        Me.DatosArtGroupBox.PerformLayout()
        CType(Me.PagFinArtTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagInicioArtTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Curriculums.ResumeLayout(False)
        Me.Tab_Curriculums.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tabs As TabControl
    Friend WithEvents Tab_Investigadores As TabPage
    Friend WithEvents Tab_Conferencias As TabPage
    Friend WithEvents Tab_Articulos As TabPage
    Friend WithEvents Tab_Curriculums As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirBBDDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DatosInvGroupBox As GroupBox
    Friend WithEvents IDInvTextBox As TextBox
    Friend WithEvents NombreInvTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ApellidosInvTextBox As TextBox
    Friend WithEvents DespachoInvTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EdificioInvTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DepartamentoInvTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TelefonoInvTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EmailInvTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LimpiarInvButton As Button
    Friend WithEvents EliminarInvButton As Button
    Friend WithEvents EditModeInvButton As Button
    Friend WithEvents InvestigadoresInvListBox As ListBox
    Friend WithEvents ButtonsInvGroupBox As GroupBox
    Friend WithEvents lowerInvGroupBox As GroupBox
    Friend WithEvents conferenciasInvCheckedListBox As CheckedListBox
    Friend WithEvents ArticulosInvCheckedListBox As CheckedListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lowerConfGroupBox As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents AsistentesConfCheckedListBox As CheckedListBox
    Friend WithEvents ButtonsConfGroupBox As GroupBox
    Friend WithEvents LimpiarConfButton As Button
    Friend WithEvents EliminarConfButton As Button
    Friend WithEvents DatosConfGroupBox As GroupBox
    Friend WithEvents IDConfTextBox As TextBox
    Friend WithEvents SiglasConfTextBox As TextBox
    Friend WithEvents NombreConfTextBox As TextBox
    Friend WithEvents LugarConfTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents EditModeConfButton As Button
    Friend WithEvents ConferenciasConfListBox As ListBox
    Friend WithEvents lowerArtGroupBox As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents AutoresArtCheckedListBox As CheckedListBox
    Friend WithEvents buttonArtGroupBox As GroupBox
    Friend WithEvents limpiarCurButton As Button
    Friend WithEvents EliminarArtButton As Button
    Friend WithEvents DatosArtGroupBox As GroupBox
    Friend WithEvents IDArtTextBox As TextBox
    Friend WithEvents TituloArtTextBox As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents editModeArtButton As Button
    Friend WithEvents ArticulosArtListBox As ListBox
    Friend WithEvents ArticulosConfListBox As ListBox
    Friend WithEvents ConferenciaArtComboBox As ComboBox
    Friend WithEvents ArribaArtButton As Button
    Friend WithEvents OrdenArtListBox As ListBox
    Friend WithEvents AbajoArtButton As Button
    Friend WithEvents CurriculumCurTextBox As TextBox
    Friend WithEvents InvestigadorCurComboBox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ModificarInvButton As Button
    Friend WithEvents AnadirInvButton As Button
    Friend WithEvents ModificarConfButton As Button
    Friend WithEvents AnadirConfButton As Button
    Friend WithEvents ModificarArtButton As Button
    Friend WithEvents AnadirArtButton As Button
    Friend WithEvents InicioConfTextBox As DateTimePicker
    Friend WithEvents FinConfTextBox As DateTimePicker
    Friend WithEvents PagInicioArtTextBox As NumericUpDown
    Friend WithEvents PagFinArtTextBox As NumericUpDown
End Class
