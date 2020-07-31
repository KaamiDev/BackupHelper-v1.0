<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.backupBtn = New System.Windows.Forms.Button()
        Me.backupTextbox = New System.Windows.Forms.TextBox()
        Me.backupDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.destinationBtn = New System.Windows.Forms.Button()
        Me.DestinationTextbox = New System.Windows.Forms.TextBox()
        Me.destinationDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.runBackupBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.showHideBtn = New System.Windows.Forms.Button()
        Me.passwordTextbox = New System.Windows.Forms.TextBox()
        Me.saveCheckbox = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(192, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BackupHelper v1.0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BackupHelper.My.Resources.Resources.history_clock_button
        Me.PictureBox1.Location = New System.Drawing.Point(129, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.backupBtn)
        Me.GroupBox1.Controls.Add(Me.backupTextbox)
        Me.GroupBox1.Location = New System.Drawing.Point(79, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 75)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Backup Directory"
        '
        'backupBtn
        '
        Me.backupBtn.Location = New System.Drawing.Point(421, 34)
        Me.backupBtn.Name = "backupBtn"
        Me.backupBtn.Size = New System.Drawing.Size(39, 26)
        Me.backupBtn.TabIndex = 1
        Me.backupBtn.Text = "..."
        Me.backupBtn.UseVisualStyleBackColor = True
        '
        'backupTextbox
        '
        Me.backupTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.backupTextbox.Location = New System.Drawing.Point(21, 34)
        Me.backupTextbox.Name = "backupTextbox"
        Me.backupTextbox.Size = New System.Drawing.Size(394, 26)
        Me.backupTextbox.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.destinationBtn)
        Me.GroupBox2.Controls.Add(Me.DestinationTextbox)
        Me.GroupBox2.Location = New System.Drawing.Point(79, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 75)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Destination Directory"
        '
        'destinationBtn
        '
        Me.destinationBtn.Location = New System.Drawing.Point(421, 34)
        Me.destinationBtn.Name = "destinationBtn"
        Me.destinationBtn.Size = New System.Drawing.Size(39, 26)
        Me.destinationBtn.TabIndex = 1
        Me.destinationBtn.Text = "..."
        Me.destinationBtn.UseVisualStyleBackColor = True
        '
        'DestinationTextbox
        '
        Me.DestinationTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DestinationTextbox.Location = New System.Drawing.Point(21, 34)
        Me.DestinationTextbox.Name = "DestinationTextbox"
        Me.DestinationTextbox.Size = New System.Drawing.Size(394, 26)
        Me.DestinationTextbox.TabIndex = 0
        '
        'runBackupBtn
        '
        Me.runBackupBtn.Location = New System.Drawing.Point(267, 505)
        Me.runBackupBtn.Name = "runBackupBtn"
        Me.runBackupBtn.Size = New System.Drawing.Size(122, 40)
        Me.runBackupBtn.TabIndex = 4
        Me.runBackupBtn.Text = "Run Backup"
        Me.runBackupBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.showHideBtn)
        Me.GroupBox3.Controls.Add(Me.passwordTextbox)
        Me.GroupBox3.Location = New System.Drawing.Point(79, 369)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(521, 74)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Password"
        '
        'showHideBtn
        '
        Me.showHideBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.showHideBtn.Location = New System.Drawing.Point(421, 34)
        Me.showHideBtn.Name = "showHideBtn"
        Me.showHideBtn.Size = New System.Drawing.Size(74, 26)
        Me.showHideBtn.TabIndex = 2
        Me.showHideBtn.Text = "Show"
        Me.showHideBtn.UseVisualStyleBackColor = True
        '
        'passwordTextbox
        '
        Me.passwordTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.passwordTextbox.Location = New System.Drawing.Point(21, 34)
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextbox.Size = New System.Drawing.Size(394, 26)
        Me.passwordTextbox.TabIndex = 0
        '
        'saveCheckbox
        '
        Me.saveCheckbox.AutoSize = True
        Me.saveCheckbox.Checked = True
        Me.saveCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.saveCheckbox.Location = New System.Drawing.Point(416, 458)
        Me.saveCheckbox.Name = "saveCheckbox"
        Me.saveCheckbox.Size = New System.Drawing.Size(184, 24)
        Me.saveCheckbox.TabIndex = 6
        Me.saveCheckbox.Text = "Save these settings?"
        Me.saveCheckbox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 577)
        Me.Controls.Add(Me.saveCheckbox)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.runBackupBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackupHelper v1.0"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents backupDialog As FolderBrowserDialog
    Friend WithEvents backupTextbox As TextBox
    Friend WithEvents backupBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents destinationBtn As Button
    Friend WithEvents DestinationTextbox As TextBox
    Friend WithEvents destinationDialog As FolderBrowserDialog
    Friend WithEvents runBackupBtn As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents showHideBtn As Button
    Friend WithEvents passwordTextbox As TextBox
    Friend WithEvents saveCheckbox As CheckBox
End Class
