namespace QuanLyQuanCafe.QuanLy
{
    partial class KhuVuc
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuVuc));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTenKhuVuc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnThemKV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnXoaKV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtTenBan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnXoaBan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnThemBan = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtTenKhuVuc);
            this.splitContainer1.Panel1.Controls.Add(this.btnThemKV);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoaKV);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Panel2.Controls.Add(this.txtTenBan);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoaBan);
            this.splitContainer1.Panel2.Controls.Add(this.btnThemBan);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 700);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 43;
            // 
            // txtTenKhuVuc
            // 
            this.txtTenKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenKhuVuc.Depth = 0;
            this.txtTenKhuVuc.Hint = "Tên khu vực";
            this.txtTenKhuVuc.Location = new System.Drawing.Point(19, 16);
            this.txtTenKhuVuc.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txtTenKhuVuc.MaxLength = 32767;
            this.txtTenKhuVuc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenKhuVuc.Name = "txtTenKhuVuc";
            this.txtTenKhuVuc.PasswordChar = '\0';
            this.txtTenKhuVuc.SelectedText = "";
            this.txtTenKhuVuc.SelectionLength = 0;
            this.txtTenKhuVuc.SelectionStart = 0;
            this.txtTenKhuVuc.Size = new System.Drawing.Size(246, 23);
            this.txtTenKhuVuc.TabIndex = 46;
            this.txtTenKhuVuc.TabStop = false;
            this.txtTenKhuVuc.UseSystemPasswordChar = false;
            // 
            // btnThemKV
            // 
            this.btnThemKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKV.Depth = 0;
            this.btnThemKV.Location = new System.Drawing.Point(305, 15);
            this.btnThemKV.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnThemKV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemKV.Name = "btnThemKV";
            this.btnThemKV.Primary = true;
            this.btnThemKV.Size = new System.Drawing.Size(75, 25);
            this.btnThemKV.TabIndex = 45;
            this.btnThemKV.Text = "Thêm";
            this.btnThemKV.UseVisualStyleBackColor = true;
            this.btnThemKV.Click += new System.EventHandler(this.btnThemKV_Click);
            // 
            // btnXoaKV
            // 
            this.btnXoaKV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaKV.Depth = 0;
            this.btnXoaKV.Location = new System.Drawing.Point(403, 15);
            this.btnXoaKV.Margin = new System.Windows.Forms.Padding(20, 15, 20, 3);
            this.btnXoaKV.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaKV.Name = "btnXoaKV";
            this.btnXoaKV.Primary = true;
            this.btnXoaKV.Size = new System.Drawing.Size(75, 25);
            this.btnXoaKV.TabIndex = 44;
            this.btnXoaKV.Text = "Xóa";
            this.btnXoaKV.UseVisualStyleBackColor = true;
            this.btnXoaKV.Click += new System.EventHandler(this.btnXoaKV_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.HideSelection = false;
            this.treeView1.ItemHeight = 25;
            this.treeView1.Location = new System.Drawing.Point(0, 57);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(498, 642);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            listViewItem1.Tag = "";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 57);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(694, 641);
            this.listView1.TabIndex = 50;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cup-icon.png");
            this.imageList1.Images.SetKeyName(1, "cup-red-icon.png");
            // 
            // txtTenBan
            // 
            this.txtTenBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenBan.Depth = 0;
            this.txtTenBan.Hint = "Tên bàn";
            this.txtTenBan.Location = new System.Drawing.Point(20, 16);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txtTenBan.MaxLength = 32767;
            this.txtTenBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.PasswordChar = '\0';
            this.txtTenBan.SelectedText = "";
            this.txtTenBan.SelectionLength = 0;
            this.txtTenBan.SelectionStart = 0;
            this.txtTenBan.Size = new System.Drawing.Size(441, 23);
            this.txtTenBan.TabIndex = 49;
            this.txtTenBan.TabStop = false;
            this.txtTenBan.UseSystemPasswordChar = false;
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaBan.Depth = 0;
            this.btnXoaBan.Location = new System.Drawing.Point(599, 15);
            this.btnXoaBan.Margin = new System.Windows.Forms.Padding(20, 15, 20, 3);
            this.btnXoaBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Primary = true;
            this.btnXoaBan.Size = new System.Drawing.Size(75, 25);
            this.btnXoaBan.TabIndex = 47;
            this.btnXoaBan.Text = "Xóa";
            this.btnXoaBan.UseVisualStyleBackColor = true;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemBan.Depth = 0;
            this.btnThemBan.Location = new System.Drawing.Point(501, 15);
            this.btnThemBan.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btnThemBan.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Primary = true;
            this.btnThemBan.Size = new System.Drawing.Size(75, 25);
            this.btnThemBan.TabIndex = 48;
            this.btnThemBan.Text = "Thêm";
            this.btnThemBan.UseVisualStyleBackColor = true;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // KhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "KhuVuc";
            this.Size = new System.Drawing.Size(1200, 700);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenKhuVuc;
        private MaterialSkin.Controls.MaterialRaisedButton btnThemKV;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoaKV;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTenBan;
        private MaterialSkin.Controls.MaterialRaisedButton btnXoaBan;
        private MaterialSkin.Controls.MaterialRaisedButton btnThemBan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
