namespace QuanLyQuanCafe.QuanLy
{
    partial class QuanLy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabHangHoa = new System.Windows.Forms.TabPage();
            this.tabKhuVuc = new System.Windows.Forms.TabPage();
            this.tabBaoCao = new System.Windows.Forms.TabPage();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1275, 37);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabNhanVien);
            this.materialTabControl1.Controls.Add(this.tabHangHoa);
            this.materialTabControl1.Controls.Add(this.tabKhuVuc);
            this.materialTabControl1.Controls.Add(this.tabBaoCao);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 104);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1275, 546);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.BackColor = System.Drawing.Color.White;
            this.tabNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(1267, 520);
            this.tabNhanVien.TabIndex = 0;
            this.tabNhanVien.Text = "Nhân viên";
            // 
            // tabHangHoa
            // 
            this.tabHangHoa.Location = new System.Drawing.Point(4, 22);
            this.tabHangHoa.Name = "tabHangHoa";
            this.tabHangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabHangHoa.Size = new System.Drawing.Size(1267, 520);
            this.tabHangHoa.TabIndex = 1;
            this.tabHangHoa.Text = "Hàng hóa";
            // 
            // tabKhuVuc
            // 
            this.tabKhuVuc.BackColor = System.Drawing.Color.White;
            this.tabKhuVuc.Location = new System.Drawing.Point(4, 22);
            this.tabKhuVuc.Name = "tabKhuVuc";
            this.tabKhuVuc.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhuVuc.Size = new System.Drawing.Size(1267, 520);
            this.tabKhuVuc.TabIndex = 2;
            this.tabKhuVuc.Text = "Khu vực";
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Location = new System.Drawing.Point(4, 22);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoCao.Size = new System.Drawing.Size(1267, 520);
            this.tabBaoCao.TabIndex = 3;
            this.tabBaoCao.Text = "Báo cáo";
            this.tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 650);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "QuanLy";
            this.Text = "Quản lý quán cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLy_FormClosing);
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabHangHoa;
        private System.Windows.Forms.TabPage tabKhuVuc;
        private System.Windows.Forms.TabPage tabBaoCao;
        private System.Windows.Forms.TabPage tabNhanVien;
    }
}