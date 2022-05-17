Public Class ClasePersona
    Private cmpNombre As String
    Private cmpApellido As String
    Private cmpDireccion As String
    Private cmpCiudad As String

    Public Property Nombre As String
        Get
            Return cmpNombre
        End Get
        Set(value As String)
            cmpNombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return cmpApellido
        End Get
        Set(value As String)
            cmpApellido = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return cmpDireccion
        End Get
        Set(value As String)
            cmpDireccion = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return cmpCiudad
        End Get
        Set(value As String)
            cmpCiudad = value
        End Set
    End Property
End Class
