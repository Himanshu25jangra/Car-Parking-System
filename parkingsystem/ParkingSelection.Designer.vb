<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParkingSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParkingSelection))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLevel2 = New System.Windows.Forms.Button()
        Me.btnLevel1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(407, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 48)
        Me.Label6.TabIndex = 268
        Me.Label6.Text = "Parking Bay"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(0, 183)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 20)
        Me.TextBox2.TabIndex = 270
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(0, 422)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(10, 20)
        Me.TextBox3.TabIndex = 271
        Me.TextBox3.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, -1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 20)
        Me.TextBox1.TabIndex = 269
        Me.TextBox1.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(443, 355)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(170, 55)
        Me.btnBack.TabIndex = 3
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLevel2
        '
        Me.btnLevel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLevel2.BackColor = System.Drawing.Color.Transparent
        Me.btnLevel2.BackgroundImage = CType(resources.GetObject("btnLevel2.BackgroundImage"), System.Drawing.Image)
        Me.btnLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLevel2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLevel2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel2.Location = New System.Drawing.Point(586, 130)
        Me.btnLevel2.Name = "btnLevel2"
        Me.btnLevel2.Size = New System.Drawing.Size(200, 114)
        Me.btnLevel2.TabIndex = 1
        Me.btnLevel2.UseVisualStyleBackColor = False
        '
        'btnLevel1
        '
        Me.btnLevel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLevel1.BackColor = System.Drawing.Color.Transparent
        Me.btnLevel1.BackgroundImage = CType(resources.GetObject("btnLevel1.BackgroundImage"), System.Drawing.Image)
        Me.btnLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLevel1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLevel1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel1.Location = New System.Drawing.Point(258, 130)
        Me.btnLevel1.Name = "btnLevel1"
        Me.btnLevel1.Size = New System.Drawing.Size(200, 114)
        Me.btnLevel1.TabIndex = 0
        Me.btnLevel1.UseVisualStyleBackColor = False
        '
        'ParkingSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.ParkingSystem.My.Resources.Resources.car7
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1031, 442)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLevel2)
        Me.Controls.Add(Me.btnLevel1)
        Me.Name = "ParkingSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ParkingSelection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Private WithEvents btnLevel2 As System.Windows.Forms.Button
    Friend WithEvents btnLevel1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
