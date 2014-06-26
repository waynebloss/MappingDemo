<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainView
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
        Me.mainMnu = New System.Windows.Forms.MenuStrip()
        Me.fileMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.fileMnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpMnu = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpMnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainTb = New System.Windows.Forms.ToolStrip()
        Me.mainTbShowMapForGeocodingBtn = New System.Windows.Forms.ToolStripButton()
        Me.mainTbSep01 = New System.Windows.Forms.ToolStripSeparator()
        Me.mainTbShowMapWithMarkersBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mainTbShowMapForDirectionsBtn = New System.Windows.Forms.ToolStripButton()
        Me.mainStatStrip = New System.Windows.Forms.StatusStrip()
        Me.mainStatLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.browser = New System.Windows.Forms.WebBrowser()
        Me.DirectionsTxt = New System.Windows.Forms.TextBox()
        Me.VertSplitter = New System.Windows.Forms.Splitter()
        Me.mainMnu.SuspendLayout()
        Me.mainTb.SuspendLayout()
        Me.mainStatStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMnu
        '
        Me.mainMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMnu, Me.helpMnu})
        Me.mainMnu.Location = New System.Drawing.Point(0, 0)
        Me.mainMnu.Name = "mainMnu"
        Me.mainMnu.Size = New System.Drawing.Size(1008, 24)
        Me.mainMnu.TabIndex = 0
        Me.mainMnu.Text = "MenuStrip1"
        '
        'fileMnu
        '
        Me.fileMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMnuExit})
        Me.fileMnu.Name = "fileMnu"
        Me.fileMnu.Size = New System.Drawing.Size(37, 20)
        Me.fileMnu.Text = "&File"
        '
        'fileMnuExit
        '
        Me.fileMnuExit.Name = "fileMnuExit"
        Me.fileMnuExit.Size = New System.Drawing.Size(92, 22)
        Me.fileMnuExit.Text = "E&xit"
        '
        'helpMnu
        '
        Me.helpMnu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.helpMnuAbout})
        Me.helpMnu.Name = "helpMnu"
        Me.helpMnu.Size = New System.Drawing.Size(44, 20)
        Me.helpMnu.Text = "&Help"
        '
        'helpMnuAbout
        '
        Me.helpMnuAbout.Name = "helpMnuAbout"
        Me.helpMnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.helpMnuAbout.Text = "&About"
        '
        'mainTb
        '
        Me.mainTb.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainTb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainTbShowMapForGeocodingBtn, Me.mainTbSep01, Me.mainTbShowMapWithMarkersBtn, Me.ToolStripSeparator1, Me.mainTbShowMapForDirectionsBtn})
        Me.mainTb.Location = New System.Drawing.Point(0, 24)
        Me.mainTb.Name = "mainTb"
        Me.mainTb.Size = New System.Drawing.Size(1008, 25)
        Me.mainTb.TabIndex = 1
        Me.mainTb.Text = "ToolStrip1"
        '
        'mainTbShowMapForGeocodingBtn
        '
        Me.mainTbShowMapForGeocodingBtn.Image = Global.GoogleMapping.My.Resources.Resources.map_magnify
        Me.mainTbShowMapForGeocodingBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mainTbShowMapForGeocodingBtn.Name = "mainTbShowMapForGeocodingBtn"
        Me.mainTbShowMapForGeocodingBtn.Size = New System.Drawing.Size(162, 22)
        Me.mainTbShowMapForGeocodingBtn.Text = "Show Map for Geocoding"
        '
        'mainTbSep01
        '
        Me.mainTbSep01.Name = "mainTbSep01"
        Me.mainTbSep01.Size = New System.Drawing.Size(6, 25)
        '
        'mainTbShowMapWithMarkersBtn
        '
        Me.mainTbShowMapWithMarkersBtn.Image = Global.GoogleMapping.My.Resources.Resources.google_map
        Me.mainTbShowMapWithMarkersBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mainTbShowMapWithMarkersBtn.Name = "mainTbShowMapWithMarkersBtn"
        Me.mainTbShowMapWithMarkersBtn.Size = New System.Drawing.Size(154, 22)
        Me.mainTbShowMapWithMarkersBtn.Text = "Show Map with Markers"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'mainTbShowMapForDirectionsBtn
        '
        Me.mainTbShowMapForDirectionsBtn.Image = Global.GoogleMapping.My.Resources.Resources.map
        Me.mainTbShowMapForDirectionsBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mainTbShowMapForDirectionsBtn.Name = "mainTbShowMapForDirectionsBtn"
        Me.mainTbShowMapForDirectionsBtn.Size = New System.Drawing.Size(157, 22)
        Me.mainTbShowMapForDirectionsBtn.Text = "Show Map for Directions"
        '
        'mainStatStrip
        '
        Me.mainStatStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainStatLbl})
        Me.mainStatStrip.Location = New System.Drawing.Point(0, 572)
        Me.mainStatStrip.Name = "mainStatStrip"
        Me.mainStatStrip.Size = New System.Drawing.Size(1008, 22)
        Me.mainStatStrip.TabIndex = 2
        Me.mainStatStrip.Text = "StatusStrip1"
        '
        'mainStatLbl
        '
        Me.mainStatLbl.Name = "mainStatLbl"
        Me.mainStatLbl.Size = New System.Drawing.Size(993, 17)
        Me.mainStatLbl.Spring = True
        Me.mainStatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'browser
        '
        Me.browser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.browser.Location = New System.Drawing.Point(0, 49)
        Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser.Name = "browser"
        Me.browser.Size = New System.Drawing.Size(1008, 523)
        Me.browser.TabIndex = 3
        '
        'DirectionsTxt
        '
        Me.DirectionsTxt.Dock = System.Windows.Forms.DockStyle.Right
        Me.DirectionsTxt.Location = New System.Drawing.Point(739, 49)
        Me.DirectionsTxt.Multiline = True
        Me.DirectionsTxt.Name = "DirectionsTxt"
        Me.DirectionsTxt.Size = New System.Drawing.Size(269, 523)
        Me.DirectionsTxt.TabIndex = 4
        '
        'VertSplitter
        '
        Me.VertSplitter.Dock = System.Windows.Forms.DockStyle.Right
        Me.VertSplitter.Location = New System.Drawing.Point(731, 49)
        Me.VertSplitter.Name = "VertSplitter"
        Me.VertSplitter.Size = New System.Drawing.Size(8, 523)
        Me.VertSplitter.TabIndex = 5
        Me.VertSplitter.TabStop = False
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 594)
        Me.Controls.Add(Me.VertSplitter)
        Me.Controls.Add(Me.DirectionsTxt)
        Me.Controls.Add(Me.browser)
        Me.Controls.Add(Me.mainStatStrip)
        Me.Controls.Add(Me.mainTb)
        Me.Controls.Add(Me.mainMnu)
        Me.MainMenuStrip = Me.mainMnu
        Me.Name = "MainView"
        Me.Text = "Google Mapping"
        Me.mainMnu.ResumeLayout(False)
        Me.mainMnu.PerformLayout()
        Me.mainTb.ResumeLayout(False)
        Me.mainTb.PerformLayout()
        Me.mainStatStrip.ResumeLayout(False)
        Me.mainStatStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainMnu As System.Windows.Forms.MenuStrip
    Friend WithEvents fileMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fileMnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpMnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainTb As System.Windows.Forms.ToolStrip
    Friend WithEvents mainStatStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mainStatLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mainTbShowMapWithMarkersBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents mainTbSep01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mainTbShowMapForGeocodingBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents browser As System.Windows.Forms.WebBrowser
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mainTbShowMapForDirectionsBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents DirectionsTxt As System.Windows.Forms.TextBox
    Friend WithEvents VertSplitter As System.Windows.Forms.Splitter

End Class
