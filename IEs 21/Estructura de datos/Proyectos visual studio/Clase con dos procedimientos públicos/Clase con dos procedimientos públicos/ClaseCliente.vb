Public Class ClaseCliente

    Inherits ClasePersona

    Private cmpCodigo As Integer
    Private cmpDeuda As Decimal

    Public Sub Comprar(Importe As Decimal)
        cmpDeuda = cmpDeuda + Importe

    End Sub

    Public Sub Pagar(Importe As Decimal)
        cmpDeuda = cmpDeuda - Importe

    End Sub

    Public Property Codigo As Integer
        Get
            Return cmpCodigo
        End Get
        Set(Cod As Integer)
            cmpCodigo = Cod
        End Set
    End Property

    Public Property Deuda As Decimal
        Get
            Return cmpDeuda
        End Get
        Set(Deu As Decimal)
            cmpDeuda = Deu
        End Set
    End Property
End Class
