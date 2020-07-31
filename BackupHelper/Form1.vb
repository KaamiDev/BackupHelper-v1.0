Imports System.IO

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
            pinfo.FileName = My.Application.Info.DirectoryPath + "\7z.exe"
            pinfo.Arguments = "a " + """" + DestinationTextbox.Text + "\backup_" + CStr(Now.ToFileTime) + ".zip"" " + """" + backupTextbox.Text + "\*"" -p" + passwordTextbox.Text
            pinfo.WindowStyle = ProcessWindowStyle.Hidden
            Dim p As Process = Process.Start(pinfo)
            If Not p.WaitForExit(60000) Then
                MsgBox("Process timed out..",, "Error")
            Else
                MsgBox("Backup Saved Successfully!",, "Success!")
                If saveCheckbox.Checked Then
                    My.Settings.Backup = backupTextbox.Text
                    My.Settings.Destination = DestinationTextbox.Text
                    My.Settings.Password = passwordTextbox.Text
                Else
                    My.Settings.Backup = ""
                    My.Settings.Destination = ""
                    My.Settings.Password = ""
                End If
                My.Settings.Save()
                endLoading()
                Process.Start(DestinationTextbox.Text)
                End If
                Else
            MsgBox("Please make sure all fields are filled in and valid.",, "Error")
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
        If passwordTextbox.Text = "" Then
            Return False
        Else
            If Directory.Exists(DestinationTextbox.Text) And Directory.Exists(backupTextbox.Text) Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(My.Application.Info.DirectoryPath + "\7z.exe") Then
            DestinationTextbox.Text = My.Settings.Destination
            backupTextbox.Text = My.Settings.Backup
            passwordTextbox.Text = My.Settings.Password
        Else
            MsgBox("7z.exe file is missing.",, "Error")
            Me.Close()
        End If
    End Sub
End Class
