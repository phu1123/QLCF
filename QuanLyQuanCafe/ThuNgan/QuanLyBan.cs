using System;
using System.Data;
using System.Windows.Forms;
using BUS;

namespace QuanLyQuanCafe.ThuNgan
{
    public partial class QuanLyBan : UserControl
    {
        public QuanLyBan()
        {
            InitializeComponent();
            dataGridView1.DataSource = dtChiTiet;
        }

        private void QuanLyBan_Load(object sender, EventArgs e)
        {
            using (HangHoaBUS bus = new HangHoaBUS())
                dataGridView2.DataSource = bus.ListHangHoa2();

            using (KhuVucBUS bus = new KhuVucBUS())
            {
                foreach (DataRow row in bus.ListKhuVuc().Rows)
                {
                    var group = new ListViewGroup(row["TenKhuVuc"].ToString());
                    listView1.Groups.Add(group);

                    foreach (DataRow r in bus.ListBan(row["TenKhuVuc"].ToString()).Rows)
                        listView1.Items.Add(new ListViewItem(r["TenBan"].ToString(), 0, group));
                }
            }
        }

        private void UpdateTongTien()
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = $"TenHangHoa LIKE '%{txtTimKiem.Text}%'";
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;

            string hanghoa = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            dtChiTiet.Rows.Add(hanghoa);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += dataGridView1_KeyPress;
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtChiTiet.Rows.Count == 0) return;

            dtChiTiet.Rows[e.RowIndex].SetField("ThanhTien",
                Convert.ToInt32(dtChiTiet.Rows[e.RowIndex].Field<string>("DonGia")) *
                Convert.ToInt32(dtChiTiet.Rows[e.RowIndex].Field<string>("SoLuong")));

            UpdateTongTien();
        }
    }
}
