<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Checkout))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvView = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnChooseParking = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtViewPSID = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(106, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 24)
        Me.Label4.TabIndex = 379
        Me.Label4.Text = "Slot Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(71, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 24)
        Me.Label3.TabIndex = 378
        Me.Label3.Text = "Vehicle No:"
        '
        'dgvView
        '
        Me.dgvView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvView.Location = New System.Drawing.Point(435, 90)
        Me.dgvView.Name = "dgvView"
        Me.dgvView.Size = New System.Drawing.Size(591, 263)
        Me.dgvView.TabIndex = 367
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), System.Drawing.Image)
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(8, 428)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(149, 55)
        Me.btnClear.TabIndex = 370
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnChooseParking
        '
        Me.btnChooseParking.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChooseParking.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnChooseParking.BackgroundImage = CType(resources.GetObject("btnChooseParking.BackgroundImage"), System.Drawing.Image)
        Me.btnChooseParking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChooseParking.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseParking.Location = New System.Drawing.Point(60, 331)
        Me.btnChooseParking.Name = "btnChooseParking"
        Me.btnChooseParking.Size = New System.Drawing.Size(241, 68)
        Me.btnChooseParking.TabIndex = 369
        Me.btnChooseParking.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(801, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 72)
        Me.Button1.TabIndex = 368
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(175, 429)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(147, 54)
        Me.btnBack.TabIndex = 363
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(191, 148)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 20)
        Me.TextBox1.TabIndex = 380
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(191, 198)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(135, 20)
        Me.TextBox3.TabIndex = 382
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(191, 103)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(135, 20)
        Me.TextBox4.TabIndex = 383
        '
        'txtViewPSID
        '
        Me.txtViewPSID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtViewPSID.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtViewPSID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtViewPSID.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViewPSID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtViewPSID.Location = New System.Drawing.Point(445, 384)
        Me.txtViewPSID.Name = "txtViewPSID"
        Me.txtViewPSID.Size = New System.Drawing.Size(292, 76)
        Me.txtViewPSID.TabIndex = 365
        Me.txtViewPSID.Text = "View Parking Details "
        Me.txtViewPSID.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(108, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 24)
        Me.Label1.TabIndex = 384
        Me.Label1.Text = "Name:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(191, 247)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(135, 20)
        Me.TextBox5.TabIndex = 386
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(108, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 24)
        Me.Label5.TabIndex = 385
        Me.Label5.Text = "Status:"
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ParkingSystem.My.Resources.Resources.car2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1048, 518)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnChooseParking)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvView)
        Me.Controls.Add(Me.txtViewPSID)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnChooseParking As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvView As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents txtViewPSID As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
