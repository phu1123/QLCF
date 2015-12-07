

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
            this.textFieldSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.radioButtonManager = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonCashier = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.radioButtonMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.flatButtonCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.flatButtonAddEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBoxFullName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.timePickerWorkSince = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.timePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxCMND = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.raisedButtonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.raisedButtonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.splitContainer1.Panel1.Controls.Add(this.textFieldSearch);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.materialRaisedButton2);
            this.splitContainer1.Panel2.Controls.Add(this.materialRaisedButton1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.raisedButtonAdd);
            this.splitContainer1.Panel2.Controls.Add(this.raisedButtonDelete);
            this.splitContainer1.Panel2MinSize = 320;
            this.splitContainer1.Size = new System.Drawing.Size(1075, 536);
            this.splitContainer1.SplitterDistance = 622;
            this.splitContainer1.TabIndex = 2;
            // 
            // textFieldSearch
            // 
            this.textFieldSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textFieldSearch.Depth = 0;
            this.textFieldSearch.Hint = "Tìm kiếm";
            this.textFieldSearch.Location = new System.Drawing.Point(371, 14);
            this.textFieldSearch.MaxLength = 32767;
            this.textFieldSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.textFieldSearch.Name = "textFieldSearch";
            this.textFieldSearch.PasswordChar = '\0';
            this.textFieldSearch.SelectedText = "";
            this.textFieldSearch.SelectionLength = 0;
            this.textFieldSearch.SelectionStart = 0;
            this.textFieldSearch.Size = new System.Drawing.Size(246, 23);
            this.textFieldSearch.TabIndex = 1;
            this.textFieldSearch.TabStop = false;
            this.textFieldSearch.UseSystemPasswordChar = false;
            this.textFieldSearch.TextChanged += new System.EventHandler(this.textFieldSearch_TextChanged);
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
            this.dataGridView1.Size = new System.Drawing.Size(620, 491);
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
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(15, 15);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(99, 35);
            this.materialRaisedButton2.TabIndex = 25;
            this.materialRaisedButton2.Text = "Phân ca";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(137, 15);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(99, 35);
            this.materialRaisedButton1.TabIndex = 24;
            this.materialRaisedButton1.Text = "Điểm danh";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flatButtonCancel);
            this.panel1.Controls.Add(this.flatButtonAddEdit);
            this.panel1.Controls.Add(this.textBoxFullName);
            this.panel1.Controls.Add(this.timePickerWorkSince);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.timePickerBirthday);
            this.panel1.Controls.Add(this.textBoxCMND);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 461);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.radioButtonManager);
            this.panel3.Controls.Add(this.radioButtonCashier);
            this.panel3.Location = new System.Drawing.Point(0, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 24);
            this.panel3.TabIndex = 42;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 4);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(67, 19);
            this.materialLabel4.TabIndex = 32;
            this.materialLabel4.Text = "Chức vụ:";
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Depth = 0;
            this.radioButtonManager.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonManager.Location = new System.Drawing.Point(95, -1);
            this.radioButtonManager.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonManager.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Ripple = true;
            this.radioButtonManager.Size = new System.Drawing.Size(75, 30);
            this.radioButtonManager.TabIndex = 26;
            this.radioButtonManager.TabStop = true;
            this.radioButtonManager.Text = "Quản lý";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            // 
            // radioButtonCashier
            // 
            this.radioButtonCashier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCashier.AutoSize = true;
            this.radioButtonCashier.Depth = 0;
            this.radioButtonCashier.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonCashier.Location = new System.Drawing.Point(198, -1);
            this.radioButtonCashier.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonCashier.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonCashier.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonCashier.Name = "radioButtonCashier";
            this.radioButtonCashier.Ripple = true;
            this.radioButtonCashier.Size = new System.Drawing.Size(89, 30);
            this.radioButtonCashier.TabIndex = 27;
            this.radioButtonCashier.TabStop = true;
            this.radioButtonCashier.Text = "Thu Ngân";
            this.radioButtonCashier.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.radioButtonMale);
            this.panel2.Controls.Add(this.radioButtonFemale);
            this.panel2.Location = new System.Drawing.Point(0, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 24);
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
            this.materialLabel2.Location = new System.Drawing.Point(3, 4);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 32;
            this.materialLabel2.Text = "Giới tính:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Depth = 0;
            this.radioButtonMale.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonMale.Location = new System.Drawing.Point(95, -1);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Ripple = true;
            this.radioButtonMale.Size = new System.Drawing.Size(58, 30);
            this.radioButtonMale.TabIndex = 26;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Nam";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Depth = 0;
            this.radioButtonFemale.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonFemale.Location = new System.Drawing.Point(198, -1);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Ripple = true;
            this.radioButtonFemale.Size = new System.Drawing.Size(47, 30);
            this.radioButtonFemale.TabIndex = 27;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Nữ";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // flatButtonCancel
            // 
            this.flatButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButtonCancel.AutoSize = true;
            this.flatButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flatButtonCancel.Depth = 0;
            this.flatButtonCancel.Location = new System.Drawing.Point(391, 415);
            this.flatButtonCancel.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.flatButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonCancel.Name = "flatButtonCancel";
            this.flatButtonCancel.Primary = false;
            this.flatButtonCancel.Size = new System.Drawing.Size(39, 36);
            this.flatButtonCancel.TabIndex = 40;
            this.flatButtonCancel.Text = "Hủy";
            this.flatButtonCancel.UseVisualStyleBackColor = true;
            this.flatButtonCancel.Click += new System.EventHandler(this.flatButtonCancel_Click);
            // 
            // flatButtonAddEdit
            // 
            this.flatButtonAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButtonAddEdit.AutoSize = true;
            this.flatButtonAddEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flatButtonAddEdit.Depth = 0;
            this.flatButtonAddEdit.Location = new System.Drawing.Point(333, 415);
            this.flatButtonAddEdit.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.flatButtonAddEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonAddEdit.Name = "flatButtonAddEdit";
            this.flatButtonAddEdit.Primary = false;
            this.flatButtonAddEdit.Size = new System.Drawing.Size(50, 36);
            this.flatButtonAddEdit.TabIndex = 39;
            this.flatButtonAddEdit.Text = "Thêm";
            this.flatButtonAddEdit.UseVisualStyleBackColor = true;
            this.flatButtonAddEdit.Click += new System.EventHandler(this.flatButtonAddEdit_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFullName.Depth = 0;
            this.textBoxFullName.Hint = "Họ tên";
            this.textBoxFullName.Location = new System.Drawing.Point(7, 101);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBoxFullName.MaxLength = 50;
            this.textBoxFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.PasswordChar = '\0';
            this.textBoxFullName.SelectedText = "";
            this.textBoxFullName.SelectionLength = 0;
            this.textBoxFullName.SelectionStart = 0;
            this.textBoxFullName.Size = new System.Drawing.Size(423, 23);
            this.textBoxFullName.TabIndex = 2;
            this.textBoxFullName.TabStop = false;
            this.textBoxFullName.UseSystemPasswordChar = false;
            this.textBoxFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxFullName_KeyPress);
            // 
            // timePickerWorkSince
            // 
            this.timePickerWorkSince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePickerWorkSince.CustomFormat = "dd/MM/yyyy";
            this.timePickerWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerWorkSince.Location = new System.Drawing.Point(113, 334);
            this.timePickerWorkSince.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.timePickerWorkSince.Name = "timePickerWorkSince";
            this.timePickerWorkSince.Size = new System.Drawing.Size(317, 20);
            this.timePickerWorkSince.TabIndex = 8;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 334);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(104, 19);
            this.materialLabel3.TabIndex = 37;
            this.materialLabel3.Text = "Ngày vào làm:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.Depth = 0;
            this.textBoxPhone.Hint = "Số điện thoại";
            this.textBoxPhone.Location = new System.Drawing.Point(7, 293);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBoxPhone.MaxLength = 12;
            this.textBoxPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.SelectionLength = 0;
            this.textBoxPhone.SelectionStart = 0;
            this.textBoxPhone.Size = new System.Drawing.Size(423, 23);
            this.textBoxPhone.TabIndex = 7;
            this.textBoxPhone.TabStop = false;
            this.textBoxPhone.UseSystemPasswordChar = false;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxIDCardNumber_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Depth = 0;
            this.textBoxAddress.Hint = "Địa chỉ";
            this.textBoxAddress.Location = new System.Drawing.Point(7, 252);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBoxAddress.MaxLength = 100;
            this.textBoxAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PasswordChar = '\0';
            this.textBoxAddress.SelectedText = "";
            this.textBoxAddress.SelectionLength = 0;
            this.textBoxAddress.SelectionStart = 0;
            this.textBoxAddress.Size = new System.Drawing.Size(423, 23);
            this.textBoxAddress.TabIndex = 5;
            this.textBoxAddress.TabStop = false;
            this.textBoxAddress.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 177);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Ngày sinh:";
            // 
            // timePickerBirthday
            // 
            this.timePickerBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePickerBirthday.CustomFormat = "dd/MM/yyyy";
            this.timePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerBirthday.Location = new System.Drawing.Point(113, 177);
            this.timePickerBirthday.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.timePickerBirthday.Name = "timePickerBirthday";
            this.timePickerBirthday.Size = new System.Drawing.Size(317, 20);
            this.timePickerBirthday.TabIndex = 3;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCMND.Depth = 0;
            this.textBoxCMND.Hint = "Số CMND";
            this.textBoxCMND.Location = new System.Drawing.Point(7, 211);
            this.textBoxCMND.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBoxCMND.MaxLength = 12;
            this.textBoxCMND.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.PasswordChar = '\0';
            this.textBoxCMND.SelectedText = "";
            this.textBoxCMND.SelectionLength = 0;
            this.textBoxCMND.SelectionStart = 0;
            this.textBoxCMND.Size = new System.Drawing.Size(423, 23);
            this.textBoxCMND.TabIndex = 4;
            this.textBoxCMND.TabStop = false;
            this.textBoxCMND.UseSystemPasswordChar = false;
            this.textBoxCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxIDCardNumber_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Hint = "Mật khẩu";
            this.textBoxPassword.Location = new System.Drawing.Point(7, 60);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(423, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserName.Depth = 0;
            this.textBoxUserName.Hint = "Tên đăng nhập";
            this.textBoxUserName.Location = new System.Drawing.Point(7, 19);
            this.textBoxUserName.MaxLength = 20;
            this.textBoxUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.PasswordChar = '\0';
            this.textBoxUserName.SelectedText = "";
            this.textBoxUserName.SelectionLength = 0;
            this.textBoxUserName.SelectionStart = 0;
            this.textBoxUserName.Size = new System.Drawing.Size(423, 23);
            this.textBoxUserName.TabIndex = 0;
            this.textBoxUserName.TabStop = false;
            this.textBoxUserName.UseSystemPasswordChar = false;
            // 
            // raisedButtonAdd
            // 
            this.raisedButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.raisedButtonAdd.Depth = 0;
            this.raisedButtonAdd.Location = new System.Drawing.Point(259, 15);
            this.raisedButtonAdd.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.raisedButtonAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.raisedButtonAdd.Name = "raisedButtonAdd";
            this.raisedButtonAdd.Primary = true;
            this.raisedButtonAdd.Size = new System.Drawing.Size(75, 35);
            this.raisedButtonAdd.TabIndex = 5;
            this.raisedButtonAdd.Text = "Thêm";
            this.raisedButtonAdd.UseVisualStyleBackColor = true;
            this.raisedButtonAdd.Click += new System.EventHandler(this.raisedButtonAdd_Click);
            // 
            // raisedButtonDelete
            // 
            this.raisedButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.raisedButtonDelete.Depth = 0;
            this.raisedButtonDelete.Location = new System.Drawing.Point(357, 15);
            this.raisedButtonDelete.Margin = new System.Windows.Forms.Padding(20, 15, 15, 3);
            this.raisedButtonDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.raisedButtonDelete.Name = "raisedButtonDelete";
            this.raisedButtonDelete.Primary = true;
            this.raisedButtonDelete.Size = new System.Drawing.Size(75, 35);
            this.raisedButtonDelete.TabIndex = 2;
            this.raisedButtonDelete.Text = "Xóa";
            this.raisedButtonDelete.UseVisualStyleBackColor = true;
            this.raisedButtonDelete.Click += new System.EventHandler(this.raisedButtonDelete_Click);
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
        private MaterialSkin.Controls.MaterialRadioButton radioButtonManager;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonCashier;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonMale;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonFemale;
        private MaterialSkin.Controls.MaterialFlatButton flatButtonCancel;
        private MaterialSkin.Controls.MaterialFlatButton flatButtonAddEdit;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxFullName;
        private System.Windows.Forms.DateTimePicker timePickerWorkSince;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker timePickerBirthday;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxCMND;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxUserName;
        private MaterialSkin.Controls.MaterialRaisedButton raisedButtonAdd;
        private MaterialSkin.Controls.MaterialRaisedButton raisedButtonDelete;
        private MaterialSkin.Controls.MaterialSingleLineTextField textFieldSearch;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
