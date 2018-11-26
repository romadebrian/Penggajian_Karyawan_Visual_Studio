<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulirHRD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormulirHRD))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtidakkawin = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbkawin = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbagama = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dttglmasuk = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dttgllahir = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnamahrd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.txtgender = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(273, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 29)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Form HRD"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rbtidakkawin)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.rbkawin)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cbagama)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dttglmasuk)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dttgllahir)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(371, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 169)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Pribadi"
        '
        'rbtidakkawin
        '
        Me.rbtidakkawin.AutoSize = True
        Me.rbtidakkawin.BackColor = System.Drawing.Color.Transparent
        Me.rbtidakkawin.ForeColor = System.Drawing.Color.White
        Me.rbtidakkawin.Location = New System.Drawing.Point(194, 92)
        Me.rbtidakkawin.Name = "rbtidakkawin"
        Me.rbtidakkawin.Size = New System.Drawing.Size(86, 17)
        Me.rbtidakkawin.TabIndex = 16
        Me.rbtidakkawin.TabStop = True
        Me.rbtidakkawin.Text = "Belum Kawin"
        Me.rbtidakkawin.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tanggal Lahir"
        '
        'rbkawin
        '
        Me.rbkawin.AutoSize = True
        Me.rbkawin.BackColor = System.Drawing.Color.Transparent
        Me.rbkawin.ForeColor = System.Drawing.Color.White
        Me.rbkawin.Location = New System.Drawing.Point(108, 90)
        Me.rbkawin.Name = "rbkawin"
        Me.rbkawin.Size = New System.Drawing.Size(54, 17)
        Me.rbkawin.TabIndex = 15
        Me.rbkawin.TabStop = True
        Me.rbkawin.Text = "Kawin"
        Me.rbkawin.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(8, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Tanggal Masuk"
        '
        'cbagama
        '
        Me.cbagama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbagama.ForeColor = System.Drawing.Color.Black
        Me.cbagama.FormattingEnabled = True
        Me.cbagama.Items.AddRange(New Object() {"Islam", "Kristen", "Katolik", "Hindu", "Budha"})
        Me.cbagama.Location = New System.Drawing.Point(108, 59)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.Size = New System.Drawing.Size(133, 21)
        Me.cbagama.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(17, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Agama"
        '
        'dttglmasuk
        '
        Me.dttglmasuk.Location = New System.Drawing.Point(108, 130)
        Me.dttglmasuk.Name = "dttglmasuk"
        Me.dttglmasuk.Size = New System.Drawing.Size(200, 20)
        Me.dttglmasuk.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(20, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Status"
        '
        'dttgllahir
        '
        Me.dttgllahir.Location = New System.Drawing.Point(108, 21)
        Me.dttgllahir.Name = "dttgllahir"
        Me.dttgllahir.Size = New System.Drawing.Size(200, 20)
        Me.dttgllahir.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbperempuan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rblaki)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtnamahrd)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 169)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Data"
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.BackColor = System.Drawing.Color.Transparent
        Me.rbperempuan.ForeColor = System.Drawing.Color.White
        Me.rbperempuan.Location = New System.Drawing.Point(176, 99)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 6
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No HRD"
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.BackColor = System.Drawing.Color.Transparent
        Me.rblaki.ForeColor = System.Drawing.Color.White
        Me.rblaki.Location = New System.Drawing.Point(100, 99)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(70, 17)
        Me.rblaki.TabIndex = 5
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki - laki"
        Me.rblaki.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(17, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nama HRD"
        '
        'txtnamahrd
        '
        Me.txtnamahrd.ForeColor = System.Drawing.Color.Black
        Me.txtnamahrd.Location = New System.Drawing.Point(100, 66)
        Me.txtnamahrd.Name = "txtnamahrd"
        Me.txtnamahrd.Size = New System.Drawing.Size(134, 20)
        Me.txtnamahrd.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(17, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Jenis Kelamin"
        '
        'txtno
        '
        Me.txtno.ForeColor = System.Drawing.Color.Black
        Me.txtno.Location = New System.Drawing.Point(100, 26)
        Me.txtno.Name = "txtno"
        Me.txtno.ReadOnly = True
        Me.txtno.Size = New System.Drawing.Size(134, 20)
        Me.txtno.TabIndex = 3
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = CType(resources.GetObject("btnNext.BackgroundImage"), System.Drawing.Image)
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNext.Location = New System.Drawing.Point(463, 270)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 55)
        Me.btnNext.TabIndex = 48
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Location = New System.Drawing.Point(162, 270)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 55)
        Me.btnBack.TabIndex = 49
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.BackgroundImage = CType(resources.GetObject("btnkeluar.BackgroundImage"), System.Drawing.Image)
        Me.btnkeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnkeluar.Location = New System.Drawing.Point(309, 270)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(90, 55)
        Me.btnkeluar.TabIndex = 50
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'txtgender
        '
        Me.txtgender.AutoSize = True
        Me.txtgender.Location = New System.Drawing.Point(560, 305)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(64, 13)
        Me.txtgender.TabIndex = 51
        Me.txtgender.Text = "jeniskelamin"
        Me.txtgender.Visible = False
        '
        'txtstatus
        '
        Me.txtstatus.AutoSize = True
        Me.txtstatus.Location = New System.Drawing.Point(636, 305)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(42, 13)
        Me.txtstatus.TabIndex = 52
        Me.txtstatus.Text = "jabatan"
        Me.txtstatus.Visible = False
        '
        'FormulirHRD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(717, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormulirHRD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulir HRD"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtidakkawin As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbkawin As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbagama As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dttglmasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dttgllahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rblaki As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnamahrd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents txtgender As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.Label
End Class
