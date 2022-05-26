Public Class frmMainMenu
    Private Sub frmUsersOptions_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblHowdy.Text = "Howdy, " + username + "."

        If role = "Administrative Manager" Then
            'To hide the Reports button which these accounts do no have permission to view
            btnReports.Visible = True
        Else
            'Marked dispose as it is not used
            btnReports.Visible = False
            btnReports.Dispose()
            pnlReports.Dispose()
        End If
    End Sub

    Private Sub RegisterAccount(sender As Object, e As EventArgs) Handles btnRegisterAcc.Click, picRegisterAcc.Click
        'To load user's name into the page
        frmRegisterAccount.lblHowdy.Text = "Howdy again, " + username + "! Welcome to"

        'To show the selected form
        frmRegisterAccount.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateAccount(sender As Object, e As EventArgs) Handles btnUpdateAcc.Click, picUpdateAcc.Click
        'To load user's name into the page
        frmUpdateAccount.lblHowdy.Text = "Howdy again, " + username + "! Welcome to"

        'To show the selected form
        frmUpdateAccount.Show()
        Me.Hide()

        'To show examples in the text field
        frmUpdateAccount.mskStudentID.Text = "TP123456"
        frmUpdateAccount.mskStudentID.ForeColor = Color.Silver
    End Sub

    Private Sub DeleteAccount(sender As Object, e As EventArgs) Handles btnDeleteAcc.Click, picDeleteAcc.Click
        'To load user's name into the page
        frmDeleteAccount.lblHowdy.Text = "Howdy again, " + username + "! Welcome to"

        'To show the selected form
        frmDeleteAccount.Show()
        Me.Hide()
    End Sub

    Private Sub AddPayRecord(sender As Object, e As EventArgs) Handles btnAddPayRec.Click, picAddPayRec.Click
        'To load user's name into the page
        frmAddPayRecord.lblHowdy.Text = "Howdy again, " + username + "! Welcome to"

        'To show examples in the text field
        frmAddPayRecord.txtDescription.ForeColor = Color.Silver
        frmAddPayRecord.mskAmountPaid.Text = "550"
        frmAddPayRecord.mskAmountPaid.ForeColor = Color.Silver

        'To show the selected form
        frmAddPayRecord.Show()
        Me.Hide()
    End Sub

    Private Sub UpdatePayRecord(sender As Object, e As EventArgs) Handles btnUpdatePayRec.Click, picUpdatePayRec.Click
        'To load user's name into the page
        frmUpdatePayRecord.lblHowdy.Text = "Howdy again, " + username + "! Welcome to"

        'To show the selected form
        frmUpdatePayRecord.Show()
        Me.Hide()
    End Sub

    Private Sub StudentsReports(sender As Object, e As EventArgs) Handles btnStudentReports.Click, picStudentReports.Click
        'To show the selected form
        frmStudentReports.Show()
        Me.Hide()
    End Sub
    Private Sub PaymentReports(sender As Object, e As EventArgs) Handles btnPaymentReports.Click, picPaymentReports.Click
        'To show the selected form
        frmPaymentReports.Show()
        Me.Hide()
    End Sub


    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Try
            con.Close()

            frmLogIn.Show()
            Me.Close()
        Catch ex As ObjectDisposedException
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        'To show the contents selected
        pnlAccounts.Visible = True
        pnlPayment.Visible = False
        pnlReports.Visible = False

        'To move the visual highlight
        pnlHighlight.Location = New Point(0, 49)
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        'To show the contents selected
        pnlAccounts.Visible = False
        pnlPayment.Visible = True
        pnlReports.Visible = False

        'To move the visual highlight
        pnlHighlight.Location = New Point(100, 49)
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        'To show the contents selected
        pnlAccounts.Visible = False
        pnlPayment.Visible = False
        pnlReports.Visible = True

        'To move the visual highlight
        pnlHighlight.Location = New Point(200, 49)
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