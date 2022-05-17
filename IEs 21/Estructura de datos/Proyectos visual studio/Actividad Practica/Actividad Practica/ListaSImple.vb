Public Class ListaSImple
    Private pri As Nodo

    Public Property Primero() As Nodo
        Get
            Return pri
        End Get
        Set(ByVal value As Nodo)
            pri = value
        End Set
    End Property

    Public Sub Agregar(Nuevo As Nodo)
        If Primero Is Nothing Then
            Primero = Nuevo
        Else
            If Nuevo.NumeroDeCuenta < Primero.NumeroDeCuenta Then
                Nuevo.Siguiente = Primero
                Primero = Nuevo
            Else
                Dim aux = Primero
                If (aux.Siguiente IsNot Nothing) Then
                    While (aux.Siguiente.NumeroDeCuenta < Nuevo.NumeroDeCuenta)
                        aux = aux.Siguiente
                        If (aux.Siguiente Is Nothing) Then
                            Exit While
                        End If
                    End While
                End If
                Nuevo.Siguiente = aux.Siguiente
                aux.Siguiente = Nuevo
            End If
        End If
    End Sub

    Public Sub Eliminar(numCuenta As Integer)
        If Primero.NumeroDeCuenta = numCuenta Then
            Primero = Primero.Siguiente
        Else
            Dim aux = Primero
            If (aux.Siguiente IsNot Nothing) Then
                While (aux.Siguiente.NumeroDeCuenta < numCuenta)
                    aux = aux.Siguiente
                    If (aux.Siguiente Is Nothing) Then
                        Exit While
                    End If
                End While
            End If
            aux.Siguiente = aux.Siguiente.Siguiente
        End If
    End Sub

    Public Sub Recorrer(combo As ComboBox)
        Dim aux As Nodo = Primero
        combo.Items.Clear()
        While Not (aux Is Nothing)
            combo.Items.Add(aux.NumeroDeCuenta)
            aux = aux.Siguiente
        End While
    End Sub

    Public Sub Recorrer(lista As DataGridView, listadoCompleto As Boolean)
        Dim aux As Nodo = Primero
        lista.Rows.Clear()
        While Not (aux Is Nothing)
            If listadoCompleto = True Then
                lista.Rows.Add(aux.NumeroDeCuenta, aux.Nombre, aux.LimiteDeCredito, aux.Deuda)
                aux = aux.Siguiente
            Else
                If aux.Deuda > 0 Then
                    lista.Rows.Add(aux.NumeroDeCuenta, aux.Nombre, aux.LimiteDeCredito, aux.Deuda)
                End If
                aux = aux.Siguiente
            End If
        End While
    End Sub
End Class
