Imports System.IO

Public Class Form1
    Dim PDQPath As String
    Dim StartupArg As String

    Public Sub ShellandWait(ByVal ProcessPath As String)
        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.Start()

            'Wait until the process passes back an exit code 
            objProcess.WaitForExit()

            'Free resources associated with this process
            objProcess.Close()
        Catch
            MessageBox.Show("Could not start process " & ProcessPath, "Error")
        End Try
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        REM Dim Temp As String = ""

        Dim TextLine As String
        Dim MKVStr As String
        Dim PParm As String
        Dim Str1 As String
        Dim Str2 As String
        Dim Skip As Boolean
        Dim OrgFile As String
        If (PathToVideos.Text <> "" And FileNameBox.Text <> "") Then
            If My.Computer.FileSystem.FileExists(PathToVideos.Text + "\" + FileNameBox.Text) Then My.Computer.FileSystem.DeleteFile(PathToVideos.Text + "\" + FileNameBox.Text)
            If My.Computer.FileSystem.FileExists(PathToVideos.Text + "\Temp.bat") Then My.Computer.FileSystem.DeleteFile(PathToVideos.Text + "\Temp.bat")
            Str2 = PathToVideos.Text.ToString
            Str2 = Str2.Replace(vbCr, "")
            Str2 = Str2.Replace(vbLf, "")
            PathToVideos.Text = Str2

            Str2 = Str2 + "\TempDir.bat"

            Dim strFile2 As String = Str2

            Dim fileExists2 As Boolean = File.Exists(strFile2)
            Dim sw2 As New StreamWriter(File.Open(strFile2, FileMode.OpenOrCreate))
            sw2.WriteLine("")
            sw2.WriteLine("c:\windows\system32\CMD.exe /C DIR " + PathToVideos.Text + "\*.mp4 /s /b > " + PathToVideos.Text + "\" + FileNameBox.Text)
            sw2.Close()

            ShellandWait(strFile2)
            REM ShellandWait("c:\windows\system32\CMD.exe", "/C DIR " + PathToVideos.Text + "\*.ts /s /b > " + FileNameBox.Text)
            
        End If

        Dim FILE_NAME As String = PathToVideos.Text + FileNameBox.Text
        Dim StreamName = ""
        Dim objReader As New System.IO.StreamReader(FILE_NAME)
        Do While objReader.Peek() <> -1
            Skip = False
            StreamName = ""
            MKVStr = ""
            PParm = ""
            TextLine = ""
            TextLine = TextLine & objReader.ReadLine() & vbNewLine

            TextLine = TextLine.Substring(0, TextLine.Length - 1)

            TextLine = """" + TextLine + """"
            MKVStr = TextLine
            OrgFile = TextLine

            MKVStr = MKVStr.Replace(".mp4", "")
            MKVStr = Replace(MKVStr, ".mp4", "")

            PParm = MKVStr
            PParm = Replace(PParm, "~", "")
            PParm = Replace(PParm, "!", "")
            PParm = Replace(PParm, "@", "")
            PParm = Replace(PParm, "#", "")
            PParm = Replace(PParm, "$", "")
            PParm = Replace(PParm, "%", "")
            PParm = Replace(PParm, "^", "")
            PParm = Replace(PParm, "&", "")
            PParm = Replace(PParm, "*", "")
            PParm = Replace(PParm, "(", "")
            PParm = Replace(PParm, ")", "")
            PParm = Replace(PParm, "+", "")
            PParm = Replace(PParm, "=", "")
            PParm = Replace(PParm, ".", "")
            PParm = PParm.Replace(PathToVideos.Text, "")
            PParm = Replace(PParm, "\", "")
            StreamName = Replace(PParm, " ", "")
            Str1 = ffMPEGPath.Text.ToString
            If OrgFile.Contains(".grab") Then
                Skip = True
            End If
            If Skip = False Then
                If My.Computer.FileSystem.FileExists(PathToVideos.Text + "\Temp.bat") Then My.Computer.FileSystem.DeleteFile(PathToVideos.Text + "\Temp.bat")
                Dim strFile As String = PathToVideos.Text + "\Temp.bat"
                Dim fileExists As Boolean = File.Exists(strFile)
                Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))
                    sw.WriteLine("")
                    sw.WriteLine(ffMPEGPath.Text.ToString + " stream create " + StreamName.ToString + " " + TextBox2.Text + " " + OrgFile.ToString + " --channel_id=" + TextBox1.Text + " --title=" + PParm.ToString + " --tags=" + TextBox3.Text)
                End Using
                ShellandWait(PathToVideos.Text + "\Temp.bat")
                REM OrgFile = OrgFile.Substring(0, OrgFile.Length - 1)
                REM  OrgFile = OrgFile.Remove(0, 1)
                REM My.Computer.FileSystem.DeleteFile(OrgFile)
            End If
        Loop
        REM ffmpeg -i input -map 0 -c copy output.mkv

        If TextBox4.Text = "/A" Then End
    End Sub

    Private Sub PathToVideos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PathToVideos.TextChanged

    End Sub

    Private Sub FileNameBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileNameBox.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Sub Main()

        ' Get the values of the command line in an array
        ' Index  Discription
        ' 0      Full path of executing prograsm with program name
        ' 1      First switch in command in your example -t
        ' 2      First value in command in your example text1
        ' 3      Second switch in command in your example -s
        ' 4      Second value in command in your example text2
        Dim clArgs() As String = Environment.GetCommandLineArgs()
        ' Hold the command line values
        Dim type As String = String.Empty
        Dim speed As String = String.Empty
        ' Test to see if two switchs and two values were passed in
        ' if yes parse the array
        If clArgs.Count() = 1 Then type = clArgs(1)
        Console.WriteLine(type)
        Console.ReadLine()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM  Console.WriteLine("GetCommandLineArgs: {0}", String.Join(", ", args))
        Dim clArgs() As String = Environment.GetCommandLineArgs()
        ' Hold the command line values
        Dim type As String = String.Empty
        Dim speed As String = String.Empty
        ' Test to see if two switchs and two values were passed in
        ' if yes parse the array
        If clArgs.Count() = 2 Then type = clArgs(1)
        Console.WriteLine(type)
 
        If clArgs.Length > 1 Then TextBox4.Text = clArgs(1)
        Dim strPath As String = System.IO.Path.GetDirectoryName( _
            System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim ConfigName As String = strPath + "\LBRYImport.INI"

        Dim ConfigName2 As String = ConfigName.Remove(0, 6)
        ConfigName = ConfigName2

        Dim StreamName2 = ""
        Dim PathToLbry As String
        Dim Tags As String
        Dim PathOfVideos2 As String
        Dim ChannelId As String
        Dim bid As String


        If My.Computer.FileSystem.FileExists(ConfigName) Then
            Dim objReader As New System.IO.StreamReader(ConfigName)
            PathToLbry = objReader.ReadLine() & vbNewLine
            PathOfVideos2 = objReader.ReadLine() & vbNewLine
            ChannelId = objReader.ReadLine() & vbNewLine
            Tags = objReader.ReadLine() & vbNewLine
            bid = objReader.ReadLine() & vbNewLine
            objReader.Close()
        Else
            PathToLbry = """c:\Program Files\LBRY\resources\static\daemon\lbrynet.exe"""
            PathOfVideos2 = "F:\Video\JSNIP4\JSNIp4\"
            ChannelId = "80c77fa72bf4dc000876543dae37aa3d2e2af227"
            Tags = "News"
            bid = "0.01"
            Dim strFile5 As String = ConfigName
            Dim fileExists As Boolean = File.Exists(strFile5)
            Using sw As New StreamWriter(File.Open(strFile5, FileMode.OpenOrCreate))
                sw.WriteLine(PathToLbry)
                sw.WriteLine(PathOfVideos2)
                sw.WriteLine(ChannelId)
                sw.WriteLine(Tags)
                sw.WriteLine(bid)
                sw.Close()
            End Using
        End If
        PathToLbry = PathToLbry.Replace(vbCr, "")
        PathToLbry = PathToLbry.Replace(vbLf, "")


        PathOfVideos2 = PathOfVideos2.Replace(vbCr, "")
        PathOfVideos2 = PathOfVideos2.Replace(vbLf, "")


        ChannelId = ChannelId.Replace(vbCr, "")
        ChannelId = ChannelId.Replace(vbLf, "")


        Tags = Tags.Replace(vbCr, "")
        Tags = Tags.Replace(vbLf, "")

        bid = bid.Replace(vbCr, "")
        bid = bid.Replace(vbLf, "")

        ffMPEGPath.Text = PathToLbry
        PathToVideos.Text = PathOfVideos2
        TextBox1.Text = ChannelId
        TextBox3.Text = Tags
        TextBox2.Text = bid
        Dim strFile6 As String = ConfigName
        Using sw As New StreamWriter(File.Open(strFile6, FileMode.OpenOrCreate))
            sw.WriteLine(PathToLbry)
            sw.WriteLine(PathOfVideos2)
            sw.WriteLine(ChannelId)
            sw.WriteLine(Tags)
            sw.WriteLine(bid)
            sw.Close()
        End Using
        If TextBox4.Text = "/A" Then Button2_Click(sender, e)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ffMPEGPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ffMPEGPath.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim strPath As String = System.IO.Path.GetDirectoryName( _
     System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        Dim ConfigName As String = strPath + "\LBRYImport.INI"

        Dim ConfigName2 As String = ConfigName.Remove(0, 6)
        ConfigName = ConfigName2
        Dim StreamName2 = ""
        Dim PathToLbry As String
        Dim Tags As String
        Dim PathOfVideos2 As String
        Dim ChannelId As String
        Dim bid As String

        Dim strFile5 As String = ConfigName
        Dim fileExists As Boolean = File.Exists(strFile5)
        Using sw As New StreamWriter(File.Open(strFile5, FileMode.OpenOrCreate))
            sw.WriteLine(PathToLbry)
            sw.WriteLine(PathOfVideos2)
            sw.WriteLine(ChannelId)
            sw.WriteLine(Tags)
            sw.WriteLine(bid)
            sw.Close()
        End Using

    End Sub
End Class