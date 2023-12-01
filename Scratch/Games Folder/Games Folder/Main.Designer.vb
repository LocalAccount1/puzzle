<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.rightPanel = New System.Windows.Forms.Panel()
        Me.settingsBtn = New FontAwesome.Sharp.IconButton()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.framePanel = New System.Windows.Forms.Panel()
        Me.usernameBtn = New FontAwesome.Sharp.IconButton()
        Me.topRightPanel = New System.Windows.Forms.Panel()
        Me.bottomRightPanel = New System.Windows.Forms.Panel()
        Me.middleRightPanel = New System.Windows.Forms.Panel()
        Me.mazeBtn = New FontAwesome.Sharp.IconButton()
        Me.rpgBtn = New FontAwesome.Sharp.IconButton()
        Me.chessBtn = New FontAwesome.Sharp.IconButton()
        Me.rightPanel.SuspendLayout()
        Me.leftPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.framePanel.SuspendLayout()
        Me.topRightPanel.SuspendLayout()
        Me.bottomRightPanel.SuspendLayout()
        Me.middleRightPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'rightPanel
        '
        Me.rightPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.rightPanel.Controls.Add(Me.bottomRightPanel)
        Me.rightPanel.Controls.Add(Me.topRightPanel)
        Me.rightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.rightPanel.Location = New System.Drawing.Point(183, 0)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(182, 309)
        Me.rightPanel.TabIndex = 0
        '
        'settingsBtn
        '
        Me.settingsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.settingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.settingsBtn.FlatAppearance.BorderSize = 0
        Me.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsBtn.Font = New System.Drawing.Font("Pixelify Sans SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBtn.ForeColor = System.Drawing.Color.Black
        Me.settingsBtn.IconChar = FontAwesome.Sharp.IconChar.Gears
        Me.settingsBtn.IconColor = System.Drawing.Color.Black
        Me.settingsBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.settingsBtn.IconSize = 30
        Me.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settingsBtn.Location = New System.Drawing.Point(0, 259)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(182, 50)
        Me.settingsBtn.TabIndex = 5
        Me.settingsBtn.Text = "Settings"
        Me.settingsBtn.UseVisualStyleBackColor = False
        '
        'leftPanel
        '
        Me.leftPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.leftPanel.Controls.Add(Me.usernameBtn)
        Me.leftPanel.Controls.Add(Me.framePanel)
        Me.leftPanel.Controls.Add(Me.settingsBtn)
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.Location = New System.Drawing.Point(0, 0)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(182, 309)
        Me.leftPanel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(60, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'framePanel
        '
        Me.framePanel.Controls.Add(Me.PictureBox1)
        Me.framePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.framePanel.Location = New System.Drawing.Point(0, 0)
        Me.framePanel.Name = "framePanel"
        Me.framePanel.Size = New System.Drawing.Size(182, 100)
        Me.framePanel.TabIndex = 6
        '
        'usernameBtn
        '
        Me.usernameBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.usernameBtn.FlatAppearance.BorderSize = 0
        Me.usernameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usernameBtn.Font = New System.Drawing.Font("Pixelify Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameBtn.IconChar = FontAwesome.Sharp.IconChar.User
        Me.usernameBtn.IconColor = System.Drawing.Color.Black
        Me.usernameBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.usernameBtn.IconSize = 35
        Me.usernameBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.usernameBtn.Location = New System.Drawing.Point(0, 100)
        Me.usernameBtn.Name = "usernameBtn"
        Me.usernameBtn.Size = New System.Drawing.Size(182, 40)
        Me.usernameBtn.TabIndex = 7
        Me.usernameBtn.Text = "Username"
        Me.usernameBtn.UseVisualStyleBackColor = True
        '
        'topRightPanel
        '
        Me.topRightPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.topRightPanel.Controls.Add(Me.mazeBtn)
        Me.topRightPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topRightPanel.Location = New System.Drawing.Point(0, 0)
        Me.topRightPanel.Name = "topRightPanel"
        Me.topRightPanel.Size = New System.Drawing.Size(182, 100)
        Me.topRightPanel.TabIndex = 0
        '
        'bottomRightPanel
        '
        Me.bottomRightPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.bottomRightPanel.Controls.Add(Me.chessBtn)
        Me.bottomRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomRightPanel.Location = New System.Drawing.Point(0, 209)
        Me.bottomRightPanel.Name = "bottomRightPanel"
        Me.bottomRightPanel.Size = New System.Drawing.Size(182, 100)
        Me.bottomRightPanel.TabIndex = 1
        '
        'middleRightPanel
        '
        Me.middleRightPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.middleRightPanel.Controls.Add(Me.rpgBtn)
        Me.middleRightPanel.Location = New System.Drawing.Point(183, 100)
        Me.middleRightPanel.Name = "middleRightPanel"
        Me.middleRightPanel.Size = New System.Drawing.Size(182, 111)
        Me.middleRightPanel.TabIndex = 2
        '
        'mazeBtn
        '
        Me.mazeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.mazeBtn.FlatAppearance.BorderSize = 0
        Me.mazeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mazeBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.mazeBtn.IconColor = System.Drawing.Color.Black
        Me.mazeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.mazeBtn.Location = New System.Drawing.Point(62, 17)
        Me.mazeBtn.Name = "mazeBtn"
        Me.mazeBtn.Size = New System.Drawing.Size(64, 64)
        Me.mazeBtn.TabIndex = 0
        Me.mazeBtn.UseVisualStyleBackColor = False
        '
        'rpgBtn
        '
        Me.rpgBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.rpgBtn.FlatAppearance.BorderSize = 0
        Me.rpgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rpgBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.rpgBtn.IconColor = System.Drawing.Color.Black
        Me.rpgBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.rpgBtn.Location = New System.Drawing.Point(59, 23)
        Me.rpgBtn.Name = "rpgBtn"
        Me.rpgBtn.Size = New System.Drawing.Size(64, 64)
        Me.rpgBtn.TabIndex = 1
        Me.rpgBtn.UseVisualStyleBackColor = False
        '
        'chessBtn
        '
        Me.chessBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.chessBtn.FlatAppearance.BorderSize = 0
        Me.chessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chessBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.chessBtn.IconColor = System.Drawing.Color.Black
        Me.chessBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.chessBtn.Location = New System.Drawing.Point(59, 18)
        Me.chessBtn.Name = "chessBtn"
        Me.chessBtn.Size = New System.Drawing.Size(64, 64)
        Me.chessBtn.TabIndex = 1
        Me.chessBtn.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(365, 309)
        Me.Controls.Add(Me.middleRightPanel)
        Me.Controls.Add(Me.rightPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.rightPanel.ResumeLayout(False)
        Me.leftPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.framePanel.ResumeLayout(False)
        Me.topRightPanel.ResumeLayout(False)
        Me.bottomRightPanel.ResumeLayout(False)
        Me.middleRightPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rightPanel As Panel
    Friend WithEvents leftPanel As Panel
    Friend WithEvents settingsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents framePanel As Panel
    Friend WithEvents usernameBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents topRightPanel As Panel
    Friend WithEvents bottomRightPanel As Panel
    Friend WithEvents middleRightPanel As Panel
    Friend WithEvents mazeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents chessBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents rpgBtn As FontAwesome.Sharp.IconButton
End Class
