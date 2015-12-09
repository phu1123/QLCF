

using System.Windows.Forms;

namespace QuanLyQuanCafe.QuanLy
{
    partial class NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTimKiem = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.rbtnQuanLy = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnThuNgan = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.rbtnNam = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnNu = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnHuy = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnYes = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtTenNV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSoDienThoai = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDiaChi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtCmnd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMatKhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTenDangNhap = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnThem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.btnThem);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2MinSize = 320;
            this.splitContainer1.Size = new System.Drawing.Size(1075, 536);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Depth = 0;
            this.txtTimKiem.Hint = "Tìm kiếm";
            this.txtTimKiem.Location = new System.Drawing.Point(349, 14);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.Size = new System.Drawing.Size(246, 23);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TabStop = false;
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(598, 491);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MSNV";
            this.Column1.HeaderText = "MSNV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "SoDienThoai";
            this.Column3.HeaderText = "SĐT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "PhanQuyen";
            this.Column4.HeaderText = "Chức vụ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnYes);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.dtpNgayVaoLam);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.txtSoDienThoai);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.txtCmnd);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 461);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.rbtnQuanLy);
            this.panel3.Controls.Add(this.rbtnThuNgan);
            this.panel3.Location = new System.Drawing.Point(0, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 24);
            this.panel3.TabIndex = 42;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(11, 4);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(67, 19);
            this.materialLabel4.TabIndex = 32;
            this.materialLabel4.Text = "Chức vụ:";
            // 
            // rbtnQuanLy
            // 
            this.rbtnQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnQuanLy.AutoSize = true;
            this.rbtnQuanLy.Depth = 0;
            this.rbtnQuanLy.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnQuanLy.Location = new System.Drawing.Point(95, -1);
            this.rbtnQuanLy.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnQuanLy.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnQuanLy.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnQuanLy.Name = "rbtnQuanLy";
            this.rbtnQuanLy.Ripple = true;
            this.rbtnQuanLy.Size = new System.Drawing.Size(75, 30);
            this.rbtnQuanLy.TabIndex = 26;
            this.rbtnQuanLy.TabStop = true;
            this.rbtnQuanLy.Text = "Quản lý";
            this.rbtnQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbtnThuNgan
            // 
            this.rbtnThuNgan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnThuNgan.AutoSize = true;
            this.rbtnThuNgan.Depth = 0;
            this.rbtnThuNgan.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnThuNgan.Location = new System.Drawing.Point(198, -1);
            this.rbtnThuNgan.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnThuNgan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnThuNgan.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnThuNgan.Name = "rbtnThuNgan";
            this.rbtnThuNgan.Ripple = true;
            this.rbtnThuNgan.Size = new System.Drawing.Size(89, 30);
            this.rbtnThuNgan.TabIndex = 27;
            this.rbtnThuNgan.TabStop = true;
            this.rbtnThuNgan.Text = "Thu Ngân";
            this.rbtnThuNgan.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.rbtnNam);
            this.panel2.Controls.Add(this.rbtnNu);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 24);
            this.panel2.TabIndex = 41;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 4);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 32;
            this.materialLabel2.Text = "Giới tính:";
            // 
            // rbtnNam
            // 
            this.rbtnNam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Depth = 0;
            this.rbtnNam.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnNam.Location = new System.Drawing.Point(95, -1);
            this.rbtnNam.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnNam.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnNam.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Ripple = true;
            this.rbtnNam.Size = new System.Drawing.Size(58, 30);
            this.rbtnNam.TabIndex = 26;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // rbtnNu
            // 
            this.rbtnNu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Depth = 0;
            this.rbtnNu.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnNu.Location = new System.Drawing.Point(198, -1);
            this.rbtnNu.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnNu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnNu.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Ripple = true;
            this.rbtnNu.Size = new System.Drawing.Size(47, 30);
            this.rbtnNu.TabIndex = 27;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.AutoSize = true;
            this.btnHuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHuy.Depth = 0;
            this.btnHuy.Location = new System.Drawing.Point(410, 413);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.btnHuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Primary = false;
            this.btnHuy.Size = new System.Drawing.Size(39, 36);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.AutoSize = true;
            this.btnYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYes.Depth = 0;
            this.btnYes.Location = new System.Drawing.Point(352, 413);
            this.btnYes.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Primary = false;
            this.btnYes.Size = new System.Drawing.Size(50, 36);
            this.btnYes.TabIndex = 39;
            this.btnYes.Text = "Thêm";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenNV.Depth = 0;
            this.txtTenNV.Hint = "Họ tên";
            this.txtTenNV.Location = new System.Drawing.Point(15, 101);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtTenNV.MaxLength = 50;
            this.txtTenNV.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.SelectionLength = 0;
            this.txtTenNV.SelectionStart = 0;
            this.txtTenNV.Size = new System.Drawing.Size(434, 23);
            this.txtTenNV.TabIndex = 2;
            this.txtTenNV.TabStop = false;
            this.txtTenNV.UseSystemPasswordChar = false;
            this.txtTenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_KeyPress);
            // 
            // dtpNgayVaoLam
            // 
            this.dtpNgayVaoLam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayVaoLam.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVaoLam.Location = new System.Drawing.Point(121, 334);
            this.dtpNgayVaoLam.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            this.dtpNgayVaoLam.Size = new System.Drawing.Size(328, 20);
            this.dtpNgayVaoLam.TabIndex = 8;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(11, 334);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(104, 19);
            this.materialLabel3.TabIndex = 37;
            this.materialLabel3.Text = "Ngày vào làm:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoDienThoai.Depth = 0;
            this.txtSoDienThoai.Hint = "Số điện thoại";
            this.txtSoDienThoai.Location = new System.Drawing.Point(15, 293);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtSoDienThoai.MaxLength = 12;
            this.txtSoDienThoai.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.PasswordChar = '\0';
            this.txtSoDienThoai.SelectedText = "";
            this.txtSoDienThoai.SelectionLength = 0;
            this.txtSoDienThoai.SelectionStart = 0;
            this.txtSoDienThoai.Size = new System.Drawing.Size(434, 23);
            this.txtSoDienThoai.TabIndex = 7;
            this.txtSoDienThoai.TabStop = false;
            this.txtSoDienThoai.UseSystemPasswordChar = false;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Depth = 0;
            this.txtDiaChi.Hint = "Địa chỉ";
            this.txtDiaChi.Location = new System.Drawing.Point(15, 252);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtDiaChi.MaxLength = 100;
            this.txtDiaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.Size = new System.Drawing.Size(434, 23);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.TabStop = false;
            this.txtDiaChi.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 177);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(121, 177);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(328, 20);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCmnd.Depth = 0;
            this.txtCmnd.Hint = "Số CMND";
            this.txtCmnd.Location = new System.Drawing.Point(15, 211);
            this.txtCmnd.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtCmnd.MaxLength = 12;
            this.txtCmnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.PasswordChar = '\0';
            this.txtCmnd.SelectedText = "";
            this.txtCmnd.SelectionLength = 0;
            this.txtCmnd.SelectionStart = 0;
            this.txtCmnd.Size = new System.Drawing.Size(434, 23);
            this.txtCmnd.TabIndex = 4;
            this.txtCmnd.TabStop = false;
            this.txtCmnd.UseSystemPasswordChar = false;
            this.txtCmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCMND_KeyPress);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Depth = 0;
            this.txtMatKhau.Hint = "Mật khẩu";
            this.txtMatKhau.Location = new System.Drawing.Point(15, 60);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(15, 15, 20, 3);
            this.txtMatKhau.MaxLength = 20;
            this.txtMatKhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.Size = new System.Drawing.Size(434, 23);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.TabStop = false;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDangNhap.Depth = 0;
            this.txtTenDangNhap.Hint = "Tên đăng nhập";
            this.txtTenDangNhap.Location = new System.Drawing.Point(15, 19);
            this.txtTenDangNhap.MaxLength = 20;
            this.txtTenDangNhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.SelectionLength = 0;
            this.txtTenDangNhap.SelectionStart = 0;
            this.txtTenDangNhap.Size = new System.Drawing.Size(434, 23);
            this.txtTenDangNhap.TabIndex = 0;
            this.txtTenDangNhap.TabStop = false;
            this.txtTenDangNhap.UseSystemPasswordChar = false;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Depth = 0;
            this.btnThem.Location = new System.Drawing.Point(276, 15);
            this.btnThem.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Primary = true;
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Depth = 0;
            this.btnXoa.Location = new System.Drawing.Point(374, 15);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(20, 15, 20, 3);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Primary = true;
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(1075, 536);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRadioButton rbtnQuanLy;
        private MaterialSkin.Controls.MaterialRadioButton rbtnThuNgan;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton rbtnNam;
        private MaterialSkin.Controls.MaterialRadioButton rbtnNu;
        private MaterialSkin.Controls.MaterialFlatButton btnHuy;
        private MaterialSkin.Controls.MaterialFlatButton btnYes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenNV;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoDienThoai;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDiaChi;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCmnd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatKhau;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenDangNhap;
        private MaterialSkin.Controls.MaterialRaisedButton btnThem;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTimKiem;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
