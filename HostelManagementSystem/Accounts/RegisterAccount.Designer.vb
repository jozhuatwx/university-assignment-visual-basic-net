<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegisterAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblStudentID As System.Windows.Forms.Label
        Dim lblIntakeCode As System.Windows.Forms.Label
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblContactNumber As System.Windows.Forms.Label
        Dim lblEmailAddress As System.Windows.Forms.Label
        Dim lblUnitID As System.Windows.Forms.Label
        Dim lblOccupyingDate As System.Windows.Forms.Label
        Dim lblUnitType As System.Windows.Forms.Label
        Dim lblUnitRent As System.Windows.Forms.Label
        Dim lblStatus As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegisterAccount))
        Me.lblStudentRegistration = New System.Windows.Forms.Label()
        Me.txtIntakeCode = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dtpOccupyingDate = New System.Windows.Forms.DateTimePicker()
        Me.Hostel_Management_SystemDataSet = New HostelManagementSystem.Hostel_Management_SystemDataSet()
        Me.cboUnitID = New System.Windows.Forms.ComboBox()
        Me.HostelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.lblHostelRegistration = New System.Windows.Forms.Label()
        Me.HostelTableAdapter = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.HostelTableAdapter()
        Me.TableAdapterManager = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager()
        Me.pnlHostelRegistration = New System.Windows.Forms.Panel()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.pnlUnitType = New System.Windows.Forms.Panel()
        Me.txtUnitType = New System.Windows.Forms.TextBox()
        Me.pnlUnitRent = New System.Windows.Forms.Panel()
        Me.txtUnitRent = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlStudentRegistration = New System.Windows.Forms.Panel()
        Me.pnlStudentID = New System.Windows.Forms.Panel()
        Me.mskStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.pnlIntakeCode = New System.Windows.Forms.Panel()
        Me.pnlFirstName = New System.Windows.Forms.Panel()
        Me.pnlLastName = New System.Windows.Forms.Panel()
        Me.pnlEmailAddress = New System.Windows.Forms.Panel()
        Me.pnlContactNumber = New System.Windows.Forms.Panel()
        Me.mskContactNumber = New System.Windows.Forms.MaskedTextBox()
        Me.pnlTitlebar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHowdy = New System.Windows.Forms.Label()
        lblStudentID = New System.Windows.Forms.Label()
        lblIntakeCode = New System.Windows.Forms.Label()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblContactNumber = New System.Windows.Forms.Label()
        lblEmailAddress = New System.Windows.Forms.Label()
        lblUnitID = New System.Windows.Forms.Label()
        lblOccupyingDate = New System.Windows.Forms.Label()
        lblUnitType = New System.Windows.Forms.Label()
        lblUnitRent = New System.Windows.Forms.Label()
        lblStatus = New System.Windows.Forms.Label()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HostelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHostelRegistration.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlUnitType.SuspendLayout()
        Me.pnlUnitRent.SuspendLayout()
        Me.pnlStudentRegistration.SuspendLayout()
        Me.pnlStudentID.SuspendLayout()
        Me.pnlIntakeCode.SuspendLayout()
        Me.pnlFirstName.SuspendLayout()
        Me.pnlLastName.SuspendLayout()
        Me.pnlEmailAddress.SuspendLayout()
        Me.pnlContactNumber.SuspendLayout()
        Me.pnlTitlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStudentID
        '
        lblStudentID.AutoSize = True
        lblStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStudentID.Location = New System.Drawing.Point(33, 64)
        lblStudentID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New System.Drawing.Size(104, 25)
        lblStudentID.TabIndex = 0
        lblStudentID.Text = "Student ID"
        '
        'lblIntakeCode
        '
        lblIntakeCode.AutoSize = True
        lblIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblIntakeCode.Location = New System.Drawing.Point(300, 64)
        lblIntakeCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblIntakeCode.Name = "lblIntakeCode"
        lblIntakeCode.Size = New System.Drawing.Size(118, 25)
        lblIntakeCode.TabIndex = 0
        lblIntakeCode.Text = "Intake Code"
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFirstName.Location = New System.Drawing.Point(33, 160)
        lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(106, 25)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLastName.Location = New System.Drawing.Point(351, 160)
        lblLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(106, 25)
        lblLastName.TabIndex = 0
        lblLastName.Text = "Last Name"
        '
        'lblContactNumber
        '
        lblContactNumber.AutoSize = True
        lblContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblContactNumber.Location = New System.Drawing.Point(33, 352)
        lblContactNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New System.Drawing.Size(154, 25)
        lblContactNumber.TabIndex = 0
        lblContactNumber.Text = "Contact Number"
        '
        'lblEmailAddress
        '
        lblEmailAddress.AutoSize = True
        lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEmailAddress.Location = New System.Drawing.Point(33, 256)
        lblEmailAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblEmailAddress.Name = "lblEmailAddress"
        lblEmailAddress.Size = New System.Drawing.Size(145, 25)
        lblEmailAddress.TabIndex = 0
        lblEmailAddress.Text = "E-mail Address"
        '
        'lblUnitID
        '
        lblUnitID.AutoSize = True
        lblUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUnitID.Location = New System.Drawing.Point(33, 64)
        lblUnitID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblUnitID.Name = "lblUnitID"
        lblUnitID.Size = New System.Drawing.Size(70, 25)
        lblUnitID.TabIndex = 0
        lblUnitID.Text = "Unit ID"
        '
        'lblOccupyingDate
        '
        lblOccupyingDate.AutoSize = True
        lblOccupyingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblOccupyingDate.Location = New System.Drawing.Point(33, 256)
        lblOccupyingDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblOccupyingDate.Name = "lblOccupyingDate"
        lblOccupyingDate.Size = New System.Drawing.Size(152, 25)
        lblOccupyingDate.TabIndex = 0
        lblOccupyingDate.Text = "Occupying Date"
        '
        'lblUnitType
        '
        lblUnitType.AutoSize = True
        lblUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUnitType.Location = New System.Drawing.Point(367, 256)
        lblUnitType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblUnitType.Name = "lblUnitType"
        lblUnitType.Size = New System.Drawing.Size(96, 25)
        lblUnitType.TabIndex = 0
        lblUnitType.Text = "Unit Type"
        '
        'lblUnitRent
        '
        lblUnitRent.AutoSize = True
        lblUnitRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUnitRent.Location = New System.Drawing.Point(367, 160)
        lblUnitRent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblUnitRent.Name = "lblUnitRent"
        lblUnitRent.Size = New System.Drawing.Size(140, 25)
        lblUnitRent.TabIndex = 0
        lblUnitRent.Text = "Unit Rent (RM)"
        '
        'lblStatus
        '
        lblStatus.AutoSize = True
        lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStatus.Location = New System.Drawing.Point(316, 64)
        lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New System.Drawing.Size(68, 25)
        lblStatus.TabIndex = 0
        lblStatus.Text = "Status"
        '
        'lblStudentRegistration
        '
        Me.lblStudentRegistration.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStudentRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentRegistration.Location = New System.Drawing.Point(0, 0)
        Me.lblStudentRegistration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStudentRegistration.Name = "lblStudentRegistration"
        Me.lblStudentRegistration.Size = New System.Drawing.Size(667, 48)
        Me.lblStudentRegistration.TabIndex = 30
        Me.lblStudentRegistration.Text = "Student Registration"
        Me.lblStudentRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIntakeCode
        '
        Me.txtIntakeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtIntakeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIntakeCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeCode.ForeColor = System.Drawing.Color.White
        Me.txtIntakeCode.Location = New System.Drawing.Point(9, 9)
        Me.txtIntakeCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIntakeCode.MaxLength = 18
        Me.txtIntakeCode.Name = "txtIntakeCode"
        Me.txtIntakeCode.Size = New System.Drawing.Size(300, 23)
        Me.txtIntakeCode.TabIndex = 0
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.White
        Me.txtFirstName.Location = New System.Drawing.Point(9, 9)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(249, 23)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.White
        Me.txtLastName.Location = New System.Drawing.Point(9, 9)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(249, 23)
        Me.txtLastName.TabIndex = 0
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.White
        Me.txtEmailAddress.Location = New System.Drawing.Point(9, 9)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(316, 23)
        Me.txtEmailAddress.TabIndex = 0
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(417, 512)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(217, 54)
        Me.btnRegister.TabIndex = 0
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(33, 512)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(217, 54)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dtpOccupyingDate
        '
        Me.dtpOccupyingDate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.dtpOccupyingDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.dtpOccupyingDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.dtpOccupyingDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.dtpOccupyingDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.dtpOccupyingDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpOccupyingDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpOccupyingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOccupyingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOccupyingDate.Location = New System.Drawing.Point(33, 288)
        Me.dtpOccupyingDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpOccupyingDate.MinimumSize = New System.Drawing.Size(251, 45)
        Me.dtpOccupyingDate.Name = "dtpOccupyingDate"
        Me.dtpOccupyingDate.Size = New System.Drawing.Size(251, 45)
        Me.dtpOccupyingDate.TabIndex = 0
        '
        'Hostel_Management_SystemDataSet
        '
        Me.Hostel_Management_SystemDataSet.DataSetName = "Hostel_Management_SystemDataSet"
        Me.Hostel_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboUnitID
        '
        Me.cboUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cboUnitID.DataSource = Me.HostelBindingSource
        Me.cboUnitID.DisplayMember = "UnitID"
        Me.cboUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnitID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnitID.ForeColor = System.Drawing.Color.White
        Me.cboUnitID.FormattingEnabled = True
        Me.cboUnitID.Location = New System.Drawing.Point(33, 102)
        Me.cboUnitID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboUnitID.Name = "cboUnitID"
        Me.cboUnitID.Size = New System.Drawing.Size(219, 33)
        Me.cboUnitID.TabIndex = 0
        '
        'HostelBindingSource
        '
        Me.HostelBindingSource.DataMember = "Hostel"
        Me.HostelBindingSource.DataSource = Me.Hostel_Management_SystemDataSet
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnProceed.FlatAppearance.BorderSize = 0
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(417, 512)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(217, 54)
        Me.btnProceed.TabIndex = 0
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'lblHostelRegistration
        '
        Me.lblHostelRegistration.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHostelRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHostelRegistration.Location = New System.Drawing.Point(0, 0)
        Me.lblHostelRegistration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHostelRegistration.Name = "lblHostelRegistration"
        Me.lblHostelRegistration.Size = New System.Drawing.Size(667, 48)
        Me.lblHostelRegistration.TabIndex = 0
        Me.lblHostelRegistration.Text = "Hostel Registration"
        Me.lblHostelRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HostelTableAdapter
        '
        Me.HostelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CredentialsTableAdapter = Nothing
        Me.TableAdapterManager.HostelTableAdapter = Me.HostelTableAdapter
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.StudentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'pnlHostelRegistration
        '
        Me.pnlHostelRegistration.Controls.Add(Me.lblHostelRegistration)
        Me.pnlHostelRegistration.Controls.Add(lblUnitID)
        Me.pnlHostelRegistration.Controls.Add(Me.cboUnitID)
        Me.pnlHostelRegistration.Controls.Add(lblStatus)
        Me.pnlHostelRegistration.Controls.Add(Me.pnlStatus)
        Me.pnlHostelRegistration.Controls.Add(lblUnitType)
        Me.pnlHostelRegistration.Controls.Add(Me.pnlUnitType)
        Me.pnlHostelRegistration.Controls.Add(lblUnitRent)
        Me.pnlHostelRegistration.Controls.Add(Me.pnlUnitRent)
        Me.pnlHostelRegistration.Controls.Add(lblOccupyingDate)
        Me.pnlHostelRegistration.Controls.Add(Me.dtpOccupyingDate)
        Me.pnlHostelRegistration.Controls.Add(Me.btnProceed)
        Me.pnlHostelRegistration.Controls.Add(Me.btnCancel)
        Me.pnlHostelRegistration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHostelRegistration.Location = New System.Drawing.Point(0, 64)
        Me.pnlHostelRegistration.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.pnlHostelRegistration.Name = "pnlHostelRegistration"
        Me.pnlHostelRegistration.Size = New System.Drawing.Size(667, 608)
        Me.pnlHostelRegistration.TabIndex = 58
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlStatus.Controls.Add(Me.txtStatus)
        Me.pnlStatus.Location = New System.Drawing.Point(316, 96)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(300, 42)
        Me.pnlStatus.TabIndex = 0
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HostelBindingSource, "Status", True))
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.Silver
        Me.txtStatus.Location = New System.Drawing.Point(9, 9)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(284, 23)
        Me.txtStatus.TabIndex = 0
        Me.txtStatus.TabStop = False
        '
        'pnlUnitType
        '
        Me.pnlUnitType.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlUnitType.Controls.Add(Me.txtUnitType)
        Me.pnlUnitType.Location = New System.Drawing.Point(367, 288)
        Me.pnlUnitType.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlUnitType.Name = "pnlUnitType"
        Me.pnlUnitType.Size = New System.Drawing.Size(249, 42)
        Me.pnlUnitType.TabIndex = 0
        '
        'txtUnitType
        '
        Me.txtUnitType.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtUnitType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnitType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HostelBindingSource, "UnitType", True))
        Me.txtUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitType.ForeColor = System.Drawing.Color.Silver
        Me.txtUnitType.Location = New System.Drawing.Point(9, 9)
        Me.txtUnitType.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUnitType.Name = "txtUnitType"
        Me.txtUnitType.ReadOnly = True
        Me.txtUnitType.Size = New System.Drawing.Size(233, 23)
        Me.txtUnitType.TabIndex = 0
        Me.txtUnitType.TabStop = False
        '
        'pnlUnitRent
        '
        Me.pnlUnitRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlUnitRent.Controls.Add(Me.txtUnitRent)
        Me.pnlUnitRent.Location = New System.Drawing.Point(367, 192)
        Me.pnlUnitRent.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlUnitRent.Name = "pnlUnitRent"
        Me.pnlUnitRent.Size = New System.Drawing.Size(249, 42)
        Me.pnlUnitRent.TabIndex = 0
        '
        'txtUnitRent
        '
        Me.txtUnitRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtUnitRent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnitRent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HostelBindingSource, "UnitRent", True))
        Me.txtUnitRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitRent.ForeColor = System.Drawing.Color.Silver
        Me.txtUnitRent.Location = New System.Drawing.Point(8, 9)
        Me.txtUnitRent.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUnitRent.Name = "txtUnitRent"
        Me.txtUnitRent.ReadOnly = True
        Me.txtUnitRent.Size = New System.Drawing.Size(233, 23)
        Me.txtUnitRent.TabIndex = 0
        Me.txtUnitRent.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(33, 512)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(217, 54)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pnlStudentRegistration
        '
        Me.pnlStudentRegistration.Controls.Add(Me.lblStudentRegistration)
        Me.pnlStudentRegistration.Controls.Add(lblStudentID)
        Me.pnlStudentRegistration.Controls.Add(Me.pnlStudentID)
        Me.pnlStudentRegistration.Controls.Add(lblIntakeCode)
        Me.pnlStudentRegistration.Controls.Add(Me.pnlIntakeCode)
        Me.pnlStudentRegistration.Controls.Add(lblFirstName)
        Me.pnlStudentRegistration.Controls.Add(Me.pnlFirstName)
        Me.pnlStudentRegistration.Controls.Add(lblLastName)
        Me.pnlStudentRegistration.Controls.Add(Me.pnlLastName)
        Me.pnlStudentRegistration.Controls.Add(lblEmailAddress)
        Me.pnlStudentRegistration.Controls.Add(Me.pnlEmailAddress)
        Me.pnlStudentRegistration.Controls.Add(lblContactNumber)
        Me.pnlStudentRegistration.Controls.Add(Me.pnlContactNumber)
        Me.pnlStudentRegistration.Controls.Add(Me.btnRegister)
        Me.pnlStudentRegistration.Controls.Add(Me.btnBack)
        Me.pnlStudentRegistration.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStudentRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlStudentRegistration.Location = New System.Drawing.Point(0, 64)
        Me.pnlStudentRegistration.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.pnlStudentRegistration.Name = "pnlStudentRegistration"
        Me.pnlStudentRegistration.Size = New System.Drawing.Size(667, 608)
        Me.pnlStudentRegistration.TabIndex = 59
        Me.pnlStudentRegistration.Visible = False
        '
        'pnlStudentID
        '
        Me.pnlStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlStudentID.Controls.Add(Me.mskStudentID)
        Me.pnlStudentID.Location = New System.Drawing.Point(33, 96)
        Me.pnlStudentID.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlStudentID.Name = "pnlStudentID"
        Me.pnlStudentID.Size = New System.Drawing.Size(217, 42)
        Me.pnlStudentID.TabIndex = 0
        '
        'mskStudentID
        '
        Me.mskStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.mskStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentID.ForeColor = System.Drawing.Color.White
        Me.mskStudentID.Location = New System.Drawing.Point(9, 9)
        Me.mskStudentID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskStudentID.Mask = "TP000000"
        Me.mskStudentID.Name = "mskStudentID"
        Me.mskStudentID.Size = New System.Drawing.Size(200, 23)
        Me.mskStudentID.TabIndex = 0
        '
        'pnlIntakeCode
        '
        Me.pnlIntakeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlIntakeCode.Controls.Add(Me.txtIntakeCode)
        Me.pnlIntakeCode.Location = New System.Drawing.Point(300, 96)
        Me.pnlIntakeCode.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlIntakeCode.Name = "pnlIntakeCode"
        Me.pnlIntakeCode.Size = New System.Drawing.Size(316, 42)
        Me.pnlIntakeCode.TabIndex = 0
        '
        'pnlFirstName
        '
        Me.pnlFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlFirstName.Controls.Add(Me.txtFirstName)
        Me.pnlFirstName.Location = New System.Drawing.Point(33, 192)
        Me.pnlFirstName.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlFirstName.Name = "pnlFirstName"
        Me.pnlFirstName.Size = New System.Drawing.Size(267, 42)
        Me.pnlFirstName.TabIndex = 0
        '
        'pnlLastName
        '
        Me.pnlLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlLastName.Controls.Add(Me.txtLastName)
        Me.pnlLastName.Location = New System.Drawing.Point(351, 192)
        Me.pnlLastName.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlLastName.Name = "pnlLastName"
        Me.pnlLastName.Size = New System.Drawing.Size(267, 42)
        Me.pnlLastName.TabIndex = 0
        '
        'pnlEmailAddress
        '
        Me.pnlEmailAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlEmailAddress.Controls.Add(Me.txtEmailAddress)
        Me.pnlEmailAddress.Location = New System.Drawing.Point(33, 288)
        Me.pnlEmailAddress.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlEmailAddress.Name = "pnlEmailAddress"
        Me.pnlEmailAddress.Size = New System.Drawing.Size(333, 42)
        Me.pnlEmailAddress.TabIndex = 0
        '
        'pnlContactNumber
        '
        Me.pnlContactNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlContactNumber.Controls.Add(Me.mskContactNumber)
        Me.pnlContactNumber.Location = New System.Drawing.Point(33, 391)
        Me.pnlContactNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlContactNumber.Name = "pnlContactNumber"
        Me.pnlContactNumber.Size = New System.Drawing.Size(233, 42)
        Me.pnlContactNumber.TabIndex = 0
        '
        'mskContactNumber
        '
        Me.mskContactNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.mskContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskContactNumber.ForeColor = System.Drawing.Color.White
        Me.mskContactNumber.Location = New System.Drawing.Point(9, 9)
        Me.mskContactNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskContactNumber.Mask = "000-00000000"
        Me.mskContactNumber.Name = "mskContactNumber"
        Me.mskContactNumber.Size = New System.Drawing.Size(217, 23)
        Me.mskContactNumber.TabIndex = 0
        '
        'pnlTitlebar
        '
        Me.pnlTitlebar.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitlebar.Controls.Add(Me.btnMinimize)
        Me.pnlTitlebar.Controls.Add(Me.btnClose)
        Me.pnlTitlebar.Controls.Add(Me.lblTitle)
        Me.pnlTitlebar.Controls.Add(Me.lblHowdy)
        Me.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitlebar.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.pnlTitlebar.Name = "pnlTitlebar"
        Me.pnlTitlebar.Size = New System.Drawing.Size(667, 64)
        Me.pnlTitlebar.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(560, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(53, 32)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(613, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(53, 32)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(667, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Register Account"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHowdy
        '
        Me.lblHowdy.BackColor = System.Drawing.Color.Transparent
        Me.lblHowdy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHowdy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowdy.Location = New System.Drawing.Point(0, 32)
        Me.lblHowdy.Name = "lblHowdy"
        Me.lblHowdy.Size = New System.Drawing.Size(667, 32)
        Me.lblHowdy.TabIndex = 0
        Me.lblHowdy.Text = "Howdy again, User! Welcome to"
        Me.lblHowdy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmRegisterAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(667, 672)
        Me.Controls.Add(Me.pnlStudentRegistration)
        Me.Controls.Add(Me.pnlHostelRegistration)
        Me.Controls.Add(Me.pnlTitlebar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.MinimumSize = New System.Drawing.Size(667, 672)
        Me.Name = "frmRegisterAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Account"
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HostelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHostelRegistration.ResumeLayout(False)
        Me.pnlHostelRegistration.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlUnitType.ResumeLayout(False)
        Me.pnlUnitType.PerformLayout()
        Me.pnlUnitRent.ResumeLayout(False)
        Me.pnlUnitRent.PerformLayout()
        Me.pnlStudentRegistration.ResumeLayout(False)
        Me.pnlStudentRegistration.PerformLayout()
        Me.pnlStudentID.ResumeLayout(False)
        Me.pnlStudentID.PerformLayout()
        Me.pnlIntakeCode.ResumeLayout(False)
        Me.pnlIntakeCode.PerformLayout()
        Me.pnlFirstName.ResumeLayout(False)
        Me.pnlFirstName.PerformLayout()
        Me.pnlLastName.ResumeLayout(False)
        Me.pnlLastName.PerformLayout()
        Me.pnlEmailAddress.ResumeLayout(False)
        Me.pnlEmailAddress.PerformLayout()
        Me.pnlContactNumber.ResumeLayout(False)
        Me.pnlContactNumber.PerformLayout()
        Me.pnlTitlebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblStudentRegistration As Label
    Friend WithEvents txtIntakeCode As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dtpOccupyingDate As DateTimePicker
    Friend WithEvents cboUnitID As ComboBox
    Friend WithEvents Hostel_Management_SystemDataSet As Hostel_Management_SystemDataSet
    Friend WithEvents btnProceed As Button
    Friend WithEvents lblHostelRegistration As Label
    Friend WithEvents HostelBindingSource As BindingSource
    Friend WithEvents HostelTableAdapter As Hostel_Management_SystemDataSetTableAdapters.HostelTableAdapter
    Friend WithEvents TableAdapterManager As Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents pnlHostelRegistration As Panel
    Friend WithEvents pnlStudentRegistration As Panel
    Friend WithEvents pnlTitlebar As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblHowdy As Label
    Friend WithEvents mskContactNumber As MaskedTextBox
    Friend WithEvents pnlStudentID As Panel
    Friend WithEvents pnlIntakeCode As Panel
    Friend WithEvents pnlContactNumber As Panel
    Friend WithEvents pnlEmailAddress As Panel
    Friend WithEvents pnlLastName As Panel
    Friend WithEvents pnlFirstName As Panel
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents pnlUnitRent As Panel
    Friend WithEvents txtUnitRent As TextBox
    Friend WithEvents pnlUnitType As Panel
    Friend WithEvents txtUnitType As TextBox
    Friend WithEvents mskStudentID As MaskedTextBox
    Friend WithEvents btnMinimize As Button
End Class
