<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manufacturer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manufacturer))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtbrand = New System.Windows.Forms.TextBox
        Me.btnaddsup = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.btnadd = New System.Windows.Forms.Button
        Me.btnclose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(486, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(310, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Brand Name    :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(310, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Supplier ID      :"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(510, 260)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(151, 27)
        Me.ComboBox1.TabIndex = 3
        '
        'txtbrand
        '
        Me.txtbrand.BackColor = System.Drawing.Color.White
        Me.txtbrand.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.Location = New System.Drawing.Point(510, 207)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(151, 26)
        Me.txtbrand.TabIndex = 4
        Me.txtbrand.Visible = False
        '
        'btnaddsup
        '
        Me.btnaddsup.BackColor = System.Drawing.Color.Transparent
        Me.btnaddsup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddsup.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddsup.ForeColor = System.Drawing.Color.White
        Me.btnaddsup.Location = New System.Drawing.Point(677, 254)
        Me.btnaddsup.Name = "btnaddsup"
        Me.btnaddsup.Size = New System.Drawing.Size(226, 40)
        Me.btnaddsup.TabIndex = 5
        Me.btnaddsup.Text = "Add New Supplier"
        Me.btnaddsup.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Transparent
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(705, 384)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(111, 43)
        Me.btnupdate.TabIndex = 6
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        Me.btnupdate.Visible = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Transparent
        Me.btnedit.CausesValidation = False
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(438, 557)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(103, 35)
        Me.btnedit.TabIndex = 7
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        Me.btnedit.Visible = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(565, 557)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(103, 35)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        Me.btnexit.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(403, 300)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(284, 232)
        Me.ListBox1.TabIndex = 9
        Me.ListBox1.Visible = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Transparent
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(326, 370)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(107, 40)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        Me.btnadd.Visible = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(531, 370)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(96, 43)
        Me.btnclose.TabIndex = 11
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        Me.btnclose.Visible = False
        '
        'Manufacturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(997, 597)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnaddsup)
        Me.Controls.Add(Me.txtbrand)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Manufacturer"
        Me.Text = "Manufacturer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtbrand As System.Windows.Forms.TextBox
    Friend WithEvents btnaddsup As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class