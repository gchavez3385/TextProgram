Public Class Gregory_Chavez_Simple_Visual_Basic_Text_Program
    Private ReadOnly TimesNewRoman As Font

    Private Sub btnClickMe_Click(sender As Object, e As EventArgs) Handles btnClickMe.Click
        Me.lblHello.Text = "HELLO"
    End Sub

    Private Sub btnChangeColor_Click(sender As Object, e As EventArgs) Handles btnChangeColor.Click
        Me.lblHello.ForeColor = Color.Firebrick
    End Sub

    Private Sub btnChangeLanguage_Click(sender As Object, e As EventArgs) Handles btnChangeLanguage.Click
        Me.lblHello.Text = "HOLA"
    End Sub

    Private Sub btnChangeLocation_Click(sender As Object, e As EventArgs) Handles btnChangeLocation.Click
        lblHello.Location = New Point(75, 75)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Application.Restart()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
