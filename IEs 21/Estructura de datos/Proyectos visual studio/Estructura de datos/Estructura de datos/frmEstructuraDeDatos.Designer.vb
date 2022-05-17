<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstructuraDeDatos
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosDelDesarrolladorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstructurasLinealesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListaEnlazadaSimpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDoblementeEnlazadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstructurasRamificadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArbolBinarioDeBusquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GrafoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.EstructurasLinealesToolStripMenuItem, Me.EstructurasRamificadasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosDelDesarrolladorToolStripMenuItem, Me.ToolStripMenuItem2, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'DatosDelDesarrolladorToolStripMenuItem
        '
        Me.DatosDelDesarrolladorToolStripMenuItem.Name = "DatosDelDesarrolladorToolStripMenuItem"
        Me.DatosDelDesarrolladorToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DatosDelDesarrolladorToolStripMenuItem.Text = "Datos del desarrollador"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(192, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EstructurasLinealesToolStripMenuItem
        '
        Me.EstructurasLinealesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColaToolStripMenuItem, Me.PilaToolStripMenuItem, Me.ToolStripMenuItem1, Me.ListaEnlazadaSimpleToolStripMenuItem, Me.ListaDoblementeEnlazadaToolStripMenuItem})
        Me.EstructurasLinealesToolStripMenuItem.Name = "EstructurasLinealesToolStripMenuItem"
        Me.EstructurasLinealesToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.EstructurasLinealesToolStripMenuItem.Text = "Estructuras lineales"
        '
        'ColaToolStripMenuItem
        '
        Me.ColaToolStripMenuItem.Name = "ColaToolStripMenuItem"
        Me.ColaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ColaToolStripMenuItem.Text = "Cola..."
        '
        'PilaToolStripMenuItem
        '
        Me.PilaToolStripMenuItem.Name = "PilaToolStripMenuItem"
        Me.PilaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.PilaToolStripMenuItem.Text = "Pila..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(220, 6)
        '
        'ListaEnlazadaSimpleToolStripMenuItem
        '
        Me.ListaEnlazadaSimpleToolStripMenuItem.Name = "ListaEnlazadaSimpleToolStripMenuItem"
        Me.ListaEnlazadaSimpleToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ListaEnlazadaSimpleToolStripMenuItem.Text = "Lista enlazada simple..."
        '
        'ListaDoblementeEnlazadaToolStripMenuItem
        '
        Me.ListaDoblementeEnlazadaToolStripMenuItem.Name = "ListaDoblementeEnlazadaToolStripMenuItem"
        Me.ListaDoblementeEnlazadaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ListaDoblementeEnlazadaToolStripMenuItem.Text = "Lista doblemente enlazada..."
        '
        'EstructurasRamificadasToolStripMenuItem
        '
        Me.EstructurasRamificadasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArbolBinarioDeBusquedaToolStripMenuItem, Me.ToolStripMenuItem3, Me.GrafoToolStripMenuItem})
        Me.EstructurasRamificadasToolStripMenuItem.Name = "EstructurasRamificadasToolStripMenuItem"
        Me.EstructurasRamificadasToolStripMenuItem.Size = New System.Drawing.Size(141, 20)
        Me.EstructurasRamificadasToolStripMenuItem.Text = "Estructuras ramificadas"
        '
        'ArbolBinarioDeBusquedaToolStripMenuItem
        '
        Me.ArbolBinarioDeBusquedaToolStripMenuItem.Name = "ArbolBinarioDeBusquedaToolStripMenuItem"
        Me.ArbolBinarioDeBusquedaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ArbolBinarioDeBusquedaToolStripMenuItem.Text = "Arbol binario de busqueda..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(220, 6)
        '
        'GrafoToolStripMenuItem
        '
        Me.GrafoToolStripMenuItem.Name = "GrafoToolStripMenuItem"
        Me.GrafoToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.GrafoToolStripMenuItem.Text = "Grafo..."
        '
        'frmEstructuraDeDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Estructura_de_datos.My.Resources.Resources._1_Ut55XNszCQPxCG9qaEQfAw
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEstructuraDeDatos"
        Me.Text = "Estructura de datos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstructurasLinealesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstructurasRamificadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosDelDesarrolladorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PilaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ListaEnlazadaSimpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDoblementeEnlazadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArbolBinarioDeBusquedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents GrafoToolStripMenuItem As ToolStripMenuItem
End Class
