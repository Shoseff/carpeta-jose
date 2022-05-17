Public Class ListaDoblementeEnlazada
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

    Public Sub agregar(Nvo As Nodo)
        If Primero Is Nothing And Ultimo Is Nothing Then
            Primero = Nvo
            Ultimo = Nvo
        Else
            If Nvo.Codigo < Primero.Codigo Then
                Nvo.Siguiente = Primero
                Primero.Anterior = Nvo
                Primero = Nvo
            Else
                If Nvo.Codigo > Ultimo.Codigo Then
                    Ultimo.Siguiente = Nvo
                    Nvo.Anterior = Ultimo
                    Ultimo = Nvo
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
                    Nvo.Anterior = aux
                    Nvo.Siguiente = aux.Siguiente
                    aux.Siguiente = Nvo
                    Nvo.Siguiente.Anterior = Nvo
                End If
            End If
        End If
    End Sub

    Public Sub eliminar(codigo As Integer)
        If Primero.Codigo = codigo And Ultimo Is Primero Then
            Primero = Nothing
            Ultimo = Nothing
        Else
            If Primero.Codigo = codigo Then
                Primero = Primero.Siguiente
                Primero.Anterior = Nothing
            Else
                If Ultimo.Codigo = codigo Then
                    Ultimo = Ultimo.Anterior
                    Ultimo.Siguiente = Nothing
                Else
                    Dim aux = Primero
                    While (aux.Siguiente.Codigo < codigo)
                        aux = aux.Siguiente

                    End While
                    aux.Siguiente = aux.Siguiente.Siguiente
                    aux.Siguiente.Anterior = aux
                End If
            End If
        End If
    End Sub

    Public Sub listar_descendiente(Grilla As DataGridView)
        Dim aux As Nodo = Ultimo
        Grilla.Rows.Clear()
        While Not (aux Is Nothing)
            Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite)
            aux = aux.Anterior
        End While
    End Sub

    Public Sub listar(lista As ListBox)
        Dim aux As Nodo = Primero
        lista.Items.Clear()
        While Not (aux Is Nothing)
            lista.Items.Add(aux.Nombre + " " + aux.Tramite)
            aux = aux.Siguiente
        End While
    End Sub

    Public Sub listar(combo As ComboBox)
        Dim aux As Nodo = Primero
        combo.Items.Clear()
        While Not (aux Is Nothing)
            combo.Items.Add(aux.Codigo)
            aux = aux.Siguiente
        End While
    End Sub
End Class
