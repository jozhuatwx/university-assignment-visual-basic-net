Public Class frmPaymentReports
    Private Sub frmPaymentReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Hostel_Management_SystemDataSet.Payment' table. You can move, or remove it, as needed.
            Me.PaymentTableAdapter.Fill(Me.Hostel_Management_SystemDataSet.Payment)

            Me.rptPaymentReports.RefreshReport()
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddPayRecord(sender As Object, e As EventArgs) Handles btnAddPayRec.Click
        Try
            'To load user's name into the page
            frmAddPayRecord.lblHowdy.Text = "Howdy again, " + username + "! Welcome to"

            'To show examples in the text field
            frmAddPayRecord.txtDescription.Text = "Single Unit"
            frmAddPayRecord.txtDescription.ForeColor = Color.Silver
            frmAddPayRecord.mskAmountPaid.Text = "550"
            frmAddPayRecord.mskAmountPaid.ForeColor = Color.Silver

            'To show the selected form
            frmAddPayRecord.Show()
            Me.Close()
        Catch ex As ObjectDisposedException
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdatePayRecord(sender As Object, e As EventArgs) Handles btnUpdatePayRec.Click
        Try
            'To load user's name into the page
            frmUpdatePayRecord.lblHowdy.Text = "Howdy again, " + username + "! Welcome to"

            'To show the selected form
            frmUpdatePayRecord.Show()
            Me.Close()
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