Public Class Admin



    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        User.Show()
        Me.Hide()
    End Sub

    Private Sub HRDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HRDToolStripMenuItem.Click
        HRD.Show()
        Me.Hide()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        login.Show()
        Me.Close()
    End Sub
End Class