Imports System.Drawing.Drawing2D
Imports System.IO

Module Module_FormReSize
    'Public ScreenW As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
    'Public ScreenH As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
    Public Sub SetControls(ByVal newx As Single, ByVal newy As Single, ByVal cons As Control, ByVal isLoaded As Boolean)
        If isLoaded Then

            For Each con As Control In cons.Controls
                Dim mytag As String() = con.Tag.ToString().Split(New Char() {":"c})
                Dim a As Single = System.Convert.ToSingle(mytag(0)) * newx
                con.Width = CInt(a)
                a = System.Convert.ToSingle(mytag(1)) * newy
                con.Height = CInt((a))
                a = System.Convert.ToSingle(mytag(2)) * newx
                con.Left = CInt((a))
                a = System.Convert.ToSingle(mytag(3)) * newy
                con.Top = CInt((a))
                Dim currentSize As Single = System.Convert.ToSingle(mytag(4)) * newy
                con.Font = New Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit)
                If con.Controls.Count > 0 Then
                    SetControls(newx, newy, con, isLoaded)
                End If
            Next
        End If
    End Sub
    ''' <summary>
    ''' 將控制項的寬，高，左邊距，頂邊距和字體大小暫存到tag屬性中
    ''' </summary>
    ''' <param name="cons">遞歸控制項中的控制項</param>
    Public Sub SetTag(ByVal cons As Control)
        For Each con As Control In cons.Controls
            con.Tag = con.Width.ToString & ":" + con.Height.ToString & ":" + con.Left.ToString & ":" + con.Top.ToString & ":" + con.Font.Size.ToString
            If con.Controls.Count > 0 Then SetTag(con)
        Next
    End Sub
    Public Function Resize_Image(ByVal imagetoresize As Image, ByVal size As Size) As Image
        Dim showW As Integer = size.Width
        Dim showH As Integer = size.Height
        Dim bmp As Bitmap = New Bitmap(showW, showH)
        'System.Drawing.Image
        'Dim g As Graphics = Graphics.FromImage((System.Drawing.Image)bmp)
        Dim g As Graphics = Graphics.FromImage((bmp))
        g.InterpolationMode = InterpolationMode.HighQualityBicubic

        g.DrawImage(imagetoresize, New System.Drawing.Rectangle(0, 0, showW, showH), New System.Drawing.Rectangle(0, 0, imagetoresize.Width, imagetoresize.Height), GraphicsUnit.Pixel)
        'Debug.Print("w=" + imagetoresize.Width.ToString + ", h=" + imagetoresize.Height.ToString)
        g.Dispose()
        'bmp.Save("D:\temp.png")
        Return (bmp)

    End Function
    Private Function Bitmap2Image(ByVal Bi As System.Drawing.Bitmap) As Image
        Dim Result As Image = Nothing
        Try

            Using ms As MemoryStream = New MemoryStream()
                Bi.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                Result = Image.FromStream(ms)
            End Using

        Catch __unusedException1__ As Exception
            Throw
        End Try

        Return Result
    End Function

End Module
