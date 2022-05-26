Imports System.Data.OleDb

Public Class frmRegisterAccount
    Private Sub frmNewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Hostel_Management_SystemDataSet.Payment' table. You can move, or remove it, as needed.
            Me.HostelTableAdapter.Fill(Me.Hostel_Management_SystemDataSet.Hostel)

            'Show example in the text fields
            mskStudentID.Text = "TP123456"
            txtIntakeCode.Text = "UCDF1705ICTSE"
            txtFirstName.Text = "Robbie"
            txtLastName.Text = "Smith"
            mskContactNumber.Text = "01122223333"
            txtEmailAddress.Text = "example@mail.apu.edu.my"

            mskStudentID.ForeColor = Color.Silver
            txtIntakeCode.ForeColor = Color.Silver
            txtFirstName.ForeColor = Color.Silver
            txtLastName.ForeColor = Color.Silver
            mskContactNumber.ForeColor = Color.Silver
            txtEmailAddress.ForeColor = Color.Silver
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmMainMenu.Show()
            Me.Close()
        End Try
    End Sub

    Private Sub txtStatus_TextChanged(sender As Object, e As EventArgs) Handles txtStatus.TextChanged
        'Changes the font color to provide more visual cues and enable/disable proceed button
        Select Case txtStatus.Text
            Case "Available"
                txtStatus.ForeColor = Color.PaleGreen
                btnProceed.Enabled = True
                btnProceed.BackColor = Color.DodgerBlue

                'Hotkey to proceed
                AcceptButton = btnProceed
            Case "Occupied"
                txtStatus.ForeColor = Color.Salmon
                btnProceed.Enabled = False
                btnProceed.BackColor = Color.FromArgb(36, 41, 47)
        End Select
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Try
            unitID = cboUnitID.Text
            unitType = txtUnitType.Text
            unitStatus = txtStatus.Text
            occupyingDate = dtpOccupyingDate.Value.ToShortDateString
            unitRent = txtUnitRent.Text
            'Checks if unit selected is available
            If txtStatus.Text = "Available" Then
                'Asks for confirmation
                msgBoxResult = MessageBox.Show("Register at this unit?" + vbCrLf +
                                               "Unit ID: " + unitID + vbCrLf +
                                               "Occupying Date: " + occupyingDate + vbCrLf +
                                               "Unit Type: " + unitType + vbCrLf +
                                               "Unit Rent: RM " + unitRent.ToString(), "Unit Registration Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If msgBoxResult = MsgBoxResult.Yes Then
                    'Displays controls to register the student
                    pnlStudentRegistration.Visible = True
                    pnlHostelRegistration.Visible = False

                    'Hotkey to register
                    AcceptButton = btnRegister
                End If
            Else
                MessageBox.Show("The unit chosen is occupied." + vbCrLf +
                                "Please choose another unit.", "Occupied Unit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
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
                'Remove Event Handler when exiting form
                RemoveHandler Me.VisibleChanged, AddressOf frmRegisterAccount_VisibleChanged

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Show controls of the hostel registration
        pnlHostelRegistration.Visible = True
        pnlStudentRegistration.Visible = False

        'Hotkey to proceed
        AcceptButton = btnProceed
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            studentID = mskStudentID.Text
            intakeCode = txtIntakeCode.Text
            firstName = txtFirstName.Text
            lastName = txtLastName.Text
            contactNumber = mskContactNumber.Text
            emailAddress = txtEmailAddress.Text
            unitID = cboUnitID.Text
            occupyingDate = dtpOccupyingDate.Value.ToShortDateString

            If studentID.Length <> 8 Or studentID = Nothing Or mskStudentID.ForeColor = Color.Silver Then
                'Student ID must be 8 characters
                MessageBox.Show("Please retype the Student ID." + vbCrLf +
                               "Example: TP123456.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf intakeCode = Nothing Or txtIntakeCode.ForeColor = Color.Silver Then
                'Intake code must be at most 18 characters
                MessageBox.Show("Please retype the Intake Code." + vbCrLf +
                               "Example: UCDF1705ICTSE.", "Invalid Intake Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf IsNumeric(firstName) Or firstName = Nothing Or txtFirstName.ForeColor = Color.Silver Then
                'Name cannot be numbers or null
                MessageBox.Show("Please retype the First Name." + vbCrLf +
                               "Example: Robbie.", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf IsNumeric(lastName) Or lastName = Nothing Or txtLastName.ForeColor = Color.Silver Then
                'Name cannot be numbers or null
                MessageBox.Show("Please retype the Last Name." + vbCrLf +
                               "Example: Smith.", "Inalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf contactNumber.Length < 11 Or contactNumber = Nothing Or mskContactNumber.ForeColor = Color.Silver Then
                'Contact number cannot contain letters and must be between 10 to 11 characters
                MessageBox.Show("Please retype the Contact Number." + vbCrLf +
                               "Example: 01122223333.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf emailAddress.Contains("@") = False Or emailAddress.Contains(".") = False Or emailAddress = Nothing Or emailAddress = "example@mail.apu.edu.my" Then
                'Email cannot be numbers only
                MessageBox.Show("Please retype the E-mail Address." + vbCrLf +
                               "Example: robbiesmith123@hotmail.com.", "Invalid E-mail Address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'Display confirmation
                msgBoxResult = MessageBox.Show("Register this student?" + vbCrLf +
                                                           "Student ID: " + studentID + vbCrLf +
                                                           "Intake Code: " + intakeCode + vbCrLf +
                                                           "First Name: " + firstName + vbCrLf +
                                                           "Last Name: " + lastName + vbCrLf +
                                                           "Contact Number: " + contactNumber + vbCrLf +
                                                           "E-mail Address: " + emailAddress, "Registration Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgBoxResult = MsgBoxResult.Yes Then
                    'Clears previous values
                    success1 = False
                    success2 = False

                    'Writes student's details into the database
                    command = New OleDbCommand("INSERT INTO Students VALUES (@StudentID, @IntakeCode, @FirstName, @LastName, @ContactNumber, @EmailAddress, @UnitID)", con)
                    command.Parameters.AddWithValue("@StudentID", studentID)
                    command.Parameters.AddWithValue("@IntakeCode", intakeCode)
                    command.Parameters.AddWithValue("@FirstName", firstName)
                    command.Parameters.AddWithValue("@LastName", lastName)
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber)
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress)
                    command.Parameters.AddWithValue("@UnitID", unitID)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    success1 = True

                    'Proceed to next process only if the first process is successful
                    If success1 = True Then
                        'Updates the hostel status
                        command = New OleDbCommand("UPDATE Hostel SET [OccupyingDate]=@OccupyingDate, [Status]='Occupied' WHERE [UnitID]=@UnitID", con)
                        command.Parameters.AddWithValue("@OccupyingDate", occupyingDate)
                        command.Parameters.AddWithValue("@UnitID", unitID)
                        command.CommandType = CommandType.Text
                        command.ExecuteNonQuery()

                        success2 = True
                    End If

                    If success1 = True And success2 = True Then
                        'Resets values and identifies as Account Registration
                        accPaidSuccess = False
                        accRegistration = True

                        'Opens Add Payment form
                        frmAddPayRecord.Show()
                        Me.Visible = False

                        'To prevent triggering event handler before it is needed
                        AddHandler Me.VisibleChanged, AddressOf frmRegisterAccount_VisibleChanged
                    End If
                End If
            End If
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRegisterAccount_VisibleChanged(sender As Object, e As EventArgs)
        Try
            'Remove Event Handler when exiting form
            RemoveHandler Me.VisibleChanged, AddressOf frmRegisterAccount_VisibleChanged

            If accPaidSuccess = True Then
                'Displays when both processes are successful
                MessageBox.Show("Registration Successful", "Registration Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Resets the value
                accPaidSuccess = False
                accRegistration = False

                'Returns to Main Menu form
                frmMainMenu.Show()
                Me.Close()
            Else
                'Displays if account payment failed
                MessageBox.Show("Registration Failed", "Registration Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Resets the value
                accPaidSuccess = False
                accRegistration = False

                'Deletes student's account if account registration failed
                command = New OleDbCommand("DELETE FROM Students WHERE [StudentID]=@StudentID", con)
                command.Parameters.AddWithValue("@StudentID", studentID)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()

                command = New OleDbCommand("UPDATE Hostel SET [OccupyingDate]=Null, [Status]='Available' WHERE [UnitID]=@UnitID", con)
                command.Parameters.AddWithValue("@UnitID", unitID)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            End If

        Catch ex As ObjectDisposedException
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Remove Event Handler when exiting form
            RemoveHandler Me.VisibleChanged, AddressOf frmRegisterAccount_VisibleChanged
        End Try
    End Sub

    Private Sub mskStudentID_TextChanged(sender As Object, e As EventArgs) Handles mskStudentID.TextChanged
        'Automatically generate student email
        If mskStudentID.Text.Length = 8 And txtEmailAddress.ForeColor = Color.Silver Then
            txtEmailAddress.Text = mskStudentID.Text + "@mail.apu.edu.my"
        End If
    End Sub
    Private Sub mskStudentID_LostFocus(sender As Object, e As EventArgs) Handles mskStudentID.LostFocus
        'Fills textbox with example
        If mskStudentID.Text = "TP" Then
            mskStudentID.Text = "123456"
            mskStudentID.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtIntakeCode_LostFocus(sender As Object, e As EventArgs) Handles txtIntakeCode.LostFocus
        'Fills textbox with example
        If txtIntakeCode.Text = "" Then
            txtIntakeCode.Text = "UCDF1705ICTSE"
            txtIntakeCode.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtFirstName_LostFocus(sender As Object, e As EventArgs) Handles txtFirstName.LostFocus
        'Fills textbox with example
        If txtFirstName.Text = "" Then
            txtFirstName.Text = "Robbie"
            txtFirstName.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtLastName_LostFocus(sender As Object, e As EventArgs) Handles txtLastName.LostFocus
        'Fills textbox with example
        If txtLastName.Text = "" Then
            txtLastName.Text = "Smith"
            txtLastName.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtContactNumber_LostFocus(sender As Object, e As EventArgs) Handles mskContactNumber.LostFocus
        'Fills textbox with example
        If mskContactNumber.Text = "   -" Then
            mskContactNumber.Text = "01122223333"
            mskContactNumber.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtEmailAddress_LostFocus(sender As Object, e As EventArgs) Handles txtEmailAddress.LostFocus
        'Fills textbox with example
        If txtEmailAddress.Text = "" Then
            txtEmailAddress.Text = "example@mail.apu.edu.my"
            txtEmailAddress.ForeColor = Color.Silver
        End If
    End Sub



    Private Sub mskStudentID_GotFocus(sender As Object, e As EventArgs) Handles mskStudentID.GotFocus
        'Clears textbox with example
        If mskStudentID.ForeColor = Color.Silver Then
            mskStudentID.Clear()
        End If
        mskStudentID.ForeColor = Color.White
    End Sub

    Private Sub txtIntakeCode_GotFocus(sender As Object, e As EventArgs) Handles txtIntakeCode.GotFocus
        'Clears textbox with example
        If txtIntakeCode.ForeColor = Color.Silver Then
            txtIntakeCode.Clear()
        End If
        txtIntakeCode.ForeColor = Color.White
    End Sub

    Private Sub txtFirstName_GotFocus(sender As Object, e As EventArgs) Handles txtFirstName.GotFocus
        'Clears textbox with example
        If txtFirstName.ForeColor = Color.Silver Then
            txtFirstName.Clear()
        End If
        txtFirstName.ForeColor = Color.White
    End Sub

    Private Sub txtLastName_GotFocus(sender As Object, e As EventArgs) Handles txtLastName.GotFocus
        'Clears textbox with example
        If txtLastName.ForeColor = Color.Silver Then
            txtLastName.Clear()
        End If
        txtLastName.ForeColor = Color.White
    End Sub

    Private Sub txtContactNumber_GotFocus(sender As Object, e As EventArgs) Handles mskContactNumber.GotFocus
        'Clears textbox with example
        If mskContactNumber.ForeColor = Color.Silver Then
            mskContactNumber.Clear()
        End If
        mskContactNumber.ForeColor = Color.White
    End Sub

    Private Sub txtEmailAddress_GotFocus(sender As Object, e As EventArgs) Handles txtEmailAddress.GotFocus
        'Clears textbox with example
        If txtEmailAddress.ForeColor = Color.Silver And txtEmailAddress.Text = "example@mail.apu.edu.my" Then
            txtEmailAddress.Clear()
        End If
        txtEmailAddress.ForeColor = Color.White
    End Sub

    Private Sub txtEmailAddress_TextChanged(sender As Object, e As EventArgs)
        txtEmailAddress.ForeColor = Color.White

        RemoveHandler txtEmailAddress.TextChanged, AddressOf txtEmailAddress_TextChanged
        AddHandler txtEmailAddress.GotFocus, AddressOf txtEmailAddress_GotFocus
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