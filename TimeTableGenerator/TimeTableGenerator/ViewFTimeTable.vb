Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class ViewFTimeTable

    Private Sub CoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoursesToolStripMenuItem.Click
        ViewFCourse.Show()
        Me.Hide()
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem.Click
        ViewFFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem.Click
        Me.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND, COMMAND1 As New MySqlCommand
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim reader As MySqlDataReader
        Dim SQLCODE, SQLCODE1 As String
        SQLCODE = "SELECT DAY,CONCAT(StartTime,' : ',Endtime) AS Timing,CONCAT(SUBJECT,' \r\n ',Lecturer) AS Lecture FROM timetable  WHERE course = '" & Course.Text & "' AND YEAR = '" & Year.Text & "'AND semester = '" & Semester.Text & "' AND day = '" & Day.Text & "' LIMIT 6"
        SQLCODE1 = "SELECT course,YEAR,semester FROM timetable  WHERE course = '" & Course.Text & "' AND YEAR = '" & Year.Text & "'AND semester = '" & Semester.Text & "'"
        CONNECT.Open()
        COMMAND = New MySqlCommand(SQLCODE, CONNECT)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        DataGridView1.DataSource = bSource
        SDA.Update(dbDataset)
        COMMAND1 = New MySqlCommand(SQLCODE1, CONNECT)
        reader = COMMAND1.ExecuteReader
        If reader.Read() Then
            Dim c = reader.GetString("course")
            Dim y = reader.GetString("year")
            Dim s = reader.GetString("semester")
            C1.Text = c
            C2.Text = y
            C3.Text = s
        End If
        CONNECT.Close()
        Me.Visible = True
    End Sub
End Class