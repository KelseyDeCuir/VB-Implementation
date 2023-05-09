Public Class Form1


    Dim strUserInput As String
    Dim strlbxNTitle As String = "New Game"
    Dim strlbxLTitle As String = "Load Game"
    Dim strlbxNameMsg As String = "Please enter a name for your character."
    Dim strlbxLoadMessage As String = "Now Loading..."
    Dim strInvalidNameErrMsg As String = "ERROR: Please enter in a valid name."

    Dim count As Integer = 1
    Private Function ValidateInputSet() As Boolean
        Dim blnValid As Boolean = False
        Dim intSettingsNum As Integer
        Try
            intSettingsNum = Convert.ToInt32(txtBrightness.Text)
            If intSettingsNum >= 1 And intSettingsNum <= 5 Then
                blnValid = True
                Return blnValid
            ElseIf intSettingsNum <= 0 Then
                MsgBox("Please enter in a valid brightness number.", , "Brightness Error")
            Else
                MsgBox("Please enter a brightness number between 1 and 5.", , "Brightness Error")
            End If
        Catch ex As FormatException
            MsgBox("Please enter a valid brightness number.", , "Brightness Error")
        Catch ex As OverflowException
            MsgBox("Please enter a reasonable brightness number.", , "Brightness Error")
        Catch ex As SystemException
            MsgBox("Invalid brightness. Please enter a valid number of brightness.", , "Brightness Error")
        End Try
        txtBrightness.Focus()
        txtBrightness.Clear()
        Return blnValid

    End Function

    Private Function ValidateInputMulti() As Boolean
        Dim blnValid As Boolean = False
        Dim intMultiNum As Integer
        Try
            intMultiNum = Convert.ToInt32(txtPlayers.Text)
            If intMultiNum >= 2 And intMultiNum <= 4 Then
                blnValid = True
                Return blnValid
            ElseIf intMultiNum <= 1 Then
                MsgBox("Please enter in a number of players greater than 1 and less than 5.", , "Multiplayer Error")
            Else
                MsgBox("Please enter a number of players between 2 and 4.", , "Multiplayer Error")
            End If
        Catch ex As FormatException
            MsgBox("Please enter a valid amount of players.", , "Multiplayer Error")
        Catch ex As OverflowException
            MsgBox("Please enter a reasonable amount of players.", , "Multiplayer Error")
        Catch ex As SystemException
            MsgBox("Invalid number of players. Please enter a valid number of players.", , "Multiplayer Error")
        End Try
        txtPlayers.Focus()
        txtPlayers.Clear()
        Return blnValid

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picMainMenu.Visible = True
        picStory.Visible = False
        picMulti.Visible = False
        picSettings.Visible = False
        panStory.Visible = False
        gbxSettings.Visible = False

    End Sub
    Private Sub btnStory_Click(sender As Object, e As EventArgs) Handles btnStory.Click
        picMainMenu.Visible = False
        picStory.Visible = True
        picMulti.Visible = False
        picSettings.Visible = False
        panStory.Visible = True
        lblPlayers.Visible = False
        txtPlayers.Visible = False
        btnMulti.Visible = False
        gbxMulti.Visible = False
        gbxSettings.Visible = False

    End Sub
    Private Sub radNew_CheckedChanged(sender As Object, e As EventArgs) Handles radNew.CheckedChanged
        Do Until count = 0
            If radNew.Checked.Equals(True) Then
                strUserInput = InputBox(strlbxNameMsg, strlbxNTitle)
                If IsNumeric(strUserInput) Then
                    strlbxNameMsg = strInvalidNameErrMsg
                    count = 1
                Else
                    count = 0
                End If
            End If
        Loop
        MsgBox("Game now loading...", , "Ascension")
        Close()
    End Sub
    Private Sub radLoad_CheckedChanged(sender As Object, e As EventArgs) Handles radLoad.CheckedChanged
        If radLoad.Checked.Equals(True) Then
            MsgBox(strlbxLoadMessage, , strlbxLTitle)
        End If
        Close()
    End Sub

    Private Sub btnMultiplayer_Click(sender As Object, e As EventArgs) Handles btnMultiplayer.Click
        picMainMenu.Visible = False
        picStory.Visible = False
        picMulti.Visible = True
        picSettings.Visible = False
        panStory.Visible = False
        lblPlayers.Visible = True
        txtPlayers.Visible = True
        btnMulti.Visible = True
        gbxMulti.Visible = True
        gbxSettings.Visible = False


    End Sub
    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim blnPlayersValid As Boolean = False
        blnPlayersValid = ValidateInputMulti()
        If blnPlayersValid = True Then
            MsgBox("Co-op mode now loading...", , "Multiplayer Mode")
            Close()
        End If
    End Sub


    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        picMainMenu.Visible = False
        picStory.Visible = False
        picMulti.Visible = False
        picSettings.Visible = True
        panStory.Visible = False
        gbxMulti.Visible = False
        btnMulti.Visible = False
        gbxSettings.Visible = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim blnBrightnessValid As Boolean = False
        blnBrightnessValid = ValidateInputSet()
        If blnBrightnessValid = True Then
            MsgBox("Settings saved", , "Settings")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Thanks for playing!", , "Ascension")
        Close()
    End Sub


End Class
