Imports System.IO
Imports System.Diagnostics
Imports System.Text
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FileOpen(1, "C:\Users\djohann\Documents\programs\Job\admint\alpsadminconsole.txt", OpenMode.Input)
        'FileClose()
        'FileOpen(2, "C:\Users\djohann\Documents\programs\Job\admint\Monthly-Rollup-State2.txt", OpenMode.Input)
        'FileClose("C:\Users\djohann\Documents\programs\Job\admint\Monthly-Rollup-State2.txt")

    End Sub
    Private Sub btnreadtxt_Click(sender As Object, e As EventArgs) Handles btnupdatemissing.Click
        FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
        Dim localdir As String
        localdir = My.Computer.FileSystem.CurrentDirectory
        'array of data from the Windows adminconsole
        Dim adminconsdata(400) As String
        'array index
        Dim i As Integer = 0
        'array of data of each line from admin console
        Dim dataperperson() As String
        'array of the wsus file in one string
        Dim wsusdata As String = My.Computer.FileSystem.ReadAllText("" & localdir & "\Monthly-Rollup-State2.txt")
        'store the pcx number of the problematic accounts in a list
        Dim problempcx As New List(Of String)
        'store the names of the users in a List  
        Dim nameproblems As New List(Of String)

        Dim senderaddress, ccaddress As String
        senderaddress = senderemailaddress.Text
        ccaddress = ccmailadress.Text
        'read lines of the file into array adminconsdata
        While Not EOF(1)
            adminconsdata(i) = LineInput(1)
            'Console.WriteLine(adminconsdata(i))
            'MsgBox(adminconsdata(i))
            dataperperson = Split(adminconsdata(i), ControlChars.Tab)
            If wsusdata.Contains(dataperperson(0)) = True Then
                MsgBox(dataperperson(0))
                'problempcx.Add(dataperperson(1))
                'nameproblems.Add(dataperperson(2))
                Dim AnswerYes As String
                Dim AnswerNo As String
                AnswerYes = MsgBox("Name: " & dataperperson(3) & "," & vbCrLf & " pxc-Nummer: " & dataperperson(1) & "," & vbCrLf & " ERROR: AU-Client nicht aktuell! ", vbQuestion + vbYesNo, "Send mail")

                If AnswerYes = vbYes Then
                    'email schicken über powershell
                    Dim proc As Process
                    proc = Process.Start("powershell.exe", "-File  "" " & localdir & "\sendmail.ps1"" " & dataperperson(3) & " " & dataperperson(0) & " " & dataperperson(1) & " " & senderaddress & " " & ccaddress & "")
                    'proc = Process.Start("powershell.exe", "-noexit -File ""C:\Users\djohann\Documents\programs\Job\admint\sendmail.ps1"" DESY")
                    proc.WaitForExit()
                Else
                    'Vielleicht die Daten rausschreiben
                End If

            Else
                'MsgBox("no problems ")
            End If
            i = i + 1

        End While

        FileClose(1)
        FileOpen(2, "C:\Users\djohann\Documents\programs\Job\admint\Monthly-Rollup-State2.txt", OpenMode.Input)
        FileClose(2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Textfile|*.txt"
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnsendmail_Click(sender As Object, e As EventArgs) Handles btnsendmail.Click
        MsgBox("First you should download the file https://winweb.desy.de/Secured/Reports/Monthly-Rollup-State2.csv and place a tab-separated table in the form of a .txt file of it in the folder of the .exe of this program")
        MsgBox("The 'select group' button allows you to select a .txt file that you have previously loaded from the Windows Management Console of a specific group via remote desktop connection. Copy the file to a folder that you can reach from your local computer.")
        MsgBox("The center of the page has text fields for entering the sender's email address and adding a cc recipient. To stay organized, it's best to include your own email address in the cc field.")
        MsgBox("If you press the detect update button, all computers from the WSUS report that have an entry in the admin console of the previously selected group are displayed. In any case, the message box should show exactly one first and last name separated by a space and the pcx number of the computer underneath. If there are several names separated by a space, there may be formatting problems in the emails. If all the information is correct, you can click on YES and an email will be sent to the appropriate person. If the data is not displayed in the desired form, click on NO and no mail will be sent.")
    End Sub


End Class
