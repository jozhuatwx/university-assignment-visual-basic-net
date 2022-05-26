Imports System.Data.OleDb

Public Class frmUpdatePayRecord
    Private Sub frmEditPaymentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Hostel_Management_SystemDataSet.Payment' table. You can move, or remove it, as needed.
            Me.PaymentTableAdapter.Fill(Me.Hostel_Management_SystemDataSet.Payment)
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        cmbPaymentID_SelectedIndexChanged(Me, New EventArgs)
    End Sub

    Private Sub cmbPaymentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentID.SelectedIndexChanged
        'Disables update button unless it is searched
        btnUpdate.Enabled = False
        btnUpdate.BackColor = Color.FromArgb(36, 41, 47)

        'Enables search button
        btnSearch.Enabled = True
        btnSearch.BackColor = Color.DodgerBlue

        'Clears all fields
        txtStudentID.Clear()
        txtUnitID.Clear()
        dtpDateofEntry.Value = DateTime.Now
        txtLoggedBy.Clear()
        txtDescription.Clear()
        txtAmountDue.Clear()
        mskAmountPaid.Clear()
        dtpPaymentDate.Value = DateTime.Now
        dtpDateofEntry.Enabled = False
        dtpPaymentDate.Enabled = False

        'Hotkey to search
        AcceptButton = btnSearch
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            paymentID = cboPaymentID.Text

            command = New OleDbCommand("SELECT * FROM Payment WHERE [PaymentID]=@PaymentID", con)
            command.Parameters.AddWithValue("@PaymentID", paymentID)
            read = command.ExecuteReader()

            If read.Read = True Then
                txtStudentID.Text = read(1)
                txtUnitID.Text = read(2)
                dtpDateofEntry.Value = read(3)
                txtLoggedBy.Text = read(4)
                txtDescription.Text = read(5)
                txtAmountDue.Text = read(6).ToString()
                mskAmountPaid.Text = read(7).ToString()
                dtpPaymentDate.Value = read(8)
                dtpDateofEntry.Enabled = True
                dtpPaymentDate.Enabled = True

                'Hotkey to update
                AcceptButton = btnUpdate

                'Enables update button
                btnUpdate.Enabled = True
                btnUpdate.BackColor = Color.DodgerBlue

                'Disables search button
                btnSearch.Enabled = False
                btnSearch.BackColor = Color.FromArgb(36, 41, 47)
            End If
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            paymentID = cboPaymentID.Text
            studentID = txtStudentID.Text
            unitID = txtUnitID.Text
            dateOfEntry = dtpDateofEntry.Value.ToShortDateString
            description = txtDescription.Text
            amountDue = txtAmountDue.Text
            amountPaid = CInt(mskAmountPaid.Text)
            paymentDate = dtpPaymentDate.Value.ToShortDateString

            If amountPaid < amountDue Then
                'Student must pay at minimun the total amount due
                MessageBox.Show("Amount Paid cannot be lesser than Amount Due (RM " + amountDue.ToString() + ").", "Invalid Amount Paid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf IsNumeric(amountPaid) = False Then
                MessageBox.Show("Please retype the Amount Paid." + vbCrLf +
                                "Example: " + amountDue.ToString() + ".", "Invalid Amount Paid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmountDue.Select()
            ElseIf txtLoggedBy.Text <> username Then
                'Only the user who keyed in the record 
                MessageBox.Show("Modification cannot be done by this user.", "Unmatching Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'Asks to confirm
                msgBoxResult = MessageBox.Show("Proceed with the edit?" + vbCrLf +
                                               "Payment ID: " + paymentID + vbCrLf +
                                               "Student ID: " + studentID + vbCrLf +
                                               "Unit ID: " + unitID + vbCrLf +
                                               "Date of Entry: " + dateOfEntry.ToShortDateString + vbCrLf +
                                               "Description: " + description + vbCrLf +
                                               "Amount Due: RM " + amountDue.ToString() + vbCrLf +
                                               "Amount Paid: RM " + amountPaid.ToString() + vbCrLf +
                                               "Payment Date: " + paymentDate.ToShortDateString, "Payment Edit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If msgBoxResult = MsgBoxResult.Yes Then
                    'Updates the payment record
                    command = New OleDbCommand("UPDATE Payment SET [DateofEntry]=@DateofEntry, Description=@Description, [AmountDue]=@AmountDue, [AmountPaid]=@AmountPaid, [PaymentDate]=@PaymentDate WHERE [PaymentID]=@PaymentID", con)
                    command.Parameters.AddWithValue("@DateofEntry", dateOfEntry)
                    command.Parameters.AddWithValue("@Description", description)
                    command.Parameters.AddWithValue("@AmountDue", amountDue)
                    command.Parameters.AddWithValue("@AmountPaid", amountPaid)
                    command.Parameters.AddWithValue("@PaymentDate", paymentDate)
                    command.Parameters.AddWithValue("@PaymentID", paymentID)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    MessageBox.Show("Payment Edit Successful.", "Payment Edit Status")

                    frmMainMenu.Show()
                    Me.Close()
                End If
            End If
        Catch ex As ObjectDisposedException
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            msgBoxResult = MessageBox.Show("All current progress will be lost. " + vbCrLf +
                                           "Do you want to proceed?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If msgBoxResult = MsgBoxResult.Yes Then
                'Returns to Main Menu form
                frmMainMenu.Show()
                Me.Close()
            End If
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
