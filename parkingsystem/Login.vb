Imports System.Data
Imports System.Data.SqlClient

Public Class Login

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        Dim cmd As New SqlCommand("select * from Login where username = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'", con)

        Dim adp As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adp.Fill(dt)

        If (dt.Rows.Count > 0) Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            Home.Show()
            Me.Hide()

        ElseIf TextBox1.Text = "" Or TextBox2.Text = "password" Then
            MsgBox("Enter Username")
        ElseIf TextBox1.Text = "username" Or TextBox2.Text = "" Then
            MsgBox("Enter Password")
        Else
            MsgBox("Invalid Username or Password")
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub
End Class

