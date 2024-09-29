Public Class Masa
    Inherits Unidad

    Public Sub New()
    End Sub

    Public Sub New(valor As Double, unidadBase As Integer, unidadEquivalencia As Integer, simboloUnidad As String)
        MyBase.New(valor, unidadBase, unidadEquivalencia, simboloUnidad)
    End Sub


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

                'Fin miligramos a otras unidades   


            Case 1 ' Gramo 
                If (opcionEquivalencia = 0) Then 'Milígramos
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 1) Then 'gramos
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
                If (opcionEquivalencia = 0) Then 'Milígramos
                    respuesta = numero * 28350
                ElseIf (opcionEquivalencia = 1) Then 'gramos
                    respuesta = numero * 28.35
                ElseIf (opcionEquivalencia = 2) Then 'Onzas
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 3) Then ' Libras
                    respuesta = numero / 16
                ElseIf (opcionEquivalencia = 4) Then 'Kilogramos
                    respuesta = numero / 35.274
                ElseIf (opcionEquivalencia = 5) Then ' Toneladas
                    respuesta = numero / 35270
                End If

            Case 3 ' Libras
                If (opcionEquivalencia = 0) Then 'Milígramos
                    respuesta = numero * 453600
                ElseIf (opcionEquivalencia = 1) Then 'gramos
                    respuesta = numero * 453.6
                ElseIf (opcionEquivalencia = 2) Then 'Onzas
                    respuesta = numero * 16
                ElseIf (opcionEquivalencia = 3) Then ' Libras
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 4) Then 'Kilogramos
                    respuesta = numero / 2.205
                ElseIf (opcionEquivalencia = 5) Then ' Toneladas
                    respuesta = numero / 2205
                End If
            Case 4 'Kilogramos
                If (opcionEquivalencia = 0) Then 'Milígramos
                    respuesta = numero * 1000000.0
                ElseIf (opcionEquivalencia = 1) Then 'gramos
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 2) Then 'Onzas
                    respuesta = numero * 35.274
                ElseIf (opcionEquivalencia = 3) Then ' Libras
                    respuesta = numero * 2.205
                ElseIf (opcionEquivalencia = 4) Then 'Kilogramos
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 5) Then ' Toneladas
                    respuesta = numero / 1000
                End If

            Case 5 ' Tonelas
                If (opcionEquivalencia = 0) Then 'Milígramos
                    respuesta = numero * 1000000000.0
                ElseIf (opcionEquivalencia = 1) Then 'gramos
                    respuesta = numero * 1000000.0
                ElseIf (opcionEquivalencia = 2) Then 'Onzas
                    respuesta = numero * 35270
                ElseIf (opcionEquivalencia = 3) Then ' Libras
                    respuesta = numero * 2205
                ElseIf (opcionEquivalencia = 4) Then 'Kilogramos
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 5) Then ' Toneladas
                    respuesta = numero * 1
                End If
        End Select
        Return respuesta
    End Function
End Class





