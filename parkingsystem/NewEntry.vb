Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.SqlClient

Public Class NewEntry
    Public Property s As String
    Private Sub TextBox3_Validated(sender As Object, e As EventArgs) Handles TextBox3.Validated

        If (TextBox3.Text = "") Then
            MsgBox("Enter Phone Number.", MsgBoxStyle.Information, "Error")
        ElseIf IsNumeric(TextBox3.Text) = False Then
            MsgBox("Only Number Are Allowed.", MsgBoxStyle.Information, "Error")
        ElseIf Len(Trim(TextBox3.Text)) <> 10 Then
            MsgBox("Only 10 Digits Are Allowed.", MsgBoxStyle.Information, "Error")
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox4_Validated(sender As Object, e As EventArgs) Handles TextBox4.Validated
        Dim email, a As String
        Dim count As Integer
        If (TextBox4.Text = "") Then
            MsgBox("Email is not entered.", MsgBoxStyle.Information, "Error")
            TextBox4.Focus()
        Else
            email = TextBox4.Text

            If (email.Contains("@") = False Or email.Contains(".") = False) Then
                MsgBox("'@' or '.' Missing", MsgBoxStyle.Information, "Error")
                TextBox4.Text = ""
                TextBox4.Focus()
            Else
                For x = 0 To email.Length - 1
                    a = email.Substring(x, 1)
                    If a.Equals("@") Then
                        count = count + 1
                    End If
                Next
                If (count > 1) Then
                    MessageBox.Show("Email can't contain '@' more then once.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox4.Text = ""
                    TextBox4.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Date.Now
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox2.SelectedItem = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or ComboBox1.SelectedItem = "" Then
            MsgBox("Empty Fields")
        Else
            Dim conn As New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
            Dim cmdd As New SqlCommand("INSERT INTO [dbo].[Newentry]([fname],[lname],[phone],[email],[vtype],[vmodel],[vno],[vcolor],[date])VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + ComboBox1.SelectedItem + "','" + ComboBox2.SelectedItem + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + DateTimePicker1.Text + "')", conn)
            Dim conn1 As New SqlConnection("Data Source=DESKTOP-GP9L71N\SQLEXPRESS;Initial Catalog=ParkingSystem;Integrated Security=True")
            Dim cmdd1 As New SqlCommand("INSERT INTO [dbo].[History]([fname],[lname],[phone],[email],[vtype],[vmodel],[vno],[vcolor],[date])VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + ComboBox1.SelectedItem + "','" + ComboBox2.SelectedItem + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + DateTimePicker1.Text + "')", conn1)
            conn.Open()
            conn1.Open()
            If cmdd.ExecuteNonQuery = 1 And cmdd1.ExecuteNonQuery Then
                MessageBox.Show("Entry Successfully Done", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conn.Close()
                conn1.Close()
            Else
                MsgBox("Error occured during entry", MsgBoxStyle.Information, MessageBoxIcon.Information)
            End If
        End If
        Dim aa As New ParkingSelection
        aa.Cname = TextBox1.Text
        aa.Email = TextBox4.Text
        aa.VehicleNo = TextBox6.Text
        aa.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedItem = ComboBox1.SelectedItem.ToString()
        ComboBox2.Items.Clear()
        If selectedItem = "Two Wheeler" Then
            ComboBox2.Items.Add("Aprilia")
            ComboBox2.Items.Add(" Ather")
            ComboBox2.Items.Add("Bajaj")
            ComboBox2.Items.Add(" BMW")
            ComboBox2.Items.Add(" Ducati")
            ComboBox2.Items.Add(" Harley Davidson")
            ComboBox2.Items.Add(" Hero")
            ComboBox2.Items.Add(" Hero Honda")
            ComboBox2.Items.Add("Honda")
            ComboBox2.Items.Add("Jawa")
            ComboBox2.Items.Add(" Kawasaki")
            ComboBox2.Items.Add(" KTM")
            ComboBox2.Items.Add("Mahindra")
            ComboBox2.Items.Add(" Ola")
            ComboBox2.Items.Add("One Electic")
            ComboBox2.Items.Add(" Royal Enfield")
            ComboBox2.Items.Add("Revolt")
            ComboBox2.Items.Add(" Suzuki")
            ComboBox2.Items.Add(" Tvs")
            ComboBox2.Items.Add(" Yamaha")
            ComboBox2.Items.Add("Yezdi")

        Else
            ComboBox2.Items.Add(" Audi")
            ComboBox2.Items.Add(" Bugatti")
            ComboBox2.Items.Add(" Fiat")
            ComboBox2.Items.Add("Ferrari")
            ComboBox2.Items.Add("Ford")
            ComboBox2.Items.Add("GMC")
            ComboBox2.Items.Add("Hyundai")
            ComboBox2.Items.Add("Jaguar")
            ComboBox2.Items.Add("Kia")
            ComboBox2.Items.Add("Lamborghini")
            ComboBox2.Items.Add("Lexus")
            ComboBox2.Items.Add("Mahindra")
            ComboBox2.Items.Add(" Mercedes Banz")
            ComboBox2.Items.Add("Mini")
            ComboBox2.Items.Add("MG")
            ComboBox2.Items.Add("Nissan")
            ComboBox2.Items.Add("Porsche")
            ComboBox2.Items.Add("Range Rover")
            ComboBox2.Items.Add("Rolls Royal")
            ComboBox2.Items.Add("Skoda")
            ComboBox2.Items.Add("Tata Motors")
            ComboBox2.Items.Add("Toyota")
            ComboBox2.Items.Add("Volks Wagon")
            ComboBox2.Items.Add("Volvo")
        End If

    End Sub

    Private Sub TextBox6_Validated(sender As Object, e As EventArgs) Handles TextBox6.Validated
        Dim vehicleNumberPattern As String = "^[A-Z]{2}[0-9]{2}[A-Z]{2}[0-9]{4}$"
        Dim vehicleNumber = TextBox6.Text.Trim()
        If Not System.Text.RegularExpressions.Regex.IsMatch(vehicleNumber, vehicleNumberPattern) Then
            MessageBox.Show("Please entervehicle number in the format XX00XX0000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox6.Focus()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub


End Class