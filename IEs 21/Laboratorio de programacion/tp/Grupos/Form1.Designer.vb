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
        Me.LB = New System.Windows.Forms.ListBox()
        Me.LV = New System.Windows.Forms.ListView()
        Me.bActualizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LB
        '
        Me.LB.FormattingEnabled = True
        Me.LB.Location = New System.Drawing.Point(34, 32)
        Me.LB.Name = "LB"
        Me.LB.Size = New System.Drawing.Size(331, 459)
        Me.LB.TabIndex = 0
        '
        'LV
        '
        Me.LV.CheckBoxes = True
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(396, 31)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(562, 459)
        Me.LV.TabIndex = 1
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.SmallIcon
        '
        'bActualizar
        '
        Me.bActualizar.Location = New System.Drawing.Point(777, 515)
        Me.bActualizar.Name = "bActualizar"
        Me.bActualizar.Size = New System.Drawing.Size(181, 40)
        Me.bActualizar.TabIndex = 2
        Me.bActualizar.Text = "ACTUALIZAR"
        Me.bActualizar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 583)
        Me.Controls.Add(Me.bActualizar)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.LB)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRUPOS IES 21"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LB As ListBox
    Friend WithEvents LV As ListView
    Friend WithEvents bActualizar As Button
End Class
