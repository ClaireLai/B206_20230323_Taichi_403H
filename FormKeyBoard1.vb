Public Class FormKeyBoard1
    Inherits System.Windows.Forms.Form
    Private MaxLimit As String
    Private MinLimit As String
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Private EnteredValue As String
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnSharp As System.Windows.Forms.Button
    Friend WithEvents btnPath2 As System.Windows.Forms.Button
    Friend WithEvents btnPath1 As System.Windows.Forms.Button
    Friend WithEvents btnPath3 As System.Windows.Forms.Button
    Friend WithEvents lblCurrentWaferID As System.Windows.Forms.Label
    Private CharIndex As Integer
    Property Cancel As Boolean = False 'Add by Vincent TCPIP 20200716 
    Private Sub txtEnterValue_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtEnterValue.MouseUp
        CharIndex = txtEnterValue.SelectionStart
    End Sub

    Private Sub txtEnterValue_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtEnterValue.MouseDown
        CharIndex = txtEnterValue.SelectionStart
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
    Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, _
    Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, _
    Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, _
    Button16.Click, Button17.Click, Button18.Click, Button19.Click, Button20.Click, _
    Button21.Click, Button22.Click, Button23.Click, Button24.Click, Button25.Click, _
    Button26.Click, Button27.Click, Button28.Click, Button29.Click, Button30.Click, _
    Button31.Click, Button32.Click, Button33.Click, Button34.Click, Button35.Click, _
    Button36.Click, btnDash.Click, btnSpace.Click, btnUnderLine.Click, btnDot.Click, btnSharp.Click, _
    btnPath1.Click, btnPath2.Click, btnPath3.Click
        Dim Str As String
        If sender.Name = "btnSpace" Then
            Str = " "
        Else
            Str = sender.Text
        End If
        If CharIndex >= txtEnterValue.TextLength Then
            txtEnterValue.Text = txtEnterValue.Text + Str
            CharIndex = txtEnterValue.TextLength
        Else
            txtEnterValue.Text = txtEnterValue.Text.Insert(CharIndex, Str)
            CharIndex = CharIndex + Str.Length
        End If
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If CharIndex < txtEnterValue.TextLength And txtEnterValue.TextLength > 0 Then
            txtEnterValue.Text = txtEnterValue.Text.Remove(CharIndex, 1)
        End If
    End Sub

    Private Sub btnBackSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackSpace.Click
        Dim a1 As Integer
        If Len(txtEnterValue.Text) = 0 Then Exit Sub
        If CharIndex > 0 Then
            CharIndex -= 1
            txtEnterValue.Text = txtEnterValue.Text.Remove(CharIndex, 1)
        End If
        'a1 = Len(txtEnterValue.Text)
        'If a1 = 0 Or a1 = 1 Then
        '    txtEnterValue.Text = ""
        '    Exit Sub
        'End If
        'txtEnterValue.Text = Mid(txtEnterValue.Text, 1, a1 - 1)
    End Sub

    Property Max() As String
        Set(ByVal value As String)
            MaxLimit = value
            'lblMax.Text = MaxLimit
        End Set
        Get
            'MaxLimit = lblMax.Text
            Return MaxLimit
        End Get
    End Property

    Property Min() As String
        Set(ByVal value As String)
            MinLimit = value
            'lblMin.Text = MinLimit
        End Set
        Get
            'MinLimit = lblMin.Text
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

    Public Function KeyInString(ByRef Obj As Label, Optional ByVal Clear As Boolean = True) As String
        If Clear Then Value = ""
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Obj.Text = EnteredValue
        End If
        Return EnteredValue
    End Function
    Public Function KeyInString(ByRef Obj As TextBox, Optional ByVal Clear As Boolean = True) As String
        If Clear Then Value = ""
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Obj.Text = EnteredValue
        End If
        Return EnteredValue
    End Function
    Public Function KeyInString(ByRef obj As DataGridView, ByVal col As Integer, ByVal row As Integer, Optional ByVal Clear As Boolean = True) As String
        txtEnterValue.Text = obj.Item(col, row).Value
        If Clear Then txtEnterValue.Text = ""
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            obj.Item(col, row).Value = EnteredValue
        End If
        Return EnteredValue
    End Function
    'Add by Vincent TCPIP 20200716    ------------- Start
    Public Function KeyInPairWafer(ByVal wid As String, ByRef obj As DataGridView, ByVal col As Integer, ByVal row As Integer, Optional ByVal Clear As Boolean = True) As String
        txtEnterValue.Text = obj.Item(col, row).Value
        lblCurrentWaferID.Text = wid
        lblCurrentWaferID.Visible = True
        If Clear Then txtEnterValue.Text = ""
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            obj.Item(col, row).Value = EnteredValue
        Else
            Cancel = True
        End If
        lblCurrentWaferID.Visible = False
        Return EnteredValue
    End Function
    'Add by Vincent TCPIP 20200716    ------------- End
