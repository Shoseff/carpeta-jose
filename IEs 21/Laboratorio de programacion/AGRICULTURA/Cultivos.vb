Imports System.Data.OleDb

Public Class Cultivos

    Dim CADENA As String = "provider=microsoft.jet.oledb.4.0;data source=AGRICULTURA.mdb"

    Dim CONECTOR As New OleDbConnection(CADENA)
    Dim COMANDO As New OleDbCommand()
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Cultivos"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(0) As DataColumn
        VECTOR(0) = TABLA.Columns("cultivo")
        TABLA.PrimaryKey = VECTOR

    End Sub
    Public Sub Ver(COMBO As ComboBox)
        COMBO.DisplayMember = "nombre"
        COMBO.ValueMember = "cultivo"
        COMBO.DataSource = TABLA
    End Sub

End Class
