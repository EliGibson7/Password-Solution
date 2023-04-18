﻿' Name:         Password Project
' Purpose:      Create a password.
' Programmer:   <Eli Gibson> on <4/12/23>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' Create a password.

        Dim strWords As String
        Dim strPassword As String
        Dim intSpaceIndex As Integer

        strWords = txtWords.Text.Trim

        If strWords <> String.Empty Then

            strPassword = strWords(0)

            intSpaceIndex = strWords.IndexOf(" ")

            Do Until intSpaceIndex = -1

                strPassword = strPassword & strWords(intSpaceIndex + 1)
                intSpaceIndex = strWords.IndexOf(" ", intSpaceIndex + 1)
            Loop

            strPassword = strPassword.Insert(1, strPassword.Length.ToString)
            lblPassword.Text = strPassword
        End If
    End Sub

    Private Sub txtWords_Enter(sender As Object, e As EventArgs) Handles txtWords.Enter
        txtWords.SelectAll()
    End Sub

    Private Sub txtWords_TextChanged(sender As Object, e As EventArgs) Handles txtWords.TextChanged
        lblPassword.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
