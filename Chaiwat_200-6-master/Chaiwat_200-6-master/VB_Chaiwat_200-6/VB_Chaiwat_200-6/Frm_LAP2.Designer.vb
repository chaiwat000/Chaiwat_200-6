<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_LAP2
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
        Me.txtVista = New System.Windows.Forms.TextBox()
        Me.txtComToshiba = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVistra = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblComVis = New System.Windows.Forms.Label()
        Me.lblComshi = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblComtoshi = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSumsell = New System.Windows.Forms.Label()
        Me.lblSumCom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "คำนวณยอดขายสินค้า"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVista
        '
        Me.txtVista.Location = New System.Drawing.Point(214, 49)
        Me.txtVista.Name = "txtVista"
        Me.txtVista.Size = New System.Drawing.Size(100, 28)
        Me.txtVista.TabIndex = 1
        Me.txtVista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtComToshiba
        '
        Me.txtComToshiba.Location = New System.Drawing.Point(296, 92)
        Me.txtComToshiba.Name = "txtComToshiba"
        Me.txtComToshiba.Size = New System.Drawing.Size(100, 28)
        Me.txtComToshiba.TabIndex = 2
        Me.txtComToshiba.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vistra Gluta   ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = " Computer Toshiba Extra520x   ="
        '
        'lblVistra
        '
        Me.lblVistra.AutoSize = True
        Me.lblVistra.Location = New System.Drawing.Point(25, 136)
        Me.lblVistra.Name = "lblVistra"
        Me.lblVistra.Size = New System.Drawing.Size(195, 22)
        Me.lblVistra.TabIndex = 5
        Me.lblVistra.Text = "ยอดขาย  Vistra Gluta  ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(25, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "ค่าคอมมิชชั่น"
        '
        'lblComVis
        '
        Me.lblComVis.AutoSize = True
        Me.lblComVis.Location = New System.Drawing.Point(25, 238)
        Me.lblComVis.Name = "lblComVis"
        Me.lblComVis.Size = New System.Drawing.Size(127, 22)
        Me.lblComVis.TabIndex = 7
        Me.lblComVis.Text = "Vistra Gluta  ="
        '
        'lblComshi
        '
        Me.lblComshi.AutoSize = True
        Me.lblComshi.Location = New System.Drawing.Point(25, 266)
        Me.lblComshi.Name = "lblComshi"
        Me.lblComshi.Size = New System.Drawing.Size(268, 22)
        Me.lblComshi.TabIndex = 8
        Me.lblComshi.Text = "Computer Toshiba Extra520x  ="
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCal.Location = New System.Drawing.Point(97, 407)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(75, 38)
        Me.btnCal.TabIndex = 9
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(214, 407)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 38)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblComtoshi
        '
        Me.lblComtoshi.AutoSize = True
        Me.lblComtoshi.Location = New System.Drawing.Point(25, 170)
        Me.lblComtoshi.Name = "lblComtoshi"
        Me.lblComtoshi.Size = New System.Drawing.Size(331, 22)
        Me.lblComtoshi.TabIndex = 11
        Me.lblComtoshi.Text = "ยอดขาย  Computer Toshiba Extra520x ="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(29, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 22)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "ผลลัพธ์รวม"
        '
        'lblSumsell
        '
        Me.lblSumsell.AutoSize = True
        Me.lblSumsell.Location = New System.Drawing.Point(29, 336)
        Me.lblSumsell.Name = "lblSumsell"
        Me.lblSumsell.Size = New System.Drawing.Size(147, 22)
        Me.lblSumsell.TabIndex = 13
        Me.lblSumsell.Text = "รวมยอดขายรวม   ="
        '
        'lblSumCom
        '
        Me.lblSumCom.AutoSize = True
        Me.lblSumCom.Location = New System.Drawing.Point(29, 364)
        Me.lblSumCom.Name = "lblSumCom"
        Me.lblSumCom.Size = New System.Drawing.Size(155, 22)
        Me.lblSumCom.TabIndex = 14
        Me.lblSumCom.Text = "รวมค่าคอมมิชชั่น   ="
        '
        'Frm_LAP2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 457)
        Me.Controls.Add(Me.lblSumCom)
        Me.Controls.Add(Me.lblSumsell)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblComtoshi)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblComshi)
        Me.Controls.Add(Me.lblComVis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblVistra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtComToshiba)
        Me.Controls.Add(Me.txtVista)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Frm_LAP2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "โปรแกรมคำนวณ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtVista As TextBox
    Friend WithEvents txtComToshiba As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVistra As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblComVis As Label
    Friend WithEvents lblComshi As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblComtoshi As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSumsell As Label
    Friend WithEvents lblSumCom As Label
End Class
