<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGraficar
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LV = New System.Windows.Forms.ListView()
        Me.CC = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.bGraficar = New System.Windows.Forms.Button()
        Me.SS = New System.Windows.Forms.StatusStrip()
        CType(Me.CC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DESDE"
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(101, 27)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(64, 20)
        Me.txtDesde.TabIndex = 1
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(258, 27)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(64, 20)
        Me.txtHasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HASTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "VENDEDORES"
        '
        'LV
        '
        Me.LV.CheckBoxes = True
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(41, 95)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(281, 420)
        Me.LV.TabIndex = 5
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.List
        '
        'CC
        '
        Me.CC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CC.BorderlineColor = System.Drawing.Color.Black
        Me.CC.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Name = "ChartArea1"
        Me.CC.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.CC.Legends.Add(Legend2)
        Me.CC.Location = New System.Drawing.Point(352, 24)
        Me.CC.Name = "CC"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.CC.Series.Add(Series2)
        Me.CC.Size = New System.Drawing.Size(905, 583)
        Me.CC.TabIndex = 6
        Me.CC.Text = "Chart1"
        '
        'bGraficar
        '
        Me.bGraficar.Location = New System.Drawing.Point(41, 554)
        Me.bGraficar.Name = "bGraficar"
        Me.bGraficar.Size = New System.Drawing.Size(281, 53)
        Me.bGraficar.TabIndex = 7
        Me.bGraficar.Text = "GRAFICAR"
        Me.bGraficar.UseVisualStyleBackColor = True
        '
        'SS
        '
        Me.SS.Location = New System.Drawing.Point(0, 634)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(1293, 22)
        Me.SS.TabIndex = 8
        Me.SS.Text = "StatusStrip1"
        '
        'FrmGraficar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 656)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.bGraficar)
        Me.Controls.Add(Me.CC)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmGraficar"
        Me.Text = "CAR IES 21"
        CType(Me.CC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LV As ListView
    Friend WithEvents CC As DataVisualization.Charting.Chart
    Friend WithEvents bGraficar As Button
    Friend WithEvents SS As StatusStrip
End Class
