<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentReports))
        Me.StudentsHostelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hostel_Management_SystemDataSet = New HostelManagementSystem.Hostel_Management_SystemDataSet()
        Me.pnlTitlebar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.btnRegisterAcc = New System.Windows.Forms.Button()
        Me.btnUpdateAcc = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlStudentReports = New System.Windows.Forms.Panel()
        Me.rptStudentReports = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.StudentsTableAdapter()
        Me.StudentsHostelTableAdapter = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.StudentsHostelTableAdapter()
        CType(Me.StudentsHostelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitlebar.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlStudentReports.SuspendLayout()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentsHostelBindingSource
        '
        Me.StudentsHostelBindingSource.DataMember = "StudentsHostel"
        Me.StudentsHostelBindingSource.DataSource = Me.Hostel_Management_SystemDataSet
        '
        'Hostel_Management_SystemDataSet
        '
        Me.Hostel_Management_SystemDataSet.DataSetName = "Hostel_Management_SystemDataSet"
        Me.Hostel_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlTitlebar
        '
        Me.pnlTitlebar.Controls.Add(Me.btnMinimize)
        Me.pnlTitlebar.Controls.Add(Me.btnClose)
        Me.pnlTitlebar.Controls.Add(Me.lblTitle)
        Me.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitlebar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlTitlebar.Name = "pnlTitlebar"
        Me.pnlTitlebar.Size = New System.Drawing.Size(1083, 32)
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
        Me.btnMinimize.Location = New System.Drawing.Point(976, 0)
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
        Me.btnClose.Location = New System.Drawing.Point(1029, 0)
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
        Me.lblTitle.Size = New System.Drawing.Size(1083, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Student Reports"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControls
        '
        Me.pnlControls.Controls.Add(Me.btnRegisterAcc)
        Me.pnlControls.Controls.Add(Me.btnUpdateAcc)
        Me.pnlControls.Controls.Add(Me.btnBack)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlControls.Location = New System.Drawing.Point(0, 570)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(1083, 100)
        Me.pnlControls.TabIndex = 1
        '
        'btnRegisterAcc
        '
        Me.btnRegisterAcc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegisterAcc.FlatAppearance.BorderSize = 0
        Me.btnRegisterAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterAcc.Location = New System.Drawing.Point(833, 16)
        Me.btnRegisterAcc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegisterAcc.Name = "btnRegisterAcc"
        Me.btnRegisterAcc.Size = New System.Drawing.Size(217, 54)
        Me.btnRegisterAcc.TabIndex = 2
        Me.btnRegisterAcc.Text = "Register"
        Me.btnRegisterAcc.UseVisualStyleBackColor = False
        '
        'btnUpdateAcc
        '
        Me.btnUpdateAcc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnUpdateAcc.FlatAppearance.BorderSize = 0
        Me.btnUpdateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAcc.Location = New System.Drawing.Point(591, 16)
        Me.btnUpdateAcc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdateAcc.Name = "btnUpdateAcc"
        Me.btnUpdateAcc.Size = New System.Drawing.Size(217, 54)
        Me.btnUpdateAcc.TabIndex = 1
        Me.btnUpdateAcc.Text = "Update"
        Me.btnUpdateAcc.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(33, 16)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(217, 54)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pnlStudentReports
        '
        Me.pnlStudentReports.Controls.Add(Me.rptStudentReports)
        Me.pnlStudentReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStudentReports.Location = New System.Drawing.Point(0, 32)
        Me.pnlStudentReports.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.pnlStudentReports.Name = "pnlStudentReports"
        Me.pnlStudentReports.Size = New System.Drawing.Size(1083, 538)
        Me.pnlStudentReports.TabIndex = 2
        '
        'rptStudentReports
        '
        Me.rptStudentReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.rptStudentReports.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rptStudentReports.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "StudentsReports"
        ReportDataSource1.Value = Me.StudentsHostelBindingSource
        Me.rptStudentReports.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptStudentReports.LocalReport.ReportEmbeddedResource = "HostelManagementSystem.StudentsReports.rdlc"
        Me.rptStudentReports.Location = New System.Drawing.Point(0, 0)
        Me.rptStudentReports.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.rptStudentReports.Name = "rptStudentReports"
        Me.rptStudentReports.ServerReport.BearerToken = Nothing
        Me.rptStudentReports.Size = New System.Drawing.Size(1083, 538)
        Me.rptStudentReports.TabIndex = 0
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.Hostel_Management_SystemDataSet
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'StudentsHostelTableAdapter
        '
        Me.StudentsHostelTableAdapter.ClearBeforeFill = True
        '
        'frmStudentReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1083, 670)
        Me.Controls.Add(Me.pnlStudentReports)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.pnlTitlebar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.MinimumSize = New System.Drawing.Size(1083, 670)
        Me.Name = "frmStudentReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students Reports"
        CType(Me.StudentsHostelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitlebar.ResumeLayout(False)
        Me.pnlControls.ResumeLayout(False)
        Me.pnlStudentReports.ResumeLayout(False)
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitlebar As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Hostel_Management_SystemDataSet As Hostel_Management_SystemDataSet
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As Hostel_Management_SystemDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents pnlControls As Panel
    Friend WithEvents btnRegisterAcc As Button
    Friend WithEvents btnUpdateAcc As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlStudentReports As Panel
    Friend WithEvents rptStudentReports As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StudentsHostelBindingSource As BindingSource
    Friend WithEvents StudentsHostelTableAdapter As Hostel_Management_SystemDataSetTableAdapters.StudentsHostelTableAdapter
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
End Class
