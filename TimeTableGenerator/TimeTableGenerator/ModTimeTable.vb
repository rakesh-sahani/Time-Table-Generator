Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class ModTimeTable
    Private Sub Load_table()
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND As New MySqlCommand
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim reader As MySqlDataReader
        Dim SQLCODE As String
        SQLCODE = "SELECT tid as 'ID',Course,Year,Semester,Day,StartTime,EndTime,Subject,Lecturer FROM timetable  WHERE course = '" & Course.Text & "' AND YEAR = '" & Year.Text & "'AND semester = '" & Semester.Text & "' LIMIT 5"
        CONNECT.Open()
        COMMAND = New MySqlCommand(SQLCODE, CONNECT)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        DataGridView1.DataSource = bSource
        SDA.Update(dbDataset)
        reader = COMMAND.ExecuteReader
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND As New MySqlCommand
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim reader As MySqlDataReader
        Dim SQLCODE As String
        SQLCODE = "SELECT tid as 'ID',Course,Year,Semester,Day,StartTime,EndTime,Subject,Lecturer FROM timetable  WHERE course = '" & Course.Text & "' AND YEAR = '" & Year.Text & "'AND semester = '" & Semester.Text & "' LIMIT 5"
        CONNECT.Open()
        COMMAND = New MySqlCommand(SQLCODE, CONNECT)
        SDA.SelectCommand = COMMAND
        SDA.Fill(dbDataset)
        bSource.DataSource = dbDataset
        DataGridView1.DataSource = bSource
        SDA.Update(dbDataset)
        reader = COMMAND.ExecuteReader
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND, COMMAND1 As New MySqlCommand
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim reader As MySqlDataReader
        Dim SQLCODE As String
        SQLCODE = "update timetable set Course = '" & C.Text & "' , YEAR = '" & Y.Text & "' , semester = '" & S.Text & "', Day  = '" & D.Text & "', StartTime = '" & ST.Text & "', EndTime  = '" & ET.Text & "' , Subject  = '" & SU.Text & "' , Lecturer = '" & L.Text & "'  WHERE tid =  '" & TID.Text & "'"
        CONNECT.Open()
        COMMAND = New MySqlCommand(SQLCODE, CONNECT)
        reader = COMMAND.ExecuteReader
        MsgBox("Table Updated Successfully")
        CONNECT.Close()
        Load_table()
        Me.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            TID.Text = row.Cells("ID").Value.ToString
            C.Text = row.Cells("Course").Value.ToString
            Y.Text = row.Cells("Year").Value.ToString
            S.Text = row.Cells("Semester").Value.ToString
            D.Text = row.Cells("Day").Value.ToString
            ST.Text = row.Cells("StartTime").Value.ToString
            ET.Text = row.Cells("EndTime").Value.ToString
            SU.Text = row.Cells("Subject").Value.ToString
            L.Text = row.Cells("Lecturer").Value.ToString
        End If
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem.Click
        AddFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        AddCourse.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem.Click
        AddTimeTable.Show()
        Me.Hide()
    End Sub

    Private Sub FacultyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem1.Click
        ModFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem1.Click
        ModCourse.Show()
        Me.Hide()
    End Sub
    Private Sub FacultyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacultyToolStripMenuItem2.Click
        ViewFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem2.Click
        ViewCourse.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem2.Click
        ViewTimeTable.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub TimeTableToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTableToolStripMenuItem1.Click
        Me.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AdminPanel.Show()
        Me.Hide()
    End Sub
End Class