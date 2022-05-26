Imports System.Data.OleDb

Public Class frmLogIn
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'To show the keyed in password characters
        txtPassword.UseSystemPasswordChar = False

        'To change the image
        btnShow.BackgroundImage = My.Resources.Hide

        'To change the event handler to hide the password when clicked again
        AddHandler btnShow.Click, AddressOf btnHide_Click
        RemoveHandler btnShow.Click, AddressOf btnShow_Click
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs)
        'To hide the keyed in password characters
        txtPassword.UseSystemPasswordChar = True

        'To change the image
        btnShow.BackgroundImage = My.Resources.Show

        'To change the event handler to show the password when clicked again
        AddHandler btnShow.Click, AddressOf btnShow_Click
        RemoveHandler btnShow.Click, AddressOf btnHide_Click
    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Hotkey to login
        AcceptButton = btnLogin

        'Clears previous values
        success1 = False
        success2 = False

        Try
            con.Open()
            Try
                username = txtUsername.Text
                password = txtPassword.Text

                If Not txtUsername.ForeColor = Color.Silver And Not password = Nothing Then
                    'If all fields are not empty
                    command = New OleDbCommand("SELECT Username, Password, Role FROM Credentials WHERE Username = @Username AND Password=@Password")
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Password", password)
                    command.Connection = con
                    command.CommandType = CommandType.Text
                    read = command.ExecuteReader()

                    If read.Read = True Then
                        If Not username = read(0) Or Not password = read(1) Then
                            'The information combination do not exist
                            MessageBox.Show("Incorrect username and/or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            con.Close()
                        Else
                            'To load the Main Menu form
                            role = read(2)
                            frmMainMenu.Show()
                            Me.Close()
                        End If
                    Else
                        'The information combination do not exist
                        MessageBox.Show("Incorrect username and/or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        con.Close()
                    End If
                Else
                    MessageBox.Show("Please key in your username and/or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'Automatically select the empty field
                    If txtUsername.ForeColor = Color.Silver Then
                        txtUsername.Select()
                    ElseIf password = Nothing Then
                        txtPassword.Select()
                    End If

                    con.Close()
                End If
            Catch ex As ObjectDisposedException
                con.Close()
            Catch ex As Exception
                con.Close()

                'Display error message 
                MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                                ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Catch ex As Exception
            'To separate connection problem from SQL errors
            MessageBox.Show("Problem with connection to database. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        'Fills textbox with example
        If txtUsername.ForeColor = Color.Silver Then
            txtUsername.Clear()
        End If
        txtUsername.ForeColor = Color.White
    End Sub

    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        'Clears textbox with example
        If txtUsername.Text = "" Then
            txtUsername.Text = "John"
            txtUsername.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
