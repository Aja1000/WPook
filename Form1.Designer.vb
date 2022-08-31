<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_newProyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_openProyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_closeProyecto = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmi_save = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistapreviadeimpresiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmi_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_deshacer = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_rehacer = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tmsi_cortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmsi_copiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmsi_pegar = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SeleccionartodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecapitularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_reindexing = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_deleteProyect = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContenidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmi_Trello = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxt_texto = New System.Windows.Forms.RichTextBox()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.Shotcuts = New System.Windows.Forms.ToolStrip()
        Me.tsb_new = New System.Windows.Forms.ToolStripButton()
        Me.tsb_open = New System.Windows.Forms.ToolStripButton()
        Me.tsb_reloadChapters = New System.Windows.Forms.ToolStripButton()
        Me.tsb_rechapter = New System.Windows.Forms.ToolStripButton()
        Me.tscb_chapters = New System.Windows.Forms.ToolStripComboBox()
        Me.tslbl_Chapters = New System.Windows.Forms.ToolStripLabel()
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.lbl_nPalabras = New System.Windows.Forms.Label()
        Me.AutoSave = New System.Windows.Forms.Timer(Me.components)
        Me.tsb_save = New System.Windows.Forms.ToolStripButton()
        Me.MainMenu.SuspendLayout()
        Me.Shotcuts.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.SystemColors.Menu
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(978, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_newProyecto, Me.tsmi_openProyecto, Me.tsmi_closeProyecto, Me.toolStripSeparator, Me.tsmi_save, Me.toolStripSeparator1, Me.ImprimirToolStripMenuItem, Me.VistapreviadeimpresiónToolStripMenuItem, Me.toolStripSeparator2, Me.tsmi_exit})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'tsmi_newProyecto
        '
        Me.tsmi_newProyecto.Image = CType(resources.GetObject("tsmi_newProyecto.Image"), System.Drawing.Image)
        Me.tsmi_newProyecto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmi_newProyecto.Name = "tsmi_newProyecto"
        Me.tsmi_newProyecto.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tsmi_newProyecto.Size = New System.Drawing.Size(206, 22)
        Me.tsmi_newProyecto.Text = "&Nuevo"
        '
        'tsmi_openProyecto
        '
        Me.tsmi_openProyecto.Image = CType(resources.GetObject("tsmi_openProyecto.Image"), System.Drawing.Image)
        Me.tsmi_openProyecto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmi_openProyecto.Name = "tsmi_openProyecto"
        Me.tsmi_openProyecto.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsmi_openProyecto.Size = New System.Drawing.Size(206, 22)
        Me.tsmi_openProyecto.Text = "&Abrir"
        '
        'tsmi_closeProyecto
        '
        Me.tsmi_closeProyecto.Name = "tsmi_closeProyecto"
        Me.tsmi_closeProyecto.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsmi_closeProyecto.Size = New System.Drawing.Size(206, 22)
        Me.tsmi_closeProyecto.Text = "Cerrar Proyecto"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(203, 6)
        '
        'tsmi_save
        '
        Me.tsmi_save.Image = CType(resources.GetObject("tsmi_save.Image"), System.Drawing.Image)
        Me.tsmi_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmi_save.Name = "tsmi_save"
        Me.tsmi_save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmi_save.Size = New System.Drawing.Size(206, 22)
        Me.tsmi_save.Text = "&Guardar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(203, 6)
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Image = CType(resources.GetObject("ImprimirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ImprimirToolStripMenuItem.Text = "&Imprimir"
        '
        'VistapreviadeimpresiónToolStripMenuItem
        '
        Me.VistapreviadeimpresiónToolStripMenuItem.Image = CType(resources.GetObject("VistapreviadeimpresiónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.VistapreviadeimpresiónToolStripMenuItem.Name = "VistapreviadeimpresiónToolStripMenuItem"
        Me.VistapreviadeimpresiónToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.VistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(203, 6)
        '
        'tsmi_exit
        '
        Me.tsmi_exit.Name = "tsmi_exit"
        Me.tsmi_exit.Size = New System.Drawing.Size(206, 22)
        Me.tsmi_exit.Text = "&Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_deshacer, Me.tsmi_rehacer, Me.toolStripSeparator3, Me.tmsi_cortar, Me.tmsi_copiar, Me.tmsi_pegar, Me.toolStripSeparator4, Me.SeleccionartodoToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'tsmi_deshacer
        '
        Me.tsmi_deshacer.Name = "tsmi_deshacer"
        Me.tsmi_deshacer.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.tsmi_deshacer.Size = New System.Drawing.Size(163, 22)
        Me.tsmi_deshacer.Text = "&Deshacer"
        '
        'tsmi_rehacer
        '
        Me.tsmi_rehacer.Name = "tsmi_rehacer"
        Me.tsmi_rehacer.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.tsmi_rehacer.Size = New System.Drawing.Size(163, 22)
        Me.tsmi_rehacer.Text = "&Rehacer"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(160, 6)
        '
        'tmsi_cortar
        '
        Me.tmsi_cortar.Image = CType(resources.GetObject("tmsi_cortar.Image"), System.Drawing.Image)
        Me.tmsi_cortar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmsi_cortar.Name = "tmsi_cortar"
        Me.tmsi_cortar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.tmsi_cortar.Size = New System.Drawing.Size(163, 22)
        Me.tmsi_cortar.Text = "Cor&tar"
        '
        'tmsi_copiar
        '
        Me.tmsi_copiar.Image = CType(resources.GetObject("tmsi_copiar.Image"), System.Drawing.Image)
        Me.tmsi_copiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmsi_copiar.Name = "tmsi_copiar"
        Me.tmsi_copiar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tmsi_copiar.Size = New System.Drawing.Size(163, 22)
        Me.tmsi_copiar.Text = "&Copiar"
        '
        'tmsi_pegar
        '
        Me.tmsi_pegar.Image = CType(resources.GetObject("tmsi_pegar.Image"), System.Drawing.Image)
        Me.tmsi_pegar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tmsi_pegar.Name = "tmsi_pegar"
        Me.tmsi_pegar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.tmsi_pegar.Size = New System.Drawing.Size(163, 22)
        Me.tmsi_pegar.Text = "&Pegar"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(160, 6)
        '
        'SeleccionartodoToolStripMenuItem
        '
        Me.SeleccionartodoToolStripMenuItem.Name = "SeleccionartodoToolStripMenuItem"
        Me.SeleccionartodoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SeleccionartodoToolStripMenuItem.Text = "&Seleccionar todo"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecapitularToolStripMenuItem, Me.tsmi_reindexing, Me.tsmi_deleteProyect, Me.PersonalizarToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.ToolStripSeparator6})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "&Herramientas"
        '
        'RecapitularToolStripMenuItem
        '
        Me.RecapitularToolStripMenuItem.Name = "RecapitularToolStripMenuItem"
        Me.RecapitularToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.RecapitularToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.RecapitularToolStripMenuItem.Text = "Recapitular"
        '
        'tsmi_reindexing
        '
        Me.tsmi_reindexing.Name = "tsmi_reindexing"
        Me.tsmi_reindexing.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.tsmi_reindexing.Size = New System.Drawing.Size(268, 22)
        Me.tsmi_reindexing.Text = "Reindexar"
        '
        'tsmi_deleteProyect
        '
        Me.tsmi_deleteProyect.Name = "tsmi_deleteProyect"
        Me.tsmi_deleteProyect.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.Escape), System.Windows.Forms.Keys)
        Me.tsmi_deleteProyect.Size = New System.Drawing.Size(268, 22)
        Me.tsmi_deleteProyect.Text = "Borrar Proyecto"
        '
        'PersonalizarToolStripMenuItem
        '
        Me.PersonalizarToolStripMenuItem.Name = "PersonalizarToolStripMenuItem"
        Me.PersonalizarToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.PersonalizarToolStripMenuItem.Text = "&Personalizar"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(265, 6)
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContenidoToolStripMenuItem, Me.ÍndiceToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.toolStripSeparator5, Me.tsmi_Trello})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'ContenidoToolStripMenuItem
        '
        Me.ContenidoToolStripMenuItem.Name = "ContenidoToolStripMenuItem"
        Me.ContenidoToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ContenidoToolStripMenuItem.Text = "&Contenido"
        '
        'ÍndiceToolStripMenuItem
        '
        Me.ÍndiceToolStripMenuItem.Name = "ÍndiceToolStripMenuItem"
        Me.ÍndiceToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ÍndiceToolStripMenuItem.Text = "Índic&e"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BuscarToolStripMenuItem.Text = "&Buscar"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(127, 6)
        '
        'tsmi_Trello
        '
        Me.tsmi_Trello.Name = "tsmi_Trello"
        Me.tsmi_Trello.Size = New System.Drawing.Size(130, 22)
        Me.tsmi_Trello.Text = "Trello"
        '
        'rtxt_texto
        '
        Me.rtxt_texto.AcceptsTab = True
        Me.rtxt_texto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxt_texto.Location = New System.Drawing.Point(12, 56)
        Me.rtxt_texto.Name = "rtxt_texto"
        Me.rtxt_texto.Size = New System.Drawing.Size(954, 431)
        Me.rtxt_texto.TabIndex = 1
        Me.rtxt_texto.Text = ""
        '
        'FolderBrowser
        '
        Me.FolderBrowser.SelectedPath = "D:\PruebasWpook"
        '
        'Shotcuts
        '
        Me.Shotcuts.BackColor = System.Drawing.SystemColors.Menu
        Me.Shotcuts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_new, Me.tsb_open, Me.tsb_save, Me.tsb_reloadChapters, Me.tsb_rechapter, Me.tscb_chapters, Me.tslbl_Chapters})
        Me.Shotcuts.Location = New System.Drawing.Point(0, 24)
        Me.Shotcuts.Name = "Shotcuts"
        Me.Shotcuts.Size = New System.Drawing.Size(978, 25)
        Me.Shotcuts.TabIndex = 2
        Me.Shotcuts.Text = "ToolStrip1"
        '
        'tsb_new
        '
        Me.tsb_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_new.Image = CType(resources.GetObject("tsb_new.Image"), System.Drawing.Image)
        Me.tsb_new.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_new.Name = "tsb_new"
        Me.tsb_new.Size = New System.Drawing.Size(23, 22)
        Me.tsb_new.Text = "Nuevo"
        '
        'tsb_open
        '
        Me.tsb_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_open.Image = CType(resources.GetObject("tsb_open.Image"), System.Drawing.Image)
        Me.tsb_open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_open.Name = "tsb_open"
        Me.tsb_open.Size = New System.Drawing.Size(23, 22)
        Me.tsb_open.Text = "Abrir"
        '
        'tsb_reloadChapters
        '
        Me.tsb_reloadChapters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_reloadChapters.Image = CType(resources.GetObject("tsb_reloadChapters.Image"), System.Drawing.Image)
        Me.tsb_reloadChapters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_reloadChapters.Name = "tsb_reloadChapters"
        Me.tsb_reloadChapters.Size = New System.Drawing.Size(23, 22)
        Me.tsb_reloadChapters.Text = "Recargar Capitulos"
        '
        'tsb_rechapter
        '
        Me.tsb_rechapter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsb_rechapter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_rechapter.Image = CType(resources.GetObject("tsb_rechapter.Image"), System.Drawing.Image)
        Me.tsb_rechapter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_rechapter.Name = "tsb_rechapter"
        Me.tsb_rechapter.Size = New System.Drawing.Size(23, 22)
        Me.tsb_rechapter.Text = "Recapitular"
        '
        'tscb_chapters
        '
        Me.tscb_chapters.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tscb_chapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscb_chapters.Name = "tscb_chapters"
        Me.tscb_chapters.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tscb_chapters.Size = New System.Drawing.Size(250, 25)
        '
        'tslbl_Chapters
        '
        Me.tslbl_Chapters.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslbl_Chapters.Name = "tslbl_Chapters"
        Me.tslbl_Chapters.Size = New System.Drawing.Size(60, 22)
        Me.tslbl_Chapters.Text = "Capitulos:"
        '
        'lbl_nPalabras
        '
        Me.lbl_nPalabras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_nPalabras.AutoSize = True
        Me.lbl_nPalabras.Location = New System.Drawing.Point(12, 489)
        Me.lbl_nPalabras.Name = "lbl_nPalabras"
        Me.lbl_nPalabras.Size = New System.Drawing.Size(0, 13)
        Me.lbl_nPalabras.TabIndex = 3
        '
        'AutoSave
        '
        Me.AutoSave.Enabled = True
        Me.AutoSave.Interval = 600000
        '
        'tsb_save
        '
        Me.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_save.Image = CType(resources.GetObject("tsb_save.Image"), System.Drawing.Image)
        Me.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_save.Name = "tsb_save"
        Me.tsb_save.Size = New System.Drawing.Size(23, 22)
        Me.tsb_save.Text = "Guardar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 504)
        Me.Controls.Add(Me.lbl_nPalabras)
        Me.Controls.Add(Me.rtxt_texto)
        Me.Controls.Add(Me.Shotcuts)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.MinimumSize = New System.Drawing.Size(450, 250)
        Me.Name = "Form1"
        Me.Text = "WPook"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.Shotcuts.ResumeLayout(False)
        Me.Shotcuts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmi_newProyecto As ToolStripMenuItem
    Friend WithEvents tsmi_openProyecto As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents tsmi_save As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VistapreviadeimpresiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmi_exit As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmi_deshacer As ToolStripMenuItem
    Friend WithEvents tsmi_rehacer As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tmsi_cortar As ToolStripMenuItem
    Friend WithEvents tmsi_copiar As ToolStripMenuItem
    Friend WithEvents tmsi_pegar As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SeleccionartodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContenidoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsmi_Trello As ToolStripMenuItem
    Friend WithEvents FolderBrowser As FolderBrowserDialog
    Friend WithEvents Shotcuts As ToolStrip
    Friend WithEvents tsmi_closeProyecto As ToolStripMenuItem
    Friend WithEvents tsmi_deleteProyect As ToolStripMenuItem
    Friend WithEvents tsb_new As ToolStripButton
    Friend WithEvents tsb_open As ToolStripButton
    Friend WithEvents tsb_reloadChapters As ToolStripButton
    Friend WithEvents tslbl_Chapters As ToolStripLabel
    Friend WithEvents tscb_chapters As ToolStripComboBox
    Friend WithEvents tsb_rechapter As ToolStripButton
    Friend WithEvents rtxt_texto As RichTextBox
    Friend WithEvents RecapitularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents SaveFile As SaveFileDialog
    Friend WithEvents tsmi_reindexing As ToolStripMenuItem
    Friend WithEvents lbl_nPalabras As Label
    Public WithEvents AutoSave As Timer
    Friend WithEvents tsb_save As ToolStripButton
End Class
