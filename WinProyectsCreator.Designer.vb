<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinProyectsCreator
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
        Me.lbl_nameProyect = New System.Windows.Forms.Label()
        Me.txt_nameProyect = New System.Windows.Forms.TextBox()
        Me.lbl_Path = New System.Windows.Forms.Label()
        Me.txt_Path = New System.Windows.Forms.TextBox()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_examine = New System.Windows.Forms.Button()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'lbl_nameProyect
        '
        Me.lbl_nameProyect.AutoSize = True
        Me.lbl_nameProyect.Location = New System.Drawing.Point(26, 26)
        Me.lbl_nameProyect.Name = "lbl_nameProyect"
        Me.lbl_nameProyect.Size = New System.Drawing.Size(109, 13)
        Me.lbl_nameProyect.TabIndex = 0
        Me.lbl_nameProyect.Text = "Nombre del Proyecto:"
        '
        'txt_nameProyect
        '
        Me.txt_nameProyect.Location = New System.Drawing.Point(29, 42)
        Me.txt_nameProyect.Name = "txt_nameProyect"
        Me.txt_nameProyect.Size = New System.Drawing.Size(253, 20)
        Me.txt_nameProyect.TabIndex = 1
        '
        'lbl_Path
        '
        Me.lbl_Path.AutoSize = True
        Me.lbl_Path.Location = New System.Drawing.Point(26, 70)
        Me.lbl_Path.Name = "lbl_Path"
        Me.lbl_Path.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Path.TabIndex = 2
        Me.lbl_Path.Text = "Ubicación"
        '
        'txt_Path
        '
        Me.txt_Path.Location = New System.Drawing.Point(29, 87)
        Me.txt_Path.Name = "txt_Path"
        Me.txt_Path.ReadOnly = True
        Me.txt_Path.Size = New System.Drawing.Size(229, 20)
        Me.txt_Path.TabIndex = 3
        '
        'btn_create
        '
        Me.btn_create.Location = New System.Drawing.Point(29, 123)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(75, 23)
        Me.btn_create.TabIndex = 4
        Me.btn_create.Text = "Crear"
        Me.btn_create.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(207, 123)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancelar"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_examine
        '
        Me.btn_examine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_examine.Location = New System.Drawing.Point(256, 87)
        Me.btn_examine.Name = "btn_examine"
        Me.btn_examine.Size = New System.Drawing.Size(26, 20)
        Me.btn_examine.TabIndex = 6
        Me.btn_examine.Text = "..."
        Me.btn_examine.UseVisualStyleBackColor = True
        '
        'FolderBrowser
        '
        Me.FolderBrowser.SelectedPath = "C:\Users\PabloAja1000\Documents\Libros\ProyectoWPook"
        '
        'WinProyectsCreator
        '
        Me.AcceptButton = Me.btn_create
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.btn_cancel
        Me.ClientSize = New System.Drawing.Size(309, 171)
        Me.Controls.Add(Me.btn_examine)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.txt_Path)
        Me.Controls.Add(Me.lbl_Path)
        Me.Controls.Add(Me.txt_nameProyect)
        Me.Controls.Add(Me.lbl_nameProyect)
        Me.MaximizeBox = False
        Me.Name = "WinProyectsCreator"
        Me.Text = "Nuevo Proyecto - WPook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_nameProyect As Label				 
    Friend WithEvents lbl_Path As Label
    Friend WithEvents txt_nameProyect As TextBox
    Friend WithEvents txt_Path As TextBox
    Friend WithEvents btn_examine As Button
    Friend WithEvents btn_create As Button
    Friend WithEvents btn_cancel As Button
	Friend WithEvents FolderBrowser As FolderBrowserDialog
End Class
