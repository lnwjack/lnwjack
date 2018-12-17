Public Class frmLab2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim total As Integer
        Dim com1 As Integer
        Dim com2 As Integer
        Dim Vistra As Double = Val(txt1.Text)
        Dim Frista As Double = Val(txt2.Text)

        total = Val(txt1.Text) + Val(txt2.Text)
        lbl5.Text = total
        com1 = Val(txt1.Text) * 0.05
        com2 = Val(txt2.Text) * 0.1
        lbl6.Text = com1 + com2
        lbl10.Text = com1.ToString
        lbl9.Text = com2.ToString

    End Sub

    Private Sub frmLab2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class