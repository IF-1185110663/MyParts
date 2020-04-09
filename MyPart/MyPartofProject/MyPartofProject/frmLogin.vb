Imports System.Data.OleDb

Public Class frmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Logins.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand(
                   "SELECT * FROM tblUsers WHERE Username = '" &
                   txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "' ", con)
        Dim user As String = ""
        Dim pass As String = ""

        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            user = sdr("Username")
            pass = sdr("Password")
            MessageBox.Show("Login Successfully!")
            Me.Hide()
            frmManagerEdits.Show()

        Else
            MessageBox.Show("Invalid username or password!")
        End If
    End Sub

End Class
