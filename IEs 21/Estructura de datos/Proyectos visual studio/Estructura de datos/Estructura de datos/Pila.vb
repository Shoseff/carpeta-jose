Public Class Pila

    Private cpPrimero As Nodo

    Public Property Primero As Nodo
        Get
            Return cpPrimero
        End Get
        Set(value As Nodo)
            cpPrimero = value
        End Set
    End Property

    Public Sub Agregar(Nvo As Nodo)
        If Primero Is Nothing Then
            Primero = Nvo
        Else
            Nvo.Siguiente = Primero
            Primero = Nvo
        End If
    End Sub

    Public Sub Eliminar()
        Primero = Primero.Siguiente
    End Sub

    Public Sub Listar(lista As ListBox)
        Dim x As Nodo = Primero
        lista.Items.Clear()
        While x IsNot Nothing
            lista.Items.Add(x.Nombre)
            x = x.Siguiente
        End While
    End Sub

    Public Sub Listar(grilla As DataGridView)
        Dim x As Nodo = Primero
        grilla.Rows.Clear()
        While x IsNot Nothing
            grilla.Rows.Add(x.Codigo, x.Nombre, x.Tramite)
            x = x.Siguiente
        End While
    End Sub
End Class
