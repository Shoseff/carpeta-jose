<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMM = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbLocalidad = New System.Windows.Forms.ComboBox()
        Me.cbCultivo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bBuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtToneladas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AÑO"
        '
        'txtAA
        '
        Me.txtAA.Location = New System.Drawing.Point(146, 68)
        Me.txtAA.Name = "txtAA"
        Me.txtAA.Size = New System.Drawing.Size(100, 20)
        Me.txtAA.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MES"
        '
        'txtMM
        '
        Me.txtMM.Location = New System.Drawing.Point(146, 109)
        Me.txtMM.Name = "txtMM"
        Me.txtMM.Size = New System.Drawing.Size(63, 20)
        Me.txtMM.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LOCALIDAD"
        '
        'cbLocalidad
        '
        Me.cbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(146, 154)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(282, 21)
        Me.cbLocalidad.TabIndex = 5
        '
        'cbCultivo
        '
        Me.cbCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCultivo.FormattingEnabled = True
        Me.cbCultivo.Location = New System.Drawing.Point(146, 201)
        Me.cbCultivo.Name = "cbCultivo"
        Me.cbCultivo.Size = New System.Drawing.Size(282, 21)
        Me.cbCultivo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "CULTIVO"
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(146, 253)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(282, 23)
        Me.bBuscar.TabIndex = 8
        Me.bBuscar.Text = "BUSCAR"
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "TONELADAS"
        '
        'txtToneladas
        '
        Me.txtToneladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToneladas.Location = New System.Drawing.Point(146, 309)
        Me.txtToneladas.Name = "txtToneladas"
        Me.txtToneladas.ReadOnly = True
        Me.txtToneladas.Size = New System.Drawing.Size(100, 20)
        Me.txtToneladas.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 413)
        Me.Controls.Add(Me.txtToneladas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.cbCultivo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbLocalidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "AVERIGUAR TONELADAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbLocalidad As ComboBox
    Friend WithEvents cbCultivo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bBuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtToneladas As TextBox
End Class
