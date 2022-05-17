Imports System.Data.OleDb
Public Class LeGustan
    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Personas"
        ADAPTADOR.Fill(TABLA)
    End Sub
    Public Sub grabar(dni As Long, comida As String)
        Dim FILA As DataRow = TABLA.NewRow
        FILA("dni") = dni
        FILA("comida") = comida
        TABLA.Rows.Add(FILA)
        Dim MAGICO As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)
    End Sub
End Class
