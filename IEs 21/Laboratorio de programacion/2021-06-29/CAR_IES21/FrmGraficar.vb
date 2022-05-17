Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmGraficar
    Dim TVEN As DataTable
    Dim TVTA As DataTable
    Dim objVEN As New Vendedores
    Dim objVTA As New Ventas

    Private Sub bGraficar_Click(sender As Object, e As EventArgs) Handles bGraficar.Click
        Dim DESDE As Integer = Val(txtDesde.Text)
        Dim HASTA As Integer = Val(txtHasta.Text)
        Dim AA As Integer = 0
        Dim TOT As Integer = 0

        CC.Series.Clear()
        SS.Items.Clear()

        For AA = DESDE To HASTA
            Dim SERIE As Series = CC.Series.Add(AA)
            For Each LVI As ListViewItem In LV.CheckedItems
                Dim CAN As Integer = Sumar(AA, Val(LVI.Tag))
                SERIE.Points.AddXY(LVI.Text, CAN)
                TOT = TOT + CAN
            Next
        Next

        SS.Items.Add("CANTIDAD TOTAL")
        SS.Items.Add(TOT)

    End Sub

    Private Sub FrmGraficar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CC.Series.Clear()
        TVEN = objVEN.getVendedores()
        TVTA = objVTA.getVentas()

        For Each FILA As DataRow In TVEN.Rows
            Dim LVI As ListViewItem = LV.Items.Add(FILA("nombre"))
            LVI.Tag = FILA("vendedor")
        Next
    End Sub

    Public Function Sumar(AA As Integer, VENDEDOR As Integer) As Integer
        Dim CAN As Integer = 0
        For Each FILA As DataRow In TVTA.Rows
            If FILA("aa") = AA And FILA("vendedor") = VENDEDOR Then
                CAN = CAN + FILA("cantidad")
            End If
        Next
        Return CAN
    End Function
End Class
