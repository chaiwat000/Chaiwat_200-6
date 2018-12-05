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
        Me.txtFrista = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVistra = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblComVis = New System.Windows.Forms.Label()
        Me.lblComFris = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblFrista = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSumVisAndFris = New System.Windows.Forms.Label()
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
        Me.Label1.Size = New System.Drawing.Size(399, 36)
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
        'txtFrista
        '
        Me.txtFrista.Location = New System.Drawing.Point(214, 89)
        Me.txtFrista.Name = "txtFrista"
        Me.txtFrista.Size = New System.Drawing.Size(100, 28)
        Me.txtFrista.TabIndex = 2
        Me.txtFrista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Label3.Location = New System.Drawing.Point(69, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Frista Gluta    ="
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
        'lblComFris
        '
        Me.lblComFris.AutoSize = True
        Me.lblComFris.Location = New System.Drawing.Point(25, 266)
        Me.lblComFris.Name = "lblComFris"
        Me.lblComFris.Size = New System.Drawing.Size(125, 22)
        Me.lblComFris.TabIndex = 8
        Me.lblComFris.Text = "Frista Gluta  ="
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
        'lblFrista
        '
        Me.lblFrista.AutoSize = True
        Me.lblFrista.Location = New System.Drawing.Point(25, 170)
        Me.lblFrista.Name = "lblFrista"
        Me.lblFrista.Size = New System.Drawing.Size(193, 22)
        Me.lblFrista.TabIndex = 11
        Me.lblFrista.Text = "ยอดขาย  Frista Gluta  ="
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
        'lblSumVisAndFris
        '
        Me.lblSumVisAndFris.AutoSize = True
        Me.lblSumVisAndFris.Location = New System.Drawing.Point(29, 336)
        Me.lblSumVisAndFris.Name = "lblSumVisAndFris"
        Me.lblSumVisAndFris.Size = New System.Drawing.Size(254, 22)
        Me.lblSumVisAndFris.TabIndex = 13
        Me.lblSumVisAndFris.Text = "รวมยอดขาย Vistra และ Frista   ="
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
        Me.ClientSize = New System.Drawing.Size(399, 457)
        Me.Controls.Add(Me.lblSumCom)
        Me.Controls.Add(Me.lblSumVisAndFris)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblFrista)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblComFris)
        Me.Controls.Add(Me.lblComVis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblVistra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFrista)
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
    Friend WithEvents txtFrista As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVistra As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblComVis As Label
    Friend WithEvents lblComFris As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblFrista As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSumVisAndFris As Label
    Friend WithEvents lblSumCom As Label
End Class
