Public Class FormAWAL



    Private Sub ButtonSTART_Click(sender As Object, e As EventArgs) Handles ButtonSTART.Click
        'My.Computer.Audio.Play("C:\Users\Jessica\Documents\Visual Studio 2012\Projects\sudoku\Dora_The_Explorer_Point_and_Click_Sound_Effect-uYAq4LPx-a4.wav", AudioPlayMode.Background)

        If RadioButtonEASY.Checked = True Then
            Form1.ShowDialog()
        End If
        If RadioButtonMEDIUM.Checked = True Then
            Form1.ShowDialog()
        End If
        If RadioButtonHARD.Checked = True Then
            Form1.ShowDialog()
        End If
    End Sub

    Private Sub RadioButtonEASY_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEASY.CheckedChanged

    End Sub

    Private Sub FormAWAL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class