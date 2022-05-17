Public Class Nodo
    Private cpCuenta As Integer
    Private cpNombre As String
    Private cpLimite As Decimal
    Private cpDeuda As Decimal
    Private sig As Nodo

    Public Property NumeroDeCuenta() As Integer
        Get
            Return cpCuenta
        End Get
        Set(ByVal value As Integer)
            cpCuenta = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return cpNombre
        End Get
        Set(ByVal value As String)
            cpNombre = value
        End Set
    End Property

    Public Property LimiteDeCredito() As Decimal
        Get
            Return cpLimite
        End Get
        Set(ByVal value As Decimal)
            cpLimite = value
        End Set
    End Property

    Public Property Deuda() As Decimal
        Get
            Return cpDeuda
        End Get
        Set(ByVal value As Decimal)
            cpDeuda = value
        End Set
    End Property

    Public Property Siguiente() As Nodo
        Get
            Return sig
        End Get
        Set(ByVal value As Nodo)
            sig = value
        End Set
    End Property
End Class
