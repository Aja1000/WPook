Imports System.IO

Public Class WinRechapter
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadListChapters()

        Dim numChapter = Form1.fileSystem.GetFiles(Form1.proyectPath, FileIO.SearchOption.SearchAllSubDirectories, "*.wpok").Count
        nud_rechapters.Maximum = numChapter
        nud_rechapters.Minimum = 1
        nud_rechapters.Enabled = False

        Form1.Enabled = False

    End Sub
    Private Sub lstBox_chapters_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstBox_chapters.SelectedValueChanged
        If lstBox_chapters.SelectedItems.Count() > 0 Then
            txt_rename.Text = lstBox_chapters.SelectedItem.ToString
            nud_rechapters.Value = lstBox_chapters.SelectedIndex + 1
            nud_rechapters.Enabled = True
        End If

    End Sub
    Private Sub btn_upChapter_Click(sender As Object, e As EventArgs) Handles btn_upChapter.Click
        Dim indexChapter As Integer = lstBox_chapters.SelectedIndex
        Dim namechapter As String = lstBox_chapters.SelectedItem.ToString()
        If indexChapter > 0 Then
            lstBox_chapters.Items.RemoveAt(indexChapter)
            lstBox_chapters.Items.Insert(indexChapter - 1, namechapter)
            lstBox_chapters.SetSelected(indexChapter - 1, True)
        End If
        reindexing()
    End Sub
    Private Sub btn_downChapter_Click(sender As Object, e As EventArgs) Handles btn_downChapter.Click
        Dim indexChapter As Integer = lstBox_chapters.SelectedIndex
        Dim namechapter As String = lstBox_chapters.SelectedItem.ToString()
        If indexChapter < lstBox_chapters.Items.Count - 1 Then
            lstBox_chapters.Items.RemoveAt(indexChapter)
            lstBox_chapters.Items.Insert(indexChapter + 1, namechapter)
            lstBox_chapters.SetSelected(indexChapter + 1, True)
        End If
        reindexing()
    End Sub
    Private Sub btn_renameChapter_Click(sender As Object, e As EventArgs) Handles btn_renameChapter.Click
        Try
            Dim indexChapter As Integer = lstBox_chapters.SelectedIndex
            Dim newName = Trim(txt_rename.Text)
            Form1.fileSystem.RenameFile(Form1.proyectPath & "\" & lstBox_chapters.SelectedItem & ".wpok", newName & ".wpok")
            lstBox_chapters.Items.RemoveAt(indexChapter)
            lstBox_chapters.Items.Insert(indexChapter, txt_rename.Text)
            reindexingPRO()
        Catch ex As Exception
            MsgBox("Deebes seleccionar el capitulo que quieres renombrar y no dejar el campo vacio")
        End Try

    End Sub
    Private Sub btn_Rechapter_Click(sender As Object, e As EventArgs) Handles btn_rechapter.Click
        Try
            Dim indexChapter As Integer = lstBox_chapters.SelectedIndex
            Dim namechapter As String = lstBox_chapters.SelectedItem.ToString()
            Dim newIndex As Integer = nud_rechapters.Value - 1
            lstBox_chapters.Items.RemoveAt(indexChapter)
            lstBox_chapters.Items.Insert(newIndex, namechapter)
            reindexingPRO()
        Catch ex As Exception
            MsgBox("Deebes seleccionar el capitulo que quieres recapitular")
        End Try

    End Sub
    Private Sub btn_deleteChapter_Click(sender As Object, e As EventArgs) Handles btn_deleteChapter.Click
        Try
            Dim chapter = Form1.proyectPath & "\" & lstBox_chapters.SelectedItem & ".wpok"
            Form1.fileSystem.DeleteFile(chapter)
            lstBox_chapters.Items.RemoveAt(lstBox_chapters.SelectedIndex)
            nud_rechapters.Maximum -= 1
            reindexingPRO()
        Catch ex As Exception
            MsgBox("Deebes seleccionar el capitulo que quieres borrar")
        End Try

    End Sub
    Private Sub btn_duplicate_Click(sender As Object, e As EventArgs) Handles btn_duplicate.Click
        Dim namechapter As String
        Dim indexChapter As Integer
        Dim ficheroDuplicado
        Dim contador As Integer = 2
        If lstBox_chapters.SelectedItems.Count > 0 Then
            namechapter = lstBox_chapters.SelectedItem.ToString()
            indexChapter = lstBox_chapters.SelectedIndex
            ficheroDuplicado = Form1.proyectPath & "\" & namechapter & "(" & contador & ").wpok"
        Else
            MsgBox("Para duplicar un archivo primero debes seleccionarlo")
            Exit Sub
        End If
        Try
            Form1.fileSystem.CopyFile(Form1.proyectPath & "\" & namechapter & ".wpok", ficheroDuplicado)
            lstBox_chapters.Items.Insert(indexChapter + 1, namechapter & "(" & contador & ")")
            reindexing()
            nud_rechapters.Maximum += 1
            Exit Sub
        Catch ex As Exception
        End Try

        Do While Form1.fileSystem.FileExists(ficheroDuplicado)
            contador += 1
            ficheroDuplicado = Form1.proyectPath & "\" & namechapter & "(" & contador & ").wpok"
            Try
                Form1.fileSystem.CopyFile(Form1.proyectPath & "\" & namechapter & ".wpok", ficheroDuplicado)
                lstBox_chapters.Items.Insert(indexChapter + contador - 1, namechapter & "(" & contador & ")")

                nud_rechapters.Maximum += 1
                reindexing()
                Exit Do
            Catch ex As Exception
            End Try
        Loop

    End Sub

    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click
        OpenFileDialog.Filter = "Archivos de Texto (*.wpok*)|*.wpok| Archivos de Texto (*.txt)|(*.txt)"
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileName = OpenFileDialog.FileName
            Try
                Form1.fileSystem.CopyFile(fileName, Form1.proyectPath & "\" & Path.GetFileNameWithoutExtension(fileName) & ".wpok")
                lstBox_chapters.Items.Insert(lstBox_chapters.Items.Count, Path.GetFileNameWithoutExtension(fileName))
                nud_rechapters.Maximum += 1
            Catch ex As Exception
                MsgBox("Ya extiste un fichero con este nombre")
            End Try
            reindexingPRO()
        End If
    End Sub
    'Cogemos el archivo *.index y llenamos la listBox
    Private Sub reloadListChapters()
        lstBox_chapters.Items.Clear()
        Dim indexFile
        'Dim indexFile = Form1.fileSystem.GetFiles(Form1.proyectPath, FileIO.SearchOption.SearchAllSubDirectories, "*.index").First
        For Each indexFile In Form1.fileSystem.GetFiles(Form1.proyectPath, FileIO.SearchOption.SearchAllSubDirectories, "*.index")
            indexFile = indexFile
        Next
        Dim fileReader As String = Form1.fileSystem.ReadAllText(indexFile)
        If fileReader <> "" Then fileReader = fileReader.TrimEnd("|")
        Dim fileNames() As String = fileReader.Split("|")
        For chapters As Integer = 0 To fileNames.GetUpperBound(0)
            lstBox_chapters.Items.Add(fileNames(chapters))
        Next
        lstBox_chapters.ClearSelected()
    End Sub

    'Tomamos lo elementos del lstBox_chapters y los añadimos en el archivo*.index en el mismo orden
    Private Sub reindexing()
        Dim index
        For Each chapter In lstBox_chapters.Items
            index = index & chapter & "|"
        Next
        Form1.fileSystem.WriteAllText(Form1.proyectPath & "\" & Form1.proyectFolder("index"), index, False) 'AAAAAAAAAAAAACreacion Index
        Form1.reloadChapters()
    End Sub
    Private Sub reindexingPRO()
        reindexing()
        lstBox_chapters.ClearSelected()
        txt_rename.Text = ""
        nud_rechapters.Enabled = False
    End Sub

End Class