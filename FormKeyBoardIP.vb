Imports System.Text.RegularExpressions
Public Class FormKeyBoardIP
    Inherits System.Windows.Forms.Form

    Private EnteredValue As String

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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnBackSpace As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKeyBoardIP))
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBackSpace = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(101, 209)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(80, 48)
        Me.Button10.TabIndex = 59
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(187, 155)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(80, 48)
        Me.Button9.TabIndex = 58
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(101, 155)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(80, 48)
        Me.Button8.TabIndex = 57
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(15, 155)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 48)
        Me.Button7.TabIndex = 56
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(187, 101)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 48)
        Me.Button6.TabIndex = 55
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(101, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 48)
        Me.Button5.TabIndex = 54
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(15, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 48)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(187, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 48)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(101, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 48)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 48)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtEnterValue
        '
        Me.txtEnterValue.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterValue.Location = New System.Drawing.Point(15, 2)
        Me.txtEnterValue.Name = "txtEnterValue"
        Me.txtEnterValue.Size = New System.Drawing.Size(252, 39)
        Me.txtEnterValue.TabIndex = 61
        Me.txtEnterValue.Text = "255.255.255.255"
        Me.txtEnterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.btnEnter.Location = New System.Drawing.Point(187, 261)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(80, 48)
        Me.btnEnter.TabIndex = 60
        Me.btnEnter.Text = "輸入"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(12, 262)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 48)
        Me.btnCancel.TabIndex = 66
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnBackSpace
        '
        Me.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackSpace.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackSpace.Location = New System.Drawing.Point(101, 261)
        Me.btnBackSpace.Name = "btnBackSpace"
        Me.btnBackSpace.Size = New System.Drawing.Size(80, 48)
        Me.btnBackSpace.TabIndex = 67
        Me.btnBackSpace.Text = "倒退鍵"
        Me.btnBackSpace.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(187, 208)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(80, 48)
        Me.Button14.TabIndex = 68
        Me.Button14.Text = "."
        Me.Button14.UseVisualStyleBackColor = False
        '
        'FormKeyBoardIP
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(279, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.btnBackSpace)
        Me.Controls.Add(Me.btnCancel)
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
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormKeyBoardIP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeyBoardIP"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub KeyBoard2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Function KeyInIP(ByRef Obj As TextBox) As String
        On Error Resume Next
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Obj.Text = EnteredValue
        End If
        Return EnteredValue
    End Function
    Private Sub txtEnterValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnterValue.TextChanged
        Static oldText As String = ""
        If Not New Regex("^(\d{1,3}\.)?(\d{1,3}\.)?(\d{1,3}\.)?(\d{1,3})?$").IsMatch(txtEnterValue.Text) Then txtEnterValue.Text = oldText
        oldText = txtEnterValue.Text
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click _
         , Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click _
         , Button8.Click, Button9.Click, Button10.Click, Button14.Click
        Static oldText As String = ""
        txtEnterValue.Text = txtEnterValue.Text + sender.text
        'If Not New Regex("^(\d{1,3}\.)?(\d{1,3}\.)?(\d{1,3}\.)?(\d{1,3})?$").IsMatch(txtEnterValue.Text) Then txtEnterValue.Text = oldText
        'oldText = txtEnterValue.Text
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
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

End Class

