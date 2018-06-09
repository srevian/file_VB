Public Class Form3

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True Then
            Form2.Show()
        ElseIf RadioButton3.Checked = True Then
            Form4.Show()
        ElseIf RadioButton2.Checked Then
            Form5.Show()
        ElseIf RadioButton4.Checked Then
            Form6.Show()
        End If
    End Sub
End Class