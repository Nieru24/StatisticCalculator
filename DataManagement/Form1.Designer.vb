<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtBox_dataInput = New System.Windows.Forms.TextBox()
        Me.lbl_dataSet = New System.Windows.Forms.Label()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_Undo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.debugBtn = New System.Windows.Forms.Button()
        Me.lbl_ungrpCalcs = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_ungrpCalcs = New System.Windows.Forms.Button()
        Me.txtBox_input_classInterval = New System.Windows.Forms.TextBox()
        Me.btn_grpCalcs = New System.Windows.Forms.Button()
        Me.grpBox_classInterval = New System.Windows.Forms.GroupBox()
        Me.radBtn_classInterval = New System.Windows.Forms.RadioButton()
        Me.lbl_LL = New System.Windows.Forms.Label()
        Me.lbl_LU = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_LB = New System.Windows.Forms.Label()
        Me.lbl_UB = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_classMark = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.grpBox_classSize = New System.Windows.Forms.GroupBox()
        Me.radBtn_classSize = New System.Windows.Forms.RadioButton()
        Me.txtBox_input_classSize = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_frequency = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_gtCFrequency = New System.Windows.Forms.Label()
        Me.lbl_ltCFrequency = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_gtCPFrequency = New System.Windows.Forms.Label()
        Me.lbl_ltCPFrequency = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_RelativeFrequency = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.lbl_groupedDataCalcs = New System.Windows.Forms.Label()
        Me.tmr_checker = New System.Windows.Forms.Timer(Me.components)
        Me.txtBox_percentileInput = New System.Windows.Forms.TextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.btn_percentileCalc = New System.Windows.Forms.Button()
        Me.lbl_percentileOutput = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpBox_classInterval.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.grpBox_classSize.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBox_dataInput
        '
        Me.txtBox_dataInput.Location = New System.Drawing.Point(37, 24)
        Me.txtBox_dataInput.Name = "txtBox_dataInput"
        Me.txtBox_dataInput.Size = New System.Drawing.Size(46, 20)
        Me.txtBox_dataInput.TabIndex = 0
        '
        'lbl_dataSet
        '
        Me.lbl_dataSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_dataSet.Location = New System.Drawing.Point(129, 16)
        Me.lbl_dataSet.Name = "lbl_dataSet"
        Me.lbl_dataSet.Size = New System.Drawing.Size(221, 80)
        Me.lbl_dataSet.TabIndex = 1
        '
        'btn_submit
        '
        Me.btn_submit.Location = New System.Drawing.Point(23, 50)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 23)
        Me.btn_submit.TabIndex = 2
        Me.btn_submit.Text = "Click Me!"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'btn_Undo
        '
        Me.btn_Undo.Location = New System.Drawing.Point(366, 59)
        Me.btn_Undo.Name = "btn_Undo"
        Me.btn_Undo.Size = New System.Drawing.Size(75, 23)
        Me.btn_Undo.TabIndex = 3
        Me.btn_Undo.Text = "Undo"
        Me.btn_Undo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_dataSet)
        Me.GroupBox1.Controls.Add(Me.btn_Clear)
        Me.GroupBox1.Controls.Add(Me.btn_Undo)
        Me.GroupBox1.Controls.Add(Me.txtBox_dataInput)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_submit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 110)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data"
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(366, 31)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 3
        Me.btn_Clear.Text = "Clear!"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Sample Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'debugBtn
        '
        Me.debugBtn.Location = New System.Drawing.Point(855, 617)
        Me.debugBtn.Name = "debugBtn"
        Me.debugBtn.Size = New System.Drawing.Size(116, 23)
        Me.debugBtn.TabIndex = 5
        Me.debugBtn.Text = "Debug Button"
        Me.debugBtn.UseVisualStyleBackColor = True
        '
        'lbl_ungrpCalcs
        '
        Me.lbl_ungrpCalcs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ungrpCalcs.Location = New System.Drawing.Point(21, 25)
        Me.lbl_ungrpCalcs.Name = "lbl_ungrpCalcs"
        Me.lbl_ungrpCalcs.Size = New System.Drawing.Size(291, 85)
        Me.lbl_ungrpCalcs.TabIndex = 6
        Me.lbl_ungrpCalcs.Text = "Range: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mean: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Median: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mode: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sample Size (n): "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_ungrpCalcs)
        Me.GroupBox2.Controls.Add(Me.lbl_ungrpCalcs)
        Me.GroupBox2.Location = New System.Drawing.Point(505, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 146)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ungrouped Data Calculation"
        '
        'btn_ungrpCalcs
        '
        Me.btn_ungrpCalcs.Location = New System.Drawing.Point(130, 117)
        Me.btn_ungrpCalcs.Name = "btn_ungrpCalcs"
        Me.btn_ungrpCalcs.Size = New System.Drawing.Size(75, 23)
        Me.btn_ungrpCalcs.TabIndex = 21
        Me.btn_ungrpCalcs.Text = "Calculate!"
        Me.btn_ungrpCalcs.UseVisualStyleBackColor = True
        '
        'txtBox_input_classInterval
        '
        Me.txtBox_input_classInterval.Location = New System.Drawing.Point(6, 19)
        Me.txtBox_input_classInterval.Name = "txtBox_input_classInterval"
        Me.txtBox_input_classInterval.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_input_classInterval.TabIndex = 10
        '
        'btn_grpCalcs
        '
        Me.btn_grpCalcs.Location = New System.Drawing.Point(353, 622)
        Me.btn_grpCalcs.Name = "btn_grpCalcs"
        Me.btn_grpCalcs.Size = New System.Drawing.Size(75, 23)
        Me.btn_grpCalcs.TabIndex = 11
        Me.btn_grpCalcs.Text = "Calculate!"
        Me.btn_grpCalcs.UseVisualStyleBackColor = True
        '
        'grpBox_classInterval
        '
        Me.grpBox_classInterval.Controls.Add(Me.radBtn_classInterval)
        Me.grpBox_classInterval.Controls.Add(Me.txtBox_input_classInterval)
        Me.grpBox_classInterval.Location = New System.Drawing.Point(6, 37)
        Me.grpBox_classInterval.Name = "grpBox_classInterval"
        Me.grpBox_classInterval.Size = New System.Drawing.Size(157, 50)
        Me.grpBox_classInterval.TabIndex = 12
        Me.grpBox_classInterval.TabStop = False
        Me.grpBox_classInterval.Text = "How many class interval?"
        '
        'radBtn_classInterval
        '
        Me.radBtn_classInterval.AutoSize = True
        Me.radBtn_classInterval.Location = New System.Drawing.Point(116, 22)
        Me.radBtn_classInterval.Name = "radBtn_classInterval"
        Me.radBtn_classInterval.Size = New System.Drawing.Size(14, 13)
        Me.radBtn_classInterval.TabIndex = 11
        Me.radBtn_classInterval.TabStop = True
        Me.radBtn_classInterval.UseVisualStyleBackColor = True
        '
        'lbl_LL
        '
        Me.lbl_LL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_LL.Location = New System.Drawing.Point(6, 57)
        Me.lbl_LL.Name = "lbl_LL"
        Me.lbl_LL.Size = New System.Drawing.Size(46, 266)
        Me.lbl_LL.TabIndex = 13
        Me.lbl_LL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_LU
        '
        Me.lbl_LU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_LU.Location = New System.Drawing.Point(58, 57)
        Me.lbl_LU.Name = "lbl_LU"
        Me.lbl_LU.Size = New System.Drawing.Size(46, 266)
        Me.lbl_LU.TabIndex = 13
        Me.lbl_LU.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.lbl_LL)
        Me.GroupBox4.Controls.Add(Me.lbl_LU)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 266)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(110, 336)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Class Interval"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "LU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "LL"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.lbl_LB)
        Me.GroupBox5.Controls.Add(Me.lbl_UB)
        Me.GroupBox5.Location = New System.Drawing.Point(128, 266)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(110, 336)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Class Boundaries"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "UB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "LB"
        '
        'lbl_LB
        '
        Me.lbl_LB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_LB.Location = New System.Drawing.Point(6, 57)
        Me.lbl_LB.Name = "lbl_LB"
        Me.lbl_LB.Size = New System.Drawing.Size(46, 266)
        Me.lbl_LB.TabIndex = 13
        Me.lbl_LB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_UB
        '
        Me.lbl_UB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_UB.Location = New System.Drawing.Point(58, 57)
        Me.lbl_UB.Name = "lbl_UB"
        Me.lbl_UB.Size = New System.Drawing.Size(46, 266)
        Me.lbl_UB.TabIndex = 13
        Me.lbl_UB.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.lbl_classMark)
        Me.GroupBox6.Location = New System.Drawing.Point(244, 266)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(92, 336)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Class Marks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(9, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "i"
        '
        'lbl_classMark
        '
        Me.lbl_classMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_classMark.Location = New System.Drawing.Point(23, 57)
        Me.lbl_classMark.Name = "lbl_classMark"
        Me.lbl_classMark.Size = New System.Drawing.Size(46, 266)
        Me.lbl_classMark.TabIndex = 13
        Me.lbl_classMark.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.grpBox_classSize)
        Me.GroupBox8.Controls.Add(Me.grpBox_classInterval)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 149)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(350, 111)
        Me.GroupBox8.TabIndex = 18
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Setting"
        '
        'grpBox_classSize
        '
        Me.grpBox_classSize.Controls.Add(Me.radBtn_classSize)
        Me.grpBox_classSize.Controls.Add(Me.txtBox_input_classSize)
        Me.grpBox_classSize.Location = New System.Drawing.Point(174, 37)
        Me.grpBox_classSize.Name = "grpBox_classSize"
        Me.grpBox_classSize.Size = New System.Drawing.Size(157, 50)
        Me.grpBox_classSize.TabIndex = 19
        Me.grpBox_classSize.TabStop = False
        Me.grpBox_classSize.Text = "How many class size?"
        '
        'radBtn_classSize
        '
        Me.radBtn_classSize.AutoSize = True
        Me.radBtn_classSize.Location = New System.Drawing.Point(116, 22)
        Me.radBtn_classSize.Name = "radBtn_classSize"
        Me.radBtn_classSize.Size = New System.Drawing.Size(14, 13)
        Me.radBtn_classSize.TabIndex = 11
        Me.radBtn_classSize.TabStop = True
        Me.radBtn_classSize.UseVisualStyleBackColor = True
        '
        'txtBox_input_classSize
        '
        Me.txtBox_input_classSize.Location = New System.Drawing.Point(6, 19)
        Me.txtBox_input_classSize.Name = "txtBox_input_classSize"
        Me.txtBox_input_classSize.Size = New System.Drawing.Size(100, 20)
        Me.txtBox_input_classSize.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lbl_frequency)
        Me.GroupBox3.Location = New System.Drawing.Point(342, 266)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(92, 336)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Frequency"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "f"
        '
        'lbl_frequency
        '
        Me.lbl_frequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_frequency.Location = New System.Drawing.Point(23, 57)
        Me.lbl_frequency.Name = "lbl_frequency"
        Me.lbl_frequency.Size = New System.Drawing.Size(46, 266)
        Me.lbl_frequency.TabIndex = 13
        Me.lbl_frequency.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.lbl_gtCFrequency)
        Me.GroupBox7.Controls.Add(Me.lbl_ltCFrequency)
        Me.GroupBox7.Location = New System.Drawing.Point(440, 266)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(110, 336)
        Me.GroupBox7.TabIndex = 20
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Cumulative Frequency"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(71, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "<cf"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = ">cf"
        '
        'lbl_gtCFrequency
        '
        Me.lbl_gtCFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_gtCFrequency.Location = New System.Drawing.Point(6, 57)
        Me.lbl_gtCFrequency.Name = "lbl_gtCFrequency"
        Me.lbl_gtCFrequency.Size = New System.Drawing.Size(46, 266)
        Me.lbl_gtCFrequency.TabIndex = 13
        Me.lbl_gtCFrequency.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_ltCFrequency
        '
        Me.lbl_ltCFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ltCFrequency.Location = New System.Drawing.Point(58, 57)
        Me.lbl_ltCFrequency.Name = "lbl_ltCFrequency"
        Me.lbl_ltCFrequency.Size = New System.Drawing.Size(46, 266)
        Me.lbl_ltCFrequency.TabIndex = 13
        Me.lbl_ltCFrequency.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.lbl_gtCPFrequency)
        Me.GroupBox9.Controls.Add(Me.lbl_ltCPFrequency)
        Me.GroupBox9.Location = New System.Drawing.Point(556, 266)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(110, 336)
        Me.GroupBox9.TabIndex = 20
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Cumulative % Frequency"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "<cpf"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = ">cpf"
        '
        'lbl_gtCPFrequency
        '
        Me.lbl_gtCPFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_gtCPFrequency.Location = New System.Drawing.Point(6, 57)
        Me.lbl_gtCPFrequency.Name = "lbl_gtCPFrequency"
        Me.lbl_gtCPFrequency.Size = New System.Drawing.Size(46, 266)
        Me.lbl_gtCPFrequency.TabIndex = 13
        Me.lbl_gtCPFrequency.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_ltCPFrequency
        '
        Me.lbl_ltCPFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ltCPFrequency.Location = New System.Drawing.Point(58, 57)
        Me.lbl_ltCPFrequency.Name = "lbl_ltCPFrequency"
        Me.lbl_ltCPFrequency.Size = New System.Drawing.Size(46, 266)
        Me.lbl_ltCPFrequency.TabIndex = 13
        Me.lbl_ltCPFrequency.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label11)
        Me.GroupBox10.Controls.Add(Me.lbl_RelativeFrequency)
        Me.GroupBox10.Location = New System.Drawing.Point(672, 266)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(92, 336)
        Me.GroupBox10.TabIndex = 19
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Relative Frequency"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "(RF) %"
        '
        'lbl_RelativeFrequency
        '
        Me.lbl_RelativeFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_RelativeFrequency.Location = New System.Drawing.Point(23, 57)
        Me.lbl_RelativeFrequency.Name = "lbl_RelativeFrequency"
        Me.lbl_RelativeFrequency.Size = New System.Drawing.Size(46, 266)
        Me.lbl_RelativeFrequency.TabIndex = 13
        Me.lbl_RelativeFrequency.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.lbl_groupedDataCalcs)
        Me.GroupBox11.Location = New System.Drawing.Point(381, 174)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(198, 86)
        Me.GroupBox11.TabIndex = 8
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Grouped Data Calculation"
        '
        'lbl_groupedDataCalcs
        '
        Me.lbl_groupedDataCalcs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_groupedDataCalcs.Location = New System.Drawing.Point(21, 25)
        Me.lbl_groupedDataCalcs.Name = "lbl_groupedDataCalcs"
        Me.lbl_groupedDataCalcs.Size = New System.Drawing.Size(166, 49)
        Me.lbl_groupedDataCalcs.TabIndex = 6
        Me.lbl_groupedDataCalcs.Text = "Mean: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Median: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mode: "
        '
        'tmr_checker
        '
        Me.tmr_checker.Enabled = True
        '
        'txtBox_percentileInput
        '
        Me.txtBox_percentileInput.Location = New System.Drawing.Point(42, 19)
        Me.txtBox_percentileInput.Name = "txtBox_percentileInput"
        Me.txtBox_percentileInput.Size = New System.Drawing.Size(72, 20)
        Me.txtBox_percentileInput.TabIndex = 21
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.btn_percentileCalc)
        Me.GroupBox12.Controls.Add(Me.lbl_percentileOutput)
        Me.GroupBox12.Controls.Add(Me.Label12)
        Me.GroupBox12.Controls.Add(Me.txtBox_percentileInput)
        Me.GroupBox12.Location = New System.Drawing.Point(599, 174)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(237, 86)
        Me.GroupBox12.TabIndex = 22
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Percentiles"
        '
        'btn_percentileCalc
        '
        Me.btn_percentileCalc.Location = New System.Drawing.Point(131, 36)
        Me.btn_percentileCalc.Name = "btn_percentileCalc"
        Me.btn_percentileCalc.Size = New System.Drawing.Size(75, 23)
        Me.btn_percentileCalc.TabIndex = 24
        Me.btn_percentileCalc.Text = "Calculate!"
        Me.btn_percentileCalc.UseVisualStyleBackColor = True
        '
        'lbl_percentileOutput
        '
        Me.lbl_percentileOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_percentileOutput.Location = New System.Drawing.Point(42, 52)
        Me.lbl_percentileOutput.Name = "lbl_percentileOutput"
        Me.lbl_percentileOutput.Size = New System.Drawing.Size(69, 19)
        Me.lbl_percentileOutput.TabIndex = 23
        Me.lbl_percentileOutput.Text = "= "
        Me.lbl_percentileOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "i:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 652)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_grpCalcs)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.debugBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Data Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.grpBox_classInterval.ResumeLayout(False)
        Me.grpBox_classInterval.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.grpBox_classSize.ResumeLayout(False)
        Me.grpBox_classSize.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtBox_dataInput As TextBox
    Friend WithEvents lbl_dataSet As Label
    Friend WithEvents btn_submit As Button
    Friend WithEvents btn_Undo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents debugBtn As Button
    Friend WithEvents lbl_ungrpCalcs As Label
    Friend WithEvents btn_Clear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBox_input_classInterval As TextBox
    Friend WithEvents btn_grpCalcs As Button
    Friend WithEvents grpBox_classInterval As GroupBox
    Friend WithEvents lbl_LL As Label
    Friend WithEvents lbl_LU As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_LB As Label
    Friend WithEvents lbl_UB As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lbl_classMark As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents radBtn_classInterval As RadioButton
    Friend WithEvents grpBox_classSize As GroupBox
    Friend WithEvents radBtn_classSize As RadioButton
    Friend WithEvents txtBox_input_classSize As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_frequency As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_gtCFrequency As Label
    Friend WithEvents lbl_ltCFrequency As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_gtCPFrequency As Label
    Friend WithEvents lbl_ltCPFrequency As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_RelativeFrequency As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents lbl_groupedDataCalcs As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tmr_checker As Timer
    Friend WithEvents btn_ungrpCalcs As Button
    Friend WithEvents txtBox_percentileInput As TextBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_percentileOutput As Label
    Friend WithEvents btn_percentileCalc As Button
End Class
