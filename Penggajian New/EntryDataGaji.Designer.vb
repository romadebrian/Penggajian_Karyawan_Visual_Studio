<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntryDataGaji
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntryDataGaji))
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.dgtransaksi = New System.Windows.Forms.DataGridView()
        Me.NoslipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglgajianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaKarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglmasukDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiPokokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BiayaLemburDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalLemburDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BonusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsuransiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiBersihDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GajianDataSet = New Penggajian.gajianDataSet()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtgajibersih = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dttglmasuk = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dttglgajian = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtslip = New System.Windows.Forms.TextBox()
        Me.txtlembur = New System.Windows.Forms.TextBox()
        Me.txtbiaya = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtgaji = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtasuransi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbonus = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TransaksiTableAdapter = New Penggajian.gajianDataSetTableAdapters.transaksiTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtnip1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbjabatan = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GajianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsimpan
        '
        Me.btnsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.Image = CType(resources.GetObject("btnsimpan.Image"), System.Drawing.Image)
        Me.btnsimpan.Location = New System.Drawing.Point(662, 148)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(78, 73)
        Me.btnsimpan.TabIndex = 1
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.Image = CType(resources.GetObject("btntambah.Image"), System.Drawing.Image)
        Me.btntambah.Location = New System.Drawing.Point(662, 51)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(78, 73)
        Me.btntambah.TabIndex = 0
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.ForeColor = System.Drawing.Color.Transparent
        Me.btnkeluar.Image = CType(resources.GetObject("btnkeluar.Image"), System.Drawing.Image)
        Me.btnkeluar.Location = New System.Drawing.Point(662, 554)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(78, 73)
        Me.btnkeluar.TabIndex = 5
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Image = CType(resources.GetObject("btnupdate.Image"), System.Drawing.Image)
        Me.btnupdate.Location = New System.Drawing.Point(662, 452)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(78, 73)
        Me.btnupdate.TabIndex = 4
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Image = CType(resources.GetObject("btnhapus.Image"), System.Drawing.Image)
        Me.btnhapus.Location = New System.Drawing.Point(662, 349)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(78, 73)
        Me.btnhapus.TabIndex = 3
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'dgtransaksi
        '
        Me.dgtransaksi.AutoGenerateColumns = False
        Me.dgtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoslipDataGridViewTextBoxColumn, Me.TglgajianDataGridViewTextBoxColumn, Me.NIPDataGridViewTextBoxColumn, Me.NamaKarDataGridViewTextBoxColumn, Me.TglmasukDataGridViewTextBoxColumn, Me.JabatanDataGridViewTextBoxColumn, Me.GajiPokokDataGridViewTextBoxColumn, Me.BiayaLemburDataGridViewTextBoxColumn, Me.TotalLemburDataGridViewTextBoxColumn, Me.BonusDataGridViewTextBoxColumn, Me.AsuransiDataGridViewTextBoxColumn, Me.GajiBersihDataGridViewTextBoxColumn})
        Me.dgtransaksi.DataSource = Me.TransaksiBindingSource
        Me.dgtransaksi.Location = New System.Drawing.Point(12, 477)
        Me.dgtransaksi.Name = "dgtransaksi"
        Me.dgtransaksi.Size = New System.Drawing.Size(635, 150)
        Me.dgtransaksi.TabIndex = 100
        '
        'NoslipDataGridViewTextBoxColumn
        '
        Me.NoslipDataGridViewTextBoxColumn.DataPropertyName = "no_slip"
        Me.NoslipDataGridViewTextBoxColumn.HeaderText = "no_slip"
        Me.NoslipDataGridViewTextBoxColumn.Name = "NoslipDataGridViewTextBoxColumn"
        '
        'TglgajianDataGridViewTextBoxColumn
        '
        Me.TglgajianDataGridViewTextBoxColumn.DataPropertyName = "tgl_gajian"
        Me.TglgajianDataGridViewTextBoxColumn.HeaderText = "tgl_gajian"
        Me.TglgajianDataGridViewTextBoxColumn.Name = "TglgajianDataGridViewTextBoxColumn"
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
        'BiayaLemburDataGridViewTextBoxColumn
        '
        Me.BiayaLemburDataGridViewTextBoxColumn.DataPropertyName = "biayaLembur"
        Me.BiayaLemburDataGridViewTextBoxColumn.HeaderText = "biayaLembur"
        Me.BiayaLemburDataGridViewTextBoxColumn.Name = "BiayaLemburDataGridViewTextBoxColumn"
        '
        'TotalLemburDataGridViewTextBoxColumn
        '
        Me.TotalLemburDataGridViewTextBoxColumn.DataPropertyName = "totalLembur"
        Me.TotalLemburDataGridViewTextBoxColumn.HeaderText = "totalLembur"
        Me.TotalLemburDataGridViewTextBoxColumn.Name = "TotalLemburDataGridViewTextBoxColumn"
        '
        'BonusDataGridViewTextBoxColumn
        '
        Me.BonusDataGridViewTextBoxColumn.DataPropertyName = "bonus"
        Me.BonusDataGridViewTextBoxColumn.HeaderText = "bonus"
        Me.BonusDataGridViewTextBoxColumn.Name = "BonusDataGridViewTextBoxColumn"
        '
        'AsuransiDataGridViewTextBoxColumn
        '
        Me.AsuransiDataGridViewTextBoxColumn.DataPropertyName = "Asuransi"
        Me.AsuransiDataGridViewTextBoxColumn.HeaderText = "Asuransi"
        Me.AsuransiDataGridViewTextBoxColumn.Name = "AsuransiDataGridViewTextBoxColumn"
        '
        'GajiBersihDataGridViewTextBoxColumn
        '
        Me.GajiBersihDataGridViewTextBoxColumn.DataPropertyName = "gajiBersih"
        Me.GajiBersihDataGridViewTextBoxColumn.HeaderText = "gajiBersih"
        Me.GajiBersihDataGridViewTextBoxColumn.Name = "GajiBersihDataGridViewTextBoxColumn"
        '
        'TransaksiBindingSource
        '
        Me.TransaksiBindingSource.DataMember = "transaksi"
        Me.TransaksiBindingSource.DataSource = Me.GajianDataSet
        '
        'GajianDataSet
        '
        Me.GajianDataSet.DataSetName = "gajianDataSet"
        Me.GajianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Gaji Bersih"
        '
        'txtgajibersih
        '
        Me.txtgajibersih.ForeColor = System.Drawing.Color.Black
        Me.txtgajibersih.Location = New System.Drawing.Point(91, 19)
        Me.txtgajibersih.Name = "txtgajibersih"
        Me.txtgajibersih.Size = New System.Drawing.Size(184, 20)
        Me.txtgajibersih.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.ForeColor = System.Drawing.Color.Black
        Me.txtnama.Location = New System.Drawing.Point(91, 22)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(200, 20)
        Me.txtnama.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Nama"
        '
        'dttglmasuk
        '
        Me.dttglmasuk.Location = New System.Drawing.Point(91, 62)
        Me.dttglmasuk.Name = "dttglmasuk"
        Me.dttglmasuk.Size = New System.Drawing.Size(200, 20)
        Me.dttglmasuk.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Jabatan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Tanggal Masuk"
        '
        'dttglgajian
        '
        Me.dttglgajian.Location = New System.Drawing.Point(91, 17)
        Me.dttglgajian.Name = "dttglgajian"
        Me.dttglgajian.Size = New System.Drawing.Size(200, 20)
        Me.dttglgajian.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tanggal Gajian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "No Slip"
        '
        'txtslip
        '
        Me.txtslip.ForeColor = System.Drawing.Color.Black
        Me.txtslip.Location = New System.Drawing.Point(91, 17)
        Me.txtslip.Name = "txtslip"
        Me.txtslip.ReadOnly = True
        Me.txtslip.Size = New System.Drawing.Size(200, 20)
        Me.txtslip.TabIndex = 7
        '
        'txtlembur
        '
        Me.txtlembur.ForeColor = System.Drawing.Color.Black
        Me.txtlembur.Location = New System.Drawing.Point(106, 109)
        Me.txtlembur.Name = "txtlembur"
        Me.txtlembur.Size = New System.Drawing.Size(169, 20)
        Me.txtlembur.TabIndex = 15
        '
        'txtbiaya
        '
        Me.txtbiaya.ForeColor = System.Drawing.Color.Black
        Me.txtbiaya.Location = New System.Drawing.Point(106, 71)
        Me.txtbiaya.Name = "txtbiaya"
        Me.txtbiaya.Size = New System.Drawing.Size(169, 20)
        Me.txtbiaya.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total Jam Lembur"
        '
        'txtgaji
        '
        Me.txtgaji.ForeColor = System.Drawing.Color.Black
        Me.txtgaji.Location = New System.Drawing.Point(106, 32)
        Me.txtgaji.Name = "txtgaji"
        Me.txtgaji.Size = New System.Drawing.Size(169, 20)
        Me.txtgaji.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Biaya Lembur"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Gaji Pokok"
        '
        'txtasuransi
        '
        Me.txtasuransi.ForeColor = System.Drawing.Color.Black
        Me.txtasuransi.Location = New System.Drawing.Point(106, 35)
        Me.txtasuransi.Name = "txtasuransi"
        Me.txtasuransi.Size = New System.Drawing.Size(184, 20)
        Me.txtasuransi.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Bonus Gaji Lembur"
        '
        'txtbonus
        '
        Me.txtbonus.ForeColor = System.Drawing.Color.Black
        Me.txtbonus.Location = New System.Drawing.Point(106, 83)
        Me.txtbonus.Name = "txtbonus"
        Me.txtbonus.Size = New System.Drawing.Size(184, 20)
        Me.txtbonus.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Asuransi"
        '
        'TransaksiTableAdapter
        '
        Me.TransaksiTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtslip)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 51)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtnip1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 84)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pilih NIP Untuk Proses Gaji"
        '
        'txtnip1
        '
        Me.txtnip1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtnip1.FormattingEnabled = True
        Me.txtnip1.Location = New System.Drawing.Point(91, 36)
        Me.txtnip1.Name = "txtnip1"
        Me.txtnip1.Size = New System.Drawing.Size(200, 21)
        Me.txtnip1.TabIndex = 101
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "NIP"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cbjabatan)
        Me.GroupBox3.Controls.Add(Me.txtnama)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.dttglmasuk)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 238)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(305, 144)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Pribadi"
        '
        'cbjabatan
        '
        Me.cbjabatan.ForeColor = System.Drawing.Color.Black
        Me.cbjabatan.Location = New System.Drawing.Point(91, 111)
        Me.cbjabatan.Name = "cbjabatan"
        Me.cbjabatan.Size = New System.Drawing.Size(200, 20)
        Me.cbjabatan.TabIndex = 42
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtgajibersih)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(12, 400)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(305, 51)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.dttglgajian)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(342, 72)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(305, 52)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.txtlembur)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.txtbiaya)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.txtgaji)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(342, 132)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(305, 148)
        Me.GroupBox6.TabIndex = 40
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Gaji Bulanan"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.txtasuransi)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.txtbonus)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(342, 300)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(305, 151)
        Me.GroupBox7.TabIndex = 41
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Informasi Potongan Gaji"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(208, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 29)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Form Entry Data Gaji"
        '
        'btnCetak
        '
        Me.btnCetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.Location = New System.Drawing.Point(662, 247)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(78, 73)
        Me.btnCetak.TabIndex = 2
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'EntryDataGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(763, 699)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.dgtransaksi)
        Me.Name = "EntryDataGaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EntryDataGaji"
        CType(Me.dgtransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GajianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents dgtransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtgajibersih As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dttglmasuk As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dttglgajian As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtslip As System.Windows.Forms.TextBox
    Friend WithEvents txtlembur As System.Windows.Forms.TextBox
    Friend WithEvents txtbiaya As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtgaji As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtasuransi As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtbonus As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GajianDataSet As Penggajian.gajianDataSet
    Friend WithEvents TransaksiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransaksiTableAdapter As Penggajian.gajianDataSetTableAdapters.transaksiTableAdapter
    Friend WithEvents NoslipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglgajianDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaKarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglmasukDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GajiPokokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BiayaLemburDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalLemburDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BonusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsuransiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GajiBersihDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cbjabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtnip1 As System.Windows.Forms.ComboBox
End Class
