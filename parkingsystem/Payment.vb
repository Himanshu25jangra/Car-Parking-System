Imports System.Data
Imports System.Data.SqlClient

Public Class Payment
    Dim Da As SqlDataAdapter
    Dim Dt As DataTable
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim sql As String
    Dim Dr As SqlDataReader
    Public Property Sid As String
    Public Property Vno As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Demo As Decimal
        Demo = Nothing

        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "UPDATE History SET Payment=@pay Where vno=@VNo"
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@pay", TextBox1.Text)
        cmd.Parameters.AddWithValue("@VNo", Label6.Text)
        cmd.ExecuteNonQuery()
        con.Close()



        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "UPDATE Slots SET CName=@CName,VehicleNo=@VNo, Status='Available' WHERE Slot_Id = @SID "
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@CName", Demo)
        cmd.Parameters.AddWithValue("@VNo", Demo)
        cmd.Parameters.AddWithValue("@SID", Label4.Text)
        cmd.ExecuteNonQuery()
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i >= 1) Then

            con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
            con.Open()
            sql = "DELETE FROM Newentry WHERE vno=@VNo"
            cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@VNo", Label6.Text)
            MessageBox.Show("Parking Slot released Successfully.")
            cmd.ExecuteNonQuery()
            con.Close()

        Else
            MsgBox("Unable to released parking slot", MsgBoxStyle.Exclamation, MessageBoxButtons.OK)
        End If
        con.Close()
        Label4.Text = ""
        Label6.Text = ""
        TextBox1.Clear()
        Home.Show()
        Me.Hide()
        con.Close()
    End Sub


    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = Sid
        Label6.Text = Vno
    End Sub
End Class