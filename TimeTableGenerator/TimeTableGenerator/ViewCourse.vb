
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class ViewCourse
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND As New MySqlCommand
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim SQLCODE As String
        SQLCODE = "select course as 'Course',Year,sem as 'Semester',scode as 'Subject Code' ,sname as 'Subject Name' ,lname as 'Lecturer' from Course where course = '" & Course.Text & "'"
        CONNECT.Open()
        COMMAND = New MySqlCommand(SQLCODE, CONNECT)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        DataGridView1.DataSource = bSource
        SDA.Update(dbDataset)
        CONNECT.Close()
        Me.Visible = True
    End Sub

    
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        AddCourse.Show()
        Me.Hide()
    End Sub

    Private Sub FacultyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem1.Click
        AddFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem1.Click
        AddTimeTable.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem1.Click
        ModCourse.Show()
        Me.Hide()
    End Sub

    Private Sub FacultyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem2.Click
        ModFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem2.Click
        ModTimeTable.Show()
        Me.Hide()
    End Sub
    Private Sub FacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem.Click
        ViewFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem.Click
        ViewTimeTable.Show()
        Me.Hide()
    End Sub


    Private Sub CoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class