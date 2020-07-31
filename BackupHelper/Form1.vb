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
        If checkInput() Then
            startLoading()
            Dim pinfo As New ProcessStartInfo()
            pinfo.FileName = "C:\Users\HP\Documents\thingy\7z.exe"
            pinfo.Arguments = "a " + """" + DestinationTextbox.Text + "\backup_" + CStr(Now.ToFileTime) + ".zip"" " + """" + backupTextbox.Text + "\*"" -p" + passwordTextbox.Text
            pinfo.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(pinfo)
            If Not p.WaitForExit(60000) Then
                MsgBox("Process timed out..",, "Error")
            Else
                MsgBox("Backup Saved Successfully!",, "Success!")
                endLoading()
                Process.Start(DestinationTextbox.Text)
            End If
        Else
            MsgBox("Please make sure all fields are filled in.",, "Error")
        End If
    End Sub

    Private Sub showHideBtn_Click(sender As Object, e As EventArgs) Handles showHideBtn.Click
        If showHideBtn.Text = "hide" Then
            passwordTextbox.PasswordChar = "*"
            showHideBtn.Text = "show"
        Else
            passwordTextbox.PasswordChar = ""
            showHideBtn.Text = "hide"
        End If
    End Sub

    Private Sub startLoading()
        backupTextbox.Enabled = False
        DestinationTextbox.Enabled = False
        backupBtn.Enabled = False
        destinationBtn.Enabled = False
        passwordTextbox.Enabled = False
        showHideBtn.Enabled = False
        runBackupBtn.Enabled = False
        runBackupBtn.Text = "Running..."
    End Sub

    Private Sub endLoading()
        backupTextbox.Enabled = True
        DestinationTextbox.Enabled = True
        backupBtn.Enabled = True
        destinationBtn.Enabled = True
        passwordTextbox.Enabled = True
        showHideBtn.Enabled = True
        runBackupBtn.Enabled = True
        runBackupBtn.Text = "Run Backup"
    End Sub

    Private Function checkInput()
        If passwordTextbox.Text = "" Or backupTextbox.Text = "" Or DestinationTextbox.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
