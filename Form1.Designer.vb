<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        btnsave = New Button()
        txtpass = New TextBox()
        Label2 = New Label()
        txtuname = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        txtusername = New TextBox()
        Label5 = New Label()
        btnsearch = New Button()
        txtpassword = New TextBox()
        Label3 = New Label()
        txtuid = New TextBox()
        Label4 = New Label()
        btndata = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnsave)
        GroupBox1.Controls.Add(txtpass)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtuname)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(33, 34)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(284, 252)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "INSERT"
        ' 
        ' btnsave
        ' 
        btnsave.Location = New Point(71, 166)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(82, 25)
        btnsave.TabIndex = 1
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(140, 102)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(100, 23)
        txtpass.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' txtuname
        ' 
        txtuname.Location = New Point(140, 31)
        txtuname.Name = "txtuname"
        txtuname.Size = New Size(100, 23)
        txtuname.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtusername)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(btndelete)
        GroupBox2.Controls.Add(btnsearch)
        GroupBox2.Controls.Add(btnupdate)
        GroupBox2.Controls.Add(txtpassword)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtuid)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(410, 34)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(284, 252)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "SEARCH"
        ' 
        ' txtusername
        ' 
        txtusername.Enabled = False
        txtusername.Location = New Point(140, 66)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(100, 23)
        txtusername.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 69)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 5
        Label5.Text = "Username"
        ' 
        ' btnsearch
        ' 
        btnsearch.Location = New Point(96, 143)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(82, 25)
        btnsearch.TabIndex = 1
        btnsearch.Text = "Search"
        btnsearch.UseVisualStyleBackColor = True
        ' 
        ' txtpassword
        ' 
        txtpassword.Enabled = False
        txtpassword.Location = New Point(140, 102)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(100, 23)
        txtpassword.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' txtuid
        ' 
        txtuid.Location = New Point(140, 31)
        txtuid.Name = "txtuid"
        txtuid.Size = New Size(100, 23)
        txtuid.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 15)
        Label4.TabIndex = 1
        Label4.Text = "User ID:"
        ' 
        ' btndata
        ' 
        btndata.Location = New Point(304, 339)
        btndata.Name = "btndata"
        btndata.Size = New Size(103, 37)
        btndata.TabIndex = 2
        btndata.Text = "Filter Data"
        btndata.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(16, 206)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(82, 25)
        btnupdate.TabIndex = 1
        btnupdate.Text = "Update"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.Location = New Point(158, 206)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(82, 25)
        btndelete.TabIndex = 1
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(875, 549)
        Controls.Add(btndata)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuname As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtuid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btndata As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
End Class
