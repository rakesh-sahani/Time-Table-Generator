<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModCourse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModCourse))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.L = New System.Windows.Forms.TextBox()
        Me.SU = New System.Windows.Forms.TextBox()
        Me.SC = New System.Windows.Forms.TextBox()
        Me.S = New System.Windows.Forms.TextBox()
        Me.Y = New System.Windows.Forms.TextBox()
        Me.C = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Semester = New System.Windows.Forms.ComboBox()
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.Course = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C3 = New System.Windows.Forms.Label()
        Me.C2 = New System.Windows.Forms.Label()
        Me.TID = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TimeTableGenerator.My.Resources.Resources.Header
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1326, 149)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCourseToolStripMenuItem, Me.AddFacultyToolStripMenuItem, Me.ViewFacultyToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddCourseToolStripMenuItem
        '
        Me.AddCourseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacultyToolStripMenuItem1, Me.CourseToolStripMenuItem, Me.TimeTableToolStripMenuItem1})
        Me.AddCourseToolStripMenuItem.Name = "AddCourseToolStripMenuItem"
        Me.AddCourseToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AddCourseToolStripMenuItem.Text = "Add "
        '
        'FacultyToolStripMenuItem1
        '
        Me.FacultyToolStripMenuItem1.Name = "FacultyToolStripMenuItem1"
        Me.FacultyToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.FacultyToolStripMenuItem1.Text = "Faculty"
        '
        'CourseToolStripMenuItem
        '
        Me.CourseToolStripMenuItem.Name = "CourseToolStripMenuItem"
        Me.CourseToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CourseToolStripMenuItem.Text = "Course"
        '
        'TimeTableToolStripMenuItem1
        '
        Me.TimeTableToolStripMenuItem1.Name = "TimeTableToolStripMenuItem1"
        Me.TimeTableToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
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
        Me.ViewFacultyToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewFacultyToolStripMenuItem.Text = "View"
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
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.L)
        Me.GroupBox1.Controls.Add(Me.SU)
        Me.GroupBox1.Controls.Add(Me.SC)
        Me.GroupBox1.Controls.Add(Me.S)
        Me.GroupBox1.Controls.Add(Me.Y)
        Me.GroupBox1.Controls.Add(Me.C)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Semester)
        Me.GroupBox1.Controls.Add(Me.Year)
        Me.GroupBox1.Controls.Add(Me.Course)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.C3)
        Me.GroupBox1.Controls.Add(Me.C2)
        Me.GroupBox1.Controls.Add(Me.TID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.C1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1326, 502)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TimeTable"
        '
        'L
        '
        Me.L.Location = New System.Drawing.Point(1120, 337)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(177, 35)
        Me.L.TabIndex = 6
        '
        'SU
        '
        Me.SU.Location = New System.Drawing.Point(1120, 296)
        Me.SU.Name = "SU"
        Me.SU.Size = New System.Drawing.Size(177, 35)
        Me.SU.TabIndex = 6
        '
        'SC
        '
        Me.SC.Location = New System.Drawing.Point(1120, 255)
        Me.SC.Name = "SC"
        Me.SC.Size = New System.Drawing.Size(177, 35)
        Me.SC.TabIndex = 6
        '
        'S
        '
        Me.S.Location = New System.Drawing.Point(1120, 219)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(177, 35)
        Me.S.TabIndex = 6
        '
        'Y
        '
        Me.Y.Location = New System.Drawing.Point(1120, 183)
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(177, 35)
        Me.Y.TabIndex = 6
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(1120, 147)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(177, 35)
        Me.C.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(979, 307)
        Me.DataGridView1.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.TimeTableGenerator.My.Resources.Resources.cancel
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(871, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 44)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.TimeTableGenerator.My.Resources.Resources.update
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(661, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.TimeTableGenerator.My.Resources.Resources.search
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(1041, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 44)
        Me.Button2.TabIndex = 4
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Semester
        '
        Me.Semester.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.Semester.FormattingEnabled = True
        Me.Semester.Items.AddRange(New Object() {"First", "Second ", "Third", "Fourth", "Fifth", "Sixth"})
        Me.Semester.Location = New System.Drawing.Point(809, 47)
        Me.Semester.Name = "Semester"
        Me.Semester.Size = New System.Drawing.Size(185, 35)
        Me.Semester.TabIndex = 1
        '
        'Year
        '
        Me.Year.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.Year.FormattingEnabled = True
        Me.Year.Items.AddRange(New Object() {"First", "Second", "Third"})
        Me.Year.Location = New System.Drawing.Point(456, 47)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(185, 35)
        Me.Year.TabIndex = 1
        '
        'Course
        '
        Me.Course.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.Course.FormattingEnabled = True
        Me.Course.Items.AddRange(New Object() {"MCA", "MSC", "PGDCA"})
        Me.Course.Location = New System.Drawing.Point(113, 47)
        Me.Course.Name = "Course"
        Me.Course.Size = New System.Drawing.Size(185, 35)
        Me.Course.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label11.Location = New System.Drawing.Point(1007, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Lecturer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label10.Location = New System.Drawing.Point(1007, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Subject"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(1007, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sub-Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(1006, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Semester"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(1007, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(690, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Semester"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(365, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Year"
        '
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.C3.Location = New System.Drawing.Point(806, 93)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(0, 22)
        Me.C3.TabIndex = 0
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.C2.Location = New System.Drawing.Point(453, 93)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(0, 22)
        Me.C2.TabIndex = 0
        '
        'TID
        '
        Me.TID.AutoSize = True
        Me.TID.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TID.Location = New System.Drawing.Point(1204, 122)
        Me.TID.Name = "TID"
        Me.TID.Size = New System.Drawing.Size(0, 22)
        Me.TID.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label12.Location = New System.Drawing.Point(1007, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(1007, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Course"
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.C1.Location = New System.Drawing.Point(141, 93)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(0, 22)
        Me.C1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course"
        '
        'ModCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "ModCourse"
        Me.Text = "ModCourse"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddCourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeTableToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeTableToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CoursesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents L As System.Windows.Forms.TextBox
    Friend WithEvents SU As System.Windows.Forms.TextBox
    Friend WithEvents SC As System.Windows.Forms.TextBox
    Friend WithEvents S As System.Windows.Forms.TextBox
    Friend WithEvents Y As System.Windows.Forms.TextBox
    Friend WithEvents C As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Semester As System.Windows.Forms.ComboBox
    Friend WithEvents Year As System.Windows.Forms.ComboBox
    Friend WithEvents Course As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C3 As System.Windows.Forms.Label
    Friend WithEvents C2 As System.Windows.Forms.Label
    Friend WithEvents TID As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
