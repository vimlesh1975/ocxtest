
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AxShockwaveFlashObjects
Imports Svt.Caspar
Imports Svt.Network

Public Class Form1
    Dim flashControl As AxShockwaveFlash
    Dim CasparCGDataCollection As New CasparCGDataCollection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        flashControl = New AxShockwaveFlash()
        flashControl.Location = New Point(0, 0)
        flashControl.Size = New Size(400, 300)

        Me.Controls.Add(flashControl)

        flashControl.Movie = "file:///" + "c:/casparcg/cg20.fth.pal"


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim xmlString = TextBox4.Text.Replace("""", "'")
            flashControl.CallFunction(xmlString)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim xmlString = TextBox5.Text.Replace("""", "'")
        flashControl.CallFunction(xmlString)
    End Sub
End Class
