Public Class ParkingSelection
    Public Property Cname As String
    Public Property Email As String
    Public Property VehicleNo As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        NewEntry.Show()
        Me.Hide()
    End Sub

    Private Sub btnLevel1_Click(sender As Object, e As EventArgs) Handles btnLevel1.Click
        Dim aa As New L1Parking
        aa.Cname = TextBox1.Text
        aa.Email = TextBox2.Text
        aa.VehicleNo = TextBox3.Text
        aa.Show()
        Me.Hide()

    End Sub

    Private Sub ParkingSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Cname
        TextBox2.Text = Email
        TextBox3.Text = VehicleNo

    End Sub

    Private Sub btnLevel2_Click(sender As Object, e As EventArgs) Handles btnLevel2.Click
        Dim aa As New L2Parking
        aa.Cname = TextBox1.Text
        aa.Email = TextBox2.Text
        aa.VehicleNo = TextBox3.Text
        aa.Show()
        Me.Hide()
    End Sub
End Class