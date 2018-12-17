Public Class frmAssign3

    Private Sub CboSelect_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSelect.SelectedIndexChanged
        Dim size As Integer = Val(cboSelect.Text)
        txtMyNumber.Font = New Font(txtMyNumber.Font.Name, size, FontStyle.Regular)
    End Sub


    Private Sub lblFRed_Click(sender As System.Object, e As System.EventArgs) Handles lblFRed.Click
        txtMyNumber.ForeColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(sender As System.Object, e As System.EventArgs) Handles lblFBlue.Click
        txtMyNumber.ForeColor = Color.Blue
    End Sub

    Private Sub lblFGreen_Click(sender As System.Object, e As System.EventArgs) Handles lblFGreen.Click
        txtMyNumber.ForeColor = Color.Green
    End Sub

    Private Sub lblFBrown_Click(sender As System.Object, e As System.EventArgs) Handles lblFBrown.Click
        txtMyNumber.ForeColor = Color.Brown
    End Sub

    Private Sub lblFViolet_Click(sender As System.Object, e As System.EventArgs) Handles lblFViolet.Click
        txtMyNumber.ForeColor = Color.Violet
    End Sub

    Private Sub lblFWhite_Click(sender As System.Object, e As System.EventArgs) Handles lblFWhite.Click
        txtMyNumber.ForeColor = Color.White
    End Sub

    Private Sub lblFBlack_Click(sender As System.Object, e As System.EventArgs) Handles lblFBlack.Click
        txtMyNumber.ForeColor = Color.Black
    End Sub

    Private Sub lblFSky_Click(sender As System.Object, e As System.EventArgs) Handles lblFSky.Click
        txtMyNumber.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBRed_Click(sender As System.Object, e As System.EventArgs) Handles lblBRed.Click
        txtMyNumber.BackColor = Color.Red
    End Sub

    Private Sub lblBOrange_Click(sender As System.Object, e As System.EventArgs) Handles lblBOrange.Click
        txtMyNumber.BackColor = Color.Orange
    End Sub

    Private Sub lblBBlue_Click(sender As System.Object, e As System.EventArgs) Handles lblBBlue.Click
        txtMyNumber.BackColor = Color.Blue
    End Sub

    Private Sub lblBYellow_Click(sender As System.Object, e As System.EventArgs) Handles lblBYellow.Click
        txtMyNumber.BackColor = Color.Yellow
    End Sub

    Private Sub lblBgreen_Click(sender As System.Object, e As System.EventArgs) Handles lblBgreen.Click
        txtMyNumber.BackColor = Color.Green
    End Sub

    Private Sub lblBBrown_Click(sender As System.Object, e As System.EventArgs) Handles lblBBrown.Click
        txtMyNumber.BackColor = Color.Brown
    End Sub

    Private Sub lblBViolet_Click(sender As System.Object, e As System.EventArgs) Handles lblBViolet.Click
        txtMyNumber.BackColor = Color.Violet
    End Sub

    Private Sub lblBwhite_Click(sender As System.Object, e As System.EventArgs) Handles lblBwhite.Click
        txtMyNumber.BackColor = Color.White
    End Sub

    Private Sub lblBBlack_Click(sender As System.Object, e As System.EventArgs) Handles lblBBlack.Click
        txtMyNumber.BackColor = Color.Black
    End Sub

    Private Sub lblBSky_Click(sender As System.Object, e As System.EventArgs) Handles lblBSky.Click
        txtMyNumber.BackColor = Color.SkyBlue
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        txtMyNumber.Text = Val(txtMyNumber.Text) + 3
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        txtMyNumber.Text = Val(txtMyNumber.Text) - 3
    End Sub

    Private Sub txtMyNumber_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMyNumber.TextChanged

    End Sub

    Private Sub lblFOrange_Click(sender As System.Object, e As System.EventArgs) Handles lblFOrange.Click
        txtMyNumber.ForeColor = Color.Orange
    End Sub
End Class