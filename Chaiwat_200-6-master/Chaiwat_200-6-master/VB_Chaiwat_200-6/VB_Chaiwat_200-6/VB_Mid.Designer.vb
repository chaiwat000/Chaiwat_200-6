<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VB_Mid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radMoter = New System.Windows.Forms.RadioButton()
        Me.radBigcar = New System.Windows.Forms.RadioButton()
        Me.radSmallcar = New System.Windows.Forms.RadioButton()
        Me.radSUV = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCar = New System.Windows.Forms.Label()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.radOnetour = New System.Windows.Forms.RadioButton()
        Me.radTwotour = New System.Windows.Forms.RadioButton()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(790, 83)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "สอบปฏิบัติกลางภาค 2/2561"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Aqua
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(790, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "โปรแกรมคำนวณค่าเดินทาง"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(64, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ประเภทรถ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radMoter
        '
        Me.radMoter.AutoSize = True
        Me.radMoter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radMoter.Location = New System.Drawing.Point(6, 21)
        Me.radMoter.Name = "radMoter"
        Me.radMoter.Size = New System.Drawing.Size(148, 24)
        Me.radMoter.TabIndex = 3
        Me.radMoter.TabStop = True
        Me.radMoter.Text = "รถจักรยานยนต์ "
        Me.radMoter.UseVisualStyleBackColor = True
        '
        'radBigcar
        '
        Me.radBigcar.AutoSize = True
        Me.radBigcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radBigcar.Location = New System.Drawing.Point(6, 49)
        Me.radBigcar.Name = "radBigcar"
        Me.radBigcar.Size = New System.Drawing.Size(99, 24)
        Me.radBigcar.TabIndex = 4
        Me.radBigcar.TabStop = True
        Me.radBigcar.Text = "รถกระบะ"
        Me.radBigcar.UseVisualStyleBackColor = True
        '
        'radSmallcar
        '
        Me.radSmallcar.AutoSize = True
        Me.radSmallcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radSmallcar.Location = New System.Drawing.Point(6, 77)
        Me.radSmallcar.Name = "radSmallcar"
        Me.radSmallcar.Size = New System.Drawing.Size(77, 24)
        Me.radSmallcar.TabIndex = 5
        Me.radSmallcar.TabStop = True
        Me.radSmallcar.Text = "รถเก๋ง"
        Me.radSmallcar.UseVisualStyleBackColor = True
        '
        'radSUV
        '
        Me.radSUV.AutoSize = True
        Me.radSUV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radSUV.Location = New System.Drawing.Point(6, 105)
        Me.radSUV.Name = "radSUV"
        Me.radSUV.Size = New System.Drawing.Size(93, 24)
        Me.radSUV.TabIndex = 6
        Me.radSUV.TabStop = True
        Me.radSUV.Text = "รถ SUV"
        Me.radSUV.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMoter)
        Me.GroupBox1.Controls.Add(Me.radSUV)
        Me.GroupBox1.Controls.Add(Me.radBigcar)
        Me.GroupBox1.Controls.Add(Me.radSmallcar)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 141)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(258, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 37)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "อัตราค่าบริการ : กิโลเมตร"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(283, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 53)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ระบุรถและระยะทางที่ต้องการเดินทาง"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCar
        '
        Me.lblCar.BackColor = System.Drawing.Color.Pink
        Me.lblCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCar.Location = New System.Drawing.Point(356, 472)
        Me.lblCar.Name = "lblCar"
        Me.lblCar.Size = New System.Drawing.Size(258, 53)
        Me.lblCar.TabIndex = 10
        Me.lblCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDistance
        '
        Me.txtDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDistance.Location = New System.Drawing.Point(356, 539)
        Me.txtDistance.Multiline = True
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(258, 49)
        Me.txtDistance.TabIndex = 11
        Me.txtDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.HotPink
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(207, 472)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 53)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "ประเภทรถที่เลือก"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(207, 539)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 49)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ระยะทาง"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(541, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 37)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "ประเภทของการเดินทาง"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radOnetour
        '
        Me.radOnetour.AutoSize = True
        Me.radOnetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radOnetour.Location = New System.Drawing.Point(550, 233)
        Me.radOnetour.Name = "radOnetour"
        Me.radOnetour.Size = New System.Drawing.Size(146, 24)
        Me.radOnetour.TabIndex = 15
        Me.radOnetour.TabStop = True
        Me.radOnetour.Text = "เดินทางขาเดียว"
        Me.radOnetour.UseVisualStyleBackColor = True
        '
        'radTwotour
        '
        Me.radTwotour.AutoSize = True
        Me.radTwotour.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.radTwotour.Location = New System.Drawing.Point(550, 263)
        Me.radTwotour.Name = "radTwotour"
        Me.radTwotour.Size = New System.Drawing.Size(160, 24)
        Me.radTwotour.TabIndex = 16
        Me.radTwotour.TabStop = True
        Me.radTwotour.Text = "เดินทางไป - กลับ"
        Me.radTwotour.UseVisualStyleBackColor = True
        '
        'lblDistance
        '
        Me.lblDistance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDistance.Location = New System.Drawing.Point(299, 682)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(126, 53)
        Me.lblDistance.TabIndex = 17
        Me.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblService
        '
        Me.lblService.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblService.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblService.Location = New System.Drawing.Point(299, 753)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(126, 53)
        Me.lblService.TabIndex = 19
        Me.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOption
        '
        Me.lblOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOption.Location = New System.Drawing.Point(299, 818)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(126, 53)
        Me.lblOption.TabIndex = 21
        Me.lblOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCal
        '
        Me.btnCal.BackColor = System.Drawing.Color.Lime
        Me.btnCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCal.Location = New System.Drawing.Point(621, 753)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(129, 71)
        Me.btnCal.TabIndex = 23
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(621, 846)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 71)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "ปิด"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(113, 701)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "ระยะทางเดินทาง"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(113, 765)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 20)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "อัตรค่าบริการ : กม."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(113, 830)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 20)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "ค่ารอคอย"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(453, 701)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 20)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "กิโลเมตร"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(453, 765)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 20)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "บาท"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(453, 830)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 20)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "บาท"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(453, 897)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 20)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "บาท"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(113, 897)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 20)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "ชำระ"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(299, 885)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(126, 53)
        Me.lblTotal.TabIndex = 31
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(279, 221)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(164, 20)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "รถจักรยายนต์ 2 บาท"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(279, 312)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(126, 20)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "รถ SUV 8 บาท"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label24.Location = New System.Drawing.Point(279, 281)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 20)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "รถเก๋ง 6 บาท"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(279, 250)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(132, 20)
        Me.Label25.TabIndex = 37
        Me.Label25.Text = "รถกระบะ 4 บาท"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 625)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "บาท"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(113, 625)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "ค่าแรกเริ่ม"
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblStart.Location = New System.Drawing.Point(299, 613)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(126, 53)
        Me.lblStart.TabIndex = 38
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VB_Mid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 946)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblOption)
        Me.Controls.Add(Me.lblService)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.radTwotour)
        Me.Controls.Add(Me.radOnetour)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.lblCar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VB_Mid"
        Me.ShowInTaskbar = False
        Me.Text = "VB_Mid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents radMoter As RadioButton
    Friend WithEvents radBigcar As RadioButton
    Friend WithEvents radSmallcar As RadioButton
    Friend WithEvents radSUV As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCar As Label
    Friend WithEvents txtDistance As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents radOnetour As RadioButton
    Friend WithEvents radTwotour As RadioButton
    Friend WithEvents lblDistance As Label
    Friend WithEvents lblService As Label
    Friend WithEvents lblOption As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblStart As Label
End Class
