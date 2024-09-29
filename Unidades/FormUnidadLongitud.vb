Public Class FormUnidadLongitud
    Dim longitud As New Unidades.Longitud

    Dim resultado As Double
    Dim resultadoRedondeado As Double

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        longitud.Valor = Double.Parse(TextNumero.Text)
        Dim cantidad As Double = longitud.Valor

        longitud.UnidadBase = ComboUnidadBase.SelectedIndex
        Dim opcionBase As Integer = longitud.UnidadBase

        longitud.UnidadEquivalente = ComboUnidadEquivalencia.SelectedIndex
        Dim opcionEquivalencia As Integer = longitud.UnidadEquivalente

        resultado = longitud.convertir(cantidad, opcionBase, opcionEquivalencia)
        resultadoRedondeado = Math.Round(resultado, 2)
        TextResultado.Text = resultado.ToString()
    End Sub
End Class