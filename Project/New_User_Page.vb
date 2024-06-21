Imports System.Data
Imports System.Data.SqlClient
Public Class New_User_Page
    Private Sub btnCreateAccountClick(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        Dim conn1 As SqlConnection = New SqlConnection("Data Source=DESKTOP-695PJR7\SQLLEARN;Initial Catalog=Student/UserDB;Integrated Security=True")
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT Username FROM dbo.Receptionist WHERE Username = '" + txtusername.Text + "' ", conn1)
        Dim sda1 As SqlDataAdapter = New SqlDataAdapter(cmd1)
        Dim dt1 As DataTable = New DataTable()
        sda1.Fill(dt1)

        Try
            If String.IsNullOrEmpty(txtuserid.Text) Then
                MessageBox.Show("Please Enter Your EMP_ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtuserid.Select()
                Return
            ElseIf String.IsNullOrEmpty(txtfirstname.Text) Then
                MessageBox.Show("Please Enter Your First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtfirstname.Select()
                Return
            ElseIf String.IsNullOrEmpty(txtlastname.Text) Then
                MessageBox.Show("Please Enter Your Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtlastname.Select()
                Return
            ElseIf String.IsNullOrEmpty(txtusername.Text) Then
                MessageBox.Show("Please Enter Your Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtusername.Select()
                Return
            ElseIf String.IsNullOrEmpty(txtpassword.Text) Then
                MessageBox.Show("Please Enter Your Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtpassword.Show()
                Return
            ElseIf Len(txtpassword.Text) < 8 Then
                MessageBox.Show("Your Password must Contained atleast 8 Charactors.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtpassword.Show()
                Return
            ElseIf (txtpassword.Text) <> (txtrepassword.Text) Then
                MessageBox.Show("Password is not matching. Please re-check", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtpassword.Show()
                Return
            ElseIf (dt1.Rows.Count > 0) Then
                MessageBox.Show("This User Name is already Exist, Please Try another", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return


            Else
                Dim conn2 As SqlConnection = New SqlConnection("Data Source=DESKTOP-695PJR7\SQLLEARN;Initial Catalog=Student/UserDB;Integrated Security=True")
                Dim cmd2 As SqlCommand = New SqlCommand("INSERT INTO dbo.Receptionist VALUES ('" & txtuserid.Text & "','" & txtfirstname.Text & "','" & txtlastname.Text & "','" & txtusername.Text & "','" & txtpassword.Text & "')", conn2)
                Dim sda2 As SqlDataAdapter = New SqlDataAdapter(cmd2)
                Dim dt2 As DataTable = New DataTable()
                sda2.Fill(dt2)

                MessageBox.Show("Your User account has been Created Successfully.", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                txtfirstname.Clear()
                txtlastname.Clear()
                txtusername.Clear()
                txtpassword.Clear()
                txtrepassword.Clear()

            End If

        Catch ex As Exception
            MessageBox.Show("Error Occerd. Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Login_Page.ShowDialog()
    End Sub


End Class