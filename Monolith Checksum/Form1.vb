'This program is free for use under the GNU General Public Software License
'Copyright © Monolith Solutions Inc 2017
'For More Info Visit:
'https://www.monolithsolutions.ca
'info@monolithsolutions.ca

'This program Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'This program Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty Of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with this program.  If Not, see < http: //www.gnu.org/licenses/>.

Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class Form1
    Private path As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MChecksumLogo
    End Sub

    Private Sub BT_OPEN_Click(sender As Object, e As EventArgs) Handles BT_OPEN.Click
        path = Nothing
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        OpenFileDialog1.ShowDialog()
        TB_DIR.Text = OpenFileDialog1.FileName
        path = OpenFileDialog1.FileName
    End Sub

    Private Sub BT_CHECK_Click(sender As Object, e As EventArgs) Handles BT_CHECK.Click
        If path <> "" Then
            If File.Exists(path) Then
                TB_MD5CALC.Text = MD5_Hash(path)
                TB_SHA1CALC.Text = SHA1_Hash(path)
                TB_SHA256CALC.Text = SHA256_Hash(path)
                IMAGEHANDLER()
            Else
                MsgBox("No File Selected!" & Environment.NewLine & "Please Open A File")
            End If
        Else
            MsgBox("No File Selected!" & Environment.NewLine & "Please Open A File")
        End If
    End Sub

    Private Sub BT_CLEAR_Click(sender As Object, e As EventArgs) Handles BT_CLEAR.Click
        TB_DIR.Text = ""
        TB_MD5.Text = ""
        TB_MD5CALC.Text = ""
        TB_SHA1.Text = ""
        TB_SHA1CALC.Text = ""
        TB_SHA256.Text = ""
        TB_SHA256CALC.Text = ""
    End Sub

    Private Sub BT_EXIT_Click(sender As Object, e As EventArgs) Handles BT_EXIT.Click
        Me.Dispose()
    End Sub

    '=========================================================================================
    'Toolstrip Menu
    '=========================================================================================

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Me.BT_OPEN_Click(0, Nothing)
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem.Click
        FolderBrowserDialog1.SelectedPath = ""
        FolderBrowserDialog1.ShowDialog()
        Dim fdpath = FolderBrowserDialog1.SelectedPath
        Dim result As Integer = MsgBox("Do you want to run checksum on all files in directory " & Environment.NewLine & fdpath & Environment.NewLine & Environment.NewLine, MessageBoxButtons.YesNo)
        If result = 6 Then
            MultiHash(fdpath)
        ElseIf result = 7 Then
            'Do Nothing
        Else
            MsgBox("ERROR: 84" & Environment.NewLine & "Please report this bug to the software vendor.")
        End If
        fdpath = Nothing
        result = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Dim hpath As String = Application.StartupPath & "/checksum-help.chm"
        If File.Exists(hpath) Then
            Dim help As New Process
            help.StartInfo.UseShellExecute = True
            help.StartInfo.FileName = "C:\windows\hh.exe"
            help.StartInfo.Arguments = hpath
            help.Start()
        Else
            Dim binwriter = New IO.BinaryWriter(IO.File.Create("checksum-help.chm"))
            binwriter.Write(My.Resources.checksum_help)
            binwriter.Close()
            Dim help As New Process
            help.StartInfo.UseShellExecute = True
            help.StartInfo.FileName = "C:\windows\hh.exe"
            help.StartInfo.Arguments = hpath
            help.Start()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.monolithsolutions.ca/download/")
    End Sub

    '=========================================================================================
    'Functions & Subs
    '=========================================================================================
    Private Sub IMAGEHANDLER()
        If TB_MD5.Text <> "" Then
            If TB_MD5.Text = TB_MD5CALC.Text Then
                PIC_MD5.Image = My.Resources.Yes
            Else
                PIC_MD5.Image = My.Resources.No
            End If
        Else
            PIC_MD5.Image = My.Resources.Maybe
        End If

        If TB_SHA1.Text <> "" Then
            If TB_SHA1.Text = TB_SHA1CALC.Text Then
                PIC_SHA1.Image = My.Resources.Yes
            Else
                PIC_SHA1.Image = My.Resources.No
            End If
        Else
            PIC_SHA1.Image = My.Resources.Maybe
        End If

        If TB_SHA256.Text <> "" Then
            If TB_SHA256.Text = TB_SHA256CALC.Text Then
                PIC_SHA256.Image = My.Resources.Yes
            Else
                PIC_SHA256.Image = My.Resources.No
            End If
        Else
            PIC_SHA256.Image = My.Resources.Maybe
        End If
    End Sub

    Private Sub MultiHash(ByVal fldr As String)
        Dim fi As String() = Directory.GetFiles(fldr)
        Dim od As String = fldr & "/" & "~CHECKSUM-COMPUTE.CSV"

        If File.Exists(od) Then
        Else
            File.Create(od).Close()
        End If

        Using sr As StreamWriter = New StreamWriter(od)
            For Each x In fi
                sr.WriteLine(x & "," & MD5_Hash(x) & "," & SHA1_Hash(x) & "," & SHA256_Hash(x) & Environment.NewLine)
            Next
            sr.Close()
            MsgBox("Checksum Complete!" & Environment.NewLine & "View ~CHECKSUM-COMPUTE.CSV in folder directory.")
        End Using
        fi = Nothing
        od = Nothing
    End Sub

    Private Function MD5_Hash(ByVal dir As String) As String
        Dim file() As Byte = System.IO.File.ReadAllBytes(dir)
        Dim md5 As New MD5CryptoServiceProvider()
        Dim bytehash() As Byte = md5.ComputeHash(file)
        Dim sb As New StringBuilder()

        For i = 0 To bytehash.Length - 1
            sb.Append(bytehash(i).ToString("X2"))
        Next

        Return sb.ToString()

        file = Nothing
        md5 = Nothing
        bytehash = Nothing
        sb = Nothing
    End Function

    Private Function SHA1_Hash(ByVal dir As String) As String
        Dim file() As Byte = System.IO.File.ReadAllBytes(dir)
        Dim sha1 As New SHA1CryptoServiceProvider()
        Dim bytehash() As Byte = sha1.ComputeHash(file)
        Dim sb As New StringBuilder()

        For i = 0 To bytehash.Length - 1
            sb.Append(bytehash(i).ToString("X2"))
        Next

        Return sb.ToString()

        file = Nothing
        sha1 = Nothing
        bytehash = Nothing
        sb = Nothing
    End Function

    Private Function SHA256_Hash(ByVal dir As String) As String
        Dim file() As Byte = System.IO.File.ReadAllBytes(dir)
        Dim sha256 As New SHA256CryptoServiceProvider()
        Dim bytehash() As Byte = sha256.ComputeHash(file)
        Dim sb As New StringBuilder()

        For i = 0 To bytehash.Length - 1
            sb.Append(bytehash(i).ToString("X2"))
        Next

        Return sb.ToString()

        file = Nothing
        sha256 = Nothing
        bytehash = Nothing
        sb = Nothing
    End Function
End Class
