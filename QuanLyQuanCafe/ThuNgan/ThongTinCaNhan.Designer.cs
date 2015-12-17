namespace QuanLyQuanCafe.ThuNgan
{
    partial class ThongTinCaNhan
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
            this.lblNgayVaoLam = new MaterialSkin.Controls.MaterialLabel();
            this.lblNgaySinh = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLuu = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtXacNhan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMatKhauCu = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMatKhauMoi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblMaSo = new MaterialSkin.Controls.MaterialLabel();
            this.lblHoTen = new MaterialSkin.Controls.MaterialLabel();
            this.lblGioiTinh = new MaterialSkin.Controls.MaterialLabel();
            this.lblCMND = new MaterialSkin.Controls.MaterialLabel();
            this.lblDiaChi = new MaterialSkin.Controls.MaterialLabel();
            this.lblSoDienThoai = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Depth = 0;
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNgayVaoLam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNgayVaoLam.Location = new System.Drawing.Point(99, 426);
            this.lblNgayVaoLam.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lblNgayVaoLam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(108, 19);
            this.lblNgayVaoLam.TabIndex = 51;
            this.lblNgayVaoLam.Text = "Ngày vào làm: ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Depth = 0;
            this.lblNgaySinh.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNgaySinh.Location = new System.Drawing.Point(99, 230);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lblNgaySinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(83, 19);
            this.lblNgaySinh.TabIndex = 47;
            this.lblNgaySinh.Text = "Ngày sinh: ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(190, 24);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(159, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(682, 24);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(113, 19);
            this.materialLabel5.TabIndex = 56;
            this.materialLabel5.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtLuu
            // 
            this.txtLuu.Depth = 0;
            this.txtLuu.Location = new System.Drawing.Point(701, 238);
            this.txtLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLuu.Name = "txtLuu";
            this.txtLuu.Primary = true;
            this.txtLuu.Size = new System.Drawing.Size(75, 23);
            this.txtLuu.TabIndex = 0;
            this.txtLuu.Text = "LƯU";
            this.txtLuu.UseVisualStyleBackColor = true;
            this.txtLuu.Click += new System.EventHandler(this.txtLuu_Click);
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Depth = 0;
            this.txtXacNhan.Hint = "Xác nhận mật khẩu";
            this.txtXacNhan.Location = new System.Drawing.Point(571, 181);
            this.txtXacNhan.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.txtXacNhan.MaxLength = 20;
            this.txtXacNhan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '\0';
            this.txtXacNhan.SelectedText = "";
            this.txtXacNhan.SelectionLength = 0;
            this.txtXacNhan.SelectionStart = 0;
            this.txtXacNhan.Size = new System.Drawing.Size(335, 23);
            this.txtXacNhan.TabIndex = 58;
            this.txtXacNhan.TabStop = false;
            this.txtXacNhan.UseSystemPasswordChar = true;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Depth = 0;
            this.txtMatKhauCu.Hint = "Mật khẩu cũ";
            this.txtMatKhauCu.Location = new System.Drawing.Point(571, 83);
            this.txtMatKhauCu.MaxLength = 20;
            this.txtMatKhauCu.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '\0';
            this.txtMatKhauCu.SelectedText = "";
            this.txtMatKhauCu.SelectionLength = 0;
            this.txtMatKhauCu.SelectionStart = 0;
            this.txtMatKhauCu.Size = new System.Drawing.Size(335, 23);
            this.txtMatKhauCu.TabIndex = 59;
            this.txtMatKhauCu.TabStop = false;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Depth = 0;
            this.txtMatKhauMoi.Hint = "Mật khẩu mới";
            this.txtMatKhauMoi.Location = new System.Drawing.Point(571, 132);
            this.txtMatKhauMoi.MaxLength = 20;
            this.txtMatKhauMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '\0';
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.SelectionLength = 0;
            this.txtMatKhauMoi.SelectionStart = 0;
            this.txtMatKhauMoi.Size = new System.Drawing.Size(335, 23);
            this.txtMatKhauMoi.TabIndex = 60;
            this.txtMatKhauMoi.TabStop = false;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Depth = 0;
            this.lblMaSo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMaSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMaSo.Location = new System.Drawing.Point(99, 83);
            this.lblMaSo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(59, 19);
            this.lblMaSo.TabIndex = 61;
            this.lblMaSo.Text = "Mã số: ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Depth = 0;
            this.lblHoTen.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHoTen.Location = new System.Drawing.Point(99, 132);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lblHoTen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(62, 19);
            this.lblHoTen.TabIndex = 62;
            this.lblHoTen.Text = "Họ tên: ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.BackColor = System.Drawing.Color.White;
            this.lblGioiTinh.Depth = 0;
            this.lblGioiTinh.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(99, 181);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lblGioiTinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(73, 19);
            this.lblGioiTinh.TabIndex = 33;
            this.lblGioiTinh.Text = "Giới tính: ";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Depth = 0;
            this.lblCMND.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCMND.Location = new System.Drawing.Point(99, 279);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lblCMND.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(83, 19);
            this.lblCMND.TabIndex = 63;
            this.lblCMND.Text = "Số CMND: ";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Depth = 0;
            this.lblDiaChi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDiaChi.Location = new System.Drawing.Point(99, 328);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lblDiaChi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(63, 19);
            this.lblDiaChi.TabIndex = 64;
            this.lblDiaChi.Text = "Địa chỉ: ";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Depth = 0;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSoDienThoai.Location = new System.Drawing.Point(99, 377);
            this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lblSoDienThoai.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(106, 19);
            this.lblSoDienThoai.TabIndex = 65;
            this.lblSoDienThoai.Text = "Số điện thoại: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSoDienThoai);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaSo);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.txtLuu);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblNgayVaoLam);
            this.Controls.Add(this.lblNgaySinh);
            this.Name = "ThongTinCaNhan";
            this.Size = new System.Drawing.Size(985, 550);
            this.Load += new System.EventHandler(this.ThongTinCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblNgayVaoLam;
        private MaterialSkin.Controls.MaterialLabel lblNgaySinh;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton txtLuu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtXacNhan;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatKhauCu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMatKhauMoi;
        private MaterialSkin.Controls.MaterialLabel lblMaSo;
        private MaterialSkin.Controls.MaterialLabel lblHoTen;
        private MaterialSkin.Controls.MaterialLabel lblGioiTinh;
        private MaterialSkin.Controls.MaterialLabel lblCMND;
        private MaterialSkin.Controls.MaterialLabel lblDiaChi;
        private MaterialSkin.Controls.MaterialLabel lblSoDienThoai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
