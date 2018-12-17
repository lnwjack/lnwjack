<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ฟ = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(248, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "โปรแกรมคำนวณค่าจ้าง"
        '
        'lblIncome
        '
        Me.lblIncome.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblIncome.Location = New System.Drawing.Point(248, 161)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(134, 35)
        Me.lblIncome.TabIndex = 0
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTax.Location = New System.Drawing.Point(248, 221)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(134, 35)
        Me.lblTax.TabIndex = 0
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblResult.Location = New System.Drawing.Point(248, 273)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(134, 35)
        Me.lblResult.TabIndex = 0
        '
        'txtsalary
        '
        Me.txtsalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalary.Location = New System.Drawing.Point(224, 103)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(177, 22)
        Me.txtsalary.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(274, 341)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 53)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(75, 341)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 53)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(37, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 35)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เงินเดือน"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label10.Location = New System.Drawing.Point(37, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 35)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "รายได้ทั้งปี"
        '
        'ฟ
        '
        Me.ฟ.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ฟ.Location = New System.Drawing.Point(37, 221)
        Me.ฟ.Name = "ฟ"
        Me.ฟ.Size = New System.Drawing.Size(134, 35)
        Me.ฟ.TabIndex = 0
        Me.ฟ.Text = "ภาษี 5%"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Location = New System.Drawing.Point(37, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 35)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เงินได้หลังหักภาษี"
        '
        'frmfirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 425)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtsalary)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.ฟ)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmfirst"
        Me.Text = "Welcom to KaikaVB2N3 Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblIncome As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ฟ As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
