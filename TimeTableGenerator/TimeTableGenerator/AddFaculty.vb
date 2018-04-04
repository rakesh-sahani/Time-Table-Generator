Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class AddFaculty
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        AddCourse.Show()
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


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND As New MySqlCommand
        Dim SQLCODE As String
        Dim i As Integer
        SQLCODE = "insert into faculty (`fullname`, `mob`, `dept`, `password`, `acesslevel`) VALUES ('" & fname.Text & "','" & mob.Text & "','" & dept.Text & "','" & pass.Text & "','Faculty')"
        CONNECT.Open()
        COMMAND = New MySqlCommand(SQLCODE, CONNECT)
        i = COMMAND.ExecuteNonQuery()
        If i > 0 Then
            CONNECT.Close()
            MsgBox("Faculty Details Submitted Successfully.")
        End If
        dept.ResetText()
        fname.Clear()
        mob.Clear()
        pass.Clear()
        Me.Visible = True
    End Sub

    Private Sub FacultyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem1.Click
        Me.Show()
    End Sub
    
End Class