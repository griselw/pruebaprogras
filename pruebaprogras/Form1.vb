Public Class Form1
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnazul.Click
        txtColores.BackColor = Color.Blue
    End Sub

    Private Sub txtRojo_Click(sender As Object, e As EventArgs) Handles txtRojo.Click
        txtColores.BackColor = Color.Red
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnverde.Click
        txtColores.BackColor = Color.Green
    End Sub

    Private Sub btnamarillo_Click(sender As Object, e As EventArgs) Handles btnamarillo.Click
        txtColores.BackColor = Color.Yellow
    End Sub

    Private Sub btnmorado_Click(sender As Object, e As EventArgs) Handles btnmorado.Click
        txtColores.BackColor = Color.Violet
    End Sub
End Class
