<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiceCricket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDiceCricket))
        Me.btnAddName = New System.Windows.Forms.Button()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMessages = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtInsertName = New System.Windows.Forms.TextBox()
        Me.txtRolls = New System.Windows.Forms.TextBox()
        Me.btnNextGame = New System.Windows.Forms.Button()
        Me.lblLeaderboard = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddName
        '
        Me.btnAddName.Location = New System.Drawing.Point(12, 63)
        Me.btnAddName.Name = "btnAddName"
        Me.btnAddName.Size = New System.Drawing.Size(75, 24)
        Me.btnAddName.TabIndex = 0
        Me.btnAddName.Text = "Add name"
        Me.btnAddName.UseVisualStyleBackColor = True
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(12, 165)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 0
        Me.btnRoll.Text = "Next roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Player name:"
        '
        'lblMessages
        '
        Me.lblMessages.Location = New System.Drawing.Point(12, 201)
        Me.lblMessages.Name = "lblMessages"
        Me.lblMessages.Size = New System.Drawing.Size(87, 208)
        Me.lblMessages.TabIndex = 1
        Me.lblMessages.Text = "Let's play dice cricket!"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(62, 536)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(105, 536)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(131, 23)
        Me.txtTotal.TabIndex = 2
        '
        'txtInsertName
        '
        Me.txtInsertName.Location = New System.Drawing.Point(12, 34)
        Me.txtInsertName.Name = "txtInsertName"
        Me.txtInsertName.Size = New System.Drawing.Size(224, 23)
        Me.txtInsertName.TabIndex = 2
        '
        'txtRolls
        '
        Me.txtRolls.Location = New System.Drawing.Point(105, 165)
        Me.txtRolls.Multiline = True
        Me.txtRolls.Name = "txtRolls"
        Me.txtRolls.Size = New System.Drawing.Size(131, 365)
        Me.txtRolls.TabIndex = 2
        '
        'btnNextGame
        '
        Me.btnNextGame.Location = New System.Drawing.Point(161, 63)
        Me.btnNextGame.Name = "btnNextGame"
        Me.btnNextGame.Size = New System.Drawing.Size(75, 24)
        Me.btnNextGame.TabIndex = 0
        Me.btnNextGame.Text = "Next game"
        Me.btnNextGame.UseVisualStyleBackColor = True
        '
        'lblLeaderboard
        '
        Me.lblLeaderboard.AutoSize = True
        Me.lblLeaderboard.Location = New System.Drawing.Point(12, 409)
        Me.lblLeaderboard.Name = "lblLeaderboard"
        Me.lblLeaderboard.Size = New System.Drawing.Size(76, 15)
        Me.lblLeaderboard.TabIndex = 1
        Me.lblLeaderboard.Text = "Leaderboard:"
        '
        'frmDiceCricket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 579)
        Me.Controls.Add(Me.txtRolls)
        Me.Controls.Add(Me.txtInsertName)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLeaderboard)
        Me.Controls.Add(Me.lblMessages)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.btnNextGame)
        Me.Controls.Add(Me.btnAddName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDiceCricket"
        Me.Text = "Dice cricket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddName As Button
    Friend WithEvents btnRoll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMessages As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtInsertName As TextBox
    Friend WithEvents txtRolls As TextBox
    Friend WithEvents btnNextGame As Button
    Friend WithEvents lblLeaderboard As Label
End Class
