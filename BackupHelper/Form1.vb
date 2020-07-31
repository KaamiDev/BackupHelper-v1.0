Public Class Form1
    Private Sub backupBtn_Click(sender As Object, e As EventArgs) Handles backupBtn.Click
        backupDialog.ShowDialog()
        backupTextbox.Text = backupDialog.SelectedPath
    End Sub

    Private Sub destinationBtn_Click(sender As Object, e As EventArgs) Handles destinationBtn.Click
        destinationDialog.ShowDialog()
        DestinationTextbox.Text = destinationDialog.SelectedPath
    End Sub

    Private Sub runBackupBtn_Click(sender As Object, e As EventArgs) Handles runBackupBtn.Click

        Dim pinfo As New ProcessStartInfo()
        pinfo.FileName = "C:\Users\HP\Documents\thingy\7z.exe"
        pinfo.Arguments = "a " + """" + DestinationTextbox.Text + "\backup_" + CStr(Now.ToFileTime) + ".zip"" " + """" + backupTextbox.Text + "\*"" -p@" + passwordTextbox.Text
        pinfo.WindowStyle = ProcessWindowStyle.Hidden
        Dim p As Process = Process.Start(pinfo)
        MsgBox(pinfo.Arguments)

    End Sub
End Class
