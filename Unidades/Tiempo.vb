Public Class Tiempo
    Inherits Unidad

    Public Sub New()
    End Sub

    Public Sub New(valor As Double, unidadBase As Integer, unidadEquivalencia As Integer, simboloUnidad As String)
        MyBase.New(valor, unidadBase, unidadEquivalencia, simboloUnidad)
    End Sub


    Public Function Convertir(numero As Double, opcionBase As Integer, opcionEquivalencia As Integer) As Double
        Dim respuesta As Double
        Select Case opcionBase
            Case 0 'Milisegundo
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero * 0.001
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero * 0.0000166667
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 0.000000277778
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 0.000000011574
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 0.0000000016534
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 0.00000000038052
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 0.00000000003171
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero * 0.000000000003171
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero * 0.0000000000003171
                End If

            Case 1 'Segundo
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero * 0.0166667
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 0.000277778
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 0.000011574
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 0.0000016534
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 0.00000038052
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 0.00000003171
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero * 0.000000003171
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero * 0.0000000003171
                End If

            Case 2 'Minuto
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 60000
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero * 60
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 0.0166667
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 0.000694444
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 0.000099206
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 0.000022831
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 0.0000019026
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero * 0.00000019026
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero * 0.000000019026
                End If

            Case 3 'Hora
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 3600000.0
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero * 3600
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero / 60
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 0.0416667
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 0.00595238
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 0.00136986
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 0.000114155
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero * 0.00001416
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero * 0.0000011416
                End If

            Case 4 'Día 
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 86400000.0
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero * 86400
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero * 1440
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 24
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 0.142857
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 0.0328767
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 0.00273973
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero * 0.000273973
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero * 0.000027397
                End If


            Case 5 'Semana 
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 604800000.0
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero * 604800
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero * 10080
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 168
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 7
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 0.230137
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 0.0191781
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero * 0.00191781
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero * 0.000191781
                End If

            Case 6 'Mes
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 2628000000.0
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero + 2628000.0
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero * 43800
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 730.001
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 30.4167
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 4.34524
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 0.0833334
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero * 0.00833334
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero * 0.000833334
                End If

            Case 7 'Año
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 31540000000.0
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero * 31540000.0
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero * 525600
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 8760
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 365
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 52
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 12
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero / 0.1
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero / 0.01
                End If

            Case 8 'Decada
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 315400000000.0
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero * 315400000.0
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero * 5256000.0
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 87600
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 3650
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 520
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 120
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 10
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero * 0.1
                End If

            Case 9 'Siglo
                If (opcionEquivalencia = 0) Then 'Milisegundo 
                    respuesta = numero * 3154000000000.0
                ElseIf (opcionEquivalencia = 1) Then 'Segundo
                    respuesta = numero * 3154000000.0
                ElseIf (opcionEquivalencia = 2) Then 'Minuto
                    respuesta = numero * 52560000.0
                ElseIf (opcionEquivalencia = 3) Then 'Hora
                    respuesta = numero * 876000
                ElseIf (opcionEquivalencia = 4) Then 'Día
                    respuesta = numero * 36500
                ElseIf (opcionEquivalencia = 5) Then 'Semana
                    respuesta = numero * 5200
                ElseIf (opcionEquivalencia = 6) Then 'Mes
                    respuesta = numero * 1200
                ElseIf (opcionEquivalencia = 7) Then 'Año
                    respuesta = numero * 100
                ElseIf (opcionEquivalencia = 8) Then 'Decada
                    respuesta = numero * 10
                ElseIf (opcionEquivalencia = 9) Then 'Siglo
                    respuesta = numero * 1
                End If


        End Select
        Return respuesta
    End Function


End Class
