Imports System.IO
Public Class WinProyectsCreator
    Dim pathProyect As String = ""
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        ControlBox = False
    End Sub
    Private Sub txt_nameProyect_TextChanged(sender As Object, e As EventArgs) Handles txt_nameProyect.TextChanged
        If txt_Path.Text <> "" Then txt_Path.Text = Trim(pathProyect & "\" & txt_nameProyect.Text)
        txt_Path.Select(txt_Path.Text.Length, 0)
    End Sub
    Private Sub btn_examinar_Click(sender As Object, e As EventArgs) Handles btn_examine.Click
        If FolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_Path.Text = FolderBrowser.SelectedPath.TrimEnd("\")
            pathProyect = Trim(txt_Path.Text)
            If txt_nameProyect.Text <> "" Then txt_Path.Text = Trim(FolderBrowser.SelectedPath & "\" & txt_nameProyect.Text)
            txt_Path.Select(txt_Path.Text.Length, 0)
            btn_create.Focus()
        End If
    End Sub
    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Dim nameProyect As String = Trim(txt_nameProyect.Text)
        With Form1
            If nameProyect <> "" AndAlso Directory.Exists(pathProyect) Then
                .proyectPath = Trim(txt_Path.Text & "\" & nameProyect)
                If Not (Directory.Exists(.proyectPath)) Then
                    .fileSystem.CreateDirectory(.proyectPath)
                    ' Una vez creada la carpeta sustiuimos espacios por barra_bajas para dejar el archivo index sin espacios
                    nameProyect += nameProyect.Replace(" ", "_")
                    Form1.fileSystem.WriteAllText(.proyectPath & "\" & nameProyect & ".index", "", False)
                    .Text = Path.GetFileName(.proyectPath) & " - WPook"
                    .Enabled = True
                    .rtxt_texto.Enabled = True
                    .tscb_chapters.Enabled = True
                    .reloadChapters()
                    .tscb_chapters.SelectedIndex = 0
                    .tsb_reloadChapters.Enabled = True
                    .tsb_rechapter.Enabled = True
                    Me.Close()
                Else
                    MsgBox("Ya existe este proyecto con este nombre")
                End If
            Else
                If nameProyect = "" Then
                    MsgBox("Este proyecto necesita un nombre")
                Else
                    MsgBox("No existe esta ruta")
                End If
            End If
        End With
    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Form1.Enabled = True
        Me.Close()
    End Sub
End Class