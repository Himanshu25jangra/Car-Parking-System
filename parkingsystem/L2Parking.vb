Imports System.Data
Imports System.Data.SqlClient
Public Class L2Parking
    Public Property Cname As String
    Public Property Email As String
    Public Property VehicleNo As String
    Dim a As String
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim sql As String
    Dim con As New SqlConnection

    Private Sub L2Parking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox5.Text = Cname
        TextBox1.Text = Email
        TextBox2.Text = VehicleNo

        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-01'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn1.BackColor = Color.Red
        Else
            btn1.BackColor = Color.Blue
        End If
        con.Close()

        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-02'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn2.BackColor = Color.Red
        Else
            btn2.BackColor = Color.Blue
        End If
        con.Close()

        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-03'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn3.BackColor = Color.Red
        Else
            btn3.BackColor = Color.Blue
        End If
        con.Close()

        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-04'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn4.BackColor = Color.Red
        Else
            btn4.BackColor = Color.Blue
        End If
        con.Close()

        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-05'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn5.BackColor = Color.Red
        Else
            btn5.BackColor = Color.Blue
        End If
        con.Close()

        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-06'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn6.BackColor = Color.Red
        Else
            btn6.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-07'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn7.BackColor = Color.Red
        Else
            btn7.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-08'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn8.BackColor = Color.Red
        Else
            btn8.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-09'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn9.BackColor = Color.Red
        Else
            btn9.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-10'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn10.BackColor = Color.Red
        Else
            btn10.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-11'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn11.BackColor = Color.Red
        Else
            btn11.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-12 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn12.BackColor = Color.Red
        Else
            btn12.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-13 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn13.BackColor = Color.Red
        Else
            btn13.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-14 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn14.BackColor = Color.Red
        Else
            btn14.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-15 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn15.BackColor = Color.Red
        Else
            btn15.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-16 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn16.BackColor = Color.Red
        Else
            btn16.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-17'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn17.BackColor = Color.Red
        Else
            btn17.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-18 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn18.BackColor = Color.Red
        Else
            btn18.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-19 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn19.BackColor = Color.Red
        Else
            btn19.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-20 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn20.BackColor = Color.Red
        Else
            btn20.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-21 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn21.BackColor = Color.Red
        Else
            btn21.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-22 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn22.BackColor = Color.Red
        Else
            btn22.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-23 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn23.BackColor = Color.Red
        Else
            btn23.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-24 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn24.BackColor = Color.Red
        Else
            btn24.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-25 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn25.BackColor = Color.Red
        Else
            btn25.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-26 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn26.BackColor = Color.Red
        Else
            btn26.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-27 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn27.BackColor = Color.Red
        Else
            btn27.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-28 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn28.BackColor = Color.Red
        Else
            btn28.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-29 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn29.BackColor = Color.Red
        Else
            btn29.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-30'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn30.BackColor = Color.Red
        Else
            btn30.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-31'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn31.BackColor = Color.Red
        Else
            btn31.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-32'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn32.BackColor = Color.Red
        Else
            btn32.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-33 '"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn33.BackColor = Color.Red
        Else
            btn33.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-34'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn34.BackColor = Color.Red
        Else
            btn34.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-35'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn35.BackColor = Color.Red
        Else
            btn35.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-36'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn36.BackColor = Color.Red
        Else
            btn36.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-37'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn37.BackColor = Color.Red
        Else
            btn37.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-38'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn38.BackColor = Color.Red
        Else
            btn38.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-39'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn39.BackColor = Color.Red
        Else
            btn39.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-40'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn40.BackColor = Color.Red
        Else
            btn40.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-41'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn41.BackColor = Color.Red
        Else
            btn41.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-42'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn42.BackColor = Color.Red
        Else
            btn42.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-43'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn43.BackColor = Color.Red
        Else
            btn43.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-44'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn44.BackColor = Color.Red
        Else
            btn44.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-45'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn45.BackColor = Color.Red
        Else
            btn45.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-46'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn46.BackColor = Color.Red
        Else
            btn46.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-47'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn47.BackColor = Color.Red
        Else
            btn47.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-48'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn48.BackColor = Color.Red
        Else
            btn48.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-49'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn49.BackColor = Color.Red
        Else
            btn49.BackColor = Color.Blue
        End If
        con.Close()
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id ='Lv2-50'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        dr.Read()
        a = dr.Item("Status")
        If a = "Assigned" Then
            btn50.BackColor = Color.Red
        Else
            btn50.BackColor = Color.Blue
        End If
        con.Close()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-01'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn1.Text
        If TextBox3.Text = "Assigned" Then
            btn1.BackColor = Color.Red
            btn1.Enabled = False
        Else
            btn1.BackColor = Color.Blue
        End If
        con.Close()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-02'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn2.Text
        If TextBox3.Text = "Assigned" Then
            btn2.BackColor = Color.Red
            btn2.Enabled = False
        Else
            btn2.BackColor = Color.Blue
        End If
        con.Close()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-03'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn3.Text
        If TextBox3.Text = "Assigned" Then
            btn3.BackColor = Color.Red
            btn3.Enabled = False
        Else
            btn3.BackColor = Color.Blue
        End If
        con.Close()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-04'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn4.Text
        If TextBox3.Text = "Assigned" Then
            btn4.BackColor = Color.Red
            btn4.Enabled = False
        Else
            btn4.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-05'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn5.Text
        If TextBox3.Text = "Assigned" Then
            btn5.BackColor = Color.Red
            btn5.Enabled = False
        Else
            btn5.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-06'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn6.Text
        If TextBox3.Text = "Assigned" Then
            btn6.BackColor = Color.Red
            btn6.Enabled = False
        Else
            btn6.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-07'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn7.Text
        If TextBox3.Text = "Assigned" Then
            btn7.BackColor = Color.Red
            btn7.Enabled = False
        Else
            btn7.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-08'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn8.Text
        If TextBox3.Text = "Assigned" Then
            btn8.BackColor = Color.Red
            btn8.Enabled = False
        Else
            btn8.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-09'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn9.Text
        If TextBox3.Text = "Assigned" Then
            btn9.BackColor = Color.Red
            btn9.Enabled = False
        Else
            btn9.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-10'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn10.Text
        If TextBox3.Text = "Assigned" Then
            btn10.BackColor = Color.Red
            btn10.Enabled = False
        Else
            btn10.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-11'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn11.Text
        If TextBox3.Text = "Assigned" Then
            btn11.BackColor = Color.Red
            btn11.Enabled = False
        Else
            btn11.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-12'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn12.Text
        If TextBox3.Text = "Assigned" Then
            btn12.BackColor = Color.Red
            btn12.Enabled = False
        Else
            btn12.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-13'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn13.Text
        If TextBox3.Text = "Assigned" Then
            btn13.BackColor = Color.Red
            btn13.Enabled = False
        Else
            btn13.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-14'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn14.Text
        If TextBox3.Text = "Assigned" Then
            btn14.BackColor = Color.Red
            btn14.Enabled = False
        Else
            btn14.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-15'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn15.Text
        If TextBox3.Text = "Assigned" Then
            btn15.BackColor = Color.Red
            btn15.Enabled = False
        Else
            btn15.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-16'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn16.Text
        If TextBox3.Text = "Assigned" Then
            btn16.BackColor = Color.Red
            btn16.Enabled = False
        Else
            btn16.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-17'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn17.Text
        If TextBox3.Text = "Assigned" Then
            btn17.BackColor = Color.Red
            btn17.Enabled = False
        Else
            btn17.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn18_Click(sender As Object, e As EventArgs) Handles btn18.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-18'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn18.Text
        If TextBox3.Text = "Assigned" Then
            btn18.BackColor = Color.Red
            btn18.Enabled = False
        Else
            btn18.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-19'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn19.Text
        If TextBox3.Text = "Assigned" Then
            btn19.BackColor = Color.Red
            btn19.Enabled = False
        Else
            btn19.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-20'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn20.Text
        If TextBox3.Text = "Assigned" Then
            btn20.BackColor = Color.Red
            btn20.Enabled = False
        Else
            btn20.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-21'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn21.Text
        If TextBox3.Text = "Assigned" Then
            btn21.BackColor = Color.Red
            btn21.Enabled = False
        Else
            btn21.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-22'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn22.Text
        If TextBox3.Text = "Assigned" Then
            btn22.BackColor = Color.Red
            btn22.Enabled = False
        Else
            btn22.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-23'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn23.Text
        If TextBox3.Text = "Assigned" Then
            btn23.BackColor = Color.Red
            btn23.Enabled = False
        Else
            btn23.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn24_Click(sender As Object, e As EventArgs) Handles btn24.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-24'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn24.Text
        If TextBox3.Text = "Assigned" Then
            btn24.BackColor = Color.Red
            btn24.Enabled = False
        Else
            btn24.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn25_Click(sender As Object, e As EventArgs) Handles btn25.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-25'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn25.Text
        If TextBox3.Text = "Assigned" Then
            btn25.BackColor = Color.Red
            btn25.Enabled = False
        Else
            btn25.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn26_Click(sender As Object, e As EventArgs) Handles btn26.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-26'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn26.Text
        If TextBox3.Text = "Assigned" Then
            btn26.BackColor = Color.Red
            btn26.Enabled = False
        Else
            btn26.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn27_Click(sender As Object, e As EventArgs) Handles btn27.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-27'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn27.Text
        If TextBox3.Text = "Assigned" Then
            btn27.BackColor = Color.Red
            btn27.Enabled = False
        Else
            btn27.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn28_Click(sender As Object, e As EventArgs) Handles btn28.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-28'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn28.Text
        If TextBox3.Text = "Assigned" Then
            btn28.BackColor = Color.Red
            btn28.Enabled = False
        Else
            btn28.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn29_Click(sender As Object, e As EventArgs) Handles btn29.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-29'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn29.Text
        If TextBox3.Text = "Assigned" Then
            btn29.BackColor = Color.Red
            btn29.Enabled = False
        Else
            btn29.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-30'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn30.Text
        If TextBox3.Text = "Assigned" Then
            btn30.BackColor = Color.Red
            btn30.Enabled = False
        Else
            btn30.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-31'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn31.Text
        If TextBox3.Text = "Assigned" Then
            btn31.BackColor = Color.Red
            btn31.Enabled = False
        Else
            btn31.BackColor = Color.Blue
        End If
        con.Close()
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-32'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn32.Text
        If TextBox3.Text = "Assigned" Then
            btn32.BackColor = Color.Red
            btn32.Enabled = False
        Else
            btn32.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-33'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn33.Text
        If TextBox3.Text = "Assigned" Then
            btn33.BackColor = Color.Red
            btn33.Enabled = False
        Else
            btn33.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn34_Click(sender As Object, e As EventArgs) Handles btn34.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-34'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn34.Text
        If TextBox3.Text = "Assigned" Then
            btn34.BackColor = Color.Red
            btn34.Enabled = False
        Else
            btn34.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn35_Click(sender As Object, e As EventArgs) Handles btn35.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-35'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn35.Text
        If TextBox3.Text = "Assigned" Then
            btn35.BackColor = Color.Red
            btn35.Enabled = False
        Else
            btn35.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn36_Click(sender As Object, e As EventArgs) Handles btn36.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-36'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn36.Text
        If TextBox3.Text = "Assigned" Then
            btn36.BackColor = Color.Red
            btn36.Enabled = False
        Else
            btn36.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn37_Click(sender As Object, e As EventArgs) Handles btn37.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-37'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn37.Text
        If TextBox3.Text = "Assigned" Then
            btn37.BackColor = Color.Red
            btn37.Enabled = False
        Else
            btn37.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn38_Click(sender As Object, e As EventArgs) Handles btn38.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-38'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn38.Text
        If TextBox3.Text = "Assigned" Then
            btn38.BackColor = Color.Red
            btn38.Enabled = False
        Else
            btn38.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn39_Click(sender As Object, e As EventArgs) Handles btn39.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-39'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn39.Text
        If TextBox3.Text = "Assigned" Then
            btn39.BackColor = Color.Red
            btn39.Enabled = False
        Else
            btn39.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn40_Click(sender As Object, e As EventArgs) Handles btn40.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-40'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn40.Text
        If TextBox3.Text = "Assigned" Then
            btn40.BackColor = Color.Red
            btn40.Enabled = False
        Else
            btn40.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn41_Click(sender As Object, e As EventArgs) Handles btn41.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-41'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn41.Text
        If TextBox3.Text = "Assigned" Then
            btn41.BackColor = Color.Red
            btn41.Enabled = False
        Else
            btn41.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn42_Click(sender As Object, e As EventArgs) Handles btn42.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-42'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn42.Text
        If TextBox3.Text = "Assigned" Then
            btn42.BackColor = Color.Red
            btn42.Enabled = False
        Else
            btn42.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn43_Click(sender As Object, e As EventArgs) Handles btn43.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-43'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn43.Text
        If TextBox3.Text = "Assigned" Then
            btn43.BackColor = Color.Red
            btn43.Enabled = False
        Else
            btn43.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn44_Click(sender As Object, e As EventArgs) Handles btn44.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-44'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn44.Text
        If TextBox3.Text = "Assigned" Then
            btn44.BackColor = Color.Red
            btn44.Enabled = False
        Else
            btn44.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn45_Click(sender As Object, e As EventArgs) Handles btn45.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-45'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn45.Text
        If TextBox3.Text = "Assigned" Then
            btn45.BackColor = Color.Red
            btn45.Enabled = False
        Else
            btn45.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn46_Click(sender As Object, e As EventArgs) Handles btn46.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-46'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn46.Text
        If TextBox3.Text = "Assigned" Then
            btn46.BackColor = Color.Red
            btn46.Enabled = False
        Else
            btn46.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn47_Click(sender As Object, e As EventArgs) Handles btn47.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-47'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn47.Text
        If TextBox3.Text = "Assigned" Then
            btn47.BackColor = Color.Red
            btn47.Enabled = False
        Else
            btn47.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn48_Click(sender As Object, e As EventArgs) Handles btn48.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-48'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn48.Text
        If TextBox3.Text = "Assigned" Then
            btn48.BackColor = Color.Red
            btn48.Enabled = False
        Else
            btn48.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn49_Click(sender As Object, e As EventArgs) Handles btn49.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-49'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn49.Text
        If TextBox3.Text = "Assigned" Then
            btn49.BackColor = Color.Red
            btn49.Enabled = False
        Else
            btn49.BackColor = Color.Blue
        End If
        con.Close()
    End Sub
    Private Sub btn50_Click(sender As Object, e As EventArgs) Handles btn50.Click
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "SELECT Status FROM Slots WHERE Slot_Id='Lv2-50'"
        cmd = New SqlCommand(sql, con)
        dr = cmd.ExecuteReader
        While dr.Read()
            TextBox4.Text = dr("Status").ToString
        End While
        TextBox3.Text = btn50.Text
        If TextBox3.Text = "Assigned" Then
            btn50.BackColor = Color.Red
            btn50.Enabled = False
        Else
            btn50.BackColor = Color.Blue
        End If
        con.Close()
    End Sub

    Private Sub btnChooseParkingSlot_Click_1(sender As Object, e As EventArgs) Handles btnChooseParkingSlot.Click
        Dim y = TextBox3.Text
        con = New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        con.Open()
        sql = "UPDATE [dbo].[Slots] SET [CName]= @CN, [VehicleNo]= @VN, [Status]= 'Assigned' WHERE [Slot_Id]= @PSID"
        cmd = New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@CN", TextBox5.Text)
        cmd.Parameters.AddWithValue("@VN", (TextBox2.Text))
        cmd.Parameters.AddWithValue("@PSID", TextBox3.Text)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i >= 1) Then
            MsgBox("Parking Slot Choose Successfully.", MessageBoxIcon.Information, MessageBoxButtons.OK)
        Else
            MsgBox("Error", MsgBoxStyle.Exclamation)
        End If
        con.Close()
        Home.Show()
        Me.Hide()

    End Sub
    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ParkingSelection.Show()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim r As String
        r = TextBox4.Text
        If r = "Assigned" Then
            MessageBox.Show("Parking Slot is Assigned")
            btnChooseParkingSlot.Enabled = False
        Else
            btnChooseParkingSlot.Enabled = True
        End If
    End Sub
End Class