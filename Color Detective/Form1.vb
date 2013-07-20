Public Class MainWindow

    Public Function LoadFile()
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) = True Then
                ' Load the file
                Dim LoadedFile As String
                LoadedFile = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                Dim ColorList() As String = Split(LoadedFile, "|")
                Dim AskResult As MsgBoxResult
                If ListBox1.Items.Count <> 0 Then
                    AskResult = MsgBox("The color history is not empty. Select ""Yes"" to append the loaded file or ""No"" to clear the history and then load the file.", MsgBoxStyle.YesNoCancel, "Confirmation")
                    If AskResult = MsgBoxResult.Yes Then
                        ListBox1.Items.Clear()
                    ElseIf AskResult = MsgBoxResult.Cancel Then
                        Exit Function
                    End If
                End If
                For Each item As String In ColorList
                    If item <> "" Then
                        ListBox1.Items.Add(item)
                    End If
                Next
            End If
        End If
    End Function

    Public Function SaveFile()
        SaveFileDialog1.ShowDialog()
        Dim Contents As String = ""
        If SaveFileDialog1.FileName <> "" Then
            For Each item As String In ListBox1.Items
                Contents = Contents + item + "|"
            Next
            Dim LengthFile As Integer = Contents.Length
            Contents = Replace(StrReverse(Contents), "|", "", 1, 1)
            Contents = StrReverse(Contents)
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, Contents, False)
            MsgBox("Color history saved.", MsgBoxStyle.Information, "Success")
        End If
        Exit Function
    End Function

    Private Sub MainWindow_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            ListBox1.Items.Add(TextBox1.Text)
            ListBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BgTimer.Start()
        Dim FileNameCDB As String = TimeOfDay()
        ColorTimer.Start()
    End Sub

    Private Sub ColorTimer_Tick(sender As Object, e As EventArgs) Handles ColorTimer.Tick
        Dim a As New Drawing.Bitmap(1, 1)
        Dim b As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(a)

        b.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y), New Drawing.Point(0, 0), a.Size)

        Dim c As Drawing.Color = a.GetPixel(0, 0)
        Dim ColorName As String

        PictureBox1.BackColor = c
        ColorName = PictureBox1.BackColor.Name
        ColorName = StrConv(ColorName, VbStrConv.Uppercase)
        ColorName = Replace(ColorName, "FF", "", 1, 1)
        ColorName = "#" & ColorName

        TextBox1.Text = ColorName
    End Sub

    Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Dim ColorNameFriend As String = ListBox1.SelectedItem
        Dim ColorReal As Color
        ColorReal = System.Drawing.ColorTranslator.FromHtml(ColorNameFriend)
        PictureBox1.BackColor = ColorReal
        If ColorNameFriend <> "" Then
            My.Computer.Clipboard.SetText(ColorNameFriend)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
    End Sub

    Private Sub ListBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseClick
        ' Stop the timer
        ColorTimer.Stop()
        Panel1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = False
        ColorTimer.Start()
        TextBox1.Focus()
    End Sub

    Private Sub SaveHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveHistoryToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub LoadHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadHistoryToolStripMenuItem.Click
        LoadFile()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub LoadColorDetectiveHistoryFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadColorDetectiveHistoryFileToolStripMenuItem.Click
        LoadFile()
    End Sub

    Private Sub SaveHistoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveHistoryToolStripMenuItem1.Click
        SaveFile()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub DeleteItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem.Click
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub BgTimer_Tick(sender As Object, e As EventArgs) Handles BgTimer.Tick
        ' Enable/Disable the Delete Context Menu Item
        If ListBox1.SelectedIndex >= 0 Then
            DeleteItemToolStripMenuItem.Enabled = True
        Else
            DeleteItemToolStripMenuItem.Enabled = False
        End If
    End Sub

End Class
