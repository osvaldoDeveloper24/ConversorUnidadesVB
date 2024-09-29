Public Class Almacenamiento
    Inherits Unidad

    Public Sub New()
    End Sub

    Public Sub New(valor As Double, unidadBase As Integer, unidadEquivalencia As Integer, simboloUnidad As String)
        MyBase.New(valor, unidadBase, unidadEquivalencia, simboloUnidad)
    End Sub


    Public Function Convertir(numero As Double, opcionBase As Integer, opcionEquivalencia As Integer) As Double
        Dim respuesta As Double
        Select Case opcionBase
            Case 0 ' Byte
                If (opcionEquivalencia = 0) Then 'Byte
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 1) Then 'Kilobyte
                    respuesta = numero / 1000
                ElseIf (opcionEquivalencia = 2) Then 'Kibibyte
                    respuesta = numero / 1024
                ElseIf (opcionEquivalencia = 3) Then 'Megabyte
                    respuesta = numero / 1000000.0
                ElseIf (opcionEquivalencia = 4) Then 'Gigabyte
                    respuesta = numero / 1000000000.0
                ElseIf (opcionEquivalencia = 5) Then 'Terabyte
                    respuesta = numero / 1000000000000.0
                ElseIf (opcionEquivalencia = 6) Then 'Petabyte
                    respuesta = numero / 1000000000000000


                End If

            Case 1 ' Kilobyte 
                If (opcionEquivalencia = 0) Then 'Byte
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 1) Then 'Kilobyte
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 2) Then 'Kibibyte
                    respuesta = numero / 1024
                ElseIf (opcionEquivalencia = 3) Then 'Megabyte
                    respuesta = numero / 1000
                ElseIf (opcionEquivalencia = 4) Then 'Gigabyte
                    respuesta = numero / 1000000.0
                ElseIf (opcionEquivalencia = 5) Then 'Terabyte
                    respuesta = numero / 1000000000.0
                ElseIf (opcionEquivalencia = 6) Then 'Petabyte
                    respuesta = numero / 1000000000000.0
                End If


            Case 2 ' Kibibyte
                If (opcionEquivalencia = 0) Then 'Byte
                    respuesta = numero * 1024
                ElseIf (opcionEquivalencia = 1) Then 'Kilobyte
                    respuesta = numero * 1024
                ElseIf (opcionEquivalencia = 2) Then 'Kibibyte
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 3) Then 'Megabyte
                    respuesta = numero / 976.6
                ElseIf (opcionEquivalencia = 4) Then 'Gigabyte
                    respuesta = numero / 976600
                ElseIf (opcionEquivalencia = 5) Then 'Terabyte
                    respuesta = numero / 976600000.0
                ElseIf (opcionEquivalencia = 6) Then 'Petabyte
                    respuesta = numero / 976600000000.0
                End If

            Case 3 ' Megabyte
                If (opcionEquivalencia = 0) Then 'Byte
                    respuesta = numero * 1000000.0
                ElseIf (opcionEquivalencia = 1) Then 'Kilobyte
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 2) Then 'Kibibyte
                    respuesta = numero * 976.6
                ElseIf (opcionEquivalencia = 3) Then 'Megabyte
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 4) Then 'Gigabyte
                    respuesta = numero / 1000
                ElseIf (opcionEquivalencia = 5) Then 'Terabyte
                    respuesta = numero / 1000000.0
                ElseIf (opcionEquivalencia = 6) Then 'Petabyte
                    respuesta = numero / 1000000000.0
                End If
            Case 4 'Gigabyte
                If (opcionEquivalencia = 0) Then 'Byte
                    respuesta = numero * 1000000000.0
                ElseIf (opcionEquivalencia = 1) Then 'Kilobyte
                    respuesta = numero * 1000000.0
                ElseIf (opcionEquivalencia = 2) Then 'Kibibyte
                    respuesta = numero * 976600
                ElseIf (opcionEquivalencia = 3) Then 'Megabyte
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 4) Then 'Gigabyte
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 5) Then 'Terabyte
                    respuesta = numero / 1000
                ElseIf (opcionEquivalencia = 6) Then 'Petabyte
                    respuesta = numero / 1000000.0
                End If

            Case 5 ' Terabyte
                If (opcionEquivalencia = 0) Then 'Byte
                    respuesta = numero * 1000000000000.0
                ElseIf (opcionEquivalencia = 1) Then 'Kilobyte
                    respuesta = numero * 1000000000.0
                ElseIf (opcionEquivalencia = 2) Then 'Kibibyte
                    respuesta = numero * 976600000.0
                ElseIf (opcionEquivalencia = 3) Then 'Megabyte
                    respuesta = numero * 1000000.0
                ElseIf (opcionEquivalencia = 4) Then 'Gigabyte
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 5) Then 'Terabyte
                    respuesta = numero * 1
                ElseIf (opcionEquivalencia = 6) Then 'Petabyte
                    respuesta = numero / 1000
                End If
            Case 6 'Petabyte
                If (opcionEquivalencia = 0) Then 'Byte
                    respuesta = numero * 1.0E+15
                ElseIf (opcionEquivalencia = 1) Then 'Kilobyte
                    respuesta = numero * 1000000000000.0
                ElseIf (opcionEquivalencia = 2) Then 'Kibibyte
                    respuesta = numero * 976600000000.0
                ElseIf (opcionEquivalencia = 3) Then 'Megabyte
                    respuesta = numero * 1000000000.0
                ElseIf (opcionEquivalencia = 4) Then 'Gigabyte
                    respuesta = numero * 1000000.0
                ElseIf (opcionEquivalencia = 5) Then 'Terabyte
                    respuesta = numero * 1000
                ElseIf (opcionEquivalencia = 6) Then 'Petabyte
                    respuesta = numero * 1
                End If
        End Select
        Return respuesta
    End Function

End Class
