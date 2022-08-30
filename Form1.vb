﻿Imports System.Drawing.Drawing2D
Imports System.IO

Public Class Form1
    'Esta variable almacena la ruta del proyecto. 
    'Solo hasta el directorio donde se guardan los archivos
    'Ej: C:\Users\PabloAja1000\Documents\Libros\ProyectoWPook
    Public proyectPath As String
    Public fileSystem = My.Computer.FileSystem

    'pa22pu@gmail.com//P!k0lo99 Trello
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'proyecto_blanco()
        closeProyect()
        tsb_reloadChapters.Enabled = True ' Borrar al terminar las pruebas
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub newProyect()
        WinProyectsCreator.Show()
    End Sub
    Public Sub openProyect()
        If FolderBrowser.ShowDialog() = Windows.Forms.DialogResult.OK Then
            proyectPath = FolderBrowser.SelectedPath
            reloadChapters()
            Me.Text = proyectFolder() & " - WPook"
            rtxt_texto.Enabled = True
            tscb_chapters.Enabled = True
            tscb_chapters.SelectedIndex = 0
            tsb_reloadChapters.Enabled = True
            tsb_rechapter.Enabled = True
            tsmi_reindexing.Enabled = True
            tscb_chapters.BackColor = Color.White
        End If

    End Sub
    Public Sub closeProyect()
        proyectPath = ""
        Me.Text = "WPook"
        tscb_chapters.Enabled = False
        tscb_chapters.Items.Clear()
        tscb_chapters.Text = ""
        rtxt_texto.Enabled = False
        rtxt_texto.Text = ""
        tsb_reloadChapters.Enabled = False
        tsb_rechapter.Enabled = False
        tsmi_reindexing.Enabled = False
        tscb_chapters.BackColor = Form.DefaultBackColor
        lbl_nPalabras.Text = ""

    End Sub
    Private Sub rtxt_texto_TextChanged(sender As Object, e As EventArgs) Handles rtxt_texto.TextChanged
        WordCount()
        tscb_chapters.BackColor = Color.Red
    End Sub
    Public Sub reloadChapters()
        tscb_chapters.Items.Clear()
        Dim indexfiles
        ' Creamos el index en caso de que no existadel Index 
        Try
            indexfiles = fileSystem.GetFiles(proyectPath, FileIO.SearchOption.SearchAllSubDirectories, proyectFolder("index"))
        Catch ex As Exception
            ' Recogemos los archivos .wpok que existan en la carpeta proyecto
            Dim wpok = fileSystem.GetFiles(proyectPath, FileIO.SearchOption.SearchAllSubDirectories, ".wpok")
            Dim index As String = ""
            'Con bucle recogemos todos los nombres del fichero separandolos con un pipe|
            'Vale cualquier caracter que no se pueda usar para nombre de fichero
            For Each namechapter As String In wpok
                index = index & Path.GetFileNameWithoutExtension(namechapter) & "|"
            Next namechapter
            ' Creamos el archivo index y lo guardamos en una variable
            fileSystem.WriteAllText(proyectPath & "\" & proyectFolder("index"), index, False) 'AAAAAAAAAAAAACreacion Index
            indexfiles = fileSystem.GetFiles(proyectPath, FileIO.SearchOption.SearchAllSubDirectories, proyectFolder("index"))
        End Try
        Dim fileReader As String = ""
        For Each indexfile In indexfiles
            fileReader = fileSystem.ReadAllText(indexfile)
        Next
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

        ' Revisar idea y combinarla con lo nuevo 
        ' El metodo nuevo falla si metes un archivo a mano que no este en el index. Parcialmente solucionado pero se puede mejorar

    End Sub
    Public Sub save()
        If Directory.Exists(proyectPath) Then
            If tscb_chapters.SelectedItem <> "Nuevo Capitulo" Then 'GUARDAR
                Dim archivo As String = proyectPath & "\" & tscb_chapters.SelectedItem & ".wpok"
                fileSystem.WriteAllText(archivo, rtxt_texto.Text, False)
                tscb_chapters.BackColor = Color.White
                MsgBox("Archivo guardado correctamente")

            Else 'GUARDAR COMO -> Nuevo Capitulo

                SaveFile.Filter = "Archivos de Texto (*.wpok*)|*.wpok"
                SaveFile.InitialDirectory = proyectPath
                SaveFile.FileName = ""

                If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then

                    fileSystem.WriteAllText(SaveFile.FileName, rtxt_texto.Text, False)
                    fileSystem.WriteAllText(proyectPath & "\" & proyectFolder("index"),
                                                    Path.GetFileNameWithoutExtension(SaveFile.FileName) & "|", True) 'AAAAAAAAAAAAACreacion Index(Sobrescritura)
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
    Private Sub tsb_reOrderChapter_Click(sender As Object, e As EventArgs) Handles tsb_rechapter.Click
        WinRechapter.Show()
    End Sub
    Private Sub tsb_refrescarCapitulos_Click(sender As Object, e As EventArgs) Handles tsb_reloadChapters.Click
        'Al final este objeto acabara por desaparecer ya que la recarga se hara de forma automatica
        'reloadChapters()
        'filesindex()
        pruebaBucles()
    End Sub
    Private Sub tsmi_deleteProyect_Click(sender As Object, e As EventArgs) Handles tsmi_deleteProyect.Click
        fileSystem.DeleteDirectory(proyectPath,
            FileIO.UIOption.AllDialogs,
            FileIO.RecycleOption.DeletePermanently,
            FileIO.UICancelOption.ThrowException)

        closeProyect()
    End Sub
    Private Sub tsmi_cerrarProyecto_Click(sender As Object, e As EventArgs) Handles tsmi_closeProyecto.Click
        closeProyect()
    End Sub
    Private Sub tsmi_salir_Click(sender As Object, e As EventArgs) Handles tsmi_exit.Click
        Me.Close()
    End Sub
    Private Sub tsmi_reindexing_Click(sender As Object, e As EventArgs) Handles tsmi_reindexing.Click
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
    Private Sub AutoSave_Tick(sender As Object, e As EventArgs) Handles AutoSave.Tick
        '300 000 5 mins
        save()
    End Sub
    Private Sub cb_capitulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscb_chapters.SelectedIndexChanged
        If tscb_chapters.SelectedItem = "Nuevo Capitulo" Then
            rtxt_texto.Text = ""
        Else ' El fallo de aqui se debe a que se guarda al final con un pipeline(|) extra
            Dim fileReader As String = fileSystem.ReadAllText(proyectPath & "\" & tscb_chapters.SelectedItem & ".wpok")
            rtxt_texto.Text = fileReader
        End If
        rtxt_texto.Select()
        tscb_chapters.BackColor = Color.White
    End Sub
    Private Sub proyecto_blanco()
        Me.Text = "Nuevo Proyecto - WPook"
        tscb_chapters.Items.Add("Nuevo Capitulo")
        tscb_chapters.SelectedIndex = 0
    End Sub
    Public Function proyectFolder(Optional ByVal index As String = "index")
        Dim fileindex
        If index = "index" Then

            fileindex = Path.GetFileName(proyectPath) & ".index"
            fileindex = fileindex.Replace(" ", "_")
        Else
            fileindex = Path.GetFileName(proyectPath)
        End If
        Return fileindex
    End Function
    Private Sub WordCount()
        'If rtxt_texto.Text <> "" Then
        ' lbl_nPalabras.Text = ""
        'Else
        Dim cuenta_palabras = Split(rtxt_texto.Text, " ")
        Dim npalabras As Integer = UBound(cuenta_palabras) + 1
        lbl_nPalabras.Text = "Conteo: " & npalabras & " palabras y " & Len(rtxt_texto.Text) & " caracteres"
        ' End If
    End Sub
    Public Sub pruebaBucles()  'Aun no funciona 
        'Dim arIndex As ArrayList
        'Dim indexFile
        'Dim arProyect As ArrayList
        'For Each namechapter As String In fileSystem.GetFiles(proyectPath, FileIO.SearchOption.SearchAllSubDirectories, ".wpok")
        '       MsgBox(namechapter)
        '      arIndex.Add(Path.GetFileNameWithoutExtension(namechapter))
        'Next namechapter
        '
        'For Each indexFile In fileSystem.GetFiles(proyectPath, FileIO.SearchOption.SearchAllSubDirectories, proyectFolder("index"))
        '       indexFile = fileSystem.ReadAllText(indexFile)
        'Next
        'If indexFile <> "" Then indexFile = indexFile.TrimEnd("|")
        ''Dim fileNames() As String = indexFile.Split("|")
        ''fileNames.ToList
        'For Each chapters In indexFile.Split("|")
        '       MsgBox(chapters)
        '      arProyect.Add("Ideas")
        '     MsgBox("Prueba")
        '    Next

        '    Dim DirectorioProyecto As String
        '    Dim Linea3 As New ArrayList()
        '    Dim i As Integer
        '    Dim j As Integer
        '    Dim esta As Boolean

        '    Linea1(1) = "ABC"
        '    Linea1(2) = "CDE"
        '    Linea1(3) = "EFG"
        '    Linea2(1) = "123"
        '    Linea2(2) = "ABC"
        '    Linea2(3) = "CDE"
        '    Linea2(4) = "CDE"
        '    Linea3.Add(Linea1(1))
        '    i = 0
        '    ' insertamos en Linea3 los elementos no repetidos de Linea1
        '    While (i < Linea1.Length)
        '        esta = False
        '        j = 0
        '        While (j < Linea3.Count And Not esta)
        '            ' vamos comparando cada uno de los elementos del vector Linea1
        '            ' con todos los elementos del vector Linea3.
        '            ' Si son iguales pasamos al siguiente elemento del vector Linea3
        '            If (Linea1(i) = Linea3.Item(j)) Then
        '                esta = True
        '            End If
        '            j = j + 1
        '        End While
        '        ' Si el elemento de Linea1 que hemos comparado con todos los elementos
        '        ' de Linea3 no ha sido igual a ninguno, tenemos que insertarlo en Linea3
        '        If Not (esta) Then
        '            Linea3.Add(Linea1(i))
        '        End If
        '        i = i + 1
        '    End While
        '    ' insertamos en Linea3 los elementos no repetidos de Linea2 haciendo
        '    ' exactamente lo mismo que antes para Linea1
        '    ' inicializamos de nuevo la variable i
        '    i = 1
        '    While (i < Linea2.Length)
        '        esta = False
        '        j = 0
        '        While (j < Linea3.Count And Not esta)
        '            If (Linea2(i) = Linea3.Item(j)) Then
        '                esta = True
        '            End If
        '            j = j + 1
        '        End While
        '        If Not (esta) Then
        '            Linea3.Add(Linea2(i))
        '        End If
        '        i = i + 1
        '    End While
        '    'Sacamos por pantalla el vector Linea3
        '    Dim h As Integer
        '    For h = 0 To Linea3.Count - 1
        '        MsgBox(Linea3.Item(h))
        '    Next
        '    ' Este mensaje lo ponemos para que nos de tiempo a visualizar en la
        '    ' consola el resultado del vector Linea3.
        '    MsgBox("")
    End Sub

End Class