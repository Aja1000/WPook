Imports System.IO
Imports System.Configuration

Public Class Form1
    'Esta variable almacena la ruta del proyecto. 
    'Solo hasta el directorio donde se guardan los archivos
    'Ej: C:\Users\PabloAja1000\Documents\Libros\ProyectoWPook
    Public proyectPath As String
    'Variable para guardar la ruta anterior cuando realizas 
    'una accion sin Guardar
    Public originalPath As String
    'pa22pu@gmail.com//P!k0lo99 Trello
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'proyecto_blanco()
        closeProyect()
        tsb_reloadChapters.Enabled = True ' Borrar al terminar las pruebas
        Me.WindowState = FormWindowState.Maximized
        'AutoSave.Interval = 10000

    End Sub
    ' Abre el formulario de creacion de Poyectos
    Private Sub newProyect()
        saveAndClose()
        WinProyectsCreator.Show()
    End Sub
    'Abre un proyecto
    Public Sub openProyect()
        saveAndClose()
        If FolderBrowser.ShowDialog() = Windows.Forms.DialogResult.OK Then
            proyectPath = FolderBrowser.SelectedPath
            correctIndexCheking()
            reloadChapters()
            Me.Text = proyectFile() & " - WPook"
            rtxt_texto.Enabled = True
            tscb_chapters.Enabled = True
            tscb_chapters.SelectedIndex = 0
            tsb_reloadChapters.Enabled = True
            tsb_rechapter.Enabled = True
            tsmi_reindexing.Enabled = True
            tsb_save.BackColor = Form.DefaultBackColor
        End If
    End Sub
    'Cierra el proyecto actual
    Public Sub closeProyect()
        saveAndClose()
        proyectPath = ""
        Me.Text = "WPook"
        tscb_chapters.Enabled = False
        tscb_chapters.Items.Clear()
        tscb_chapters.Text = ""
        rtxt_texto.Text = ""
        rtxt_texto.Enabled = False
        lbl_nPalabras.Text = ""
        originalPath = ""
        tsb_reloadChapters.Enabled = False
        tsb_rechapter.Enabled = False
        tsmi_reindexing.Enabled = False
        tsb_save.BackColor = Form.DefaultBackColor
    End Sub
    'Determina si se ha modificado el archivo abierto en ese momento
    Private Sub rtxt_texto_TextChanged(sender As Object, e As EventArgs) Handles rtxt_texto.TextChanged
        If rtxt_texto.Text <> "" Then
            Dim cuenta_palabras = Split(rtxt_texto.Text, " ")
            Dim npalabras As Integer = UBound(cuenta_palabras) + 1
            lbl_nPalabras.Text = "Conteo: " & npalabras & " palabras y " & Len(rtxt_texto.Text) & " caracteres"
        Else
            lbl_nPalabras.Text = ""
        End If

        If rtxt_texto.Text <> originalPath Then
            tsb_save.BackColor = Color.Red
        Else
            tsb_save.BackColor = Form.DefaultBackColor
        End If
    End Sub
    'Rellena el ComboBox de Capitulos
    Public Sub reloadChapters()
        tscb_chapters.Items.Clear()
        Dim fileReader
        ' Creamos el index en caso de que no exista del Index 
        If File.Exists(proyectPath & "\" & proyectFile("index")) Then
            fileReader = File.ReadAllText(proyectPath & "\" & proyectFile("index"))
        Else
            MsgBox("No se ha podido encontrar el indice del Proyecto")
        End If

        If fileReader <> "" Then
            fileReader = fileReader.TrimEnd("|")
            Dim fileNames() As String = fileReader.Split("|")
            For chapters As Integer = 0 To fileNames.GetUpperBound(0)
                tscb_chapters.Items.Add(fileNames(chapters))
            Next
            tscb_chapters.Items.Add("Nuevo Capitulo")
        Else
            tscb_chapters.Items.Add("Nuevo Capitulo")
        End If
        tscb_chapters.SelectedIndex = 0

    End Sub
    'Guarda el Archivo abierto
    Public Sub save()
        If Directory.Exists(proyectPath) Then
            If tscb_chapters.SelectedItem <> "Nuevo Capitulo" Then 'GUARDAR
                Dim archivo As String = proyectPath & "\" & tscb_chapters.SelectedItem & ".wpok"
                File.WriteAllText(archivo, rtxt_texto.Text)
                tsb_save.BackColor = Form.DefaultBackColor
                originalPath = rtxt_texto.Text
                MsgBox("Archivo guardado correctamente", MsgBoxStyle.OkOnly, "Guardado")

            Else 'GUARDAR COMO -> Nuevo Capitulo

                SaveFile.Filter = "Archivos de Texto (*.wpok*)|*.wpok"
                SaveFile.InitialDirectory = proyectPath
                SaveFile.FileName = ""

                If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then

                    File.WriteAllText(SaveFile.FileName, rtxt_texto.Text)
                    File.WriteAllText(proyectPath & "\" & proyectFile("index"),
                                                    Path.GetFileNameWithoutExtension(SaveFile.FileName) & "|") 'AAAAAAAAAAAAACreacion Index(Sobrescritura)
                    reloadChapters()
                    'Tras recargar el combobox le decimos que se quede en elemento creado que por logica permanecera en ultima posicion
                    tscb_chapters.SelectedIndex = tscb_chapters.Items.Count - 2
                End If
            End If
        Else
            ' Metodo para cuando empieces en blanco al inicia la app
            'SaveFile.Filter = "Archivos de Texto (*.wpok*)|*.wpok"

            'If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    fileSystem.WriteAllText(SaveFile.FileName, rtxt_texto.Text, False)
            '    fileSystem.WriteAllText(SaveFile.FileName & "\" & Path.GetFileNameWithoutExtension(SaveFile.FileName) & ".index",
            '                                            Path.GetFileNameWithoutExtension(SaveFile.FileName) & "|", True)
            '    reloadChapters()
            '    'Tras recargar el combobox le decimos que se quede en elemento creado que por logica permanecera en ultima posicion
            '    tscb_chapters.SelectedIndex = tscb_chapters.Items.Count - 2
            'End If
        End If
    End Sub
    Private Sub tsmi_nuevoProyecto_Click(sender As Object, e As EventArgs) Handles tsmi_newProyecto.Click
        newProyect()
    End Sub
    Private Sub tsb_nuevo_Click(sender As Object, e As EventArgs) Handles tsb_new.Click
        newProyect()
    End Sub
    Private Sub tsmi_abrirProyecto_Click(sender As Object, e As EventArgs) Handles tsmi_openProyecto.Click
        openProyect()
    End Sub
    Private Sub tsb_abrir_Click(sender As Object, e As EventArgs) Handles tsb_open.Click
        openProyect()
    End Sub
    Private Sub tsmi_Guardar_Click(sender As Object, e As EventArgs) Handles tsmi_save.Click
        save()
    End Sub
    Private Sub tsb_save_Click(sender As Object, e As EventArgs) Handles tsb_save.Click
        save()
    End Sub
    ' Abre el formulario para la reestructuracion de capitulos
    Private Sub tsb_reOrderChapter_Click(sender As Object, e As EventArgs) Handles tsb_rechapter.Click
        'Cambiar nombre para ser igual que el otro (reindexing)
        saveAndClose()
        WinRechapter.Show()
    End Sub
    'Metodo para hacer prubas
    Private Sub tsb_refrescarCapitulos_Click(sender As Object, e As EventArgs) Handles tsb_reloadChapters.Click
        'Al final este objeto acabara por desaparecer ya que la recarga se hara de forma automatica
        'saveAndClose()
        'reloadChapters()
        'filesindex()
        'usingAppConfigFile()
    End Sub
    'Metodo para Borrar un proyecto Complto
    Private Sub tsmi_deleteProyect_Click(sender As Object, e As EventArgs) Handles tsmi_deleteProyect.Click
        My.Computer.FileSystem.DeleteDirectory(proyectPath,
            FileIO.UIOption.AllDialogs,
            FileIO.RecycleOption.DeletePermanently,
            FileIO.UICancelOption.ThrowException)

        closeProyect()
    End Sub
    Private Sub tsmi_cerrarProyecto_Click(sender As Object, e As EventArgs) Handles tsmi_closeProyecto.Click
        closeProyect()
    End Sub
    Private Sub tsmi_salir_Click(sender As Object, e As EventArgs) Handles tsmi_exit.Click
        saveAndClose()
        Me.Close()
    End Sub
    Private Sub tsmi_reindexing_Click(sender As Object, e As EventArgs) Handles tsmi_reindexing.Click
        saveAndClose()
        WinRechapter.Show()
    End Sub
    Private Sub tmsi_copiar_Click(sender As Object, e As EventArgs) Handles tmsi_copiar.Click
        rtxt_texto.Copy()
    End Sub
    Private Sub tmsi_cortar_Click(sender As Object, e As EventArgs) Handles tmsi_cortar.Click
        rtxt_texto.Cut()
    End Sub
    Private Sub tmsi_pegar_Click(sender As Object, e As EventArgs) Handles tmsi_pegar.Click
        rtxt_texto.Paste()
    End Sub
    Private Sub tsmi_deshacer_Click(sender As Object, e As EventArgs) Handles tsmi_deshacer.Click
        rtxt_texto.Undo()
    End Sub
    Private Sub tsmi_rehacer_Click(sender As Object, e As EventArgs) Handles tsmi_rehacer.Click
        rtxt_texto.Redo()
    End Sub
    Private Sub tsmi_Trello_Click(sender As Object, e As EventArgs) Handles tsmi_Trello.Click
        System.Diagnostics.Process.Start("https://trello.com/b/Sf3Letyl/wpook")
    End Sub
    'Medotodo de AutoGuardado
    Private Sub AutoSave_Tick(sender As Object, e As EventArgs) Handles AutoSave.Tick
        '300 000 = 5 mins
        save()
    End Sub
    Private Sub tscb_capitulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscb_chapters.SelectedIndexChanged
        saveAndClose()
        If tscb_chapters.SelectedItem = "Nuevo Capitulo" Then
            rtxt_texto.Text = ""
        Else
            Dim fileReader As String = File.ReadAllText(proyectPath & "\" & tscb_chapters.SelectedItem & ".wpok")
            rtxt_texto.Text = fileReader
            originalPath = fileReader
        End If
        rtxt_texto.Select()
        tsb_save.BackColor = Form.DefaultBackColor
    End Sub
    Private Sub tsb_save_BackColorChanged(sender As Object, e As EventArgs) Handles tsb_save.BackColorChanged
        If tsb_save.BackColor = Form.DefaultBackColor Then
            AutoSave.Enabled = False
        ElseIf tsb_save.BackColor = Color.Red Then
            AutoSave.Enabled = True
        End If
    End Sub
    Private Sub proyecto_blanco()
        Me.Text = "Nuevo Proyecto - WPook"
        tscb_chapters.Items.Add("Nuevo Capitulo")
        tscb_chapters.SelectedIndex = 0
    End Sub
    Public Function proyectFile(Optional ByVal index As String = "index")
        Dim fileindex
        If index = "index" Then

            fileindex = Path.GetFileName(proyectPath) & ".index"
            fileindex = fileindex.Replace(" ", "_")
        Else
            fileindex = Path.GetFileName(proyectPath)
        End If
        Return fileindex
    End Function
    Public Sub correctIndexCheking()
        Dim numArchivos As Integer = My.Computer.FileSystem.GetFiles(proyectPath, FileIO.SearchOption.SearchTopLevelOnly, "*.wpok").Count
        Dim numIndex As Integer = File.ReadAllText(proyectPath & "\" & proyectFile("index")).TrimEnd("|").Split("|").Count
        Dim iteraciones As Integer = 0
        Dim index As String
        Dim fileReader As String

        If File.Exists(proyectPath & "\" & proyectFile("index")) Then
            fileReader = File.ReadAllText(proyectPath & "\" & proyectFile("index"))

            Dim fileNames() As String = fileReader.TrimEnd("|").Split("|")
            For Each namechapter In My.Computer.FileSystem.GetFiles(proyectPath, FileIO.SearchOption.SearchTopLevelOnly, "*.wpok") 'Archivos
                iteraciones = 0
                For chapters As Integer = 0 To fileNames.GetUpperBound(0) 'Index
                    If fileNames(chapters) = Path.GetFileNameWithoutExtension(namechapter) Then
                        Exit For
                    Else
                        iteraciones += 1
                        If iteraciones = numIndex Then
                            index += File.ReadAllText(proyectPath & "\" & proyectFile("index")) & Path.GetFileNameWithoutExtension(namechapter) & "|"
                        End If
                    End If
                Next
            Next namechapter

            File.WriteAllText(proyectPath & "\" & proyectFile("index"), index)
            index = ""
            ''''''''''' METODO PARA BORRAR LOS CAPITULOS EXTRA EN EL INDEX
            'Dim indexNames() As String = File.ReadAllText(proyectPath & "\" & proyectFile("index")).TrimEnd("|").Split("|")
            'For chapters As Integer = 0 To indexNames.GetUpperBound(0) 'Index
            '    Console.WriteLine("Primero " & indexNames(chapters))
            '    For Each namechapter In My.Computer.FileSystem.GetFiles(proyectPath, FileIO.SearchOption.SearchTopLevelOnly, "*.wpok") 'Archivos
            '        Console.WriteLine("Segundo " & Path.GetFileNameWithoutExtension(namechapter))
            '        If indexNames(chapters) = Path.GetFileNameWithoutExtension(namechapter) Then
            '            index += index & Path.GetFileNameWithoutExtension(namechapter) & "|"
            '            Console.WriteLine("Index: " & index)
            '            Exit For
            '        End If
            '    Next namechapter
            'Next
            'Console.WriteLine(index)
            'File.WriteAllText(proyectPath & "\" & proyectFile("index"), index)

        Else
            'Con bucle recogemos todos los nombres del fichero separandolos con un pipe|
            'Vale cualquier caracter que no se pueda usar para nombre de fichero
            For Each namechapter In My.Computer.FileSystem.GetFiles(proyectPath, FileIO.SearchOption.SearchTopLevelOnly, "*.wpok")
                index = index & Path.GetFileNameWithoutExtension(namechapter) & "|"
            Next namechapter
            ' Creamos el archivo index y lo guardamos en una variable
            File.WriteAllText(proyectPath & "\" & proyectFile("index"), index) 'AAAAAAAAAAAAACreacion Index
        End If

    End Sub
    Public Sub usingAppConfigFile()

        'Dim configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        'Dim name As String = ConfigurationManager.AppSettings("TIMER_INTERVAL")
        'MsgBox(name)

        'configuration.AppSettings.Settings.Remove("TIMER_INTERVAL")
        ''configuration.AppSettings.Settings.Add("TIMER_INTERVAL", 600000)
        'configuration.Save(ConfigurationSaveMode.Modified)
        ''End

        ''NO Funciona
        ''Dim name As String = ConfigurationManager.AppSettings("TIMER_INTERVAL")
        ''ConfigurationManager.AppSettings("TIMER_INTERVAL").Replace(name, 600000)
        ''https://www.aspsnippets.com/Articles/Read-AppSettings-value-from-AppConfig-file-using-C-and-VBNet.aspx

    End Sub
    Public Sub saveAndClose()
        If tsb_save.BackColor = Color.Red Then
            Dim saves = MessageBox.Show("¿Desea guardar los ultimos cambios de " & tscb_chapters.SelectedItem & " antes de continuar?",
                           "Guardar Cambios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If saves = DialogResult.Yes Then
                save()
            ElseIf saves = DialogResult.Cancel Then
                Exit Sub 'Sale del metodo pero necesito que salga del metodo en el que se usa 
                '' Se puede usar una salida [return] para determinar el tipo de salida y a partir de ahi hacer un trycatch
            Else

            End If
        End If
    End Sub
    Private Sub btn_Excel_Click(sender As Object, e As EventArgs) Handles btn_Excel.Click
        'Si no se consigue trabajar directamente con excel habria que renombrar archivo ...
        'Dim excel = fileSystem.GetFile(proyectPath, FileIO.SearchOption.SearchAllSubDirectories, ".xlsx")
        Dim fileExcel = Path.GetFileName(proyectPath).Replace(" ", "_")
        fileExcel = proyectPath & "\" & fileExcel & ".xlsx"
        If (File.Exists(fileExcel)) Then
            'Esto funciona a la perfeccion
            Process.Start(fileExcel)
        Else
            'De momento conseguimos que lance un excel vacio
            Process.Start("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.exe")
        End If
    End Sub
End Class