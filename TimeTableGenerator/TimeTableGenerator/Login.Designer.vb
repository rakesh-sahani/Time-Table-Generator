<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Admin = New System.Windows.Forms.RadioButton()
        Me.Faculty = New System.Windows.Forms.RadioButton()
        Me.AcessLevel = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AcessLevel.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserName
        '
        Me.UserName.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.UserName.Location = New System.Drawing.Point(479, 350)
        Me.UserName.Multiline = True
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(315, 47)
        Me.UserName.TabIndex = 2
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.Password.Location = New System.Drawing.Point(479, 428)
        Me.Password.Multiline = True
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(315, 42)
        Me.Password.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.TimeTableGenerator.My.Resources.Resources.LoginB
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(468, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(363, 55)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TimeTableGenerator.My.Resources.Resources.Login
        Me.PictureBox2.Location = New System.Drawing.Point(366, 304)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(584, 289)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TimeTableGenerator.My.Resources.Resources.Header
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1326, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Admin
        '
        Me.Admin.AutoSize = True
        Me.Admin.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.Admin.Location = New System.Drawing.Point(36, 19)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(98, 31)
        Me.Admin.TabIndex = 4
        Me.Admin.TabStop = True
        Me.Admin.Text = "Admin"
        Me.Admin.UseVisualStyleBackColor = True
        '
        'Faculty
        '
        Me.Faculty.AutoSize = True
        Me.Faculty.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Faculty.Location = New System.Drawing.Point(250, 19)
        Me.Faculty.Name = "Faculty"
        Me.Faculty.Size = New System.Drawing.Size(109, 31)
        Me.Faculty.TabIndex = 4
        Me.Faculty.TabStop = True
        Me.Faculty.Text = "Faculty"
        Me.Faculty.UseVisualStyleBackColor = True
        '
        'AcessLevel
        '
        Me.AcessLevel.Controls.Add(Me.Admin)
        Me.AcessLevel.Controls.Add(Me.Faculty)
        Me.AcessLevel.Location = New System.Drawing.Point(454, 259)
        Me.AcessLevel.Name = "AcessLevel"
        Me.AcessLevel.Size = New System.Drawing.Size(401, 56)
        Me.AcessLevel.TabIndex = 5
        Me.AcessLevel.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.AcessLevel)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "Login"
        Me.Text = "Welcome to Jamia Millia Islamia"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AcessLevel.ResumeLayout(False)
        Me.AcessLevel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Admin As System.Windows.Forms.RadioButton
    Friend WithEvents Faculty As System.Windows.Forms.RadioButton
    Friend WithEvents AcessLevel As System.Windows.Forms.GroupBox

End Class
