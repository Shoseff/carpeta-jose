Public Class Arbol
    Private campoRaiz As Nodo
    Dim i As Integer
    Dim Vector(100) As Nodo

    Public Property Raiz As Nodo
        Get
            Return campoRaiz
        End Get
        Set(ByVal value As Nodo)
            campoRaiz = value
        End Set
    End Property

    Public Sub Agregar(Nvo As Nodo)
        Nvo.Izquierda = Nothing
        Nvo.Derecha = Nothing
        If Raiz Is Nothing Then
            Raiz = Nvo
        Else
            Dim NodoPadre As Nodo = Raiz
            Dim Aux As Nodo = Raiz
            While Aux IsNot Nothing
                NodoPadre = Aux
                If Nvo.Codigo < Aux.Codigo Then
                    Aux = Aux.Izquierda
                Else
                    Aux = Aux.Derecha
                End If
            End While
            If Nvo.Codigo < NodoPadre.Codigo Then
                NodoPadre.Izquierda = Nvo
            Else
                NodoPadre.Derecha = Nvo
            End If
        End If
    End Sub

    Public Sub Listar(combo As ComboBox)
        combo.Items.Clear()
        InOrden(combo, Raiz)
    End Sub

    Public Sub InOrden(combo As ComboBox, NodoPadre As Nodo)
        If NodoPadre.Izquierda IsNot Nothing Then
            InOrden(combo, NodoPadre.Izquierda)
        End If
        combo.Items.Add(NodoPadre.Codigo)
        If NodoPadre.Derecha IsNot Nothing Then
            InOrden(combo, NodoPadre.Derecha)
        End If
    End Sub

    Public Sub Listar(Lista As ListBox, orden As Integer)
        Lista.Items.Clear()
        Select Case orden
            Case 1
                InOrden(Lista, Raiz)
            Case 2
                PreOrden(Lista, Raiz)
            Case 3
                PostOrden(Lista, Raiz)
            Case Else
                InOrden(Lista, Raiz)
        End Select
    End Sub

    Public Sub InOrden(Lista As ListBox, NodoPadre As Nodo)
        If NodoPadre.Izquierda IsNot Nothing Then
            InOrden(Lista, NodoPadre.Izquierda)
        End If
        Lista.Items.Add(NodoPadre.Codigo)
        If NodoPadre.Derecha IsNot Nothing Then
            InOrden(Lista, NodoPadre.Derecha)
        End If
    End Sub

    Public Sub PreOrden(Lista As ListBox, NodoPadre As Nodo)
        Lista.Items.Add(NodoPadre.Codigo)
        If NodoPadre.Izquierda IsNot Nothing Then
            PreOrden(Lista, NodoPadre.Izquierda)
        End If
        If NodoPadre.Derecha IsNot Nothing Then
            PreOrden(Lista, NodoPadre.Derecha)
        End If
    End Sub

    Public Sub PostOrden(Lista As ListBox, NodoPadre As Nodo)
        If NodoPadre.Izquierda IsNot Nothing Then
            PostOrden(Lista, NodoPadre.Izquierda)
        End If
        If NodoPadre.Derecha IsNot Nothing Then
            PostOrden(Lista, NodoPadre.Derecha)
        End If
        Lista.Items.Add(NodoPadre.Codigo)
    End Sub

    Public Function Buscar(codigo As Integer) As Nodo
        Dim aux As Nodo = Raiz
        While aux IsNot Nothing
            If codigo = aux.Codigo Then
                Exit While
            Else
                If codigo < aux.Codigo Then
                    aux = aux.Izquierda
                Else
                    aux = aux.Derecha
                End If
            End If
        End While
        Return aux
    End Function

    Public Sub Eliminar(codigo As Integer)
        i = 0
        GrabarVector(Raiz, codigo)
        Raiz = Nothing
        EquilibrarArbol(0, i - 1)
    End Sub

    Private Sub GrabarVector(NodoPadre As Nodo, codigo As Integer)
        If NodoPadre.Izquierda IsNot Nothing Then
            GrabarVector(NodoPadre.Izquierda, codigo)
        End If
        If NodoPadre.Codigo <> codigo Then
            Vector(i) = NodoPadre
            i = i + 1
        End If
        If NodoPadre.Derecha IsNot Nothing Then
            GrabarVector(NodoPadre.Derecha, codigo)
        End If
    End Sub

    Public Sub Equlibrar()
        i = 0
        GrabarVectorInOrden(Raiz)
        Raiz = Nothing
        EquilibrarArbol(0, i - 1)
    End Sub

    Private Sub GrabarVectorInOrden(NodoPadre As Nodo)
        If NodoPadre.Izquierda IsNot Nothing Then
            GrabarVectorInOrden(NodoPadre.Izquierda)
        End If
        Vector(i) = NodoPadre
        i = i + 1
        If NodoPadre.Derecha IsNot Nothing Then
            GrabarVectorInOrden(NodoPadre.Derecha)
        End If
    End Sub

    Private Sub EquilibrarArbol(ini As Integer, fin As Integer)
        Dim m As Integer = (ini + fin) / 2

        If ini <= fin Then
            Agregar(Vector(m))
            EquilibrarArbol(ini, m - 1)
            EquilibrarArbol(m + 1, fin)
        End If
    End Sub
End Class
