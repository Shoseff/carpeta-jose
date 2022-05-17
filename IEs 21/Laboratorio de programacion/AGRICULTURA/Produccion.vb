Imports System.Data.OleDb

Public Class Produccion
    Dim CADENA As String = "provider=microsoft.jet.oledb.4.0;data source=AGRICULTURA.mdb"

    Dim CONECTOR As New OleDbConnection(CADENA)
    Dim COMANDO As New OleDbCommand()
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Produccion"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(3) As DataColumn
        VECTOR(0) = TABLA.Columns("aa")
        VECTOR(1) = TABLA.Columns("mm")
        VECTOR(2) = TABLA.Columns("localidad")
        VECTOR(3) = TABLA.Columns("cultivo")
        TABLA.PrimaryKey = VECTOR

    End Sub

    Public Function Buscar(AA As Integer, MM As Integer, LOCALIDAD As Integer, CULTIVO As Integer) As Integer
        Dim TONELADAS As Integer = 0

        Dim CLAVE(3) As String
        CLAVE(0) = AA
        CLAVE(1) = MM
        CLAVE(2) = LOCALIDAD
        CLAVE(3) = CULTIVO
        Dim RPRO As DataRow = TABLA.Rows.Find(CLAVE)
        If Not RPRO Is Nothing Then
            TONELADAS = RPRO("toneladas")
        End If
        Return TONELADAS

    End Function
End Class
