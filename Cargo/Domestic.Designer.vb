<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Domestic
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtdzip = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdcity = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtocity = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.cmbstatus = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnupdate = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Operations = New System.Windows.Forms.GroupBox
        Me.txtweight = New System.Windows.Forms.TextBox
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtprod = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtdomesno = New System.Windows.Forms.TextBox
        Me.txtcnsgno = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Operations.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtdzip)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtdcity)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(423, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 113)
        Me.GroupBox3.TabIndex = 250
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DESTINATION"
        '
        'txtdzip
        '
        Me.txtdzip.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdzip.Location = New System.Drawing.Point(133, 74)
        Me.txtdzip.Name = "txtdzip"
        Me.txtdzip.Size = New System.Drawing.Size(190, 28)
        Me.txtdzip.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 223
        Me.Label4.Text = "ZIP CODE"
        '
        'txtdcity
        '
        Me.txtdcity.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdcity.Location = New System.Drawing.Point(133, 36)
        Me.txtdcity.Name = "txtdcity"
        Me.txtdcity.Size = New System.Drawing.Size(190, 28)
        Me.txtdcity.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 217
        Me.Label10.Text = "CITY"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtocity)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(49, 227)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 64)
        Me.GroupBox2.TabIndex = 249
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ORIGIN"
        '
        'txtocity
        '
        Me.txtocity.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtocity.Location = New System.Drawing.Point(129, 27)
        Me.txtocity.Name = "txtocity"
        Me.txtocity.Size = New System.Drawing.Size(187, 28)
        Me.txtocity.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "CITY"
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(367, 486)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(111, 39)
        Me.btndelete.TabIndex = 243
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(133, 486)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(111, 39)
        Me.btnsave.TabIndex = 242
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'cmbstatus
        '
        Me.cmbstatus.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"Delivered", "Not Delivered"})
        Me.cmbstatus.Location = New System.Drawing.Point(161, 77)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(184, 28)
        Me.cmbstatus.TabIndex = 140
        Me.cmbstatus.Text = "                     "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "STATUS"
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(250, 486)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(111, 39)
        Me.btnupdate.TabIndex = 252
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 251
        Me.Label1.Text = "CDOMESTIC NO"
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(484, 486)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(111, 39)
        Me.btnclear.TabIndex = 244
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(601, 486)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(111, 39)
        Me.btnexit.TabIndex = 245
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "PRODUCT"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(174, 85)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 28)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Operations
        '
        Me.Operations.Controls.Add(Me.DateTimePicker1)
        Me.Operations.Controls.Add(Me.txtweight)
        Me.Operations.Controls.Add(Me.txtamt)
        Me.Operations.Controls.Add(Me.Label11)
        Me.Operations.Controls.Add(Me.Label7)
        Me.Operations.Controls.Add(Me.Label9)
        Me.Operations.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operations.Location = New System.Drawing.Point(41, 300)
        Me.Operations.Name = "Operations"
        Me.Operations.Size = New System.Drawing.Size(372, 177)
        Me.Operations.TabIndex = 247
        Me.Operations.TabStop = False
        Me.Operations.Text = "Booking Details"
        '
        'txtweight
        '
        Me.txtweight.Location = New System.Drawing.Point(174, 48)
        Me.txtweight.Multiline = True
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(184, 31)
        Me.txtweight.TabIndex = 5
        '
        'txtamt
        '
        Me.txtamt.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.Location = New System.Drawing.Point(174, 119)
        Me.txtamt.Multiline = True
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(184, 30)
        Me.txtamt.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 140
        Me.Label11.Text = "AMOUNT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 20)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "BOOKING DATE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 20)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "WEIGHT(Kgs)"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Footlight MT Light", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(208, 81)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(487, 38)
        Me.Label29.TabIndex = 246
        Me.Label29.Text = "COURIER DOMESTIC DETAILS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtprod)
        Me.GroupBox1.Controls.Add(Me.cmbstatus)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(423, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 125)
        Me.GroupBox1.TabIndex = 248
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Details"
        '
        'txtprod
        '
        Me.txtprod.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprod.Location = New System.Drawing.Point(161, 35)
        Me.txtprod.Name = "txtprod"
        Me.txtprod.Size = New System.Drawing.Size(184, 28)
        Me.txtprod.TabIndex = 141
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(419, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 20)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "CONSIG NO"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 564)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(798, 166)
        Me.DataGridView1.TabIndex = 255
        '
        'txtdomesno
        '
        Me.txtdomesno.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdomesno.Location = New System.Drawing.Point(198, 142)
        Me.txtdomesno.Name = "txtdomesno"
        Me.txtdomesno.Size = New System.Drawing.Size(187, 28)
        Me.txtdomesno.TabIndex = 256
        '
        'txtcnsgno
        '
        Me.txtcnsgno.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcnsgno.Location = New System.Drawing.Point(556, 142)
        Me.txtcnsgno.Name = "txtcnsgno"
        Me.txtcnsgno.Size = New System.Drawing.Size(187, 28)
        Me.txtcnsgno.TabIndex = 257
        '
        'Domestic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(827, 742)
        Me.Controls.Add(Me.txtcnsgno)
        Me.Controls.Add(Me.txtdomesno)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Operations)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Name = "Domestic"
        Me.Text = "Domestic"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Operations.ResumeLayout(False)
        Me.Operations.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdzip As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdcity As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtocity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Operations As System.Windows.Forms.GroupBox
    Friend WithEvents txtweight As System.Windows.Forms.TextBox
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtprod As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtdomesno As System.Windows.Forms.TextBox
    Friend WithEvents txtcnsgno As System.Windows.Forms.TextBox
End Class
