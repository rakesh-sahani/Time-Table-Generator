<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFaculty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddFaculty))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacultyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeTableToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFacultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacultyToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CourseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeTableToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFacultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.mob = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.dept = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCourseToolStripMenuItem, Me.AddFacultyToolStripMenuItem, Me.ViewFacultyToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddCourseToolStripMenuItem
        '
        Me.AddCourseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacultyToolStripMenuItem1, Me.CourseToolStripMenuItem, Me.TimeTableToolStripMenuItem1})
        Me.AddCourseToolStripMenuItem.Name = "AddCourseToolStripMenuItem"
        Me.AddCourseToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddCourseToolStripMenuItem.Text = "Add"
        '
        'FacultyToolStripMenuItem1
        '
        Me.FacultyToolStripMenuItem1.Name = "FacultyToolStripMenuItem1"
        Me.FacultyToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FacultyToolStripMenuItem1.Text = "Faculty"
        '
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CourseToolStripMenuItem.Text = "Course"
        '
        'TimeTableToolStripMenuItem1
        '
        Me.TimeTableToolStripMenuItem1.Name = "TimeTableToolStripMenuItem1"
        Me.TimeTableToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.TimeTableToolStripMenuItem1.Text = "TimeTable"
        '
        'AddFacultyToolStripMenuItem
        '
        Me.AddFacultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacultyToolStripMenuItem2, Me.CourseToolStripMenuItem1, Me.TimeTableToolStripMenuItem2})
        Me.AddFacultyToolStripMenuItem.Name = "AddFacultyToolStripMenuItem"
        Me.AddFacultyToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.AddFacultyToolStripMenuItem.Text = "Modify"
        '
        'FacultyToolStripMenuItem2
        '
        Me.FacultyToolStripMenuItem2.Name = "FacultyToolStripMenuItem2"
        Me.FacultyToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
        Me.FacultyToolStripMenuItem2.Text = "Faculty"
        '
        'CourseToolStripMenuItem1
        '
        Me.CourseToolStripMenuItem1.Name = "CourseToolStripMenuItem1"
        Me.CourseToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.CourseToolStripMenuItem1.Text = "Course"
        '
        'TimeTableToolStripMenuItem2
        '
        Me.TimeTableToolStripMenuItem2.Name = "TimeTableToolStripMenuItem2"
        Me.TimeTableToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
        Me.TimeTableToolStripMenuItem2.Text = "TimeTable"
        '
        'ViewFacultyToolStripMenuItem
        '
        Me.ViewFacultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacultyToolStripMenuItem, Me.CoursesToolStripMenuItem, Me.TimeTableToolStripMenuItem})
        Me.ViewFacultyToolStripMenuItem.Name = "ViewFacultyToolStripMenuItem"
        Me.ViewFacultyToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ViewFacultyToolStripMenuItem.Text = "View "
        '
        'FacultyToolStripMenuItem
        '
        Me.FacultyToolStripMenuItem.Name = "FacultyToolStripMenuItem"
        Me.FacultyToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.FacultyToolStripMenuItem.Text = "Faculty"
        '
        'CoursesToolStripMenuItem
        '
        Me.CoursesToolStripMenuItem.Name = "CoursesToolStripMenuItem"
        Me.CoursesToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CoursesToolStripMenuItem.Text = "Course"
        '
        'TimeTableToolStripMenuItem
        '
        Me.TimeTableToolStripMenuItem.Name = "TimeTableToolStripMenuItem"
        Me.TimeTableToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.TimeTableToolStripMenuItem.Text = "Time Table"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.pass)
        Me.GroupBox1.Controls.Add(Me.mob)
        Me.GroupBox1.Controls.Add(Me.fname)
        Me.GroupBox1.Controls.Add(Me.dept)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(313, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(744, 509)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Faculty Details"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.TimeTableGenerator.My.Resources.Resources.Submit
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(300, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 55)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pass
        '
        Me.pass.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.pass.Location = New System.Drawing.Point(367, 280)
        Me.pass.Multiline = True
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(292, 38)
        Me.pass.TabIndex = 2
        '
        'mob
        '
        Me.mob.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.mob.Location = New System.Drawing.Point(367, 139)
        Me.mob.Multiline = True
        Me.mob.Name = "mob"
        Me.mob.Size = New System.Drawing.Size(292, 38)
        Me.mob.TabIndex = 2
        '
        'fname
        '
        Me.fname.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.fname.Location = New System.Drawing.Point(367, 67)
        Me.fname.Multiline = True
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(292, 38)
        Me.fname.TabIndex = 2
        '
        'dept
        '
        Me.dept.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.dept.FormattingEnabled = True
        Me.dept.Items.AddRange(New Object() {"IT ", "MATH", "HOD"})
        Me.dept.Location = New System.Drawing.Point(367, 222)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(292, 35)
        Me.dept.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(100, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mobile "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(101, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(100, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Department"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(100, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TimeTableGenerator.My.Resources.Resources.Header
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1326, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(1063, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "* UserName"
        '
        'AddFaculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "AddFaculty"
        Me.Text = "AddFaculty"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddCourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeTableToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeTableToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoursesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents mob As System.Windows.Forms.TextBox
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents dept As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
