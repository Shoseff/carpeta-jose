
Imports System.Data.OleDb

Public Class Funciones

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Funciones"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(1) As DataColumn
        VECTOR(0) = TABLA.Columns("funcion")
        TABLA.PrimaryKey = VECTOR

    End Sub

    Public Sub AgregarFechas(CB As ComboBox)

        CB.DisplayMember = "fecha"
        CB.ValueMember = "fecha"
        CB.DataSource = TABLA

    End Sub

    Public Sub AgregarHoras(LB As ListBox, Fecha As String)

        For Each FILA As DataRow In TABLA.Rows
            If FILA("fecha") = Fecha Then
                LB.Items.Add(FILA("hora"))
            End If
        Next

    End Sub

    Public Function Buscar(Fecha As String, Hora As String) As Integer

        Dim Funcion As Integer

        For Each FILA As DataRow In TABLA.Rows
            If FILA("fecha") = Fecha And FILA("hora") = Hora Then
                Funcion = FILA("funcion")
                Exit For
            End If
        Next

        Return Funcion
    End Function

End Class
