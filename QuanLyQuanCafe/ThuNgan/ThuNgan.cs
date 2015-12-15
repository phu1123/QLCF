using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QuanLyQuanCafe.ThuNgan
{
    public partial class ThuNgan : MaterialForm
    {
        public static int MsnvLogin;

        public ThuNgan(int msnv)
        {       
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal500, Accent.Red700, TextShade.WHITE);
            MsnvLogin = msnv;
        }

        private void ThuNgan_Load(object sender, System.EventArgs e)
        {
            QuanLyBan quanlyban = new QuanLyBan { Dock = DockStyle.Fill };
            HoaDon nhanvien = new HoaDon { Dock = DockStyle.Fill };
            tabQuanLyBan.Controls.Add(quanlyban);
            tabHoaDon.Controls.Add(nhanvien);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}