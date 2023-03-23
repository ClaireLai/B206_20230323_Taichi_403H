Public Class FormKeyBoard3
    Inherits System.Windows.Forms.Form
    Private MaxLimit As String
    Private MinLimit As String
    Private EnteredValue As String

    Property Max() As String
        Set(ByVal value As String)
            MaxLimit = value
            lblMax.Text = MaxLimit
        End Set
        Get
            MaxLimit = lblMax.Text
            Return MaxLimit
        End Get
    End Property

    Property Min() As String
        Set(ByVal value As String)
            MinLimit = value
            lblMin.Text = MinLimit
        End Set
        Get
            MinLimit = lblMin.Text
            Return MinLimit
        End Get
    End Property
    Property Value() As String
        Set(ByVal value As String)
            EnteredValue = value
            txtEnterValue.Text = EnteredValue
        End Set
        Get
            EnteredValue = txtEnterValue.Text
            Return EnteredValue
        End Get
    End Property
    Public Function KeyInString(ByRef Obj As Object, Optional ByVal sMax As String = "9999", Optional ByVal sMin As String = "-9999") As String
        Value = ""
        Max = sMax
        Min = sMin
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Obj.Text = Format(Val(EnteredValue), "0.0E+00")
        End If
        Return EnteredValue
    End Function
    'Public Function KeyInString(ByRef Obj As TextBox, Optional ByVal sMax As String = "9999", Optional ByVal sMin As String = "0") As String
    '    Value = ""
    '    Max = sMax
    '    Min = sMin
    '    Me.ShowDialog()
    '    If Me.DialogResult = Windows.Forms.DialogResult.OK Then
    '        Obj.Text = EnteredValue
    '    End If
    '    Return EnteredValue
    'End Function
    Public Function KeyInString(ByRef obj As DataGridView, ByVal col As Integer, ByVal row As Integer, Optional ByVal sMax As String = "9999", Optional ByVal sMin As String = "0") As String
        Value = ""
        Max = sMax
        Min = sMin
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            obj.Item(col, row).Value = Format(Val(EnteredValue), "0.0E+00")
        End If
        Return EnteredValue
    End Function
    Public Function KeyInString(ByRef obj As DataGridViewTextBoxCell, Optional ByVal sMax As String = "9999", Optional ByVal sMin As String = "0") As String
        Value = ""
        Max = sMax
        Min = sMin
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            obj.Value = Format(Val(EnteredValue), "0.0E+00")
        End If
        Return EnteredValue
    End Function
#Region " Windows Form 設計工具產生的程式碼 "

    Public Sub New()
        MyBase.New()

        '此呼叫為 Windows Form 設計工具的必要項。
        InitializeComponent()

        '在 InitializeComponent() 呼叫之後加入所有的初始設定

    End Sub

    'Form 覆寫 Dispose 以清除元件清單。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '您可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器來修改這些程序。
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtEnterValue As System.Windows.Forms.TextBox
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblMinText As System.Windows.Forms.Label
    Friend WithEvents lblMaxText As System.Windows.Forms.Label
    Friend WithEvents btnBackSpace As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKeyBoard3))
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtEnterValue = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBackSpace = New System.Windows.Forms.Button()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMinText = New System.Windows.Forms.Label()
        Me.lblMaxText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(89, 322)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(80, 48)
        Me.Button13.TabIndex = 73
        Me.Button13.Text = "E"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(175, 268)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(80, 48)
        Me.Button11.TabIndex = 72
        Me.Button11.Text = "-"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(89, 268)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 48)
        Me.Button10.TabIndex = 62
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(175, 214)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 48)
        Me.Button9.TabIndex = 71
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(89, 214)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 48)
        Me.Button8.TabIndex = 70
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(3, 214)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 48)
        Me.Button7.TabIndex = 69
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(175, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 48)
        Me.Button6.TabIndex = 68
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(89, 160)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 48)
        Me.Button5.TabIndex = 67
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(3, 160)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 48)
        Me.Button4.TabIndex = 66
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(175, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 48)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(89, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 48)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 48)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtEnterValue
        '
        Me.txtEnterValue.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterValue.Location = New System.Drawing.Point(3, 60)
        Me.txtEnterValue.Name = "txtEnterValue"
        Me.txtEnterValue.Size = New System.Drawing.Size(166, 39)
        Me.txtEnterValue.TabIndex = 75
        Me.txtEnterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(175, 322)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(80, 48)
        Me.btnEnter.TabIndex = 74
        Me.btnEnter.Text = "輸入"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(3, 268)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(80, 48)
        Me.Button14.TabIndex = 76
        Me.Button14.Text = "."
        Me.Button14.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(3, 322)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 48)
        Me.btnCancel.TabIndex = 77
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnBackSpace
        '
        Me.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackSpace.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackSpace.Location = New System.Drawing.Point(175, 60)
        Me.btnBackSpace.Name = "btnBackSpace"
        Me.btnBackSpace.Size = New System.Drawing.Size(80, 40)
        Me.btnBackSpace.TabIndex = 78
        Me.btnBackSpace.Text = "倒退鍵"
        Me.btnBackSpace.UseVisualStyleBackColor = False
        '
        'lblMax
        '
        Me.lblMax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMax.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.ForeColor = System.Drawing.Color.Red
        Me.lblMax.Location = New System.Drawing.Point(86, 4)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(166, 26)
        Me.lblMax.TabIndex = 80
        Me.lblMax.Text = "0"
        Me.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.Red
        Me.lblMin.Location = New System.Drawing.Point(86, 32)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(166, 26)
        Me.lblMin.TabIndex = 80
        Me.lblMin.Text = "0"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMinText
        '
        Me.lblMinText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinText.Location = New System.Drawing.Point(0, 32)
        Me.lblMinText.Name = "lblMinText"
        Me.lblMinText.Size = New System.Drawing.Size(80, 26)
        Me.lblMinText.TabIndex = 82
        Me.lblMinText.Text = "最小值:"
        Me.lblMinText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMaxText
        '
        Me.lblMaxText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxText.Location = New System.Drawing.Point(0, 4)
        Me.lblMaxText.Name = "lblMaxText"
        Me.lblMaxText.Size = New System.Drawing.Size(80, 26)
        Me.lblMaxText.TabIndex = 81
        Me.lblMaxText.Text = "最大值:"
        Me.lblMaxText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormKeyBoard3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(258, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMinText)
        Me.Controls.Add(Me.lblMaxText)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.btnBackSpace)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEnterValue)
        Me.Controls.Add(Me.btnEnter)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormKeyBoard3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeyBoard3"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub FormKeyBoard3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, _
    Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button13.Click, Button14.Click

        txtEnterValue.Text = txtEnterValue.Text + sender.text

    End Sub

    Private Sub btnBackSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackSpace.Click
        Dim a1 As Integer
        a1 = Len(txtEnterValue.Text)
        If a1 = 0 Or a1 = 1 Then
            txtEnterValue.Text = ""
            Exit Sub
        End If
        txtEnterValue.Text = Mid(txtEnterValue.Text, 1, a1 - 1)
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        On Error Resume Next
        EnteredValue = txtEnterValue.Text
        If EnteredValue = "" Then EnteredValue = "0"
        If Val(EnteredValue) < Val(MinLimit) Then
            EnteredValue = MinLimit
        End If
        If Val(EnteredValue) > Val(MaxLimit) Then
            EnteredValue = MaxLimit
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub


End Class
