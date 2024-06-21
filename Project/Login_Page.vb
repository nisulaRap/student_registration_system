Imports System.Data
Imports System.Data.SqlClient
Public Class Login_Page
    Private Sub btnLoginClick(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-695PJR7\SQLLEARN;Initial Catalog=Student/UserDB;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM dbo.Receptionist WHERE UserName = '" + txtUser.Text + "'AND Password = '" + txtPsw.Text + "' ", conn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If String.IsNullOrEmpty(txtUser.Text) Or String.IsNullOrEmpty(txtPsw.Text) Then
            MessageBox.Show("Please Enter Username and Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf (dt.Rows.Count > 0) Then
            MessageBox.Show(" Login Successfull.. Welcome ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Student_Registration_Page.ShowDialog()

            txtUser.Clear()
            txtPsw.Clear()
            Show_Password.Checked = False

        Else
            MessageBox.Show("Username or Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtUser.Clear()
        txtPsw.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Show_Password.CheckedChanged
        If Show_Password.Checked Then
            txtPsw.UseSystemPasswordChar = False
        Else
            txtPsw.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Visible = False
        New_User_Page.ShowDialog()
    End Sub

End Class