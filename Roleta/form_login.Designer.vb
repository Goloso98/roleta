<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_login
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
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.lbl_error_login = New System.Windows.Forms.Label()
        Me.but_login = New System.Windows.Forms.Button()
        Me.but_SignUp = New System.Windows.Forms.Button()
        Me.panel_signup = New System.Windows.Forms.Panel()
        Me.but_signup_add = New System.Windows.Forms.Button()
        Me.txt_signup_Lname = New System.Windows.Forms.TextBox()
        Me.txt_signup_Fname = New System.Windows.Forms.TextBox()
        Me.lbl_signup_Lname = New System.Windows.Forms.Label()
        Me.lbl_signup_Fname = New System.Windows.Forms.Label()
        Me.txt_signup_pass2 = New System.Windows.Forms.TextBox()
        Me.lbl_signup_pass2 = New System.Windows.Forms.Label()
        Me.txt_signup_pass = New System.Windows.Forms.TextBox()
        Me.lbl_signup_pass = New System.Windows.Forms.Label()
        Me.txt_signup_user = New System.Windows.Forms.TextBox()
        Me.lbl_signup_user = New System.Windows.Forms.Label()
        Me.lbl_signup = New System.Windows.Forms.Label()
        Me.panel_signup.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_user
        '
        Me.lbl_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user.Location = New System.Drawing.Point(14, 58)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(103, 17)
        Me.lbl_user.TabIndex = 0
        Me.lbl_user.Text = "User:"
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(123, 55)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(147, 22)
        Me.txt_user.TabIndex = 1
        '
        'lbl_pass
        '
        Me.lbl_pass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pass.Location = New System.Drawing.Point(11, 84)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(106, 17)
        Me.lbl_pass.TabIndex = 0
        Me.lbl_pass.Text = "Password:"
        Me.lbl_pass.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(123, 81)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_pass.Size = New System.Drawing.Size(147, 22)
        Me.txt_pass.TabIndex = 2
        '
        'lbl_error_login
        '
        Me.lbl_error_login.AutoSize = True
        Me.lbl_error_login.BackColor = System.Drawing.Color.Transparent
        Me.lbl_error_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.lbl_error_login.ForeColor = System.Drawing.Color.Red
        Me.lbl_error_login.Location = New System.Drawing.Point(99, 106)
        Me.lbl_error_login.Name = "lbl_error_login"
        Me.lbl_error_login.Size = New System.Drawing.Size(95, 13)
        Me.lbl_error_login.TabIndex = 0
        Me.lbl_error_login.Text = "Password is wrong"
        Me.lbl_error_login.Visible = False
        '
        'but_login
        '
        Me.but_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_login.Location = New System.Drawing.Point(14, 132)
        Me.but_login.Name = "but_login"
        Me.but_login.Size = New System.Drawing.Size(149, 29)
        Me.but_login.TabIndex = 3
        Me.but_login.Text = "Login"
        Me.but_login.UseVisualStyleBackColor = True
        '
        'but_SignUp
        '
        Me.but_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.but_SignUp.Location = New System.Drawing.Point(169, 132)
        Me.but_SignUp.Name = "but_SignUp"
        Me.but_SignUp.Size = New System.Drawing.Size(101, 29)
        Me.but_SignUp.TabIndex = 4
        Me.but_SignUp.Text = "Sign Up"
        Me.but_SignUp.UseVisualStyleBackColor = True
        '
        'panel_signup
        '
        Me.panel_signup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_signup.Controls.Add(Me.but_signup_add)
        Me.panel_signup.Controls.Add(Me.txt_signup_Lname)
        Me.panel_signup.Controls.Add(Me.txt_signup_Fname)
        Me.panel_signup.Controls.Add(Me.lbl_signup_Lname)
        Me.panel_signup.Controls.Add(Me.lbl_signup_Fname)
        Me.panel_signup.Controls.Add(Me.txt_signup_pass2)
        Me.panel_signup.Controls.Add(Me.lbl_signup_pass2)
        Me.panel_signup.Controls.Add(Me.txt_signup_pass)
        Me.panel_signup.Controls.Add(Me.lbl_signup_pass)
        Me.panel_signup.Controls.Add(Me.txt_signup_user)
        Me.panel_signup.Controls.Add(Me.lbl_signup_user)
        Me.panel_signup.Controls.Add(Me.lbl_signup)
        Me.panel_signup.Location = New System.Drawing.Point(12, 237)
        Me.panel_signup.Name = "panel_signup"
        Me.panel_signup.Size = New System.Drawing.Size(258, 390)
        Me.panel_signup.TabIndex = 5
        '
        'but_signup_add
        '
        Me.but_signup_add.Location = New System.Drawing.Point(3, 351)
        Me.but_signup_add.Name = "but_signup_add"
        Me.but_signup_add.Size = New System.Drawing.Size(248, 29)
        Me.but_signup_add.TabIndex = 6
        Me.but_signup_add.TabStop = False
        Me.but_signup_add.Text = "Add user"
        Me.but_signup_add.UseVisualStyleBackColor = True
        '
        'txt_signup_Lname
        '
        Me.txt_signup_Lname.Location = New System.Drawing.Point(3, 322)
        Me.txt_signup_Lname.Name = "txt_signup_Lname"
        Me.txt_signup_Lname.Size = New System.Drawing.Size(248, 22)
        Me.txt_signup_Lname.TabIndex = 5
        Me.txt_signup_Lname.TabStop = False
        '
        'txt_signup_Fname
        '
        Me.txt_signup_Fname.Location = New System.Drawing.Point(3, 276)
        Me.txt_signup_Fname.Name = "txt_signup_Fname"
        Me.txt_signup_Fname.Size = New System.Drawing.Size(248, 22)
        Me.txt_signup_Fname.TabIndex = 4
        Me.txt_signup_Fname.TabStop = False
        '
        'lbl_signup_Lname
        '
        Me.lbl_signup_Lname.Location = New System.Drawing.Point(4, 302)
        Me.lbl_signup_Lname.Name = "lbl_signup_Lname"
        Me.lbl_signup_Lname.Size = New System.Drawing.Size(247, 17)
        Me.lbl_signup_Lname.TabIndex = 0
        Me.lbl_signup_Lname.Text = "Last Name"
        '
        'lbl_signup_Fname
        '
        Me.lbl_signup_Fname.Location = New System.Drawing.Point(4, 256)
        Me.lbl_signup_Fname.Name = "lbl_signup_Fname"
        Me.lbl_signup_Fname.Size = New System.Drawing.Size(247, 17)
        Me.lbl_signup_Fname.TabIndex = 0
        Me.lbl_signup_Fname.Text = "First Name"
        '
        'txt_signup_pass2
        '
        Me.txt_signup_pass2.Location = New System.Drawing.Point(3, 185)
        Me.txt_signup_pass2.Name = "txt_signup_pass2"
        Me.txt_signup_pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_signup_pass2.Size = New System.Drawing.Size(248, 22)
        Me.txt_signup_pass2.TabIndex = 3
        Me.txt_signup_pass2.TabStop = False
        '
        'lbl_signup_pass2
        '
        Me.lbl_signup_pass2.Location = New System.Drawing.Point(4, 165)
        Me.lbl_signup_pass2.Name = "lbl_signup_pass2"
        Me.lbl_signup_pass2.Size = New System.Drawing.Size(247, 17)
        Me.lbl_signup_pass2.TabIndex = 0
        Me.lbl_signup_pass2.Text = "Re-type password"
        '
        'txt_signup_pass
        '
        Me.txt_signup_pass.Location = New System.Drawing.Point(3, 139)
        Me.txt_signup_pass.Name = "txt_signup_pass"
        Me.txt_signup_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_signup_pass.Size = New System.Drawing.Size(248, 22)
        Me.txt_signup_pass.TabIndex = 2
        Me.txt_signup_pass.TabStop = False
        '
        'lbl_signup_pass
        '
        Me.lbl_signup_pass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_signup_pass.Location = New System.Drawing.Point(4, 119)
        Me.lbl_signup_pass.Name = "lbl_signup_pass"
        Me.lbl_signup_pass.Size = New System.Drawing.Size(247, 17)
        Me.lbl_signup_pass.TabIndex = 0
        Me.lbl_signup_pass.Text = "Password"
        '
        'txt_signup_user
        '
        Me.txt_signup_user.Location = New System.Drawing.Point(3, 77)
        Me.txt_signup_user.Name = "txt_signup_user"
        Me.txt_signup_user.Size = New System.Drawing.Size(248, 22)
        Me.txt_signup_user.TabIndex = 1
        Me.txt_signup_user.TabStop = False
        '
        'lbl_signup_user
        '
        Me.lbl_signup_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_signup_user.Location = New System.Drawing.Point(4, 57)
        Me.lbl_signup_user.Name = "lbl_signup_user"
        Me.lbl_signup_user.Size = New System.Drawing.Size(247, 17)
        Me.lbl_signup_user.TabIndex = 0
        Me.lbl_signup_user.Text = "Username"
        '
        'lbl_signup
        '
        Me.lbl_signup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_signup.Location = New System.Drawing.Point(4, 4)
        Me.lbl_signup.Name = "lbl_signup"
        Me.lbl_signup.Size = New System.Drawing.Size(247, 23)
        Me.lbl_signup.TabIndex = 0
        Me.lbl_signup.Text = "Sign Up"
        Me.lbl_signup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 639)
        Me.Controls.Add(Me.panel_signup)
        Me.Controls.Add(Me.but_SignUp)
        Me.Controls.Add(Me.but_login)
        Me.Controls.Add(Me.lbl_error_login)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "form_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.panel_signup.ResumeLayout(False)
        Me.panel_signup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_user As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_pass As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents lbl_error_login As Label
    Friend WithEvents but_login As Button
    Friend WithEvents but_SignUp As Button
    Friend WithEvents panel_signup As Panel
    Friend WithEvents but_signup_add As Button
    Friend WithEvents txt_signup_Lname As TextBox
    Friend WithEvents txt_signup_Fname As TextBox
    Friend WithEvents lbl_signup_Lname As Label
    Friend WithEvents lbl_signup_Fname As Label
    Friend WithEvents txt_signup_pass2 As TextBox
    Friend WithEvents lbl_signup_pass2 As Label
    Friend WithEvents txt_signup_pass As TextBox
    Friend WithEvents lbl_signup_pass As Label
    Friend WithEvents txt_signup_user As TextBox
    Friend WithEvents lbl_signup_user As Label
    Friend WithEvents lbl_signup As Label
End Class
