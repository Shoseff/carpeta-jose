Imports System.Data.OleDb

Public Class Puntajes
    Dim CADENA As String = "provider=microsoft.jet.oledb.4.0;data source=CONCURSO.mdb"

    Dim CONECTOR As New OleDbConnection(CADENA)
    Dim COMANDO As New OleDbCommand()
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Puntajes"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(0) As DataColumn
        VECTOR(0) = TABLA.Columns("dni")
        TABLA.PrimaryKey = VECTOR

    End Sub

    Public Function getPuntajes() As DataTable
        Return TABLA
    End Function

End Class
