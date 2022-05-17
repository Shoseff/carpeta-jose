Imports System.Data.OleDb
Public Class Usuarios

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Usuarios"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(0) As DataColumn
        VECTOR(0) = TABLA.Columns("usuario")
        TABLA.PrimaryKey = VECTOR

    End Sub

    Public Sub Cargar(LB As ListView)

        For Each Reg As DataRow In TABLA.Rows

            LB.Items.Add(Reg("nombre"), Reg("usuario"))

        Next

    End Sub

    Public Function Buscar(ID As Integer) As String

        Dim Fila As DataRow = TABLA.Rows.Find(ID)
        Return Fila("nombre")

    End Function

    Public Sub Limpiar(LV As ListView)

        For Each A As ListViewItem In LV.Items

            A.Checked = False

        Next

    End Sub


End Class
