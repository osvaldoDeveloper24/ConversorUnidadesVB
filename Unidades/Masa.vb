Public Class Masa
    Inherits Unidad

    Public Sub New()
    End Sub

    Public Sub New(valor As Double, unidadBase As Integer, unidadEquivalencia As Integer, simboloUnidad As String)
        MyBase.New(valor, unidadBase, unidadEquivalencia, simboloUnidad)
    End Sub

    ' Sobrescribimos el método Convertir para manejar las conversiones de masa
    Public Function Convertir(numero As Double, opcionBase As Integer, opcionEquivalencia As Integer) As Double
        Dim respuesta As Double
        Select Case opcionBase
            Case 0 ' Miligramo
                If (opcionEquivalencia = 0) Then 'Milígramos
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 1) Then 'Gramos
                    respuesta = numero / 1000
                ElseIf (opcionEquivalencia = 2) Then 'Onzas
                    respuesta = numero / 28350
                ElseIf (opcionEquivalencia = 3) Then 'Libras
                    respuesta = numero / 453600
                ElseIf (opcionEquivalencia = 4) Then 'Kilogramos
                    respuesta = numero / 1000000.0
                ElseIf (opcionEquivalencia = 5) Then 'Toneladas
                    respuesta = numero / 1000000000.0
                End If


            Case 1 ' Gramo 
                If (opcionEquivalencia = 0) Then 'Milígramos
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 1) Then 'Onzas
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 2) Then 'Onzas
                    respuesta = numero / 28.35
                ElseIf (opcionEquivalencia = 3) Then ' Libras
                    respuesta = numero / 453.6
                ElseIf (opcionEquivalencia = 4) Then 'Kilogramos
                    respuesta = numero / 1000
                ElseIf (opcionEquivalencia = 5) Then ' Toneladas
                    respuesta = numero / 1000000.0
                End If

            Case 2 ' Onzas

            Case 3 ' Libras

            Case 4 'Kilogramos

            Case 5 ' Tonelas

        End Select


        Return respuesta
    End Function
End Class





