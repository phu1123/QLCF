using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.QuanLy
{
    public partial class HangHoa : UserControl
    {
        public HangHoa()
        {
            InitializeComponent();

            dataGridView1.Rows.Add(72132139, "Cà phê đen", "20000", 200);
            dataGridView1.Rows.Add(21312321, "Trà sữa", "30000", 500);
            dataGridView1.Rows.Add(13213213, "Cà phê sữa", "25000", 200);
            dataGridView1.Rows.Add(23131233, "Chanh đá", "25000", 250);
            dataGridView1.Rows.Add(21331231, "Sinh tố bơ", "30000",300);
            dataGridView1.Rows.Add(21321313, "Cocacola", "18000", 150);
            dataGridView1.Rows.Add(43534553, "Pepsi", "20000", 100);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }
    }
}
