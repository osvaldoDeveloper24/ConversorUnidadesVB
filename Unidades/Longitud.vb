﻿Public Class Longitud
    Inherits Unidad

    Public Sub New()
    End Sub

    Public Sub New(valor As Double, unidadBase As Integer, unidadEquivalencia As Integer, simboloUnidad As String)
        MyBase.New(valor, unidadBase, unidadEquivalencia, simboloUnidad)
    End Sub

    Public Function convertir(numero As Double, unidadBase As Integer, opcionEquivalencia As Integer) As Double
        Dim respuesta As Double

        Select Case unidadBase
            Case 0 'Milimetro
                If (opcionEquivalencia = 0) Then
                    respuesta = numero * 1 'Milimetro
                ElseIf (opcionEquivalencia = 1) Then
                    respuesta = numero / 100000 'Centimetro
                ElseIf (opcionEquivalencia = 2) Then
                    respuesta = numero / 39370.1 'Pulgada
                ElseIf (opcionEquivalencia = 3) Then
                    respuesta = numero / 3280.84 'Pie
                ElseIf (opcionEquivalencia = 4) Then
                    respuesta = numero / 1093.61 'Yarda
                ElseIf (opcionEquivalencia = 5) Then
                    respuesta = numero / 1000 'Metro
                ElseIf (opcionEquivalencia = 6) Then
                    respuesta = numero / 1000000 'Kilometro
                End If

            Case 1 'Centimetro
                If (opcionEquivalencia = 0) Then
                    respuesta = numero / 10 'milimetro 
                ElseIf (opcionEquivalencia = 1) Then
                    respuesta = numero * 1 'Centimetro
                ElseIf (opcionEquivalencia = 2) Then
                    respuesta = numero / 0.3937 'Pulgada
                ElseIf (opcionEquivalencia = 3) Then
                    respuesta = numero / 0.0328 'Pie
                ElseIf (opcionEquivalencia = 4) Then
                    respuesta = numero / 0.0109 'Yarda
                ElseIf (opcionEquivalencia = 5) Then
                    respuesta = numero / 0.01 'Metro
                ElseIf (opcionEquivalencia = 6) Then
                    respuesta = numero / 0.00001 'Kilometro
                End If

            Case 2 'Pulgada
                If (opcionEquivalencia = 0) Then
                    respuesta = numero / 25.4 'Milimetro
                ElseIf (opcionEquivalencia = 1) Then
                    respuesta = numero / 2.54 'centimetro
                ElseIf (opcionEquivalencia = 2) Then
                    respuesta = numero / 0.3937 'Pulgada
                ElseIf (opcionEquivalencia = 3) Then
                    respuesta = numero / 0.0328 'Pie
                ElseIf (opcionEquivalencia = 4) Then
                    respuesta = numero / 0.0109 'Yarda
                ElseIf (opcionEquivalencia = 5) Then
                    respuesta = numero / 0.01 'Metro
                ElseIf (opcionEquivalencia = 6) Then
                    respuesta = numero / 0.0000254 'Kilometro
                End If

            Case 3 'Pie
                If (opcionEquivalencia = 0) Then
                    respuesta = numero / 304.8 'Milimetro
                ElseIf (opcionEquivalencia = 1) Then
                    respuesta = numero / 30.48 'Centimetro
                ElseIf (opcionEquivalencia = 2) Then
                    respuesta = numero * 1 'Pie
                ElseIf (opcionEquivalencia = 4) Then
                    respuesta = numero / 0.3333 'Yarda
                ElseIf (opcionEquivalencia = 5) Then
                    respuesta = numero / 0.3048 'Metro
                ElseIf (opcionEquivalencia = 6) Then
                    respuesta = numero / 0.0003048 'Kilometro
                End If

            Case 4 'Yarda
                If (opcionEquivalencia = 0) Then
                    respuesta = numero / 914.4 'Milimetro
                ElseIf (opcionEquivalencia = 1) Then
                    respuesta = numero / 91.44 'Centimetro
                ElseIf (opcionEquivalencia = 2) Then
                    respuesta = numero / 3 'Pie
                ElseIf (opcionEquivalencia = 4) Then
                    respuesta = numero * 1 'Yarda
                ElseIf (opcionEquivalencia = 5) Then
                    respuesta = numero / 0.9144 'Metro
                ElseIf (opcionEquivalencia = 6) Then
                    respuesta = numero / 0.0009144 'Kilometro
                End If

            Case 5 'Metro
                If (opcionEquivalencia = 0) Then
                    respuesta = numero / 1000 'Milimetro
                ElseIf (opcionEquivalencia = 1) Then
                    respuesta = numero / 100 'Centimetro
                ElseIf (opcionEquivalencia = 2) Then
                    respuesta = numero / 3.28084 'Pie
                ElseIf (opcionEquivalencia = 4) Then
                    respuesta = numero / 1.09361 'Yarda
                ElseIf (opcionEquivalencia = 5) Then
                    respuesta = numero * 1 'Metro
                ElseIf (opcionEquivalencia = 6) Then
                    respuesta = numero / 0.001 'Kilometro
                End If

            Case 6 'Kiometro
                If (opcionEquivalencia = 0) Then
                    respuesta = numero / 1000000 'Milimetro
                ElseIf (opcionEquivalencia = 1) Then
                    respuesta = numero / 100000 'Centimetro
                ElseIf (opcionEquivalencia = 2) Then
                    respuesta = numero / 3280.84 'Pie
                ElseIf (opcionEquivalencia = 4) Then
                    respuesta = numero / 1093.61 'Yarda
                ElseIf (opcionEquivalencia = 5) Then
                    respuesta = numero / 1000 'Metro
                ElseIf (opcionEquivalencia = 6) Then
                    respuesta = numero * 1 'Kilometro
                End If

        End Select
    End Function


End Class
