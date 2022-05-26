Imports System.Data.OleDb

Public Class frmDeleteAccount
    Private Sub frmRemoveStudentsRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Hostel_Management_SystemDataSet.Students' table. You can move, or remove it, as needed.
            Me.StudentsTableAdapter.Fill(Me.Hostel_Management_SystemDataSet.Students)
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'To disable deleting record if no account is chosen
        If cboUnitID.SelectedIndex = -1 Then
            btnDelete.Enabled = False
            btnDelete.BackColor = Color.FromArgb(36, 41, 47)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Hotkey to delete
        AcceptButton = btnDelete

        'Clears previous values
        success1 = False
        success2 = False

        unitID = cboUnitID.Text
        studentID = txtStudentID.Text
        intakeCode = txtIntakeCode.Text
        firstName = txtFirstName.Text
        lastName = txtLastName.Text

        Try
            If Not unitID = "" Then
                msgBoxResult = MessageBox.Show("Delete this record?" + vbCrLf +
                                               "Unit ID: " + unitID + vbCrLf +
                                               "Student ID: " + studentID + vbCrLf +
                                               "Intake Code: " + intakeCode + vbCrLf +
                                               "First Name: " + firstName + vbCrLf +
                                               "Last Name: " + lastName, "Deleting Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                'To catch all errors
                'Searches and delete the selected data
                If msgBoxResult = MsgBoxResult.Yes Then
                    'To change hostel status to available
                    command = New OleDbCommand("UPDATE Hostel SET [OccupyingDate]= Null, [Status]='Available' WHERE [UnitID]=@UnitID", con)
                    command.Parameters.AddWithValue("@UnitID", unitID)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    success1 = True

                    'Proceed to next process only if the first process is successful
                    If success1 = True Then
                        'To delete student's account
                        command = New OleDbCommand("DELETE FROM Students WHERE [UnitID]=@UnitID", con)
                        command.Parameters.AddWithValue("@UnitID", unitID)
                        command.CommandType = CommandType.Text
                        command.ExecuteNonQuery()

                        success2 = True
                    End If

                End If

                If success1 = True And success2 = True Then
                    'Displays when both processes are successful
                    MessageBox.Show("Record Deletion Successful.", "Record Deletion Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Returns to Main Menu form
                    frmMainMenu.Show()
                    Me.Close()
                End If
            Else
                'Stop if no Unit ID is chosen
                MessageBox.Show("Please select a unit.", "Unit Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cboUnitID.Select()
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