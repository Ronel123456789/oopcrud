<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        dgvrecord = New DataGridView()
        btnhome = New Button()
        btnprint = New Button()
        CType(dgvrecord, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvrecord
        ' 
        dgvrecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvrecord.Location = New Point(45, 12)
        dgvrecord.Name = "dgvrecord"
        dgvrecord.RowTemplate.Height = 25
        dgvrecord.Size = New Size(589, 254)
        dgvrecord.TabIndex = 0
        ' 
        ' btnhome
        ' 
        btnhome.Location = New Point(476, 360)
        btnhome.Name = "btnhome"
        btnhome.Size = New Size(75, 27)
        btnhome.TabIndex = 1
        btnhome.Text = "Home"
        btnhome.UseVisualStyleBackColor = True
        ' 
        ' btnprint
        ' 
        btnprint.Location = New Point(378, 364)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(75, 23)
        btnprint.TabIndex = 2
        btnprint.Text = "Print"
        btnprint.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnprint)
        Controls.Add(btnhome)
        Controls.Add(dgvrecord)
        Name = "Form3"
        Text = "Form3"
        CType(dgvrecord, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvrecord As DataGridView
    Friend WithEvents btnhome As Button
    Friend WithEvents btnprint As Button
End Class
