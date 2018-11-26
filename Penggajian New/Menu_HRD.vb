Public Class Menu_HRD

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        login.Show()
        Me.Close()

    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem.Click
        karyawan.Show()
        Me.Close()
    End Sub

    Private Sub EntryDataGajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryDataGajiToolStripMenuItem.Click
        EntryDataGaji.Show()
        Me.Close()
    End Sub
End Class