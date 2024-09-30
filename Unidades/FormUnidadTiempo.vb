Public Class FormUnidadTiempo
    Dim tiempo As New Unidades.Tiempo
    Dim resultado As Double
    Dim resultadoRedondeado As Double
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        tiempo.Valor = Double.Parse(TextNumero.Text)
        Dim cantidad As Double = tiempo.Valor

        tiempo.UnidadBase = ComboUnidadBase.SelectedIndex
        Dim opcionBase As Integer = tiempo.UnidadBase

        tiempo.UnidadEquivalente = ComboUnidadEquivalencia.SelectedIndex
        Dim opcionEquivalencia As Integer = tiempo.UnidadEquivalente

        resultado = tiempo.Convertir(cantidad, opcionBase, opcionEquivalencia)
        resultadoRedondeado = Math.Round(resultado, 2)

        TextResultado.Text = resultado.ToString()
    End Sub
End Class