<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRst = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCmd = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IPアドレス"
        '
        'txtIP
        '
        Me.txtIP.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtIP.Location = New System.Drawing.Point(161, 65)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(280, 30)
        Me.txtIP.TabIndex = 1
        '
        'txtPort
        '
        Me.txtPort.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtPort.Location = New System.Drawing.Point(161, 116)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(127, 30)
        Me.txtPort.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ポート番号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "コマンド"
        '
        'txtRst
        '
        Me.txtRst.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtRst.Location = New System.Drawing.Point(160, 370)
        Me.txtRst.Multiline = True
        Me.txtRst.Name = "txtRst"
        Me.txtRst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRst.Size = New System.Drawing.Size(281, 148)
        Me.txtRst.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSend.Location = New System.Drawing.Point(342, 304)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(99, 33)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "発行"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(88, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "結果"
        '
        'txtCmd
        '
        Me.txtCmd.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtCmd.Location = New System.Drawing.Point(161, 169)
        Me.txtCmd.Multiline = True
        Me.txtCmd.Name = "txtCmd"
        Me.txtCmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCmd.Size = New System.Drawing.Size(280, 129)
        Me.txtCmd.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClear.Location = New System.Drawing.Point(219, 304)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(99, 33)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 549)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtCmd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtRst)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRst As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCmd As TextBox
    Friend WithEvents btnClear As Button
End Class
