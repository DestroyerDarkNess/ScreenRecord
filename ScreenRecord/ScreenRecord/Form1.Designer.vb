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
        Me.cb_screenSelector = New System.Windows.Forms.ComboBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lb_stopWatch = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tb_SaveFolder = New System.Windows.Forms.TextBox()
        Me.nud_FPS = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cb_BitRate = New System.Windows.Forms.ComboBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cb_VideoCodec = New System.Windows.Forms.ComboBox()
        Me.lb_1 = New System.Windows.Forms.Label()
        Me.bt_Save = New System.Windows.Forms.Button()
        Me.bt_start = New System.Windows.Forms.Button()
        CType(Me.nud_FPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_screenSelector
        '
        Me.cb_screenSelector.FormattingEnabled = True
        Me.cb_screenSelector.Location = New System.Drawing.Point(79, 36)
        Me.cb_screenSelector.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_screenSelector.Name = "cb_screenSelector"
        Me.cb_screenSelector.Size = New System.Drawing.Size(102, 21)
        Me.cb_screenSelector.TabIndex = 29
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(30, 39)
        Me.label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(49, 13)
        Me.label5.TabIndex = 28
        Me.label5.Text = "Screens:"
        '
        'lb_stopWatch
        '
        Me.lb_stopWatch.AutoSize = True
        Me.lb_stopWatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lb_stopWatch.Location = New System.Drawing.Point(63, 59)
        Me.lb_stopWatch.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_stopWatch.Name = "lb_stopWatch"
        Me.lb_stopWatch.Size = New System.Drawing.Size(202, 26)
        Me.lb_stopWatch.TabIndex = 27
        Me.lb_stopWatch.Text = "00:00:00.0000000"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(10, 86)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(75, 13)
        Me.label4.TabIndex = 26
        Me.label4.Text = "Save in folder:"
        '
        'tb_SaveFolder
        '
        Me.tb_SaveFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_SaveFolder.Location = New System.Drawing.Point(12, 103)
        Me.tb_SaveFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_SaveFolder.Name = "tb_SaveFolder"
        Me.tb_SaveFolder.Size = New System.Drawing.Size(295, 20)
        Me.tb_SaveFolder.TabIndex = 25
        '
        'nud_FPS
        '
        Me.nud_FPS.Location = New System.Drawing.Point(230, 35)
        Me.nud_FPS.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_FPS.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nud_FPS.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nud_FPS.Name = "nud_FPS"
        Me.nud_FPS.Size = New System.Drawing.Size(75, 20)
        Me.nud_FPS.TabIndex = 24
        Me.nud_FPS.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(199, 37)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(30, 13)
        Me.label3.TabIndex = 23
        Me.label3.Text = "FPS:"
        '
        'cb_BitRate
        '
        Me.cb_BitRate.FormattingEnabled = True
        Me.cb_BitRate.Location = New System.Drawing.Point(230, 11)
        Me.cb_BitRate.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_BitRate.Name = "cb_BitRate"
        Me.cb_BitRate.Size = New System.Drawing.Size(76, 21)
        Me.cb_BitRate.TabIndex = 22
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(185, 13)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 13)
        Me.label2.TabIndex = 21
        Me.label2.Text = "BitRate:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 13)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(68, 13)
        Me.label1.TabIndex = 20
        Me.label1.Text = "VideoCodec:"
        '
        'cb_VideoCodec
        '
        Me.cb_VideoCodec.FormattingEnabled = True
        Me.cb_VideoCodec.Location = New System.Drawing.Point(79, 11)
        Me.cb_VideoCodec.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_VideoCodec.Name = "cb_VideoCodec"
        Me.cb_VideoCodec.Size = New System.Drawing.Size(102, 21)
        Me.cb_VideoCodec.TabIndex = 19
        '
        'lb_1
        '
        Me.lb_1.AutoSize = True
        Me.lb_1.Location = New System.Drawing.Point(10, 130)
        Me.lb_1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_1.Name = "lb_1"
        Me.lb_1.Size = New System.Drawing.Size(47, 13)
        Me.lb_1.TabIndex = 18
        Me.lb_1.Text = "Frames: "
        '
        'bt_Save
        '
        Me.bt_Save.Location = New System.Drawing.Point(187, 125)
        Me.bt_Save.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(56, 34)
        Me.bt_Save.TabIndex = 17
        Me.bt_Save.Text = "Stop"
        Me.bt_Save.UseVisualStyleBackColor = True
        '
        'bt_start
        '
        Me.bt_start.Location = New System.Drawing.Point(250, 125)
        Me.bt_start.Margin = New System.Windows.Forms.Padding(2)
        Me.bt_start.Name = "bt_start"
        Me.bt_start.Size = New System.Drawing.Size(56, 34)
        Me.bt_start.TabIndex = 16
        Me.bt_start.Text = "Start"
        Me.bt_start.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(331, 165)
        Me.Controls.Add(Me.cb_screenSelector)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.lb_stopWatch)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.tb_SaveFolder)
        Me.Controls.Add(Me.nud_FPS)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.cb_BitRate)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cb_VideoCodec)
        Me.Controls.Add(Me.lb_1)
        Me.Controls.Add(Me.bt_Save)
        Me.Controls.Add(Me.bt_start)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.nud_FPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cb_screenSelector As System.Windows.Forms.ComboBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents lb_stopWatch As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents tb_SaveFolder As System.Windows.Forms.TextBox
    Private WithEvents nud_FPS As System.Windows.Forms.NumericUpDown
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents cb_BitRate As System.Windows.Forms.ComboBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cb_VideoCodec As System.Windows.Forms.ComboBox
    Private WithEvents lb_1 As System.Windows.Forms.Label
    Private WithEvents bt_Save As System.Windows.Forms.Button
    Private WithEvents bt_start As System.Windows.Forms.Button

End Class
