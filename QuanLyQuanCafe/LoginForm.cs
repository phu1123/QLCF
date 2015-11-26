using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace QuanLyQuanCafe
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal500, Accent.Red700, TextShade.WHITE);
        }

        private void flatButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                label1.Text = @"Vui lòng nhập tên đăng nhập và mật khẩu."; return;
            }

            using (var conn = new SqlConnection(@"Server = .\SQLEXPRESS; Database = QLCF; Trusted_Connection = True"))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM TaiKhoan", conn);
                var r = cmd.ExecuteReader();

                while (r.Read())
                {
                    if (r["TenDangNhap"].ToString() != textBoxUsername.Text || r["MatKhau"].ToString() != textBoxPassword.Text)
                        continue;
                    if ((bool)r["PhanQuyen"] == false)
                        new QuanLy.QuanLy(r["MSNV"].ToString()).Show();
                    else new ThuNgan.ThuNgan(r["MSNV"].ToString()).Show();
                    Close();
                }

                label1.Text = @"Sai tên đăng nhập hoặc mật khẩu. Hãy thử lại.";
                textBoxUsername.Clear();
                textBoxPassword.Clear();
            }

        }

        private void flatButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}