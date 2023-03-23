<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control_Datalogview
    Inherits System.Windows.Forms.UserControl

    'UserControl 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgDatalogView = New System.Windows.Forms.DataGridView
        Me.RichTextProcessRecord = New System.Windows.Forms.RichTextBox
        Me.lblStatus = New System.Windows.Forms.Label
        CType(Me.dgDatalogView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDatalogView
        '
        Me.dgDatalogView.AllowUserToAddRows = False
        Me.dgDatalogView.AllowUserToDeleteRows = False
        Me.dgDatalogView.AllowUserToResizeColumns = False
        Me.dgDatalogView.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDatalogView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDatalogView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgDatalogView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDatalogView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDatalogView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgDatalogView.ColumnHeadersHeight = 30
        Me.dgDatalogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgDatalogView.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.NullValue = "0"
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDatalogView.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgDatalogView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgDatalogView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgDatalogView.GridColor = System.Drawing.Color.Brown
        Me.dgDatalogView.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dgDatalogView.Location = New System.Drawing.Point(0, 98)
        Me.dgDatalogView.MultiSelect = False
        Me.dgDatalogView.Name = "dgDatalogView"
        Me.dgDatalogView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.NullValue = "0"
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDatalogView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgDatalogView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgDatalogView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgDatalogView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDatalogView.RowTemplate.DefaultCellStyle.NullValue = "-"
        Me.dgDatalogView.RowTemplate.DividerHeight = 1
        Me.dgDatalogView.RowTemplate.Height = 30
        Me.dgDatalogView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDatalogView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgDatalogView.Size = New System.Drawing.Size(1012, 368)
        Me.dgDatalogView.TabIndex = 538
        '
        'RichTextProcessRecord
        '
        Me.RichTextProcessRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextProcessRecord.Dock = System.Windows.Forms.DockStyle.Top
        Me.RichTextProcessRecord.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextProcessRecord.Location = New System.Drawing.Point(0, 0)
        Me.RichTextProcessRecord.Name = "RichTextProcessRecord"
        Me.RichTextProcessRecord.Size = New System.Drawing.Size(1012, 69)
        Me.RichTextProcessRecord.TabIndex = 533
        Me.RichTextProcessRecord.Text = ""
        Me.RichTextProcessRecord.WordWrap = False
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(1, 70)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(1008, 27)
        Me.lblStatus.TabIndex = 539
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Control_Datalogview
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.dgDatalogView)
        Me.Controls.Add(Me.RichTextProcessRecord)
        Me.Name = "Control_Datalogview"
        Me.Size = New System.Drawing.Size(1012, 466)
        CType(Me.dgDatalogView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDatalogView As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextProcessRecord As System.Windows.Forms.RichTextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
