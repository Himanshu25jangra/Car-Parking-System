Imports System.Data.SqlClient
Public Class History

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        conn.Open()
        Dim cmd As New SqlCommand("Select * from History", conn)
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        History_Load(sender, e)

    End Sub
End Class