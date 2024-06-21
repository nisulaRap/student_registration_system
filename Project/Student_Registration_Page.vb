Imports System.Data
Imports System.Data.SqlClient
Public Class Student_Registration_Page
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Student_UserDBDataSet4.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter1.Fill(Me._Student_UserDBDataSet4.Student)
    End Sub

    Private Sub Search1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.StudentTableAdapter1.Search1(Me._Student_UserDBDataSet4.Student, Stu_IDToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(" ")
        End Try

    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Me.StudentTableAdapter1.Fill(Me._Student_UserDBDataSet4.Student)
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        StudentBindingSource1.MovePrevious()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        StudentBindingSource1.MoveNext()
    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        StudentBindingSource1.AddNew()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Try
            If String.IsNullOrEmpty(txtstuID.Text) Then
                MessageBox.Show(" Please Enter Student's ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtstuID.Select()

            ElseIf String.IsNullOrEmpty(txtinitial.Text) Then
                MessageBox.Show(" Please Enter Student's Name With Initials ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtinitial.Select()

            ElseIf String.IsNullOrEmpty(txtfullname.Text) Then
                MessageBox.Show(" Please Enter Student's Full Name  ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtfullname.Select()

            ElseIf String.IsNullOrEmpty(txtnic.Text) Then
                MessageBox.Show(" Please Enter Student's NIC / Passport Number ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtnic.Select()

            ElseIf String.IsNullOrEmpty(txtdob.Text) Then
                MessageBox.Show(" Please Enter Student's Date Of Birth ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtdob.Select()

            ElseIf String.IsNullOrEmpty(combogender.Text) Then
                MessageBox.Show("Please Enter Student's Gender ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                combogender.Select()

            ElseIf String.IsNullOrEmpty(txtaddress.Text) Then
                MessageBox.Show(" Please Enter Student's Address ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtaddress.Select()

            ElseIf String.IsNullOrEmpty(txttp.Text) Then
                MessageBox.Show(" Please Enter Student's Telephone Number ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txttp.Select()

            ElseIf String.IsNullOrEmpty(ComboCourse_ID.Text) Then
                MessageBox.Show(" Please Enter Student's Course_ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ComboCourse_ID.Select()

            ElseIf String.IsNullOrEmpty(comboCourseName.Text) Then
                MessageBox.Show(" Please Enter Student's Course Name ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                comboCourseName.Select()
            Else
                StudentBindingSource1.EndEdit()
                StudentTableAdapter1.Update(_Student_UserDBDataSet4)
                MessageBox.Show(" New Record Added Successfully.. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(" Something Went Wrong.. Please Try Again ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim conn3 As SqlConnection = New SqlConnection("Data Source=DESKTOP-695PJR7\SQLLEARN;Initial Catalog=Student/UserDB;Integrated Security=True")
        Dim cmd3 As SqlCommand = New SqlCommand("DELETE FROM [dbo].[Student] WHERE [Stu_ID] = '" + txtstuID.Text + "' ", conn3)
        Dim sda3 As SqlDataAdapter = New SqlDataAdapter(cmd3)
        Dim dt3 As DataTable = New DataTable()
        sda3.Fill(dt3)

        StudentBindingSource1.RemoveCurrent()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.StudentTableAdapter1.Search(Me._Student_UserDBDataSet4.Student, Stu_IDToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Search1ToolStripButton_Click_1(sender As Object, e As EventArgs) Handles Search1ToolStripButton.Click
        Try
            Me.StudentTableAdapter1.Search1(Me._Student_UserDBDataSet4.Student, Stu_IDToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class