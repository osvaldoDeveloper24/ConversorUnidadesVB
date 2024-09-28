
Public Class Form1
    Inherits Form

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
            Me.Close()
        End Sub

        Private Sub PictureLongitud_Click(sender As Object, e As EventArgs) Handles PictureLongitud.Click
            Dim longitud As New Unidades.FormUnidadLongitud
            longitud.Show()
            Me.Hide()
        End Sub

        Private Sub PictureTiempo_Click(sender As Object, e As EventArgs) Handles PictureTiempo.Click
            Dim tiempo As New Unidades.FormUnidadTiempo
            tiempo.Show()
            Me.Hide()
        End Sub

        Private Sub PictureAlmacenamiento_Click(sender As Object, e As EventArgs) Handles PictureAlmacenamiento.Click
            Dim almacenamiento As New Unidades.FormUnidadAlmacenamiento
            almacenamiento.Show()
            Me.Hide()
        End Sub

        Private Sub PictureMasa_Click(sender As Object, e As EventArgs) Handles PictureMasa.Click
            Dim masa As New Unidades.FormUnidadMasa
            masa.Show()
            Me.Hide()
        End Sub

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class


