<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModFaculty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModFaculty))
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
        Me.C1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TID = New System.Windows.Forms.Label()
        Me.C2 = New System.Windows.Forms.Label()
        Me.C3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dept = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FN = New System.Windows.Forms.TextBox()
        Me.MOB = New System.Windows.Forms.TextBox()
        Me.DT = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.C1.Location = New System.Drawing.Point(141, 93)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(0, 22)
        Me.C1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(859, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Full Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label12.Location = New System.Drawing.Point(859, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "ID"
        '
        'TID
        '
        Me.TID.AutoSize = True
        Me.TID.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TID.Location = New System.Drawing.Point(1056, 135)
        Me.TID.Name = "TID"
        Me.TID.Size = New System.Drawing.Size(0, 22)
        Me.TID.TabIndex = 0
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
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.C3.Location = New System.Drawing.Point(806, 93)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(0, 22)
        Me.C3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(285, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(859, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mobile"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(858, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Department"
        '
        'dept
        '
        Me.dept.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.dept.FormattingEnabled = True
        Me.dept.Items.AddRange(New Object() {"IT ", "MATH", "HOD"})
        Me.dept.Location = New System.Drawing.Point(515, 47)
        Me.dept.Name = "dept"
        Me.dept.Size = New System.Drawing.Size(185, 35)
        Me.dept.TabIndex = 1
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
        'Button1
        '
        Me.Button1.BackgroundImage = Global.TimeTableGenerator.My.Resources.Resources.update
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(863, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.TimeTableGenerator.My.Resources.Resources.cancel
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(1075, 389)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 44)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 307)
        Me.DataGridView1.TabIndex = 5
        '
        'FN
        '
        Me.FN.Location = New System.Drawing.Point(972, 181)
        Me.FN.Name = "FN"
        Me.FN.Size = New System.Drawing.Size(177, 35)
        Me.FN.TabIndex = 6
        '
        'MOB
        '
        Me.MOB.Location = New System.Drawing.Point(972, 246)
        Me.MOB.Name = "MOB"
        Me.MOB.Size = New System.Drawing.Size(177, 35)
        Me.MOB.TabIndex = 6
        '
        'DT
        '
        Me.DT.Location = New System.Drawing.Point(972, 308)
        Me.DT.Name = "DT"
        Me.DT.Size = New System.Drawing.Size(177, 35)
        Me.DT.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.DT)
        Me.GroupBox1.Controls.Add(Me.MOB)
        Me.GroupBox1.Controls.Add(Me.FN)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.dept)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.C3)
        Me.GroupBox1.Controls.Add(Me.C2)
        Me.GroupBox1.Controls.Add(Me.TID)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.C1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1224, 458)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Faculty"
        '
        'ModFaculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1366, 768)
        Me.Name = "ModFaculty"
        Me.Text = "ModFaculty"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents C1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TID As System.Windows.Forms.Label
    Friend WithEvents C2 As System.Windows.Forms.Label
    Friend WithEvents C3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dept As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FN As System.Windows.Forms.TextBox
    Friend WithEvents MOB As System.Windows.Forms.TextBox
    Friend WithEvents DT As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
