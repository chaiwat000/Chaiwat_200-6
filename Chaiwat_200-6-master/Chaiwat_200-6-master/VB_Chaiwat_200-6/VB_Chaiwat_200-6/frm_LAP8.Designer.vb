<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LAP8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LAP8))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.lblTotalCredit = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOldGpa = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNewGrade = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Turquoise
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(810, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณเกรดเฉลี่ยสะสม"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstSubject
        '
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.ItemHeight = 16
        Me.lstSubject.Location = New System.Drawing.Point(30, 177)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(162, 212)
        Me.lstSubject.TabIndex = 1
        '
        'lstScore
        '
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.ItemHeight = 16
        Me.lstScore.Location = New System.Drawing.Point(221, 177)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(162, 212)
        Me.lstScore.TabIndex = 2
        '
        'lstCredit
        '
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.ItemHeight = 16
        Me.lstCredit.Location = New System.Drawing.Point(410, 177)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(162, 212)
        Me.lstCredit.TabIndex = 3
        '
        'lstGrade
        '
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.ItemHeight = 16
        Me.lstGrade.Location = New System.Drawing.Point(618, 177)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(162, 212)
        Me.lstGrade.TabIndex = 4
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(30, 408)
        Me.txtSubject.Multiline = True
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(162, 37)
        Me.txtSubject.TabIndex = 5
        Me.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCredit
        '
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCredit.Location = New System.Drawing.Point(410, 408)
        Me.txtCredit.Multiline = True
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(162, 37)
        Me.txtCredit.TabIndex = 8
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtScore
        '
        Me.txtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtScore.Location = New System.Drawing.Point(221, 408)
        Me.txtScore.Multiline = True
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(162, 37)
        Me.txtScore.TabIndex = 7
        Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(618, 408)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 37)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(708, 408)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 476)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "คะแนนสะสมก่อนหน้า"
        '
        'lblTotalScore
        '
        Me.lblTotalScore.BackColor = System.Drawing.Color.GreenYellow
        Me.lblTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalScore.Location = New System.Drawing.Point(221, 476)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(66, 23)
        Me.lblTotalScore.TabIndex = 12
        Me.lblTotalScore.Text = "150"
        Me.lblTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalCredit
        '
        Me.lblTotalCredit.BackColor = System.Drawing.Color.GreenYellow
        Me.lblTotalCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCredit.Location = New System.Drawing.Point(447, 476)
        Me.lblTotalCredit.Name = "lblTotalCredit"
        Me.lblTotalCredit.Size = New System.Drawing.Size(63, 23)
        Me.lblTotalCredit.TabIndex = 14
        Me.lblTotalCredit.Text = "50"
        Me.lblTotalCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 476)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "หน่วยกิตสะสม"
        '
        'lblOldGpa
        '
        Me.lblOldGpa.BackColor = System.Drawing.Color.GreenYellow
        Me.lblOldGpa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOldGpa.Location = New System.Drawing.Point(717, 476)
        Me.lblOldGpa.Name = "lblOldGpa"
        Me.lblOldGpa.Size = New System.Drawing.Size(66, 23)
        Me.lblOldGpa.TabIndex = 16
        Me.lblOldGpa.Text = "3.00"
        Me.lblOldGpa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(588, 476)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "เกรดเฉลี่ยสะสม"
        '
        'lblNewGrade
        '
        Me.lblNewGrade.BackColor = System.Drawing.Color.GreenYellow
        Me.lblNewGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNewGrade.Location = New System.Drawing.Point(487, 543)
        Me.lblNewGrade.Name = "lblNewGrade"
        Me.lblNewGrade.Size = New System.Drawing.Size(103, 42)
        Me.lblNewGrade.TabIndex = 18
        Me.lblNewGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(196, 549)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "เกรดเฉลี่ยสะสมภาคปัจจุบัน"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 48)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "วิชา"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(615, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 48)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "เกรด"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(407, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 48)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "หน่วยกิต"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(221, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 48)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "คะแนนสอบ"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_LAP8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 605)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblNewGrade)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblOldGpa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotalCredit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstSubject)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_LAP8"
        Me.ShowInTaskbar = False
        Me.Text = "frm_LAP8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstSubject As ListBox
    Friend WithEvents lstScore As ListBox
    Friend WithEvents lstCredit As ListBox
    Friend WithEvents lstGrade As ListBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalScore As Label
    Friend WithEvents lblTotalCredit As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOldGpa As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNewGrade As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
