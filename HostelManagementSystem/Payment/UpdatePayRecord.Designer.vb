<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdatePayRecord
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
        Dim lblPaymentID As System.Windows.Forms.Label
        Dim lblStudentID As System.Windows.Forms.Label
        Dim lblUnitID As System.Windows.Forms.Label
        Dim lblDateofEntry As System.Windows.Forms.Label
        Dim lblDescription As System.Windows.Forms.Label
        Dim lblAmountDue As System.Windows.Forms.Label
        Dim lblAmountPaid As System.Windows.Forms.Label
        Dim lblPaymentDate As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdatePayRecord))
        Me.pnlTitlebar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHowdy = New System.Windows.Forms.Label()
        Me.pnlPayRecMod = New System.Windows.Forms.Panel()
        Me.lblPayRecMod = New System.Windows.Forms.Label()
        Me.cboPaymentID = New System.Windows.Forms.ComboBox()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hostel_Management_SystemDataSet = New HostelManagementSystem.Hostel_Management_SystemDataSet()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblLoggedBy = New System.Windows.Forms.Label()
        Me.pnlLoggedBy = New System.Windows.Forms.Panel()
        Me.txtLoggedBy = New System.Windows.Forms.TextBox()
        Me.pnlDescription = New System.Windows.Forms.Panel()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.pnlUnitID = New System.Windows.Forms.Panel()
        Me.txtUnitID = New System.Windows.Forms.TextBox()
        Me.pnlAmountDue = New System.Windows.Forms.Panel()
        Me.lblAmountDueRM = New System.Windows.Forms.Label()
        Me.txtAmountDue = New System.Windows.Forms.TextBox()
        Me.pnlStudentID = New System.Windows.Forms.Panel()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.pnlAmountPaid = New System.Windows.Forms.Panel()
        Me.mskAmountPaid = New System.Windows.Forms.MaskedTextBox()
        Me.lblAmountPaidRM = New System.Windows.Forms.Label()
        Me.dtpDateofEntry = New System.Windows.Forms.DateTimePicker()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PaymentTableAdapter = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.PaymentTableAdapter()
        Me.TableAdapterManager = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager()
        lblPaymentID = New System.Windows.Forms.Label()
        lblStudentID = New System.Windows.Forms.Label()
        lblUnitID = New System.Windows.Forms.Label()
        lblDateofEntry = New System.Windows.Forms.Label()
        lblDescription = New System.Windows.Forms.Label()
        lblAmountDue = New System.Windows.Forms.Label()
        lblAmountPaid = New System.Windows.Forms.Label()
        lblPaymentDate = New System.Windows.Forms.Label()
        Me.pnlTitlebar.SuspendLayout()
        Me.pnlPayRecMod.SuspendLayout()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoggedBy.SuspendLayout()
        Me.pnlDescription.SuspendLayout()
        Me.pnlUnitID.SuspendLayout()
        Me.pnlAmountDue.SuspendLayout()
        Me.pnlStudentID.SuspendLayout()
        Me.pnlAmountPaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPaymentID
        '
        lblPaymentID.AutoSize = True
        lblPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPaymentID.Location = New System.Drawing.Point(33, 64)
        lblPaymentID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblPaymentID.Name = "lblPaymentID"
        lblPaymentID.Size = New System.Drawing.Size(113, 25)
        lblPaymentID.TabIndex = 0
        lblPaymentID.Text = "Payment ID"
        '
        'lblStudentID
        '
        lblStudentID.AutoSize = True
        lblStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStudentID.Location = New System.Drawing.Point(33, 352)
        lblStudentID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New System.Drawing.Size(104, 25)
        lblStudentID.TabIndex = 0
        lblStudentID.Text = "Student ID"
        '
        'lblUnitID
        '
        lblUnitID.AutoSize = True
        lblUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUnitID.Location = New System.Drawing.Point(33, 256)
        lblUnitID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblUnitID.Name = "lblUnitID"
        lblUnitID.Size = New System.Drawing.Size(70, 25)
        lblUnitID.TabIndex = 0
        lblUnitID.Text = "Unit ID"
        '
        'lblDateofEntry
        '
        lblDateofEntry.AutoSize = True
        lblDateofEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDateofEntry.Location = New System.Drawing.Point(33, 448)
        lblDateofEntry.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDateofEntry.Name = "lblDateofEntry"
        lblDateofEntry.Size = New System.Drawing.Size(124, 25)
        lblDateofEntry.TabIndex = 0
        lblDateofEntry.Text = "Date of Entry"
        '
        'lblDescription
        '
        lblDescription.AutoSize = True
        lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDescription.Location = New System.Drawing.Point(284, 160)
        lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New System.Drawing.Size(109, 25)
        lblDescription.TabIndex = 0
        lblDescription.Text = "Description"
        '
        'lblAmountDue
        '
        lblAmountDue.AutoSize = True
        lblAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAmountDue.Location = New System.Drawing.Point(367, 256)
        lblAmountDue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblAmountDue.Name = "lblAmountDue"
        lblAmountDue.Size = New System.Drawing.Size(121, 25)
        lblAmountDue.TabIndex = 0
        lblAmountDue.Text = "Amount Due"
        '
        'lblAmountPaid
        '
        lblAmountPaid.AutoSize = True
        lblAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAmountPaid.Location = New System.Drawing.Point(367, 352)
        lblAmountPaid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblAmountPaid.Name = "lblAmountPaid"
        lblAmountPaid.Size = New System.Drawing.Size(124, 25)
        lblAmountPaid.TabIndex = 0
        lblAmountPaid.Text = "Amount Paid"
        '
        'lblPaymentDate
        '
        lblPaymentDate.AutoSize = True
        lblPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPaymentDate.Location = New System.Drawing.Point(367, 448)
        lblPaymentDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblPaymentDate.Name = "lblPaymentDate"
        lblPaymentDate.Size = New System.Drawing.Size(135, 25)
        lblPaymentDate.TabIndex = 0
        lblPaymentDate.Text = "Payment Date"
        '
        'pnlTitlebar
        '
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
        Me.lblTitle.Text = "Update Payment Record"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHowdy
        '
        Me.lblHowdy.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblHowdy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowdy.Location = New System.Drawing.Point(0, 32)
        Me.lblHowdy.Name = "lblHowdy"
        Me.lblHowdy.Size = New System.Drawing.Size(667, 32)
        Me.lblHowdy.TabIndex = 0
        Me.lblHowdy.Text = "Howdy again, User! Welcome to"
        Me.lblHowdy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pnlPayRecMod
        '
        Me.pnlPayRecMod.Controls.Add(Me.lblPayRecMod)
        Me.pnlPayRecMod.Controls.Add(lblPaymentID)
        Me.pnlPayRecMod.Controls.Add(Me.cboPaymentID)
        Me.pnlPayRecMod.Controls.Add(Me.btnSearch)
        Me.pnlPayRecMod.Controls.Add(Me.lblLoggedBy)
        Me.pnlPayRecMod.Controls.Add(Me.pnlLoggedBy)
        Me.pnlPayRecMod.Controls.Add(lblDescription)
        Me.pnlPayRecMod.Controls.Add(Me.pnlDescription)
        Me.pnlPayRecMod.Controls.Add(lblUnitID)
        Me.pnlPayRecMod.Controls.Add(Me.pnlUnitID)
        Me.pnlPayRecMod.Controls.Add(lblAmountDue)
        Me.pnlPayRecMod.Controls.Add(Me.pnlAmountDue)
        Me.pnlPayRecMod.Controls.Add(lblStudentID)
        Me.pnlPayRecMod.Controls.Add(Me.pnlStudentID)
        Me.pnlPayRecMod.Controls.Add(lblAmountPaid)
        Me.pnlPayRecMod.Controls.Add(Me.pnlAmountPaid)
        Me.pnlPayRecMod.Controls.Add(lblDateofEntry)
        Me.pnlPayRecMod.Controls.Add(Me.dtpDateofEntry)
        Me.pnlPayRecMod.Controls.Add(lblPaymentDate)
        Me.pnlPayRecMod.Controls.Add(Me.dtpPaymentDate)
        Me.pnlPayRecMod.Controls.Add(Me.btnUpdate)
        Me.pnlPayRecMod.Controls.Add(Me.btnCancel)
        Me.pnlPayRecMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPayRecMod.Location = New System.Drawing.Point(0, 64)
        Me.pnlPayRecMod.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.pnlPayRecMod.Name = "pnlPayRecMod"
        Me.pnlPayRecMod.Size = New System.Drawing.Size(667, 608)
        Me.pnlPayRecMod.TabIndex = 63
        '
        'lblPayRecMod
        '
        Me.lblPayRecMod.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPayRecMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayRecMod.Location = New System.Drawing.Point(0, 0)
        Me.lblPayRecMod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPayRecMod.Name = "lblPayRecMod"
        Me.lblPayRecMod.Size = New System.Drawing.Size(667, 48)
        Me.lblPayRecMod.TabIndex = 0
        Me.lblPayRecMod.Text = "Payment Records Modification"
        Me.lblPayRecMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboPaymentID
        '
        Me.cboPaymentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cboPaymentID.DataSource = Me.PaymentBindingSource
        Me.cboPaymentID.DisplayMember = "PaymentID"
        Me.cboPaymentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentID.ForeColor = System.Drawing.Color.White
        Me.cboPaymentID.FormattingEnabled = True
        Me.cboPaymentID.Location = New System.Drawing.Point(67, 103)
        Me.cboPaymentID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPaymentID.Name = "cboPaymentID"
        Me.cboPaymentID.Size = New System.Drawing.Size(135, 33)
        Me.cboPaymentID.TabIndex = 0
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.Hostel_Management_SystemDataSet
        '
        'Hostel_Management_SystemDataSet
        '
        Me.Hostel_Management_SystemDataSet.DataSetName = "Hostel_Management_SystemDataSet"
        Me.Hostel_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(208, 97)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(133, 42)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblLoggedBy
        '
        Me.lblLoggedBy.AutoSize = True
        Me.lblLoggedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggedBy.Location = New System.Drawing.Point(33, 160)
        Me.lblLoggedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoggedBy.Name = "lblLoggedBy"
        Me.lblLoggedBy.Size = New System.Drawing.Size(106, 25)
        Me.lblLoggedBy.TabIndex = 0
        Me.lblLoggedBy.Text = "Logged By"
        '
        'pnlLoggedBy
        '
        Me.pnlLoggedBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlLoggedBy.Controls.Add(Me.txtLoggedBy)
        Me.pnlLoggedBy.Location = New System.Drawing.Point(33, 192)
        Me.pnlLoggedBy.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlLoggedBy.Name = "pnlLoggedBy"
        Me.pnlLoggedBy.Size = New System.Drawing.Size(167, 42)
        Me.pnlLoggedBy.TabIndex = 0
        '
        'txtLoggedBy
        '
        Me.txtLoggedBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtLoggedBy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLoggedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoggedBy.ForeColor = System.Drawing.Color.Silver
        Me.txtLoggedBy.Location = New System.Drawing.Point(9, 9)
        Me.txtLoggedBy.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLoggedBy.Name = "txtLoggedBy"
        Me.txtLoggedBy.ReadOnly = True
        Me.txtLoggedBy.Size = New System.Drawing.Size(151, 23)
        Me.txtLoggedBy.TabIndex = 0
        Me.txtLoggedBy.TabStop = False
        '
        'pnlDescription
        '
        Me.pnlDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlDescription.Controls.Add(Me.txtDescription)
        Me.pnlDescription.Location = New System.Drawing.Point(284, 192)
        Me.pnlDescription.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlDescription.Name = "pnlDescription"
        Me.pnlDescription.Size = New System.Drawing.Size(333, 42)
        Me.pnlDescription.TabIndex = 0
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(9, 9)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.MaxLength = 150
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(316, 23)
        Me.txtDescription.TabIndex = 0
        '
        'pnlUnitID
        '
        Me.pnlUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlUnitID.Controls.Add(Me.txtUnitID)
        Me.pnlUnitID.Location = New System.Drawing.Point(33, 288)
        Me.pnlUnitID.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlUnitID.Name = "pnlUnitID"
        Me.pnlUnitID.Size = New System.Drawing.Size(249, 42)
        Me.pnlUnitID.TabIndex = 0
        '
        'txtUnitID
        '
        Me.txtUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtUnitID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitID.ForeColor = System.Drawing.Color.Silver
        Me.txtUnitID.Location = New System.Drawing.Point(9, 9)
        Me.txtUnitID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitID.Name = "txtUnitID"
        Me.txtUnitID.ReadOnly = True
        Me.txtUnitID.Size = New System.Drawing.Size(233, 23)
        Me.txtUnitID.TabIndex = 0
        Me.txtUnitID.TabStop = False
        '
        'pnlAmountDue
        '
        Me.pnlAmountDue.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlAmountDue.Controls.Add(Me.lblAmountDueRM)
        Me.pnlAmountDue.Controls.Add(Me.txtAmountDue)
        Me.pnlAmountDue.ForeColor = System.Drawing.Color.Silver
        Me.pnlAmountDue.Location = New System.Drawing.Point(367, 288)
        Me.pnlAmountDue.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlAmountDue.Name = "pnlAmountDue"
        Me.pnlAmountDue.Size = New System.Drawing.Size(249, 42)
        Me.pnlAmountDue.TabIndex = 0
        '
        'lblAmountDueRM
        '
        Me.lblAmountDueRM.AutoSize = True
        Me.lblAmountDueRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDueRM.Location = New System.Drawing.Point(9, 9)
        Me.lblAmountDueRM.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAmountDueRM.Name = "lblAmountDueRM"
        Me.lblAmountDueRM.Size = New System.Drawing.Size(42, 25)
        Me.lblAmountDueRM.TabIndex = 0
        Me.lblAmountDueRM.Text = "RM"
        '
        'txtAmountDue
        '
        Me.txtAmountDue.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmountDue.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountDue.ForeColor = System.Drawing.Color.Silver
        Me.txtAmountDue.Location = New System.Drawing.Point(55, 9)
        Me.txtAmountDue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmountDue.Name = "txtAmountDue"
        Me.txtAmountDue.ReadOnly = True
        Me.txtAmountDue.Size = New System.Drawing.Size(187, 23)
        Me.txtAmountDue.TabIndex = 0
        Me.txtAmountDue.TabStop = False
        Me.txtAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlStudentID
        '
        Me.pnlStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlStudentID.Controls.Add(Me.txtStudentID)
        Me.pnlStudentID.Location = New System.Drawing.Point(33, 384)
        Me.pnlStudentID.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlStudentID.Name = "pnlStudentID"
        Me.pnlStudentID.Size = New System.Drawing.Size(249, 42)
        Me.pnlStudentID.TabIndex = 0
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.ForeColor = System.Drawing.Color.Silver
        Me.txtStudentID.Location = New System.Drawing.Point(9, 9)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(233, 23)
        Me.txtStudentID.TabIndex = 0
        Me.txtStudentID.TabStop = False
        '
        'pnlAmountPaid
        '
        Me.pnlAmountPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlAmountPaid.Controls.Add(Me.mskAmountPaid)
        Me.pnlAmountPaid.Controls.Add(Me.lblAmountPaidRM)
        Me.pnlAmountPaid.Location = New System.Drawing.Point(367, 384)
        Me.pnlAmountPaid.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlAmountPaid.Name = "pnlAmountPaid"
        Me.pnlAmountPaid.Size = New System.Drawing.Size(249, 42)
        Me.pnlAmountPaid.TabIndex = 0
        '
        'mskAmountPaid
        '
        Me.mskAmountPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.mskAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskAmountPaid.ForeColor = System.Drawing.Color.White
        Me.mskAmountPaid.Location = New System.Drawing.Point(55, 9)
        Me.mskAmountPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.mskAmountPaid.Mask = "000000"
        Me.mskAmountPaid.Name = "mskAmountPaid"
        Me.mskAmountPaid.Size = New System.Drawing.Size(187, 23)
        Me.mskAmountPaid.TabIndex = 64
        Me.mskAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAmountPaidRM
        '
        Me.lblAmountPaidRM.AutoSize = True
        Me.lblAmountPaidRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaidRM.Location = New System.Drawing.Point(9, 9)
        Me.lblAmountPaidRM.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAmountPaidRM.Name = "lblAmountPaidRM"
        Me.lblAmountPaidRM.Size = New System.Drawing.Size(42, 25)
        Me.lblAmountPaidRM.TabIndex = 0
        Me.lblAmountPaidRM.Text = "RM"
        '
        'dtpDateofEntry
        '
        Me.dtpDateofEntry.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateofEntry.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpDateofEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateofEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateofEntry.Location = New System.Drawing.Point(33, 480)
        Me.dtpDateofEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateofEntry.MinimumSize = New System.Drawing.Size(251, 45)
        Me.dtpDateofEntry.Name = "dtpDateofEntry"
        Me.dtpDateofEntry.Size = New System.Drawing.Size(251, 45)
        Me.dtpDateofEntry.TabIndex = 0
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpPaymentDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPaymentDate.Location = New System.Drawing.Point(367, 480)
        Me.dtpPaymentDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpPaymentDate.MinimumSize = New System.Drawing.Size(251, 45)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(251, 45)
        Me.dtpPaymentDate.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(417, 544)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(217, 54)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(33, 544)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(217, 54)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CredentialsTableAdapter = Nothing
        Me.TableAdapterManager.HostelTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Me.PaymentTableAdapter
        Me.TableAdapterManager.StudentsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmUpdatePayRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(667, 672)
        Me.Controls.Add(Me.pnlPayRecMod)
        Me.Controls.Add(Me.pnlTitlebar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.MinimumSize = New System.Drawing.Size(667, 672)
        Me.Name = "frmUpdatePayRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdatePayRecord"
        Me.pnlTitlebar.ResumeLayout(False)
        Me.pnlPayRecMod.ResumeLayout(False)
        Me.pnlPayRecMod.PerformLayout()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoggedBy.ResumeLayout(False)
        Me.pnlLoggedBy.PerformLayout()
        Me.pnlDescription.ResumeLayout(False)
        Me.pnlDescription.PerformLayout()
        Me.pnlUnitID.ResumeLayout(False)
        Me.pnlUnitID.PerformLayout()
        Me.pnlAmountDue.ResumeLayout(False)
        Me.pnlAmountDue.PerformLayout()
        Me.pnlStudentID.ResumeLayout(False)
        Me.pnlStudentID.PerformLayout()
        Me.pnlAmountPaid.ResumeLayout(False)
        Me.pnlAmountPaid.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitlebar As Panel
    Friend WithEvents lblHowdy As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlPayRecMod As Panel
    Friend WithEvents lblPayRecMod As Label
    Friend WithEvents txtLoggedBy As TextBox
    Friend WithEvents lblLoggedBy As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtUnitID As TextBox
    Friend WithEvents cboPaymentID As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Hostel_Management_SystemDataSet As Hostel_Management_SystemDataSet
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As Hostel_Management_SystemDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents TableAdapterManager As Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents pnlDescription As Panel
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents pnlAmountDue As Panel
    Friend WithEvents lblAmountDueRM As Label
    Friend WithEvents txtAmountDue As TextBox
    Friend WithEvents pnlStudentID As Panel
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents pnlAmountPaid As Panel
    Friend WithEvents lblAmountPaidRM As Label
    Friend WithEvents dtpDateofEntry As DateTimePicker
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents pnlUnitID As Panel
    Friend WithEvents pnlLoggedBy As Panel
    Friend WithEvents mskAmountPaid As MaskedTextBox
    Friend WithEvents btnMinimize As Button
End Class
