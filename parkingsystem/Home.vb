Imports System.Speech.Synthesis

Public Class Home
    Dim spc As New SpeechSynthesizer

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spc.SelectVoiceByHints(VoiceGender.Male)
        spc.SpeakAsync("WELCOME To VeHIcle Parking Management System")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewEntry.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Customer.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SRecord.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        History.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Checkout.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Report.Show()
        Me.Hide()
    End Sub
End Class