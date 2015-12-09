using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace QuanLyQuanCafe.QuanLy
{
    public partial class QuanLy : MaterialForm
    {
        public static int MsnvLogin;

        public QuanLy(int msnv)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal500, Accent.Red700, TextShade.WHITE);
            MsnvLogin = msnv;
        } 

        private void QuanLy_Load(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien { Dock = DockStyle.Fill };
            KhuVuc khuvuc = new KhuVuc { Dock = DockStyle.Fill };
            HangHoa hanghoa = new HangHoa { Dock = DockStyle.Fill };
            tabNhanVien.Controls.Add(nhanvien);
            tabKhuVuc.Controls.Add(khuvuc);
            tabHangHoa.Controls.Add(hanghoa);

        }

        private void QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
