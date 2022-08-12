Public Class WinRechapter

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadListChapters()

        Dim numChapter = My.Computer.FileSystem.GetFiles(Form1.proyectPath, FileIO.SearchOption.SearchAllSubDirectories, "*.wpok").Count
        nud_rechapters.Maximum = numChapter
        nud_rechapters.Minimum = 1
        nud_rechapters.Enabled = False

        Form1.Enabled = False

    End Sub
    Private Sub btn_upChapter_Click(sender As Object, e As EventArgs) Handles btn_upChapter.Click
        Dim indexChapter As Integer = lstBox_chapters.SelectedIndex
        Dim index As String = lstBox_chapters.SelectedItem.ToString()
        If indexChapter > 0 Then
            lstBox_chapters.Items.RemoveAt(indexChapter)
            lstBox_chapters.Items.Insert(indexChapter - 1, index)
            lstBox_chapters.SetSelected(indexChapter - 1, True)
        End If
        reindexing()
    End Sub
    Private Sub btn_downChapter_Click(sender As Object, e As EventArgs) Handles btn_downChapter.Click
        Dim indexChapter As Integer = lstBox_chapters.SelectedIndex
        Dim index As String = lstBox_chapters.SelectedItem.ToString()
        If indexChapter < lstBox_chapters.Items.Count - 1 Then
            lstBox_chapters.Items.RemoveAt(indexChapter)
            lstBox_chapters.Items.Insert(indexChapter + 1, index)
            lstBox_chapters.SetSelected(indexChapter + 1, True)
        End If
        reindexing()
    End Sub
    Private Sub btn_renameChapter_Click(sender As Object, e As EventArgs) Handles btn_renameChapter.Click
        Try
            Dim indexChapter As Integer = lstBox_chapters.SelectedIndex
            Dim newName = Trim(txt_rename.Text)
            My.Computer.FileSystem.RenameFile(Form1.proyectPath & "\" & lstBox_chapters.SelectedItem & ".wpok", newName)
            lstBox_chapters.Items.RemoveAt(indexChapter)
            lstBox_chapters.Items.Insert(indexChapter, txt_rename.Text)
            reindexing()
            lstBox_chapters.ClearSelected()
            txt_rename.Text = ""
            nud_rechapters.Enabled = False
        Catch ex As Exception
            MsgBox("Deebes seleccionar el capitulo que quieres renombrar y no dejar el campo vacio")
        End Try

    End Sub
    Private Sub btn_Rechapter_Click(sender As Object, e As EventArgs) Handles btn_rechapter.Click
        Try
            Dim indexChapter As Integer = lstBox_chapters.SelectedIndex
            Dim index As String = lstBox_chapters.SelectedItem.ToString()
            Dim newIndex As Integer = nud_rechapters.Value - 1
            lstBox_chapters.Items.RemoveAt(indexChapter)
            lstBox_chapters.Items.Insert(newIndex, index)
            reindexing()
            lstBox_chapters.ClearSelected()
            txt_rename.Text = ""
            nud_rechapters.Enabled = False
        Catch ex As Exception
            MsgBox("Deebes seleccionar el capitulo que quieres recapitular")
        End Try

    End Sub
    Private Sub btn_deleteChapter_Click(sender As Object, e As EventArgs) Handles btn_deleteChapter.Click
        Try
            Dim chapter = Form1.proyectPath & "\" & lstBox_chapters.SelectedItem & ".wpok"
            My.Computer.FileSystem.DeleteFile(chapter)
            lstBox_chapters.Items.RemoveAt(lstBox_chapters.SelectedIndex)
            reindexing()
            lstBox_chapters.ClearSelected()
            txt_rename.Text = ""
            nud_rechapters.Enabled = False
        Catch ex As Exception
            MsgBox("Deebes seleccionar el capitulo que quieres borrar")
        End Try

    End Sub
    Private Sub lstBox_chapters_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstBox_chapters.SelectedValueChanged
        Try
            Dim chapter As String = lstBox_chapters.SelectedItem.ToString
            txt_rename.Text = chapter
            nud_rechapters.Value = lstBox_chapters.SelectedIndex + 1
            nud_rechapters.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub reloadListChapters()
        lstBox_chapters.Items.Clear()
        Dim fileIndex = My.Computer.FileSystem.GetFiles(Form1.proyectPath, FileIO.SearchOption.SearchAllSubDirectories, "*.index")
        Dim fileReader As String = My.Computer.FileSystem.ReadAllText(fileIndex.First)
        If fileReader <> "" Then fileReader = fileReader.TrimEnd("|")
        Dim fileNames() As String = fileReader.Split("|")
        For chapters As Integer = 0 To fileNames.GetUpperBound(0)
            lstBox_chapters.Items.Add(fileNames(chapters))
        Next
        lstBox_chapters.ClearSelected()
    End Sub

    Private Sub reindexing()
        Dim index
        For Each chapter In lstBox_chapters.Items
            index = index & chapter & "|"
        Next
        My.Computer.FileSystem.WriteAllText(Form1.proyectPath & "\" & Form1.proyectFolder("index"), index, False)
        Form1.reloadChapters()
    End Sub

End Class