Public Class Form6
    Dim Reg_no, data, file As String
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Reg_no = TextBox1.Text
        Dim details As New IO.FileStream("C:\patientmanagement\" & Reg_no & ".txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        Dim detailsreader As New IO.StreamReader(details)
        Data = detailsreader.ReadLine
        TextBox1.Text = Data
        Data = detailsreader.ReadLine
        TextBox2.Text = Data
        Data = detailsreader.ReadLine
        RichTextBox1.Text = Data
        Data = detailsreader.ReadLine
        TextBox6.Text = Data
        Data = detailsreader.ReadLine
        ComboBox1.Text = Data
        Data = detailsreader.ReadLine
        TextBox3.Text = Data
        Data = detailsreader.ReadLine
        TextBox4.Text = Data
        Data = detailsreader.ReadLine
        TextBox5.Text = Data
        Data = detailsreader.ReadLine
        ComboBox2.Text = Data
        Data = detailsreader.ReadLine
        ComboBox3.Text = Data
        Data = detailsreader.ReadLine
        TextBox7.Text = Data

        detailsreader.Close()
        details.Close()

        file = "C:\patientmanagement\" & Reg_no & ".txt"
        MsgBox("Are You Sure To Delete This File" & file, vbYesNo)
        If vbYes Then
            Kill(file)
        End If
        MsgBox("Removed Successfully !!!")
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class