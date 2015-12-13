using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace QuanLyQuanCafe.Dialog
{
    public partial class XacNhan : MaterialForm
    {
        public XacNhan()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal500,
                Accent.Red700, TextShade.WHITE);
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;  
        }
        private void btnKhong_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
