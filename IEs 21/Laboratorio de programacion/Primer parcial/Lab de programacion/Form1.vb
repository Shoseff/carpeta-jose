Public Class Form1

    Dim objDAT As New Datos
    Dim t1 As DataTable
    Dim pos As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objDAT As New Datos
        Dim T1 As DataTable = objDAT.DameLaTabla()

        For Each FILA As DataRow In T1.Rows
            MessageBox.Show(FILA("nombre"))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PPD.ShowDialog()
    End Sub

    Private Sub PDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PDoc.PrintPage
        Dim f1 As New Font("courier new", 14)
        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top
        'pos = 0
        Do While pos < t1.Rows.Count
            Dim fila As DataRow = t1.Rows(pos)
            e.Graphics.DrawString(fila("nombre"), f1, Brushes.Black, x, y)
            pos = pos + 1
            y = y + f1.Height
        Loop
        'e.HasMorePages = True
    End Sub



End Class
