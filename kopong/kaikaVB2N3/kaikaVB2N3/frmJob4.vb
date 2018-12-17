Public Class frmJob4
    Const decR_Bonus = 0.2
    Const decR_Tax = 0.07
    Const decR_Allow = 0.01
    Dim Bonus As Double
    Dim Yearsalary As Double
    Dim sum As Double
    Dim allowance As Double
    Dim Tax As Double

    
    Private Sub btnCalTax_Click(sender As System.Object, e As System.EventArgs) Handles btnCalTax.Click
        Yearsalary = Val(txtSalary.Text) * 12
        Bonus = Val(txtSale.Text * decR_Bonus)
        sum = Yearsalary + Bonus
        allowance = sum * decR_Allow
        Tax = (sum - allowance) * decR_Tax

        lblYearSalary.Text = Yearsalary
        lblBonus.Text = Bonus
        lblAllincome.Text = sum
        lblAllwance.Text = allowance
        lblTax.Text = Tax
    End Sub

    Private Sub radShortDate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Date.Now.ToShortDateString
    End Sub

    Private Sub radGenDate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = Date.Now
    End Sub

    Private Sub radLongDate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = Date.Now.ToLongDateString
    End Sub
End Class