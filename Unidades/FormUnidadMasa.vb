Public Class FormUnidadMasa
    Dim masa As New Unidades.Masa
    Dim resultado As Double

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        masa.Valor = Double.Parse(TextNumero.Text)
        Dim cantidad As Double = masa.Valor

        masa.UnidadBase = ComboUnidadBase.SelectedIndex
        Dim opcionBase As Integer = masa.UnidadBase

        masa.UnidadEquivalente = ComboUnidadEquivalencia.SelectedIndex
        Dim opcionEquivalencia As Integer = masa.UnidadEquivalente

        resultado = masa.Convertir(cantidad, opcionBase, opcionEquivalencia)
        TextResultado.Text = resultado.ToString()



    End Sub
End Class
