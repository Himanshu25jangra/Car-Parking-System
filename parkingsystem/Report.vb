Public Class Report

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ParkingSystemDataSet.History' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.ParkingSystemDataSet.History)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.HistoryTableAdapter.Filterdate(Me.ParkingSystemDataSet.History, DateTimePicker1.Value, DateTimePicker2.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.Show()
        Me.Close()
    End Sub
End Class