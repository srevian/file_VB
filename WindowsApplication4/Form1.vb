Public Class Form1
    Dim intmsg As String
    Dim username As String
    Dim password As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dir As New IO.DirectoryInfo("C:\patientmanagement")
        dir.CreateSubdirectory("subdir")
        Dim loginfile As New IO.FileStream("C:\patientmanagement\login.txt", IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.Read)
        Dim myfilewriter As New IO.StreamWriter(loginfile)
        myfilewriter.WriteLine("sourav")
        myfilewriter.WriteLine("12345")
        myfilewriter.Close()
        loginfile.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click
        Dim loginfile As New IO.FileStream("C:\patientmanagement\login.txt", IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
        Dim myfilereader As New IO.StreamReader(loginfile)
        username = myfilereader.ReadLine()
        password = myfilereader.ReadLine()
        If StrComp(TextBox1.Text, username) = 0 Then
            If StrComp(TextBox2.Text, password) = 0 Then
                Form3.Show()
            Else
                MsgBox("invalid password !!! try again...")
                TextBox2.Clear()
            End If
        Else
            MsgBox("invalid username !!! try again...")
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
