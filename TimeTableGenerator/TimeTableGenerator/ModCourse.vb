Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class ModCourse

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddCourse.Show()
        Me.Hide()
    End Sub

    Private Sub FacultyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddTimeTable.Show()
        Me.Hide()
    End Sub
    Private Sub FacultyToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ModTimeTable.Show()
        Me.Hide()
    End Sub

    Private Sub CoursesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewCourse.Show()
        Me.Hide()
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub TimeTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ViewTimeTable.Show()
        Me.Hide()
    End Sub


    Private Sub CourseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()
    End Sub

    Private Sub Load_table()
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND As New MySqlCommand
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim reader As MySqlDataReader
        Dim SQLCODE As String
        SQLCODE = "SELECT cid as 'ID',Course,Year,Sem as 'Semester',scode as 'Sub-Code',sname as 'Subject',lname as 'Lecturer' FROM course  WHERE course = '" & Course.Text & "' AND YEAR = '" & Year.Text & "'AND sem = '" & Semester.Text & "'"
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
        SQLCODE = "SELECT cid as 'ID',Course,Year,Sem as 'Semester',scode as 'Sub-Code',sname as 'Subject',lname as 'Lecturer' FROM course  WHERE course = '" & Course.Text & "' AND YEAR = '" & Year.Text & "'AND sem= '" & Semester.Text & "'"
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
            Dim s = reader.GetString("Semester")
            C1.Text = c
            C2.Text = y
            C3.Text = s
        End If
        CONNECT.Close()
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
            SC.Text = row.Cells("Sub-Code").Value.ToString
            SU.Text = row.Cells("Subject").Value.ToString
            L.Text = row.Cells("Lecturer").Value.ToString
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AdminPanel.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CONNECT As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
        Dim COMMAND, COMMAND1 As New MySqlCommand
        Dim SDA As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bSource As New BindingSource
        Dim reader As MySqlDataReader
        Dim SQLCODE As String
        SQLCODE = "update course set Course = '" & C.Text & "' , YEAR = '" & Y.Text & "' , sem = '" & S.Text & "', scode  = '" & SC.Text & "', sname = '" & SU.Text & "', lname  = '" & L.Text & "'  WHERE cid =  '" & TID.Text & "'"
        CONNECT.Open()
        COMMAND = New MySqlCommand(SQLCODE, CONNECT)
        reader = COMMAND.ExecuteReader
        MsgBox("Details Updated Successfully")
        CONNECT.Close()
        Load_table()
        Me.Visible = True
    End Sub
End Class