
Imports System.Data.OleDb

Public Class Reservas

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()

        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Reservas"
        ADAPTADOR.Fill(TABLA)

        Dim VECTOR(2) As DataColumn
        VECTOR(0) = TABLA.Columns("funcion")
        VECTOR(1) = TABLA.Columns("asiento")
        TABLA.PrimaryKey = VECTOR

    End Sub

    Public Sub Dibujar(Funcion As Integer, Gra As Graphics)

        Dim Func As Integer = Funcion

        Dim FUENTE As New Font("Verdana", 8)
        Dim X As Integer = 0
        Dim Y As Integer = 0

        Dim Alto As Integer = 26
        Dim Ancho As Integer = 40

        Dim Butaca As Integer = 0


        For Y = 0 To 400 - Alto Step Alto

            For X = 0 To 400 - Ancho Step Ancho

                Butaca = Butaca + 1

                Dim Ocupado As Boolean = EstaOcupado(Func, Butaca)

                If Ocupado = True Then
                    GRA.FillRectangle(Brushes.Red, X, Y, Ancho - 10, Alto - 2)
                Else

                    Gra.DrawRectangle(Pens.Black, X, Y, Ancho - 10, Alto - 2)
                End If

                Gra.DrawString(Butaca, FUENTE, Brushes.Black, X, Y)

            Next
        Next

    End Sub

    Public Function EstaOcupado(Funcion As Long, Butaca As Long) As Boolean

        Dim OK As Boolean = False
        For Each FILA As DataRow In TABLA.Rows

            If FILA("funcion") = Funcion And FILA("asiento") = Butaca Then
                OK = True
                Exit For
            End If
        Next

        Return OK

    End Function


End Class
