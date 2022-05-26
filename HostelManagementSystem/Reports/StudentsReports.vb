Public Class frmStudentReports
    Private Sub frmStudentsReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Hostel_Management_SystemDataSet.StudentsHostel' table. You can move, or remove it, as needed.
            Me.StudentsHostelTableAdapter.Fill(Me.Hostel_Management_SystemDataSet.StudentsHostel)
            'TODO: This line of code loads data into the 'Hostel_Management_SystemDataSet.Students' table. You can move, or remove it, as needed.
            Me.StudentsTableAdapter.Fill(Me.Hostel_Management_SystemDataSet.Students)

            Me.rptStudentReports.RefreshReport()
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RegisterAccount(sender As Object, e As EventArgs) Handles btnRegisterAcc.Click
        Try
            'To load user's name into the page
            frmRegisterAccount.lblHowdy.Text = "Howdy again, " + username + "! Welcome to"

            'To show the selected form
            frmRegisterAccount.Show()
            Me.Close()
        Catch ex As ObjectDisposedException
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateAccount(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click
        Try
            'To load user's name into the page
            frmUpdateAccount.lblHowdy.Text = "Howdy again, " + username + "! Welcome to"

            'To show the selected form
            frmUpdateAccount.Show()
            Me.Close()

            'To show examples in the text field
            frmUpdateAccount.mskStudentID.Text = "TP123456"
            frmUpdateAccount.mskStudentID.ForeColor = Color.Silver
        Catch ex As ObjectDisposedException
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            'Returns to Main Menu form
            frmMainMenu.Show()
            Me.Close()
        Catch ex As ObjectDisposedException
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'To confirm exiting the application
        msgBoxResult = MessageBox.Show("Exit Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If msgBoxResult = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class