Imports System.CodeDom
Imports System.Data.Common
Imports System.Linq.Expressions
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(Sender As Object, e As EventArgs) Handles MyBase.Load


        DbConnection()
        btnupdate.Enabled = False
        btndelete.Enabled = False
        txtusername.Enabled = False
        txtpassword.Enabled = False

    End Sub





    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        InsertRec()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsearch.Click, btnupdate.Click, btndelete.Click
        SearchRec()
    End Sub


    Private Sub btndata_Click(sender As Object, e As EventArgs) Handles btndata.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            updateRecord(txtuid.Text, txtusername.Text, txtpassword.Text)
        Else
            txtuid.Clear()
            txtusername.Clear()
            txtpassword.Clear()

        End If
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim result As DialogResult = MessageBox.Show("Do you really want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            updateRecord(txtuid.Text, txtusername.Text, txtpassword.Text)
        Else
            txtuid.Clear()
            txtusername.Clear()
            txtpassword.Clear()

        End If
    End Sub
End Class
