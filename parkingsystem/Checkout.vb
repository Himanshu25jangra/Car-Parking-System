Imports System.Data
Imports System.Data.SqlClient

Public Class Checkout

    Dim Da As SqlDataAdapter
    Dim Dt As DataTable
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim sql As String
    Dim Dr As SqlDataReader

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True"
        con = New SqlConnection(sql)
        Da = New SqlDataAdapter()
        Dt = New DataTable()
        cmd = New SqlCommand("Select Slots.Slot_Id,Slots.CName,Slots.VehicleNo,Slots.Status from Slots where Slots.Status='Assigned' order by Slot_Id,Status", con)
        con.Open()
        Da.SelectCommand = cmd
        Da.SelectCommand.Connection = con
        Da.Fill(Dt)
        dgvView.DataSource = Dt
        con.Close()
    End Sub

    Private Sub txtViewPSID_Click(sender As Object, e As EventArgs) Handles txtViewPSID.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT  CName,VehicleNo,Status FROM Slots WHERE Slot_Id =@SID"
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@SID", TextBox4.Text)
        Dr = cmd.ExecuteReader
        While Dr.Read()
            TextBox1.Text = Dr("CName")
            TextBox3.Text = Dr("VehicleNo")
            TextBox5.Text = Dr("Status")
        End While
    End Sub

    Private Sub btnChooseParking_Click(sender As Object, e As EventArgs) Handles btnChooseParking.Click
        Dim a As New Payment
        a.Sid = TextBox4.Text
        a.Vno = TextBox3.Text
        a.Show()
        Me.Hide()
    End Sub

    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class