<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdateAccount
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
        Dim lblUnitID As System.Windows.Forms.Label
        Dim lblStudentID As System.Windows.Forms.Label
        Dim lblIntakeCode As System.Windows.Forms.Label
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblContactNumber As System.Windows.Forms.Label
        Dim lblEmailAddress As System.Windows.Forms.Label
        Dim lblOldUnitID As System.Windows.Forms.Label
        Dim lblNewUnitID As System.Windows.Forms.Label
        Dim lblOccupyingDate As System.Windows.Forms.Label
        Dim lblUnitType As System.Windows.Forms.Label
        Dim lblUnitRent As System.Windows.Forms.Label
        Dim lblStatus As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateAccount))
        Me.txtUnitID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblStudRecMod = New System.Windows.Forms.Label()
        Me.txtOldUnitID = New System.Windows.Forms.TextBox()
        Me.Hostel_Management_SystemDataSet = New HostelManagementSystem.Hostel_Management_SystemDataSet()
        Me.cboNewUnitID = New System.Windows.Forms.ComboBox()
        Me.HostelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblHosRecMod = New System.Windows.Forms.Label()
        Me.pnlTitlebar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHowdy = New System.Windows.Forms.Label()
        Me.pnlStudRecMod = New System.Windows.Forms.Panel()
        Me.pnlStudentID = New System.Windows.Forms.Panel()
        Me.mskStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.pnlFirstName = New System.Windows.Forms.Panel()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.pnlLastName = New System.Windows.Forms.Panel()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.pnlEmailAddress = New System.Windows.Forms.Panel()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.pnlContactNumber = New System.Windows.Forms.Panel()
        Me.mskContactNumber = New System.Windows.Forms.MaskedTextBox()
        Me.pnlIntakeCode = New System.Windows.Forms.Panel()
        Me.txtIntakeCode = New System.Windows.Forms.TextBox()
        Me.pnlUnitID = New System.Windows.Forms.Panel()
        Me.pnlHosRecMod = New System.Windows.Forms.Panel()
        Me.pnlOldUnitID = New System.Windows.Forms.Panel()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.txtSameUnit = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.pnlUnitRent = New System.Windows.Forms.Panel()
        Me.lblUnitRentRM = New System.Windows.Forms.Label()
        Me.txtUnitRent = New System.Windows.Forms.TextBox()
        Me.dtpOccupyingDate = New System.Windows.Forms.DateTimePicker()
        Me.pnlUnitType = New System.Windows.Forms.Panel()
        Me.txtUnitType = New System.Windows.Forms.TextBox()
        Me.TableAdapterManager = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager()
        Me.HostelTableAdapter = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.HostelTableAdapter()
        lblUnitID = New System.Windows.Forms.Label()
        lblStudentID = New System.Windows.Forms.Label()
        lblIntakeCode = New System.Windows.Forms.Label()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblContactNumber = New System.Windows.Forms.Label()
        lblEmailAddress = New System.Windows.Forms.Label()
        lblOldUnitID = New System.Windows.Forms.Label()
        lblNewUnitID = New System.Windows.Forms.Label()
        lblOccupyingDate = New System.Windows.Forms.Label()
        lblUnitType = New System.Windows.Forms.Label()
        lblUnitRent = New System.Windows.Forms.Label()
        lblStatus = New System.Windows.Forms.Label()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HostelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitlebar.SuspendLayout()
        Me.pnlStudRecMod.SuspendLayout()
        Me.pnlStudentID.SuspendLayout()
        Me.pnlFirstName.SuspendLayout()
        Me.pnlLastName.SuspendLayout()
        Me.pnlEmailAddress.SuspendLayout()
        Me.pnlContactNumber.SuspendLayout()
        Me.pnlIntakeCode.SuspendLayout()
        Me.pnlUnitID.SuspendLayout()
        Me.pnlHosRecMod.SuspendLayout()
        Me.pnlOldUnitID.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlUnitRent.SuspendLayout()
        Me.pnlUnitType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUnitID
        '
        lblUnitID.AutoSize = True
        lblUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUnitID.Location = New System.Drawing.Point(287, 286)
        lblUnitID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblUnitID.Name = "lblUnitID"
        lblUnitID.Size = New System.Drawing.Size(59, 20)
        lblUnitID.TabIndex = 0
        lblUnitID.Text = "Unit ID"
        '
        'lblStudentID
        '
        lblStudentID.AutoSize = True
        lblStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStudentID.Location = New System.Drawing.Point(25, 52)
        lblStudentID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New System.Drawing.Size(87, 20)
        lblStudentID.TabIndex = 0
        lblStudentID.Text = "Student ID"
        '
        'lblIntakeCode
        '
        lblIntakeCode.AutoSize = True
        lblIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblIntakeCode.Location = New System.Drawing.Point(25, 286)
        lblIntakeCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblIntakeCode.Name = "lblIntakeCode"
        lblIntakeCode.Size = New System.Drawing.Size(96, 20)
        lblIntakeCode.TabIndex = 0
        lblIntakeCode.Text = "Intake Code"
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFirstName.Location = New System.Drawing.Point(25, 130)
        lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(86, 20)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLastName.Location = New System.Drawing.Point(263, 130)
        lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(86, 20)
        lblLastName.TabIndex = 0
        lblLastName.Text = "Last Name"
        '
        'lblContactNumber
        '
        lblContactNumber.AutoSize = True
        lblContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblContactNumber.Location = New System.Drawing.Point(300, 208)
        lblContactNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New System.Drawing.Size(125, 20)
        lblContactNumber.TabIndex = 0
        lblContactNumber.Text = "Contact Number"
        '
        'lblEmailAddress
        '
        lblEmailAddress.AutoSize = True
        lblEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEmailAddress.Location = New System.Drawing.Point(25, 208)
        lblEmailAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblEmailAddress.Name = "lblEmailAddress"
        lblEmailAddress.Size = New System.Drawing.Size(116, 20)
        lblEmailAddress.TabIndex = 42
        lblEmailAddress.Text = "E-mail Address"
        '
        'lblOldUnitID
        '
        lblOldUnitID.AutoSize = True
        lblOldUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblOldUnitID.Location = New System.Drawing.Point(25, 52)
        lblOldUnitID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblOldUnitID.Name = "lblOldUnitID"
        lblOldUnitID.Size = New System.Drawing.Size(87, 20)
        lblOldUnitID.TabIndex = 66
        lblOldUnitID.Text = "Old Unit ID"
        '
        'lblNewUnitID
        '
        lblNewUnitID.AutoSize = True
        lblNewUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblNewUnitID.Location = New System.Drawing.Point(25, 130)
        lblNewUnitID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblNewUnitID.Name = "lblNewUnitID"
        lblNewUnitID.Size = New System.Drawing.Size(94, 20)
        lblNewUnitID.TabIndex = 0
        lblNewUnitID.Text = "New Unit ID"
        '
        'lblOccupyingDate
        '
        lblOccupyingDate.AutoSize = True
        lblOccupyingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblOccupyingDate.Location = New System.Drawing.Point(25, 286)
        lblOccupyingDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblOccupyingDate.Name = "lblOccupyingDate"
        lblOccupyingDate.Size = New System.Drawing.Size(122, 20)
        lblOccupyingDate.TabIndex = 0
        lblOccupyingDate.Text = "Occupying Date"
        '
        'lblUnitType
        '
        lblUnitType.AutoSize = True
        lblUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUnitType.Location = New System.Drawing.Point(275, 286)
        lblUnitType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblUnitType.Name = "lblUnitType"
        lblUnitType.Size = New System.Drawing.Size(76, 20)
        lblUnitType.TabIndex = 0
        lblUnitType.Text = "Unit Type"
        '
        'lblUnitRent
        '
        lblUnitRent.AutoSize = True
        lblUnitRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUnitRent.Location = New System.Drawing.Point(275, 208)
        lblUnitRent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblUnitRent.Name = "lblUnitRent"
        lblUnitRent.Size = New System.Drawing.Size(77, 20)
        lblUnitRent.TabIndex = 56
        lblUnitRent.Text = "Unit Rent"
        '
        'lblStatus
        '
        lblStatus.AutoSize = True
        lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStatus.Location = New System.Drawing.Point(238, 130)
        lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New System.Drawing.Size(56, 20)
        lblStatus.TabIndex = 57
        lblStatus.Text = "Status"
        '
        'txtUnitID
        '
        Me.txtUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtUnitID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnitID.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitID.ForeColor = System.Drawing.Color.Silver
        Me.txtUnitID.Location = New System.Drawing.Point(7, 7)
        Me.txtUnitID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtUnitID.Name = "txtUnitID"
        Me.txtUnitID.ReadOnly = True
        Me.txtUnitID.Size = New System.Drawing.Size(163, 19)
        Me.txtUnitID.TabIndex = 0
        Me.txtUnitID.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(192, 78)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 34)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnProceed.FlatAppearance.BorderSize = 0
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(313, 416)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(163, 44)
        Me.btnProceed.TabIndex = 49
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(25, 416)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(163, 44)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblStudRecMod
        '
        Me.lblStudRecMod.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStudRecMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudRecMod.Location = New System.Drawing.Point(0, 0)
        Me.lblStudRecMod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudRecMod.Name = "lblStudRecMod"
        Me.lblStudRecMod.Size = New System.Drawing.Size(500, 39)
        Me.lblStudRecMod.TabIndex = 35
        Me.lblStudRecMod.Text = "Student Records Modification"
        Me.lblStudRecMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOldUnitID
        '
        Me.txtOldUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtOldUnitID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldUnitID.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtOldUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldUnitID.ForeColor = System.Drawing.Color.Silver
        Me.txtOldUnitID.Location = New System.Drawing.Point(7, 7)
        Me.txtOldUnitID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtOldUnitID.Name = "txtOldUnitID"
        Me.txtOldUnitID.ReadOnly = True
        Me.txtOldUnitID.Size = New System.Drawing.Size(163, 19)
        Me.txtOldUnitID.TabIndex = 0
        Me.txtOldUnitID.TabStop = False
        '
        'Hostel_Management_SystemDataSet
        '
        Me.Hostel_Management_SystemDataSet.DataSetName = "Hostel_Management_SystemDataSet"
        Me.Hostel_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboNewUnitID
        '
        Me.cboNewUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cboNewUnitID.DataSource = Me.HostelBindingSource
        Me.cboNewUnitID.DisplayMember = "UnitID"
        Me.cboNewUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNewUnitID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNewUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNewUnitID.ForeColor = System.Drawing.Color.White
        Me.cboNewUnitID.FormattingEnabled = True
        Me.cboNewUnitID.Location = New System.Drawing.Point(25, 162)
        Me.cboNewUnitID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cboNewUnitID.Name = "cboNewUnitID"
        Me.cboNewUnitID.Size = New System.Drawing.Size(165, 28)
        Me.cboNewUnitID.TabIndex = 61
        '
        'HostelBindingSource
        '
        Me.HostelBindingSource.DataMember = "Hostel"
        Me.HostelBindingSource.DataSource = Me.Hostel_Management_SystemDataSet
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(25, 416)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(163, 44)
        Me.btnBack.TabIndex = 60
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(313, 416)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(163, 44)
        Me.btnUpdate.TabIndex = 59
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblHosRecMod
        '
        Me.lblHosRecMod.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHosRecMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHosRecMod.Location = New System.Drawing.Point(0, 0)
        Me.lblHosRecMod.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHosRecMod.Name = "lblHosRecMod"
        Me.lblHosRecMod.Size = New System.Drawing.Size(500, 39)
        Me.lblHosRecMod.TabIndex = 58
        Me.lblHosRecMod.Text = "Hostel Records Modification"
        Me.lblHosRecMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTitlebar
        '
        Me.pnlTitlebar.Controls.Add(Me.btnMinimize)
        Me.pnlTitlebar.Controls.Add(Me.btnClose)
        Me.pnlTitlebar.Controls.Add(Me.lblTitle)
        Me.pnlTitlebar.Controls.Add(Me.lblHowdy)
        Me.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitlebar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlTitlebar.Name = "pnlTitlebar"
        Me.pnlTitlebar.Size = New System.Drawing.Size(500, 52)
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
        Me.btnMinimize.Location = New System.Drawing.Point(420, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 26)
        Me.btnMinimize.TabIndex = 1
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
        Me.btnClose.Location = New System.Drawing.Point(460, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 26)
        Me.btnClose.TabIndex = 0
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
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Update Account"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHowdy
        '
        Me.lblHowdy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHowdy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowdy.Location = New System.Drawing.Point(0, 26)
        Me.lblHowdy.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHowdy.Name = "lblHowdy"
        Me.lblHowdy.Size = New System.Drawing.Size(500, 26)
        Me.lblHowdy.TabIndex = 0
        Me.lblHowdy.Text = "Howdy again, User! Welcome to"
        Me.lblHowdy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pnlStudRecMod
        '
        Me.pnlStudRecMod.Controls.Add(Me.lblStudRecMod)
        Me.pnlStudRecMod.Controls.Add(lblStudentID)
        Me.pnlStudRecMod.Controls.Add(Me.pnlStudentID)
        Me.pnlStudRecMod.Controls.Add(Me.btnSearch)
        Me.pnlStudRecMod.Controls.Add(lblFirstName)
        Me.pnlStudRecMod.Controls.Add(Me.pnlFirstName)
        Me.pnlStudRecMod.Controls.Add(lblLastName)
        Me.pnlStudRecMod.Controls.Add(Me.pnlLastName)
        Me.pnlStudRecMod.Controls.Add(lblEmailAddress)
        Me.pnlStudRecMod.Controls.Add(Me.pnlEmailAddress)
        Me.pnlStudRecMod.Controls.Add(lblContactNumber)
        Me.pnlStudRecMod.Controls.Add(Me.pnlContactNumber)
        Me.pnlStudRecMod.Controls.Add(lblIntakeCode)
        Me.pnlStudRecMod.Controls.Add(Me.pnlIntakeCode)
        Me.pnlStudRecMod.Controls.Add(lblUnitID)
        Me.pnlStudRecMod.Controls.Add(Me.pnlUnitID)
        Me.pnlStudRecMod.Controls.Add(Me.btnProceed)
        Me.pnlStudRecMod.Controls.Add(Me.btnCancel)
        Me.pnlStudRecMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStudRecMod.Location = New System.Drawing.Point(0, 52)
        Me.pnlStudRecMod.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlStudRecMod.Name = "pnlStudRecMod"
        Me.pnlStudRecMod.Size = New System.Drawing.Size(500, 494)
        Me.pnlStudRecMod.TabIndex = 69
        '
        'pnlStudentID
        '
        Me.pnlStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlStudentID.Controls.Add(Me.mskStudentID)
        Me.pnlStudentID.Location = New System.Drawing.Point(25, 78)
        Me.pnlStudentID.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlStudentID.Name = "pnlStudentID"
        Me.pnlStudentID.Size = New System.Drawing.Size(163, 34)
        Me.pnlStudentID.TabIndex = 53
        '
        'mskStudentID
        '
        Me.mskStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.mskStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentID.ForeColor = System.Drawing.Color.White
        Me.mskStudentID.Location = New System.Drawing.Point(7, 7)
        Me.mskStudentID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.mskStudentID.Mask = "TP000000"
        Me.mskStudentID.Name = "mskStudentID"
        Me.mskStudentID.Size = New System.Drawing.Size(150, 19)
        Me.mskStudentID.TabIndex = 1
        '
        'pnlFirstName
        '
        Me.pnlFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlFirstName.Controls.Add(Me.txtFirstName)
        Me.pnlFirstName.Location = New System.Drawing.Point(25, 156)
        Me.pnlFirstName.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlFirstName.Name = "pnlFirstName"
        Me.pnlFirstName.Size = New System.Drawing.Size(200, 34)
        Me.pnlFirstName.TabIndex = 55
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Silver
        Me.txtFirstName.Location = New System.Drawing.Point(7, 7)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(187, 19)
        Me.txtFirstName.TabIndex = 0
        Me.txtFirstName.TabStop = False
        '
        'pnlLastName
        '
        Me.pnlLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlLastName.Controls.Add(Me.txtLastName)
        Me.pnlLastName.Location = New System.Drawing.Point(266, 156)
        Me.pnlLastName.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlLastName.Name = "pnlLastName"
        Me.pnlLastName.Size = New System.Drawing.Size(200, 34)
        Me.pnlLastName.TabIndex = 56
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Silver
        Me.txtLastName.Location = New System.Drawing.Point(7, 7)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(187, 19)
        Me.txtLastName.TabIndex = 0
        Me.txtLastName.TabStop = False
        '
        'pnlEmailAddress
        '
        Me.pnlEmailAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlEmailAddress.Controls.Add(Me.txtEmailAddress)
        Me.pnlEmailAddress.Location = New System.Drawing.Point(25, 234)
        Me.pnlEmailAddress.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlEmailAddress.Name = "pnlEmailAddress"
        Me.pnlEmailAddress.Size = New System.Drawing.Size(238, 34)
        Me.pnlEmailAddress.TabIndex = 0
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailAddress.ForeColor = System.Drawing.Color.White
        Me.txtEmailAddress.Location = New System.Drawing.Point(7, 7)
        Me.txtEmailAddress.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.ReadOnly = True
        Me.txtEmailAddress.Size = New System.Drawing.Size(226, 19)
        Me.txtEmailAddress.TabIndex = 0
        '
        'pnlContactNumber
        '
        Me.pnlContactNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlContactNumber.Controls.Add(Me.mskContactNumber)
        Me.pnlContactNumber.Location = New System.Drawing.Point(300, 234)
        Me.pnlContactNumber.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlContactNumber.Name = "pnlContactNumber"
        Me.pnlContactNumber.Size = New System.Drawing.Size(163, 34)
        Me.pnlContactNumber.TabIndex = 0
        '
        'mskContactNumber
        '
        Me.mskContactNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.mskContactNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskContactNumber.ForeColor = System.Drawing.Color.White
        Me.mskContactNumber.Location = New System.Drawing.Point(7, 7)
        Me.mskContactNumber.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.mskContactNumber.Mask = "000-00000000"
        Me.mskContactNumber.Name = "mskContactNumber"
        Me.mskContactNumber.ReadOnly = True
        Me.mskContactNumber.Size = New System.Drawing.Size(150, 19)
        Me.mskContactNumber.TabIndex = 0
        '
        'pnlIntakeCode
        '
        Me.pnlIntakeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlIntakeCode.Controls.Add(Me.txtIntakeCode)
        Me.pnlIntakeCode.Location = New System.Drawing.Point(25, 312)
        Me.pnlIntakeCode.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlIntakeCode.Name = "pnlIntakeCode"
        Me.pnlIntakeCode.Size = New System.Drawing.Size(226, 34)
        Me.pnlIntakeCode.TabIndex = 0
        '
        'txtIntakeCode
        '
        Me.txtIntakeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtIntakeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIntakeCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeCode.ForeColor = System.Drawing.Color.White
        Me.txtIntakeCode.Location = New System.Drawing.Point(7, 7)
        Me.txtIntakeCode.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtIntakeCode.MaxLength = 18
        Me.txtIntakeCode.Name = "txtIntakeCode"
        Me.txtIntakeCode.ReadOnly = True
        Me.txtIntakeCode.Size = New System.Drawing.Size(212, 19)
        Me.txtIntakeCode.TabIndex = 0
        '
        'pnlUnitID
        '
        Me.pnlUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlUnitID.Controls.Add(Me.txtUnitID)
        Me.pnlUnitID.Location = New System.Drawing.Point(287, 312)
        Me.pnlUnitID.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlUnitID.Name = "pnlUnitID"
        Me.pnlUnitID.Size = New System.Drawing.Size(175, 34)
        Me.pnlUnitID.TabIndex = 0
        '
        'pnlHosRecMod
        '
        Me.pnlHosRecMod.Controls.Add(Me.lblHosRecMod)
        Me.pnlHosRecMod.Controls.Add(lblOldUnitID)
        Me.pnlHosRecMod.Controls.Add(Me.pnlOldUnitID)
        Me.pnlHosRecMod.Controls.Add(lblNewUnitID)
        Me.pnlHosRecMod.Controls.Add(Me.cboNewUnitID)
        Me.pnlHosRecMod.Controls.Add(lblStatus)
        Me.pnlHosRecMod.Controls.Add(Me.pnlStatus)
        Me.pnlHosRecMod.Controls.Add(lblUnitRent)
        Me.pnlHosRecMod.Controls.Add(Me.pnlUnitRent)
        Me.pnlHosRecMod.Controls.Add(lblOccupyingDate)
        Me.pnlHosRecMod.Controls.Add(Me.dtpOccupyingDate)
        Me.pnlHosRecMod.Controls.Add(lblUnitType)
        Me.pnlHosRecMod.Controls.Add(Me.pnlUnitType)
        Me.pnlHosRecMod.Controls.Add(Me.btnUpdate)
        Me.pnlHosRecMod.Controls.Add(Me.btnBack)
        Me.pnlHosRecMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHosRecMod.Location = New System.Drawing.Point(0, 52)
        Me.pnlHosRecMod.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlHosRecMod.Name = "pnlHosRecMod"
        Me.pnlHosRecMod.Size = New System.Drawing.Size(500, 494)
        Me.pnlHosRecMod.TabIndex = 70
        Me.pnlHosRecMod.Visible = False
        '
        'pnlOldUnitID
        '
        Me.pnlOldUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlOldUnitID.Controls.Add(Me.txtOldUnitID)
        Me.pnlOldUnitID.Location = New System.Drawing.Point(25, 78)
        Me.pnlOldUnitID.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlOldUnitID.Name = "pnlOldUnitID"
        Me.pnlOldUnitID.Size = New System.Drawing.Size(175, 34)
        Me.pnlOldUnitID.TabIndex = 0
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlStatus.Controls.Add(Me.txtSameUnit)
        Me.pnlStatus.Controls.Add(Me.txtStatus)
        Me.pnlStatus.Location = New System.Drawing.Point(238, 156)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(226, 34)
        Me.pnlStatus.TabIndex = 0
        '
        'txtSameUnit
        '
        Me.txtSameUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtSameUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSameUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtSameUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSameUnit.ForeColor = System.Drawing.Color.White
        Me.txtSameUnit.Location = New System.Drawing.Point(7, 7)
        Me.txtSameUnit.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSameUnit.Name = "txtSameUnit"
        Me.txtSameUnit.ReadOnly = True
        Me.txtSameUnit.Size = New System.Drawing.Size(212, 19)
        Me.txtSameUnit.TabIndex = 0
        Me.txtSameUnit.TabStop = False
        Me.txtSameUnit.Text = "Same Unit"
        Me.txtSameUnit.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HostelBindingSource, "Status", True))
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.Silver
        Me.txtStatus.Location = New System.Drawing.Point(7, 7)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(212, 19)
        Me.txtStatus.TabIndex = 0
        Me.txtStatus.TabStop = False
        '
        'pnlUnitRent
        '
        Me.pnlUnitRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlUnitRent.Controls.Add(Me.lblUnitRentRM)
        Me.pnlUnitRent.Controls.Add(Me.txtUnitRent)
        Me.pnlUnitRent.Location = New System.Drawing.Point(275, 234)
        Me.pnlUnitRent.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlUnitRent.Name = "pnlUnitRent"
        Me.pnlUnitRent.Size = New System.Drawing.Size(187, 34)
        Me.pnlUnitRent.TabIndex = 0
        '
        'lblUnitRentRM
        '
        Me.lblUnitRentRM.AutoSize = True
        Me.lblUnitRentRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitRentRM.ForeColor = System.Drawing.Color.Silver
        Me.lblUnitRentRM.Location = New System.Drawing.Point(7, 7)
        Me.lblUnitRentRM.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblUnitRentRM.Name = "lblUnitRentRM"
        Me.lblUnitRentRM.Size = New System.Drawing.Size(34, 20)
        Me.lblUnitRentRM.TabIndex = 1
        Me.lblUnitRentRM.Text = "RM"
        '
        'txtUnitRent
        '
        Me.txtUnitRent.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtUnitRent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnitRent.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtUnitRent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HostelBindingSource, "UnitRent", True))
        Me.txtUnitRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitRent.ForeColor = System.Drawing.Color.Silver
        Me.txtUnitRent.Location = New System.Drawing.Point(41, 7)
        Me.txtUnitRent.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUnitRent.Name = "txtUnitRent"
        Me.txtUnitRent.ReadOnly = True
        Me.txtUnitRent.Size = New System.Drawing.Size(140, 19)
        Me.txtUnitRent.TabIndex = 0
        Me.txtUnitRent.TabStop = False
        Me.txtUnitRent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.dtpOccupyingDate.Location = New System.Drawing.Point(25, 312)
        Me.dtpOccupyingDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpOccupyingDate.MinimumSize = New System.Drawing.Size(189, 45)
        Me.dtpOccupyingDate.Name = "dtpOccupyingDate"
        Me.dtpOccupyingDate.Size = New System.Drawing.Size(189, 45)
        Me.dtpOccupyingDate.TabIndex = 0
        '
        'pnlUnitType
        '
        Me.pnlUnitType.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlUnitType.Controls.Add(Me.txtUnitType)
        Me.pnlUnitType.Location = New System.Drawing.Point(275, 312)
        Me.pnlUnitType.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlUnitType.Name = "pnlUnitType"
        Me.pnlUnitType.Size = New System.Drawing.Size(187, 34)
        Me.pnlUnitType.TabIndex = 0
        '
        'txtUnitType
        '
        Me.txtUnitType.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtUnitType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnitType.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtUnitType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HostelBindingSource, "UnitType", True))
        Me.txtUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitType.ForeColor = System.Drawing.Color.Silver
        Me.txtUnitType.Location = New System.Drawing.Point(7, 7)
        Me.txtUnitType.Margin = New System.Windows.Forms.Padding(1)
        Me.txtUnitType.Name = "txtUnitType"
        Me.txtUnitType.ReadOnly = True
        Me.txtUnitType.Size = New System.Drawing.Size(175, 19)
        Me.txtUnitType.TabIndex = 0
        Me.txtUnitType.TabStop = False
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
        'HostelTableAdapter
        '
        Me.HostelTableAdapter.ClearBeforeFill = True
        '
        'frmUpdateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 546)
        Me.Controls.Add(Me.pnlHosRecMod)
        Me.Controls.Add(Me.pnlStudRecMod)
        Me.Controls.Add(Me.pnlTitlebar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MinimumSize = New System.Drawing.Size(500, 534)
        Me.Name = "frmUpdateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Account"
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HostelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitlebar.ResumeLayout(False)
        Me.pnlStudRecMod.ResumeLayout(False)
        Me.pnlStudRecMod.PerformLayout()
        Me.pnlStudentID.ResumeLayout(False)
        Me.pnlStudentID.PerformLayout()
        Me.pnlFirstName.ResumeLayout(False)
        Me.pnlFirstName.PerformLayout()
        Me.pnlLastName.ResumeLayout(False)
        Me.pnlLastName.PerformLayout()
        Me.pnlEmailAddress.ResumeLayout(False)
        Me.pnlEmailAddress.PerformLayout()
        Me.pnlContactNumber.ResumeLayout(False)
        Me.pnlContactNumber.PerformLayout()
        Me.pnlIntakeCode.ResumeLayout(False)
        Me.pnlIntakeCode.PerformLayout()
        Me.pnlUnitID.ResumeLayout(False)
        Me.pnlUnitID.PerformLayout()
        Me.pnlHosRecMod.ResumeLayout(False)
        Me.pnlHosRecMod.PerformLayout()
        Me.pnlOldUnitID.ResumeLayout(False)
        Me.pnlOldUnitID.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlUnitRent.ResumeLayout(False)
        Me.pnlUnitRent.PerformLayout()
        Me.pnlUnitType.ResumeLayout(False)
        Me.pnlUnitType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUnitID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblStudRecMod As Label
    Friend WithEvents txtOldUnitID As TextBox
    Friend WithEvents cboNewUnitID As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblHosRecMod As Label
    Friend WithEvents pnlTitlebar As Panel
    Friend WithEvents lblHowdy As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlStudRecMod As Panel
    Friend WithEvents pnlHosRecMod As Panel
    Friend WithEvents Hostel_Management_SystemDataSet As Hostel_Management_SystemDataSet
    Friend WithEvents TableAdapterManager As Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HostelTableAdapter As Hostel_Management_SystemDataSetTableAdapters.HostelTableAdapter
    Friend WithEvents pnlStudentID As Panel
    Friend WithEvents pnlIntakeCode As Panel
    Friend WithEvents txtIntakeCode As TextBox
    Friend WithEvents pnlFirstName As Panel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents pnlLastName As Panel
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents pnlEmailAddress As Panel
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents pnlContactNumber As Panel
    Friend WithEvents mskContactNumber As MaskedTextBox
    Friend WithEvents pnlUnitID As Panel
    Friend WithEvents pnlOldUnitID As Panel
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtUnitType As TextBox
    Friend WithEvents txtUnitRent As TextBox
    Friend WithEvents dtpOccupyingDate As DateTimePicker
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents pnlUnitType As Panel
    Friend WithEvents pnlUnitRent As Panel
    Friend WithEvents lblUnitRentRM As Label
    Friend WithEvents mskStudentID As MaskedTextBox
    Friend WithEvents HostelBindingSource As BindingSource
    Friend WithEvents txtSameUnit As TextBox
    Friend WithEvents btnMinimize As Button
End Class
