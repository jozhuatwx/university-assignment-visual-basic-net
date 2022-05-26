<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.lblHowdy = New System.Windows.Forms.Label()
        Me.pnlTitlebar = New System.Windows.Forms.Panel()
        Me.pnlNavbar = New System.Windows.Forms.Panel()
        Me.pnlHighlight = New System.Windows.Forms.Panel()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.pnlAccounts = New System.Windows.Forms.Panel()
        Me.picRegisterAcc = New System.Windows.Forms.PictureBox()
        Me.btnRegisterAcc = New System.Windows.Forms.Button()
        Me.picUpdateAcc = New System.Windows.Forms.PictureBox()
        Me.btnUpdateAcc = New System.Windows.Forms.Button()
        Me.picDeleteAcc = New System.Windows.Forms.PictureBox()
        Me.btnDeleteAcc = New System.Windows.Forms.Button()
        Me.pnlReports = New System.Windows.Forms.Panel()
        Me.picStudentReports = New System.Windows.Forms.PictureBox()
        Me.btnStudentReports = New System.Windows.Forms.Button()
        Me.picPaymentReports = New System.Windows.Forms.PictureBox()
        Me.btnPaymentReports = New System.Windows.Forms.Button()
        Me.pnlPayment = New System.Windows.Forms.Panel()
        Me.picAddPayRec = New System.Windows.Forms.PictureBox()
        Me.btnAddPayRec = New System.Windows.Forms.Button()
        Me.picUpdatePayRec = New System.Windows.Forms.PictureBox()
        Me.btnUpdatePayRec = New System.Windows.Forms.Button()
        Me.pnlTitlebar.SuspendLayout()
        Me.pnlNavbar.SuspendLayout()
        Me.pnlAccounts.SuspendLayout()
        CType(Me.picRegisterAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpdateAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeleteAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlReports.SuspendLayout()
        CType(Me.picStudentReports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPaymentReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPayment.SuspendLayout()
        CType(Me.picAddPayRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUpdatePayRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(260, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 26)
        Me.btnClose.TabIndex = 0
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAccounts
        '
        Me.btnAccounts.FlatAppearance.BorderSize = 0
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounts.ForeColor = System.Drawing.Color.White
        Me.btnAccounts.Location = New System.Drawing.Point(0, 10)
        Me.btnAccounts.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(100, 42)
        Me.btnAccounts.TabIndex = 0
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.AutoSize = True
        Me.btnPayment.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Location = New System.Drawing.Point(100, 10)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(100, 42)
        Me.btnPayment.TabIndex = 0
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'lblHowdy
        '
        Me.lblHowdy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHowdy.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowdy.ForeColor = System.Drawing.Color.White
        Me.lblHowdy.Location = New System.Drawing.Point(0, 0)
        Me.lblHowdy.Name = "lblHowdy"
        Me.lblHowdy.Size = New System.Drawing.Size(300, 195)
        Me.lblHowdy.TabIndex = 0
        Me.lblHowdy.Text = "Howdy, User."
        Me.lblHowdy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTitlebar
        '
        Me.pnlTitlebar.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlTitlebar.Controls.Add(Me.pnlNavbar)
        Me.pnlTitlebar.Controls.Add(Me.btnLogout)
        Me.pnlTitlebar.Controls.Add(Me.btnMinimize)
        Me.pnlTitlebar.Controls.Add(Me.btnClose)
        Me.pnlTitlebar.Controls.Add(Me.lblHowdy)
        Me.pnlTitlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitlebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitlebar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlTitlebar.Name = "pnlTitlebar"
        Me.pnlTitlebar.Size = New System.Drawing.Size(300, 195)
        Me.pnlTitlebar.TabIndex = 0
        '
        'pnlNavbar
        '
        Me.pnlNavbar.Controls.Add(Me.pnlHighlight)
        Me.pnlNavbar.Controls.Add(Me.btnAccounts)
        Me.pnlNavbar.Controls.Add(Me.btnPayment)
        Me.pnlNavbar.Controls.Add(Me.btnReports)
        Me.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlNavbar.Location = New System.Drawing.Point(0, 143)
        Me.pnlNavbar.Margin = New System.Windows.Forms.Padding(1)
        Me.pnlNavbar.Name = "pnlNavbar"
        Me.pnlNavbar.Size = New System.Drawing.Size(300, 52)
        Me.pnlNavbar.TabIndex = 0
        '
        'pnlHighlight
        '
        Me.pnlHighlight.BackColor = System.Drawing.Color.White
        Me.pnlHighlight.Location = New System.Drawing.Point(0, 49)
        Me.pnlHighlight.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlHighlight.Name = "pnlHighlight"
        Me.pnlHighlight.Size = New System.Drawing.Size(100, 3)
        Me.pnlHighlight.TabIndex = 0
        '
        'btnReports
        '
        Me.btnReports.AutoSize = True
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(200, 10)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(100, 42)
        Me.btnReports.TabIndex = 0
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(80, 26)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(220, 0)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 26)
        Me.btnMinimize.TabIndex = 0
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'pnlAccounts
        '
        Me.pnlAccounts.Controls.Add(Me.picRegisterAcc)
        Me.pnlAccounts.Controls.Add(Me.btnRegisterAcc)
        Me.pnlAccounts.Controls.Add(Me.picUpdateAcc)
        Me.pnlAccounts.Controls.Add(Me.btnUpdateAcc)
        Me.pnlAccounts.Controls.Add(Me.picDeleteAcc)
        Me.pnlAccounts.Controls.Add(Me.btnDeleteAcc)
        Me.pnlAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAccounts.Location = New System.Drawing.Point(0, 195)
        Me.pnlAccounts.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlAccounts.Name = "pnlAccounts"
        Me.pnlAccounts.Size = New System.Drawing.Size(300, 312)
        Me.pnlAccounts.TabIndex = 0
        '
        'picRegisterAcc
        '
        Me.picRegisterAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.picRegisterAcc.Image = Global.HostelManagementSystem.My.Resources.Resources.RegisterAccount
        Me.picRegisterAcc.Location = New System.Drawing.Point(25, 26)
        Me.picRegisterAcc.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.picRegisterAcc.Name = "picRegisterAcc"
        Me.picRegisterAcc.Size = New System.Drawing.Size(50, 65)
        Me.picRegisterAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRegisterAcc.TabIndex = 8
        Me.picRegisterAcc.TabStop = False
        '
        'btnRegisterAcc
        '
        Me.btnRegisterAcc.AutoSize = True
        Me.btnRegisterAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnRegisterAcc.FlatAppearance.BorderSize = 0
        Me.btnRegisterAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterAcc.Location = New System.Drawing.Point(75, 26)
        Me.btnRegisterAcc.Name = "btnRegisterAcc"
        Me.btnRegisterAcc.Size = New System.Drawing.Size(200, 65)
        Me.btnRegisterAcc.TabIndex = 0
        Me.btnRegisterAcc.Text = "     Register Account"
        Me.btnRegisterAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegisterAcc.UseVisualStyleBackColor = False
        '
        'picUpdateAcc
        '
        Me.picUpdateAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.picUpdateAcc.Image = Global.HostelManagementSystem.My.Resources.Resources.UpdateAccount
        Me.picUpdateAcc.Location = New System.Drawing.Point(25, 117)
        Me.picUpdateAcc.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.picUpdateAcc.Name = "picUpdateAcc"
        Me.picUpdateAcc.Size = New System.Drawing.Size(50, 65)
        Me.picUpdateAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUpdateAcc.TabIndex = 9
        Me.picUpdateAcc.TabStop = False
        '
        'btnUpdateAcc
        '
        Me.btnUpdateAcc.AutoSize = True
        Me.btnUpdateAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnUpdateAcc.FlatAppearance.BorderSize = 0
        Me.btnUpdateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateAcc.Location = New System.Drawing.Point(75, 117)
        Me.btnUpdateAcc.Name = "btnUpdateAcc"
        Me.btnUpdateAcc.Size = New System.Drawing.Size(200, 65)
        Me.btnUpdateAcc.TabIndex = 0
        Me.btnUpdateAcc.Text = "     Update Account"
        Me.btnUpdateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateAcc.UseVisualStyleBackColor = False
        '
        'picDeleteAcc
        '
        Me.picDeleteAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.picDeleteAcc.Image = Global.HostelManagementSystem.My.Resources.Resources.RemoveAccount
        Me.picDeleteAcc.Location = New System.Drawing.Point(25, 208)
        Me.picDeleteAcc.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.picDeleteAcc.Name = "picDeleteAcc"
        Me.picDeleteAcc.Size = New System.Drawing.Size(50, 65)
        Me.picDeleteAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDeleteAcc.TabIndex = 10
        Me.picDeleteAcc.TabStop = False
        '
        'btnDeleteAcc
        '
        Me.btnDeleteAcc.AutoSize = True
        Me.btnDeleteAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnDeleteAcc.FlatAppearance.BorderSize = 0
        Me.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAcc.Location = New System.Drawing.Point(75, 208)
        Me.btnDeleteAcc.Name = "btnDeleteAcc"
        Me.btnDeleteAcc.Size = New System.Drawing.Size(200, 65)
        Me.btnDeleteAcc.TabIndex = 0
        Me.btnDeleteAcc.Text = "     Delete Account"
        Me.btnDeleteAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteAcc.UseVisualStyleBackColor = False
        '
        'pnlReports
        '
        Me.pnlReports.Controls.Add(Me.picStudentReports)
        Me.pnlReports.Controls.Add(Me.btnStudentReports)
        Me.pnlReports.Controls.Add(Me.picPaymentReports)
        Me.pnlReports.Controls.Add(Me.btnPaymentReports)
        Me.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReports.Location = New System.Drawing.Point(0, 195)
        Me.pnlReports.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlReports.Name = "pnlReports"
        Me.pnlReports.Size = New System.Drawing.Size(300, 312)
        Me.pnlReports.TabIndex = 0
        Me.pnlReports.Visible = False
        '
        'picStudentReports
        '
        Me.picStudentReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.picStudentReports.BackgroundImage = Global.HostelManagementSystem.My.Resources.Resources.StudentReports
        Me.picStudentReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picStudentReports.Location = New System.Drawing.Point(25, 26)
        Me.picStudentReports.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.picStudentReports.Name = "picStudentReports"
        Me.picStudentReports.Size = New System.Drawing.Size(50, 65)
        Me.picStudentReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStudentReports.TabIndex = 16
        Me.picStudentReports.TabStop = False
        '
        'btnStudentReports
        '
        Me.btnStudentReports.AutoSize = True
        Me.btnStudentReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnStudentReports.FlatAppearance.BorderSize = 0
        Me.btnStudentReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentReports.Location = New System.Drawing.Point(75, 26)
        Me.btnStudentReports.Name = "btnStudentReports"
        Me.btnStudentReports.Size = New System.Drawing.Size(200, 65)
        Me.btnStudentReports.TabIndex = 0
        Me.btnStudentReports.Text = "     Student Reports"
        Me.btnStudentReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentReports.UseVisualStyleBackColor = False
        '
        'picPaymentReports
        '
        Me.picPaymentReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.picPaymentReports.BackgroundImage = Global.HostelManagementSystem.My.Resources.Resources.PaymentReports
        Me.picPaymentReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picPaymentReports.Location = New System.Drawing.Point(25, 117)
        Me.picPaymentReports.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.picPaymentReports.Name = "picPaymentReports"
        Me.picPaymentReports.Size = New System.Drawing.Size(50, 65)
        Me.picPaymentReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPaymentReports.TabIndex = 14
        Me.picPaymentReports.TabStop = False
        '
        'btnPaymentReports
        '
        Me.btnPaymentReports.AutoSize = True
        Me.btnPaymentReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnPaymentReports.FlatAppearance.BorderSize = 0
        Me.btnPaymentReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaymentReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaymentReports.Location = New System.Drawing.Point(75, 117)
        Me.btnPaymentReports.Name = "btnPaymentReports"
        Me.btnPaymentReports.Size = New System.Drawing.Size(200, 65)
        Me.btnPaymentReports.TabIndex = 0
        Me.btnPaymentReports.Text = "     Payment Reports"
        Me.btnPaymentReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaymentReports.UseVisualStyleBackColor = False
        '
        'pnlPayment
        '
        Me.pnlPayment.Controls.Add(Me.picAddPayRec)
        Me.pnlPayment.Controls.Add(Me.btnAddPayRec)
        Me.pnlPayment.Controls.Add(Me.picUpdatePayRec)
        Me.pnlPayment.Controls.Add(Me.btnUpdatePayRec)
        Me.pnlPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPayment.Location = New System.Drawing.Point(0, 195)
        Me.pnlPayment.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pnlPayment.Name = "pnlPayment"
        Me.pnlPayment.Size = New System.Drawing.Size(300, 312)
        Me.pnlPayment.TabIndex = 0
        Me.pnlPayment.Visible = False
        '
        'picAddPayRec
        '
        Me.picAddPayRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.picAddPayRec.Image = Global.HostelManagementSystem.My.Resources.Resources.AddPaymentRecords
        Me.picAddPayRec.Location = New System.Drawing.Point(25, 26)
        Me.picAddPayRec.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.picAddPayRec.Name = "picAddPayRec"
        Me.picAddPayRec.Size = New System.Drawing.Size(50, 65)
        Me.picAddPayRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAddPayRec.TabIndex = 15
        Me.picAddPayRec.TabStop = False
        '
        'btnAddPayRec
        '
        Me.btnAddPayRec.AutoSize = True
        Me.btnAddPayRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnAddPayRec.FlatAppearance.BorderSize = 0
        Me.btnAddPayRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPayRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPayRec.Location = New System.Drawing.Point(75, 26)
        Me.btnAddPayRec.Name = "btnAddPayRec"
        Me.btnAddPayRec.Size = New System.Drawing.Size(200, 65)
        Me.btnAddPayRec.TabIndex = 0
        Me.btnAddPayRec.Text = "     Add Record"
        Me.btnAddPayRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPayRec.UseVisualStyleBackColor = False
        '
        'picUpdatePayRec
        '
        Me.picUpdatePayRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.picUpdatePayRec.Image = Global.HostelManagementSystem.My.Resources.Resources.EditPaymentRecords
        Me.picUpdatePayRec.Location = New System.Drawing.Point(25, 117)
        Me.picUpdatePayRec.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.picUpdatePayRec.Name = "picUpdatePayRec"
        Me.picUpdatePayRec.Size = New System.Drawing.Size(50, 65)
        Me.picUpdatePayRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUpdatePayRec.TabIndex = 16
        Me.picUpdatePayRec.TabStop = False
        '
        'btnUpdatePayRec
        '
        Me.btnUpdatePayRec.AutoSize = True
        Me.btnUpdatePayRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnUpdatePayRec.FlatAppearance.BorderSize = 0
        Me.btnUpdatePayRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdatePayRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePayRec.Location = New System.Drawing.Point(75, 117)
        Me.btnUpdatePayRec.Name = "btnUpdatePayRec"
        Me.btnUpdatePayRec.Size = New System.Drawing.Size(200, 65)
        Me.btnUpdatePayRec.TabIndex = 0
        Me.btnUpdatePayRec.Text = "     Update Record"
        Me.btnUpdatePayRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdatePayRec.UseVisualStyleBackColor = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 507)
        Me.Controls.Add(Me.pnlReports)
        Me.Controls.Add(Me.pnlPayment)
        Me.Controls.Add(Me.pnlAccounts)
        Me.Controls.Add(Me.pnlTitlebar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MinimumSize = New System.Drawing.Size(300, 507)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.pnlTitlebar.ResumeLayout(False)
        Me.pnlNavbar.ResumeLayout(False)
        Me.pnlNavbar.PerformLayout()
        Me.pnlAccounts.ResumeLayout(False)
        Me.pnlAccounts.PerformLayout()
        CType(Me.picRegisterAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpdateAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeleteAcc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlReports.ResumeLayout(False)
        Me.pnlReports.PerformLayout()
        CType(Me.picStudentReports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPaymentReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPayment.ResumeLayout(False)
        Me.pnlPayment.PerformLayout()
        CType(Me.picAddPayRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUpdatePayRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents lblHowdy As Label
    Friend WithEvents pnlTitlebar As Panel
    Friend WithEvents pnlHighlight As Panel
    Friend WithEvents pnlAccounts As Panel
    Friend WithEvents btnUpdateAcc As Button
    Friend WithEvents btnDeleteAcc As Button
    Friend WithEvents btnRegisterAcc As Button
    Friend WithEvents pnlReports As Panel
    Friend WithEvents picDeleteAcc As PictureBox
    Friend WithEvents picUpdateAcc As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlNavbar As Panel
    Friend WithEvents pnlPayment As Panel
    Friend WithEvents picRegisterAcc As PictureBox
    Friend WithEvents btnReports As Button
    Friend WithEvents picPaymentReports As PictureBox
    Friend WithEvents btnPaymentReports As Button
    Friend WithEvents picAddPayRec As PictureBox
    Friend WithEvents btnAddPayRec As Button
    Friend WithEvents picUpdatePayRec As PictureBox
    Friend WithEvents btnUpdatePayRec As Button
    Friend WithEvents picStudentReports As PictureBox
    Friend WithEvents btnStudentReports As Button
    Friend WithEvents btnMinimize As Button
End Class
