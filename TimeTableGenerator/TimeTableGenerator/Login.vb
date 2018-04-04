Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Login
    Dim MysqlConn As New MySqlConnection("Server = localhost; user id = root;password = 1234; database = timetable;")
    Dim AccessLevel As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MysqlCMD As MySqlCommand
        Dim MysqlDR As MySqlDataReader

        Try
            MysqlConn.Open()

            If Admin.Checked = True Then
                Dim Query As String
                Query = "SELECT * FROM admin WHERE username = '" & UserName.Text & "' and password = '" & Password.Text & "' and AcessLevel = 'Admin'"
                MysqlCMD = New MySqlCommand(Query, MysqlConn)
                MysqlDR = MysqlCMD.ExecuteReader
                If MysqlDR.HasRows Then
                    AdminPanel.Show()
                    Me.Visible = False
                Else
                    MsgBox("Invalid User or Password")
                End If
            ElseIf Faculty.Checked = True Then
                Dim Query As String
                Query = "SELECT * FROM faculty WHERE fullname = '" & UserName.Text & "' and password = '" & Password.Text & "' and AcessLevel = 'Faculty'"
                MysqlCMD = New MySqlCommand(Query, MysqlConn)
                MysqlDR = MysqlCMD.ExecuteReader
                If MysqlDR.HasRows Then
                    FacultyPanel.Show()
                    Me.Visible = False
                Else
                    MsgBox("Invalid User or Password")
                End If

            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
   
End Class


