using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using BUS;
using APP;

namespace QuanLyQuanCafe
{
    public partial class DangNhap : MaterialForm
    {
        public DangNhap()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal500,
                Accent.Red700, TextShade.WHITE);
        }

        private void flatButtonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                label1.Text = @"Vui lòng nhập tên đăng nhập và mật khẩu.";
                return;
            }

            DbConnection.ConnectionString = @"Server=.\SQLEXPRESS; Database=QLCF; Integrated Security=SSPI;";

            using (NhanVienBUS bus = new NhanVienBUS())
            {
                DataTable credentials = bus.LoginCredentials();
                DataRow row = credentials.AsEnumerable().FirstOrDefault(r => r.Field<string>("TenDangNhap") == textBoxUsername.Text && 
                    textBoxPassword.Text == r.Field<string>("MatKhau"));

                if (row != null)
                {
                    if (row.Field<bool>("PhanQuyen") == false)
                        new QuanLy.QuanLy(row.Field<int>("MSNV")).Show();
                    else new ThuNgan.ThuNgan().Show();
                    Close();
                }
                else
                {
                    label1.Text = @"Sai tên đăng nhập hoặc mật khẩu. Hãy thử lại.";
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                }
            }           
        }

        private void flatButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}