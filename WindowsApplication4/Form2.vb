Public Class Form2
    Dim reg_no, sex As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Registration no. should be filled up !!!")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Patient name should be filled up !!!")
        ElseIf RichTextBox1.Text = "" Then
            MsgBox("Address should be filled up !!!")
        ElseIf TextBox6.Text = "" Then
            MsgBox("Ph no. should be filled up !!!")
        End If

        reg_no = TextBox1.Text
        Dim details As New IO.FileStream("C:\patientmanagement\" & reg_no & ".txt", IO.FileMode.CreateNew, IO.FileAccess.ReadWrite, IO.FileShare.Read)
        Dim detailswriter As New IO.StreamWriter(details)
        detailswriter.WriteLine(reg_no)
        detailswriter.WriteLine(TextBox2.Text)
        detailswriter.WriteLine(RichTextBox1.Text)
        detailswriter.WriteLine(TextBox6.Text)
        detailswriter.WriteLine(ComboBox1.Text)
        detailswriter.WriteLine(TextBox3.Text)
        detailswriter.WriteLine(TextBox4.Text)
        detailswriter.WriteLine(TextBox5.Text)
        detailswriter.WriteLine(ComboBox2.Text)

        If RadioButton1.Checked = True Then
            sex = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            sex = RadioButton2.Text
        ElseIf RadioButton3.Checked = True Then
            sex = RadioButton3.Text
        Else
            MsgBox("sex should be filled up !!!")
        End If

        detailswriter.WriteLine(sex)
        detailswriter.WriteLine(TextBox7.Text)

        detailswriter.Close()
        details.Close()
        MsgBox(" Saved Successfully !!!")
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class