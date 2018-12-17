<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดขาย Vistra Glota"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(26, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ยอดขาย Frista Glota"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(26, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ผลรวมยอดขาย"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(26, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ค่าคอมมิชชั่น"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(164, 44)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(164, 78)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 1
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl5.Location = New System.Drawing.Point(164, 121)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(100, 23)
        Me.lbl5.TabIndex = 2
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl6.Location = New System.Drawing.Point(164, 172)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(100, 23)
        Me.lbl6.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(134, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 66)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl10
        '
        Me.lbl10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl10.Location = New System.Drawing.Point(325, 41)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(100, 23)
        Me.lbl10.TabIndex = 2
        '
        'lbl9
        '
        Me.lbl9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl9.Location = New System.Drawing.Point(325, 78)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(100, 23)
        Me.lbl9.TabIndex = 2
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Location = New System.Drawing.Point(284, 44)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(24, 13)
        Me.lbl7.TabIndex = 4
        Me.lbl7.Text = "5 %"
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Location = New System.Drawing.Point(278, 81)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(30, 13)
        Me.lbl8.TabIndex = 4
        Me.lbl8.Text = "10 %"
        '
        'frmLab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 351)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
End Class
