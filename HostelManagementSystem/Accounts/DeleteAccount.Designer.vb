<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDeleteAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeleteAccount))
        Me.cboUnitID = New System.Windows.Forms.ComboBox()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hostel_Management_SystemDataSet = New HostelManagementSystem.Hostel_Management_SystemDataSet()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblIntakeCode = New System.Windows.Forms.Label()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblUnitID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblStudRecDel = New System.Windows.Forms.Label()
        Me.pnlTitlebar = New System.Windows.Forms.Panel()
        Me.lblHowdy = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlStudRecDel = New System.Windows.Forms.Panel()
        Me.pnlStudentID = New System.Windows.Forms.Panel()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.pnlIntakeCode = New System.Windows.Forms.Panel()
        Me.txtIntakeCode = New System.Windows.Forms.TextBox()
        Me.pnlFirstName = New System.Windows.Forms.Panel()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.pnlLastName = New System.Windows.Forms.Panel()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.StudentsTableAdapter = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.StudentsTableAdapter()
        Me.TableAdapterManager = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitlebar.SuspendLayout()
        Me.pnlStudRecDel.SuspendLayout()
        Me.pnlStudentID.SuspendLayout()
        Me.pnlIntakeCode.SuspendLayout()
        Me.pnlFirstName.SuspendLayout()
        Me.pnlLastName.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cboUnitID.Location = New System.Drawing.Point(25, 83)
        Me.cboUnitID.Name = "cboUnitID"
        Me.cboUnitID.Size = New System.Drawing.Size(165, 28)
        Me.cboUnitID.TabIndex = 48
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
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(263, 208)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(86, 20)
        Me.lblLastName.TabIndex = 47
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(25, 208)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(86, 20)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'lblIntakeCode
        '
        Me.lblIntakeCode.AutoSize = True
        Me.lblIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntakeCode.Location = New System.Drawing.Point(225, 130)
        Me.lblIntakeCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIntakeCode.Name = "lblIntakeCode"
        Me.lblIntakeCode.Size = New System.Drawing.Size(96, 20)
        Me.lblIntakeCode.TabIndex = 0
        Me.lblIntakeCode.Text = "Intake Code"
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.Location = New System.Drawing.Point(25, 130)
        Me.lblStudentID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(87, 20)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID"
        '
        'lblUnitID
        '
        Me.lblUnitID.AutoSize = True
        Me.lblUnitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitID.Location = New System.Drawing.Point(25, 52)
        Me.lblUnitID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUnitID.Name = "lblUnitID"
        Me.lblUnitID.Size = New System.Drawing.Size(59, 20)
        Me.lblUnitID.TabIndex = 43
        Me.lblUnitID.Text = "Unit ID"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(313, 416)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(163, 44)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
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
        'lblStudRecDel
        '
        Me.lblStudRecDel.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStudRecDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudRecDel.Location = New System.Drawing.Point(0, 0)
        Me.lblStudRecDel.Name = "lblStudRecDel"
        Me.lblStudRecDel.Size = New System.Drawing.Size(500, 39)
        Me.lblStudRecDel.TabIndex = 0
        Me.lblStudRecDel.Text = "Student Records Deletion"
        Me.lblStudRecDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTitlebar
        '
        Me.pnlTitlebar.Controls.Add(Me.lblHowdy)
        Me.pnlTitlebar.Controls.Add(Me.btnMinimize)
        Me.pnlTitlebar.Controls.Add(Me.btnClose)
        Me.pnlTitlebar.Controls.Add(Me.lblTitle)
        Me.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitlebar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlTitlebar.Name = "pnlTitlebar"
        Me.pnlTitlebar.Size = New System.Drawing.Size(500, 52)
        Me.pnlTitlebar.TabIndex = 69
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
        Me.lblTitle.Text = "Delete Account"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStudRecDel
        '
        Me.pnlStudRecDel.Controls.Add(Me.lblStudRecDel)
        Me.pnlStudRecDel.Controls.Add(Me.lblUnitID)
        Me.pnlStudRecDel.Controls.Add(Me.cboUnitID)
        Me.pnlStudRecDel.Controls.Add(Me.lblStudentID)
        Me.pnlStudRecDel.Controls.Add(Me.pnlStudentID)
        Me.pnlStudRecDel.Controls.Add(Me.lblIntakeCode)
        Me.pnlStudRecDel.Controls.Add(Me.pnlIntakeCode)
        Me.pnlStudRecDel.Controls.Add(Me.lblFirstName)
        Me.pnlStudRecDel.Controls.Add(Me.pnlFirstName)
        Me.pnlStudRecDel.Controls.Add(Me.lblLastName)
        Me.pnlStudRecDel.Controls.Add(Me.pnlLastName)
        Me.pnlStudRecDel.Controls.Add(Me.btnDelete)
        Me.pnlStudRecDel.Controls.Add(Me.btnCancel)
        Me.pnlStudRecDel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStudRecDel.Location = New System.Drawing.Point(0, 52)
        Me.pnlStudRecDel.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlStudRecDel.Name = "pnlStudRecDel"
        Me.pnlStudRecDel.Size = New System.Drawing.Size(500, 494)
        Me.pnlStudRecDel.TabIndex = 0
        '
        'pnlStudentID
        '
        Me.pnlStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlStudentID.Controls.Add(Me.txtStudentID)
        Me.pnlStudentID.Location = New System.Drawing.Point(25, 156)
        Me.pnlStudentID.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pnlStudentID.Name = "pnlStudentID"
        Me.pnlStudentID.Size = New System.Drawing.Size(163, 34)
        Me.pnlStudentID.TabIndex = 0
        '
        'txtStudentID
        '
        Me.txtStudentID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "StudentID", True))
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.ForeColor = System.Drawing.Color.Silver
        Me.txtStudentID.Location = New System.Drawing.Point(7, 7)
        Me.txtStudentID.MaxLength = 8
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(150, 19)
        Me.txtStudentID.TabIndex = 0
        Me.txtStudentID.TabStop = False
        '
        'pnlIntakeCode
        '
        Me.pnlIntakeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlIntakeCode.Controls.Add(Me.txtIntakeCode)
        Me.pnlIntakeCode.Location = New System.Drawing.Point(225, 156)
        Me.pnlIntakeCode.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pnlIntakeCode.Name = "pnlIntakeCode"
        Me.pnlIntakeCode.Size = New System.Drawing.Size(237, 34)
        Me.pnlIntakeCode.TabIndex = 0
        '
        'txtIntakeCode
        '
        Me.txtIntakeCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtIntakeCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIntakeCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "IntakeCode", True))
        Me.txtIntakeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntakeCode.ForeColor = System.Drawing.Color.Silver
        Me.txtIntakeCode.Location = New System.Drawing.Point(7, 7)
        Me.txtIntakeCode.Name = "txtIntakeCode"
        Me.txtIntakeCode.ReadOnly = True
        Me.txtIntakeCode.Size = New System.Drawing.Size(225, 19)
        Me.txtIntakeCode.TabIndex = 0
        Me.txtIntakeCode.TabStop = False
        '
        'pnlFirstName
        '
        Me.pnlFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.pnlFirstName.Controls.Add(Me.txtFirstName)
        Me.pnlFirstName.Location = New System.Drawing.Point(25, 234)
        Me.pnlFirstName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pnlFirstName.Name = "pnlFirstName"
        Me.pnlFirstName.Size = New System.Drawing.Size(200, 34)
        Me.pnlFirstName.TabIndex = 0
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "FirstName", True))
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Silver
        Me.txtFirstName.Location = New System.Drawing.Point(7, 7)
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
        Me.pnlLastName.Location = New System.Drawing.Point(263, 234)
        Me.pnlLastName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.pnlLastName.Name = "pnlLastName"
        Me.pnlLastName.Size = New System.Drawing.Size(200, 34)
        Me.pnlLastName.TabIndex = 52
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "LastName", True))
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Silver
        Me.txtLastName.Location = New System.Drawing.Point(7, 7)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(187, 19)
        Me.txtLastName.TabIndex = 0
        Me.txtLastName.TabStop = False
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
        'frmDeleteAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 546)
        Me.Controls.Add(Me.pnlStudRecDel)
        Me.Controls.Add(Me.pnlTitlebar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MinimumSize = New System.Drawing.Size(500, 546)
        Me.Name = "frmDeleteAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete"
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitlebar.ResumeLayout(False)
        Me.pnlStudRecDel.ResumeLayout(False)
        Me.pnlStudRecDel.PerformLayout()
        Me.pnlStudentID.ResumeLayout(False)
        Me.pnlStudentID.PerformLayout()
        Me.pnlIntakeCode.ResumeLayout(False)
        Me.pnlIntakeCode.PerformLayout()
        Me.pnlFirstName.ResumeLayout(False)
        Me.pnlFirstName.PerformLayout()
        Me.pnlLastName.ResumeLayout(False)
        Me.pnlLastName.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboUnitID As ComboBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblIntakeCode As Label
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblUnitID As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblStudRecDel As Label
    Friend WithEvents pnlTitlebar As Panel
    Friend WithEvents lblHowdy As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlStudRecDel As Panel
    Friend WithEvents StudentsTableAdapter As Hostel_Management_SystemDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents TableAdapterManager As Hostel_Management_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents pnlStudentID As Panel
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents pnlIntakeCode As Panel
    Friend WithEvents txtIntakeCode As TextBox
    Friend WithEvents pnlFirstName As Panel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents pnlLastName As Panel
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Hostel_Management_SystemDataSet As Hostel_Management_SystemDataSet
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents btnMinimize As Button
End Class
