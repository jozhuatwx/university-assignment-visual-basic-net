<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPayRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddPayRecord))
        Me.pnlTitlebar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHowdy = New System.Windows.Forms.Label()
        Me.pnlRecStudPay = New System.Windows.Forms.Panel()
        Me.lblRecStudPay = New System.Windows.Forms.Label()
        Me.pnlPaymentID = New System.Windows.Forms.Panel()
        Me.lblPaymentIDP = New System.Windows.Forms.Label()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.pnlDescription = New System.Windows.Forms.Panel()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cboUnitID = New System.Windows.Forms.ComboBox()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hostel_Management_SystemDataSet = New HostelManagementSystem.Hostel_Management_SystemDataSet()
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.StudentsTableAdapter = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.StudentsTableAdapter()
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
        Me.pnlRecStudPay.SuspendLayout()
        Me.pnlPaymentID.SuspendLayout()
        Me.pnlDescription.SuspendLayout()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        lblPaymentID.Location = New System.Drawing.Point(25, 52)
        lblPaymentID.Name = "lblPaymentID"
        lblPaymentID.Size = New System.Drawing.Size(92, 20)
        lblPaymentID.TabIndex = 0
        lblPaymentID.Text = "Payment ID"
        '
        'lblStudentID
        '
        lblStudentID.AutoSize = True
        lblStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStudentID.Location = New System.Drawing.Point(25, 208)
        lblStudentID.Name = "lblStudentID"
        lblStudentID.Size = New System.Drawing.Size(87, 20)
        lblStudentID.TabIndex = 0
        lblStudentID.Text = "Student ID"
        '
        'lblUnitID
        '
        lblUnitID.AutoSize = True
        lblUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUnitID.Location = New System.Drawing.Point(25, 130)
        lblUnitID.Name = "lblUnitID"
        lblUnitID.Size = New System.Drawing.Size(59, 20)
        lblUnitID.TabIndex = 0
        lblUnitID.Text = "Unit ID"
        '
        'lblDateofEntry
        '
        lblDateofEntry.AutoSize = True
        lblDateofEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDateofEntry.Location = New System.Drawing.Point(25, 286)
        lblDateofEntry.Name = "lblDateofEntry"
        lblDateofEntry.Size = New System.Drawing.Size(103, 20)
        lblDateofEntry.TabIndex = 0
        lblDateofEntry.Text = "Date of Entry"
        '
        'lblDescription
        '
        lblDescription.AutoSize = True
        lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDescription.Location = New System.Drawing.Point(213, 52)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New System.Drawing.Size(89, 20)
        lblDescription.TabIndex = 0
        lblDescription.Text = "Description"
        '
        'lblAmountDue
        '
        lblAmountDue.AutoSize = True
        lblAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAmountDue.Location = New System.Drawing.Point(275, 130)
        lblAmountDue.Name = "lblAmountDue"
        lblAmountDue.Size = New System.Drawing.Size(99, 20)
        lblAmountDue.TabIndex = 0
        lblAmountDue.Text = "Amount Due"
        '
        'lblAmountPaid
        '
        lblAmountPaid.AutoSize = True
        lblAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblAmountPaid.Location = New System.Drawing.Point(275, 208)
        lblAmountPaid.Name = "lblAmountPaid"
        lblAmountPaid.Size = New System.Drawing.Size(100, 20)
        lblAmountPaid.TabIndex = 0
        lblAmountPaid.Text = "Amount Paid"
        '
        'lblPaymentDate
        '
        lblPaymentDate.AutoSize = True
        lblPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPaymentDate.Location = New System.Drawing.Point(275, 286)
        lblPaymentDate.Name = "lblPaymentDate"
        lblPaymentDate.Size = New System.Drawing.Size(110, 20)
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
        Me.pnlTitlebar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
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
        Me.btnClose.Location = New System.Drawing.Point(460, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 26)
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
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add Payment Record"
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
        'pnlRecStudPay
        '
        Me.pnlRecStudPay.Controls.Add(Me.lblRecStudPay)
        Me.pnlRecStudPay.Controls.Add(lblPaymentID)
        Me.pnlRecStudPay.Controls.Add(Me.pnlPaymentID)
        Me.pnlRecStudPay.Controls.Add(lblDescription)
        Me.pnlRecStudPay.Controls.Add(Me.pnlDescription)
        Me.pnlRecStudPay.Controls.Add(lblUnitID)
        Me.pnlRecStudPay.Controls.Add(Me.cboUnitID)
        Me.pnlRecStudPay.Controls.Add(Me.pnlUnitID)
        Me.pnlRecStudPay.Controls.Add(lblAmountDue)
        Me.pnlRecStudPay.Controls.Add(Me.pnlAmountDue)
        Me.pnlRecStudPay.Controls.Add(lblStudentID)
        Me.pnlRecStudPay.Controls.Add(Me.pnlStudentID)
        Me.pnlRecStudPay.Controls.Add(lblAmountPaid)
        Me.pnlRecStudPay.Controls.Add(Me.pnlAmountPaid)
        Me.pnlRecStudPay.Controls.Add(lblDateofEntry)
        Me.pnlRecStudPay.Controls.Add(Me.dtpDateofEntry)
        Me.pnlRecStudPay.Controls.Add(lblPaymentDate)
        Me.pnlRecStudPay.Controls.Add(Me.dtpPaymentDate)
        Me.pnlRecStudPay.Controls.Add(Me.btnAdd)
        Me.pnlRecStudPay.Controls.Add(Me.btnCancel)
        Me.pnlRecStudPay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRecStudPay.Location = New System.Drawing.Point(0, 52)
        Me.pnlRecStudPay.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlRecStudPay.Name = "pnlRecStudPay"
        Me.pnlRecStudPay.Size = New System.Drawing.Size(500, 494)
        Me.pnlRecStudPay.TabIndex = 0
        '
        'lblRecStudPay
        '
        Me.lblRecStudPay.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRecStudPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecStudPay.Location = New System.Drawing.Point(0, 0)
        Me.lblRecStudPay.Name = "lblRecStudPay"
        Me.lblRecStudPay.Size = New System.Drawing.Size(500, 39)
        Me.lblRecStudPay.TabIndex = 0
        Me.lblRecStudPay.Text = "Recording of Student's Payment"
        Me.lblRecStudPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlPaymentID
        '
        Me.pnlPaymentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlPaymentID.Controls.Add(Me.lblPaymentIDP)
        Me.pnlPaymentID.Controls.Add(Me.txtPaymentID)
        Me.pnlPaymentID.Location = New System.Drawing.Point(25, 78)
        Me.pnlPaymentID.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlPaymentID.Name = "pnlPaymentID"
        Me.pnlPaymentID.Size = New System.Drawing.Size(137, 34)
        Me.pnlPaymentID.TabIndex = 0
        '
        'lblPaymentIDP
        '
        Me.lblPaymentIDP.AutoSize = True
        Me.lblPaymentIDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentIDP.ForeColor = System.Drawing.Color.Silver
        Me.lblPaymentIDP.Location = New System.Drawing.Point(7, 7)
        Me.lblPaymentIDP.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPaymentIDP.Name = "lblPaymentIDP"
        Me.lblPaymentIDP.Size = New System.Drawing.Size(19, 20)
        Me.lblPaymentIDP.TabIndex = 0
        Me.lblPaymentIDP.Text = "P"
        '
        'txtPaymentID
        '
        Me.txtPaymentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtPaymentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaymentID.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPaymentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentID.ForeColor = System.Drawing.Color.Silver
        Me.txtPaymentID.Location = New System.Drawing.Point(31, 7)
        Me.txtPaymentID.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPaymentID.MaxLength = 4
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.ReadOnly = True
        Me.txtPaymentID.Size = New System.Drawing.Size(100, 19)
        Me.txtPaymentID.TabIndex = 0
        Me.txtPaymentID.TabStop = False
        Me.txtPaymentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlDescription
        '
        Me.pnlDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlDescription.Controls.Add(Me.txtDescription)
        Me.pnlDescription.Location = New System.Drawing.Point(213, 78)
        Me.pnlDescription.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlDescription.Name = "pnlDescription"
        Me.pnlDescription.Size = New System.Drawing.Size(250, 34)
        Me.pnlDescription.TabIndex = 0
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(7, 7)
        Me.txtDescription.MaxLength = 150
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(237, 19)
        Me.txtDescription.TabIndex = 0
        '
        'cboUnitID
        '
        Me.cboUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cboUnitID.DataSource = Me.StudentsBindingSource
        Me.cboUnitID.DisplayMember = "UnitID"
        Me.cboUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnitID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnitID.ForeColor = System.Drawing.Color.White
        Me.cboUnitID.FormattingEnabled = True
        Me.cboUnitID.Location = New System.Drawing.Point(25, 158)
        Me.cboUnitID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboUnitID.Name = "cboUnitID"
        Me.cboUnitID.Size = New System.Drawing.Size(165, 28)
        Me.cboUnitID.TabIndex = 0
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.Hostel_Management_SystemDataSet
        '
        'Hostel_Management_SystemDataSet
        '
        Me.Hostel_Management_SystemDataSet.DataSetName = "Hostel_Management_SystemDataSet"
        Me.Hostel_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlUnitID
        '
        Me.pnlUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlUnitID.Controls.Add(Me.txtUnitID)
        Me.pnlUnitID.Location = New System.Drawing.Point(25, 156)
        Me.pnlUnitID.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlUnitID.Name = "pnlUnitID"
        Me.pnlUnitID.Size = New System.Drawing.Size(187, 34)
        Me.pnlUnitID.TabIndex = 0
        '
        'txtUnitID
        '
        Me.txtUnitID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtUnitID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnitID.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitID.ForeColor = System.Drawing.Color.Silver
        Me.txtUnitID.Location = New System.Drawing.Point(7, 7)
        Me.txtUnitID.Name = "txtUnitID"
        Me.txtUnitID.ReadOnly = True
        Me.txtUnitID.Size = New System.Drawing.Size(175, 19)
        Me.txtUnitID.TabIndex = 0
        Me.txtUnitID.TabStop = False
        '
        'pnlAmountDue
        '
        Me.pnlAmountDue.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlAmountDue.Controls.Add(Me.lblAmountDueRM)
        Me.pnlAmountDue.Controls.Add(Me.txtAmountDue)
        Me.pnlAmountDue.Location = New System.Drawing.Point(275, 156)
        Me.pnlAmountDue.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlAmountDue.Name = "pnlAmountDue"
        Me.pnlAmountDue.Size = New System.Drawing.Size(187, 34)
        Me.pnlAmountDue.TabIndex = 0
        '
        'lblAmountDueRM
        '
        Me.lblAmountDueRM.AutoSize = True
        Me.lblAmountDueRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDueRM.ForeColor = System.Drawing.Color.Silver
        Me.lblAmountDueRM.Location = New System.Drawing.Point(7, 7)
        Me.lblAmountDueRM.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAmountDueRM.Name = "lblAmountDueRM"
        Me.lblAmountDueRM.Size = New System.Drawing.Size(34, 20)
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
        Me.txtAmountDue.Location = New System.Drawing.Point(41, 7)
        Me.txtAmountDue.Name = "txtAmountDue"
        Me.txtAmountDue.ReadOnly = True
        Me.txtAmountDue.Size = New System.Drawing.Size(140, 19)
        Me.txtAmountDue.TabIndex = 0
        Me.txtAmountDue.TabStop = False
        Me.txtAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlStudentID
        '
        Me.pnlStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlStudentID.Controls.Add(Me.txtStudentID)
        Me.pnlStudentID.Location = New System.Drawing.Point(25, 234)
        Me.pnlStudentID.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlStudentID.Name = "pnlStudentID"
        Me.pnlStudentID.Size = New System.Drawing.Size(187, 34)
        Me.pnlStudentID.TabIndex = 0
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.ForeColor = System.Drawing.Color.Silver
        Me.txtStudentID.Location = New System.Drawing.Point(7, 7)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(175, 19)
        Me.txtStudentID.TabIndex = 0
        Me.txtStudentID.TabStop = False
        '
        'pnlAmountPaid
        '
        Me.pnlAmountPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pnlAmountPaid.Controls.Add(Me.mskAmountPaid)
        Me.pnlAmountPaid.Controls.Add(Me.lblAmountPaidRM)
        Me.pnlAmountPaid.Location = New System.Drawing.Point(275, 234)
        Me.pnlAmountPaid.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlAmountPaid.Name = "pnlAmountPaid"
        Me.pnlAmountPaid.Size = New System.Drawing.Size(187, 34)
        Me.pnlAmountPaid.TabIndex = 0
        '
        'mskAmountPaid
        '
        Me.mskAmountPaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.mskAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskAmountPaid.ForeColor = System.Drawing.Color.White
        Me.mskAmountPaid.Location = New System.Drawing.Point(44, 7)
        Me.mskAmountPaid.Mask = "000000"
        Me.mskAmountPaid.Name = "mskAmountPaid"
        Me.mskAmountPaid.Size = New System.Drawing.Size(140, 19)
        Me.mskAmountPaid.TabIndex = 1
        Me.mskAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAmountPaidRM
        '
        Me.lblAmountPaidRM.AutoSize = True
        Me.lblAmountPaidRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaidRM.Location = New System.Drawing.Point(7, 7)
        Me.lblAmountPaidRM.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblAmountPaidRM.Name = "lblAmountPaidRM"
        Me.lblAmountPaidRM.Size = New System.Drawing.Size(34, 20)
        Me.lblAmountPaidRM.TabIndex = 1
        Me.lblAmountPaidRM.Text = "RM"
        '
        'dtpDateofEntry
        '
        Me.dtpDateofEntry.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateofEntry.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpDateofEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateofEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateofEntry.Location = New System.Drawing.Point(25, 318)
        Me.dtpDateofEntry.MinimumSize = New System.Drawing.Size(189, 45)
        Me.dtpDateofEntry.Name = "dtpDateofEntry"
        Me.dtpDateofEntry.Size = New System.Drawing.Size(189, 45)
        Me.dtpDateofEntry.TabIndex = 0
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpPaymentDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPaymentDate.Location = New System.Drawing.Point(275, 318)
        Me.dtpPaymentDate.MinimumSize = New System.Drawing.Size(189, 45)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(189, 45)
        Me.dtpPaymentDate.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(313, 416)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(163, 44)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(25, 416)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(163, 44)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CredentialsTableAdapter = Nothing
        Me.TableAdapterManager.HostelTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.StudentsTableAdapter = Me.StudentsTableAdapter
        Me.TableAdapterManager.UpdateOrder = HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmAddPayRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 546)
        Me.Controls.Add(Me.pnlRecStudPay)
        Me.Controls.Add(Me.pnlTitlebar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MinimumSize = New System.Drawing.Size(500, 546)
        Me.Name = "frmAddPayRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Payment Record"
        Me.pnlTitlebar.ResumeLayout(False)
        Me.pnlRecStudPay.ResumeLayout(False)
        Me.pnlRecStudPay.PerformLayout()
        Me.pnlPaymentID.ResumeLayout(False)
        Me.pnlPaymentID.PerformLayout()
        Me.pnlDescription.ResumeLayout(False)
        Me.pnlDescription.PerformLayout()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnlRecStudPay As Panel
    Friend WithEvents txtAmountDue As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblRecStudPay As Label
    Friend WithEvents dtpDateofEntry As DateTimePicker
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Hostel_Management_SystemDataSet As Hostel_Management_SystemDataSet
    Friend WithEvents StudentsTableAdapter As Hostel_Management_SystemDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TableAdapterManager As Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents pnlDescription As Panel
    Friend WithEvents pnlAmountPaid As Panel
    Friend WithEvents pnlAmountDue As Panel
    Friend WithEvents pnlPaymentID As Panel
    Friend WithEvents pnlStudentID As Panel
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents txtPaymentID As TextBox
    Friend WithEvents lblPaymentIDP As Label
    Friend WithEvents lblAmountDueRM As Label
    Friend WithEvents lblAmountPaidRM As Label
    Friend WithEvents mskAmountPaid As MaskedTextBox
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents cboUnitID As ComboBox
    Friend WithEvents pnlUnitID As Panel
    Friend WithEvents txtUnitID As TextBox
    Friend WithEvents btnMinimize As Button
End Class
