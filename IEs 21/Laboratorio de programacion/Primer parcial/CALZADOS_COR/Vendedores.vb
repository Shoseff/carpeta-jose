﻿
Imports System.Data.OleDb
Public Class Vendedores
    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable
    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Vendedores"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(0) As DataColumn
        VECTOR(0) = TABLA.Columns("dni")
        TABLA.PrimaryKey = VECTOR

    End Sub

    Public Function Buscar(Dni As Integer) As DataRow
        Dim FILA As DataRow = TABLA.Rows.Find(Dni)
        Return FILA
    End Function

    Public Sub Ver(GRILLA As DataGridView)
        GRILLA.DataSource = TABLA
    End Sub
End Class
