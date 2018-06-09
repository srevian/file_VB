Public Class Form5
    Dim Regi_no, data, filename As String
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Regi_no = TextBox1.Text
        Dim details As New IO.FileStream("C:\patientmanagement\" & Regi_no & ".txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        Dim detailsreader As New IO.StreamReader(details)
        data = detailsreader.ReadLine
        TextBox1.Text = data
        data = detailsreader.ReadLine
        TextBox2.Text = data
        data = detailsreader.ReadLine
        RichTextBox1.Text = data
        data = detailsreader.ReadLine
        TextBox6.Text = data
        data = detailsreader.ReadLine
        ComboBox1.Text = data
        data = detailsreader.ReadLine
        TextBox3.Text = data
        data = detailsreader.ReadLine
        TextBox4.Text = data
        data = detailsreader.ReadLine
        TextBox5.Text = data
        data = detailsreader.ReadLine
        ComboBox2.Text = data
        data = detailsreader.ReadLine
        ComboBox3.Text = data
        data = detailsreader.ReadLine
        TextBox7.Text = data

        detailsreader.Close()
        details.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        filename = "C:\patientmanagement\" & Regi_no & ".txt"
        MsgBox("Are You Sure To Delete This File" & filename, vbYesNo)
        If vbYes Then
            Kill(filename)
        End If

        If TextBox1.Text = "" Then
            MsgBox("Registration no. should be filled up !!!")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Patient name should be filled up !!!")
        ElseIf RichTextBox1.Text = "" Then
            MsgBox("Address should be filled up !!!")
        ElseIf TextBox6.Text = "" Then
            MsgBox("Ph no. should be filled up !!!")
        End If

        Regi_no = TextBox1.Text
        Dim details As New IO.FileStream("C:\patientmanagement\" & Regi_no & ".txt", IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.Read)
        Dim detailswriter As New IO.StreamWriter(details)
        detailswriter.WriteLine(TextBox1.Text)
        detailswriter.WriteLine(TextBox2.Text)
        detailswriter.WriteLine(RichTextBox1.Text)
        detailswriter.WriteLine(TextBox6.Text)
        detailswriter.WriteLine(ComboBox1.Text)
        detailswriter.WriteLine(TextBox3.Text)
        detailswriter.WriteLine(TextBox4.Text)
        detailswriter.WriteLine(TextBox5.Text)
        detailswriter.WriteLine(ComboBox2.Text)
        detailswriter.WriteLine(ComboBox3.Text)
        detailswriter.WriteLine(TextBox7.Text)

        detailswriter.Close()
        details.Close()
        MsgBox("Updated successfully !!!")
        Me.Hide()
    End Sub
End Class