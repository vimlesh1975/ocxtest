
Imports Svt.Caspar
Public Class Form1
    Dim CasparCGDataCollection As New CasparCGDataCollection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim aa As String = "file:///" + Application.StartupPath.Replace("\", "/") + "/cg20.fth.pal"
        'Console.WriteLine(aa)
        flashControl.Movie = "file:///" + "c:/casparcg/cg20.fth.pal"
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CasparCGDataCollection.SetData("f0", TextBox4.Text)
        CasparCGDataCollection.SetData("f1", "E.A. DDK Mumbai")
        Dim str = "<invoke name='Add' returntype='xml'><arguments><number>8</number><string>CMP/CG_TEMPLATE/TOP_LEFT.ft</string><true/><string></string><string><![CDATA[" + CasparCGDataCollection.ToXml + "]]></string></arguments></invoke>"
        Try
            Label1.Text = flashControl.CallFunction(str)
        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CasparCGDataCollection.SetData("f0", TextBox5.Text)
        CasparCGDataCollection.SetData("f1", "E.A. DDK Mumbai")
        Dim str = "<invoke name='SetData' returntype='xml'><arguments><array><property id='0'><number>8</number></property></array><string><![CDATA[" + CasparCGDataCollection.ToXml + "]]></string></arguments></invoke>"
        Try
            Label1.Text = flashControl.CallFunction(str)
        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim str = "<invoke name='Stop' returntype='xml'><arguments><array><property id='0'><number>8</number></property></array><number>0</number></arguments></invoke>"
        Try
            Label1.Text = flashControl.CallFunction(str)
        Catch ex As Exception
            Label1.Text = ex.ToString()
        End Try
    End Sub
End Class
