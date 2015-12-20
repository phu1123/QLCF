using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using APP;
using BUS;
using DTO;
using QuanLyQuanCafe.Dialog;

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

            using (KhuVucBUS bus = new KhuVucBUS())
            {
                foreach (DataRow row in bus.ListKhuVuc().Rows)
                {
                    var group = new ListViewGroup(row["TenKhuVuc"].ToString());
                    listView1.Groups.Add(group);

                    foreach (DataRow r in bus.ListBan(row["TenKhuVuc"].ToString()).Rows)
                        listView1.Items.Add(new ListViewItem(r["TenBan"].ToString(),
                            bus.IsAvailable(r["MaSoBan"].ToString()) ? 0 : 1, group)).Tag = r["MaSoBan"];

                    listView1.Items[0].Selected = true;
                }
            }

            using (QuanLyBanBUS bus = new QuanLyBanBUS())
                txtSoHoaDon.Text = bus.GetSoHoaDon().ToString();
        }

        private bool IsInputErr()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Cells[2].ErrorText = row.Cells[2].Value == DBNull.Value ? "Nhập thông tin" : string.Empty;

            errorProvider1.SetError(txtSoHoaDon, string.IsNullOrWhiteSpace(txtSoHoaDon.Text) ? "Bạn không được để trống thông tin này" : string.Empty);

            return dataGridView1.Rows.Count == 0 || errorProvider1.GetError(txtSoHoaDon) != string.Empty ||
                   dataGridView1.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[2].ErrorText != string.Empty);
        }

        private void RefreshHangHoa()
        {
            using (QuanLyBanBUS bus = new QuanLyBanBUS())
                dataGridView1.DataSource = bus.LoadHangHoa();

            using (QuanLyBanBUS bus = new QuanLyBanBUS())
            {
                int exclTax = bus.ExclTax();
                lblExclTax.Text = exclTax.ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
                lblTongTien.Text = (exclTax - (exclTax * nudThue.Value * 0.01m)).ToString("N0", CultureInfo.CreateSpecificCulture("vi-VN"));
            }

            listView1.Items.OfType<ListViewItem>().Single(i => (int) i.Tag == QuanLyBanBUS.Masoban).ImageIndex = dataGridView1.Rows.Count == 0 ? 0 : 1;

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = $"TenHangHoa LIKE '%{txtTimKiem.Text}%'";
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string hanghoa = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                string dongia = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();

                using (QuanLyBanBUS bus = new QuanLyBanBUS())
                    bus.InsertHangHoa(hanghoa, dongia);

                RefreshHangHoa();
            }
            catch (SqlException ex)
            {
                if (ex.Number != DbConnection.MssqlEng002627) throw;
            }  
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
            if (dataGridView1.Rows.Count == 0) return;

            string tenhanghoa = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string soluong = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            using (QuanLyBanBUS bus = new QuanLyBanBUS())
                bus.UpdateSoLuong(tenhanghoa, soluong);

            RefreshHangHoa();
        }

        private void nudThue_ValueChanged(object sender, EventArgs e)
        {
            RefreshHangHoa();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected) return;
            lblBan.Text = (listView1.SelectedItems[0].Group.Header + @" - " + listView1.SelectedItems[0].Text).ToUpper();
            QuanLyBanBUS.Masoban = (int) listView1.SelectedItems[0].Tag;
            RefreshHangHoa();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            using (QuanLyBanBUS bus = new QuanLyBanBUS())
                bus.DeleteHangHoa(e.Row.Cells[0].Value.ToString());
            e.Cancel = true;
            RefreshHangHoa();
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            using (QuanLyBanBUS bus = new QuanLyBanBUS())
                bus.ClearHangHoa();
            RefreshHangHoa();
        }

        private void txtSoHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (IsInputErr()) return;

            try
            {
                using (QuanLyBanBUS bus = new QuanLyBanBUS())
                {
                    BanHangDTO info = new BanHangDTO
                    {
                        Msnv = ThuNgan.MsnvLogin,
                        MaSoBan = QuanLyBanBUS.Masoban,
                        SoHoaDon = Convert.ToInt32(txtSoHoaDon.Text),
                        GioRa = DateTime.Now,
                        GhiChu = txtGhiChu.Text,
                        KhuyenMai = nudThue.Value,
                        TongTien = int.Parse(lblTongTien.Text, NumberStyles.AllowThousands,
                            CultureInfo.CreateSpecificCulture("vi-VN")),
                        ChiTiet = bus.LoadHangHoa()
                    };

                    bus.BanHang(info);
                    bus.ClearHangHoa();
                    RefreshHangHoa();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == DbConnection.MssqlEng002627)
                    errorProvider1.SetError(txtSoHoaDon, "Hóa đơn đã tồn tại");
                else throw;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(IsInputErr()) return;

            using (QuanLyBanBUS bus = new QuanLyBanBUS())
            {
                BanHangDTO info = new BanHangDTO
                {
                    MaSoBan = QuanLyBanBUS.Masoban,
                    SoHoaDon = Convert.ToInt32(txtSoHoaDon.Text),
                    GioRa = DateTime.Now,
                    GhiChu = txtGhiChu.Text,
                    KhuyenMai = nudThue.Value,
                    TongTien =
                        int.Parse(lblTongTien.Text, NumberStyles.AllowThousands,
                            CultureInfo.CreateSpecificCulture("vi-VN")),
                    ChiTiet = bus.LoadHangHoa()
                };

                new BanHangReport(info).ShowDialog();
            }

        }
    
    }
}
