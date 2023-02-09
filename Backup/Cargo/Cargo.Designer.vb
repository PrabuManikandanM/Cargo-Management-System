<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargo
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
        Me.cmbbtype = New System.Windows.Forms.ComboBox
        Me.btnuupdate = New System.Windows.Forms.Button
        Me.cmbcarmode = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnclear = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOcity = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtOzip = New System.Windows.Forms.TextBox
        Me.txtOctry = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtDzip = New System.Windows.Forms.TextBox
        Me.txtDcity = New System.Windows.Forms.TextBox
        Me.txtDctry = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtcarno = New System.Windows.Forms.TextBox
        Me.txtcnsgno = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbbtype
        '
        Me.cmbbtype.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbtype.FormattingEnabled = True
        Me.cmbbtype.Items.AddRange(New Object() {"Amount ", "Cheque", "Card"})
        Me.cmbbtype.Location = New System.Drawing.Point(145, 81)
        Me.cmbbtype.Name = "cmbbtype"
        Me.cmbbtype.Size = New System.Drawing.Size(172, 28)
        Me.cmbbtype.TabIndex = 8
        '
        'btnuupdate
        '
        Me.btnuupdate.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuupdate.Location = New System.Drawing.Point(196, 450)
        Me.btnuupdate.Name = "btnuupdate"
        Me.btnuupdate.Size = New System.Drawing.Size(111, 39)
        Me.btnuupdate.TabIndex = 252
        Me.btnuupdate.Text = "UPDATE"
        Me.btnuupdate.UseVisualStyleBackColor = True
        '
        'cmbcarmode
        '
        Me.cmbcarmode.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcarmode.FormattingEnabled = True
        Me.cmbcarmode.Items.AddRange(New Object() {"Domestic", "International"})
        Me.cmbcarmode.Location = New System.Drawing.Point(545, 81)
        Me.cmbcarmode.Name = "cmbcarmode"
        Me.cmbcarmode.Size = New System.Drawing.Size(172, 28)
        Me.cmbcarmode.TabIndex = 249
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(392, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 20)
        Me.Label11.TabIndex = 250
        Me.Label11.Text = "CARGO MODE"
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(483, 449)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(111, 39)
        Me.btnclear.TabIndex = 248
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 20)
        Me.Label8.TabIndex = 247
        Me.Label8.Text = "CARGO NO"
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(617, 450)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(111, 39)
        Me.btnexit.TabIndex = 246
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(58, 449)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(111, 40)
        Me.btnsave.TabIndex = 245
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(338, 449)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(111, 40)
        Me.btndelete.TabIndex = 244
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbbtype)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Footlight MT Light", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(51, 320)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(332, 119)
        Me.GroupBox4.TabIndex = 242
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Booking Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "PAY TYPE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(145, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(172, 28)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "BOOK DATE"
        '
        'txtOcity
        '
        Me.txtOcity.Location = New System.Drawing.Point(160, 67)
        Me.txtOcity.Name = "txtOcity"
        Me.txtOcity.Size = New System.Drawing.Size(166, 30)
        Me.txtOcity.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(60, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 20)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "CONSIG NO"
        '
        'txtOzip
        '
        Me.txtOzip.Location = New System.Drawing.Point(160, 103)
        Me.txtOzip.Name = "txtOzip"
        Me.txtOzip.Size = New System.Drawing.Size(166, 30)
        Me.txtOzip.TabIndex = 3
        '
        'txtOctry
        '
        Me.txtOctry.Location = New System.Drawing.Point(160, 31)
        Me.txtOctry.Name = "txtOctry"
        Me.txtOctry.Size = New System.Drawing.Size(166, 30)
        Me.txtOctry.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(35, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 20)
        Me.Label9.TabIndex = 213
        Me.Label9.Text = "ZIPCODE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 20)
        Me.Label7.TabIndex = 209
        Me.Label7.Text = "COUNTRY"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 210
        Me.Label10.Text = "CITY"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDzip)
        Me.GroupBox3.Controls.Add(Me.txtDcity)
        Me.GroupBox3.Controls.Add(Me.txtDctry)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Footlight MT Light", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(389, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 143)
        Me.GroupBox3.TabIndex = 241
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Destination"
        '
        'txtDzip
        '
        Me.txtDzip.Location = New System.Drawing.Point(157, 104)
        Me.txtDzip.Name = "txtDzip"
        Me.txtDzip.Size = New System.Drawing.Size(166, 30)
        Me.txtDzip.TabIndex = 6
        '
        'txtDcity
        '
        Me.txtDcity.Location = New System.Drawing.Point(157, 69)
        Me.txtDcity.Name = "txtDcity"
        Me.txtDcity.Size = New System.Drawing.Size(166, 30)
        Me.txtDcity.TabIndex = 5
        '
        'txtDctry
        '
        Me.txtDctry.Location = New System.Drawing.Point(157, 36)
        Me.txtDctry.Name = "txtDctry"
        Me.txtDctry.Size = New System.Drawing.Size(166, 30)
        Me.txtDctry.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "ZIPCODE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "CITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Footlight MT Light", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "COUNTRY"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOzip)
        Me.GroupBox1.Controls.Add(Me.txtOcity)
        Me.GroupBox1.Controls.Add(Me.txtOctry)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Footlight MT Light", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(51, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 143)
        Me.GroupBox1.TabIndex = 240
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origin"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Footlight MT Light", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(235, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(274, 38)
        Me.Label14.TabIndex = 239
        Me.Label14.Text = "CARGO DETAILS"
        '
        'txtcarno
        '
        Me.txtcarno.Location = New System.Drawing.Point(211, 81)
        Me.txtcarno.Name = "txtcarno"
        Me.txtcarno.Size = New System.Drawing.Size(166, 20)
        Me.txtcarno.TabIndex = 214
        '
        'txtcnsgno
        '
        Me.txtcnsgno.Location = New System.Drawing.Point(211, 125)
        Me.txtcnsgno.Name = "txtcnsgno"
        Me.txtcnsgno.Size = New System.Drawing.Size(166, 20)
        Me.txtcnsgno.TabIndex = 255
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 516)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(757, 192)
        Me.DataGridView1.TabIndex = 256
        '
        'Cargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 720)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtcnsgno)
        Me.Controls.Add(Me.txtcarno)
        Me.Controls.Add(Me.btnuupdate)
        Me.Controls.Add(Me.cmbcarmode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label14)
        Me.Name = "Cargo"
        Me.Text = "Cargo"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbbtype As System.Windows.Forms.ComboBox
    Friend WithEvents btnuupdate As System.Windows.Forms.Button
    Friend WithEvents cmbcarmode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOcity As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtOzip As System.Windows.Forms.TextBox
    Friend WithEvents txtOctry As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDzip As System.Windows.Forms.TextBox
    Friend WithEvents txtDcity As System.Windows.Forms.TextBox
    Friend WithEvents txtDctry As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcarno As System.Windows.Forms.TextBox
    Friend WithEvents txtcnsgno As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
