Imports System.Data
Imports System.Data.SqlClient
Public Class Register
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text
        Dim username As String = TextBox2.Text
        Dim password As String = TextBox3.Text
        Dim cpassword As String = TextBox4.Text
        If name.Trim() = "" Or username.Trim() = "" Or password.Trim() = "" Then
            MsgBox("Empty Fields")
        ElseIf Not String.Equals(password, cpassword) Then
            MsgBox("Wrong Password")
        ElseIf usernameexist(username) Then
            MsgBox("This user already exists")
        Else
            Dim conn As New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
            Dim cmdd As New SqlCommand("INSERT INTO [dbo].[Login] VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "')", conn)
            conn.Open()
            If cmdd.ExecuteNonQuery = 1 Then
                MessageBox.Show("User Registered Successfully", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
            Else
                MsgBox("User Not Registered")
            End If
        End If
    End Sub
    Public Function usernameexist(ByVal username As String) As Boolean
        Dim con As New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
        Dim dt As New DataTable
        Dim adp As New SqlDataAdapter
        Dim cmd As New SqlCommand("SELECT * FROM Login WHERE username= '" + TextBox2.Text + "'", con)
        adp.SelectCommand = cmd
        adp.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

  
End Class