Imports System.Data.OleDb
Public Class Datos
    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Comidas"
        ADAPTADOR.Fill(TABLA)
    End Sub

    Public Function DameLaTabla() As DataTable
        Return TABLA
    End Function

End Class