#Region "SanAn CIM Function 20190710"
    'Add By Vincent 20190710  ----------------------------------------------------------  Start
    Public Function KeyInDir(ByRef Obj As TextBox) As String
        Value = Obj.Text
        btnPath1.Visible = True
        btnPath2.Visible = True
        btnPath3.Visible = True
        Me.ShowDialog()
        If Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Obj.Text = EnteredValue
        End If
        btnPath1.Visible = False
        btnPath2.Visible = False
        btnPath3.Visible = False
        Return EnteredValue
    End Function
    'Add By Vincent 20190710  ----------------------------------------------------------  end
#End Region
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
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
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
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDash As System.Windows.Forms.Button
    Friend WithEvents btnUnderLine As System.Windows.Forms.Button
    Friend WithEvents btnSpace As System.Windows.Forms.Button
    Friend WithEvents btnDot As System.Windows.Forms.Button
    Friend WithEvents btnCapsLock As System.Windows.Forms.Button
    Friend WithEvents btnBackSpace As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormKeyBoard1))
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBackSpace = New System.Windows.Forms.Button()
        Me.btnDash = New System.Windows.Forms.Button()
        Me.btnUnderLine = New System.Windows.Forms.Button()
        Me.btnSpace = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnCapsLock = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnSharp = New System.Windows.Forms.Button()
        Me.btnPath2 = New System.Windows.Forms.Button()
        Me.btnPath1 = New System.Windows.Forms.Button()
        Me.btnPath3 = New System.Windows.Forms.Button()
        Me.lblCurrentWaferID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(472, 303)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(196, 48)
        Me.btnEnter.TabIndex = 74
        Me.btnEnter.Text = "輸入"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button36.Location = New System.Drawing.Point(10, 253)
        Me.Button36.Margin = New System.Windows.Forms.Padding(1)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(64, 48)
        Me.Button36.TabIndex = 73
        Me.Button36.Text = "Z"
        Me.Button36.UseVisualStyleBackColor = False
        '
        'Button35
        '
        Me.Button35.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button35.Location = New System.Drawing.Point(340, 153)
        Me.Button35.Margin = New System.Windows.Forms.Padding(1)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(64, 48)
        Me.Button35.TabIndex = 72
        Me.Button35.Text = "Y"
        Me.Button35.UseVisualStyleBackColor = False
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.Location = New System.Drawing.Point(76, 253)
        Me.Button34.Margin = New System.Windows.Forms.Padding(1)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(64, 48)
        Me.Button34.TabIndex = 71
        Me.Button34.Text = "X"
        Me.Button34.UseVisualStyleBackColor = False
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.Location = New System.Drawing.Point(76, 153)
        Me.Button33.Margin = New System.Windows.Forms.Padding(1)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(64, 48)
        Me.Button33.TabIndex = 70
        Me.Button33.Text = "W"
        Me.Button33.UseVisualStyleBackColor = False
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.Location = New System.Drawing.Point(208, 253)
        Me.Button32.Margin = New System.Windows.Forms.Padding(1)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(64, 48)
        Me.Button32.TabIndex = 69
        Me.Button32.Text = "V"
        Me.Button32.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.Location = New System.Drawing.Point(406, 153)
        Me.Button31.Margin = New System.Windows.Forms.Padding(1)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(64, 48)
        Me.Button31.TabIndex = 68
        Me.Button31.Text = "U"
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.Location = New System.Drawing.Point(274, 153)
        Me.Button30.Margin = New System.Windows.Forms.Padding(1)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(64, 48)
        Me.Button30.TabIndex = 67
        Me.Button30.Text = "T"
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.Location = New System.Drawing.Point(76, 203)
        Me.Button29.Margin = New System.Windows.Forms.Padding(1)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(64, 48)
        Me.Button29.TabIndex = 66
        Me.Button29.Text = "S"
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.Location = New System.Drawing.Point(208, 153)
        Me.Button28.Margin = New System.Windows.Forms.Padding(1)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(64, 48)
        Me.Button28.TabIndex = 65
        Me.Button28.Text = "R"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.Location = New System.Drawing.Point(10, 153)
        Me.Button27.Margin = New System.Windows.Forms.Padding(1)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(64, 48)
        Me.Button27.TabIndex = 64
        Me.Button27.Text = "Q"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.Location = New System.Drawing.Point(604, 153)
        Me.Button26.Margin = New System.Windows.Forms.Padding(1)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(64, 48)
        Me.Button26.TabIndex = 63
        Me.Button26.Text = "P"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.Location = New System.Drawing.Point(538, 153)
        Me.Button25.Margin = New System.Windows.Forms.Padding(1)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(64, 48)
        Me.Button25.TabIndex = 62
        Me.Button25.Text = "O"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.Location = New System.Drawing.Point(340, 253)
        Me.Button24.Margin = New System.Windows.Forms.Padding(1)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(64, 48)
        Me.Button24.TabIndex = 61
        Me.Button24.Text = "N"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(406, 253)
        Me.Button23.Margin = New System.Windows.Forms.Padding(1)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(64, 48)
        Me.Button23.TabIndex = 60
        Me.Button23.Text = "M"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(538, 203)
        Me.Button22.Margin = New System.Windows.Forms.Padding(1)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(64, 48)
        Me.Button22.TabIndex = 59
        Me.Button22.Text = "L"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(472, 203)
        Me.Button21.Margin = New System.Windows.Forms.Padding(1)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(64, 48)
        Me.Button21.TabIndex = 58
        Me.Button21.Text = "K"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(406, 203)
        Me.Button20.Margin = New System.Windows.Forms.Padding(1)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(64, 48)
        Me.Button20.TabIndex = 57
        Me.Button20.Text = "J"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(472, 153)
        Me.Button19.Margin = New System.Windows.Forms.Padding(1)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(64, 48)
        Me.Button19.TabIndex = 56
        Me.Button19.Text = "I"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(340, 203)
        Me.Button18.Margin = New System.Windows.Forms.Padding(1)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(64, 48)
        Me.Button18.TabIndex = 55
        Me.Button18.Text = "H"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(274, 203)
        Me.Button17.Margin = New System.Windows.Forms.Padding(1)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(64, 48)
        Me.Button17.TabIndex = 54
        Me.Button17.Text = "G"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(208, 203)
        Me.Button16.Margin = New System.Windows.Forms.Padding(1)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(64, 48)
        Me.Button16.TabIndex = 53
        Me.Button16.Text = "F"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(142, 153)
        Me.Button15.Margin = New System.Windows.Forms.Padding(1)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(64, 48)
        Me.Button15.TabIndex = 52
        Me.Button15.Text = "E"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(142, 203)
        Me.Button14.Margin = New System.Windows.Forms.Padding(1)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(64, 48)
        Me.Button14.TabIndex = 51
        Me.Button14.Text = "D"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(142, 253)
        Me.Button13.Margin = New System.Windows.Forms.Padding(1)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(64, 48)
        Me.Button13.TabIndex = 50
        Me.Button13.Text = "C"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(274, 253)
        Me.Button12.Margin = New System.Windows.Forms.Padding(1)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(64, 48)
        Me.Button12.TabIndex = 49
        Me.Button12.Text = "B"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(10, 203)
        Me.Button11.Margin = New System.Windows.Forms.Padding(1)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(64, 48)
        Me.Button11.TabIndex = 48
        Me.Button11.Text = "A"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(538, 103)
        Me.Button10.Margin = New System.Windows.Forms.Padding(1)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(64, 48)
        Me.Button10.TabIndex = 47
        Me.Button10.Text = "9"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(472, 103)
        Me.Button9.Margin = New System.Windows.Forms.Padding(1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(64, 48)
        Me.Button9.TabIndex = 46
        Me.Button9.Text = "8"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(406, 103)
        Me.Button8.Margin = New System.Windows.Forms.Padding(1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(64, 48)
        Me.Button8.TabIndex = 45
        Me.Button8.Text = "7"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(340, 103)
        Me.Button7.Margin = New System.Windows.Forms.Padding(1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(64, 48)
        Me.Button7.TabIndex = 44
        Me.Button7.Text = "6"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(274, 103)
        Me.Button6.Margin = New System.Windows.Forms.Padding(1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 48)
        Me.Button6.TabIndex = 43
        Me.Button6.Text = "5"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(208, 103)
        Me.Button5.Margin = New System.Windows.Forms.Padding(1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 48)
        Me.Button5.TabIndex = 42
        Me.Button5.Text = "4"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(142, 103)
        Me.Button4.Margin = New System.Windows.Forms.Padding(1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 48)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "3"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(76, 103)
        Me.Button3.Margin = New System.Windows.Forms.Padding(1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 48)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "2"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(10, 103)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 48)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "1"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(604, 103)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 48)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "0"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtEnterValue
        '
        Me.txtEnterValue.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterValue.Location = New System.Drawing.Point(12, 7)
        Me.txtEnterValue.Name = "txtEnterValue"
        Me.txtEnterValue.Size = New System.Drawing.Size(656, 39)
        Me.txtEnterValue.TabIndex = 75
        Me.txtEnterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(10, 303)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(130, 48)
        Me.btnCancel.TabIndex = 76
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnBackSpace
        '
        Me.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackSpace.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackSpace.Location = New System.Drawing.Point(538, 52)
        Me.btnBackSpace.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBackSpace.Name = "btnBackSpace"
        Me.btnBackSpace.Size = New System.Drawing.Size(130, 48)
        Me.btnBackSpace.TabIndex = 77
        Me.btnBackSpace.Text = "倒退鍵"
        Me.btnBackSpace.UseVisualStyleBackColor = False
        '
        'btnDash
        '
        Me.btnDash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDash.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.btnDash.Location = New System.Drawing.Point(472, 253)
        Me.btnDash.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDash.Name = "btnDash"
        Me.btnDash.Size = New System.Drawing.Size(64, 48)
        Me.btnDash.TabIndex = 81
        Me.btnDash.Text = "-"
        Me.btnDash.UseVisualStyleBackColor = False
        '
        'btnUnderLine
        '
        Me.btnUnderLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUnderLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnderLine.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.btnUnderLine.Location = New System.Drawing.Point(604, 203)
        Me.btnUnderLine.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUnderLine.Name = "btnUnderLine"
        Me.btnUnderLine.Size = New System.Drawing.Size(64, 48)
        Me.btnUnderLine.TabIndex = 80
        Me.btnUnderLine.Text = "_"
        Me.btnUnderLine.UseVisualStyleBackColor = False
        '
        'btnSpace
        '
        Me.btnSpace.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpace.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpace.Location = New System.Drawing.Point(208, 303)
        Me.btnSpace.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSpace.Name = "btnSpace"
        Me.btnSpace.Size = New System.Drawing.Size(196, 48)
        Me.btnSpace.TabIndex = 79
        Me.btnSpace.Text = "空白鍵"
        Me.btnSpace.UseVisualStyleBackColor = False
        '
        'btnDot
        '
        Me.btnDot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDot.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.btnDot.Location = New System.Drawing.Point(538, 253)
        Me.btnDot.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(64, 48)
        Me.btnDot.TabIndex = 82
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = False
        '
        'btnCapsLock
        '
        Me.btnCapsLock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCapsLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCapsLock.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapsLock.Location = New System.Drawing.Point(208, 53)
        Me.btnCapsLock.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCapsLock.Name = "btnCapsLock"
        Me.btnCapsLock.Size = New System.Drawing.Size(130, 48)
        Me.btnCapsLock.TabIndex = 78
        Me.btnCapsLock.Text = "A/a"
        Me.btnCapsLock.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(10, 52)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(1)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 48)
        Me.btnClear.TabIndex = 83
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(340, 52)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(130, 48)
        Me.btnDel.TabIndex = 84
        Me.btnDel.Text = "Del"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnSharp
        '
        Me.btnSharp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSharp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSharp.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.btnSharp.Location = New System.Drawing.Point(604, 253)
        Me.btnSharp.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSharp.Name = "btnSharp"
        Me.btnSharp.Size = New System.Drawing.Size(64, 48)
        Me.btnSharp.TabIndex = 85
        Me.btnSharp.Text = "#"
        Me.btnSharp.UseVisualStyleBackColor = False
        '
        'btnPath2
        '
        Me.btnPath2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPath2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPath2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath2.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPath2.Location = New System.Drawing.Point(142, 53)
        Me.btnPath2.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPath2.Name = "btnPath2"
        Me.btnPath2.Size = New System.Drawing.Size(64, 48)
        Me.btnPath2.TabIndex = 96
        Me.btnPath2.Text = "\"
        Me.btnPath2.UseVisualStyleBackColor = False
        Me.btnPath2.Visible = False
        '
        'btnPath1
        '
        Me.btnPath1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPath1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPath1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPath1.Location = New System.Drawing.Point(76, 53)
        Me.btnPath1.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPath1.Name = "btnPath1"
        Me.btnPath1.Size = New System.Drawing.Size(64, 48)
        Me.btnPath1.TabIndex = 95
        Me.btnPath1.Text = ":"
        Me.btnPath1.UseVisualStyleBackColor = False
        Me.btnPath1.Visible = False
        '
        'btnPath3
        '
        Me.btnPath3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPath3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPath3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPath3.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPath3.Location = New System.Drawing.Point(472, 52)
        Me.btnPath3.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPath3.Name = "btnPath3"
        Me.btnPath3.Size = New System.Drawing.Size(64, 48)
        Me.btnPath3.TabIndex = 97
        Me.btnPath3.Text = "/"
        Me.btnPath3.UseVisualStyleBackColor = False
        Me.btnPath3.Visible = False
        '
        'lblCurrentWaferID
        '
        Me.lblCurrentWaferID.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCurrentWaferID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCurrentWaferID.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblCurrentWaferID.Location = New System.Drawing.Point(10, 7)
        Me.lblCurrentWaferID.Name = "lblCurrentWaferID"
        Me.lblCurrentWaferID.Size = New System.Drawing.Size(262, 39)
        Me.lblCurrentWaferID.TabIndex = 755
        Me.lblCurrentWaferID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCurrentWaferID.Visible = False
        '
        'FormKeyBoard1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(674, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCurrentWaferID)
        Me.Controls.Add(Me.btnPath3)
        Me.Controls.Add(Me.btnPath2)
        Me.Controls.Add(Me.btnPath1)
        Me.Controls.Add(Me.btnSharp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCapsLock)
        Me.Controls.Add(Me.btnBackSpace)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtEnterValue)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Button36)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.Button33)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btnSpace)
        Me.Controls.Add(Me.btnUnderLine)
        Me.Controls.Add(Me.btnDash)
        Me.Controls.Add(Me.Button30)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
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
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormKeyBoard1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KeyBoard1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    '大小寫旗標,  CapsLock=FALSE 為大寫
    Dim CapsLock As Boolean
    Private Sub Keyboard1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CapsLock = False
        For Each cc As Object In Me.Controls
            If cc.tabindex >= 48 And cc.tabindex <= 73 Then
                ChangeCaps(CapsLock, cc)
                If CapsLock Then
                    cc.BackColor = Color.SkyBlue
                Else
                    cc.BackColor = Color.FromArgb(192, 255, 192)
                End If
            End If
        Next
        If CapsLock Then
            btnCapsLock.BackColor = Color.SkyBlue
        Else
            btnCapsLock.BackColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub



    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        EnteredValue = txtEnterValue.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Cancel = False
        'Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'cancel
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Cancel = True
        'Me.Close()

    End Sub



    Private Sub btnCapsLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapsLock.Click
        CapsLock = Not CapsLock

        For Each cc As Object In Me.Controls
            If cc.TabIndex >= 48 And cc.TabIndex <= 73 Then
                ChangeCaps(CapsLock, cc)
                If CapsLock Then
                    'cc.BackgroundImage = My.Resources.ButtonG
                    cc.BackColor = Color.SkyBlue
                Else
                    'cc.BackgroundImage = My.Resources.ButtonB
                    cc.BackColor = Color.FromArgb(192, 255, 192)
                End If
            End If
        Next
        If CapsLock Then
            btnCapsLock.BackColor = Color.SkyBlue
            'btnCapsLock.BackgroundImage = My.Resources.ButtonLO
        Else
            'btnCapsLock.BackgroundImage = My.Resources.ButtonB
            btnCapsLock.BackColor = Color.FromArgb(192, 255, 192)
        End If
    End Sub

    Public Sub ChangeCaps(ByVal caps As Boolean, ByRef obj As Button)
        If CapsLock Then
            obj.Text = obj.Text.ToLower()
        Else
            obj.Text = obj.Text.ToUpper()
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtEnterValue.Clear()
    End Sub


End Class
