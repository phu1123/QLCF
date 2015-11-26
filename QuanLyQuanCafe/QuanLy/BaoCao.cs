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
    public partial class BaoCao : UserControl
    {
        public BaoCao()
        {
            InitializeComponent();

            dataGridView1.Rows.Add("01/11/2015", 100, 5000000);
            dataGridView1.Rows.Add("02/11/2015", 80, 4000000);
            dataGridView1.Rows.Add("03/11/2015", 50, 3000000);
            dataGridView1.Rows.Add("04/11/2015", 50, 3000000);
            dataGridView1.Rows.Add("05/11/2015", 150, 6000000);
            dataGridView1.Rows.Add("06/11/2015", 150, 6000000);
        }
    }
}
