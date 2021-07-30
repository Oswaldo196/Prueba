Public Class EMPLEADO
    Inherits PERSONA

    'ATRIBUTOS
    Private _tipoContrato As String
    Private _sueldo As Double

    'PROPIEDADES 
    Public Property TipoCotrato As String
        Get
            Return _tipoContrato
        End Get
        Set(value As String)
            _tipoContrato = value
        End Set
    End Property

    Public Property Sueldo As Double
        Get
            Return _sueldo
        End Get
        Set(value As Double)
            _sueldo = value
        End Set
    End Property

    'OPERACIONES 
    Public Sub calcularSueldo(sueldoBase As Double)
        If (Me.TipoCotrato = "C") Then
            Me.Sueldo = sueldoBase + 350
        ElseIf (Me.TipoCotrato = "N") Then
            Me.Sueldo = sueldoBase + 500
        Else
            Me.Sueldo = 0
        End If
    End Sub
End Class
