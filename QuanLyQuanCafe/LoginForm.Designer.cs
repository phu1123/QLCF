namespace QuanLyQuanCafe
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBoxUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.flatButtonLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.flatButtonExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Depth = 0;
            this.textBoxUsername.Hint = "Tên đăng nhập";
            this.textBoxUsername.Location = new System.Drawing.Point(28, 203);
            this.textBoxUsername.MaxLength = 32767;
            this.textBoxUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.SelectionLength = 0;
            this.textBoxUsername.SelectionStart = 0;
            this.textBoxUsername.Size = new System.Drawing.Size(394, 23);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.TabStop = false;
            this.textBoxUsername.UseSystemPasswordChar = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Hint = "Mật khẩu";
            this.textBoxPassword.Location = new System.Drawing.Point(28, 241);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.Size = new System.Drawing.Size(394, 23);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // flatButtonLogin
            // 
            this.flatButtonLogin.AutoSize = true;
            this.flatButtonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flatButtonLogin.BackColor = System.Drawing.Color.White;
            this.flatButtonLogin.Depth = 0;
            this.flatButtonLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.flatButtonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.flatButtonLogin.Location = new System.Drawing.Point(267, 309);
            this.flatButtonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.flatButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonLogin.Name = "flatButtonLogin";
            this.flatButtonLogin.Primary = false;
            this.flatButtonLogin.Size = new System.Drawing.Size(90, 36);
            this.flatButtonLogin.TabIndex = 0;
            this.flatButtonLogin.Text = "Đăng nhập";
            this.flatButtonLogin.UseVisualStyleBackColor = false;
            this.flatButtonLogin.Click += new System.EventHandler(this.flatButtonLogin_Click);
            // 
            // flatButtonExit
            // 
            this.flatButtonExit.AutoSize = true;
            this.flatButtonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flatButtonExit.BackColor = System.Drawing.Color.White;
            this.flatButtonExit.Depth = 0;
            this.flatButtonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.flatButtonExit.Location = new System.Drawing.Point(365, 309);
            this.flatButtonExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.flatButtonExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.flatButtonExit.Name = "flatButtonExit";
            this.flatButtonExit.Primary = false;
            this.flatButtonExit.Size = new System.Drawing.Size(57, 36);
            this.flatButtonExit.TabIndex = 1;
            this.flatButtonExit.Text = "Thoát";
            this.flatButtonExit.UseVisualStyleBackColor = false;
            this.flatButtonExit.Click += new System.EventHandler(this.flatButtonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flatButtonExit);
            this.Controls.Add(this.flatButtonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBoxPassword;
        private MaterialSkin.Controls.MaterialFlatButton flatButtonLogin;
        private MaterialSkin.Controls.MaterialFlatButton flatButtonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

