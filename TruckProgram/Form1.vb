﻿Public Class Form1
    Dim calForm As New Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If calForm Is Nothing Then
            calForm = New Form2
        ElseIf calForm.IsDisposed Then
            calForm = New Form2
        End If
        calForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class