Public Class FormUnidadAlmacenamiento
    Dim almacenamiento As New Unidades.Almacenamiento
    Dim resultado As Double
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()


    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        almacenamiento.Valor = Double.Parse(TextNumero.Text)
        Dim cantidad As Double = almacenamiento.Valor

        almacenamiento.UnidadBase = ComboUnidadBase.SelectedIndex
        Dim opcionBase As Integer = almacenamiento.UnidadBase

        almacenamiento.UnidadEquivalente = ComboUnidadEquivalencia.SelectedIndex
        Dim opcionEquivalencia As Integer = almacenamiento.UnidadEquivalente

        resultado = almacenamiento.Convertir(cantidad, opcionBase, opcionEquivalencia)
        TextResultado.Text = resultado.ToString()

    End Sub
End Class