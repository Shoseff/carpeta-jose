<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReservas
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
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBFecha = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBHorario = New System.Windows.Forms.ListBox()
        Me.BConsultar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB
        '
        Me.PB.BackColor = System.Drawing.Color.White
        Me.PB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PB.Location = New System.Drawing.Point(44, 35)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(400, 400)
        Me.PB.TabIndex = 0
        Me.PB.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(468, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FECHAS"
        '
        'CBFecha
        '
        Me.CBFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBFecha.FormattingEnabled = True
        Me.CBFecha.Location = New System.Drawing.Point(471, 51)
        Me.CBFecha.Name = "CBFecha"
        Me.CBFecha.Size = New System.Drawing.Size(97, 21)
        Me.CBFecha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "HORARIOS"
        '
        'LBHorario
        '
        Me.LBHorario.FormattingEnabled = True
        Me.LBHorario.Location = New System.Drawing.Point(471, 123)
        Me.LBHorario.Name = "LBHorario"
        Me.LBHorario.Size = New System.Drawing.Size(97, 95)
        Me.LBHorario.TabIndex = 4
        '
        'BConsultar
        '
        Me.BConsultar.Location = New System.Drawing.Point(471, 295)
        Me.BConsultar.Name = "BConsultar"
        Me.BConsultar.Size = New System.Drawing.Size(97, 23)
        Me.BConsultar.TabIndex = 5
        Me.BConsultar.Text = "Consultar"
        Me.BConsultar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.Location = New System.Drawing.Point(471, 353)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(97, 23)
        Me.BCancelar.TabIndex = 6
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(471, 406)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(97, 23)
        Me.BSalir.TabIndex = 7
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'FrmReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 482)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BConsultar)
        Me.Controls.Add(Me.LBHorario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PB)
        Me.Name = "FrmReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASIENTOS RESERVADOS"
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PB As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBFecha As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBHorario As System.Windows.Forms.ListBox
    Friend WithEvents BConsultar As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents BSalir As System.Windows.Forms.Button

End Class
