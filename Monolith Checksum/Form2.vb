'This program is free for use under the GNU General Public Software License
'Copyright © Monolith Solutions Inc 2017
'For More Info Visit:
'https://www.monolithsolutions.ca
'info@monolithsolutions.ca

'This file Is part of Monolith Checksum.

'Monolith Checksum Is free software: you can redistribute it And/Or modify
'it under the terms Of the GNU General Public License As published by
'the Free Software Foundation, either version 3 Of the License, Or
'(at your option) any later version.

'Monolith Checksum Is distributed In the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License For more details.

'You should have received a copy Of the GNU General Public License
'along with Foobar.  If Not, see < http: //www.gnu.org/licenses/>.

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox1.Image = My.Resources.MChecksumLogoPng
        Me.Icon = My.Resources.MChecksumLogo
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.monolithsolutions.ca/")
    End Sub
End Class