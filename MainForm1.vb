Public Class MainForm1
    Private Sub MainForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim newf01 As New NewChoiceForm01
        newf01.Show()
    End Sub

    Private Sub 退出程序ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出程序ToolStripMenuItem.Click
        End
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
