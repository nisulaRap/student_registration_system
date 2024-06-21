<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Registration_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboCourseName = New System.Windows.Forms.ComboBox()
        Me.StudentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._Student_UserDBDataSet4 = New Project._Student_UserDBDataSet4()
        Me.ComboCourse_ID = New System.Windows.Forms.ComboBox()
        Me.combogender = New System.Windows.Forms.ComboBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnaddnew = New System.Windows.Forms.Button()
        Me.txtdob = New System.Windows.Forms.DateTimePicker()
        Me.txttp = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtnic = New System.Windows.Forms.TextBox()
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.txtinitial = New System.Windows.Forms.TextBox()
        Me.txtstuID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameWithInitialsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.StudentTableAdapter1 = New Project._Student_UserDBDataSet4TableAdapters.StudentTableAdapter()
        Me.Search1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Param1ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Stu_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Search1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Student_UserDBDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Search1ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.comboCourseName)
        Me.GroupBox1.Controls.Add(Me.ComboCourse_ID)
        Me.GroupBox1.Controls.Add(Me.combogender)
        Me.GroupBox1.Controls.Add(Me.btnnext)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.btnprevious)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.btnaddnew)
        Me.GroupBox1.Controls.Add(Me.txtdob)
        Me.GroupBox1.Controls.Add(Me.txttp)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtnic)
        Me.GroupBox1.Controls.Add(Me.txtfullname)
        Me.GroupBox1.Controls.Add(Me.txtinitial)
        Me.GroupBox1.Controls.Add(Me.txtstuID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 69)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(378, 559)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'comboCourseName
        '
        Me.comboCourseName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Course Name", True))
        Me.comboCourseName.FormattingEnabled = True
        Me.comboCourseName.Items.AddRange(New Object() {"ICT - NVQ 05", "Auto Mobile - NVQ 05", "Mecratronic - NVQ 05", "Accounting - NVQ 05"})
        Me.comboCourseName.Location = New System.Drawing.Point(178, 412)
        Me.comboCourseName.Margin = New System.Windows.Forms.Padding(2)
        Me.comboCourseName.Name = "comboCourseName"
        Me.comboCourseName.Size = New System.Drawing.Size(164, 21)
        Me.comboCourseName.TabIndex = 31
        '
        'StudentBindingSource1
        '
        Me.StudentBindingSource1.DataMember = "Student"
        Me.StudentBindingSource1.DataSource = Me._Student_UserDBDataSet4
        '
        '_Student_UserDBDataSet4
        '
        Me._Student_UserDBDataSet4.DataSetName = "_Student_UserDBDataSet4"
        Me._Student_UserDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboCourse_ID
        '
        Me.ComboCourse_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Course_ID", True))
        Me.ComboCourse_ID.FormattingEnabled = True
        Me.ComboCourse_ID.Items.AddRange(New Object() {"ICTNVQ5", "AMNVQ5", "MTRNVQ5", "ACCNVQ5"})
        Me.ComboCourse_ID.Location = New System.Drawing.Point(178, 374)
        Me.ComboCourse_ID.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboCourse_ID.Name = "ComboCourse_ID"
        Me.ComboCourse_ID.Size = New System.Drawing.Size(164, 21)
        Me.ComboCourse_ID.TabIndex = 30
        '
        'combogender
        '
        Me.combogender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Gender", True))
        Me.combogender.FormattingEnabled = True
        Me.combogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.combogender.Location = New System.Drawing.Point(178, 216)
        Me.combogender.Margin = New System.Windows.Forms.Padding(2)
        Me.combogender.Name = "combogender"
        Me.combogender.Size = New System.Drawing.Size(164, 21)
        Me.combogender.TabIndex = 29
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnnext.Location = New System.Drawing.Point(249, 503)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(101, 41)
        Me.btnnext.TabIndex = 28
        Me.btnnext.Text = ">>>"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnclose.Location = New System.Drawing.Point(138, 503)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(101, 41)
        Me.btnclose.TabIndex = 27
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnprevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnprevious.Location = New System.Drawing.Point(27, 503)
        Me.btnprevious.Margin = New System.Windows.Forms.Padding(2)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(101, 41)
        Me.btnprevious.TabIndex = 26
        Me.btnprevious.Text = "<<<"
        Me.btnprevious.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btndelete.Location = New System.Drawing.Point(249, 453)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(101, 41)
        Me.btndelete.TabIndex = 25
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnsave.Location = New System.Drawing.Point(138, 453)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(101, 41)
        Me.btnsave.TabIndex = 24
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnaddnew
        '
        Me.btnaddnew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnaddnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddnew.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnaddnew.Location = New System.Drawing.Point(27, 453)
        Me.btnaddnew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnaddnew.Name = "btnaddnew"
        Me.btnaddnew.Size = New System.Drawing.Size(101, 41)
        Me.btnaddnew.TabIndex = 23
        Me.btnaddnew.Text = "ADD NEW"
        Me.btnaddnew.UseVisualStyleBackColor = False
        '
        'txtdob
        '
        Me.txtdob.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "DOB", True))
        Me.txtdob.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdob.Location = New System.Drawing.Point(178, 183)
        Me.txtdob.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(164, 20)
        Me.txtdob.TabIndex = 20
        '
        'txttp
        '
        Me.txttp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Telephone", True))
        Me.txttp.Location = New System.Drawing.Point(178, 336)
        Me.txttp.Margin = New System.Windows.Forms.Padding(2)
        Me.txttp.Name = "txttp"
        Me.txttp.Size = New System.Drawing.Size(164, 20)
        Me.txttp.TabIndex = 17
        '
        'txtemail
        '
        Me.txtemail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Email", True))
        Me.txtemail.Location = New System.Drawing.Point(178, 297)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(164, 20)
        Me.txtemail.TabIndex = 16
        '
        'txtaddress
        '
        Me.txtaddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Address", True))
        Me.txtaddress.Location = New System.Drawing.Point(178, 258)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(164, 20)
        Me.txtaddress.TabIndex = 15
        '
        'txtnic
        '
        Me.txtnic.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "NIC", True))
        Me.txtnic.Location = New System.Drawing.Point(178, 145)
        Me.txtnic.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnic.Name = "txtnic"
        Me.txtnic.Size = New System.Drawing.Size(164, 20)
        Me.txtnic.TabIndex = 14
        '
        'txtfullname
        '
        Me.txtfullname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Full Name", True))
        Me.txtfullname.Location = New System.Drawing.Point(178, 106)
        Me.txtfullname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(164, 20)
        Me.txtfullname.TabIndex = 13
        '
        'txtinitial
        '
        Me.txtinitial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Name with Initials", True))
        Me.txtinitial.Location = New System.Drawing.Point(178, 68)
        Me.txtinitial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtinitial.Name = "txtinitial"
        Me.txtinitial.Size = New System.Drawing.Size(164, 20)
        Me.txtinitial.TabIndex = 12
        '
        'txtstuID
        '
        Me.txtstuID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource1, "Stu_ID", True))
        Me.txtstuID.Location = New System.Drawing.Point(178, 28)
        Me.txtstuID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtstuID.Name = "txtstuID"
        Me.txtstuID.Size = New System.Drawing.Size(164, 20)
        Me.txtstuID.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 412)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Course Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 374)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Course_ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 336)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Telephone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 297)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 221)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 259)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NIC No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name with Initials"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name in Full"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student_ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(405, 54)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(901, 559)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StuIDDataGridViewTextBoxColumn, Me.NameWithInitialsDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.NICDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.CourseIDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(2, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(897, 542)
        Me.DataGridView1.TabIndex = 2
        '
        'StuIDDataGridViewTextBoxColumn
        '
        Me.StuIDDataGridViewTextBoxColumn.DataPropertyName = "Stu_ID"
        Me.StuIDDataGridViewTextBoxColumn.HeaderText = "Stu_ID"
        Me.StuIDDataGridViewTextBoxColumn.Name = "StuIDDataGridViewTextBoxColumn"
        '
        'NameWithInitialsDataGridViewTextBoxColumn
        '
        Me.NameWithInitialsDataGridViewTextBoxColumn.DataPropertyName = "Name with Initials"
        Me.NameWithInitialsDataGridViewTextBoxColumn.HeaderText = "Name with Initials"
        Me.NameWithInitialsDataGridViewTextBoxColumn.Name = "NameWithInitialsDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'NICDataGridViewTextBoxColumn
        '
        Me.NICDataGridViewTextBoxColumn.DataPropertyName = "NIC"
        Me.NICDataGridViewTextBoxColumn.HeaderText = "NIC"
        Me.NICDataGridViewTextBoxColumn.Name = "NICDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        '
        'CourseIDDataGridViewTextBoxColumn
        '
        Me.CourseIDDataGridViewTextBoxColumn.DataPropertyName = "Course_ID"
        Me.CourseIDDataGridViewTextBoxColumn.HeaderText = "Course_ID"
        Me.CourseIDDataGridViewTextBoxColumn.Name = "CourseIDDataGridViewTextBoxColumn"
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "Course Name"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "Course Name"
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        '
        'btnShowAll
        '
        Me.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnShowAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnShowAll.Location = New System.Drawing.Point(301, 0)
        Me.btnShowAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(86, 28)
        Me.btnShowAll.TabIndex = 25
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = False
        '
        'StudentTableAdapter1
        '
        Me.StudentTableAdapter1.ClearBeforeFill = True
        '
        'Search1ToolStrip
        '
        Me.Search1ToolStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Search1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Param1ToolStripLabel, Me.Stu_IDToolStripTextBox, Me.Search1ToolStripButton})
        Me.Search1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.Search1ToolStrip.Name = "Search1ToolStrip"
        Me.Search1ToolStrip.Size = New System.Drawing.Size(1326, 25)
        Me.Search1ToolStrip.TabIndex = 26
        Me.Search1ToolStrip.Text = "Search1ToolStrip"
        '
        'Param1ToolStripLabel
        '
        Me.Param1ToolStripLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Param1ToolStripLabel.Name = "Param1ToolStripLabel"
        Me.Param1ToolStripLabel.Size = New System.Drawing.Size(88, 22)
        Me.Param1ToolStripLabel.Text = "Student_ID :"
        '
        'Stu_IDToolStripTextBox
        '
        Me.Stu_IDToolStripTextBox.Name = "Stu_IDToolStripTextBox"
        Me.Stu_IDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Search1ToolStripButton
        '
        Me.Search1ToolStripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Search1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Search1ToolStripButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search1ToolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Search1ToolStripButton.Name = "Search1ToolStripButton"
        Me.Search1ToolStripButton.Size = New System.Drawing.Size(65, 22)
        Me.Search1ToolStripButton.Text = "Search"
        Me.Search1ToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Student_Registration_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1326, 648)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.Search1ToolStrip)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Student_Registration_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students Registration Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StudentBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Student_UserDBDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Search1ToolStrip.ResumeLayout(False)
        Me.Search1ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnaddnew As Button
    Friend WithEvents txtdob As DateTimePicker
    Friend WithEvents txttp As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtnic As TextBox
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents txtinitial As TextBox
    Friend WithEvents txtstuID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnext As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents btnprevious As Button
    Friend WithEvents combogender As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnShowAll As Button
    Friend WithEvents ComboCourse_ID As ComboBox
    Friend WithEvents comboCourseName As ComboBox
    Friend WithEvents _Student_UserDBDataSet4 As _Student_UserDBDataSet4
    Friend WithEvents StudentBindingSource1 As BindingSource
    Friend WithEvents StudentTableAdapter1 As _Student_UserDBDataSet4TableAdapters.StudentTableAdapter
    Friend WithEvents StuIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameWithInitialsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Search1ToolStrip As ToolStrip
    Friend WithEvents Param1ToolStripLabel As ToolStripLabel
    Friend WithEvents Stu_IDToolStripTextBox As ToolStripTextBox
    Friend WithEvents Search1ToolStripButton As ToolStripButton
End Class
