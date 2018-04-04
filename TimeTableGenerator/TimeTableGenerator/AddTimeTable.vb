Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class AddTimeTable

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


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND As New MySqlCommand
        Dim SQLCODE As String
        Dim reader As MySqlDataReader
        SQLCODE = "select sname,lname from course where course = '" & Course.Text & "' and year = '" & Year.Text & "'and sem = '" & Semester.Text & "'"
        CONNECT.Open()
        COMMAND = New MySqlCommand(SQLCODE, CONNECT)
        reader = COMMAND.ExecuteReader
        While reader.Read
            Dim Sname = reader.GetString("sname")
            S1.Items.Add(Sname)
            S2.Items.Add(Sname)
            S3.Items.Add(Sname)
            S4.Items.Add(Sname)
            S5.Items.Add(Sname)
            S6.Items.Add(Sname)
            Dim Lname = reader.GetString("lname")
            L1.Items.Add(Lname)
            L2.Items.Add(Lname)
            L3.Items.Add(Lname)
            L4.Items.Add(Lname)
            L5.Items.Add(Lname)
            L6.Items.Add(Lname)
        End While
        MsgBox("Fill Time Table Details.")
        CONNECT.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND1, COMMAND2, COMMAND3, COMMAND4, COMMAND5, COMMAND6 As New MySqlCommand
        Dim SQLCODE1, SQLCODE2, SQLCODE3, SQLCODE4, SQLCODE5, SQLCODE6 As String
        SQLCODE1 = "INSERT INTO timetable (`Course`, `Year`, `Semester`, `Day`, `StartTime`, `EndTime`, `Subject`, `Lecturer`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & D1.Text & "','" & T1.Text & "','" & E1.Text & "','" & S1.Text & "','" & L1.Text & "')"
        SQLCODE2 = "INSERT INTO timetable (`Course`, `Year`, `Semester`, `Day`, `StartTime`, `EndTime`, `Subject`, `Lecturer`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & D2.Text & "','" & T2.Text & "','" & E2.Text & "','" & S2.Text & "','" & L2.Text & "')"
        SQLCODE3 = "INSERT INTO timetable (`Course`, `Year`, `Semester`, `Day`, `StartTime`, `EndTime`, `Subject`, `Lecturer`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & D3.Text & "','" & T3.Text & "','" & E3.Text & "','" & S3.Text & "','" & L3.Text & "')"
        SQLCODE4 = "INSERT INTO timetable (`Course`, `Year`, `Semester`, `Day`, `StartTime`, `EndTime`, `Subject`, `Lecturer`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & D4.Text & "','" & T4.Text & "','" & E4.Text & "','" & S4.Text & "','" & L4.Text & "')"
        SQLCODE5 = "INSERT INTO timetable (`Course`, `Year`, `Semester`, `Day`, `StartTime`, `EndTime`, `Subject`, `Lecturer`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & D5.Text & "','" & T5.Text & "','" & E5.Text & "','" & S5.Text & "','" & L5.Text & "')"
        SQLCODE6 = "INSERT INTO timetable (`Course`, `Year`, `Semester`, `Day`, `StartTime`, `EndTime`, `Subject`, `Lecturer`) VALUES ('" & Course.Text & "','" & Year.Text & "','" & Semester.Text & "','" & D6.Text & "','" & T6.Text & "','" & E6.Text & "','" & S6.Text & "','" & L6.Text & "')"
        CONNECT.Open()
        COMMAND1 = New MySqlCommand(SQLCODE1, CONNECT)
        COMMAND2 = New MySqlCommand(SQLCODE2, CONNECT)
        COMMAND3 = New MySqlCommand(SQLCODE3, CONNECT)
        COMMAND4 = New MySqlCommand(SQLCODE4, CONNECT)
        COMMAND5 = New MySqlCommand(SQLCODE5, CONNECT)
        COMMAND6 = New MySqlCommand(SQLCODE6, CONNECT)
        COMMAND1.ExecuteNonQuery()
        COMMAND2.ExecuteNonQuery()
        COMMAND3.ExecuteNonQuery()
        COMMAND4.ExecuteNonQuery()
        COMMAND5.ExecuteNonQuery()
        COMMAND6.ExecuteNonQuery()
        CONNECT.Close()
        MsgBox("TimeTable Details Submitted Successfully.")
        Course.ResetText()
        Year.ResetText()
        Semester.ResetText()
        D1.ResetText()
        D2.ResetText()
        D3.ResetText()
        D4.ResetText()
        D5.ResetText()
        D6.ResetText()
        S1.ResetText()
        S2.ResetText()
        S3.ResetText()
        S4.ResetText()
        S5.ResetText()
        S6.ResetText()
        L1.ResetText()
        L2.ResetText()
        L3.ResetText()
        L4.ResetText()
        L5.ResetText()
        L6.ResetText()
        Me.Visible = True
    End Sub


    Private Sub FacultyToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem3.Click
        AddFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem2.Click
        AddCourse.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem3.Click
        Me.Show()
    End Sub

    Private Sub FacultyToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem4.Click
        ModFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem3.Click
        ModCourse.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem4.Click
        ModTimeTable.Show()
        Me.Hide()
    End Sub

    Private Sub FacultyToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem5.Click
        ViewFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem4.Click
        ViewCourse.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem5.Click
        ViewTimeTable.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class