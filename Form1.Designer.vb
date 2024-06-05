<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblPro = New System.Windows.Forms.Label()
        Me.lblMines = New System.Windows.Forms.Label()
        Me.lblProTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PnlBoard = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Beginner9910ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Intermediate161640ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Expert301699ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTitle.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.Controls.Add(Me.btnReset)
        Me.pnlTitle.Controls.Add(Me.lblPro)
        Me.pnlTitle.Controls.Add(Me.lblMines)
        Me.pnlTitle.Controls.Add(Me.lblProTitle)
        Me.pnlTitle.Controls.Add(Me.Label2)
        Me.pnlTitle.Controls.Add(Me.LblTitle)
        Me.pnlTitle.Location = New System.Drawing.Point(17, 40)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(450, 110)
        Me.pnlTitle.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(191, 70)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(69, 37)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblPro
        '
        Me.lblPro.Font = New System.Drawing.Font("Harlow Solid Italic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPro.Location = New System.Drawing.Point(353, 45)
        Me.lblPro.Name = "lblPro"
        Me.lblPro.Size = New System.Drawing.Size(94, 56)
        Me.lblPro.TabIndex = 4
        Me.lblPro.Text = "[]"
        Me.lblPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMines
        '
        Me.lblMines.Font = New System.Drawing.Font("Harlow Solid Italic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMines.Location = New System.Drawing.Point(3, 45)
        Me.lblMines.Name = "lblMines"
        Me.lblMines.Size = New System.Drawing.Size(94, 56)
        Me.lblMines.TabIndex = 3
        Me.lblMines.Text = "[]"
        Me.lblMines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProTitle
        '
        Me.lblProTitle.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProTitle.Location = New System.Drawing.Point(353, 10)
        Me.lblProTitle.Name = "lblProTitle"
        Me.lblProTitle.Size = New System.Drawing.Size(94, 35)
        Me.lblProTitle.TabIndex = 2
        Me.lblProTitle.Text = "Progress"
        Me.lblProTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mines"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTitle
        '
        Me.LblTitle.Font = New System.Drawing.Font("Harlow Solid Italic", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(103, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(245, 91)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Minesweeper"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlBoard
        '
        Me.PnlBoard.Location = New System.Drawing.Point(17, 170)
        Me.PnlBoard.Name = "PnlBoard"
        Me.PnlBoard.Size = New System.Drawing.Size(450, 450)
        Me.PnlBoard.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DifficultyToolStripMenuItem, Me.GameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Beginner9910ToolStripMenuItem, Me.Intermediate161640ToolStripMenuItem, Me.Expert301699ToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(69, 21)
        Me.DifficultyToolStripMenuItem.Text = "Difficulty"
        '
        'Beginner9910ToolStripMenuItem
        '
        Me.Beginner9910ToolStripMenuItem.Name = "Beginner9910ToolStripMenuItem"
        Me.Beginner9910ToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.Beginner9910ToolStripMenuItem.Text = "Beginner (9-9-10)"
        '
        'Intermediate161640ToolStripMenuItem
        '
        Me.Intermediate161640ToolStripMenuItem.Name = "Intermediate161640ToolStripMenuItem"
        Me.Intermediate161640ToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.Intermediate161640ToolStripMenuItem.Text = "Intermediate (16-16-40)"
        '
        'Expert301699ToolStripMenuItem
        '
        Me.Expert301699ToolStripMenuItem.Name = "Expert301699ToolStripMenuItem"
        Me.Expert301699ToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.Expert301699ToolStripMenuItem.Text = "Expert (30-16-99)"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.CheatToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(54, 21)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'CheatToolStripMenuItem
        '
        Me.CheatToolStripMenuItem.Name = "CheatToolStripMenuItem"
        Me.CheatToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CheatToolStripMenuItem.Text = "Cheat"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 641)
        Me.Controls.Add(Me.PnlBoard)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Minesweeper"
        Me.pnlTitle.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents PnlBoard As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DifficultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Beginner9910ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Intermediate161640ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Expert301699ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblTitle As Label
    Friend WithEvents lblPro As Label
    Friend WithEvents lblMines As Label
    Friend WithEvents lblProTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents CheatToolStripMenuItem As ToolStripMenuItem
End Class
