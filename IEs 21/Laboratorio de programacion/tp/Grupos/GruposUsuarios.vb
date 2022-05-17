Imports System.Data.OleDb

Public Class GruposUsuarios
    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable


    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "GruposUsuarios"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(1) As DataColumn
        VECTOR(0) = TABLA.Columns("grupo")
        VECTOR(1) = TABLA.Columns("usuario")
        TABLA.PrimaryKey = VECTOR


    End Sub

    Public Sub Grabar(Gru As Integer, Usu As Integer)

        Dim Fila As DataRow = TABLA.NewRow
        Fila("grupo") = Gru
        Fila("usuario") = Usu
        TABLA.Rows.Add(Fila)

        Actualizar()

    End Sub

    Public Sub Actualizar()

        Dim M As New OleDbCommandBuilder(ADAPTADOR)
        ADAPTADOR.Update(TABLA)

    End Sub

    Public Sub Eliminar(Gru As Integer, Usu As Integer)

        Dim V(1) As Object

        V(0) = Gru
        V(1) = Usu

        Dim FILA As DataRow = TABLA.Rows.Find(V)

        If Not FILA Is Nothing Then
            FILA.Delete()
        End If

        Actualizar()

    End Sub

    Public Sub Ver(IdGrup As Integer, LV As ListView)

        Dim Nom As String = ""
        Dim ObjUsu As New Usuarios

        For Each FILA As DataRow In TABLA.Rows

            If FILA("grupo") = IdGrup Then

                For Each A As ListViewItem In LV.Items

                    If A.Text = ObjUsu.Buscar(FILA("usuario")) Then

                        A.Checked = True

                    End If

                Next

            End If

        Next

    End Sub

    Public Function Buscar(Gru As Long, Usu As Long)

        Dim Esta As Boolean = False

        For Each FILA As DataRow In TABLA.Rows

            If FILA("grupo") = Gru And FILA("usuario") = Usu Then

                Esta = True
                Exit For

            End If
        Next
        Return Esta

    End Function


End Class
