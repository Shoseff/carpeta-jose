
Imports System.Data.OleDb

Public Class Datos

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)

    Dim COMACT As New OleDbCommand
    Dim ADAACT As New OleDbDataAdapter(COMACT)
    Dim TACT As New DataTable

    Dim COMPAI As New OleDbCommand
    Dim ADAPAI As New OleDbDataAdapter(COMPAI)
    Dim TPAI As New DataTable

    Dim COMPEL As New OleDbCommand
    Dim ADAPEL As New OleDbDataAdapter(COMPEL)
    Dim TPEL As New DataTable


    Dim COMAPE As New OleDbCommand
    Dim ADAAPE As New OleDbDataAdapter(COMAPE)
    Dim TAPE As New DataTable

    Public Sub New()

        ' ACTORES

        COMACT.Connection = CONECTOR
        COMACT.CommandType = CommandType.TableDirect
        COMACT.CommandText = "Actores"
        ADAACT.Fill(TACT)
        Dim VACT(1) As DataColumn
        VACT(0) = TACT.Columns("actor")
        TACT.PrimaryKey = VACT

        ' PAISES

        COMPAI.Connection = CONECTOR
        COMPAI.CommandType = CommandType.TableDirect
        COMPAI.CommandText = "Paises"
        ADAPAI.Fill(TPAI)
        Dim VPAI(1) As DataColumn
        VPAI(0) = TPAI.Columns("pais")
        TPAI.PrimaryKey = VPAI

        ' PELICULAS

        COMPEL.Connection = CONECTOR
        COMPEL.CommandType = CommandType.TableDirect
        COMPEL.CommandText = "Peliculas"
        ADAPEL.Fill(TPEL)
        Dim VPEL(1) As DataColumn
        VPEL(0) = TPEL.Columns("pelicula")
        TPEL.PrimaryKey = VPEL

        ' ACTORES_PELICULAS

        COMAPE.Connection = CONECTOR
        COMAPE.CommandType = CommandType.TableDirect
        COMAPE.CommandText = "ActoresPeliculas"
        ADAAPE.Fill(TAPE)
        Dim VAPE(2) As DataColumn
        VAPE(0) = TAPE.Columns("actor")
        VAPE(1) = TAPE.Columns("pelicula")
        TAPE.PrimaryKey = VAPE

    End Sub

    Public Function ObtenerActores() As DataTable
        Return TACT
    End Function

    Public Function ObtenerPaises() As DataTable
        Return TPAI
    End Function

    Public Function ObtenerPeliculas() As DataTable
        Return TPEL
    End Function

    Public Function ObtenerActoresPeliculas() As DataTable
        Return TAPE
    End Function

    Public Sub Construir(ByRef TV As TreeView)

        Dim Nodo0 As TreeNode = TV.Nodes.Add("PAISES", "PAISES")

        For Each Registro As DataRow In TPAI.Rows

            Dim Nodo1 As TreeNode = Nodo0.Nodes.Add(Registro("nombre"), Registro("nombre"))
            Nodo1.Tag = Registro("pais")
            Ver(Nodo1)

        Next

    End Sub

    Public Sub Ver(Nodo1 As TreeNode)

        For Each Registro As DataRow In TACT.Rows

            If Registro("pais") = Val(Nodo1.Tag) Then
                Dim Nodo2 As TreeNode = Nodo1.Nodes.Add(Registro("nombre"), Registro("nombre"))
                Nodo2.Tag = Registro("actor")
            End If

        Next
    End Sub



    Public Function TraerPeliculas(CodAut As Integer, Lv As ListView) As Integer

        Dim Contador As Integer = 0

        Lv.Items.Clear()

        For Each Registro As DataRow In TAPE.Rows

            If Registro("actor") = CodAut Then

                NombrePelicula(Registro("pelicula"), Lv)
                Contador = Contador + 1

            End If

        Next


        Return Contador
    End Function



    Public Sub NombrePelicula(IdentificacionPeli As Integer, LV As ListView)

        Dim Registro As DataRow = TPEL.Rows.Find(IdentificacionPeli)

        Dim LVI As ListViewItem = LV.Items.Add(Registro("nombre"))

        LVI.SubItems.Add(Registro("estreno"))
        LVI.SubItems.Add(Registro("duracion"))


    End Sub


    Public Function ObtenerDatosActores(Cod As Integer) As DataRow


        Dim Registro As DataRow = TACT.Rows.Find(Cod)


        Return Registro
    End Function

End Class
