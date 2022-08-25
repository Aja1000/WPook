<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinRechapter
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
        Me.lstBox_chapters = New System.Windows.Forms.ListBox()
        Me.lbl_listadoCapitulos = New System.Windows.Forms.Label()
        Me.btn_upChapter = New System.Windows.Forms.Button()
        Me.btn_downChapter = New System.Windows.Forms.Button()
        Me.nud_rechapters = New System.Windows.Forms.NumericUpDown()
        Me.btn_rechapter = New System.Windows.Forms.Button()
        Me.btn_renameChapter = New System.Windows.Forms.Button()
        Me.btn_duplicate = New System.Windows.Forms.Button()
        Me.txt_rename = New System.Windows.Forms.TextBox()
        Me.btn_deleteChapter = New System.Windows.Forms.Button()
        Me.btn_import = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.nud_rechapters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstBox_chapters
        '
        Me.lstBox_chapters.FormattingEnabled = True
        Me.lstBox_chapters.Location = New System.Drawing.Point(12, 29)
        Me.lstBox_chapters.Name = "lstBox_chapters"
        Me.lstBox_chapters.Size = New System.Drawing.Size(184, 277)
        Me.lstBox_chapters.TabIndex = 0
        '
        'lbl_listadoCapitulos
        '
        Me.lbl_listadoCapitulos.AutoSize = True
        Me.lbl_listadoCapitulos.Font = New System.Drawing.Font("Book Antiqua", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_listadoCapitulos.Location = New System.Drawing.Point(12, 9)
        Me.lbl_listadoCapitulos.Name = "lbl_listadoCapitulos"
        Me.lbl_listadoCapitulos.Size = New System.Drawing.Size(130, 17)
        Me.lbl_listadoCapitulos.TabIndex = 1
        Me.lbl_listadoCapitulos.Text = "Listado de Capitulos:"
        '
        'btn_upChapter
        '
        Me.btn_upChapter.Location = New System.Drawing.Point(202, 29)
        Me.btn_upChapter.Name = "btn_upChapter"
        Me.btn_upChapter.Size = New System.Drawing.Size(80, 80)
        Me.btn_upChapter.TabIndex = 3
        Me.btn_upChapter.Text = "UP"
        Me.btn_upChapter.UseVisualStyleBackColor = True
        '
        'btn_downChapter
        '
        Me.btn_downChapter.Location = New System.Drawing.Point(306, 29)
        Me.btn_downChapter.Name = "btn_downChapter"
        Me.btn_downChapter.Size = New System.Drawing.Size(80, 80)
        Me.btn_downChapter.TabIndex = 2
        Me.btn_downChapter.Text = "DOWN"
        Me.btn_downChapter.UseVisualStyleBackColor = True
        '
        'nud_rechapters
        '
        Me.nud_rechapters.Location = New System.Drawing.Point(392, 209)
        Me.nud_rechapters.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nud_rechapters.Name = "nud_rechapters"
        Me.nud_rechapters.Size = New System.Drawing.Size(41, 20)
        Me.nud_rechapters.TabIndex = 5
        '
        'btn_rechapter
        '
        Me.btn_rechapter.Location = New System.Drawing.Point(306, 123)
        Me.btn_rechapter.Name = "btn_rechapter"
        Me.btn_rechapter.Size = New System.Drawing.Size(80, 80)
        Me.btn_rechapter.TabIndex = 6
        Me.btn_rechapter.Text = "Recapitular"
        Me.btn_rechapter.UseVisualStyleBackColor = True
        '
        'btn_renameChapter
        '
        Me.btn_renameChapter.Location = New System.Drawing.Point(202, 123)
        Me.btn_renameChapter.Name = "btn_renameChapter"
        Me.btn_renameChapter.Size = New System.Drawing.Size(80, 80)
        Me.btn_renameChapter.TabIndex = 7
        Me.btn_renameChapter.Text = "Renombrar Capitulo"
        Me.btn_renameChapter.UseVisualStyleBackColor = True
        '
        'btn_duplicate
        '
        Me.btn_duplicate.Location = New System.Drawing.Point(202, 235)
        Me.btn_duplicate.Name = "btn_duplicate"
        Me.btn_duplicate.Size = New System.Drawing.Size(80, 71)
        Me.btn_duplicate.TabIndex = 8
        Me.btn_duplicate.Text = "Duplicar"
        Me.btn_duplicate.UseVisualStyleBackColor = True
        '
        'txt_rename
        '
        Me.txt_rename.Location = New System.Drawing.Point(202, 209)
        Me.txt_rename.Name = "txt_rename"
        Me.txt_rename.Size = New System.Drawing.Size(184, 20)
        Me.txt_rename.TabIndex = 9
        '
        'btn_deleteChapter
        '
        Me.btn_deleteChapter.Location = New System.Drawing.Point(392, 29)
        Me.btn_deleteChapter.Name = "btn_deleteChapter"
        Me.btn_deleteChapter.Size = New System.Drawing.Size(45, 174)
        Me.btn_deleteChapter.TabIndex = 10
        Me.btn_deleteChapter.Text = "Eliminar Capitulo"
        Me.btn_deleteChapter.UseVisualStyleBackColor = True
        '
        'btn_import
        '
        Me.btn_import.Location = New System.Drawing.Point(306, 235)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(80, 71)
        Me.btn_import.TabIndex = 11
        Me.btn_import.Text = "Importar"
        Me.btn_import.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        Me.OpenFileDialog.InitialDirectory = "Documentos"
        Me.OpenFileDialog.RestoreDirectory = True
        Me.OpenFileDialog.Title = "Importar Capitulos"
        '
        'WinRechapter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(448, 318)
        Me.Controls.Add(Me.btn_import)
        Me.Controls.Add(Me.btn_deleteChapter)
        Me.Controls.Add(Me.txt_rename)
        Me.Controls.Add(Me.btn_duplicate)
        Me.Controls.Add(Me.btn_renameChapter)
        Me.Controls.Add(Me.btn_rechapter)
        Me.Controls.Add(Me.nud_rechapters)
        Me.Controls.Add(Me.btn_upChapter)
        Me.Controls.Add(Me.btn_downChapter)
        Me.Controls.Add(Me.lbl_listadoCapitulos)
        Me.Controls.Add(Me.lstBox_chapters)
        Me.MaximizeBox = False
        Me.Name = "WinRechapter"
        Me.Text = "Recapitulador - WPook"
        CType(Me.nud_rechapters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub WinRechapter_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
    End Sub

    Friend WithEvents lstBox_chapters As ListBox
    Friend WithEvents lbl_listadoCapitulos As Label
    Friend WithEvents btn_downChapter As Button
    Friend WithEvents btn_upChapter As Button
    Friend WithEvents nud_rechapters As NumericUpDown
    Friend WithEvents btn_rechapter As Button
    Friend WithEvents btn_renameChapter As Button
    Friend WithEvents btn_duplicate As Button
    Friend WithEvents txt_rename As TextBox
    Friend WithEvents btn_deleteChapter As Button
    Friend WithEvents btn_import As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
