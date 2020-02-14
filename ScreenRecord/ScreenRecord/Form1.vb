Imports AForge.Video
Imports System.Threading
Imports AForge.Video.FFMPEG

Public Class Form1

#Region " Types "

    Public Enum BitRate
        _50kbit = 5000
        _100kbit = 10000
        _500kbit = 50000
        _1000kbit = 1000000
        _2000kbit = 2000000
        _3000kbit = 3000000
    End Enum

#End Region

#Region " Declare's "

    Private _isRecording As Boolean
    Private _screenNames As List(Of String)
    Private _frameCount As UInt32
    Private _writer As VideoFileWriter
    Private _width As Integer
    Private _height As Integer
    Private _streamVideo As ScreenCaptureStream
    Private _stopWatch As Stopwatch
    Private _screenArea As Rectangle

#End Region

#Region " Method's "

    Private Sub StartRec(ByVal path As String)
        If _isRecording = False Then
            Me.SetScreenArea()
            Me.SetVisible(True)
            Me._frameCount = 0
            Me.tb_SaveFolder.Text = path
            Dim fullName As String = String.Format("{0}\{1}_{2}.avi", path, Environment.UserName.ToUpper(), DateTime.Now.ToString("d_MMM_yyyy_HH_mm_ssff"))
            _writer.Open(fullName, Me._width, Me._height, CInt(nud_FPS.Value), CType(cb_VideoCodec.SelectedValue, VideoCodec), CInt(CType(Me.cb_BitRate.SelectedValue, BitRate)))
            Me.StartRecord()
        End If
    End Sub

    Private Sub SetScreenArea()
        Dim screenName As String = Me.cb_screenSelector.SelectedValue.ToString()

        If String.Compare(screenName, "Select ALL", StringComparison.OrdinalIgnoreCase) = 0 Then

            For Each screen As Screen In screen.AllScreens
                Me._screenArea = Rectangle.Union(_screenArea, screen.Bounds)
            Next
        Else
            Me._screenArea = Screen.AllScreens.First(Function(scr) scr.DeviceName.Equals(screenName)).Bounds
            Me._width = Me._screenArea.Width
            Me._height = Me._screenArea.Height
        End If
    End Sub

    Private Sub StartRecord()
        Me._streamVideo = New ScreenCaptureStream(Me._screenArea)
        AddHandler _streamVideo.NewFrame, New NewFrameEventHandler(AddressOf Me.video_NewFrame)
        Me._streamVideo.Start()
        Me._stopWatch.Start()
    End Sub

    Private Sub video_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        If Me._isRecording Then
            Me._frameCount += 1
            Me._writer.WriteVideoFrame(eventArgs.Frame)
            Me.lb_1.Invoke(New Action(Function()
                                          lb_1.Text = String.Format("Frames: {0}", _frameCount)
                                      End Function))
            Me.lb_stopWatch.Invoke(New Action(Function()
                                                  Me.lb_stopWatch.Text = _stopWatch.Elapsed.ToString()
                                              End Function))
        Else
            _stopWatch.Reset()
            Thread.Sleep(500)
            _streamVideo.SignalToStop()
            Thread.Sleep(500)
            _writer.Close()
        End If
    End Sub

    Private Sub SetVisible(ByVal visible As Boolean)
        Me.bt_start.Enabled = Not visible
        Me.bt_Save.Enabled = visible
        Me._isRecording = visible
    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me._isRecording = False
        Me._frameCount = 0

        Me._stopWatch = New Stopwatch()
        Me._screenArea = Rectangle.Empty
        bt_Save.Enabled = False
        Me._writer = New VideoFileWriter()
        _screenNames = New List(Of String)()
        _screenNames.Add("Select ALL")

        For Each screen In System.Windows.Forms.Screen.AllScreens
            _screenNames.Add(screen.DeviceName)
        Next

        Me.cb_screenSelector.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cb_screenSelector.DataSource = _screenNames
        Me.cb_VideoCodec.DataSource = [Enum].GetValues(GetType(VideoCodec))
        Me.cb_VideoCodec.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cb_BitRate.DataSource = [Enum].GetValues(GetType(BitRate))
        Me.cb_BitRate.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cb_BitRate.SelectedIndex = 3
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me._isRecording = False
    End Sub

    Private Sub bt_start_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_start.Click
        Try
            If Me.tb_SaveFolder.Text.Length < 1 Then
                Dim fbd As FolderBrowserDialog = New FolderBrowserDialog()

                If fbd.ShowDialog() = DialogResult.OK Then
                    Me.StartRec(fbd.SelectedPath)
                End If
            Else
                Me.StartRec(Me.tb_SaveFolder.Text)
            End If

        Catch exc As Exception
            MessageBox.Show(exc.Message)
        End Try
    End Sub

    Private Sub bt_Save_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bt_Save.Click
        Me.SetVisible(False)
        MessageBox.Show("File saved!")
    End Sub

End Class



