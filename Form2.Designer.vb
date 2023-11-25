<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cbotype = New ComboBox()
        Label1 = New Label()
        txtdata = New TextBox()
        btnfind = New Button()
        dgvrecord = New DataGridView()
        btnback = New Button()
        CType(dgvrecord, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbotype
        ' 
        cbotype.FormattingEnabled = True
        cbotype.Location = New Point(37, 77)
        cbotype.Name = "cbotype"
        cbotype.Size = New Size(121, 23)
        cbotype.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(176, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 1
        Label1.Text = "Search"
        ' 
        ' txtdata
        ' 
        txtdata.Location = New Point(288, 77)
        txtdata.Name = "txtdata"
        txtdata.Size = New Size(100, 23)
        txtdata.TabIndex = 2
        ' 
        ' btnfind
        ' 
        btnfind.Location = New Point(411, 77)
        btnfind.Name = "btnfind"
        btnfind.Size = New Size(118, 23)
        btnfind.TabIndex = 3
        btnfind.Text = "Find Record"
        btnfind.UseVisualStyleBackColor = True
        ' 
        ' dgvrecord
        ' 
        dgvrecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvrecord.Location = New Point(49, 122)
        dgvrecord.Name = "dgvrecord"
        dgvrecord.RowTemplate.Height = 25
        dgvrecord.Size = New Size(480, 225)
        dgvrecord.TabIndex = 4
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(464, 381)
        btnback.Name = "btnback"
        btnback.Size = New Size(75, 23)
        btnback.TabIndex = 5
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 

        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(605, 450)
        ControlBox = False
        Controls.Add(btnback)
        Controls.Add(dgvrecord)
        Controls.Add(btnfind)
        Controls.Add(txtdata)
        Controls.Add(Label1)
        Controls.Add(cbotype)
        Name = "Form2"
        Text = "Form2"
        CType(dgvrecord, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbotype As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdata As TextBox
    Friend WithEvents btnfind As Button
    Friend WithEvents dgvrecord As DataGridView
    Friend WithEvents btnback As Button
End Class
