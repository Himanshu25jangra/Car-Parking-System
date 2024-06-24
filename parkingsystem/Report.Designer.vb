<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParkingSystemDataSet = New ParkingSystem.ParkingSystemDataSet()
        Me.HistoryTableAdapter = New ParkingSystem.ParkingSystemDataSetTableAdapters.HistoryTableAdapter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParkingSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HistoryBindingSource
        '
        Me.HistoryBindingSource.DataMember = "History"
        Me.HistoryBindingSource.DataSource = Me.ParkingSystemDataSet
        '
        'ParkingSystemDataSet
        '
        Me.ParkingSystemDataSet.DataSetName = "ParkingSystemDataSet"
        Me.ParkingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistoryTableAdapter
        '
        Me.HistoryTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportViewer1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.90076!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.09924!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(662, 262)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.HistoryBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ParkingSystem.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 62)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(656, 197)
        Me.ReportViewer1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 53)
        Me.Panel2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(9, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 262)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParkingSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParkingSystemDataSet As ParkingSystem.ParkingSystemDataSet
    Friend WithEvents HistoryTableAdapter As ParkingSystem.ParkingSystemDataSetTableAdapters.HistoryTableAdapter
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
