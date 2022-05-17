Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form2

    Dim TPER As DataTable
    Dim TPUN As DataTable
    Dim objPER As New Personas
    Dim objPUN As New Puntajes

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TPER = objPER.getPersonas()
        TPUN = objPUN.getPuntajes()
        CHA.Series.Clear()

        Dim SERIE As SERIES = CHA.Series.Add("PUNTAJES")

        For Each RPER As DataRow In TPER.Rows
            Dim RPUN As DataRow = TPUN.Rows.Find(RPER("dni"))
            SERIE.Points.AddXY(RPER("nombre"), RPUN("puntaje"))
        Next

    End Sub
End Class