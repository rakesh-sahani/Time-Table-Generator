Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class AddCourse
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND1, COMMAND2, COMMAND3, COMMAND4, COMMAND5 As New MySqlCommand
        Dim SQLCODE1, SQLCODE2, SQLCODE3, SQLCODE4, SQLCODE5 As String
        SQLCODE1 = "insert into Course ( `course`, `year`, `sem`, `scode`, `sname`,`lname`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & S1.Text & "','" & SN1.Text & "','" & L1.Text & "')"
        SQLCODE2 = "insert into Course ( `course`, `year`, `sem`, `scode`, `sname`,`lname`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & S2.Text & "','" & SN2.Text & "','" & L2.Text & "')"
        SQLCODE3 = "insert into Course ( `course`, `year`, `sem`, `scode`, `sname`,`lname`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & S3.Text & "','" & SN3.Text & "','" & L3.Text & "')"
        SQLCODE4 = "insert into Course ( `course`, `year`, `sem`, `scode`, `sname`,`lname`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & S4.Text & "','" & SN4.Text & "','" & L4.Text & "')"
        SQLCODE5 = "insert into Course ( `course`, `year`, `sem`, `scode`, `sname`,`lname`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & S5.Text & "','" & SN5.Text & "','" & L5.Text & "')"
        CONNECT.Open()
        COMMAND1 = New MySqlCommand(SQLCODE1, CONNECT)
        COMMAND2 = New MySqlCommand(SQLCODE2, CONNECT)
        COMMAND3 = New MySqlCommand(SQLCODE3, CONNECT)
        COMMAND4 = New MySqlCommand(SQLCODE4, CONNECT)
        COMMAND5 = New MySqlCommand(SQLCODE5, CONNECT)
        COMMAND1.ExecuteNonQuery()
        COMMAND2.ExecuteNonQuery()
        COMMAND3.ExecuteNonQuery()
        COMMAND4.ExecuteNonQuery()
        COMMAND5.ExecuteNonQuery()
        CONNECT.Close()
        MsgBox("Course Details Submitted Successfully.")
        Course.ResetText()
        Year.ResetText()
        Semester.ResetText()
        S1.Clear()
        S2.Clear()
        S3.Clear()
        S4.Clear()
        S5.Clear()
        SN1.Clear()
        SN2.Clear()
        SN3.Clear()
        SN4.Clear()
        SN5.Clear()
        L1.ResetText()
        L2.ResetText()
        L3.ResetText()
        L4.ResetText()
        L5.ResetText()
        Me.Visible = True
    End Sub

    Private Sub AddCourse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND As New MySqlCommand
        Dim SQLCODE As String
        Dim reader As MySqlDataReader
        SQLCODE = "select fullname from faculty"
        CONNECT.Open()
        COMMAND = New MySqlCommand(SQLCODE, CONNECT)
        reader = COMMAND.ExecuteReader
        While reader.Read
            Dim Fname = reader.GetString("fullname")
            L1.Items.Add(Fname)
            L2.Items.Add(Fname)
            L3.Items.Add(Fname)
            L4.Items.Add(Fname)
            L5.Items.Add(Fname)
        End While
        CONNECT.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
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

    Private Sub CoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem.Click
        ViewCourse.Show()
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
    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class