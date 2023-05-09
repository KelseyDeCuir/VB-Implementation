<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnStory = New System.Windows.Forms.Button()
        Me.btnMultiplayer = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.panStory = New System.Windows.Forms.Panel()
        Me.radLoad = New System.Windows.Forms.RadioButton()
        Me.radNew = New System.Windows.Forms.RadioButton()
        Me.picSettings = New System.Windows.Forms.PictureBox()
        Me.picMulti = New System.Windows.Forms.PictureBox()
        Me.picStory = New System.Windows.Forms.PictureBox()
        Me.picMainMenu = New System.Windows.Forms.PictureBox()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.txtPlayers = New System.Windows.Forms.TextBox()
        Me.lblPlayers = New System.Windows.Forms.Label()
        Me.gbxMulti = New System.Windows.Forms.GroupBox()
        Me.gbxSettings = New System.Windows.Forms.GroupBox()
        Me.lblBrightness = New System.Windows.Forms.Label()
        Me.lblAudio = New System.Windows.Forms.Label()
        Me.lblMusic = New System.Windows.Forms.Label()
        Me.txtBrightness = New System.Windows.Forms.TextBox()
        Me.btnAudioOn = New System.Windows.Forms.Button()
        Me.btnAudioOff = New System.Windows.Forms.Button()
        Me.btnMusicOn = New System.Windows.Forms.Button()
        Me.btnMusicOff = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.panStory.SuspendLayout()
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMulti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxMulti.SuspendLayout()
        Me.gbxSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Snow
        Me.lblTitle.Font = New System.Drawing.Font("Franklin Gothic Medium", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(251, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(153, 43)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Ascension"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStory
        '
        Me.btnStory.BackColor = System.Drawing.Color.Transparent
        Me.btnStory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStory.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStory.ForeColor = System.Drawing.Color.DarkRed
        Me.btnStory.Location = New System.Drawing.Point(549, 98)
        Me.btnStory.Name = "btnStory"
        Me.btnStory.Size = New System.Drawing.Size(126, 27)
        Me.btnStory.TabIndex = 1
        Me.btnStory.Text = "Story Mode"
        Me.btnStory.UseVisualStyleBackColor = False
        '
        'btnMultiplayer
        '
        Me.btnMultiplayer.BackColor = System.Drawing.Color.Transparent
        Me.btnMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMultiplayer.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplayer.ForeColor = System.Drawing.Color.DarkRed
        Me.btnMultiplayer.Location = New System.Drawing.Point(549, 148)
        Me.btnMultiplayer.Name = "btnMultiplayer"
        Me.btnMultiplayer.Size = New System.Drawing.Size(126, 27)
        Me.btnMultiplayer.TabIndex = 2
        Me.btnMultiplayer.Text = "Multiplayer"
        Me.btnMultiplayer.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettings.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.DarkRed
        Me.btnSettings.Location = New System.Drawing.Point(549, 204)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(126, 27)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkRed
        Me.btnExit.Location = New System.Drawing.Point(549, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 27)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'panStory
        '
        Me.panStory.BackColor = System.Drawing.Color.Transparent
        Me.panStory.Controls.Add(Me.radLoad)
        Me.panStory.Controls.Add(Me.radNew)
        Me.panStory.Location = New System.Drawing.Point(314, 55)
        Me.panStory.Name = "panStory"
        Me.panStory.Size = New System.Drawing.Size(229, 120)
        Me.panStory.TabIndex = 6
        '
        'radLoad
        '
        Me.radLoad.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLoad.ForeColor = System.Drawing.Color.Black
        Me.radLoad.Location = New System.Drawing.Point(13, 57)
        Me.radLoad.Name = "radLoad"
        Me.radLoad.Size = New System.Drawing.Size(178, 36)
        Me.radLoad.TabIndex = 1
        Me.radLoad.TabStop = True
        Me.radLoad.Text = "Load Game"
        Me.radLoad.UseVisualStyleBackColor = True
        '
        'radNew
        '
        Me.radNew.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNew.ForeColor = System.Drawing.Color.Black
        Me.radNew.Location = New System.Drawing.Point(13, 15)
        Me.radNew.Name = "radNew"
        Me.radNew.Size = New System.Drawing.Size(178, 36)
        Me.radNew.TabIndex = 0
        Me.radNew.TabStop = True
        Me.radNew.Text = "New Game"
        Me.radNew.UseVisualStyleBackColor = True
        '
        'picSettings
        '
        Me.picSettings.Image = Global.VB_Implementation.My.Resources.Resources.settings
        Me.picSettings.Location = New System.Drawing.Point(0, 55)
        Me.picSettings.Name = "picSettings"
        Me.picSettings.Size = New System.Drawing.Size(308, 290)
        Me.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSettings.TabIndex = 9
        Me.picSettings.TabStop = False
        '
        'picMulti
        '
        Me.picMulti.Image = Global.VB_Implementation.My.Resources.Resources.multiplayer
        Me.picMulti.Location = New System.Drawing.Point(66, 98)
        Me.picMulti.Name = "picMulti"
        Me.picMulti.Size = New System.Drawing.Size(200, 200)
        Me.picMulti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMulti.TabIndex = 8
        Me.picMulti.TabStop = False
        '
        'picStory
        '
        Me.picStory.Image = Global.VB_Implementation.My.Resources.Resources.elevator_attendant
        Me.picStory.Location = New System.Drawing.Point(0, 55)
        Me.picStory.Name = "picStory"
        Me.picStory.Size = New System.Drawing.Size(308, 290)
        Me.picStory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStory.TabIndex = 7
        Me.picStory.TabStop = False
        '
        'picMainMenu
        '
        Me.picMainMenu.Image = Global.VB_Implementation.My.Resources.Resources.elevator
        Me.picMainMenu.Location = New System.Drawing.Point(0, 55)
        Me.picMainMenu.Name = "picMainMenu"
        Me.picMainMenu.Size = New System.Drawing.Size(308, 290)
        Me.picMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMainMenu.TabIndex = 5
        Me.picMainMenu.TabStop = False
        '
        'btnMulti
        '
        Me.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMulti.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulti.ForeColor = System.Drawing.Color.DarkRed
        Me.btnMulti.Location = New System.Drawing.Point(358, 220)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(126, 27)
        Me.btnMulti.TabIndex = 10
        Me.btnMulti.Text = "Start Game"
        Me.btnMulti.UseVisualStyleBackColor = True
        Me.btnMulti.Visible = False
        '
        'txtPlayers
        '
        Me.txtPlayers.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayers.Location = New System.Drawing.Point(140, 33)
        Me.txtPlayers.Multiline = True
        Me.txtPlayers.Name = "txtPlayers"
        Me.txtPlayers.Size = New System.Drawing.Size(86, 30)
        Me.txtPlayers.TabIndex = 10
        Me.txtPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPlayers.Visible = False
        '
        'lblPlayers
        '
        Me.lblPlayers.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayers.ForeColor = System.Drawing.Color.Black
        Me.lblPlayers.Location = New System.Drawing.Point(0, 34)
        Me.lblPlayers.Name = "lblPlayers"
        Me.lblPlayers.Size = New System.Drawing.Size(134, 31)
        Me.lblPlayers.TabIndex = 10
        Me.lblPlayers.Text = "Players (2-4):"
        Me.lblPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPlayers.Visible = False
        '
        'gbxMulti
        '
        Me.gbxMulti.Controls.Add(Me.lblPlayers)
        Me.gbxMulti.Controls.Add(Me.txtPlayers)
        Me.gbxMulti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbxMulti.Location = New System.Drawing.Point(311, 123)
        Me.gbxMulti.Name = "gbxMulti"
        Me.gbxMulti.Size = New System.Drawing.Size(232, 91)
        Me.gbxMulti.TabIndex = 2
        Me.gbxMulti.TabStop = False
        Me.gbxMulti.Visible = False
        '
        'gbxSettings
        '
        Me.gbxSettings.BackColor = System.Drawing.Color.Snow
        Me.gbxSettings.Controls.Add(Me.btnSave)
        Me.gbxSettings.Controls.Add(Me.btnMusicOff)
        Me.gbxSettings.Controls.Add(Me.btnMusicOn)
        Me.gbxSettings.Controls.Add(Me.btnAudioOff)
        Me.gbxSettings.Controls.Add(Me.btnAudioOn)
        Me.gbxSettings.Controls.Add(Me.txtBrightness)
        Me.gbxSettings.Controls.Add(Me.lblMusic)
        Me.gbxSettings.Controls.Add(Me.lblAudio)
        Me.gbxSettings.Controls.Add(Me.lblBrightness)
        Me.gbxSettings.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSettings.Location = New System.Drawing.Point(311, 55)
        Me.gbxSettings.Name = "gbxSettings"
        Me.gbxSettings.Size = New System.Drawing.Size(232, 290)
        Me.gbxSettings.TabIndex = 11
        Me.gbxSettings.TabStop = False
        Me.gbxSettings.Text = "Settings"
        Me.gbxSettings.Visible = False
        '
        'lblBrightness
        '
        Me.lblBrightness.AutoSize = True
        Me.lblBrightness.Location = New System.Drawing.Point(43, 30)
        Me.lblBrightness.Name = "lblBrightness"
        Me.lblBrightness.Size = New System.Drawing.Size(134, 21)
        Me.lblBrightness.TabIndex = 0
        Me.lblBrightness.Text = "Brightness (1-5)"
        Me.lblBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAudio
        '
        Me.lblAudio.AutoSize = True
        Me.lblAudio.Location = New System.Drawing.Point(43, 84)
        Me.lblAudio.Name = "lblAudio"
        Me.lblAudio.Size = New System.Drawing.Size(55, 21)
        Me.lblAudio.TabIndex = 1
        Me.lblAudio.Text = "Audio"
        Me.lblAudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMusic
        '
        Me.lblMusic.AutoSize = True
        Me.lblMusic.Location = New System.Drawing.Point(43, 149)
        Me.lblMusic.Name = "lblMusic"
        Me.lblMusic.Size = New System.Drawing.Size(55, 21)
        Me.lblMusic.TabIndex = 2
        Me.lblMusic.Text = "Music"
        Me.lblMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBrightness
        '
        Me.txtBrightness.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrightness.Location = New System.Drawing.Point(30, 54)
        Me.txtBrightness.Multiline = True
        Me.txtBrightness.Name = "txtBrightness"
        Me.txtBrightness.Size = New System.Drawing.Size(94, 23)
        Me.txtBrightness.TabIndex = 3
        Me.txtBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAudioOn
        '
        Me.btnAudioOn.BackColor = System.Drawing.Color.Snow
        Me.btnAudioOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAudioOn.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAudioOn.Location = New System.Drawing.Point(16, 110)
        Me.btnAudioOn.Name = "btnAudioOn"
        Me.btnAudioOn.Size = New System.Drawing.Size(51, 23)
        Me.btnAudioOn.TabIndex = 4
        Me.btnAudioOn.Text = "On"
        Me.btnAudioOn.UseVisualStyleBackColor = False
        '
        'btnAudioOff
        '
        Me.btnAudioOff.BackColor = System.Drawing.Color.Snow
        Me.btnAudioOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAudioOff.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAudioOff.Location = New System.Drawing.Point(83, 110)
        Me.btnAudioOff.Name = "btnAudioOff"
        Me.btnAudioOff.Size = New System.Drawing.Size(51, 23)
        Me.btnAudioOff.TabIndex = 5
        Me.btnAudioOff.Text = "Off"
        Me.btnAudioOff.UseVisualStyleBackColor = False
        '
        'btnMusicOn
        '
        Me.btnMusicOn.BackColor = System.Drawing.Color.Snow
        Me.btnMusicOn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMusicOn.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusicOn.Location = New System.Drawing.Point(16, 182)
        Me.btnMusicOn.Name = "btnMusicOn"
        Me.btnMusicOn.Size = New System.Drawing.Size(51, 23)
        Me.btnMusicOn.TabIndex = 6
        Me.btnMusicOn.Text = "On"
        Me.btnMusicOn.UseVisualStyleBackColor = False
        '
        'btnMusicOff
        '
        Me.btnMusicOff.BackColor = System.Drawing.Color.Snow
        Me.btnMusicOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMusicOff.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusicOff.Location = New System.Drawing.Point(83, 182)
        Me.btnMusicOff.Name = "btnMusicOff"
        Me.btnMusicOff.Size = New System.Drawing.Size(51, 23)
        Me.btnMusicOff.TabIndex = 7
        Me.btnMusicOff.Text = "Off"
        Me.btnMusicOff.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Snow
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(47, 230)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(687, 343)
        Me.Controls.Add(Me.gbxSettings)
        Me.Controls.Add(Me.gbxMulti)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.picSettings)
        Me.Controls.Add(Me.picMulti)
        Me.Controls.Add(Me.picStory)
        Me.Controls.Add(Me.panStory)
        Me.Controls.Add(Me.picMainMenu)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnMultiplayer)
        Me.Controls.Add(Me.btnStory)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panStory.ResumeLayout(False)
        CType(Me.picSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMulti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxMulti.ResumeLayout(False)
        Me.gbxMulti.PerformLayout()
        Me.gbxSettings.ResumeLayout(False)
        Me.gbxSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnStory As Button
    Friend WithEvents btnMultiplayer As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picMainMenu As PictureBox
    Friend WithEvents panStory As Panel
    Friend WithEvents radLoad As RadioButton
    Friend WithEvents radNew As RadioButton
    Friend WithEvents picStory As PictureBox
    Friend WithEvents picMulti As PictureBox
    Friend WithEvents picSettings As PictureBox
    Friend WithEvents btnMulti As Button
    Friend WithEvents txtPlayers As TextBox
    Friend WithEvents lblPlayers As Label
    Friend WithEvents gbxMulti As GroupBox
    Friend WithEvents gbxSettings As GroupBox
    Friend WithEvents btnMusicOff As Button
    Friend WithEvents btnMusicOn As Button
    Friend WithEvents btnAudioOff As Button
    Friend WithEvents btnAudioOn As Button
    Friend WithEvents txtBrightness As TextBox
    Friend WithEvents lblMusic As Label
    Friend WithEvents lblAudio As Label
    Friend WithEvents lblBrightness As Label
    Friend WithEvents btnSave As Button
End Class
