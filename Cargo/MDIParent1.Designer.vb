<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ConsignerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CourierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DomesticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InternationalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsignerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CargoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DomesticToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.InternationalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FeedbackToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsignerToolStripMenuItem, Me.CargoToolStripMenuItem, Me.CourierToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsignerToolStripMenuItem
        '
        Me.ConsignerToolStripMenuItem.Name = "ConsignerToolStripMenuItem"
        Me.ConsignerToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ConsignerToolStripMenuItem.Text = "Consigner"
        '
        'CargoToolStripMenuItem
        '
        Me.CargoToolStripMenuItem.Name = "CargoToolStripMenuItem"
        Me.CargoToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.CargoToolStripMenuItem.Text = "Cargo"
        '
        'CourierToolStripMenuItem
        '
        Me.CourierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DomesticToolStripMenuItem, Me.InternationalToolStripMenuItem})
        Me.CourierToolStripMenuItem.Name = "CourierToolStripMenuItem"
        Me.CourierToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.CourierToolStripMenuItem.Text = "Courier"
        '
        'DomesticToolStripMenuItem
        '
        Me.DomesticToolStripMenuItem.Name = "DomesticToolStripMenuItem"
        Me.DomesticToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.DomesticToolStripMenuItem.Text = "Domestic"
        '
        'InternationalToolStripMenuItem
        '
        Me.InternationalToolStripMenuItem.Name = "InternationalToolStripMenuItem"
        Me.InternationalToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.InternationalToolStripMenuItem.Text = "International"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsignerToolStripMenuItem1, Me.CargoToolStripMenuItem1, Me.DomesticToolStripMenuItem1, Me.InternationalToolStripMenuItem1, Me.FeedbackToolStripMenuItem1})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ConsignerToolStripMenuItem1
        '
        Me.ConsignerToolStripMenuItem1.Name = "ConsignerToolStripMenuItem1"
        Me.ConsignerToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ConsignerToolStripMenuItem1.Text = "Consigner"
        '
        'CargoToolStripMenuItem1
        '
        Me.CargoToolStripMenuItem1.Name = "CargoToolStripMenuItem1"
        Me.CargoToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CargoToolStripMenuItem1.Text = "Cargo"
        '
        'DomesticToolStripMenuItem1
        '
        Me.DomesticToolStripMenuItem1.Name = "DomesticToolStripMenuItem1"
        Me.DomesticToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DomesticToolStripMenuItem1.Text = "Domestic"
        '
        'InternationalToolStripMenuItem1
        '
        Me.InternationalToolStripMenuItem1.Name = "InternationalToolStripMenuItem1"
        Me.InternationalToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.InternationalToolStripMenuItem1.Text = "International"
        '
        'FeedbackToolStripMenuItem1
        '
        Me.FeedbackToolStripMenuItem1.Name = "FeedbackToolStripMenuItem1"
        Me.FeedbackToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.FeedbackToolStripMenuItem1.Text = "Feedback"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsignerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DomesticToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InternationalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsignerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DomesticToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InternationalToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
