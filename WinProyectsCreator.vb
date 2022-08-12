﻿Public Class WinProyectsCreator
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        ControlBox = False
    End Sub
    Private Sub btn_examinar_Click(sender As Object, e As EventArgs) Handles btn_examine.Click
        If FolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_path.Text = FolderBrowser.SelectedPath
            btn_create.Select()
        End If
    End Sub
    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Dim nameProyect As String = Trim(txt_nameProyect.Text)
        With Form1
            If txt_nameProyect.Text <> "" AndAlso System.IO.Directory.Exists(txt_path.Text) Then
                Form1.proyectPath = Trim(txt_Path.Text & "\" & nameProyect)
                If Not (System.IO.Directory.Exists(Form1.proyectPath)) Then
                    My.Computer.FileSystem.CreateDirectory(Form1.proyectPath)
                    ' Una vez creada la carpeta sustiuimos espacios por barra_bajas para dejar el archivo index sin espacios
                    nameProyect = nameProyect.Replace(" ", "_")
                    My.Computer.FileSystem.WriteAllText(Form1.proyectPath & "\" & nameProyect & ".index", "", False)

                    .Text = IO.Path.GetFileName(Form1.proyectPath) & " - WPook"
                    .Enabled = True
                    .rtxt_texto.Enabled = True
                    .tscb_chapters.Enabled = True
                    .reloadChapters()
                    .tscb_chapters.SelectedIndex = 0
                    .tsb_reloadChapters.Enabled = True
                    .tsb_rechapter.Enabled = True
                    Me.Close()
                Else
                    MsgBox("Ya existe este Proyecto")
                End If
            Else
                MsgBox("No existe esta ruta")
            End If
        End With
    End Sub
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Form1.Enabled = True
        Me.Close()
    End Sub
End Class