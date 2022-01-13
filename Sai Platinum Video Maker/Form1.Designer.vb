<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BurnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PublishVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.BuildsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "Mellow"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'BuildsToolStripMenuItem
        '
        Me.BuildsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuildVideoToolStripMenuItem, Me.BurnToolStripMenuItem, Me.PublishVideoToolStripMenuItem})
        Me.BuildsToolStripMenuItem.Name = "BuildsToolStripMenuItem"
        Me.BuildsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.BuildsToolStripMenuItem.Text = "Build"
        '
        'BuildVideoToolStripMenuItem
        '
        Me.BuildVideoToolStripMenuItem.Name = "BuildVideoToolStripMenuItem"
        Me.BuildVideoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BuildVideoToolStripMenuItem.Text = "Build Video"
        '
        'BurnToolStripMenuItem
        '
        Me.BurnToolStripMenuItem.Name = "BurnToolStripMenuItem"
        Me.BurnToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BurnToolStripMenuItem.Text = "Burn"
        '
        'PublishVideoToolStripMenuItem
        '
        Me.PublishVideoToolStripMenuItem.Name = "PublishVideoToolStripMenuItem"
        Me.PublishVideoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PublishVideoToolStripMenuItem.Text = "Publish Video"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Sai Platinum Video Maker"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuildVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BurnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PublishVideoToolStripMenuItem As ToolStripMenuItem
End Class
