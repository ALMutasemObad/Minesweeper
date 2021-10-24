Public Class Minesweeper
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        b1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        b2.Enabled = False
        b7.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        b3.Enabled = False
        b5.Enabled = False
        b9.Enabled = False

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        b4.Enabled = False
        b8.Enabled = False

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        b6.Enabled = False
        b1.Enabled = False
        Label1.Text = "Game Over"
        Label1.Visible = True

        B10.Visible = True




    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        b1.Hide()

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        b2.Hide()
        b6.Hide()
        b9.Hide()

    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        b3.Hide()
        b5.Hide()
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        b4.Hide()
        b2.Hide()
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        b5.Hide()
        b7.Hide()
        b8.Hide()
        b9.Hide()

    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        b6.Hide()
        b5.Hide()

    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        b7.Hide()
        b3.Hide()

    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        b8.Hide()
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        b9.Hide()
        b4.Hide()

    End Sub

    Private Sub B10_Click(sender As Object, e As EventArgs) Handles B10.Click
        b1.Show()
        b2.Show()
        b3.Show()
        b4.Show()
        b5.Show()
        b6.Show()
        b7.Show()
        b8.Show()
        b9.Show()
        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True
        b5.Enabled = True
        b6.Enabled = True
        b7.Enabled = True
        b8.Enabled = True
        b9.Enabled = True
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        B10.Visible = False
        Label1.Visible = False
    End Sub
End Class
