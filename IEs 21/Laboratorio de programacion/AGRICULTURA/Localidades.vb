Imports System.Data.OleDb

Public Class Localidades
    Dim CADENA As String = "provider=microsoft.jet.oledb.4.0;data source=AGRICULTURA.mdb"

    Dim CONECTOR As New OleDbConnection(CADENA)
    Dim COMANDO As New OleDbCommand()
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Localidades"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(0) As DataColumn
        VECTOR(0) = TABLA.Columns("localidad")
        TABLA.PrimaryKey = VECTOR

    End Sub
    Public Sub Ver(COMBO As ComboBox)
        COMBO.DisplayMember = "nombre"
        COMBO.ValueMember = "localidad"
        COMBO.DataSource = TABLA
    End Sub
End Class
