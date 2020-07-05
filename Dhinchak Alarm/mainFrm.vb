Public Class mainForm
    Private Const firstElement As SByte = 0
    Dim HOURTOSECS As Short = 60 * 60
    Dim MINTOSECS As Short = 60
    Dim timeLeftSeconds As Int16 = 0

    Public Sub New()

        InitializeComponent()

        ''TODO - Initialise the combo box so that any new entry into Audio folder
        ''is automatically parsed into list of items
        alarmSoundSelector.SelectedIndex = firstElement

    End Sub

    ''' <summary>
    ''' Regular Alarm Tick event. Ticker ends when time remaining drops to 0 seconds.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub alarmTimer_Tick(sender As Object, e As EventArgs) _
        Handles alarmTimer.Tick

        If timeLeftSeconds = 0 Then
            alarmTimer.Stop()
            playSound()
        End If

        timeLeftLabel.Text = returnTimeFormat(timeLeftSeconds)
        timeLeftSeconds -= 1

    End Sub

    Private Sub setButton_Click(sender As Object, e As EventArgs) _
        Handles setButton.Click

        alarmTimer.Start()
        timeLeftSeconds = hourUpDown.Value * HOURTOSECS + MinuteUpDown.Value * MINTOSECS

    End Sub

    ''' <summary>
    ''' returnTimeFormat return the time in String Format such that hours 
    ''' and minutes left are clearly shown. This helps in abstracting the
    ''' string generation for time remaining.
    ''' </summary>
    ''' <param name="time">time as Int16</param>
    ''' <returns>timeInText</returns>
    Private Function returnTimeFormat(ByVal time As Int16) As String

        Dim hours, minutes, seconds As String
        Dim timeInText = ""

        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(time)

        hours = iSpan.Hours.ToString.PadLeft(2, "0"c)
        minutes = iSpan.Minutes.ToString.PadLeft(2, "0"c)
        seconds = iSpan.Seconds.ToString.PadLeft(2, "0"c)

        If CInt(hours) > 0 Then
            timeInText = hours + " hrs and " +
                     minutes + " mins and " +
                     seconds + " seconds"
        ElseIf CInt(hours) = 0 And CInt(minutes) > 0 Then
            timeInText = minutes + " mins and " + seconds + " seconds"
        Else
            timeInText = seconds + " seconds"
        End If

        Return timeInText

    End Function

    Private Sub playSound()

        Dim path As String = System.AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Audio\")
        Dim song = ""
        Select Case alarmSoundSelector.SelectedIndex
            Case 0
                song = My.Resources.selfie_maine
            Case 1
                song = My.Resources.dilo_ka_shooter
        End Select

        Try
            My.Computer.Audio.Play(path + song, AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
            MessageBox.Show(ex.Message + path + song)
        End Try

    End Sub

    ''' <summary>
    ''' TO DO
    ''' </summary>
    Private Sub parseAlarmSounds()

    End Sub

End Class
