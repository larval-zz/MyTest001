﻿Public Class NewChoiceForm01
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim ck1 As Boolean
        Dim ck2 As Boolean
        Dim ck3 As Boolean
        Dim ck4 As Boolean
        ck1 = CheckBox1.Checked
        ck2 = CheckBox2.Checked
        ck3 = CheckBox3.Checked
        ck4 = CheckBox4.Checked
        If ck1 = True Then
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim ck1 As Boolean
        Dim ck2 As Boolean
        Dim ck3 As Boolean
        Dim ck4 As Boolean
        ck1 = CheckBox1.Checked
        ck2 = CheckBox2.Checked
        ck3 = CheckBox3.Checked
        ck4 = CheckBox4.Checked
        If ck2 = True Then
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Dim ck1 As Boolean
        Dim ck2 As Boolean
        Dim ck3 As Boolean
        Dim ck4 As Boolean
        ck1 = CheckBox1.Checked
        ck2 = CheckBox2.Checked
        ck3 = CheckBox3.Checked
        ck4 = CheckBox4.Checked
        If ck3 = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox4.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Dim ck1 As Boolean
        Dim ck2 As Boolean
        Dim ck3 As Boolean
        Dim ck4 As Boolean
        ck1 = CheckBox1.Checked
        ck2 = CheckBox2.Checked
        ck3 = CheckBox3.Checked
        ck4 = CheckBox4.Checked
        If ck4 = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
        Else
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        Dim ck5 As Boolean
        Dim ck6 As Boolean
        Dim ck7 As Boolean
        Dim ck8 As Boolean
        ck5 = CheckBox5.Checked
        ck6 = CheckBox6.Checked
        ck7 = CheckBox7.Checked
        ck8 = CheckBox8.Checked
        If ck8 = True Then
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
        Else
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
    End Sub
End Class