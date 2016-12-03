<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStats
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lblBls = New System.Windows.Forms.Label()
        Me.lblBlsstat = New System.Windows.Forms.Label()
        Me.lblBws = New System.Windows.Forms.Label()
        Me.lblBwsstat = New System.Windows.Forms.Label()
        Me.lblWl = New System.Windows.Forms.Label()
        Me.lblWlstat = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Green
        Me.GroupBox1.Controls.Add(Me.lbl_title)
        Me.GroupBox1.Controls.Add(Me.lblBls)
        Me.GroupBox1.Controls.Add(Me.lblBlsstat)
        Me.GroupBox1.Controls.Add(Me.lblBws)
        Me.GroupBox1.Controls.Add(Me.lblBwsstat)
        Me.GroupBox1.Controls.Add(Me.lblWl)
        Me.GroupBox1.Controls.Add(Me.lblWlstat)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(315, 521)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(12, 0)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(295, 91)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "CURRENT SESSION"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBls
        '
        Me.lblBls.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBls.Location = New System.Drawing.Point(8, 378)
        Me.lblBls.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBls.Name = "lblBls"
        Me.lblBls.Size = New System.Drawing.Size(299, 71)
        Me.lblBls.TabIndex = 0
        Me.lblBls.Text = "BIGGEST LOSING STREAK"
        Me.lblBls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBlsstat
        '
        Me.lblBlsstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlsstat.Location = New System.Drawing.Point(25, 449)
        Me.lblBlsstat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBlsstat.Name = "lblBlsstat"
        Me.lblBlsstat.Size = New System.Drawing.Size(270, 29)
        Me.lblBlsstat.TabIndex = 0
        Me.lblBlsstat.Text = "- - -"
        Me.lblBlsstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBws
        '
        Me.lblBws.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBws.Location = New System.Drawing.Point(8, 220)
        Me.lblBws.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBws.Name = "lblBws"
        Me.lblBws.Size = New System.Drawing.Size(299, 73)
        Me.lblBws.TabIndex = 0
        Me.lblBws.Text = "BIGGEST WIN STREAK"
        Me.lblBws.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBwsstat
        '
        Me.lblBwsstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBwsstat.Location = New System.Drawing.Point(25, 293)
        Me.lblBwsstat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBwsstat.Name = "lblBwsstat"
        Me.lblBwsstat.Size = New System.Drawing.Size(270, 29)
        Me.lblBwsstat.TabIndex = 0
        Me.lblBwsstat.Text = "- - -"
        Me.lblBwsstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWl
        '
        Me.lblWl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWl.Location = New System.Drawing.Point(8, 111)
        Me.lblWl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWl.Name = "lblWl"
        Me.lblWl.Size = New System.Drawing.Size(299, 37)
        Me.lblWl.TabIndex = 0
        Me.lblWl.Text = "WIN/LOSE RATE"
        Me.lblWl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWlstat
        '
        Me.lblWlstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWlstat.Location = New System.Drawing.Point(20, 167)
        Me.lblWlstat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWlstat.Name = "lblWlstat"
        Me.lblWlstat.Size = New System.Drawing.Size(275, 29)
        Me.lblWlstat.TabIndex = 0
        Me.lblWlstat.Text = "- - -"
        Me.lblWlstat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(347, 550)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stats"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblBls As Label
    Friend WithEvents lblBlsstat As Label
    Friend WithEvents lblBwsstat As Label
    Friend WithEvents lblWl As Label
    Friend WithEvents lblWlstat As Label
    Friend WithEvents lblBws As Label
    Friend WithEvents lbl_title As Label
End Class
