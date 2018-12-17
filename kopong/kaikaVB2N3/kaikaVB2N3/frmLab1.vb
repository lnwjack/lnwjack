Public Class frmLab1

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click




        lblIncome.Text = Val(txtsalary.Text) * 12
        lblTax.Text = Val(lblIncome.Text) * 0.05
        lblResult.Text = lblIncome.Text - lblTax.Text




    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()


    End Sub
End Class
