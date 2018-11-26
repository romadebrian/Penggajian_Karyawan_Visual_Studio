<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(karyawan))
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dgkaryawan = New System.Windows.Forms.DataGridView()
        Me.NIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaKarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenkelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NohpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgllahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglmasukDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiPokokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GajianDataSet = New Penggajian.gajianDataSet()
        Me.txtgaji = New System.Windows.Forms.TextBox()
        Me.cbjabatan = New System.Windows.Forms.ComboBox()
        Me.dttglmasuk = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rbtidakkawin = New System.Windows.Forms.RadioButton()
        Me.rbkawin = New System.Windows.Forms.RadioButton()
        Me.cbagama = New System.Windows.Forms.ComboBox()
        Me.dttgllahir = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KaryawanTableAdapter = New Penggajian.gajianDataSetTableAdapters.karyawanTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtalamat = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgkaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GajianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnkeluar
        '
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.Color.Transparent
        Me.btnkeluar.Image = CType(resources.GetObject("btnkeluar.Image"), System.Drawing.Image)
        Me.btnkeluar.Location = New System.Drawing.Point(752, 486)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(89, 70)
        Me.btnkeluar.TabIndex = 26
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), System.Drawing.Image)
        Me.btnupdate.Location = New System.Drawing.Point(752, 388)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(89, 70)
        Me.btnupdate.TabIndex = 25
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(752, 178)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(89, 70)
        Me.btnsimpan.TabIndex = 24
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.Location = New System.Drawing.Point(752, 286)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(89, 70)
        Me.btnhapus.TabIndex = 23
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Image = CType(resources.GetObject("btntambah.Image"), System.Drawing.Image)
        Me.btntambah.Location = New System.Drawing.Point(752, 75)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(89, 70)
        Me.btntambah.TabIndex = 0
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'dgkaryawan
        '
        Me.dgkaryawan.AutoGenerateColumns = False
        Me.dgkaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgkaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIPDataGridViewTextBoxColumn, Me.NamaKarDataGridViewTextBoxColumn, Me.JenkelDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.NohpDataGridViewTextBoxColumn, Me.TgllahirDataGridViewTextBoxColumn, Me.AgamaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TglmasukDataGridViewTextBoxColumn, Me.JabatanDataGridViewTextBoxColumn, Me.GajiPokokDataGridViewTextBoxColumn})
        Me.dgkaryawan.DataSource = Me.KaryawanBindingSource
        Me.dgkaryawan.Location = New System.Drawing.Point(25, 399)
        Me.dgkaryawan.Name = "dgkaryawan"
        Me.dgkaryawan.Size = New System.Drawing.Size(704, 164)
        Me.dgkaryawan.TabIndex = 21
        '
        'NIPDataGridViewTextBoxColumn
        '
        Me.NIPDataGridViewTextBoxColumn.DataPropertyName = "NIP"
        Me.NIPDataGridViewTextBoxColumn.HeaderText = "NIP"
        Me.NIPDataGridViewTextBoxColumn.Name = "NIPDataGridViewTextBoxColumn"
        '
        'NamaKarDataGridViewTextBoxColumn
        '
        Me.NamaKarDataGridViewTextBoxColumn.DataPropertyName = "namaKar"
        Me.NamaKarDataGridViewTextBoxColumn.HeaderText = "namaKar"
        Me.NamaKarDataGridViewTextBoxColumn.Name = "NamaKarDataGridViewTextBoxColumn"
        '
        'JenkelDataGridViewTextBoxColumn
        '
        Me.JenkelDataGridViewTextBoxColumn.DataPropertyName = "Jenkel"
        Me.JenkelDataGridViewTextBoxColumn.HeaderText = "Jenkel"
        Me.JenkelDataGridViewTextBoxColumn.Name = "JenkelDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'NohpDataGridViewTextBoxColumn
        '
        Me.NohpDataGridViewTextBoxColumn.DataPropertyName = "no_hp"
        Me.NohpDataGridViewTextBoxColumn.HeaderText = "no_hp"
        Me.NohpDataGridViewTextBoxColumn.Name = "NohpDataGridViewTextBoxColumn"
        '
        'TgllahirDataGridViewTextBoxColumn
        '
        Me.TgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir"
        Me.TgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir"
        Me.TgllahirDataGridViewTextBoxColumn.Name = "TgllahirDataGridViewTextBoxColumn"
        '
        'AgamaDataGridViewTextBoxColumn
        '
        Me.AgamaDataGridViewTextBoxColumn.DataPropertyName = "agama"
        Me.AgamaDataGridViewTextBoxColumn.HeaderText = "agama"
        Me.AgamaDataGridViewTextBoxColumn.Name = "AgamaDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'TglmasukDataGridViewTextBoxColumn
        '
        Me.TglmasukDataGridViewTextBoxColumn.DataPropertyName = "tgl_masuk"
        Me.TglmasukDataGridViewTextBoxColumn.HeaderText = "tgl_masuk"
        Me.TglmasukDataGridViewTextBoxColumn.Name = "TglmasukDataGridViewTextBoxColumn"
        '
        'JabatanDataGridViewTextBoxColumn
        '
        Me.JabatanDataGridViewTextBoxColumn.DataPropertyName = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.HeaderText = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.Name = "JabatanDataGridViewTextBoxColumn"
        '
        'GajiPokokDataGridViewTextBoxColumn
        '
        Me.GajiPokokDataGridViewTextBoxColumn.DataPropertyName = "gajiPokok"
        Me.GajiPokokDataGridViewTextBoxColumn.HeaderText = "gajiPokok"
        Me.GajiPokokDataGridViewTextBoxColumn.Name = "GajiPokokDataGridViewTextBoxColumn"
        '
        'KaryawanBindingSource
        '
        Me.KaryawanBindingSource.DataMember = "karyawan"
        Me.KaryawanBindingSource.DataSource = Me.GajianDataSet
        '
        'GajianDataSet
        '
        Me.GajianDataSet.DataSetName = "gajianDataSet"
        Me.GajianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtgaji
        '
        Me.txtgaji.Location = New System.Drawing.Point(101, 108)
        Me.txtgaji.Name = "txtgaji"
        Me.txtgaji.ReadOnly = True
        Me.txtgaji.Size = New System.Drawing.Size(169, 20)
        Me.txtgaji.TabIndex = 5
        '
        'cbjabatan
        '
        Me.cbjabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjabatan.FormattingEnabled = True
        Me.cbjabatan.Items.AddRange(New Object() {"Sekretaris", "Staff Full Time", "Staff Part Time"})
        Me.cbjabatan.Location = New System.Drawing.Point(101, 65)
        Me.cbjabatan.Name = "cbjabatan"
        Me.cbjabatan.Size = New System.Drawing.Size(169, 21)
        Me.cbjabatan.TabIndex = 4
        '
        'dttglmasuk
        '
        Me.dttglmasuk.Location = New System.Drawing.Point(116, 25)
        Me.dttglmasuk.Name = "dttglmasuk"
        Me.dttglmasuk.Size = New System.Drawing.Size(218, 20)
        Me.dttglmasuk.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(16, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Gaji Pokok"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(16, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Jabatan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(16, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Tanggal Masuk"
        '
        'rbtidakkawin
        '
        Me.rbtidakkawin.AutoSize = True
        Me.rbtidakkawin.ForeColor = System.Drawing.Color.White
        Me.rbtidakkawin.Location = New System.Drawing.Point(167, 98)
        Me.rbtidakkawin.Name = "rbtidakkawin"
        Me.rbtidakkawin.Size = New System.Drawing.Size(86, 17)
        Me.rbtidakkawin.TabIndex = 16
        Me.rbtidakkawin.TabStop = True
        Me.rbtidakkawin.Text = "Belum Kawin"
        Me.rbtidakkawin.UseVisualStyleBackColor = True
        '
        'rbkawin
        '
        Me.rbkawin.AutoSize = True
        Me.rbkawin.ForeColor = System.Drawing.Color.White
        Me.rbkawin.Location = New System.Drawing.Point(107, 98)
        Me.rbkawin.Name = "rbkawin"
        Me.rbkawin.Size = New System.Drawing.Size(54, 17)
        Me.rbkawin.TabIndex = 15
        Me.rbkawin.TabStop = True
        Me.rbkawin.Text = "Kawin"
        Me.rbkawin.UseVisualStyleBackColor = True
        '
        'cbagama
        '
        Me.cbagama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbagama.FormattingEnabled = True
        Me.cbagama.Items.AddRange(New Object() {"Islam", "Kristen", "Katolik", "Hindu", "Budha"})
        Me.cbagama.Location = New System.Drawing.Point(107, 65)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.Size = New System.Drawing.Size(133, 21)
        Me.cbagama.TabIndex = 14
        '
        'dttgllahir
        '
        Me.dttgllahir.Location = New System.Drawing.Point(107, 27)
        Me.dttgllahir.Name = "dttgllahir"
        Me.dttgllahir.Size = New System.Drawing.Size(216, 20)
        Me.dttgllahir.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(18, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(15, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Agama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(15, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tanggal Lahir"
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(29, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(29, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Jenis Kelamin"
        '
        'txtnip
        '
        Me.txtnip.Location = New System.Drawing.Point(112, 31)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(134, 20)
        Me.txtnip.TabIndex = 3
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(112, 71)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(134, 20)
        Me.txtnama.TabIndex = 4
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.ForeColor = System.Drawing.Color.White
        Me.rblaki.Location = New System.Drawing.Point(127, 104)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(70, 17)
        Me.rblaki.TabIndex = 5
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki - laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.ForeColor = System.Drawing.Color.White
        Me.rbperempuan.Location = New System.Drawing.Point(209, 104)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 6
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbperempuan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rblaki)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtnip)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(25, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 148)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtalamat)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txttelp)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(383, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 148)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kontak"
        '
        'txtalamat
        '
        Me.txtalamat.AcceptsTab = True
        Me.txtalamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtalamat.Location = New System.Drawing.Point(98, 31)
        Me.txtalamat.Multiline = False
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(207, 60)
        Me.txtalamat.TabIndex = 9
        Me.txtalamat.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Alamat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "No Telepon"
        '
        'txttelp
        '
        Me.txttelp.Location = New System.Drawing.Point(98, 104)
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(207, 20)
        Me.txttelp.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rbtidakkawin)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.rbkawin)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cbagama)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dttgllahir)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(25, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(329, 144)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Pribadi"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtgaji)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.cbjabatan)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.dttglmasuk)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(383, 237)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(346, 141)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Kerja"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 29)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Form Karyawan"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(280, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 32)
        Me.Panel1.TabIndex = 37
        '
        'karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(853, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.dgkaryawan)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karyawan"
        CType(Me.dgkaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GajianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents dgkaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents txtgaji As System.Windows.Forms.TextBox
    Friend WithEvents cbjabatan As System.Windows.Forms.ComboBox
    Friend WithEvents dttglmasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rbtidakkawin As System.Windows.Forms.RadioButton
    Friend WithEvents rbkawin As System.Windows.Forms.RadioButton
    Friend WithEvents cbagama As System.Windows.Forms.ComboBox
    Friend WithEvents dttgllahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GajianDataSet As Penggajian.gajianDataSet
    Friend WithEvents KaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KaryawanTableAdapter As Penggajian.gajianDataSetTableAdapters.karyawanTableAdapter
    Friend WithEvents NIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaKarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenkelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NohpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TgllahirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglmasukDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GajiPokokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents rblaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtalamat As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttelp As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
