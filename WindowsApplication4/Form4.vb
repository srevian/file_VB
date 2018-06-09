Public Class Form4
    Dim regis_no, result As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        regis_no = TextBox1.Text
        Dim details As New IO.FileStream("C:\patientmanagement\" & regis_no & ".txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        Dim detailsreader As New IO.StreamReader(details)
        result = detailsreader.ReadLine
        TextBox1.Text = result
        result = detailsreader.ReadLine
        TextBox2.Text = result
        result = detailsreader.ReadLine
        RichTextBox1.Text = result
        result = detailsreader.ReadLine
        TextBox6.Text = result
        result = detailsreader.ReadLine
        TextBox9.Text = result
        result = detailsreader.ReadLine
        TextBox3.Text = result
        result = detailsreader.ReadLine
        TextBox4.Text = result
        result = detailsreader.ReadLine
        TextBox5.Text = result
        result = detailsreader.ReadLine
        TextBox10.Text = result
        result = detailsreader.ReadLine
        TextBox8.Text = result
        result = detailsreader.ReadLine
        TextBox7.Text = result

        detailsreader.Close()
        details.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class