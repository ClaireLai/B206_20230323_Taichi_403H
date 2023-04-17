Public Class FormRecipe
    Inherits System.Windows.Forms.Form
    Public StepTime(Recipe_Max) As Integer
    Public TotalStepTime As Integer
    Public RecipePage As Integer
    Dim rwstepindex As Integer
    Private X As Single '當前窗體的寬度
    Private Y As Single '當前窗體的高度
    Private isLoaded As Boolean '// 是否已設定各控制的尺寸資料到Tag屬性
    Private FormW As Integer
    Private FormH As Integer

#Region " Windows Form 設計工具產生的程式碼 "
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnDelStep As System.Windows.Forms.Button
    Friend WithEvents chkKeyBoard As System.Windows.Forms.CheckBox
    Friend WithEvents lblStepTotalTime As System.Windows.Forms.Label
    Friend WithEvents lblPreSetTimeText As System.Windows.Forms.Label
    Friend WithEvents lblRecipeNoteText As System.Windows.Forms.Label
    Friend WithEvents txtRecipeNote As System.Windows.Forms.TextBox
    Friend WithEvents lblRecipeStep As System.Windows.Forms.Label
    Friend WithEvents lblRecipeFileName As System.Windows.Forms.Label
    Friend WithEvents txtDest As System.Windows.Forms.TextBox
    Friend WithEvents btnCopyTo As System.Windows.Forms.Button
    Friend WithEvents chkBondBeforeVacuum As System.Windows.Forms.CheckBox
    Friend WithEvents chkVacuumPurge As System.Windows.Forms.CheckBox
    Friend WithEvents chkKeepBonding As System.Windows.Forms.CheckBox
    Friend WithEvents chkVacuumMode As System.Windows.Forms.CheckBox
    Friend WithEvents lblRecipeName As System.Windows.Forms.Label
    Friend WithEvents lblIn01Text As System.Windows.Forms.Label
    Friend WithEvents grpProcessCondition As System.Windows.Forms.GroupBox
    Friend WithEvents radPress As System.Windows.Forms.RadioButton
    Friend WithEvents radTemp As System.Windows.Forms.RadioButton
    Friend WithEvents radBoth As System.Windows.Forms.RadioButton
    Friend WithEvents chkAutoVent As System.Windows.Forms.CheckBox
    Friend WithEvents grpProcessOption As System.Windows.Forms.GroupBox
    Friend WithEvents dgRecipeEdit As System.Windows.Forms.DataGridView
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnCopyToAll As System.Windows.Forms.Button
    Friend WithEvents lblTotalTime1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTime2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTime3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTime6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTime5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTime4 As System.Windows.Forms.Label
    Friend WithEvents lblStepText As System.Windows.Forms.Label
    Friend WithEvents lblSiteTime01Text As System.Windows.Forms.Label
    Friend WithEvents lblSiteTime02Text As System.Windows.Forms.Label
    Friend WithEvents lblSiteTime03Text As System.Windows.Forms.Label
    Friend WithEvents lblSiteTime04Text As System.Windows.Forms.Label
    Friend WithEvents lblSiteTime05Text As System.Windows.Forms.Label
    Friend WithEvents lblSiteTime06Text As System.Windows.Forms.Label
    Friend WithEvents lblMFCOffTime01Text As System.Windows.Forms.Label
    Friend WithEvents txtMFCOffTime01 As System.Windows.Forms.TextBox
    Friend WithEvents lblMFCOnTime01Text As System.Windows.Forms.Label
    Friend WithEvents txtMFCOnTime01 As System.Windows.Forms.TextBox
    Friend WithEvents grpMFC01 As System.Windows.Forms.GroupBox
    Friend WithEvents grpMFC02 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMFCOffTime02Text As System.Windows.Forms.Label
    Friend WithEvents lblMFCOnTime02Text As System.Windows.Forms.Label
    Friend WithEvents txtMFCOffTime02 As System.Windows.Forms.TextBox
    Friend WithEvents txtMFCOnTime02 As System.Windows.Forms.TextBox
    Friend WithEvents lblArrow01Text As System.Windows.Forms.Label
    Friend WithEvents lblMFC01FlowText As System.Windows.Forms.Label
    Friend WithEvents txtMFC01Flow As System.Windows.Forms.TextBox
    Friend WithEvents lblMFC02FlowText As System.Windows.Forms.Label
    Friend WithEvents txtMFC02Flow As System.Windows.Forms.TextBox
    Friend WithEvents chkAfterPurge As System.Windows.Forms.CheckBox
    Friend WithEvents pnl6Site As System.Windows.Forms.Panel
    Friend WithEvents chkAutoDoorOpen As System.Windows.Forms.CheckBox
    Friend WithEvents chkPurgeKeepBonding As System.Windows.Forms.CheckBox
    Friend WithEvents lblPurgeOffText As System.Windows.Forms.Label
    Friend WithEvents txtPurgeOFFTime As System.Windows.Forms.TextBox
    Friend WithEvents lblPurgeOnText As System.Windows.Forms.Label
    Friend WithEvents txtPurgeONTime As System.Windows.Forms.TextBox
    Friend WithEvents picC01 As System.Windows.Forms.PictureBox
    Friend WithEvents lblAfterPurgeTemp As System.Windows.Forms.Label
    Friend WithEvents txtAfterPurgeTemp As System.Windows.Forms.TextBox
    Friend WithEvents chkPurgeCooling As System.Windows.Forms.CheckBox
    Friend WithEvents TabControlOption As System.Windows.Forms.TabControl
    Friend WithEvents TabPageOption As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMFC01 As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePurge As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMFC02 As System.Windows.Forms.TabPage
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Public Sub New()
        MyBase.New()

        '此呼叫為 Windows Form 設計工具的必要項。
        InitializeComponent()
        isLoaded = False
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
    Friend WithEvents btnLoadRecipe As System.Windows.Forms.Button
    Friend WithEvents btnSaveRecipe As System.Windows.Forms.Button
    Friend WithEvents lblRecipeBasePressureText As System.Windows.Forms.Label
    Friend WithEvents txtRecipeBasePressure As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblUnit As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblWaferSizeText As System.Windows.Forms.Label
    Friend WithEvents txtWaferSize As System.Windows.Forms.TextBox
    Friend WithEvents btnAddStep As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecipe))
        Me.btnLoadRecipe = New System.Windows.Forms.Button()
        Me.btnSaveRecipe = New System.Windows.Forms.Button()
        Me.lblRecipeBasePressureText = New System.Windows.Forms.Label()
        Me.txtRecipeBasePressure = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtRecipeNote = New System.Windows.Forms.TextBox()
        Me.chkKeyBoard = New System.Windows.Forms.CheckBox()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.btnCopyTo = New System.Windows.Forms.Button()
        Me.txtDest = New System.Windows.Forms.TextBox()
        Me.chkAutoVent = New System.Windows.Forms.CheckBox()
        Me.grpProcessCondition = New System.Windows.Forms.GroupBox()
        Me.radPress = New System.Windows.Forms.RadioButton()
        Me.radTemp = New System.Windows.Forms.RadioButton()
        Me.radBoth = New System.Windows.Forms.RadioButton()
        Me.lblIn01Text = New System.Windows.Forms.Label()
        Me.chkVacuumMode = New System.Windows.Forms.CheckBox()
        Me.chkBondBeforeVacuum = New System.Windows.Forms.CheckBox()
        Me.chkVacuumPurge = New System.Windows.Forms.CheckBox()
        Me.chkKeepBonding = New System.Windows.Forms.CheckBox()
        Me.lblRecipeName = New System.Windows.Forms.Label()
        Me.lblRecipeNoteText = New System.Windows.Forms.Label()
        Me.lblRecipeFileName = New System.Windows.Forms.Label()
        Me.lblWaferSizeText = New System.Windows.Forms.Label()
        Me.txtWaferSize = New System.Windows.Forms.TextBox()
        Me.lblPreSetTimeText = New System.Windows.Forms.Label()
        Me.lblStepTotalTime = New System.Windows.Forms.Label()
        Me.lblRecipeStep = New System.Windows.Forms.Label()
        Me.btnAddStep = New System.Windows.Forms.Button()
        Me.btnDelStep = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.grpProcessOption = New System.Windows.Forms.GroupBox()
        Me.chkAutoDoorOpen = New System.Windows.Forms.CheckBox()
        Me.chkAfterPurge = New System.Windows.Forms.CheckBox()
        Me.dgRecipeEdit = New System.Windows.Forms.DataGridView()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCopyToAll = New System.Windows.Forms.Button()
        Me.lblTotalTime1 = New System.Windows.Forms.Label()
        Me.lblTotalTime2 = New System.Windows.Forms.Label()
        Me.lblTotalTime3 = New System.Windows.Forms.Label()
        Me.lblTotalTime6 = New System.Windows.Forms.Label()
        Me.lblTotalTime5 = New System.Windows.Forms.Label()
        Me.lblTotalTime4 = New System.Windows.Forms.Label()
        Me.lblStepText = New System.Windows.Forms.Label()
        Me.lblSiteTime01Text = New System.Windows.Forms.Label()
        Me.lblSiteTime02Text = New System.Windows.Forms.Label()
        Me.lblSiteTime03Text = New System.Windows.Forms.Label()
        Me.lblSiteTime04Text = New System.Windows.Forms.Label()
        Me.lblSiteTime05Text = New System.Windows.Forms.Label()
        Me.lblSiteTime06Text = New System.Windows.Forms.Label()
        Me.lblMFCOffTime01Text = New System.Windows.Forms.Label()
        Me.txtMFCOffTime01 = New System.Windows.Forms.TextBox()
        Me.lblMFCOnTime01Text = New System.Windows.Forms.Label()
        Me.txtMFCOnTime01 = New System.Windows.Forms.TextBox()
        Me.grpMFC01 = New System.Windows.Forms.GroupBox()
        Me.lblMFC01FlowText = New System.Windows.Forms.Label()
        Me.txtMFC01Flow = New System.Windows.Forms.TextBox()
        Me.grpMFC02 = New System.Windows.Forms.GroupBox()
        Me.lblMFC02FlowText = New System.Windows.Forms.Label()
        Me.txtMFC02Flow = New System.Windows.Forms.TextBox()
        Me.lblMFCOffTime02Text = New System.Windows.Forms.Label()
        Me.lblMFCOnTime02Text = New System.Windows.Forms.Label()
        Me.txtMFCOffTime02 = New System.Windows.Forms.TextBox()
        Me.txtMFCOnTime02 = New System.Windows.Forms.TextBox()
        Me.lblArrow01Text = New System.Windows.Forms.Label()
        Me.pnl6Site = New System.Windows.Forms.Panel()
        Me.chkPurgeKeepBonding = New System.Windows.Forms.CheckBox()
        Me.lblPurgeOffText = New System.Windows.Forms.Label()
        Me.txtPurgeOFFTime = New System.Windows.Forms.TextBox()
        Me.lblPurgeOnText = New System.Windows.Forms.Label()
        Me.txtPurgeONTime = New System.Windows.Forms.TextBox()
        Me.picC01 = New System.Windows.Forms.PictureBox()
        Me.lblAfterPurgeTemp = New System.Windows.Forms.Label()
        Me.txtAfterPurgeTemp = New System.Windows.Forms.TextBox()
        Me.chkPurgeCooling = New System.Windows.Forms.CheckBox()
        Me.TabControlOption = New System.Windows.Forms.TabControl()
        Me.TabPageOption = New System.Windows.Forms.TabPage()
        Me.TabPageMFC01 = New System.Windows.Forms.TabPage()
        Me.TabPageMFC02 = New System.Windows.Forms.TabPage()
        Me.TabPagePurge = New System.Windows.Forms.TabPage()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.grpProcessCondition.SuspendLayout()
        Me.grpProcessOption.SuspendLayout()
        CType(Me.dgRecipeEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMFC01.SuspendLayout()
        Me.grpMFC02.SuspendLayout()
        Me.pnl6Site.SuspendLayout()
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlOption.SuspendLayout()
        Me.TabPageOption.SuspendLayout()
        Me.TabPageMFC01.SuspendLayout()
        Me.TabPageMFC02.SuspendLayout()
        Me.TabPagePurge.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoadRecipe
        '
        Me.btnLoadRecipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLoadRecipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadRecipe.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnLoadRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoadRecipe.Location = New System.Drawing.Point(615, 62)
        Me.btnLoadRecipe.Name = "btnLoadRecipe"
        Me.btnLoadRecipe.Size = New System.Drawing.Size(92, 43)
        Me.btnLoadRecipe.TabIndex = 310
        Me.btnLoadRecipe.Text = "開啟檔案"
        Me.ToolTip1.SetToolTip(Me.btnLoadRecipe, "Load Recipe")
        Me.btnLoadRecipe.UseVisualStyleBackColor = False
        '
        'btnSaveRecipe
        '
        Me.btnSaveRecipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSaveRecipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveRecipe.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnSaveRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveRecipe.Location = New System.Drawing.Point(615, 146)
        Me.btnSaveRecipe.Name = "btnSaveRecipe"
        Me.btnSaveRecipe.Size = New System.Drawing.Size(92, 43)
        Me.btnSaveRecipe.TabIndex = 311
        Me.btnSaveRecipe.Text = "儲存檔案"
        Me.ToolTip1.SetToolTip(Me.btnSaveRecipe, "Save Recipe")
        Me.btnSaveRecipe.UseVisualStyleBackColor = False
        '
        'lblRecipeBasePressureText
        '
        Me.lblRecipeBasePressureText.BackColor = System.Drawing.Color.Transparent
        Me.lblRecipeBasePressureText.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblRecipeBasePressureText.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeBasePressureText.Location = New System.Drawing.Point(713, 124)
        Me.lblRecipeBasePressureText.Name = "lblRecipeBasePressureText"
        Me.lblRecipeBasePressureText.Size = New System.Drawing.Size(91, 39)
        Me.lblRecipeBasePressureText.TabIndex = 309
        Me.lblRecipeBasePressureText.Text = "背景壓力:"
        Me.lblRecipeBasePressureText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRecipeBasePressure
        '
        Me.txtRecipeBasePressure.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecipeBasePressure.Location = New System.Drawing.Point(807, 130)
        Me.txtRecipeBasePressure.Name = "txtRecipeBasePressure"
        Me.txtRecipeBasePressure.Size = New System.Drawing.Size(97, 26)
        Me.txtRecipeBasePressure.TabIndex = 314
        Me.txtRecipeBasePressure.Text = "9.0E-01"
        Me.txtRecipeBasePressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtRecipeBasePressure, "Enter Base Pressure when Process")
        '
        'Timer1
        '
        '
        'lblUnit
        '
        Me.lblUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblUnit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.ForeColor = System.Drawing.Color.Black
        Me.lblUnit.Location = New System.Drawing.Point(906, 132)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(49, 23)
        Me.lblUnit.TabIndex = 320
        Me.lblUnit.Text = "Torr"
        Me.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRecipeNote
        '
        Me.txtRecipeNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtRecipeNote.Location = New System.Drawing.Point(807, 98)
        Me.txtRecipeNote.Name = "txtRecipeNote"
        Me.txtRecipeNote.Size = New System.Drawing.Size(214, 26)
        Me.txtRecipeNote.TabIndex = 313
        Me.txtRecipeNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtRecipeNote, "Enter Note for Recipe")
        '
        'chkKeyBoard
        '
        Me.chkKeyBoard.BackColor = System.Drawing.Color.Transparent
        Me.chkKeyBoard.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.chkKeyBoard.Location = New System.Drawing.Point(477, 695)
        Me.chkKeyBoard.Name = "chkKeyBoard"
        Me.chkKeyBoard.Size = New System.Drawing.Size(128, 23)
        Me.chkKeyBoard.TabIndex = 515
        Me.chkKeyBoard.Text = "使用鍵盤"
        Me.chkKeyBoard.UseVisualStyleBackColor = False
        Me.chkKeyBoard.Visible = False
        '
        'txtSource
        '
        Me.txtSource.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSource.Location = New System.Drawing.Point(814, 330)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(49, 39)
        Me.txtSource.TabIndex = 322
        Me.txtSource.Text = "1"
        Me.txtSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCopyTo
        '
        Me.btnCopyTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCopyTo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCopyTo.Location = New System.Drawing.Point(869, 328)
        Me.btnCopyTo.Name = "btnCopyTo"
        Me.btnCopyTo.Size = New System.Drawing.Size(92, 43)
        Me.btnCopyTo.TabIndex = 518
        Me.btnCopyTo.Text = "複製到->"
        Me.btnCopyTo.UseVisualStyleBackColor = False
        '
        'txtDest
        '
        Me.txtDest.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDest.Location = New System.Drawing.Point(970, 330)
        Me.txtDest.Name = "txtDest"
        Me.txtDest.Size = New System.Drawing.Size(49, 39)
        Me.txtDest.TabIndex = 517
        Me.txtDest.Text = "2"
        Me.txtDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkAutoVent
        '
        Me.chkAutoVent.Checked = True
        Me.chkAutoVent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoVent.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoVent.Location = New System.Drawing.Point(12, 98)
        Me.chkAutoVent.Name = "chkAutoVent"
        Me.chkAutoVent.Size = New System.Drawing.Size(153, 26)
        Me.chkAutoVent.TabIndex = 520
        Me.chkAutoVent.Text = "結束後VENT"
        Me.chkAutoVent.UseVisualStyleBackColor = True
        '
        'grpProcessCondition
        '
        Me.grpProcessCondition.Controls.Add(Me.radPress)
        Me.grpProcessCondition.Controls.Add(Me.radTemp)
        Me.grpProcessCondition.Controls.Add(Me.radBoth)
        Me.grpProcessCondition.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProcessCondition.ForeColor = System.Drawing.Color.Black
        Me.grpProcessCondition.Location = New System.Drawing.Point(186, 6)
        Me.grpProcessCondition.Name = "grpProcessCondition"
        Me.grpProcessCondition.Size = New System.Drawing.Size(173, 110)
        Me.grpProcessCondition.TabIndex = 519
        Me.grpProcessCondition.TabStop = False
        Me.grpProcessCondition.Text = "製程繼續條件"
        '
        'radPress
        '
        Me.radPress.AutoSize = True
        Me.radPress.Location = New System.Drawing.Point(25, 80)
        Me.radPress.Name = "radPress"
        Me.radPress.Size = New System.Drawing.Size(58, 22)
        Me.radPress.TabIndex = 0
        Me.radPress.Text = "壓力"
        Me.radPress.UseVisualStyleBackColor = True
        '
        'radTemp
        '
        Me.radTemp.AutoSize = True
        Me.radTemp.Location = New System.Drawing.Point(25, 51)
        Me.radTemp.Name = "radTemp"
        Me.radTemp.Size = New System.Drawing.Size(58, 22)
        Me.radTemp.TabIndex = 0
        Me.radTemp.Text = "溫度"
        Me.radTemp.UseVisualStyleBackColor = True
        '
        'radBoth
        '
        Me.radBoth.AutoSize = True
        Me.radBoth.Checked = True
        Me.radBoth.Location = New System.Drawing.Point(25, 26)
        Me.radBoth.Name = "radBoth"
        Me.radBoth.Size = New System.Drawing.Size(58, 22)
        Me.radBoth.TabIndex = 0
        Me.radBoth.TabStop = True
        Me.radBoth.Text = "同時"
        Me.radBoth.UseVisualStyleBackColor = True
        '
        'lblIn01Text
        '
        Me.lblIn01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblIn01Text.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIn01Text.ForeColor = System.Drawing.Color.Black
        Me.lblIn01Text.Location = New System.Drawing.Point(865, 164)
        Me.lblIn01Text.Name = "lblIn01Text"
        Me.lblIn01Text.Size = New System.Drawing.Size(27, 23)
        Me.lblIn01Text.TabIndex = 518
        Me.lblIn01Text.Text = "in"
        Me.lblIn01Text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkVacuumMode
        '
        Me.chkVacuumMode.Checked = True
        Me.chkVacuumMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVacuumMode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVacuumMode.Location = New System.Drawing.Point(12, 176)
        Me.chkVacuumMode.Name = "chkVacuumMode"
        Me.chkVacuumMode.Size = New System.Drawing.Size(153, 26)
        Me.chkVacuumMode.TabIndex = 517
        Me.chkVacuumMode.Text = "真空壓合"
        Me.chkVacuumMode.UseVisualStyleBackColor = True
        '
        'chkBondBeforeVacuum
        '
        Me.chkBondBeforeVacuum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBondBeforeVacuum.Location = New System.Drawing.Point(12, 46)
        Me.chkBondBeforeVacuum.Name = "chkBondBeforeVacuum"
        Me.chkBondBeforeVacuum.Size = New System.Drawing.Size(153, 26)
        Me.chkBondBeforeVacuum.TabIndex = 516
        Me.chkBondBeforeVacuum.Text = "抽氣前預壓"
        Me.chkBondBeforeVacuum.UseVisualStyleBackColor = True
        '
        'chkVacuumPurge
        '
        Me.chkVacuumPurge.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVacuumPurge.Location = New System.Drawing.Point(12, 20)
        Me.chkVacuumPurge.Name = "chkVacuumPurge"
        Me.chkVacuumPurge.Size = New System.Drawing.Size(153, 26)
        Me.chkVacuumPurge.TabIndex = 515
        Me.chkVacuumPurge.Text = "抽氣時Purge"
        Me.chkVacuumPurge.UseVisualStyleBackColor = True
        '
        'chkKeepBonding
        '
        Me.chkKeepBonding.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKeepBonding.Location = New System.Drawing.Point(12, 72)
        Me.chkKeepBonding.Name = "chkKeepBonding"
        Me.chkKeepBonding.Size = New System.Drawing.Size(153, 26)
        Me.chkKeepBonding.TabIndex = 514
        Me.chkKeepBonding.Text = "結束後持壓 "
        Me.chkKeepBonding.UseVisualStyleBackColor = True
        '
        'lblRecipeName
        '
        Me.lblRecipeName.BackColor = System.Drawing.Color.Transparent
        Me.lblRecipeName.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblRecipeName.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecipeName.Location = New System.Drawing.Point(713, 62)
        Me.lblRecipeName.Name = "lblRecipeName"
        Me.lblRecipeName.Size = New System.Drawing.Size(91, 39)
        Me.lblRecipeName.TabIndex = 308
        Me.lblRecipeName.Text = "配方名:"
        Me.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRecipeNoteText
        '
        Me.lblRecipeNoteText.BackColor = System.Drawing.Color.Transparent
        Me.lblRecipeNoteText.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblRecipeNoteText.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeNoteText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecipeNoteText.Location = New System.Drawing.Point(713, 92)
        Me.lblRecipeNoteText.Name = "lblRecipeNoteText"
        Me.lblRecipeNoteText.Size = New System.Drawing.Size(91, 39)
        Me.lblRecipeNoteText.TabIndex = 308
        Me.lblRecipeNoteText.Text = "註解:"
        Me.lblRecipeNoteText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRecipeFileName
        '
        Me.lblRecipeFileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecipeFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecipeFileName.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lblRecipeFileName.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeFileName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecipeFileName.Location = New System.Drawing.Point(807, 67)
        Me.lblRecipeFileName.Name = "lblRecipeFileName"
        Me.lblRecipeFileName.Size = New System.Drawing.Size(214, 28)
        Me.lblRecipeFileName.TabIndex = 316
        Me.lblRecipeFileName.Text = "0"
        Me.lblRecipeFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWaferSizeText
        '
        Me.lblWaferSizeText.BackColor = System.Drawing.Color.Transparent
        Me.lblWaferSizeText.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblWaferSizeText.ForeColor = System.Drawing.Color.Black
        Me.lblWaferSizeText.Location = New System.Drawing.Point(713, 161)
        Me.lblWaferSizeText.Name = "lblWaferSizeText"
        Me.lblWaferSizeText.Size = New System.Drawing.Size(91, 28)
        Me.lblWaferSizeText.TabIndex = 308
        Me.lblWaferSizeText.Text = "晶圓尺寸:"
        Me.lblWaferSizeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaferSize
        '
        Me.txtWaferSize.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaferSize.Location = New System.Drawing.Point(807, 162)
        Me.txtWaferSize.Name = "txtWaferSize"
        Me.txtWaferSize.Size = New System.Drawing.Size(58, 26)
        Me.txtWaferSize.TabIndex = 313
        Me.txtWaferSize.Text = "2"
        Me.txtWaferSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPreSetTimeText
        '
        Me.lblPreSetTimeText.BackColor = System.Drawing.Color.Transparent
        Me.lblPreSetTimeText.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblPreSetTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblPreSetTimeText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPreSetTimeText.Location = New System.Drawing.Point(627, 191)
        Me.lblPreSetTimeText.Name = "lblPreSetTimeText"
        Me.lblPreSetTimeText.Size = New System.Drawing.Size(109, 28)
        Me.lblPreSetTimeText.TabIndex = 316
        Me.lblPreSetTimeText.Text = "預計時間(s):"
        Me.lblPreSetTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStepTotalTime
        '
        Me.lblStepTotalTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStepTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStepTotalTime.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblStepTotalTime.ForeColor = System.Drawing.Color.Black
        Me.lblStepTotalTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStepTotalTime.Location = New System.Drawing.Point(742, 191)
        Me.lblStepTotalTime.Name = "lblStepTotalTime"
        Me.lblStepTotalTime.Size = New System.Drawing.Size(277, 28)
        Me.lblStepTotalTime.TabIndex = 316
        Me.lblStepTotalTime.Text = "0"
        Me.lblStepTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRecipeStep
        '
        Me.lblRecipeStep.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRecipeStep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecipeStep.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipeStep.ForeColor = System.Drawing.Color.Black
        Me.lblRecipeStep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecipeStep.Location = New System.Drawing.Point(674, 9)
        Me.lblRecipeStep.Name = "lblRecipeStep"
        Me.lblRecipeStep.Size = New System.Drawing.Size(62, 28)
        Me.lblRecipeStep.TabIndex = 316
        Me.lblRecipeStep.Text = "0"
        Me.lblRecipeStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddStep
        '
        Me.btnAddStep.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAddStep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStep.Location = New System.Drawing.Point(608, 332)
        Me.btnAddStep.Name = "btnAddStep"
        Me.btnAddStep.Size = New System.Drawing.Size(92, 43)
        Me.btnAddStep.TabIndex = 512
        Me.btnAddStep.Text = "新增 Step"
        Me.btnAddStep.UseVisualStyleBackColor = False
        '
        'btnDelStep
        '
        Me.btnDelStep.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelStep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelStep.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDelStep.Location = New System.Drawing.Point(608, 387)
        Me.btnDelStep.Name = "btnDelStep"
        Me.btnDelStep.Size = New System.Drawing.Size(92, 43)
        Me.btnDelStep.TabIndex = 512
        Me.btnDelStep.Text = "刪除 Step"
        Me.btnDelStep.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "*.rcp"
        '
        'grpProcessOption
        '
        Me.grpProcessOption.Controls.Add(Me.chkAutoDoorOpen)
        Me.grpProcessOption.Controls.Add(Me.chkAfterPurge)
        Me.grpProcessOption.Controls.Add(Me.chkVacuumMode)
        Me.grpProcessOption.Controls.Add(Me.chkAutoVent)
        Me.grpProcessOption.Controls.Add(Me.chkKeepBonding)
        Me.grpProcessOption.Controls.Add(Me.chkBondBeforeVacuum)
        Me.grpProcessOption.Controls.Add(Me.chkVacuumPurge)
        Me.grpProcessOption.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProcessOption.ForeColor = System.Drawing.Color.Black
        Me.grpProcessOption.Location = New System.Drawing.Point(6, 6)
        Me.grpProcessOption.Name = "grpProcessOption"
        Me.grpProcessOption.Size = New System.Drawing.Size(174, 204)
        Me.grpProcessOption.TabIndex = 520
        Me.grpProcessOption.TabStop = False
        Me.grpProcessOption.Text = "製程選項"
        '
        'chkAutoDoorOpen
        '
        Me.chkAutoDoorOpen.Checked = True
        Me.chkAutoDoorOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoDoorOpen.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoDoorOpen.Location = New System.Drawing.Point(12, 124)
        Me.chkAutoDoorOpen.Name = "chkAutoDoorOpen"
        Me.chkAutoDoorOpen.Size = New System.Drawing.Size(153, 26)
        Me.chkAutoDoorOpen.TabIndex = 523
        Me.chkAutoDoorOpen.Text = "結束後開門"
        Me.chkAutoDoorOpen.UseVisualStyleBackColor = True
        '
        'chkAfterPurge
        '
        Me.chkAfterPurge.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAfterPurge.Location = New System.Drawing.Point(12, 150)
        Me.chkAfterPurge.Name = "chkAfterPurge"
        Me.chkAfterPurge.Size = New System.Drawing.Size(153, 26)
        Me.chkAfterPurge.TabIndex = 521
        Me.chkAfterPurge.Text = "結束後Purge"
        Me.chkAfterPurge.UseVisualStyleBackColor = True
        '
        'dgRecipeEdit
        '
        Me.dgRecipeEdit.AllowUserToAddRows = False
        Me.dgRecipeEdit.AllowUserToDeleteRows = False
        Me.dgRecipeEdit.AllowUserToResizeColumns = False
        Me.dgRecipeEdit.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRecipeEdit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgRecipeEdit.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgRecipeEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgRecipeEdit.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.NullValue = "0"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRecipeEdit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgRecipeEdit.ColumnHeadersHeight = 30
        Me.dgRecipeEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgRecipeEdit.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.NullValue = "0"
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRecipeEdit.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgRecipeEdit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgRecipeEdit.EnableHeadersVisualStyles = False
        Me.dgRecipeEdit.GridColor = System.Drawing.Color.Brown
        Me.dgRecipeEdit.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dgRecipeEdit.Location = New System.Drawing.Point(0, 4)
        Me.dgRecipeEdit.Margin = New System.Windows.Forms.Padding(0)
        Me.dgRecipeEdit.MultiSelect = False
        Me.dgRecipeEdit.Name = "dgRecipeEdit"
        Me.dgRecipeEdit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle8.NullValue = "0"
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRecipeEdit.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgRecipeEdit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRecipeEdit.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgRecipeEdit.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRecipeEdit.RowTemplate.DefaultCellStyle.NullValue = "-"
        Me.dgRecipeEdit.RowTemplate.DividerHeight = 1
        Me.dgRecipeEdit.RowTemplate.Height = 30
        Me.dgRecipeEdit.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRecipeEdit.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgRecipeEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgRecipeEdit.Size = New System.Drawing.Size(605, 688)
        Me.dgRecipeEdit.TabIndex = 521
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClearAll.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(927, 385)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(92, 43)
        Me.btnClearAll.TabIndex = 525
        Me.btnClearAll.Text = "清除全部"
        Me.btnClearAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(711, 332)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(92, 43)
        Me.btnPrev.TabIndex = 527
        Me.btnPrev.Text = "上一頁"
        Me.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(711, 387)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(92, 43)
        Me.btnNext.TabIndex = 526
        Me.btnNext.Text = "下一頁"
        Me.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnCopyToAll
        '
        Me.btnCopyToAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCopyToAll.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyToAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCopyToAll.Location = New System.Drawing.Point(814, 385)
        Me.btnCopyToAll.Name = "btnCopyToAll"
        Me.btnCopyToAll.Size = New System.Drawing.Size(92, 43)
        Me.btnCopyToAll.TabIndex = 528
        Me.btnCopyToAll.Text = "複製全部"
        Me.btnCopyToAll.UseVisualStyleBackColor = False
        '
        'lblTotalTime1
        '
        Me.lblTotalTime1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalTime1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTime1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime1.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTime1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalTime1.Location = New System.Drawing.Point(666, 222)
        Me.lblTotalTime1.Name = "lblTotalTime1"
        Me.lblTotalTime1.Size = New System.Drawing.Size(161, 28)
        Me.lblTotalTime1.TabIndex = 529
        Me.lblTotalTime1.Text = "0"
        Me.lblTotalTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTime2
        '
        Me.lblTotalTime2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalTime2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTime2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime2.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTime2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalTime2.Location = New System.Drawing.Point(666, 250)
        Me.lblTotalTime2.Name = "lblTotalTime2"
        Me.lblTotalTime2.Size = New System.Drawing.Size(161, 28)
        Me.lblTotalTime2.TabIndex = 530
        Me.lblTotalTime2.Text = "0"
        Me.lblTotalTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTime3
        '
        Me.lblTotalTime3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalTime3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTime3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime3.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTime3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalTime3.Location = New System.Drawing.Point(666, 278)
        Me.lblTotalTime3.Name = "lblTotalTime3"
        Me.lblTotalTime3.Size = New System.Drawing.Size(161, 28)
        Me.lblTotalTime3.TabIndex = 531
        Me.lblTotalTime3.Text = "0"
        Me.lblTotalTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTime6
        '
        Me.lblTotalTime6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalTime6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTime6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime6.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTime6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalTime6.Location = New System.Drawing.Point(29, 56)
        Me.lblTotalTime6.Name = "lblTotalTime6"
        Me.lblTotalTime6.Size = New System.Drawing.Size(161, 28)
        Me.lblTotalTime6.TabIndex = 534
        Me.lblTotalTime6.Text = "0"
        Me.lblTotalTime6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTime5
        '
        Me.lblTotalTime5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalTime5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTime5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime5.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTime5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalTime5.Location = New System.Drawing.Point(29, 28)
        Me.lblTotalTime5.Name = "lblTotalTime5"
        Me.lblTotalTime5.Size = New System.Drawing.Size(161, 28)
        Me.lblTotalTime5.TabIndex = 533
        Me.lblTotalTime5.Text = "0"
        Me.lblTotalTime5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTime4
        '
        Me.lblTotalTime4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalTime4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTime4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime4.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTime4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTotalTime4.Location = New System.Drawing.Point(29, 0)
        Me.lblTotalTime4.Name = "lblTotalTime4"
        Me.lblTotalTime4.Size = New System.Drawing.Size(161, 28)
        Me.lblTotalTime4.TabIndex = 532
        Me.lblTotalTime4.Text = "0"
        Me.lblTotalTime4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStepText
        '
        Me.lblStepText.BackColor = System.Drawing.Color.Transparent
        Me.lblStepText.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblStepText.ForeColor = System.Drawing.Color.Black
        Me.lblStepText.Location = New System.Drawing.Point(609, 13)
        Me.lblStepText.Name = "lblStepText"
        Me.lblStepText.Size = New System.Drawing.Size(62, 24)
        Me.lblStepText.TabIndex = 321
        Me.lblStepText.Text = "STEP:"
        Me.lblStepText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSiteTime01Text
        '
        Me.lblSiteTime01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSiteTime01Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblSiteTime01Text.ForeColor = System.Drawing.Color.Black
        Me.lblSiteTime01Text.Location = New System.Drawing.Point(639, 224)
        Me.lblSiteTime01Text.Name = "lblSiteTime01Text"
        Me.lblSiteTime01Text.Size = New System.Drawing.Size(25, 24)
        Me.lblSiteTime01Text.TabIndex = 535
        Me.lblSiteTime01Text.Text = "1:"
        Me.lblSiteTime01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSiteTime02Text
        '
        Me.lblSiteTime02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSiteTime02Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblSiteTime02Text.ForeColor = System.Drawing.Color.Black
        Me.lblSiteTime02Text.Location = New System.Drawing.Point(639, 252)
        Me.lblSiteTime02Text.Name = "lblSiteTime02Text"
        Me.lblSiteTime02Text.Size = New System.Drawing.Size(25, 24)
        Me.lblSiteTime02Text.TabIndex = 535
        Me.lblSiteTime02Text.Text = "2:"
        Me.lblSiteTime02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSiteTime03Text
        '
        Me.lblSiteTime03Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSiteTime03Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblSiteTime03Text.ForeColor = System.Drawing.Color.Black
        Me.lblSiteTime03Text.Location = New System.Drawing.Point(639, 280)
        Me.lblSiteTime03Text.Name = "lblSiteTime03Text"
        Me.lblSiteTime03Text.Size = New System.Drawing.Size(25, 24)
        Me.lblSiteTime03Text.TabIndex = 535
        Me.lblSiteTime03Text.Text = "3:"
        Me.lblSiteTime03Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSiteTime04Text
        '
        Me.lblSiteTime04Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSiteTime04Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblSiteTime04Text.ForeColor = System.Drawing.Color.Black
        Me.lblSiteTime04Text.Location = New System.Drawing.Point(2, 2)
        Me.lblSiteTime04Text.Name = "lblSiteTime04Text"
        Me.lblSiteTime04Text.Size = New System.Drawing.Size(25, 24)
        Me.lblSiteTime04Text.TabIndex = 535
        Me.lblSiteTime04Text.Text = "4:"
        Me.lblSiteTime04Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSiteTime05Text
        '
        Me.lblSiteTime05Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSiteTime05Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblSiteTime05Text.ForeColor = System.Drawing.Color.Black
        Me.lblSiteTime05Text.Location = New System.Drawing.Point(2, 30)
        Me.lblSiteTime05Text.Name = "lblSiteTime05Text"
        Me.lblSiteTime05Text.Size = New System.Drawing.Size(25, 24)
        Me.lblSiteTime05Text.TabIndex = 535
        Me.lblSiteTime05Text.Text = "5:"
        Me.lblSiteTime05Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSiteTime06Text
        '
        Me.lblSiteTime06Text.BackColor = System.Drawing.Color.Transparent
        Me.lblSiteTime06Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblSiteTime06Text.ForeColor = System.Drawing.Color.Black
        Me.lblSiteTime06Text.Location = New System.Drawing.Point(2, 58)
        Me.lblSiteTime06Text.Name = "lblSiteTime06Text"
        Me.lblSiteTime06Text.Size = New System.Drawing.Size(25, 24)
        Me.lblSiteTime06Text.TabIndex = 535
        Me.lblSiteTime06Text.Text = "6:"
        Me.lblSiteTime06Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMFCOffTime01Text
        '
        Me.lblMFCOffTime01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblMFCOffTime01Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblMFCOffTime01Text.ForeColor = System.Drawing.Color.Black
        Me.lblMFCOffTime01Text.Location = New System.Drawing.Point(13, 53)
        Me.lblMFCOffTime01Text.Name = "lblMFCOffTime01Text"
        Me.lblMFCOffTime01Text.Size = New System.Drawing.Size(109, 28)
        Me.lblMFCOffTime01Text.TabIndex = 536
        Me.lblMFCOffTime01Text.Text = "OFF時間(s):"
        Me.lblMFCOffTime01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMFCOffTime01
        '
        Me.txtMFCOffTime01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMFCOffTime01.Location = New System.Drawing.Point(125, 54)
        Me.txtMFCOffTime01.Name = "txtMFCOffTime01"
        Me.txtMFCOffTime01.Size = New System.Drawing.Size(58, 26)
        Me.txtMFCOffTime01.TabIndex = 537
        Me.txtMFCOffTime01.Text = "30"
        Me.txtMFCOffTime01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMFCOnTime01Text
        '
        Me.lblMFCOnTime01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblMFCOnTime01Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblMFCOnTime01Text.ForeColor = System.Drawing.Color.Black
        Me.lblMFCOnTime01Text.Location = New System.Drawing.Point(13, 85)
        Me.lblMFCOnTime01Text.Name = "lblMFCOnTime01Text"
        Me.lblMFCOnTime01Text.Size = New System.Drawing.Size(109, 28)
        Me.lblMFCOnTime01Text.TabIndex = 538
        Me.lblMFCOnTime01Text.Text = "ON時間(s):"
        Me.lblMFCOnTime01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMFCOnTime01
        '
        Me.txtMFCOnTime01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMFCOnTime01.Location = New System.Drawing.Point(125, 86)
        Me.txtMFCOnTime01.Name = "txtMFCOnTime01"
        Me.txtMFCOnTime01.Size = New System.Drawing.Size(58, 26)
        Me.txtMFCOnTime01.TabIndex = 539
        Me.txtMFCOnTime01.Text = "5"
        Me.txtMFCOnTime01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpMFC01
        '
        Me.grpMFC01.Controls.Add(Me.lblMFC01FlowText)
        Me.grpMFC01.Controls.Add(Me.txtMFC01Flow)
        Me.grpMFC01.Controls.Add(Me.lblMFCOffTime01Text)
        Me.grpMFC01.Controls.Add(Me.lblMFCOnTime01Text)
        Me.grpMFC01.Controls.Add(Me.txtMFCOffTime01)
        Me.grpMFC01.Controls.Add(Me.txtMFCOnTime01)
        Me.grpMFC01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMFC01.ForeColor = System.Drawing.Color.Black
        Me.grpMFC01.Location = New System.Drawing.Point(6, 6)
        Me.grpMFC01.Name = "grpMFC01"
        Me.grpMFC01.Size = New System.Drawing.Size(189, 126)
        Me.grpMFC01.TabIndex = 520
        Me.grpMFC01.TabStop = False
        Me.grpMFC01.Text = "MFC 01 週期設定"
        '
        'lblMFC01FlowText
        '
        Me.lblMFC01FlowText.BackColor = System.Drawing.Color.Transparent
        Me.lblMFC01FlowText.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblMFC01FlowText.ForeColor = System.Drawing.Color.Black
        Me.lblMFC01FlowText.Location = New System.Drawing.Point(13, 21)
        Me.lblMFC01FlowText.Name = "lblMFC01FlowText"
        Me.lblMFC01FlowText.Size = New System.Drawing.Size(109, 28)
        Me.lblMFC01FlowText.TabIndex = 540
        Me.lblMFC01FlowText.Text = "流量(sccm):"
        Me.lblMFC01FlowText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMFC01Flow
        '
        Me.txtMFC01Flow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMFC01Flow.Location = New System.Drawing.Point(125, 22)
        Me.txtMFC01Flow.Name = "txtMFC01Flow"
        Me.txtMFC01Flow.Size = New System.Drawing.Size(58, 26)
        Me.txtMFC01Flow.TabIndex = 541
        Me.txtMFC01Flow.Text = "30"
        Me.txtMFC01Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpMFC02
        '
        Me.grpMFC02.Controls.Add(Me.lblMFC02FlowText)
        Me.grpMFC02.Controls.Add(Me.txtMFC02Flow)
        Me.grpMFC02.Controls.Add(Me.lblMFCOffTime02Text)
        Me.grpMFC02.Controls.Add(Me.lblMFCOnTime02Text)
        Me.grpMFC02.Controls.Add(Me.txtMFCOffTime02)
        Me.grpMFC02.Controls.Add(Me.txtMFCOnTime02)
        Me.grpMFC02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMFC02.ForeColor = System.Drawing.Color.Black
        Me.grpMFC02.Location = New System.Drawing.Point(6, 6)
        Me.grpMFC02.Name = "grpMFC02"
        Me.grpMFC02.Size = New System.Drawing.Size(189, 126)
        Me.grpMFC02.TabIndex = 540
        Me.grpMFC02.TabStop = False
        Me.grpMFC02.Text = "MFC 02 週期設定"
        '
        'lblMFC02FlowText
        '
        Me.lblMFC02FlowText.BackColor = System.Drawing.Color.Transparent
        Me.lblMFC02FlowText.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblMFC02FlowText.ForeColor = System.Drawing.Color.Black
        Me.lblMFC02FlowText.Location = New System.Drawing.Point(13, 21)
        Me.lblMFC02FlowText.Name = "lblMFC02FlowText"
        Me.lblMFC02FlowText.Size = New System.Drawing.Size(109, 28)
        Me.lblMFC02FlowText.TabIndex = 542
        Me.lblMFC02FlowText.Text = "流量(sccm):"
        Me.lblMFC02FlowText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMFC02Flow
        '
        Me.txtMFC02Flow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMFC02Flow.Location = New System.Drawing.Point(125, 22)
        Me.txtMFC02Flow.Name = "txtMFC02Flow"
        Me.txtMFC02Flow.Size = New System.Drawing.Size(58, 26)
        Me.txtMFC02Flow.TabIndex = 543
        Me.txtMFC02Flow.Text = "30"
        Me.txtMFC02Flow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMFCOffTime02Text
        '
        Me.lblMFCOffTime02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblMFCOffTime02Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblMFCOffTime02Text.ForeColor = System.Drawing.Color.Black
        Me.lblMFCOffTime02Text.Location = New System.Drawing.Point(13, 53)
        Me.lblMFCOffTime02Text.Name = "lblMFCOffTime02Text"
        Me.lblMFCOffTime02Text.Size = New System.Drawing.Size(109, 28)
        Me.lblMFCOffTime02Text.TabIndex = 540
        Me.lblMFCOffTime02Text.Text = "OFF時間(s):"
        Me.lblMFCOffTime02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMFCOnTime02Text
        '
        Me.lblMFCOnTime02Text.BackColor = System.Drawing.Color.Transparent
        Me.lblMFCOnTime02Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblMFCOnTime02Text.ForeColor = System.Drawing.Color.Black
        Me.lblMFCOnTime02Text.Location = New System.Drawing.Point(13, 85)
        Me.lblMFCOnTime02Text.Name = "lblMFCOnTime02Text"
        Me.lblMFCOnTime02Text.Size = New System.Drawing.Size(109, 28)
        Me.lblMFCOnTime02Text.TabIndex = 541
        Me.lblMFCOnTime02Text.Text = "ON時間(s):"
        Me.lblMFCOnTime02Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMFCOffTime02
        '
        Me.txtMFCOffTime02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMFCOffTime02.Location = New System.Drawing.Point(125, 54)
        Me.txtMFCOffTime02.Name = "txtMFCOffTime02"
        Me.txtMFCOffTime02.Size = New System.Drawing.Size(58, 26)
        Me.txtMFCOffTime02.TabIndex = 537
        Me.txtMFCOffTime02.Text = "30"
        Me.txtMFCOffTime02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMFCOnTime02
        '
        Me.txtMFCOnTime02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMFCOnTime02.Location = New System.Drawing.Point(125, 86)
        Me.txtMFCOnTime02.Name = "txtMFCOnTime02"
        Me.txtMFCOnTime02.Size = New System.Drawing.Size(58, 26)
        Me.txtMFCOnTime02.TabIndex = 539
        Me.txtMFCOnTime02.Text = "5"
        Me.txtMFCOnTime02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblArrow01Text
        '
        Me.lblArrow01Text.BackColor = System.Drawing.Color.Transparent
        Me.lblArrow01Text.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblArrow01Text.ForeColor = System.Drawing.Color.Black
        Me.lblArrow01Text.Location = New System.Drawing.Point(580, 692)
        Me.lblArrow01Text.Name = "lblArrow01Text"
        Me.lblArrow01Text.Size = New System.Drawing.Size(25, 24)
        Me.lblArrow01Text.TabIndex = 541
        Me.lblArrow01Text.Text = "->"
        Me.lblArrow01Text.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblArrow01Text.Visible = False
        '
        'pnl6Site
        '
        Me.pnl6Site.Controls.Add(Me.lblSiteTime06Text)
        Me.pnl6Site.Controls.Add(Me.lblSiteTime05Text)
        Me.pnl6Site.Controls.Add(Me.lblSiteTime04Text)
        Me.pnl6Site.Controls.Add(Me.lblTotalTime6)
        Me.pnl6Site.Controls.Add(Me.lblTotalTime5)
        Me.pnl6Site.Controls.Add(Me.lblTotalTime4)
        Me.pnl6Site.Location = New System.Drawing.Point(829, 222)
        Me.pnl6Site.Name = "pnl6Site"
        Me.pnl6Site.Size = New System.Drawing.Size(203, 87)
        Me.pnl6Site.TabIndex = 542
        '
        'chkPurgeKeepBonding
        '
        Me.chkPurgeKeepBonding.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPurgeKeepBonding.Location = New System.Drawing.Point(28, 151)
        Me.chkPurgeKeepBonding.Name = "chkPurgeKeepBonding"
        Me.chkPurgeKeepBonding.Size = New System.Drawing.Size(194, 26)
        Me.chkPurgeKeepBonding.TabIndex = 621
        Me.chkPurgeKeepBonding.Text = "Purge 時持壓"
        Me.chkPurgeKeepBonding.UseVisualStyleBackColor = True
        '
        'lblPurgeOffText
        '
        Me.lblPurgeOffText.BackColor = System.Drawing.Color.Transparent
        Me.lblPurgeOffText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurgeOffText.ForeColor = System.Drawing.Color.Black
        Me.lblPurgeOffText.Location = New System.Drawing.Point(14, 120)
        Me.lblPurgeOffText.Name = "lblPurgeOffText"
        Me.lblPurgeOffText.Size = New System.Drawing.Size(140, 28)
        Me.lblPurgeOffText.TabIndex = 619
        Me.lblPurgeOffText.Text = "抽氣時間(s)"
        Me.lblPurgeOffText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPurgeOFFTime
        '
        Me.txtPurgeOFFTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurgeOFFTime.Location = New System.Drawing.Point(160, 121)
        Me.txtPurgeOFFTime.Name = "txtPurgeOFFTime"
        Me.txtPurgeOFFTime.Size = New System.Drawing.Size(62, 26)
        Me.txtPurgeOFFTime.TabIndex = 618
        Me.txtPurgeOFFTime.Text = "15"
        Me.txtPurgeOFFTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPurgeOnText
        '
        Me.lblPurgeOnText.BackColor = System.Drawing.Color.Transparent
        Me.lblPurgeOnText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurgeOnText.ForeColor = System.Drawing.Color.Black
        Me.lblPurgeOnText.Location = New System.Drawing.Point(14, 86)
        Me.lblPurgeOnText.Name = "lblPurgeOnText"
        Me.lblPurgeOnText.Size = New System.Drawing.Size(140, 28)
        Me.lblPurgeOnText.TabIndex = 620
        Me.lblPurgeOnText.Text = "進氣時間(s)"
        Me.lblPurgeOnText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPurgeONTime
        '
        Me.txtPurgeONTime.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurgeONTime.Location = New System.Drawing.Point(160, 87)
        Me.txtPurgeONTime.Name = "txtPurgeONTime"
        Me.txtPurgeONTime.Size = New System.Drawing.Size(62, 26)
        Me.txtPurgeONTime.TabIndex = 617
        Me.txtPurgeONTime.Text = "3"
        Me.txtPurgeONTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picC01
        '
        Me.picC01.BackColor = System.Drawing.SystemColors.Control
        Me.picC01.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picC01.Image = Global.CELLO.My.Resources.Resources.tempc
        Me.picC01.Location = New System.Drawing.Point(206, 57)
        Me.picC01.Name = "picC01"
        Me.picC01.Size = New System.Drawing.Size(22, 22)
        Me.picC01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picC01.TabIndex = 616
        Me.picC01.TabStop = False
        '
        'lblAfterPurgeTemp
        '
        Me.lblAfterPurgeTemp.BackColor = System.Drawing.Color.Transparent
        Me.lblAfterPurgeTemp.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lblAfterPurgeTemp.ForeColor = System.Drawing.Color.Black
        Me.lblAfterPurgeTemp.Location = New System.Drawing.Point(14, 54)
        Me.lblAfterPurgeTemp.Name = "lblAfterPurgeTemp"
        Me.lblAfterPurgeTemp.Size = New System.Drawing.Size(140, 28)
        Me.lblAfterPurgeTemp.TabIndex = 615
        Me.lblAfterPurgeTemp.Text = "開始Purge 溫度:"
        Me.lblAfterPurgeTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAfterPurgeTemp
        '
        Me.txtAfterPurgeTemp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAfterPurgeTemp.Location = New System.Drawing.Point(160, 55)
        Me.txtAfterPurgeTemp.Name = "txtAfterPurgeTemp"
        Me.txtAfterPurgeTemp.Size = New System.Drawing.Size(44, 26)
        Me.txtAfterPurgeTemp.TabIndex = 614
        Me.txtAfterPurgeTemp.Text = "200"
        Me.txtAfterPurgeTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkPurgeCooling
        '
        Me.chkPurgeCooling.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPurgeCooling.Location = New System.Drawing.Point(29, 25)
        Me.chkPurgeCooling.Name = "chkPurgeCooling"
        Me.chkPurgeCooling.Size = New System.Drawing.Size(153, 26)
        Me.chkPurgeCooling.TabIndex = 613
        Me.chkPurgeCooling.Text = "Purge降溫"
        Me.chkPurgeCooling.UseVisualStyleBackColor = True
        '
        'TabControlOption
        '
        Me.TabControlOption.Controls.Add(Me.TabPageOption)
        Me.TabControlOption.Controls.Add(Me.TabPageMFC01)
        Me.TabControlOption.Controls.Add(Me.TabPageMFC02)
        Me.TabControlOption.Controls.Add(Me.TabPagePurge)
        Me.TabControlOption.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TabControlOption.ItemSize = New System.Drawing.Size(100, 36)
        Me.TabControlOption.Location = New System.Drawing.Point(609, 436)
        Me.TabControlOption.Name = "TabControlOption"
        Me.TabControlOption.SelectedIndex = 0
        Me.TabControlOption.Size = New System.Drawing.Size(412, 256)
        Me.TabControlOption.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControlOption.TabIndex = 622
        '
        'TabPageOption
        '
        Me.TabPageOption.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageOption.Controls.Add(Me.grpProcessOption)
        Me.TabPageOption.Controls.Add(Me.grpProcessCondition)
        Me.TabPageOption.Location = New System.Drawing.Point(4, 40)
        Me.TabPageOption.Name = "TabPageOption"
        Me.TabPageOption.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageOption.Size = New System.Drawing.Size(404, 212)
        Me.TabPageOption.TabIndex = 0
        Me.TabPageOption.Text = "Option"
        '
        'TabPageMFC01
        '
        Me.TabPageMFC01.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageMFC01.Controls.Add(Me.grpMFC01)
        Me.TabPageMFC01.Location = New System.Drawing.Point(4, 40)
        Me.TabPageMFC01.Name = "TabPageMFC01"
        Me.TabPageMFC01.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMFC01.Size = New System.Drawing.Size(404, 212)
        Me.TabPageMFC01.TabIndex = 1
        Me.TabPageMFC01.Text = "MFC 01"
        '
        'TabPageMFC02
        '
        Me.TabPageMFC02.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageMFC02.Controls.Add(Me.grpMFC02)
        Me.TabPageMFC02.Location = New System.Drawing.Point(4, 40)
        Me.TabPageMFC02.Name = "TabPageMFC02"
        Me.TabPageMFC02.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMFC02.Size = New System.Drawing.Size(404, 212)
        Me.TabPageMFC02.TabIndex = 3
        Me.TabPageMFC02.Text = "MFC 02"
        '
        'TabPagePurge
        '
        Me.TabPagePurge.BackColor = System.Drawing.SystemColors.Control
        Me.TabPagePurge.Controls.Add(Me.chkPurgeCooling)
        Me.TabPagePurge.Controls.Add(Me.chkPurgeKeepBonding)
        Me.TabPagePurge.Controls.Add(Me.txtAfterPurgeTemp)
        Me.TabPagePurge.Controls.Add(Me.lblPurgeOffText)
        Me.TabPagePurge.Controls.Add(Me.lblAfterPurgeTemp)
        Me.TabPagePurge.Controls.Add(Me.txtPurgeOFFTime)
        Me.TabPagePurge.Controls.Add(Me.picC01)
        Me.TabPagePurge.Controls.Add(Me.lblPurgeOnText)
        Me.TabPagePurge.Controls.Add(Me.txtPurgeONTime)
        Me.TabPagePurge.Location = New System.Drawing.Point(4, 40)
        Me.TabPagePurge.Name = "TabPagePurge"
        Me.TabPagePurge.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePurge.Size = New System.Drawing.Size(404, 212)
        Me.TabPagePurge.TabIndex = 2
        Me.TabPagePurge.Text = "Purge"
        '
        'btnEnter
        '
        Me.btnEnter.BackgroundImage = CType(resources.GetObject("btnEnter.BackgroundImage"), System.Drawing.Image)
        Me.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnter.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(803, 4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(218, 55)
        Me.btnEnter.TabIndex = 623
        Me.btnEnter.Text = "配方對照表編輯"
        Me.btnEnter.UseVisualStyleBackColor = True
        Me.btnEnter.Visible = False
        '
        'FormRecipe
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.TabControlOption)
        Me.Controls.Add(Me.pnl6Site)
        Me.Controls.Add(Me.lblArrow01Text)
        Me.Controls.Add(Me.lblSiteTime03Text)
        Me.Controls.Add(Me.lblSiteTime02Text)
        Me.Controls.Add(Me.lblSiteTime01Text)
        Me.Controls.Add(Me.lblTotalTime3)
        Me.Controls.Add(Me.lblTotalTime2)
        Me.Controls.Add(Me.lblTotalTime1)
        Me.Controls.Add(Me.btnCopyToAll)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnSaveRecipe)
        Me.Controls.Add(Me.btnLoadRecipe)
        Me.Controls.Add(Me.dgRecipeEdit)
        Me.Controls.Add(Me.lblIn01Text)
        Me.Controls.Add(Me.lblRecipeBasePressureText)
        Me.Controls.Add(Me.btnDelStep)
        Me.Controls.Add(Me.txtRecipeBasePressure)
        Me.Controls.Add(Me.lblRecipeName)
        Me.Controls.Add(Me.lblRecipeNoteText)
        Me.Controls.Add(Me.btnAddStep)
        Me.Controls.Add(Me.lblRecipeFileName)
        Me.Controls.Add(Me.lblPreSetTimeText)
        Me.Controls.Add(Me.txtRecipeNote)
        Me.Controls.Add(Me.chkKeyBoard)
        Me.Controls.Add(Me.lblWaferSizeText)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.txtWaferSize)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.txtDest)
        Me.Controls.Add(Me.btnCopyTo)
        Me.Controls.Add(Me.lblStepTotalTime)
        Me.Controls.Add(Me.lblRecipeStep)
        Me.Controls.Add(Me.lblStepText)
        Me.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 50)
        Me.Name = "FormRecipe"
        Me.Text = "Recipe"
        Me.grpProcessCondition.ResumeLayout(False)
        Me.grpProcessCondition.PerformLayout()
        Me.grpProcessOption.ResumeLayout(False)
        CType(Me.dgRecipeEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMFC01.ResumeLayout(False)
        Me.grpMFC01.PerformLayout()
        Me.grpMFC02.ResumeLayout(False)
        Me.grpMFC02.PerformLayout()
        Me.pnl6Site.ResumeLayout(False)
        CType(Me.picC01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlOption.ResumeLayout(False)
        Me.TabPageOption.ResumeLayout(False)
        Me.TabPageMFC01.ResumeLayout(False)
        Me.TabPageMFC02.ResumeLayout(False)
        Me.TabPagePurge.ResumeLayout(False)
        Me.TabPagePurge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub Recipe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If DesignMode Then Exit Sub
        Dim i As Integer
        Me.Top = FromStartUpTopPosition
        Me.Left = 0
        rwstepindex = 1

        chkKeyBoard.Checked = False
        lblRecipeStep.Text = rwstepindex.ToString
        ReadRecipeColumnData(RecipeINIFile)                     '讀取配方欄位語言資料
        ChangeRecipeColumnHeader(FormRecipes.dgRecipeEdit)      '改變配方欄位語系
        SetVisible(MFC01_USED, grpMFC01)
        SetVisible(MFC02_USED, grpMFC02)
        SetVisible(MAXPLATE > 2, pnl6Site)

        grpMFC01.Text = PLCRValue(DAMFC01Index).Name
        grpMFC02.Text = PLCRValue(DAMFC02Index).Name
        grpMFC01.Text = PLCRValue(DAMFC01Index).Name
        grpMFC02.Text = PLCRValue(DAMFC02Index).Name
        If PURGECOOLING Then
            chkAfterPurge.Visible = False
        End If
        Timer1.Interval = 500
        Timer1.Enabled = True

        X = Me.Width '獲取窗體的寬度
        Y = Me.Height '獲取窗體的高度
        isLoaded = True '已設定各控制項的尺寸到Tag屬性中
        SetTag(Me) '調用方法
        Debug.Print("FormProcess_Load")
    End Sub

    Private Sub txtRecipeNote_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRecipeNote.MouseDown
        CallKeyboard1(sender)
    End Sub
    Public Function ReadRecipeFile(ByVal sfile As String) As Boolean
        Dim i, j, k As Integer
        Dim sstr As String
        i = RecipeEditIndex

        lblRecipeFileName.Text = My.Computer.FileSystem.GetName(sfile)
        sstr = "RECIPE"

        RecipeNum(i).Used = ReadProgData(sstr, "USED", "1", sfile)
        RecipeNum(i).RecipeNote = ReadProgData(sstr, "RECIPE_NOTE", "0", sfile)
        RecipeNum(i).StepSet = ReadProgData(sstr, "PROCESS_STEP", "0", sfile)
        RecipeNum(i).BasePressure = ReadProgData(sstr, "BASE_PRESSURE", "0", sfile)
        RecipeNum(i).WaferSize = ReadProgData(sstr, "WAFER_SIZE", "0", sfile)
        RecipeNum(i).TotalTime = Val(ReadProgData(sstr, "TOTAL_TIME", "0", sfile))

        RecipeNum(i).PumpingMode = ReadProgData(sstr, "VACUUM_MODE", "0", sfile)
        RecipeNum(i).KeepBonding = ReadProgData(sstr, "KEEP_PRESS", "0", sfile)
        RecipeNum(i).BondingSync = Val(ReadProgData(sstr, "BOND_SYNC", "0", sfile))
        RecipeNum(i).VacuumPurge = Val(ReadProgData(sstr, "VACUUM_PURGE", "0", sfile))
        RecipeNum(i).BondBeforeVacuum = ReadProgData(sstr, "BONDBEFOREVACUUM", "0", sfile)

        RecipeNum(i).AutoVent = ReadProgData(sstr, "AUTO_VENT", "0", sfile)
        RecipeNum(i).AfterPurge = ReadProgData(sstr, "AFTERPURGE", "0", sfile)
        RecipeNum(i).AutoDoorOpen = ReadProgData(sstr, "AUTODOOROPEN", "0", sfile)

        RecipeNum(i).MFC01Flow = ReadProgData(sstr, "MFC01FLOW", "0", sfile)
        RecipeNum(i).MFC01ONTime = ReadProgData(sstr, "MFC01ONTIME", "0", sfile)
        RecipeNum(i).MFC01OFFTime = ReadProgData(sstr, "MFC01OFFTIME", "0", sfile)

        RecipeNum(i).MFC02Flow = ReadProgData(sstr, "MFC02FLOW", "0", sfile)
        RecipeNum(i).MFC02ONTime = ReadProgData(sstr, "MFC02ONTIME", "0", sfile)
        RecipeNum(i).MFC02OFFTime = ReadProgData(sstr, "MFC02OFFTIME", "0", sfile)

        'Purge Function 

        RecipeNum(i).PurgeCooling = ReadProgData(sstr, "PURGECOOLING", "0", sfile)
        RecipeNum(i).PurgeCoolingTemp = ReadProgData(sstr, "PURGECOOLINGTEMP", "0", sfile)
        RecipeNum(i).PurgeONTime = ReadProgData(sstr, "PURGEONTIME", "0", sfile)
        RecipeNum(i).PurgeOFFTime = ReadProgData(sstr, "PURGEOFFTIME", "0", sfile)
        RecipeNum(i).PurgeKeepBonding = ReadProgData(sstr, "PURGEKEEPBONDING", "0", sfile)
        chkPurgeCooling.Checked = GetTrue01Boolean(RecipeNum(i).PurgeCooling)
        txtAfterPurgeTemp.Text = RecipeNum(i).PurgeCoolingTemp
        txtPurgeONTime.Text = RecipeNum(i).PurgeONTime
        txtPurgeOFFTime.Text = RecipeNum(i).PurgeOFFTime
        chkPurgeKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).PurgeKeepBonding)



        chkBondBeforeVacuum.Checked = GetTrue01Boolean(RecipeNum(i).BondBeforeVacuum)
        chkKeepBonding.Checked = GetTrue01Boolean(RecipeNum(i).KeepBonding)
        chkVacuumMode.Checked = GetTrue01Boolean(RecipeNum(i).PumpingMode)
        chkVacuumPurge.Checked = GetTrue01Boolean(RecipeNum(i).VacuumPurge)
        chkAutoVent.Checked = GetTrue01Boolean(RecipeNum(i).AutoVent)
        chkAfterPurge.Checked = GetTrue01Boolean(RecipeNum(i).AfterPurge)
        chkAutoDoorOpen.Checked = GetTrue01Boolean(RecipeNum(i).AutoDoorOpen)

        txtMFC01Flow.Text = RecipeNum(i).MFC01Flow
        txtMFCOnTime01.Text = RecipeNum(i).MFC01ONTime
        txtMFCOffTime01.Text = RecipeNum(i).MFC01OFFTime

        txtMFC02Flow.Text = RecipeNum(i).MFC02Flow
        txtMFCOnTime02.Text = RecipeNum(i).MFC02ONTime
        txtMFCOffTime02.Text = RecipeNum(i).MFC02OFFTime

        'radBoth.Checked = False
        'radTemp.Checked = False
        'radPress.Checked = False
        radBoth.Checked = (RecipeNum(i).BondingSync = "0")
        radTemp.Checked = (RecipeNum(i).BondingSync = "1")
        radPress.Checked = (RecipeNum(i).BondingSync = "2")

        txtWaferSize.Text = RecipeNum(i).WaferSize
        txtRecipeNote.Text = RecipeNum(i).RecipeNote
        txtRecipeBasePressure.Text = Format(Val(RecipeNum(i).BasePressure), "0.0E+00")
        lblRecipeStep.Text = RecipeNum(i).StepSet

        TotalStepTime = RecipeNum(i).TotalTime
        rwstepindex = Val(RecipeNum(i).StepSet)
        dgRecipeEdit.ColumnCount = rwstepindex
        dgRecipeEdit.RowCount = Recipe_Num + 1
        Dim ItemIndex As Integer
        For k = 0 To MAXPLATE
            RecipeNum(i).Plate(k).TotalStep = Val(ReadProgData(sstr, "TOTALSTEP", "0", sfile))
            For j = 0 To rwstepindex - 1
                ItemIndex = k * Recipe_Change
                sstr = "STEP" & Format(j + 1, "00")
                'dgRecipeEdit.Column(j).Height = RowHeadersHeight
                dgRecipeEdit.Columns(j).HeaderCell.Value = sstr
                RecipeNum(i).Plate(k).Pressure(j) = Val(ReadProgData(sstr, "PRESS" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Pressure_Rate(j) = Val(ReadProgData(sstr, "PRESS_RATE" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Temperature(j) = Val(ReadProgData(sstr, "TEMP" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Temperature_Rate(j) = Val(ReadProgData(sstr, "TEMP_RATE" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).Time(j) = Val(ReadProgData(sstr, "HOLD_TIME" + Format(k, "00"), "0", sfile))
                RecipeNum(i).Plate(k).STEPNote(j) = ReadProgData(sstr, "NOTE" + Format(k, "00"), "0", sfile)
                RecipeNum(i).Plate(k).StepTime(j) = Val(ReadProgData(sstr, "STEP_TIME" + Format(k, "00"), "0", sfile))

                Try
                    dgRecipeEdit.Item(j, ItemIndex).Value = RecipeNum(i).Plate(k).Pressure(j)
                    'If RecipeNum(i).Plate(k).Pressure(j) < 1 Then
                    '    dgRecipeEdit.Item(j, ItemIndex).Style.BackColor = Color.Pink
                    'Else
                    '    dgRecipeEdit.Item(j, ItemIndex).Style.BackColor = Color.White
                    'End If
                    dgRecipeEdit.Item(j, ItemIndex + 1).Value = RecipeNum(i).Plate(k).Pressure_Rate(j)
                    dgRecipeEdit.Item(j, ItemIndex + 2).Value = RecipeNum(i).Plate(k).Temperature(j)
                    'If RecipeNum(i).Plate(k).Temperature(j) <= RecipeTempLowLimit Then
                    '    dgRecipeEdit.Item(j, ItemIndex + 2).Style.ForeColor = Color.Red
                    'Else
                    '    dgRecipeEdit.Item(j, ItemIndex + 2).Style.ForeColor = Color.Black
                    'End If
                    dgRecipeEdit.Item(j, ItemIndex + 3).Value = RecipeNum(i).Plate(k).Temperature_Rate(j)
                    dgRecipeEdit.Item(j, ItemIndex + 4).Value = RecipeNum(i).Plate(k).Time(j)
                    dgRecipeEdit.Item(j, ItemIndex + 5).Value = RecipeNum(i).Plate(k).STEPNote(j)
                    dgRecipeEdit.Item(j, ItemIndex + 6).Value = RecipeNum(i).Plate(k).StepTime(j)

                Catch ex As Exception
                    MsgBoxLangErr("Recipe Load Error:" + vbCrLf + ex.Message)
                    Return False
                End Try

            Next
        Next
        Cal_StepTime()
        Return True
    End Function



    Private Sub WriteRecipeFile(ByVal index As Integer)
        Dim i, j, k As Integer
        Dim sfile As String
        Dim sstr As String
        i = index

        sfile = RecipeDir + RecipeFileName
        sstr = "RECIPE"

        WriteProgData(sstr, "USED", RecipeNum(i).Used, sfile)
        WriteProgData(sstr, "USER", LoginUserName, sfile)
        WriteProgData(sstr, "RECIPE_NOTE", RecipeNum(i).RecipeNote, sfile)
        WriteProgData(sstr, "PROCESS_STEP", RecipeNum(i).StepSet, sfile)
        WriteProgData(sstr, "BASE_PRESSURE", RecipeNum(i).BasePressure, sfile)
        WriteProgData(sstr, "WAFER_SIZE", RecipeNum(i).WaferSize, sfile)
        WriteProgData(sstr, "TOTAL_TIME", RecipeNum(i).TotalTime, sfile)

        WriteProgData(sstr, "BOND_SYNC", RecipeNum(i).BondingSync, sfile)
        WriteProgData(sstr, "VACUUM_PURGE", RecipeNum(i).VacuumPurge, sfile)
        WriteProgData(sstr, "BONDBEFOREVACUUM", RecipeNum(i).BondBeforeVacuum, sfile)
        WriteProgData(sstr, "VACUUM_MODE", RecipeNum(i).PumpingMode, sfile)
        WriteProgData(sstr, "KEEP_PRESS", RecipeNum(i).KeepBonding, sfile)
        WriteProgData(sstr, "AUTO_VENT", RecipeNum(i).AutoVent, sfile)
        WriteProgData(sstr, "AFTERPURGE", RecipeNum(i).AfterPurge, sfile)
        WriteProgData(sstr, "AUTODOOROPEN", RecipeNum(i).AutoDoorOpen, sfile)

        WriteProgData(sstr, "MFC01FLOW", RecipeNum(i).MFC01Flow, sfile)
        WriteProgData(sstr, "MFC01ONTIME", RecipeNum(i).MFC01ONTime, sfile)
        WriteProgData(sstr, "MFC01OFFTIME", RecipeNum(i).MFC01OFFTime, sfile)

        WriteProgData(sstr, "MFC02FLOW", RecipeNum(i).MFC02Flow, sfile)
        WriteProgData(sstr, "MFC02ONTIME", RecipeNum(i).MFC02ONTime, sfile)
        WriteProgData(sstr, "MFC02OFFTIME", RecipeNum(i).MFC02OFFTime, sfile)


        'Purge Function
        WriteProgData(sstr, "PURGECOOLING", RecipeNum(i).PurgeCooling, sfile)
        WriteProgData(sstr, "PURGECOOLINGTEMP", RecipeNum(i).PurgeCoolingTemp, sfile)
        WriteProgData(sstr, "PURGEONTIME", RecipeNum(i).PurgeONTime, sfile)
        WriteProgData(sstr, "PURGEOFFTIME", RecipeNum(i).PurgeOFFTime, sfile)
        WriteProgData(sstr, "PURGEKEEPBONDING", RecipeNum(i).PurgeKeepBonding, sfile)

        For k = 0 To MAXPLATE
            For j = 0 To rwstepindex - 1
                sstr = "STEP" & Format(j + 1, "00")
                WriteProgData(sstr, "PRESS" + Format(k, "00"), RecipeNum(i).Plate(k).Pressure(j).ToString, sfile)
                WriteProgData(sstr, "PRESS_RATE" + Format(k, "00"), RecipeNum(i).Plate(k).Pressure_Rate(j).ToString, sfile)
                WriteProgData(sstr, "TEMP" + Format(k, "00"), RecipeNum(i).Plate(k).Temperature(j).ToString, sfile)
                WriteProgData(sstr, "TEMP_RATE" + Format(k, "00"), RecipeNum(i).Plate(k).Temperature_Rate(j).ToString, sfile)
                WriteProgData(sstr, "HOLD_TIME" + Format(k, "00"), RecipeNum(i).Plate(k).Time(j).ToString, sfile)
                WriteProgData(sstr, "NOTE" + Format(k, "00"), RecipeNum(i).Plate(k).STEPNote(j), sfile)
                WriteProgData(sstr, "STEP_TIME" + Format(k, "00"), RecipeNum(i).Plate(k).StepTime(j).ToString, sfile)
            Next j
            WriteProgData(sstr, "TOTALSTEP" + Format(k, "00"), RecipeNum(i).Plate(k).TotalStep.ToString, sfile)
            WriteProgData(sstr, "TOTALTIME" + Format(k, "00"), RecipeNum(i).Plate(k).TotalTime.ToString, sfile)
        Next k



        Flush(sfile)
    End Sub
    Private Sub btnSaveRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRecipe.Click
        'save
        Dim i, l, m As Integer
        Dim pressure As Integer = 0
        Dim temp As Integer = 0
        Dim iTimep As Integer = 0
        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim NoValue As Integer
        On Error Resume Next
        Dim sfile As String


        FormKeyInRecipeFileNames.RecipeFileName = ""
        FormKeyInRecipeFileNames.OldRecipeFileName = RecipeName
        If FormKeyInRecipeFileNames.ShowDialog() = Windows.Forms.DialogResult.Cancel Or FormKeyInRecipeFileNames.RecipeFileName = "" Then
            MsgBoxLangOK("檔案未儲存!", "File Not Saved!")
            Exit Sub
        End If
        RecipeName = FormKeyInRecipeFileNames.RecipeFileName
        RecipeFileName = RecipeName + ".RCP"
        RecipeLongFileName = RecipeDir + RecipeFileName
        sfile = RecipeDir + RecipeFileName
        If System.IO.File.Exists(sfile) Then
            If MsgBoxLangYesNo("檔案已存在,要覆蓋嗎?", "File Existed,OverWrite?") = False Then
                Exit Sub
            End If
            System.IO.File.Delete(sfile)
        End If
        lblRecipeFileName.Text = RecipeFileName
        Cal_StepTime()
        i = RecipeEditIndex
        NoValue = 0
        Dim ItemIndex As Integer
        RecipeNum(i).TotalTime = 0
        For k = 0 To MAXPLATE
            If Val(RecipeNum(i).Plate(k).Time(0)) > 0 Then
                RecipeNum(i).Used = "1"
            Else
                RecipeNum(i).Used = "0"
            End If
            RecipeNum(i).TotalTime = TotalTime(k)

            RecipeNum(i).Plate(k).TotalTime = 0
            For j = 0 To rwstepindex - 1
                ItemIndex = k * Recipe_Change
                RecipeNum(i).Plate(k).Pressure(j) = Format(dgRecipeEdit.Item(j, ItemIndex).Value)
                RecipeNum(i).Plate(k).Pressure_Rate(j) = Format(dgRecipeEdit.Item(j, ItemIndex + 1).Value)
                RecipeNum(i).Plate(k).Temperature(j) = Format(dgRecipeEdit.Item(j, ItemIndex + 2).Value)
                RecipeNum(i).Plate(k).Temperature_Rate(j) = Format(dgRecipeEdit.Item(j, ItemIndex + 3).Value)
                RecipeNum(i).Plate(k).Time(j) = Format(dgRecipeEdit.Item(j, ItemIndex + 4).Value)
                RecipeNum(i).Plate(k).STEPNote(j) = Format(dgRecipeEdit.Item(j, ItemIndex + 5).Value)
                RecipeNum(i).Plate(k).StepTime(j) = Format(dgRecipeEdit.Item(j, ItemIndex + 6).Value)
                RecipeNum(i).Plate(k).TotalTime = RecipeNum(i).Plate(k).TotalTime + RecipeNum(i).Plate(k).StepTime(j)
            Next
            m = 0
            For l = 0 To rwstepindex - 1
                If RecipeNum(i).Plate(k).Time(l) > 0 Then
                    RecipeNum(i).Plate(k).TotalStep = l + 1
                End If
            Next

            'If RecipeNum(i).TotalTime < RecipeNum(i).Plate(k).TotalTime Then
            '    RecipeNum(i).TotalTime = RecipeNum(i).TotalTime
            'End If
        Next
        RecipeNum(i).WaferSize = Val(txtWaferSize.Text).ToString
        RecipeNum(i).RecipeNote = txtRecipeNote.Text
        RecipeNum(i).BasePressure = Format(Val(txtRecipeBasePressure.Text), "0.0E+00")
        RecipeNum(i).StepSet = rwstepindex.ToString
        RecipeNum(i).TotalTime = TotalStepTime

        RecipeNum(i).BondBeforeVacuum = GetTrue01String(chkBondBeforeVacuum.Checked)
        RecipeNum(i).KeepBonding = GetTrue01String(chkKeepBonding.Checked)
        RecipeNum(i).VacuumPurge = GetTrue01String(chkVacuumPurge.Checked)
        RecipeNum(i).PumpingMode = GetTrue01String(chkVacuumMode.Checked)
        RecipeNum(i).AutoVent = GetTrue01String(chkAutoVent.Checked)
        RecipeNum(i).AfterPurge = GetTrue01String(chkAfterPurge.Checked)
        RecipeNum(i).AutoDoorOpen = GetTrue01String(chkAutoDoorOpen.Checked)

        RecipeNum(i).MFC01Flow = Val(txtMFC01Flow.Text).ToString
        RecipeNum(i).MFC01ONTime = Val(txtMFCOnTime01.Text).ToString
        RecipeNum(i).MFC01OFFTime = Val(txtMFCOffTime01.Text).ToString

        RecipeNum(i).MFC02Flow = Val(txtMFC02Flow.Text).ToString
        RecipeNum(i).MFC02ONTime = Val(txtMFCOnTime02.Text).ToString
        RecipeNum(i).MFC02OFFTime = Val(txtMFCOffTime02.Text).ToString

        If radBoth.Checked Then RecipeNum(i).BondingSync = "0"
        If radTemp.Checked Then RecipeNum(i).BondingSync = "1"
        If radPress.Checked Then RecipeNum(i).BondingSync = "2"


        'Purge Function
        RecipeNum(i).PurgeCooling = GetTrue01String(chkPurgeCooling.Checked)
        RecipeNum(i).PurgeCoolingTemp = txtAfterPurgeTemp.Text
        RecipeNum(i).PurgeONTime = txtPurgeONTime.Text
        RecipeNum(i).PurgeOFFTime = txtPurgeOFFTime.Text
        RecipeNum(i).PurgeKeepBonding = GetTrue01String(chkPurgeKeepBonding.Checked)

        WriteRecipeFile(i)
    End Sub


    Private Sub btnLoadRecipe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadRecipe.Click
        FormRecipeSelects.RecipeDir = RecipeDir
        If FormRecipeSelects.ShowDialog() = Windows.Forms.DialogResult.OK Then
            RecipeFileName = FormRecipeSelects.RecipeFileName
            If RecipeFileName <> "" Then
                lblRecipeFileName.Text = RecipeFileName
                RecipeFileName = lblRecipeFileName.Text
                RecipeName = Mid(RecipeFileName, 1, InStr(RecipeFileName, ".") - 1)
                RecipeLongFileName = RecipeDir & RecipeFileName
                RecipeLongFileName = FormRecipeSelects.RecipeDir & RecipeFileName
                lblRecipeFileName.Text = RecipeFileName
                ReadRecipeFile(RecipeLongFileName)
                Dim i As Integer
                For i = 0 To rwstepindex - 1
                    dgRecipeEdit.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                    dgRecipeEdit.Columns(i).Width = TableWidth
                Next

            End If

        End If
    End Sub

    Public Sub ShowInit()
        Me.Show()
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer
        'Me.Top = FromStartUpTopPosition
        'Me.Left = 0
        'Cal_StepTime()
        If SystemLanguage <> LanguageChange Then
            For i = 0 To Recipe_Num
                'Select Case SystemLanguage
                '    Case 0
                '        dgRecipeEdit.Rows(i).HeaderCell.Value = RecipeRowHeader(LanguageChange, i)
                '    Case 1
                dgRecipeEdit.Rows(i).HeaderCell.Value = RecipeRowHeader(SystemLanguage, i)
                '    Case 2
                '        dgRecipeEdit.Rows(i).HeaderCell.Value = RecipeRowHeader(LanguageChange, i)
                'End Select
                LanguageChange = SystemLanguage
            Next

        End If
        If (MFC01_USED And (Val(txtMFC01Flow.Text) > 0)) Then
            chkAfterPurge.Checked = True
        End If
        If (MFC02_USED And (Val(txtMFC02Flow.Text) > 0)) Then
            chkAfterPurge.Checked = True
        End If
        ObjShow.Show(RecipePage = 0, btnPrev, Color.Lime, System.Drawing.SystemColors.Control)
        ObjShow.Show(RecipePage = 1, btnNext, Color.Lime, System.Drawing.SystemColors.Control)

        If rwstepindex > 5 Then
            dgRecipeEdit.Height = TableHeight * (Recipe_Change * 3) + dgRecipeEdit.ColumnHeadersHeight + 20
        Else
            dgRecipeEdit.Height = TableHeight * (Recipe_Change * 3) + dgRecipeEdit.ColumnHeadersHeight + 3
        End If
        If Val(txtRecipeBasePressure.Text) >= 760 Then
            chkVacuumMode.Checked = False
        Else
            chkVacuumMode.Checked = True
        End If

        'Purge Cooling
        If PURGECOOLING Then
            chkAfterPurge.Visible = False
        End If
        If chkPurgeCooling.Checked Then
            chkAfterPurge.Checked = False
        End If
        txtAfterPurgeTemp.Enabled = chkPurgeCooling.Checked
        If chkPurgeCooling.Checked Then
            txtPurgeONTime.Enabled = True
            txtPurgeOFFTime.Enabled = True
        Else
            txtPurgeONTime.Enabled = False
            txtPurgeOFFTime.Enabled = False
        End If
        Cal_StepTime()
    End Sub

    Private Sub txtWaferSize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtWaferSize.MouseDown
        CallKeyboard2(sender, WAFERSIZE_MAX, WAFERSIZE_MIN)
    End Sub

    Private Sub txtRecipeBasePressure_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtRecipeBasePressure.MouseDown
        CallKeyboard3(sender, VACUUM_MAX, VACUUM_MIN)
        sender.text = Format(Val(sender.Text), "0.0E+00")
    End Sub



    Private Sub dgRecipeEdit_CellMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgRecipeEdit.CellMouseDown
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Exit Sub
        End If
        DataGridViewInput(sender, e.ColumnIndex, e.RowIndex)


    End Sub

    Private Sub DataGridViewInput(ByRef sender As DataGridView, ByVal col As Integer, ByVal row As Integer)
        Dim txtInputTemp As New TextBox
        Dim index As Integer
        Dim i As Integer
        If col < 0 Or row < 0 Then
            Exit Sub
        End If
        'txtInputTemp.Text = dgRecipeEdit.Item(e.ColumnIndex, e.RowIndex).Value
        'If row < 2 Then
        '    index = row + 10
        'Else
        '    index = row - 2
        'End If

        index = row Mod Recipe_Change
        Select Case index
            'Case 0  ' Input Press
            '    CallKeyboard2(sender, col, row, PLCRValue(DAMFC01Index).Max, PLCRValue(DAMFC01Index).Min)
            'Case 1  'Input PressRate
            '    CallKeyboard2(sender, col, row, PLCRValue(DAMFC02Index).Max, PLCRValue(DAMFC02Index).Min)
            Case 0  ' Input Press
                CallKeyboard2(sender, col, row, PRESS_MAX, PRESS_MIN)
            Case 1  'Input PressRate
                CallKeyboard2(sender, col, row, PRESSRATE_MAX, PRESSRATE_MIN)
            Case 2  'Input Temp
                CallKeyboard2(sender, col, row, TEMP_MAX, TEMP_MIN)
                If Val(sender.Item(col, row).Value) <= RecipeTempLowLimit Then
                    MsgBoxLangErr("溫度低於30度,不加溫!", "Temp. lower tha 30, Heater Disable!")
                    'dgRecipeEdit.Rows(row).Cells(col).Style.ForeColor = Color.Red
                Else
                    'dgRecipeEdit.Rows(row).Cells(col).Style.ForeColor = Color.Black
                End If
            Case 3  'Input Temp Rate
                Dim max As String
                If CelloUsbFlag Then
                    max = "20"
                Else
                    max = TEMPRATE_MAX
                End If
                CallKeyboard2(sender, col, row, max, TEMPRATE_MIN)
            Case 4  'Input Hole Time
                CallKeyboard2(sender, col, row, NORMAL_MAX, NORMAL_MIN)
            Case 5  'Input Note
                CallKeyboard1(sender, col, row)
        End Select

        'Dim i, s As Integer
        's = 0
        'For i = 0 To 5
        '    If Val(dgRecipeEdit.Item(col, i).Value) > 0 Then
        '        s = s + 1
        '    End If
        'Next
        'If s >= 5 Then Cal_StepTime()
        Dim h As Integer
        For h = 0 To MAXPLATE
            Cal_StepTime(sender, h)
        Next
    End Sub

    Private Sub btnAddStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStep.Click
        AddStep()
        Cal_StepTime()
    End Sub


    Public Sub AddStep()
        Dim col_index As Integer
        If rwstepindex < Recipe_Max Then
            rwstepindex += 1
            col_index = rwstepindex - 1
            dgRecipeEdit.ColumnCount = rwstepindex
            dgRecipeEdit.Columns(col_index).Width = TableWidth
            dgRecipeEdit.Columns(col_index).Name = "Step " + Format(rwstepindex, "00")
            dgRecipeEdit.Columns(col_index).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            dgRecipeEdit.Columns(col_index).SortMode = DataGridViewColumnSortMode.NotSortable
            dgRecipeEdit.Columns(col_index).SortMode = DataGridViewColumnSortMode.NotSortable
            lblRecipeStep.Text = rwstepindex.ToString
            Dim i As Integer
            For i = 0 To TableMax - 1
                dgRecipeEdit.Item(col_index, i).Value = dgRecipeEdit.Item(col_index - 1, i).Value
                dgRecipeEdit.Rows(i).Cells(col_index).Style.ForeColor = dgRecipeEdit.Rows(i).Cells(col_index - 1).Style.ForeColor
            Next
            dgRecipeEdit.Item(col_index, 0).Selected = True
            dgRecipeEdit.CurrentCell = dgRecipeEdit(col_index, 0)
            dgRecipeEdit.FirstDisplayedScrollingColumnIndex = col_index
            i = col_index
            SetRecipePage(RecipePage, dgRecipeEdit)
        End If
    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Dim i As Integer
        If RecipePage > 0 Then RecipePage -= 1
        SetRecipePage(RecipePage, dgRecipeEdit)
        ObjShow.Show(RecipePage = 0, btnPrev, Color.Lime, System.Drawing.SystemColors.Control)
        ObjShow.Show(RecipePage = 1, btnNext, Color.Lime, System.Drawing.SystemColors.Control)

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Dim i As Integer
        If RecipePage < 1 Then RecipePage += 1
        SetRecipePage(RecipePage, dgRecipeEdit)
        ObjShow.Show(RecipePage = 0, btnPrev, Color.Lime, System.Drawing.SystemColors.Control)
        ObjShow.Show(RecipePage = 1, btnNext, Color.Lime, System.Drawing.SystemColors.Control)

    End Sub
    Private Sub SetRecipePage(ByVal page As Integer, ByRef sender As DataGridView)
        Try
            Select Case page
                Case 0
                    dgRecipeEdit.CurrentCell = dgRecipeEdit(dgRecipeEdit.CurrentCell.ColumnIndex, 0)
                Case 1
                    dgRecipeEdit.CurrentCell = dgRecipeEdit(dgRecipeEdit.CurrentCell.ColumnIndex, Recipe_Num)
                    dgRecipeEdit.CurrentCell = dgRecipeEdit(dgRecipeEdit.CurrentCell.ColumnIndex, 23)
                    'Case 2
                    '    dgRecipeEdit.CurrentCell = dgRecipeEdit(dgRecipeEdit.CurrentCell.ColumnIndex, 59)
                    '    dgRecipeEdit.CurrentCell = dgRecipeEdit(dgRecipeEdit.CurrentCell.ColumnIndex, 40)
                    'Case 3
                    '    dgRecipeEdit.CurrentCell = dgRecipeEdit(dgRecipeEdit.CurrentCell.ColumnIndex, 79)
                    '    dgRecipeEdit.CurrentCell = dgRecipeEdit(dgRecipeEdit.CurrentCell.ColumnIndex, 60)
            End Select
        Catch ex As Exception
            MsgBoxLangErr("Change Page Error:" + vbCrLf + ex.Message)

        End Try '


    End Sub

    Private Sub btnDelStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelStep.Click
        If rwstepindex > 1 Then
            rwstepindex -= 1

            dgRecipeEdit.ColumnCount = rwstepindex
            dgRecipeEdit.Item(rwstepindex - 1, 0).Selected = True
            lblRecipeStep.Text = rwstepindex.ToString
        End If
    End Sub

    Dim tempT(Recipe_Max) As Single
    Dim tempTR(Recipe_Max) As Single
    Dim tempP(Recipe_Max) As Single
    Dim tempPR(Recipe_Max) As Single
    Dim tempH(Recipe_Max) As Single
    Public Sub ClearStepTime()
        Dim i As Integer
        For i = 0 To Recipe_Max
            tempP(i) = 0
            tempPR(i) = 0
            tempT(i) = 0
            tempTR(i) = 0
            tempH(i) = 0
            StepTime(i) = 0
        Next
    End Sub
    Public TotalTime(5) As Integer
    Private Sub Cal_StepTime()
        Dim h As Integer
        TotalStepTime = 0
        For h = 0 To MAXPLATE
            TotalTime(h) = Cal_StepTime(dgRecipeEdit, h)
            If TotalTime(h) > TotalStepTime Then TotalStepTime = TotalTime(h)
        Next
        lblTotalTime1.Text = TotalTime(0).ToString + "/(" + ConvertSecToTime(TotalTime(0)) + ")"
        lblTotalTime2.Text = TotalTime(1).ToString + "/(" + ConvertSecToTime(TotalTime(1)) + ")"
        lblTotalTime3.Text = TotalTime(2).ToString + "/(" + ConvertSecToTime(TotalTime(2)) + ")"
        lblTotalTime4.Text = TotalTime(3).ToString + "/(" + ConvertSecToTime(TotalTime(3)) + ")"
        lblTotalTime5.Text = TotalTime(4).ToString + "/(" + ConvertSecToTime(TotalTime(4)) + ")"
        lblTotalTime6.Text = TotalTime(5).ToString + "/(" + ConvertSecToTime(TotalTime(5)) + ")"
        lblStepTotalTime.Text = TotalStepTime.ToString + "/(" + ConvertSecToTime(TotalStepTime) + ")"
        'Dim i As Integer
        'Dim j As Integer
        'On Error Resume Next
        'ClearStepTime()
        'For i = 0 To rwstepindex - 1
        '    tempP(i) = CType(dgRecipeEdit.Item(0, i).Value, Single)
        '    tempPR(i) = CType(dgRecipeEdit.Item(1, i).Value, Single)
        '    tempT(i) = CType(dgRecipeEdit.Item(2, i).Value, Single)
        '    tempTR(i) = CType(dgRecipeEdit.Item(3, i).Value, Single)
        '    tempH(i) = CType(dgRecipeEdit.Item(4, i).Value, Single)
        'Next
        'TotalStepTime = 0
        'i = 0
        'StepTime(i) = GetStepTimeI0(tempP(i), tempPR(i), tempT(i), tempTR(i), tempH(i))
        'dgRecipeEdit.Item(6, i).Value = StepTime(i)
        'TotalStepTime = TotalStepTime + StepTime(i)
        'If rwstepindex > 1 Then
        '    For i = 1 To rwstepindex - 1
        '        StepTime(i) = GetStepTimeI(tempP(i), tempPR(i), tempT(i), tempTR(i), tempH(i), tempP(i - 1), tempT(i - 1))
        '        dgRecipeEdit.Item(6, i).Value = StepTime(i)
        '        TotalStepTime = TotalStepTime + StepTime(i)
        '    Next

        'End If
        'lblStepTotalTime.Text = ConvertSecToTime(TotalStepTime)
    End Sub
    Private Function Cal_StepTime(ByVal dg As DataGridView, ByVal Index As Integer) As Integer
        Dim i As Integer
        Dim j As Integer
        Dim TstepTime As Integer
        On Error Resume Next
        ClearStepTime()

        For i = 0 To rwstepindex - 1
            tempP(i) = Val(dg.Item(i, Index * Recipe_Change).Value)
            tempPR(i) = Val(dg.Item(i, Index * Recipe_Change + 1).Value)
            tempT(i) = Val(dg.Item(i, Index * Recipe_Change + 2).Value)
            tempTR(i) = Val(dg.Item(i, Index * Recipe_Change + 3).Value)
            tempH(i) = Val(dg.Item(i, Index * Recipe_Change + 4).Value)
            'StepTime(i) = GetStepTimeI0(tempP(i), tempPR(i), tempT(i), tempTR(i), tempH(i))
            'dg.Item(i, Index * Recipe_Change + 6).Value = StepTime(i)
        Next
        StepTime(0) = GetStepTimeI0(tempP(0), tempPR(0), tempT(0), tempTR(0), tempH(0))

        TstepTime = 0
        i = 0
        StepTime(i) = GetStepTimeI0(tempP(i), tempPR(i), tempT(i), tempTR(i), tempH(i))
        dg.Item(i, Index * Recipe_Change + 6).Value = StepTime(i)
        TstepTime = TstepTime + StepTime(i)
        If rwstepindex > 1 Then
            For i = 1 To rwstepindex - 1
                StepTime(i) = GetStepTimeI(tempP(i), tempPR(i), tempT(i), tempTR(i), tempH(i), tempP(i - 1), tempT(i - 1))
                dg.Item(i, Index * Recipe_Change + 6).Value = StepTime(i)
                TstepTime = TstepTime + StepTime(i)
            Next
        End If
        Return TstepTime
    End Function

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cal_StepTime()
    End Sub

    Private Sub chkKeyBoard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKeyBoard.CheckedChanged
        If chkKeyBoard.Checked = True Then
            dgRecipeEdit.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            dgRecipeEdit.EditMode = DataGridViewEditMode.EditProgrammatically
        End If
    End Sub
    '更新配方時間
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cal_StepTime()
    End Sub

    ''COPY 到 目標STEP
    'Private Sub btnCopyTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyTo.Click
    '    StepCopyTo(Val(txtSource.Text) - 1, Val(txtDest.Text) - 1)
    'End Sub
    'COPY 到 目標STEP

    Private Sub btnCopyToAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyToAll.Click
        StepCopyTo(Val(txtSource.Text) - 1, Val(txtDest.Text) - 1, Recipe_Change, True)
    End Sub
    Private Sub btnCopyTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyTo.Click
        StepCopyTo(Val(txtSource.Text) - 1, Val(txtDest.Text) - 1, Recipe_Change)
    End Sub
    Public Sub StepCopyTo(ByVal CopySourceIndex As Integer, ByVal CopyDestIndex As Integer, ByVal RecipeCount As Integer, Optional ByVal ToAll As Boolean = False)
        Dim i, j, k, l As Integer
        Dim cht, chs, eng As String
        Dim MaxCount As Integer
        Dim Hcount As Integer
        Dim ItemIndex As Integer

        If ToAll Then
            cht = "由Site " + txtSource.Text + " 複製到全部,確定?"
            chs = StrConv(cht, VbStrConv.SimplifiedChinese, 2052)
            eng = "Copy Site " + txtSource.Text + " To All Site , OK?"
            MaxCount = MAXPLATE
        Else
            cht = "由 Site " + txtSource.Text + " 複製到 Site " + txtDest.Text + ",確定?"
            chs = StrConv(cht, VbStrConv.SimplifiedChinese, 2052)
            eng = "Copy Site " + txtSource.Text + " To Site " + txtDest.Text + ", OK?"
            MaxCount = 0
        End If
        Hcount = RecipeCount - 1
        If Hcount < 0 Then Hcount = 0

        If CopySourceIndex < 0 Then CopySourceIndex = 0
        If CopyDestIndex < 0 Then CopyDestIndex = 0

        If MsgBoxLangYesNo(cht, chs, eng) Then
            Try
                For j = 0 To dgRecipeEdit.ColumnCount - 1
                    For k = 0 To MaxCount
                        If ToAll Then
                            CopyDestIndex = k
                        End If
                        For i = 0 To RecipeCount - 1
                            dgRecipeEdit.Item(j, RecipeCount * CopyDestIndex + i).Value = dgRecipeEdit.Item(j, RecipeCount * (CopySourceIndex) + i).Value
                            'dgRecipeEdit.Item(j, Hcount * (CopyDestIndex) + 1).Value = dgRecipeEdit.Item(j, Hcount * (CopySourceIndex) + 1).Value
                            'dgRecipeEdit.Item(j, Hcount * (CopyDestIndex) + 2).Value = dgRecipeEdit.Item(j, Hcount * (CopySourceIndex) + 2).Value
                            'dgRecipeEdit.Item(j, Hcount * (CopyDestIndex) + 3).Value = dgRecipeEdit.Item(j, Hcount * (CopySourceIndex) + 3).Value
                            'dgRecipeEdit.Item(j, Hcount * (CopyDestIndex) + 4).Value = dgRecipeEdit.Item(j, Hcount * (CopySourceIndex) + 4).Value
                            'dgRecipeEdit.Item(j, Hcount * (CopyDestIndex) + 5).Value = dgRecipeEdit.Item(j, Hcount * (CopySourceIndex) + 5).Value
                            'dgRecipeEdit.Item(j, Hcount * (CopyDestIndex) + 6).Value = dgRecipeEdit.Item(j, Hcount * (CopySourceIndex) + 6).Value
                        Next
                    Next
                Next
            Catch ex As Exception
                MsgBoxLangErr(" Recipe Copy Error:" + vbCrLf + ex.Message)
            End Try
        End If
    End Sub


    '刪除 STEP
    Private Sub txtDelStepSet_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        CallKeyboard2(sender, rwstepindex.ToString, "1")

    End Sub

    'COPY 來源STEP
    Private Sub txtSource_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtSource.MouseDown
        CallKeyboard2(sender, (MAXPLATE + 1).ToString, "1")

    End Sub
    'COPY 目標STEP 輸入
    Private Sub txtDest_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtDest.MouseDown
        CallKeyboard2(sender, (MAXPLATE + 1).ToString, "1")
    End Sub


    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        Dim i, j As Integer
        Dim cht, chs, eng As String
        cht = "清除全部配方,確定?"
        chs = StrConv(cht, VbStrConv.SimplifiedChinese, 2052)
        eng = "Clear All Recipe, OK?"
        If MsgBoxLangYesNo(cht, chs, eng) Then
            dgRecipeEdit.ColumnCount = 1
            rwstepindex = dgRecipeEdit.ColumnCount
            lblRecipeStep.Text = rwstepindex.ToString
            i = 0
            For j = 0 To MAXPLATE
                dgRecipeEdit.Item(i, j * Recipe_Change + Recipe_Col.PRESSURE).Value = "0"
                dgRecipeEdit.Item(i, j * Recipe_Change + Recipe_Col.P_RATE).Value = "0"
                dgRecipeEdit.Item(i, j * Recipe_Change + Recipe_Col.TEMP).Value = "0"
                dgRecipeEdit.Item(i, j * Recipe_Change + Recipe_Col.TEMP_RATE).Value = "0"
                dgRecipeEdit.Item(i, j * Recipe_Change + Recipe_Col.HOLD_TIME).Value = "0"
                dgRecipeEdit.Item(i, j * Recipe_Change + Recipe_Col.NOTE).Value = ""
                dgRecipeEdit.Item(i, j * Recipe_Change + Recipe_Col.PRE_SET).Value = "0"
            Next
            For j = 0 To TableMax - 1
                dgRecipeEdit.Rows(j).Cells(0).Style.ForeColor = Color.Black
            Next

        End If
    End Sub

    Private Sub txtMFC01Flow_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMFC01Flow.MouseDown
        CallKeyboard2(sender, PLCRValue(DAMFC01Index).Max, "0")
        If Val(txtMFC01Flow.Text) > 0 Or Val(txtMFC02Flow.Text) > 0 Then chkAfterPurge.Checked = True
    End Sub

    Private Sub txtMFCOffTime01_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMFCOffTime01.MouseDown
        CallKeyboard2(sender, "9999", "0")
    End Sub

    Private Sub txtMFCOnTime01_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMFCOnTime01.MouseDown
        CallKeyboard2(sender, "9999", "0")
    End Sub

    Private Sub txtMFC02Flow_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMFC02Flow.MouseDown
        CallKeyboard2(sender, PLCRValue(DAMFC02Index).Max, "0")
        If Val(txtMFC01Flow.Text) > 0 Or Val(txtMFC02Flow.Text) > 0 Then chkAfterPurge.Checked = True
    End Sub

    Private Sub txtMFCOffTime02_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMFCOffTime02.MouseDown
        CallKeyboard2(sender, "9999", "0")
    End Sub

    Private Sub txtMFCOnTime02_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMFCOnTime02.MouseDown
        CallKeyboard2(sender, "9999", "0")
    End Sub

    Private Sub chkPurgeCooling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPurgeCooling.Click
        If chkPurgeCooling.Checked Then
            chkAfterPurge.Checked = False
        End If
    End Sub

    Private Sub txtAfterPurgeTemp_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtAfterPurgeTemp.MouseDown
        FormKeyboard2s.KeyInString(sender, "500", "25")
    End Sub

    Private Sub txtPurgeONTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPurgeONTime.MouseDown
        FormKeyboard2s.KeyInString(sender, "99999", "1")
    End Sub

    Private Sub txtPurgeOFFTime_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPurgeOFFTime.MouseDown
        FormKeyboard2s.KeyInString(sender, "99999", "1")
    End Sub

    Private Sub chkAfterPurge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAfterPurge.Click
        If chkAfterPurge.Checked Then
            chkPurgeCooling.Checked = False
        End If
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        RecipeMapEditor.txtBarcode.Text = ""
        RecipeMapEditor.txtBarcode.Focus()
        RecipeMapEditor.txtBarcode.Select()
        RecipeMapEditor.RefreshData()
        RecipeMapEditor.ShowDialog()
    End Sub

    Private Sub FormRecipe_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If isLoaded Then

            'Dim new_x As Single = FormW / X
            'Dim new_Y As Single = (FormH - FromStartUpTopPosition) / Y
            Me.Height = (FormW - FromStartUpTopPosition)
            Me.Width = FormW
            SetControls(NewX_sub, NewY_sub, Me, isLoaded)
            Debug.Print("Form1_Resize  ,Me.Width=" + Me.Width.ToString + ",Me.Height=" + Me.Height.ToString)
        End If
    End Sub

    Private Sub FormRecipe_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FormW = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        FormH = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height

        Me.WindowState = FormWindowState.Normal
        FormRecipe_Resize(Me, e)
        'Debug.Print("Form1_Shown" + ",screen.Width=" + FormW.ToString + ",screen.Height=" + FormH.ToString)
    End Sub
End Class
