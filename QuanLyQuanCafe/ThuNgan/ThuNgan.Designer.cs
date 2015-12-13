

namespace QuanLyQuanCafe.ThuNgan
{
    partial class ThuNgan
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
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabQuanLyBan = new System.Windows.Forms.TabPage();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.tabBaoCao = new System.Windows.Forms.TabPage();
            this.tabThongTinCaNhan = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabQuanLyBan);
            this.tabControl1.Controls.Add(this.tabHoaDon);
            this.tabControl1.Controls.Add(this.tabBaoCao);
            this.tabControl1.Controls.Add(this.tabThongTinCaNhan);
            this.tabControl1.Depth = 0;
            this.tabControl1.Location = new System.Drawing.Point(0, 104);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tabQuanLyBan
            // 
            this.tabQuanLyBan.Location = new System.Drawing.Point(4, 22);
            this.tabQuanLyBan.Name = "tabQuanLyBan";
            this.tabQuanLyBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLyBan.Size = new System.Drawing.Size(1258, 520);
            this.tabQuanLyBan.TabIndex = 0;
            this.tabQuanLyBan.Text = "Quản lý bàn";
            this.tabQuanLyBan.UseVisualStyleBackColor = true;
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tabHoaDon.Name = "tabHoaDon";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoaDon.Size = new System.Drawing.Size(1258, 520);
            this.tabHoaDon.TabIndex = 1;
            this.tabHoaDon.Text = "Hóa đơn";
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Location = new System.Drawing.Point(4, 22);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaoCao.Size = new System.Drawing.Size(1258, 520);
            this.tabBaoCao.TabIndex = 2;
            this.tabBaoCao.Text = "Báo cáo hàng ngày";
            this.tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // tabThongTinCaNhan
            // 
            this.tabThongTinCaNhan.BackColor = System.Drawing.Color.White;
            this.tabThongTinCaNhan.Location = new System.Drawing.Point(4, 22);
            this.tabThongTinCaNhan.Name = "tabThongTinCaNhan";
            this.tabThongTinCaNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongTinCaNhan.Size = new System.Drawing.Size(1258, 520);
            this.tabThongTinCaNhan.TabIndex = 3;
            this.tabThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1266, 37);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // ThuNgan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 650);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ThuNgan";
            this.Text = "Quản lý quán cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.ThuNgan_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabBaoCao;
        private System.Windows.Forms.TabPage tabHoaDon;
        private System.Windows.Forms.TabPage tabThongTinCaNhan;
        private System.Windows.Forms.TabPage tabQuanLyBan;
    }
}