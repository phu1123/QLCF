


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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.radioButtonAdmin = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonEmployee = new MaterialSkin.Controls.MaterialRadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.radioButtonMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.flatButtonCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.flatButtonAddEdit = new MaterialSkin.Controls.MaterialFlatButton();
            this.textboxFullName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.timePickerFirstDayWorking = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textboxPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.timePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.textboxIDCardNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxIdentifyNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.raisedButtonAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.raisedButtonDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.employeeTable = new System.Data.DataTable();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.materialSingleLineTextField1);
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
            this.splitContainer1.Size = new System.Drawing.Size(925, 536);
            this.splitContainer1.SplitterDistance = 471;
            this.splitContainer1.TabIndex = 2;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Tìm kiếm";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(220, 14);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(246, 23);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
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
            this.Column7,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(469, 491);
            this.dataGridView1.TabIndex = 0;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(16, 15);
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
            this.materialRaisedButton1.Location = new System.Drawing.Point(138, 15);
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
            this.panel1.Controls.Add(this.textboxFullName);
            this.panel1.Controls.Add(this.timePickerFirstDayWorking);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.textboxPhone);
            this.panel1.Controls.Add(this.textboxAddress);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.timePickerBirthday);
            this.panel1.Controls.Add(this.textboxIDCardNumber);
            this.panel1.Controls.Add(this.textboxPassword);
            this.panel1.Controls.Add(this.textboxIdentifyNumber);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 461);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.radioButtonAdmin);
            this.panel3.Controls.Add(this.radioButtonEmployee);
            this.panel3.Location = new System.Drawing.Point(0, 366);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 24);
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
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Depth = 0;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonAdmin.Location = new System.Drawing.Point(95, -1);
            this.radioButtonAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Ripple = true;
            this.radioButtonAdmin.Size = new System.Drawing.Size(75, 30);
            this.radioButtonAdmin.TabIndex = 26;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Quản lý";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Depth = 0;
            this.radioButtonEmployee.Font = new System.Drawing.Font("Roboto", 10F);
            this.radioButtonEmployee.Location = new System.Drawing.Point(198, -1);
            this.radioButtonEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonEmployee.Name = "radioButtonEmployee";
            this.radioButtonEmployee.Ripple = true;
            this.radioButtonEmployee.Size = new System.Drawing.Size(89, 30);
            this.radioButtonEmployee.TabIndex = 27;
            this.radioButtonEmployee.TabStop = true;
            this.radioButtonEmployee.Text = "Thu Ngân";
            this.radioButtonEmployee.UseVisualStyleBackColor = true;
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
            this.panel2.Size = new System.Drawing.Size(431, 24);
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
            this.flatButtonCancel.Location = new System.Drawing.Point(392, 415);
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
            this.flatButtonAddEdit.Location = new System.Drawing.Point(334, 415);
            this.flatButtonAddEdit.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.flatButtonAddEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonAddEdit.Name = "flatButtonAddEdit";
            this.flatButtonAddEdit.Primary = false;
            this.flatButtonAddEdit.Size = new System.Drawing.Size(39, 36);
            this.flatButtonAddEdit.TabIndex = 39;
            this.flatButtonAddEdit.Text = "Sửa";
            this.flatButtonAddEdit.UseVisualStyleBackColor = true;
            this.flatButtonAddEdit.Click += new System.EventHandler(this.flatButtonAddEdit_Click);
            // 
            // textboxFullName
            // 
            this.textboxFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxFullName.Depth = 0;
            this.textboxFullName.Hint = "Họ tên";
            this.textboxFullName.Location = new System.Drawing.Point(7, 101);
            this.textboxFullName.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textboxFullName.MaxLength = 32767;
            this.textboxFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxFullName.Name = "textboxFullName";
            this.textboxFullName.PasswordChar = '\0';
            this.textboxFullName.SelectedText = "";
            this.textboxFullName.SelectionLength = 0;
            this.textboxFullName.SelectionStart = 0;
            this.textboxFullName.Size = new System.Drawing.Size(424, 23);
            this.textboxFullName.TabIndex = 38;
            this.textboxFullName.TabStop = false;
            this.textboxFullName.UseSystemPasswordChar = false;
            this.textboxFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxFullName_KeyPress);
            // 
            // timePickerFirstDayWorking
            // 
            this.timePickerFirstDayWorking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePickerFirstDayWorking.CustomFormat = "dd/MM/yyyy";
            this.timePickerFirstDayWorking.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerFirstDayWorking.Location = new System.Drawing.Point(113, 334);
            this.timePickerFirstDayWorking.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.timePickerFirstDayWorking.Name = "timePickerFirstDayWorking";
            this.timePickerFirstDayWorking.Size = new System.Drawing.Size(318, 20);
            this.timePickerFirstDayWorking.TabIndex = 36;
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
            // textboxPhone
            // 
            this.textboxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxPhone.Depth = 0;
            this.textboxPhone.Hint = "Số điện thoại";
            this.textboxPhone.Location = new System.Drawing.Point(7, 293);
            this.textboxPhone.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textboxPhone.MaxLength = 32767;
            this.textboxPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxPhone.Name = "textboxPhone";
            this.textboxPhone.PasswordChar = '\0';
            this.textboxPhone.SelectedText = "";
            this.textboxPhone.SelectionLength = 0;
            this.textboxPhone.SelectionStart = 0;
            this.textboxPhone.Size = new System.Drawing.Size(424, 23);
            this.textboxPhone.TabIndex = 31;
            this.textboxPhone.TabStop = false;
            this.textboxPhone.UseSystemPasswordChar = false;
            this.textboxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxIDCardNumber_KeyPress);
            // 
            // textboxAddress
            // 
            this.textboxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxAddress.Depth = 0;
            this.textboxAddress.Hint = "Địa chỉ";
            this.textboxAddress.Location = new System.Drawing.Point(7, 252);
            this.textboxAddress.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textboxAddress.MaxLength = 32767;
            this.textboxAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxAddress.Name = "textboxAddress";
            this.textboxAddress.PasswordChar = '\0';
            this.textboxAddress.SelectedText = "";
            this.textboxAddress.SelectionLength = 0;
            this.textboxAddress.SelectionStart = 0;
            this.textboxAddress.Size = new System.Drawing.Size(424, 23);
            this.textboxAddress.TabIndex = 30;
            this.textboxAddress.TabStop = false;
            this.textboxAddress.UseSystemPasswordChar = false;
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
            this.timePickerBirthday.Size = new System.Drawing.Size(318, 20);
            this.timePickerBirthday.TabIndex = 28;
            // 
            // textboxIDCardNumber
            // 
            this.textboxIDCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxIDCardNumber.Depth = 0;
            this.textboxIDCardNumber.Hint = "Số CMND";
            this.textboxIDCardNumber.Location = new System.Drawing.Point(7, 211);
            this.textboxIDCardNumber.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textboxIDCardNumber.MaxLength = 32767;
            this.textboxIDCardNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxIDCardNumber.Name = "textboxIDCardNumber";
            this.textboxIDCardNumber.PasswordChar = '\0';
            this.textboxIDCardNumber.SelectedText = "";
            this.textboxIDCardNumber.SelectionLength = 0;
            this.textboxIDCardNumber.SelectionStart = 0;
            this.textboxIDCardNumber.Size = new System.Drawing.Size(424, 23);
            this.textboxIDCardNumber.TabIndex = 25;
            this.textboxIDCardNumber.TabStop = false;
            this.textboxIDCardNumber.UseSystemPasswordChar = false;
            this.textboxIDCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxIDCardNumber_KeyPress);
            // 
            // textboxPassword
            // 
            this.textboxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxPassword.Depth = 0;
            this.textboxPassword.Hint = "Mật khẩu";
            this.textboxPassword.Location = new System.Drawing.Point(7, 60);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.textboxPassword.MaxLength = 32767;
            this.textboxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '\0';
            this.textboxPassword.SelectedText = "";
            this.textboxPassword.SelectionLength = 0;
            this.textboxPassword.SelectionStart = 0;
            this.textboxPassword.Size = new System.Drawing.Size(424, 23);
            this.textboxPassword.TabIndex = 24;
            this.textboxPassword.TabStop = false;
            this.textboxPassword.UseSystemPasswordChar = true;
            // 
            // textboxIdentifyNumber
            // 
            this.textboxIdentifyNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxIdentifyNumber.Depth = 0;
            this.textboxIdentifyNumber.Hint = "Tên đăng nhập";
            this.textboxIdentifyNumber.Location = new System.Drawing.Point(7, 19);
            this.textboxIdentifyNumber.MaxLength = 32767;
            this.textboxIdentifyNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxIdentifyNumber.Name = "textboxIdentifyNumber";
            this.textboxIdentifyNumber.PasswordChar = '\0';
            this.textboxIdentifyNumber.SelectedText = "";
            this.textboxIdentifyNumber.SelectionLength = 0;
            this.textboxIdentifyNumber.SelectionStart = 0;
            this.textboxIdentifyNumber.Size = new System.Drawing.Size(424, 23);
            this.textboxIdentifyNumber.TabIndex = 23;
            this.textboxIdentifyNumber.TabStop = false;
            this.textboxIdentifyNumber.UseSystemPasswordChar = false;
            // 
            // raisedButtonAdd
            // 
            this.raisedButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.raisedButtonAdd.Depth = 0;
            this.raisedButtonAdd.Location = new System.Drawing.Point(260, 15);
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
            this.raisedButtonDelete.Location = new System.Drawing.Point(358, 15);
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
            // Column1
            // 
            this.Column1.DataPropertyName = "MASO";
            this.Column1.HeaderText = "Mã số";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "HOTEN";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "SDT";
            this.Column7.HeaderText = "SĐT";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "CHUCVU";
            this.Column9.HeaderText = "Chức vụ";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(925, 536);
            this.Load += new System.EventHandler(this.Nhanvien_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonAdmin;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonEmployee;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonMale;
        private MaterialSkin.Controls.MaterialRadioButton radioButtonFemale;
        private MaterialSkin.Controls.MaterialFlatButton flatButtonCancel;
        private MaterialSkin.Controls.MaterialFlatButton flatButtonAddEdit;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxFullName;
        private System.Windows.Forms.DateTimePicker timePickerFirstDayWorking;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxPhone;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxAddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker timePickerBirthday;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxIDCardNumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxIdentifyNumber;
        private MaterialSkin.Controls.MaterialRaisedButton raisedButtonAdd;
        private MaterialSkin.Controls.MaterialRaisedButton raisedButtonDelete;
        private System.Data.DataTable employeeTable;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
    }
}
