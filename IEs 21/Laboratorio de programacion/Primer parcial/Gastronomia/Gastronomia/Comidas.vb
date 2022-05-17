Imports System.Data.OleDb
Public Class Comidas
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

    Public Sub ver(combo As ComboBox)
        combo.DisplayMember = "nombre"
        combo.ValueMember = "comida"
        combo.DataSource = TABLA
    End Sub
End Class
