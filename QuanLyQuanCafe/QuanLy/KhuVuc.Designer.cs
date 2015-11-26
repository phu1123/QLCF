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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuVuc));
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Tầng 1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Tầng 2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Bàn 1", 1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Bàn 2", 0);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Bàn 3", 0);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("Bàn 4", 1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Bàn 5", 1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("Bàn 6", 1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("Bàn 1", 0);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("Bàn 2", 1);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("Bàn 3", 1);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("Bàn 7", 1);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("Bàn 8", 0);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("Bàn 9", 0);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.raisedButtonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.raisedButtonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textboxIdentifyNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.flatButtonCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.flatButtonAddEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cup-icon.png");
            this.imageList1.Images.SetKeyName(1, "cup-red-icon.png");
            // 
            // raisedButtonAdd
            // 
            this.raisedButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.raisedButtonAdd.Depth = 0;
            this.raisedButtonAdd.Location = new System.Drawing.Point(848, 15);
            this.raisedButtonAdd.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.raisedButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.raisedButtonAdd.Name = "raisedButtonAdd";
            this.raisedButtonAdd.Primary = true;
            this.raisedButtonAdd.Size = new System.Drawing.Size(75, 35);
            this.raisedButtonAdd.TabIndex = 7;
            this.raisedButtonAdd.Text = "Thêm";
            this.raisedButtonAdd.UseVisualStyleBackColor = true;
            // 
            // raisedButtonDelete
            // 
            this.raisedButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.raisedButtonDelete.Depth = 0;
            this.raisedButtonDelete.Location = new System.Drawing.Point(946, 15);
            this.raisedButtonDelete.Margin = new System.Windows.Forms.Padding(20, 15, 15, 3);
            this.raisedButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.raisedButtonDelete.Name = "raisedButtonDelete";
            this.raisedButtonDelete.Primary = true;
            this.raisedButtonDelete.Size = new System.Drawing.Size(75, 35);
            this.raisedButtonDelete.TabIndex = 6;
            this.raisedButtonDelete.Text = "Xóa";
            this.raisedButtonDelete.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            listViewGroup3.Header = "Tầng 1";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "Tầng 2";
            listViewGroup4.Name = "listViewGroup2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            listViewItem13.Group = listViewGroup3;
            listViewItem14.Group = listViewGroup3;
            listViewItem15.Group = listViewGroup3;
            listViewItem16.Group = listViewGroup3;
            listViewItem17.Group = listViewGroup3;
            listViewItem18.Group = listViewGroup3;
            listViewItem19.Group = listViewGroup4;
            listViewItem20.Group = listViewGroup4;
            listViewItem21.Group = listViewGroup4;
            listViewItem22.Group = listViewGroup3;
            listViewItem23.Group = listViewGroup3;
            listViewItem24.Group = listViewGroup3;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(703, 537);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textboxIdentifyNumber
            // 
            this.textboxIdentifyNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxIdentifyNumber.Depth = 0;
            this.textboxIdentifyNumber.Hint = "Tên khu vực";
            this.textboxIdentifyNumber.Location = new System.Drawing.Point(712, 92);
            this.textboxIdentifyNumber.MaxLength = 32767;
            this.textboxIdentifyNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxIdentifyNumber.Name = "textboxIdentifyNumber";
            this.textboxIdentifyNumber.PasswordChar = '\0';
            this.textboxIdentifyNumber.SelectedText = "";
            this.textboxIdentifyNumber.SelectionLength = 0;
            this.textboxIdentifyNumber.SelectionStart = 0;
            this.textboxIdentifyNumber.Size = new System.Drawing.Size(321, 23);
            this.textboxIdentifyNumber.TabIndex = 24;
            this.textboxIdentifyNumber.TabStop = false;
            this.textboxIdentifyNumber.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Số bàn";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(712, 131);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(321, 23);
            this.materialSingleLineTextField1.TabIndex = 25;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // flatButtonCancel
            // 
            this.flatButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButtonCancel.AutoSize = true;
            this.flatButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flatButtonCancel.Depth = 0;
            this.flatButtonCancel.Location = new System.Drawing.Point(993, 189);
            this.flatButtonCancel.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.flatButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonCancel.Name = "flatButtonCancel";
            this.flatButtonCancel.Primary = false;
            this.flatButtonCancel.Size = new System.Drawing.Size(39, 36);
            this.flatButtonCancel.TabIndex = 42;
            this.flatButtonCancel.Text = "Hủy";
            this.flatButtonCancel.UseVisualStyleBackColor = true;
            // 
            // flatButtonAddEdit
            // 
            this.flatButtonAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButtonAddEdit.AutoSize = true;
            this.flatButtonAddEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flatButtonAddEdit.Depth = 0;
            this.flatButtonAddEdit.Location = new System.Drawing.Point(935, 189);
            this.flatButtonAddEdit.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.flatButtonAddEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonAddEdit.Name = "flatButtonAddEdit";
            this.flatButtonAddEdit.Primary = false;
            this.flatButtonAddEdit.Size = new System.Drawing.Size(39, 36);
            this.flatButtonAddEdit.TabIndex = 41;
            this.flatButtonAddEdit.Text = "Sửa";
            this.flatButtonAddEdit.UseVisualStyleBackColor = true;
            // 
            // KhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flatButtonCancel);
            this.Controls.Add(this.flatButtonAddEdit);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.textboxIdentifyNumber);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.raisedButtonAdd);
            this.Controls.Add(this.raisedButtonDelete);
            this.Name = "KhuVuc";
            this.Size = new System.Drawing.Size(1036, 543);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialRaisedButton raisedButtonAdd;
        private MaterialSkin.Controls.MaterialRaisedButton raisedButtonDelete;
        private System.Windows.Forms.ListView listView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxIdentifyNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialFlatButton flatButtonCancel;
        private MaterialSkin.Controls.MaterialFlatButton flatButtonAddEdit;
    }
}
