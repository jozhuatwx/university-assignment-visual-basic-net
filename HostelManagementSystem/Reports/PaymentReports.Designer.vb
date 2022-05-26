<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaymentReports))
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hostel_Management_SystemDataSet = New HostelManagementSystem.Hostel_Management_SystemDataSet()
        Me.pnlTitlebar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rptPaymentReports = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PaymentTableAdapter = New HostelManagementSystem.Hostel_Management_SystemDataSetTableAdapters.PaymentTableAdapter()
        Me.btnUpdatePayRec = New System.Windows.Forms.Button()
        Me.btnAddPayRec = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.pnlPaymentReports = New System.Windows.Forms.Panel()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitlebar.SuspendLayout()
        Me.pnlControls.SuspendLayout()
        Me.pnlPaymentReports.SuspendLayout()
        Me.SuspendLayout()
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
        'pnlTitlebar
        '
        Me.pnlTitlebar.Controls.Add(Me.btnMinimize)
        Me.pnlTitlebar.Controls.Add(Me.btnClose)
        Me.pnlTitlebar.Controls.Add(Me.lblTitle)
        Me.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitlebar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlTitlebar.Name = "pnlTitlebar"
        Me.pnlTitlebar.Size = New System.Drawing.Size(812, 26)
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
        Me.btnMinimize.Location = New System.Drawing.Point(732, 0)
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
        Me.btnClose.Location = New System.Drawing.Point(772, 0)
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
        Me.lblTitle.Size = New System.Drawing.Size(812, 26)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Payment Reports"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rptPaymentReports
        '
        Me.rptPaymentReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.rptPaymentReports.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rptPaymentReports.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PaymentRecords"
        ReportDataSource1.Value = Me.PaymentBindingSource
        Me.rptPaymentReports.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptPaymentReports.LocalReport.ReportEmbeddedResource = "HostelManagementSystem.PaymentReports.rdlc"
        Me.rptPaymentReports.Location = New System.Drawing.Point(0, 0)
        Me.rptPaymentReports.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.rptPaymentReports.Name = "rptPaymentReports"
        Me.rptPaymentReports.ServerReport.BearerToken = Nothing
        Me.rptPaymentReports.Size = New System.Drawing.Size(812, 437)
        Me.rptPaymentReports.TabIndex = 0
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'btnUpdatePayRec
        '
        Me.btnUpdatePayRec.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnUpdatePayRec.FlatAppearance.BorderSize = 0
        Me.btnUpdatePayRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdatePayRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePayRec.Location = New System.Drawing.Point(443, 13)
        Me.btnUpdatePayRec.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdatePayRec.Name = "btnUpdatePayRec"
        Me.btnUpdatePayRec.Size = New System.Drawing.Size(163, 44)
        Me.btnUpdatePayRec.TabIndex = 1
        Me.btnUpdatePayRec.Text = "Update"
        Me.btnUpdatePayRec.UseVisualStyleBackColor = False
        '
        'btnAddPayRec
        '
        Me.btnAddPayRec.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddPayRec.FlatAppearance.BorderSize = 0
        Me.btnAddPayRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPayRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPayRec.Location = New System.Drawing.Point(625, 13)
        Me.btnAddPayRec.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAddPayRec.Name = "btnAddPayRec"
        Me.btnAddPayRec.Size = New System.Drawing.Size(163, 44)
        Me.btnAddPayRec.TabIndex = 2
        Me.btnAddPayRec.Text = "Add"
        Me.btnAddPayRec.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(25, 13)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(163, 44)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pnlControls
        '
        Me.pnlControls.Controls.Add(Me.btnAddPayRec)
        Me.pnlControls.Controls.Add(Me.btnUpdatePayRec)
        Me.pnlControls.Controls.Add(Me.btnBack)
        Me.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlControls.Location = New System.Drawing.Point(0, 463)
        Me.pnlControls.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(812, 81)
        Me.pnlControls.TabIndex = 0
        '
        'pnlPaymentReports
        '
        Me.pnlPaymentReports.Controls.Add(Me.rptPaymentReports)
        Me.pnlPaymentReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPaymentReports.Location = New System.Drawing.Point(0, 26)
        Me.pnlPaymentReports.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlPaymentReports.Name = "pnlPaymentReports"
        Me.pnlPaymentReports.Size = New System.Drawing.Size(812, 437)
        Me.pnlPaymentReports.TabIndex = 0
        '
        'frmPaymentReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 544)
        Me.Controls.Add(Me.pnlPaymentReports)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.pnlTitlebar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MinimumSize = New System.Drawing.Size(812, 544)
        Me.Name = "frmPaymentReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Reports"
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hostel_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitlebar.ResumeLayout(False)
        Me.pnlControls.ResumeLayout(False)
        Me.pnlPaymentReports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitlebar As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents rptPaymentReports As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Hostel_Management_SystemDataSet As Hostel_Management_SystemDataSet
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As Hostel_Management_SystemDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents btnUpdatePayRec As Button
    Friend WithEvents btnAddPayRec As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlControls As Panel
    Friend WithEvents pnlPaymentReports As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
End Class
