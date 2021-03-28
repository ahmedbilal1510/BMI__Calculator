<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStdWeightAns = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.btnCalculateStdWeight = New System.Windows.Forms.Button()
        Me.lblStdWeight = New System.Windows.Forms.Label()
        Me.lblHeightCm = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBMIAns = New System.Windows.Forms.Label()
        Me.btnCalculateBMI = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeightM = New System.Windows.Forms.TextBox()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeightM = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCalculateHeightM = New System.Windows.Forms.Button()
        Me.txtHeightCmC = New System.Windows.Forms.TextBox()
        Me.lblHeightMCAns = New System.Windows.Forms.Label()
        Me.lblHeightMC = New System.Windows.Forms.Label()
        Me.lblHeightCmC = New System.Windows.Forms.Label()
        Me.btnSelectCase = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStdWeightAns)
        Me.GroupBox1.Controls.Add(Me.txtHeight)
        Me.GroupBox1.Controls.Add(Me.btnCalculateStdWeight)
        Me.GroupBox1.Controls.Add(Me.lblStdWeight)
        Me.GroupBox1.Controls.Add(Me.lblHeightCm)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(139, 150)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox1.Size = New System.Drawing.Size(792, 384)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Standard Weight"
        '
        'lblStdWeightAns
        '
        Me.lblStdWeightAns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStdWeightAns.Location = New System.Drawing.Point(481, 191)
        Me.lblStdWeightAns.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblStdWeightAns.Name = "lblStdWeightAns"
        Me.lblStdWeightAns.Size = New System.Drawing.Size(269, 43)
        Me.lblStdWeightAns.TabIndex = 3
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeight.Location = New System.Drawing.Point(481, 74)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(270, 44)
        Me.txtHeight.TabIndex = 2
        '
        'btnCalculateStdWeight
        '
        Me.btnCalculateStdWeight.Location = New System.Drawing.Point(146, 293)
        Me.btnCalculateStdWeight.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnCalculateStdWeight.Name = "btnCalculateStdWeight"
        Me.btnCalculateStdWeight.Size = New System.Drawing.Size(475, 74)
        Me.btnCalculateStdWeight.TabIndex = 3
        Me.btnCalculateStdWeight.Text = "Calculate Standard Weight"
        Me.btnCalculateStdWeight.UseVisualStyleBackColor = True
        '
        'lblStdWeight
        '
        Me.lblStdWeight.AutoSize = True
        Me.lblStdWeight.Location = New System.Drawing.Point(92, 196)
        Me.lblStdWeight.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblStdWeight.Name = "lblStdWeight"
        Me.lblStdWeight.Size = New System.Drawing.Size(299, 37)
        Me.lblStdWeight.TabIndex = 1
        Me.lblStdWeight.Text = "Standard Weight (kg) :"
        '
        'lblHeightCm
        '
        Me.lblHeightCm.AutoSize = True
        Me.lblHeightCm.Location = New System.Drawing.Point(92, 83)
        Me.lblHeightCm.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblHeightCm.Name = "lblHeightCm"
        Me.lblHeightCm.Size = New System.Drawing.Size(178, 37)
        Me.lblHeightCm.TabIndex = 0
        Me.lblHeightCm.Text = "Height (cm) :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSelectCase)
        Me.GroupBox2.Controls.Add(Me.lblBMIAns)
        Me.GroupBox2.Controls.Add(Me.btnCalculateBMI)
        Me.GroupBox2.Controls.Add(Me.txtWeight)
        Me.GroupBox2.Controls.Add(Me.txtHeightM)
        Me.GroupBox2.Controls.Add(Me.lblBMI)
        Me.GroupBox2.Controls.Add(Me.lblWeight)
        Me.GroupBox2.Controls.Add(Me.lblHeightM)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(142, 1124)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox2.Size = New System.Drawing.Size(789, 490)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Body Mass Index (BMI)"
        '
        'lblBMIAns
        '
        Me.lblBMIAns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBMIAns.Location = New System.Drawing.Point(481, 310)
        Me.lblBMIAns.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblBMIAns.Name = "lblBMIAns"
        Me.lblBMIAns.Size = New System.Drawing.Size(269, 48)
        Me.lblBMIAns.TabIndex = 5
        '
        'btnCalculateBMI
        '
        Me.btnCalculateBMI.Location = New System.Drawing.Point(46, 401)
        Me.btnCalculateBMI.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnCalculateBMI.Name = "btnCalculateBMI"
        Me.btnCalculateBMI.Size = New System.Drawing.Size(288, 71)
        Me.btnCalculateBMI.TabIndex = 4
        Me.btnCalculateBMI.Text = "If...Then...Else"
        Me.btnCalculateBMI.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Location = New System.Drawing.Point(481, 191)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(270, 44)
        Me.txtWeight.TabIndex = 4
        '
        'txtHeightM
        '
        Me.txtHeightM.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeightM.Location = New System.Drawing.Point(481, 80)
        Me.txtHeightM.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.txtHeightM.Name = "txtHeightM"
        Me.txtHeightM.Size = New System.Drawing.Size(270, 44)
        Me.txtHeightM.TabIndex = 3
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(89, 322)
        Me.lblBMI.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(81, 37)
        Me.lblBMI.TabIndex = 2
        Me.lblBMI.Text = "BMI :"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(79, 199)
        Me.lblWeight.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(177, 37)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "Weight (kg) :"
        '
        'lblHeightM
        '
        Me.lblHeightM.AutoSize = True
        Me.lblHeightM.Location = New System.Drawing.Point(82, 94)
        Me.lblHeightM.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblHeightM.Name = "lblHeightM"
        Me.lblHeightM.Size = New System.Drawing.Size(163, 37)
        Me.lblHeightM.TabIndex = 0
        Me.lblHeightM.Text = "Height (m) :"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.Location = New System.Drawing.Point(276, 17)
        Me.lblSubTitle.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(496, 46)
        Me.lblSubTitle.TabIndex = 2
        Me.lblSubTitle.Text = "Standard Weight and BMI"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(432, 1619)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(184, 94)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCalculateHeightM)
        Me.GroupBox3.Controls.Add(Me.txtHeightCmC)
        Me.GroupBox3.Controls.Add(Me.lblHeightMCAns)
        Me.GroupBox3.Controls.Add(Me.lblHeightMC)
        Me.GroupBox3.Controls.Add(Me.lblHeightCmC)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(153, 625)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.GroupBox3.Size = New System.Drawing.Size(775, 310)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Convert cm to m"
        '
        'btnCalculateHeightM
        '
        Me.btnCalculateHeightM.Location = New System.Drawing.Point(209, 236)
        Me.btnCalculateHeightM.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.btnCalculateHeightM.Name = "btnCalculateHeightM"
        Me.btnCalculateHeightM.Size = New System.Drawing.Size(317, 57)
        Me.btnCalculateHeightM.TabIndex = 4
        Me.btnCalculateHeightM.Text = "Convert cm to m"
        Me.btnCalculateHeightM.UseVisualStyleBackColor = True
        '
        'txtHeightCmC
        '
        Me.txtHeightCmC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeightCmC.Location = New System.Drawing.Point(456, 77)
        Me.txtHeightCmC.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.txtHeightCmC.Name = "txtHeightCmC"
        Me.txtHeightCmC.Size = New System.Drawing.Size(270, 44)
        Me.txtHeightCmC.TabIndex = 3
        '
        'lblHeightMCAns
        '
        Me.lblHeightMCAns.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeightMCAns.Location = New System.Drawing.Point(456, 159)
        Me.lblHeightMCAns.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblHeightMCAns.Name = "lblHeightMCAns"
        Me.lblHeightMCAns.Size = New System.Drawing.Size(269, 46)
        Me.lblHeightMCAns.TabIndex = 2
        '
        'lblHeightMC
        '
        Me.lblHeightMC.AutoSize = True
        Me.lblHeightMC.Location = New System.Drawing.Point(111, 159)
        Me.lblHeightMC.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblHeightMC.Name = "lblHeightMC"
        Me.lblHeightMC.Size = New System.Drawing.Size(163, 37)
        Me.lblHeightMC.TabIndex = 1
        Me.lblHeightMC.Text = "Height (m) :"
        '
        'lblHeightCmC
        '
        Me.lblHeightCmC.AutoSize = True
        Me.lblHeightCmC.Location = New System.Drawing.Point(98, 77)
        Me.lblHeightCmC.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblHeightCmC.Name = "lblHeightCmC"
        Me.lblHeightCmC.Size = New System.Drawing.Size(178, 37)
        Me.lblHeightCmC.TabIndex = 0
        Me.lblHeightCmC.Text = "Height (cm) :"
        '
        'btnSelectCase
        '
        Me.btnSelectCase.Location = New System.Drawing.Point(489, 394)
        Me.btnSelectCase.Name = "btnSelectCase"
        Me.btnSelectCase.Size = New System.Drawing.Size(263, 78)
        Me.btnSelectCase.TabIndex = 6
        Me.btnSelectCase.Text = "Select Case"
        Me.btnSelectCase.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Wheat
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(984, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enter your Height in cm and press ""Calculate Standard Weight"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Wheat
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 579)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(827, 37)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Enter your Height in cm and press ""Convert cm to m"""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Wheat
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 1004)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(768, 111)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Enter your Height in m and Weight in kg and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "press If...Then...Enter or Select Ca" &
    "se to Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your BMI"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1097, 1731)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Name = "Form1"
        Me.Text = "Standard Weight and BMI Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblStdWeightAns As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblStdWeight As Label
    Friend WithEvents lblHeightCm As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblBMIAns As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeightM As TextBox
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeightM As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents btnCalculateStdWeight As Button
    Friend WithEvents btnCalculateBMI As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCalculateHeightM As Button
    Friend WithEvents txtHeightCmC As TextBox
    Friend WithEvents lblHeightMCAns As Label
    Friend WithEvents lblHeightMC As Label
    Friend WithEvents lblHeightCmC As Label
    Friend WithEvents btnSelectCase As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
