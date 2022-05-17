Public Class ListaSimple

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
            If Nvo.Codigo < Primero.Codigo Then
                Nvo.Siguiente = Primero
                Primero = Nvo
            Else
                Dim aux = Primero
                If (aux.Siguiente IsNot Nothing) Then
                    While (aux.Siguiente.Codigo < Nvo.Codigo)
                        aux = aux.Siguiente
                        If (aux.Siguiente Is Nothing) Then
                            Exit While
                        End If
                    End While
                End If
                Nvo.Siguiente = aux.Siguiente
                aux.Siguiente = Nvo
            End If
        End If
    End Sub

    Public Sub Eliminar(Codigo As Integer)
        If Primero.Codigo = Codigo Then
            Primero = Primero.Siguiente
        Else
            Dim aux = Primero
            If (aux.Siguiente IsNot Nothing) Then
                While (aux.Siguiente.Codigo < Codigo)
                    aux = aux.Siguiente
                    If (aux.Siguiente Is Nothing) Then
                        Exit While
                    End If
                End While
            End If
            aux.Siguiente = aux.Siguiente.Siguiente
        End If
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

    Public Sub Listar(combo As ComboBox)
        Dim aux As Nodo = Primero
        combo.Items.Clear()
        While Not (aux Is Nothing)
            combo.Items.Add(aux.Codigo)
            aux = aux.Siguiente
        End While
    End Sub
End Class
