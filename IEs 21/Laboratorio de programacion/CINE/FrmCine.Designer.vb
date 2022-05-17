<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCine
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
        Me.TV = New System.Windows.Forms.TreeView()
        Me.LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SS = New System.Windows.Forms.StatusStrip()
        Me.LabelNombre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelFechaNac = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CantidadPeliculas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SS.SuspendLayout()
        Me.SuspendLayout()
        '
        'TV
        '
        Me.TV.Location = New System.Drawing.Point(25, 28)
        Me.TV.Name = "TV"
        Me.TV.Size = New System.Drawing.Size(230, 299)
        Me.TV.TabIndex = 0
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(280, 28)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(378, 299)
        Me.LV.TabIndex = 1
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre de la película"
        Me.ColumnHeader1.Width = 253
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Estrenó"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Duración"
        '
        'SS
        '
        Me.SS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.LabelNombre, Me.ToolStripStatusLabel2, Me.LabelFechaNac, Me.ToolStripStatusLabel3, Me.CantidadPeliculas})
        Me.SS.Location = New System.Drawing.Point(0, 344)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(689, 22)
        Me.SS.TabIndex = 2
        Me.SS.Text = "StatusStrip1"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = False
        Me.LabelNombre.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(150, 17)
        '
        'LabelFechaNac
        '
        Me.LabelFechaNac.AutoSize = False
        Me.LabelFechaNac.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.LabelFechaNac.Name = "LabelFechaNac"
        Me.LabelFechaNac.Size = New System.Drawing.Size(90, 17)
        Me.LabelFechaNac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CantidadPeliculas
        '
        Me.CantidadPeliculas.AutoSize = False
        Me.CantidadPeliculas.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.CantidadPeliculas.Name = "CantidadPeliculas"
        Me.CantidadPeliculas.Size = New System.Drawing.Size(30, 17)
        Me.CantidadPeliculas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 17)
        Me.ToolStripStatusLabel1.Text = "Nombre:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(59, 17)
        Me.ToolStripStatusLabel2.Text = "Nacida el:"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(123, 17)
        Me.ToolStripStatusLabel3.Text = "Cantidad de películas:"
        '
        'FrmCine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 366)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.TV)
        Me.Name = "FrmCine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CINE"
        Me.SS.ResumeLayout(False)
        Me.SS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TV As System.Windows.Forms.TreeView
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SS As System.Windows.Forms.StatusStrip
    Friend WithEvents LabelNombre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LabelFechaNac As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CantidadPeliculas As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel

End Class
