namespace QuanLyQuanCafe.QuanLy
{
    partial class HangHoa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnNhapHang = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThemMenu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabNoHeader1 = new QuanLyQuanCafe.TabNoHeader();
            this.tabThem = new System.Windows.Forms.TabPage();
            this.txtSoLuongTon = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnHuy = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnThem = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtGhiChu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTenHangHoa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDonViTinh = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtGiaBan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabNhapHang = new System.Windows.Forms.TabPage();
            this.lblTongTien = new MaterialSkin.Controls.MaterialLabel();
            this.nudThue = new System.Windows.Forms.NumericUpDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtGhiChuHoaDon = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNhaCungCap = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnHuy2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNhap = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtSoHoaDon = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabNoHeader1.SuspendLayout();
            this.tabThem.SuspendLayout();
            this.tabNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(651, 626);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "TenHangHoa";
            this.Column1.HeaderText = "Tên hàng hóa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "GiaBan";
            this.Column2.HeaderText = "Giá bán (VNĐ)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DonViTinh";
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SoLuongTon";
            this.Column4.HeaderText = "Số lượng tồn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTimKiem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabNoHeader1);
            this.splitContainer1.Panel2.Controls.Add(this.btnNhapHang);
            this.splitContainer1.Panel2.Controls.Add(this.btnThemMenu);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2MinSize = 350;
            this.splitContainer1.Size = new System.Drawing.Size(1120, 671);
            this.splitContainer1.SplitterDistance = 653;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Hint = "Tìm kiếm";
            this.txtTimKiem.Location = new System.Drawing.Point(402, 15);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.Size = new System.Drawing.Size(246, 23);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapHang.Depth = 0;
            this.btnNhapHang.Location = new System.Drawing.Point(140, 15);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnNhapHang.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Primary = true;
            this.btnNhapHang.Size = new System.Drawing.Size(105, 35);
            this.btnNhapHang.TabIndex = 44;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnThemMenu
            // 
            this.btnThemMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMenu.Depth = 0;
            this.btnThemMenu.Location = new System.Drawing.Point(268, 15);
            this.btnThemMenu.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnThemMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemMenu.Name = "btnThemMenu";
            this.btnThemMenu.Primary = true;
            this.btnThemMenu.Size = new System.Drawing.Size(75, 35);
            this.btnThemMenu.TabIndex = 43;
            this.btnThemMenu.Text = "Thêm";
            this.btnThemMenu.UseVisualStyleBackColor = true;
            this.btnThemMenu.Click += new System.EventHandler(this.btnThemMenu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Depth = 0;
            this.btnXoa.Location = new System.Drawing.Point(366, 15);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(20, 15, 20, 3);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // tabNoHeader1
            // 
            this.tabNoHeader1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabNoHeader1.Controls.Add(this.tabThem);
            this.tabNoHeader1.Controls.Add(this.tabNhapHang);
            this.tabNoHeader1.Location = new System.Drawing.Point(0, 56);
            this.tabNoHeader1.Name = "tabNoHeader1";
            this.tabNoHeader1.SelectedIndex = 0;
            this.tabNoHeader1.Size = new System.Drawing.Size(461, 614);
            this.tabNoHeader1.TabIndex = 50;
            // 
            // tabThem
            // 
            this.tabThem.BackColor = System.Drawing.Color.White;
            this.tabThem.Controls.Add(this.txtSoLuongTon);
            this.tabThem.Controls.Add(this.btnHuy);
            this.tabThem.Controls.Add(this.btnThem);
            this.tabThem.Controls.Add(this.txtGhiChu);
            this.tabThem.Controls.Add(this.txtTenHangHoa);
            this.tabThem.Controls.Add(this.txtDonViTinh);
            this.tabThem.Controls.Add(this.txtGiaBan);
            this.tabThem.Location = new System.Drawing.Point(4, 22);
            this.tabThem.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.tabThem.Name = "tabThem";
            this.tabThem.Padding = new System.Windows.Forms.Padding(3);
            this.tabThem.Size = new System.Drawing.Size(453, 588);
            this.tabThem.TabIndex = 0;
            this.tabThem.Text = "tabThem";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuongTon.Depth = 0;
            this.txtSoLuongTon.Hint = "Số lượng tồn";
            this.txtSoLuongTon.Location = new System.Drawing.Point(18, 148);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtSoLuongTon.MaxLength = 10;
            this.txtSoLuongTon.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.PasswordChar = '\0';
            this.txtSoLuongTon.SelectedText = "";
            this.txtSoLuongTon.SelectionLength = 0;
            this.txtSoLuongTon.SelectionStart = 0;
            this.txtSoLuongTon.Size = new System.Drawing.Size(419, 23);
            this.txtSoLuongTon.TabIndex = 44;
            this.txtSoLuongTon.TabStop = false;
            this.txtSoLuongTon.UseSystemPasswordChar = false;
            this.txtSoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.AutoSize = true;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Depth = 0;
            this.btnHuy.Location = new System.Drawing.Point(398, 245);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Primary = false;
            this.btnHuy.Size = new System.Drawing.Size(39, 36);
            this.btnHuy.TabIndex = 41;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.AutoSize = true;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Depth = 0;
            this.btnThem.Location = new System.Drawing.Point(339, 245);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = false;
            this.btnThem.Size = new System.Drawing.Size(50, 36);
            this.btnThem.TabIndex = 40;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Depth = 0;
            this.txtGhiChu.Hint = "Ghi chú";
            this.txtGhiChu.Location = new System.Drawing.Point(18, 189);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGhiChu.MaxLength = 200;
            this.txtGhiChu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.SelectionLength = 0;
            this.txtGhiChu.SelectionStart = 0;
            this.txtGhiChu.Size = new System.Drawing.Size(419, 23);
            this.txtGhiChu.TabIndex = 43;
            this.txtGhiChu.TabStop = false;
            this.txtGhiChu.UseSystemPasswordChar = false;
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenHangHoa.Depth = 0;
            this.txtTenHangHoa.Hint = "Tên hàng hóa";
            this.txtTenHangHoa.Location = new System.Drawing.Point(18, 25);
            this.txtTenHangHoa.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.txtTenHangHoa.MaxLength = 50;
            this.txtTenHangHoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.PasswordChar = '\0';
            this.txtTenHangHoa.SelectedText = "";
            this.txtTenHangHoa.SelectionLength = 0;
            this.txtTenHangHoa.SelectionStart = 0;
            this.txtTenHangHoa.Size = new System.Drawing.Size(419, 23);
            this.txtTenHangHoa.TabIndex = 9;
            this.txtTenHangHoa.TabStop = false;
            this.txtTenHangHoa.UseSystemPasswordChar = false;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonViTinh.Depth = 0;
            this.txtDonViTinh.Hint = "Đơn vị tính";
            this.txtDonViTinh.Location = new System.Drawing.Point(18, 107);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtDonViTinh.MaxLength = 20;
            this.txtDonViTinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.PasswordChar = '\0';
            this.txtDonViTinh.SelectedText = "";
            this.txtDonViTinh.SelectionLength = 0;
            this.txtDonViTinh.SelectionStart = 0;
            this.txtDonViTinh.Size = new System.Drawing.Size(419, 23);
            this.txtDonViTinh.TabIndex = 42;
            this.txtDonViTinh.TabStop = false;
            this.txtDonViTinh.UseSystemPasswordChar = false;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaBan.Depth = 0;
            this.txtGiaBan.Hint = "Giá bán (VND)";
            this.txtGiaBan.Location = new System.Drawing.Point(18, 66);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGiaBan.MaxLength = 10;
            this.txtGiaBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.SelectionLength = 0;
            this.txtGiaBan.SelectionStart = 0;
            this.txtGiaBan.Size = new System.Drawing.Size(419, 23);
            this.txtGiaBan.TabIndex = 10;
            this.txtGiaBan.TabStop = false;
            this.txtGiaBan.UseSystemPasswordChar = false;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // tabNhapHang
            // 
            this.tabNhapHang.BackColor = System.Drawing.Color.White;
            this.tabNhapHang.Controls.Add(this.lblTongTien);
            this.tabNhapHang.Controls.Add(this.nudThue);
            this.tabNhapHang.Controls.Add(this.materialLabel1);
            this.tabNhapHang.Controls.Add(this.materialLabel2);
            this.tabNhapHang.Controls.Add(this.dataGridView2);
            this.tabNhapHang.Controls.Add(this.materialLabel4);
            this.tabNhapHang.Controls.Add(this.dtpNgayNhap);
            this.tabNhapHang.Controls.Add(this.txtDiaChi);
            this.tabNhapHang.Controls.Add(this.txtGhiChuHoaDon);
            this.tabNhapHang.Controls.Add(this.txtNhaCungCap);
            this.tabNhapHang.Controls.Add(this.btnHuy2);
            this.tabNhapHang.Controls.Add(this.btnNhap);
            this.tabNhapHang.Controls.Add(this.txtSoHoaDon);
            this.tabNhapHang.Location = new System.Drawing.Point(4, 22);
            this.tabNhapHang.Name = "tabNhapHang";
            this.tabNhapHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapHang.Size = new System.Drawing.Size(453, 588);
            this.tabNhapHang.TabIndex = 1;
            this.tabNhapHang.Text = "tabNhapHang";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.Depth = 0;
            this.lblTongTien.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTongTien.Location = new System.Drawing.Point(141, 491);
            this.lblTongTien.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTongTien.Size = new System.Drawing.Size(296, 19);
            this.lblTongTien.TabIndex = 62;
            this.lblTongTien.Text = "0";
            // 
            // nudThue
            // 
            this.nudThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudThue.DecimalPlaces = 1;
            this.nudThue.Location = new System.Drawing.Point(132, 444);
            this.nudThue.Name = "nudThue";
            this.nudThue.Size = new System.Drawing.Size(305, 20);
            this.nudThue.TabIndex = 61;
            this.nudThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudThue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudThue.ValueChanged += new System.EventHandler(this.nudThue_ValueChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 445);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 19);
            this.materialLabel1.TabIndex = 60;
            this.materialLabel1.Text = "Thuế GTGT (%):";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 491);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(121, 19);
            this.materialLabel2.TabIndex = 59;
            this.materialLabel2.Text = "Tổng tiền (VNĐ):";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView2.Location = new System.Drawing.Point(18, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.Size = new System.Drawing.Size(419, 178);
            this.dataGridView2.TabIndex = 58;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            this.dataGridView2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView2_KeyPress);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TenHangHoa";
            this.Column5.HeaderText = "Tên hàng hóa";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "GiaMua";
            this.Column6.HeaderText = "Giá mua";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "SoLuong";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "ThanhTien";
            this.Column8.HeaderText = "Thành tiền";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(14, 69);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(83, 19);
            this.materialLabel4.TabIndex = 57;
            this.materialLabel4.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(132, 69);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(305, 20);
            this.dtpNgayNhap.TabIndex = 56;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Depth = 0;
            this.txtDiaChi.Hint = "Địa chỉ";
            this.txtDiaChi.Location = new System.Drawing.Point(18, 148);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtDiaChi.MaxLength = 10;
            this.txtDiaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.Size = new System.Drawing.Size(419, 23);
            this.txtDiaChi.TabIndex = 55;
            this.txtDiaChi.TabStop = false;
            this.txtDiaChi.UseSystemPasswordChar = false;
            // 
            // txtGhiChuHoaDon
            // 
            this.txtGhiChuHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChuHoaDon.Depth = 0;
            this.txtGhiChuHoaDon.Hint = "Ghi chú";
            this.txtGhiChuHoaDon.Location = new System.Drawing.Point(18, 189);
            this.txtGhiChuHoaDon.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtGhiChuHoaDon.MaxLength = 200;
            this.txtGhiChuHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            this.txtGhiChuHoaDon.PasswordChar = '\0';
            this.txtGhiChuHoaDon.SelectedText = "";
            this.txtGhiChuHoaDon.SelectionLength = 0;
            this.txtGhiChuHoaDon.SelectionStart = 0;
            this.txtGhiChuHoaDon.Size = new System.Drawing.Size(419, 23);
            this.txtGhiChuHoaDon.TabIndex = 54;
            this.txtGhiChuHoaDon.TabStop = false;
            this.txtGhiChuHoaDon.UseSystemPasswordChar = false;
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhaCungCap.Depth = 0;
            this.txtNhaCungCap.Hint = "Nhà cung cấp";
            this.txtNhaCungCap.Location = new System.Drawing.Point(18, 107);
            this.txtNhaCungCap.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtNhaCungCap.MaxLength = 20;
            this.txtNhaCungCap.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.PasswordChar = '\0';
            this.txtNhaCungCap.SelectedText = "";
            this.txtNhaCungCap.SelectionLength = 0;
            this.txtNhaCungCap.SelectionStart = 0;
            this.txtNhaCungCap.Size = new System.Drawing.Size(419, 23);
            this.txtNhaCungCap.TabIndex = 53;
            this.txtNhaCungCap.TabStop = false;
            this.txtNhaCungCap.UseSystemPasswordChar = false;
            // 
            // btnHuy2
            // 
            this.btnHuy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy2.AutoSize = true;
            this.btnHuy2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy2.Depth = 0;
            this.btnHuy2.Location = new System.Drawing.Point(398, 543);
            this.btnHuy2.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.btnHuy2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy2.Name = "btnHuy2";
            this.btnHuy2.Primary = false;
            this.btnHuy2.Size = new System.Drawing.Size(39, 36);
            this.btnHuy2.TabIndex = 52;
            this.btnHuy2.Text = "Hủy";
            this.btnHuy2.UseVisualStyleBackColor = true;
            this.btnHuy2.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhap.AutoSize = true;
            this.btnNhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNhap.Depth = 0;
            this.btnNhap.Location = new System.Drawing.Point(339, 543);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.btnNhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Primary = false;
            this.btnNhap.Size = new System.Drawing.Size(49, 36);
            this.btnNhap.TabIndex = 51;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtSoHoaDon
            // 
            this.txtSoHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoHoaDon.Depth = 0;
            this.txtSoHoaDon.Hint = "Số Hóa Đơn";
            this.txtSoHoaDon.Location = new System.Drawing.Point(18, 28);
            this.txtSoHoaDon.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.txtSoHoaDon.MaxLength = 50;
            this.txtSoHoaDon.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoHoaDon.Name = "txtSoHoaDon";
            this.txtSoHoaDon.PasswordChar = '\0';
            this.txtSoHoaDon.SelectedText = "";
            this.txtSoHoaDon.SelectionLength = 0;
            this.txtSoHoaDon.SelectionStart = 0;
            this.txtSoHoaDon.Size = new System.Drawing.Size(419, 23);
            this.txtSoHoaDon.TabIndex = 50;
            this.txtSoHoaDon.TabStop = false;
            this.txtSoHoaDon.UseSystemPasswordChar = false;
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "HangHoa";
            this.Size = new System.Drawing.Size(1120, 671);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabNoHeader1.ResumeLayout(false);
            this.tabThem.ResumeLayout(false);
            this.tabThem.PerformLayout();
            this.tabNhapHang.ResumeLayout(false);
            this.tabNhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenHangHoa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGiaBan;
        private MaterialSkin.Controls.MaterialFlatButton btnThem;
        private MaterialSkin.Controls.MaterialFlatButton btnHuy;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTimKiem;
        private MaterialSkin.Controls.MaterialRaisedButton btnThemMenu;
        private MaterialSkin.Controls.MaterialRaisedButton btnNhapHang;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDonViTinh;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGhiChu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoLuongTon;
        private TabNoHeader tabNoHeader1;
        private System.Windows.Forms.TabPage tabThem;
        private System.Windows.Forms.TabPage tabNhapHang;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiaChi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGhiChuHoaDon;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNhaCungCap;
        private MaterialSkin.Controls.MaterialFlatButton btnHuy2;
        private MaterialSkin.Controls.MaterialFlatButton btnNhap;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoHoaDon;
        private System.Windows.Forms.NumericUpDown nudThue;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
