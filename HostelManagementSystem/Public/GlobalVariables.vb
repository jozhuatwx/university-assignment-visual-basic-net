Imports System.Data.OleDb

Module GlobalVariables
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hostel Management System.accdb"
    Public con As OleDbConnection = New OleDbConnection(connectionString)
    Public read As OleDbDataReader
    Public command As OleDbCommand

    Public username, password, role, unitID, unitType, unitStatus, studentID, intakeCode, firstName, lastName, contactNumber, emailAddress, newUnitID, oldUnitID, paymentID, description As String
    Public unitRent, amountDue, amountPaid, amountPaidSum, monthDifference, yearDifference, intPaidMonth, intPaidYear, intPaymentID, intOccupyingMonth, intOccupyingYear As Integer
    Public occupyingDate, dateOfEntry, paymentDate, lastPaidMonth, lastPaidYear As Date
    Public success1, success2, success3, accRegistration, accPaidSuccess As Boolean

    Public msgBoxResult As MsgBoxResult
End Module
