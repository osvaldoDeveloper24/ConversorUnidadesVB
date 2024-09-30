Public Class FormUnidadMasa
    Dim masa As New Unidades.Masa
    Dim resultado As Double

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If Not Double.TryParse(TextNumero.Text, masa.Valor) Then
            MessageBox.Show("Ingrese un valor numérico válido.", "ENTRADA NUMÉRICA", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Exit Sub
        ElseIf (ComboUnidadBase.SelectedIndex = -1) Then
            MessageBox.Show("Seleccione una unidad base.", "UNIDAD BASE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (ComboUnidadEquivalencia.SelectedIndex = -1) Then
            MessageBox.Show("Seleccione una unidad de equivalencia.", "UNIDAD EQUIVALENTE", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            Dim cantidad As Double = masa.Valor
            masa.UnidadBase = ComboUnidadBase.SelectedIndex
            Dim opcionBase As Integer = masa.UnidadBase
            masa.UnidadEquivalente = ComboUnidadEquivalencia.SelectedIndex
            Dim opcionEquivalente As Integer = masa.UnidadEquivalente

            resultado = masa.Convertir(cantidad, opcionBase, opcionEquivalente)

            TextResultado.Text = resultado.ToString()

        Catch ex As Exception
            MessageBox.Show("No se puede realizar la conversión: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
