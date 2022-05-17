Imports System.Data.OleDb
Public Class Grupos


    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Grupos"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(0) As DataColumn
        VECTOR(0) = TABLA.Columns("grupo")
        TABLA.PrimaryKey = VECTOR

    End Sub

    Public Sub Cargar(LB As ListBox)

        LB.DisplayMember = ("nombre")
        LB.ValueMember = ("grupo")
        LB.DataSource = TABLA

    End Sub

End Class
