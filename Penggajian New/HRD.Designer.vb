<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRD
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HRD))
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
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dghrd = New System.Windows.Forms.DataGridView()
        Me.NohrdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaHrdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenkelhrdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglLhrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgamaHrdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusHrdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglmskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HrdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GajianDataSet = New Penggajian.gajianDataSet()
        Me.HrdTableAdapter = New Penggajian.gajianDataSetTableAdapters.hrdTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dghrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HrdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GajianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(273, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 29)
        Me.Label4.TabIndex = 44
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
        Me.GroupBox2.Location = New System.Drawing.Point(371, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 169)
        Me.GroupBox2.TabIndex = 43
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 169)
        Me.GroupBox1.TabIndex = 42
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
        Me.txtnamahrd.TabIndex = 4
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
        Me.txtno.Size = New System.Drawing.Size(134, 20)
        Me.txtno.TabIndex = 3
        '
        'btnkeluar
        '
        Me.btnkeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.Color.Transparent
        Me.btnkeluar.Image = CType(resources.GetObject("btnkeluar.Image"), System.Drawing.Image)
        Me.btnkeluar.Location = New System.Drawing.Point(557, 446)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(89, 70)
        Me.btnkeluar.TabIndex = 41
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), System.Drawing.Image)
        Me.btnupdate.Location = New System.Drawing.Point(434, 446)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(89, 70)
        Me.btnupdate.TabIndex = 40
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(181, 446)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(89, 70)
        Me.btnsimpan.TabIndex = 39
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.Location = New System.Drawing.Point(311, 446)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(89, 70)
        Me.btnhapus.TabIndex = 38
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btntambah.Image = CType(resources.GetObject("btntambah.Image"), System.Drawing.Image)
        Me.btntambah.Location = New System.Drawing.Point(55, 446)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(89, 70)
        Me.btntambah.TabIndex = 37
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'dghrd
        '
        Me.dghrd.AutoGenerateColumns = False
        Me.dghrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dghrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NohrdDataGridViewTextBoxColumn, Me.NamaHrdDataGridViewTextBoxColumn, Me.JenkelhrdDataGridViewTextBoxColumn, Me.TglLhrDataGridViewTextBoxColumn, Me.AgamaHrdDataGridViewTextBoxColumn, Me.StatusHrdDataGridViewTextBoxColumn, Me.TglmskDataGridViewTextBoxColumn})
        Me.dghrd.DataSource = Me.HrdBindingSource
        Me.dghrd.Location = New System.Drawing.Point(13, 256)
        Me.dghrd.Name = "dghrd"
        Me.dghrd.Size = New System.Drawing.Size(690, 180)
        Me.dghrd.TabIndex = 45
        '
        'NohrdDataGridViewTextBoxColumn
        '
        Me.NohrdDataGridViewTextBoxColumn.DataPropertyName = "no_hrd"
        Me.NohrdDataGridViewTextBoxColumn.HeaderText = "no_hrd"
        Me.NohrdDataGridViewTextBoxColumn.Name = "NohrdDataGridViewTextBoxColumn"
        '
        'NamaHrdDataGridViewTextBoxColumn
        '
        Me.NamaHrdDataGridViewTextBoxColumn.DataPropertyName = "namaHrd"
        Me.NamaHrdDataGridViewTextBoxColumn.HeaderText = "namaHrd"
        Me.NamaHrdDataGridViewTextBoxColumn.Name = "NamaHrdDataGridViewTextBoxColumn"
        '
        'JenkelhrdDataGridViewTextBoxColumn
        '
        Me.JenkelhrdDataGridViewTextBoxColumn.DataPropertyName = "jenkel_hrd"
        Me.JenkelhrdDataGridViewTextBoxColumn.HeaderText = "jenkel_hrd"
        Me.JenkelhrdDataGridViewTextBoxColumn.Name = "JenkelhrdDataGridViewTextBoxColumn"
        '
        'TglLhrDataGridViewTextBoxColumn
        '
        Me.TglLhrDataGridViewTextBoxColumn.DataPropertyName = "tglLhr"
        Me.TglLhrDataGridViewTextBoxColumn.HeaderText = "tglLhr"
        Me.TglLhrDataGridViewTextBoxColumn.Name = "TglLhrDataGridViewTextBoxColumn"
        '
        'AgamaHrdDataGridViewTextBoxColumn
        '
        Me.AgamaHrdDataGridViewTextBoxColumn.DataPropertyName = "agamaHrd"
        Me.AgamaHrdDataGridViewTextBoxColumn.HeaderText = "agamaHrd"
        Me.AgamaHrdDataGridViewTextBoxColumn.Name = "AgamaHrdDataGridViewTextBoxColumn"
        '
        'StatusHrdDataGridViewTextBoxColumn
        '
        Me.StatusHrdDataGridViewTextBoxColumn.DataPropertyName = "statusHrd"
        Me.StatusHrdDataGridViewTextBoxColumn.HeaderText = "statusHrd"
        Me.StatusHrdDataGridViewTextBoxColumn.Name = "StatusHrdDataGridViewTextBoxColumn"
        '
        'TglmskDataGridViewTextBoxColumn
        '
        Me.TglmskDataGridViewTextBoxColumn.DataPropertyName = "tgl_msk"
        Me.TglmskDataGridViewTextBoxColumn.HeaderText = "tgl_msk"
        Me.TglmskDataGridViewTextBoxColumn.Name = "TglmskDataGridViewTextBoxColumn"
        '
        'HrdBindingSource
        '
        Me.HrdBindingSource.DataMember = "hrd"
        Me.HrdBindingSource.DataSource = Me.GajianDataSet
        '
        'GajianDataSet
        '
        Me.GajianDataSet.DataSetName = "gajianDataSet"
        Me.GajianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HrdTableAdapter
        '
        Me.HrdTableAdapter.ClearBeforeFill = True
        '
        'HRD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(717, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.dghrd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btntambah)
        Me.Name = "HRD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HRD"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dghrd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HrdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GajianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents dghrd As System.Windows.Forms.DataGridView
    Friend WithEvents GajianDataSet As Penggajian.gajianDataSet
    Friend WithEvents HrdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HrdTableAdapter As Penggajian.gajianDataSetTableAdapters.hrdTableAdapter
    Friend WithEvents NohrdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaHrdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenkelhrdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglLhrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgamaHrdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusHrdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglmskDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
