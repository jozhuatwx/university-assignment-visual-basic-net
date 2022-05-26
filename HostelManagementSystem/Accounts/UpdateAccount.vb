Imports System.Data.OleDb

Public Class frmUpdateAccount
    Private Sub mskStudentID_TextChanged(sender As Object, e As EventArgs) Handles mskStudentID.TextChanged
        'Disables proceed button unless it is searched
        btnProceed.Enabled = False
        btnProceed.BackColor = Color.FromArgb(36, 41, 47)

        'Temporarily changes fields to non-editable
        txtIntakeCode.ReadOnly = True
        txtIntakeCode.TabStop = False
        mskContactNumber.ReadOnly = True
        mskContactNumber.TabStop = False
        txtEmailAddress.ReadOnly = True
        txtEmailAddress.TabStop = False

        If Not (mskStudentID.Text = "TP123456" And mskStudentID.ForeColor = Color.Silver) And mskStudentID.Text.Length <> 8 Then
            'Enables the search button
            btnSearch.Enabled = True
            btnSearch.BackColor = Color.DodgerBlue
        End If

        'Clears all fields
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmailAddress.Clear()
        mskContactNumber.Clear()
        txtIntakeCode.Clear()
        txtUnitID.Clear()

        'Hotkey to search
        AcceptButton = btnSearch
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            studentID = mskStudentID.Text
            intakeCode = txtIntakeCode.Text
            firstName = txtFirstName.Text
            lastName = txtLastName.Text
            contactNumber = mskContactNumber.Text
            emailAddress = txtEmailAddress.Text
            unitID = txtUnitID.Text

            If mskStudentID.ForeColor = Color.Silver Or studentID = Nothing Then
                'Displays message if the Student ID is left empty
                MessageBox.Show("Please key in the Student ID." + vbCrLf +
                                "Example: TP123456.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                'Automatically selects the Student ID field
                mskStudentID.Select()
            ElseIf studentID.Length <> 8 Then
                'Displays message if the Student ID is less than 8 characters
                MessageBox.Show("Please retype the Student ID." + vbCrLf +
                                "Example: TP123456.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                'Automatically selects the Student ID field
                mskStudentID.Select()
            Else
                command = New OleDbCommand("SELECT * FROM Students WHERE [StudentID]=@StudentID", con)
                command.Parameters.AddWithValue("@StudentID", studentID)
                read = command.ExecuteReader()

                If read.Read = True Then
                    'Copies data to the fields
                    mskStudentID.Text = read(0)
                    txtIntakeCode.Text = read(1)
                    txtFirstName.Text = read(2)
                    txtLastName.Text = read(3)
                    mskContactNumber.Text = read(4)
                    txtEmailAddress.Text = read(5)
                    txtUnitID.Text = read(6).ToString()

                    'Enables the proceed button
                    btnProceed.Enabled = True
                    btnProceed.BackColor = Color.DodgerBlue

                    'Enables editting certain fields
                    txtIntakeCode.ReadOnly = False
                    txtIntakeCode.TabStop = True
                    mskContactNumber.ReadOnly = False
                    mskContactNumber.TabStop = True
                    txtEmailAddress.ReadOnly = False
                    txtEmailAddress.TabStop = True

                    'Disables the search button
                    btnSearch.Enabled = False
                    btnSearch.BackColor = Color.FromArgb(36, 41, 47)

                    'Hotkey to proceed
                    AcceptButton = btnProceed
                Else
                    'Displays message when information is not found
                    MessageBox.Show("Information not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    'Automatically selects the Student ID field
                    mskStudentID.Select()
                End If
            End If
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Try
            'Clears previous values
            success1 = False
            success2 = False

            intakeCode = txtIntakeCode.Text
            contactNumber = mskContactNumber.Text
            emailAddress = txtEmailAddress.Text

            If intakeCode.Length >= 19 Or intakeCode = Nothing Then
                'Intake code must be at most 19 characters
                MessageBox.Show("Please retype the Intake Code." + vbCrLf +
                                "Example: UCDF1705ICTSE.", "Invalid Intake Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf contactNumber.Length < 11 Then
                'Contact number cannot contain letters and must be between 10 to 11 characters
                MessageBox.Show("Please retype the Contact Number." + vbCrLf +
                                "Example: 0112223333.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf emailAddress.Contains("@") = False Or emailAddress.Contains(".") = False Or emailAddress = Nothing Then
                'Email cannot be numbers only
                MessageBox.Show("Please retype the E-mail Address." + vbCrLf +
                                "Example: robbiesmith123@hotmail.com.", "Invalid E-mail Address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                msgBoxResult = MessageBox.Show("Update Record?" + vbCrLf +
                                               "Intake Code: " + intakeCode + vbCrLf +
                                               "Contact Number: " + contactNumber + vbCrLf +
                                               "E-mail Address: " + emailAddress, "Updating Student Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If msgBoxResult = MsgBoxResult.Yes Then
                    'Updates the information in the database
                    command = New OleDbCommand("UPDATE Students SET [IntakeCode]=@IntakeCode,[ContactNumber]=@ContactNumber,[EmailAddress]=@EmailAddress WHERE [StudentID]=@StudentID", con)
                    command.Parameters.AddWithValue("@IntakeCode", intakeCode)
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber)
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress)
                    command.Parameters.AddWithValue("@StudentID", studentID)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    success1 = True

                    'TODO: This line of code loads data into the 'Hostel_Management_SystemDataSet.Hostel' table. You can move, or remove it, as needed.
                    Me.HostelTableAdapter.Fill(Me.Hostel_Management_SystemDataSet.Hostel)

                    oldUnitID = txtUnitID.Text

                    If success1 = True Then
                        command = New OleDbCommand("SELECT [OccupyingDate] FROM Hostel WHERE [UnitID]=@UnitID", con)
                        command.Parameters.AddWithValue("@UnitID", oldUnitID)

                        read = command.ExecuteReader()
                        If read.Read = True Then
                            txtOldUnitID.Text = oldUnitID
                            dtpOccupyingDate.Value = read(0).ToString()
                        End If

                        'Hotkey to update
                        AcceptButton = btnUpdate

                        success2 = True
                    End If

                    If success1 = True And success2 = True Then
                        'Display controls to update hostel unit if both processes are successful
                        pnlStudRecMod.Visible = False
                        pnlHosRecMod.Visible = True

                        cboNewUnitID_SelectedIndexChanged(Me, New EventArgs)
                    End If
                End If
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


    Private Sub mskStudentID_LostFocus(sender As Object, e As EventArgs) Handles mskStudentID.LostFocus
        'Fills textbox with example
        If mskStudentID.Text = "TP" Then
            mskStudentID.Text = "123456"
            mskStudentID.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub mskStudentID_GotFocus(sender As Object, e As EventArgs) Handles mskStudentID.GotFocus
        'Clears textbox with example
        If mskStudentID.ForeColor = Color.Silver Then
            mskStudentID.Clear()
        End If
        mskStudentID.ForeColor = Color.White
    End Sub


    Private Sub txtStatus_TextChanged(sender As Object, e As EventArgs) Handles txtStatus.TextChanged
        'Changes the font color to provide more visual cues and enable/disable update button
        If txtSameUnit.Visible = False Then
            Select Case txtStatus.Text
                Case "Available"
                    txtStatus.ForeColor = Color.PaleGreen
                    btnUpdate.Enabled = True
                    btnUpdate.BackColor = Color.DodgerBlue
                Case "Occupied"
                    txtStatus.ForeColor = Color.Salmon
                    btnUpdate.Enabled = False
                    btnUpdate.BackColor = Color.FromArgb(36, 41, 47)
            End Select
        End If
    End Sub

    Private Sub txtSameUnit_VisibleChanged(sender As Object, e As EventArgs) Handles txtSameUnit.VisibleChanged
        If txtSameUnit.Visible = True Then
            btnUpdate.Enabled = True
            btnUpdate.BackColor = Color.DodgerBlue
        Else
            txtStatus_TextChanged(Me, New EventArgs)
        End If
    End Sub
    Private Sub cboNewUnitID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNewUnitID.SelectedIndexChanged
        If cboNewUnitID.Text = txtOldUnitID.Text Then
            txtSameUnit.Visible = True
        Else
            txtSameUnit.Visible = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Shows control to update account details
        pnlHosRecMod.Visible = False
        pnlStudRecMod.Visible = True
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'Clears previous values
            success1 = False
            success2 = False
            success3 = False

            newUnitID = cboNewUnitID.Text
            unitType = txtUnitType.Text
            unitStatus = txtStatus.Text
            occupyingDate = dtpOccupyingDate.Value.ToShortDateString
            unitRent = txtUnitRent.Text
            studentID = mskStudentID.Text
            oldUnitID = txtOldUnitID.Text


            If unitStatus = "Available" Or oldUnitID = newUnitID Then
                'To prevent changing unit types
                If (oldUnitID.Contains("S") And cboNewUnitID.Text.Contains("S")) Or (oldUnitID.Contains("D") And cboNewUnitID.Text.Contains("D")) Then

                    msgBoxResult = MessageBox.Show("Update record?" + vbCrLf +
                                                   "New Unit ID: " + newUnitID + vbCrLf +
                                                   "Occupying Date: " + occupyingDate + vbCrLf +
                                                   "Unit Type: " + unitType + vbCrLf +
                                                   "Unit Rent: RM " + unitRent.ToString(), "Updating Unit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If msgBoxResult = MsgBoxResult.Yes Then

                        'Update the new unit to occupied
                        command = New OleDbCommand("UPDATE Hostel SET [OccupyingDate]= Null, [Status]='Available' WHERE [UnitID]=@OldUnitID", con)
                        command.Parameters.AddWithValue("@OldUnitID", oldUnitID)
                        command.CommandType = CommandType.Text
                        command.ExecuteNonQuery()

                        success1 = True

                        If success1 = True Then
                            'Update the old unit to available
                            command = New OleDbCommand("UPDATE Hostel SET [OccupyingDate]=@OccupyingDate, [Status]='Occupied' WHERE [UnitID]=@NewUnitID", con)
                            command.Parameters.AddWithValue("@OccupyingDate", occupyingDate)
                            command.Parameters.AddWithValue("@NewUnitID", newUnitID)
                            command.CommandType = CommandType.Text
                            command.ExecuteNonQuery()

                            success2 = True
                        End If


                        If success2 = True Then
                            'Update the student's account to new unit
                            command = New OleDbCommand("UPDATE Students SET [UnitID]=@NewUnitID WHERE [StudentID]=@StudentID", con)
                            command.Parameters.AddWithValue("@NewUnitID", newUnitID)
                            command.Parameters.AddWithValue("@StudentID", studentID)
                            command.CommandType = CommandType.Text
                            command.ExecuteNonQuery()

                            'Update the new unit in the payment record
                            command = New OleDbCommand("UPDATE Payment SET [UnitID]=@NewUnitID WHERE [StudentID]=@StudentID", con)
                            command.Parameters.AddWithValue("@NewUnitID", newUnitID)
                            command.Parameters.AddWithValue("@StudentID", studentID)
                            command.CommandType = CommandType.Text
                            command.ExecuteNonQuery()

                            success3 = True
                        End If

                        If success1 = True And success2 = True And success3 = True Then
                            mskStudentID.Text = ""
                            MessageBox.Show("Update Unit Successful.", "Unit Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            frmMainMenu.Show()
                            Me.Close()
                        End If
                    End If
                Else
                    MessageBox.Show("Please select the same unit type.", "Unit Type", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please choose an available unit.", "Occupied Unit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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