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
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.tabPageMenu = new System.Windows.Forms.TabPage();
            this.tabPageArea = new System.Windows.Forms.TabPage();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.hangHoa2 = new QuanLyQuanCafe.QuanLy.HangHoa();
            this.hangHoa1 = new QuanLyQuanCafe.QuanLy.HangHoa();
            this.khuVuc1 = new QuanLyQuanCafe.QuanLy.KhuVuc();
            this.baoCao1 = new QuanLyQuanCafe.QuanLy.BaoCao();
            this.materialTabControl1.SuspendLayout();
            this.tabPageMenu.SuspendLayout();
            this.tabPageArea.SuspendLayout();
            this.tabPageReport.SuspendLayout();
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
            this.materialTabControl1.Controls.Add(this.tabPageEmployee);
            this.materialTabControl1.Controls.Add(this.tabPageMenu);
            this.materialTabControl1.Controls.Add(this.tabPageArea);
            this.materialTabControl1.Controls.Add(this.tabPageReport);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 104);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1275, 546);
            this.materialTabControl1.TabIndex = 2;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.BackColor = System.Drawing.Color.White;
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(1267, 520);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Nhân viên";
            // 
            // tabPageMenu
            // 
            this.tabPageMenu.Controls.Add(this.hangHoa2);
            this.tabPageMenu.Controls.Add(this.hangHoa1);
            this.tabPageMenu.Location = new System.Drawing.Point(4, 22);
            this.tabPageMenu.Name = "tabPageMenu";
            this.tabPageMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenu.Size = new System.Drawing.Size(1267, 520);
            this.tabPageMenu.TabIndex = 1;
            this.tabPageMenu.Text = "Hàng hóa";
            // 
            // tabPageArea
            // 
            this.tabPageArea.BackColor = System.Drawing.Color.White;
            this.tabPageArea.Controls.Add(this.khuVuc1);
            this.tabPageArea.Location = new System.Drawing.Point(4, 22);
            this.tabPageArea.Name = "tabPageArea";
            this.tabPageArea.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArea.Size = new System.Drawing.Size(1267, 520);
            this.tabPageArea.TabIndex = 2;
            this.tabPageArea.Text = "Khu vực";
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.baoCao1);
            this.tabPageReport.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(1267, 520);
            this.tabPageReport.TabIndex = 3;
            this.tabPageReport.Text = "Báo cáo";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // hangHoa2
            // 
            this.hangHoa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hangHoa2.Location = new System.Drawing.Point(3, 3);
            this.hangHoa2.Name = "hangHoa2";
            this.hangHoa2.Size = new System.Drawing.Size(1261, 514);
            this.hangHoa2.TabIndex = 1;
            // 
            // hangHoa1
            // 
            this.hangHoa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hangHoa1.Location = new System.Drawing.Point(3, 3);
            this.hangHoa1.Name = "hangHoa1";
            this.hangHoa1.Size = new System.Drawing.Size(1261, 514);
            this.hangHoa1.TabIndex = 0;
            // 
            // khuVuc1
            // 
            this.khuVuc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khuVuc1.Location = new System.Drawing.Point(3, 3);
            this.khuVuc1.Name = "khuVuc1";
            this.khuVuc1.Size = new System.Drawing.Size(1261, 514);
            this.khuVuc1.TabIndex = 0;
            // 
            // baoCao1
            // 
            this.baoCao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baoCao1.Location = new System.Drawing.Point(3, 3);
            this.baoCao1.Name = "baoCao1";
            this.baoCao1.Size = new System.Drawing.Size(1261, 514);
            this.baoCao1.TabIndex = 0;
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
            this.tabPageMenu.ResumeLayout(false);
            this.tabPageArea.ResumeLayout(false);
            this.tabPageReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageMenu;
        private System.Windows.Forms.TabPage tabPageArea;
        private HangHoa hangHoa1;
        private KhuVuc khuVuc1;
        private System.Windows.Forms.TabPage tabPageReport;
        private BaoCao baoCao1;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private HangHoa hangHoa2;
    }
}