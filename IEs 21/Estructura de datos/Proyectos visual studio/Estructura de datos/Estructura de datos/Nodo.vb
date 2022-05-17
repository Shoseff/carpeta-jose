Public Class Nodo

    Private cpCodigo As Integer
    Private cpNombre As String
    Private cpTramite As String
    Private cpSiguiente As Nodo
    Private cpAnterior As Nodo
    Private cpIzquierda As Nodo
    Private cpDerecha As Nodo

    Public Property Codigo As Integer
        Get
            Return cpCodigo
        End Get
        Set(value As Integer)
            cpCodigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return cpNombre
        End Get
        Set(value As String)
            cpNombre = value
        End Set
    End Property

    Public Property Tramite As String
        Get
            Return cpTramite
        End Get
        Set(value As String)
            cpTramite = value
        End Set
    End Property

    Public Property Siguiente As Nodo
        Get
            Return cpSiguiente
        End Get
        Set(value As Nodo)
            cpSiguiente = value
        End Set
    End Property

    Public Property Anterior As Nodo
        Get
            Return cpAnterior
        End Get
        Set(value As Nodo)
            cpAnterior = value
        End Set
    End Property

    Public Property Izquierda As Nodo
        Get
            Return cpIzquierda
        End Get
        Set(value As Nodo)
            cpIzquierda = value
        End Set
    End Property

    Public Property Derecha As Nodo
        Get
            Return cpDerecha
        End Get
        Set(value As Nodo)
            cpDerecha = value
        End Set
    End Property

End Class
