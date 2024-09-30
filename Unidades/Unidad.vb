Public Class Unidad

    Private _valor As Double
    Private _unidadBase As Integer
    Private _unidadEquivalencia As Integer
    Private _simboloUnidad As String
    Private _resultado As Double
    Public Sub New()
    End Sub

    Public Sub New(valor As Double, unidadBase As Integer, unidadEquivalencia As Integer, simboloUnidad As String)
        Me._valor = valor
        Me._unidadBase = unidadBase
        Me._unidadEquivalencia = unidadEquivalencia
        Me._simboloUnidad = simboloUnidad
    End Sub
    Public Property Valor As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            Me._valor = value
        End Set

    End Property


    Public Property UnidadBase As Integer
        Get
            Return _unidadBase
        End Get
        Set(value As Integer)
            Me._unidadBase = value
        End Set
    End Property

    Public Property UnidadEquivalente As Integer
        Get
            Return _unidadEquivalencia
        End Get
        Set(value As Integer)
            Me._unidadEquivalencia = value
        End Set
    End Property

    Public Property SimboloUnidad As String
        Get
            Return _simboloUnidad
        End Get
        Set(value As String)
            Me._simboloUnidad = value
        End Set
    End Property

    Public Property Resultado As Double
        Get
            Return _resultado
        End Get
        Set(value As Double)
            Me._resultado = value
        End Set
    End Property

End Class
