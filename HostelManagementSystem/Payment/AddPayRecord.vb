Imports System.Data.OleDb

Public Class frmAddPayRecord
    Private Sub frmAddPaymentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'Hostel_Management_SystemDataSet.Students' table. You can move, or remove it, as needed.
            Me.StudentsTableAdapter.Fill(Me.Hostel_Management_SystemDataSet.Students)

            mskAmountPaid.Text = "0"

            'To retrieve the latest payment ID number
            command = New OleDbCommand("SELECT [PaymentID] FROM Payment", con)
            read = command.ExecuteReader()

            If read.Read = True Then
                command = New OleDbCommand("SELECT MAX([PaymentID]) FROM Payment", con)
                read = command.ExecuteReader()
                read.Read()

                'To increment the latest payment ID by 1
                paymentID = (read(0) + 1)
            Else
                paymentID = 1
            End If

            intPaymentID = CInt(paymentID)
            'To format the payment ID to 4-character string
            txtPaymentID.Text = intPaymentID.ToString("0000")
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If accRegistration = True Then
            'Hides combobox and displays the unit ID selected if it is Account Registration
            cboUnitID.Visible = False
            pnlUnitID.Visible = True

            'Inserts values taken from Register Account form
            txtUnitID.Text = unitID
            txtStudentID.Text = studentID

            'Calls method once to load data based on the Unit ID and Student ID
            cboUnitID_SelectedIndexChanged(Me, New EventArgs)
        Else
            cboUnitID.Visible = True
            pnlUnitID.Visible = False

            'To move event to till after dataset is loaded
            cboUnitID_SelectedIndexChanged(Me, New EventArgs)
            AddHandler cboUnitID.SelectedIndexChanged, AddressOf cboUnitID_SelectedIndexChanged
        End If

        'Hotkey to add
        AcceptButton = btnAdd
    End Sub

    Private Sub cboUnitID_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            'Clears previous values
            success1 = False
            success2 = False
            success3 = False

            amountDue = 0
            amountPaidSum = 0
            monthDifference = 0
            yearDifference = 0

            If accRegistration = False Then
                'Not Registering Account
                unitID = cboUnitID.Text

                'Retrieves Student ID based on the Unit ID
                command = New OleDbCommand("SELECT [StudentID] FROM Students WHERE [UnitID]=@UnitID", con)
                command.Parameters.AddWithValue("@UnitID", unitID)
                read = command.ExecuteReader()

                If read.Read = True Then
                    studentID = read(0)
                    txtStudentID.Text = studentID

                    success1 = True
                End If

                If success1 = True Then
                    'Retrieves the unit rend and hostel occupying date
                    command = New OleDbCommand("SELECT [UnitRent], [OccupyingDate] FROM Hostel WHERE [UnitID]=@UnitID", con)
                    command.Parameters.AddWithValue("@UnitID", unitID)
                    read = command.ExecuteReader()
                    If read.Read = True Then
                        unitRent = read(0)

                        occupyingDate = read(1)

                        'Keeps the month only and converts it to integer
                        intOccupyingMonth = occupyingDate.ToString("MM")

                        'Keeps the year only and converts it to integer
                        intOccupyingYear = occupyingDate.ToString("yyyy")

                        'Calcuate the total month and year difference from now
                        monthDifference = DateTime.Now.Month - intOccupyingMonth
                        yearDifference = DateTime.Now.Year - intOccupyingYear
                    End If

                    success2 = True
                End If

                If success2 = True Then
                    'Retrieves the total amount paid
                    command = New OleDbCommand("SELECT [AmountPaid] As amountPaidSum FROM Payment WHERE [StudentID]=@StudentID AND [UnitID]=@UnitID", con)
                    command.Parameters.AddWithValue("@StudentID", studentID)
                    command.Parameters.AddWithValue("@UnitID", unitID)
                    read = command.ExecuteReader()

                    If read.Read = True Then
                        command = New OleDbCommand("SELECT SUM([AmountPaid]) As amountPaidSum FROM Payment WHERE [StudentID]=@StudentID AND [UnitID]=@UnitID", con)
                        command.Parameters.AddWithValue("@StudentID", studentID)
                        command.Parameters.AddWithValue("@UnitID", unitID)
                        read = command.ExecuteReader()
                        read.Read()

                        amountPaidSum = read("amountPaidSum")
                    End If

                    success3 = True
                End If
            End If

            If (success1 = True And success2 = True) Or accRegistration = True Then
                'Runs only when both processes are successful or is part of Account Registration
                'Converts year(s) to months and add to month difference
                While yearDifference > 0
                    monthDifference += 12
                    yearDifference -= 1
                End While

                'Calculates the total amount due including the initial deposit
                'Adds 1 month for the present month, 1 month for deposit
                amountDue += unitRent * (monthDifference + 2)

                'Displays the total amount due
                txtAmountDue.Text = CStr(amountDue - amountPaidSum)

                'Changes the font color to provide more visual cues
                If CInt(txtAmountDue.Text) > 0 Then
                    txtAmountDue.ForeColor = Color.Salmon
                    lblAmountDueRM.ForeColor = Color.Salmon
                Else
                    txtAmountDue.ForeColor = Color.PaleGreen
                    lblAmountDueRM.ForeColor = Color.PaleGreen
                End If
            End If

            'Fills textbox with example
            If unitID.Contains("S") Then
                txtDescription.Text = "Single Unit"
            ElseIf unitID.Contains("D") Then
                txtDescription.Text = "Double Unit"
            End If
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If success3 = False And accRegistration = False Then
            'Close form if process failed and is not Account Registration as the required information cannot be obtained
            Try
                frmMainMenu.Show()
                Me.Close()
            Catch ex As ObjectDisposedException
            Catch ex As Exception
                'Display error message 
                MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                                ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            'Clears previous values
            success1 = False

            If accRegistration = False Then
                unitID = cboUnitID.Text
            End If

            dateOfEntry = dtpDateofEntry.Value.ToShortDateString
            description = txtDescription.Text
            amountPaid = CInt(mskAmountPaid.Text)
            paymentDate = dtpPaymentDate.Value.ToShortDateString

            If unitID = Nothing Then
                'Unit ID cannot be null
                MessageBox.Show("No Unit selected.", "Invalid Unit ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                cboUnitID.Select()
            ElseIf amountPaid < CInt(txtAmountDue.Text) Then
                'Student must pay at minimun the total amount due
                MessageBox.Show("Amount Paid cannot be lesser than Amount Due (RM " + amountDue.ToString() + ").", "Invalid Amount Paid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf IsNumeric(amountPaid) = False Then
                MessageBox.Show("Please retype the Amount Paid." + vbCrLf +
                                "Example: " + amountDue.ToString() + ".", "Invalid Amount Paid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAmountDue.Select()
            Else
                'Asks for confirmation
                msgBoxResult = MessageBox.Show("Proceed with the payment?" + vbCrLf +
                                                "Student ID: " + studentID + vbCrLf +
                                                "Unit ID: " + unitID + vbCrLf +
                                                "Date of Entry: " + dateOfEntry.ToShortDateString + vbCrLf +
                                                "Description: " + description + vbCrLf +
                                                "Amount Due: RM " + amountDue.ToString() + vbCrLf +
                                                "Amount Paid: RM " + amountPaid.ToString() + vbCrLf +
                                                "Payment Date: " + paymentDate.ToShortDateString, "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If msgBoxResult = MsgBoxResult.Yes Then
                    'Inserts payment record
                    command = New OleDbCommand("INSERT INTO Payment VALUES (@PaymentID, @StudentID, @UnitID, @DateofEntry, @LoggedBy, @Description, @AmountDue, @AmountPaid, @PaymentDate)", con)
                    command.Parameters.AddWithValue("@PaymentID", txtPaymentID.Text)
                    command.Parameters.AddWithValue("@StudentID", studentID)
                    command.Parameters.AddWithValue("@UnitID", unitID)
                    command.Parameters.AddWithValue("@DateofEntry", dateOfEntry)
                    command.Parameters.AddWithValue("@LoggedBy", username)
                    command.Parameters.AddWithValue("@Description", description)
                    command.Parameters.AddWithValue("@AmountDue", CInt(txtAmountDue.Text))
                    command.Parameters.AddWithValue("@AmountPaid", amountPaid)
                    command.Parameters.AddWithValue("@PaymentDate", paymentDate)
                    command.CommandType = CommandType.Text
                    command.ExecuteNonQuery()

                    success1 = True

                    If success1 = True Then
                        MessageBox.Show("Payment Successful.", "Payment Status")

                        If accRegistration = True Then
                            'Shows Register Account form if it is part of the registration process
                            accPaidSuccess = True
                            Me.Visible = False
                            frmRegisterAccount.Visible = True
                        Else
                            'Returns to Main Menu if it is not part of the registration process
                            frmMainMenu.Show()
                        End If

                        Me.Close()
                    End If
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
                If accRegistration = True Then
                    frmRegisterAccount.Visible = True
                Else
                    'Returns to Main Menu form
                    frmMainMenu.Show()
                End If
                Me.Close()
            End If
        Catch ex As ObjectDisposedException
        Catch ex As Exception
            'Display error message 
            MessageBox.Show("Error occurred. Please retry or search the error online:" + vbCrLf +
                            ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDescription_GotFocus(sender As Object, e As EventArgs) Handles txtDescription.GotFocus
        'Clears textbox with example
        If txtDescription.ForeColor = Color.Silver Then
            txtDescription.Clear()
        End If
        txtDescription.ForeColor = Color.White
    End Sub

    Private Sub mskAmountPaid_GotFocus(sender As Object, e As EventArgs) Handles mskAmountPaid.GotFocus
        'Clears textbox with example
        If mskAmountPaid.ForeColor = Color.Silver Then
            mskAmountPaid.Clear()
        End If
        mskAmountPaid.ForeColor = Color.White
    End Sub

    Private Sub txtDescription_LostFocus(sender As Object, e As EventArgs) Handles txtDescription.LostFocus
        'Fills textbox with example
        If txtDescription.Text = "" Then
            If unitID.Contains("S") Then
                txtDescription.Text = "Single Unit"
            ElseIf unitID.Contains("D") Then
                txtDescription.Text = "Double Unit"
            End If
            txtDescription.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub mskAmountPaid_LostFocus(sender As Object, e As EventArgs) Handles mskAmountPaid.LostFocus
        'Fills textbox with example
        If mskAmountPaid.Text = "" Then
            mskAmountPaid.Text = "0"
            mskAmountPaid.ForeColor = Color.Silver
        End If
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