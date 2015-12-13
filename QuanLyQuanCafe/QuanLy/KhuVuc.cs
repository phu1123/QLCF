using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using APP;
using BUS;
using QuanLyQuanCafe.Dialog;

namespace QuanLyQuanCafe.QuanLy
{
    public partial class KhuVuc : UserControl
    {
        public KhuVuc()
        {
            InitializeComponent();
            RefreshKhuVuc();
        }

        private void RefreshKhuVuc()
        {
            treeView1.Nodes.Clear();

            using (KhuVucBUS bus = new KhuVucBUS())
            {
                foreach (DataRow row in bus.ListKhuVuc().Rows)
                    treeView1.Nodes.Add(row[0].ToString());
            }

            treeView1.SelectedNode = treeView1.TopNode;
        }

        private void RefreshBan()
        {
            listView1.Items.Clear();

            using (KhuVucBUS bus = new KhuVucBUS())
            {
                foreach (DataRow row in bus.ListBan(treeView1.SelectedNode.Text).Rows)
                    listView1.Items.Add(row[1].ToString(), 1).Tag = row[0];
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshBan();
        }

        private void btnXoaKV_Click(object sender, System.EventArgs e)
        {
            using (KhuVucBUS bus = new KhuVucBUS())
            {
                if (new XacNhan {Text = @"Bạn có chắc chắn muốn xóa " + treeView1.SelectedNode.Text }.ShowDialog() == DialogResult.Yes)
                    bus.DeleteKhuVuc(treeView1.SelectedNode.Text);
            }

            RefreshKhuVuc();
        }

        private void btnThemKV_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhuVuc.Text))
            {
                errorProvider1.SetError(txtTenKhuVuc, "Vui lòng điền tên khu vực muốn thêm");
                return;
            }

            errorProvider1.SetError(txtTenKhuVuc, string.Empty);

            try
            {
                using (KhuVucBUS bus = new KhuVucBUS())
                    bus.InsertKhuVuc(txtTenKhuVuc.Text);
            }
            catch (SqlException ex)
            {
                if (ex.Number == DbConnection.MssqlEng002627)
                    errorProvider1.SetError(txtTenKhuVuc, "Khu vực đã tồn tại");
                else throw;
            }

            RefreshKhuVuc();
        }

        private void btnThemBan_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBan.Text))
            {
                errorProvider1.SetError(txtTenBan, "Vui lòng điền tên bàn muốn thêm");
                return;
            }

            errorProvider1.SetError(txtTenBan, string.Empty);

            try
            {
                using (KhuVucBUS bus = new KhuVucBUS())
                    bus.InsertBan(treeView1.SelectedNode.Text, txtTenBan.Text);
            }
            catch (SqlException ex)
            {
                if (ex.Number == DbConnection.MssqlEng002627)
                    errorProvider1.SetError(txtTenBan, "Bàn đã tồn tại trong khu vực");
                else throw;
            }

           RefreshBan();
        }

        private void btnXoaBan_Click(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            using (KhuVucBUS bus = new KhuVucBUS())
            {
                if (new XacNhan { Text = @"Bạn có chắc chắn muốn xóa " + listView1.SelectedItems[0].Text }.ShowDialog() == DialogResult.Yes)
                    bus.DeleteBan(listView1.SelectedItems[0].Tag.ToString());
            }

            RefreshBan();
        }
    }
}
