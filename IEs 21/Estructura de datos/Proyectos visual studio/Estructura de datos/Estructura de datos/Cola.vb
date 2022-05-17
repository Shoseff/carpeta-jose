Public Class Cola

    Private cpPrimero As Nodo
    Private cpUltimo As Nodo

    Public Property Primero As Nodo
        Get
            Return cpPrimero
        End Get
        Set(value As Nodo)
            cpPrimero = value
        End Set
    End Property

    Public Property Ultimo As Nodo
        Get
            Return cpUltimo
        End Get
        Set(value As Nodo)
            cpUltimo = value
        End Set
    End Property

    Public Sub Agregar(Nvo As Nodo)
        If Primero Is Nothing Then
            Primero = Nvo
            Ultimo = Nvo
        Else
            Ultimo.Siguiente = Nvo
            Ultimo = Nvo
        End If
    End Sub

    Public Sub Eliminar()
        If Primero IsNot Nothing Then
            If Primero Is Ultimo Then
                Primero = Nothing
                Ultimo = Nothing
            Else
                Primero = Primero.Siguiente
            End If
        End If
    End Sub

    Public Sub Listar(Lista As ListBox)
        Dim x As Nodo = Primero
        Lista.Items.Clear()
        While x IsNot Nothing
            Lista.Items.Add(x.Nombre)
            x = x.Siguiente
        End While
    End Sub

    Public Sub Listar(Dgv As DataGridView)
        Dim x As Nodo = Primero
        Dgv.Rows.Clear()
        While x IsNot Nothing
            Dgv.Rows.Add(x.Codigo, x.Nombre, x.Tramite)
            x = x.Siguiente
        End While
    End Sub
End Class
