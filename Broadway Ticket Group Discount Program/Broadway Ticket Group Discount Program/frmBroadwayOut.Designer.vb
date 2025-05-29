<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadwayTicket
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
        Me.lblBroadway = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.grpnamesize = New System.Windows.Forms.GroupBox()
        Me.Radio4 = New System.Windows.Forms.RadioButton()
        Me.Radio3 = New System.Windows.Forms.RadioButton()
        Me.Radio2 = New System.Windows.Forms.RadioButton()
        Me.Radio1 = New System.Windows.Forms.RadioButton()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDisplaytotal = New System.Windows.Forms.Label()
        Me.PicBroadway = New System.Windows.Forms.PictureBox()
        Me.grpnamesize.SuspendLayout()
        CType(Me.PicBroadway, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBroadway
        '
        Me.lblBroadway.AutoSize = True
        Me.lblBroadway.Location = New System.Drawing.Point(175, 12)
        Me.lblBroadway.Name = "lblBroadway"
        Me.lblBroadway.Size = New System.Drawing.Size(174, 20)
        Me.lblBroadway.TabIndex = 0
        Me.lblBroadway.Text = "Broadway Ticket Group"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(23, 81)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(207, 20)
        Me.lblNumber.TabIndex = 1
        Me.lblNumber.Text = "Enter the Size of the people"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(304, 78)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 26)
        Me.txtNumber.TabIndex = 2
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpnamesize
        '
        Me.grpnamesize.Controls.Add(Me.Radio4)
        Me.grpnamesize.Controls.Add(Me.Radio3)
        Me.grpnamesize.Controls.Add(Me.Radio2)
        Me.grpnamesize.Controls.Add(Me.Radio1)
        Me.grpnamesize.Location = New System.Drawing.Point(30, 124)
        Me.grpnamesize.Name = "grpnamesize"
        Me.grpnamesize.Size = New System.Drawing.Size(200, 159)
        Me.grpnamesize.TabIndex = 3
        Me.grpnamesize.TabStop = False
        Me.grpnamesize.Text = "Group Size"
        '
        'Radio4
        '
        Me.Radio4.AutoSize = True
        Me.Radio4.Location = New System.Drawing.Point(6, 117)
        Me.Radio4.Name = "Radio4"
        Me.Radio4.Size = New System.Drawing.Size(110, 24)
        Me.Radio4.TabIndex = 3
        Me.Radio4.TabStop = True
        Me.Radio4.Text = "Size 25-99"
        Me.Radio4.UseVisualStyleBackColor = True
        '
        'Radio3
        '
        Me.Radio3.AutoSize = True
        Me.Radio3.Location = New System.Drawing.Point(6, 87)
        Me.Radio3.Name = "Radio3"
        Me.Radio3.Size = New System.Drawing.Size(110, 24)
        Me.Radio3.TabIndex = 2
        Me.Radio3.TabStop = True
        Me.Radio3.Text = "Size 13-24"
        Me.Radio3.UseVisualStyleBackColor = True
        '
        'Radio2
        '
        Me.Radio2.AutoSize = True
        Me.Radio2.Location = New System.Drawing.Point(6, 57)
        Me.Radio2.Name = "Radio2"
        Me.Radio2.Size = New System.Drawing.Size(101, 24)
        Me.Radio2.TabIndex = 1
        Me.Radio2.TabStop = True
        Me.Radio2.Text = "Size 9-12"
        Me.Radio2.UseVisualStyleBackColor = True
        '
        'Radio1
        '
        Me.Radio1.AutoSize = True
        Me.Radio1.Checked = True
        Me.Radio1.Location = New System.Drawing.Point(6, 27)
        Me.Radio1.Name = "Radio1"
        Me.Radio1.Size = New System.Drawing.Size(88, 24)
        Me.Radio1.TabIndex = 0
        Me.Radio1.TabStop = True
        Me.Radio1.Text = "Size1-8"
        Me.Radio1.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(32, 316)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(129, 20)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "Cost of Ticket is :"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(58, 378)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(88, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(304, 378)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDisplaytotal
        '
        Me.lblDisplaytotal.AutoSize = True
        Me.lblDisplaytotal.Location = New System.Drawing.Point(300, 316)
        Me.lblDisplaytotal.Name = "lblDisplaytotal"
        Me.lblDisplaytotal.Size = New System.Drawing.Size(67, 20)
        Me.lblDisplaytotal.TabIndex = 7
        Me.lblDisplaytotal.Text = "$0000.0"
        '
        'PicBroadway
        '
        Me.PicBroadway.Image = Global.Broadway_Ticket_Group_Discount_Program.My.Resources.Resources.Broadway
        Me.PicBroadway.Location = New System.Drawing.Point(435, 12)
        Me.PicBroadway.Name = "PicBroadway"
        Me.PicBroadway.Size = New System.Drawing.Size(353, 426)
        Me.PicBroadway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBroadway.TabIndex = 8
        Me.PicBroadway.TabStop = False
        '
        'frmBroadwayTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PicBroadway)
        Me.Controls.Add(Me.lblDisplaytotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.grpnamesize)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblBroadway)
        Me.Name = "frmBroadwayTicket"
        Me.Text = "Broadway Ticket Group"
        Me.grpnamesize.ResumeLayout(False)
        Me.grpnamesize.PerformLayout()
        CType(Me.PicBroadway, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBroadway As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents grpnamesize As GroupBox
    Friend WithEvents Radio4 As RadioButton
    Friend WithEvents Radio3 As RadioButton
    Friend WithEvents Radio2 As RadioButton
    Friend WithEvents Radio1 As RadioButton
    Friend WithEvents lbltotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDisplaytotal As Label
    Friend WithEvents PicBroadway As PictureBox
End Class
