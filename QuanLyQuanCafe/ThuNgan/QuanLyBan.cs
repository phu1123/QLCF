using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUS;

namespace QuanLyQuanCafe.ThuNgan
{
    public partial class QuanLyBan : UserControl
    {
        public QuanLyBan()
        {
            InitializeComponent();
        }

        private void QuanLyBan_Load(object sender, EventArgs e)
        {
            using (HangHoaBUS bus = new HangHoaBUS())
                dataGridView2.DataSource = bus.ListHangHoa2();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = $"TenHangHoa LIKE '%{txtTimKiem.Text}%'";
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            string tenhanghoa = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //dtChiTiet.Rows.Add(tenhanghoa);
        }
    }
}
