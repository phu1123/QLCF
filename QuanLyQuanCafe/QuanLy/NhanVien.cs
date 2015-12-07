using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using BUS;
using DTO;

namespace QuanLyQuanCafe.QuanLy
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
            RefreshNhanVien();
        }

        public void RefreshNhanVien()
        {
            using (NhanVienBUS nhanvienBUS = new NhanVienBUS())
                dataGridView1.DataSource = nhanvienBUS.ListNhanVien();
        }

        private void raisedButtonAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            dataGridView1.ClearSelection();
            flatButtonAddEdit.Text = @"Thêm";

            foreach (Control c in panel1.Controls)
            {
                errorProvider1.SetError(c, string.Empty);
                if (!(c is MaterialSingleLineTextField)) continue;
                var tf = c as MaterialSingleLineTextField;
                tf.Clear();
            }
        }


        private void raisedButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            using (NhanVienBUS nhanvienBUS = new NhanVienBUS())
            {
                string msnv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                nhanvienBUS.DeleteNhanVien(msnv);
            }

            RefreshNhanVien();
        }

        private void flatButtonAddEdit_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is MaterialSingleLineTextField)
                    errorProvider1.SetError(c, string.IsNullOrWhiteSpace(c.Text) ? "Bạn không được để trống thông tin này" : string.Empty);

                if (c is Panel)
                    errorProvider1.SetError(c, c.Controls.OfType<MaterialRadioButton>().All(chk => chk.Checked == false) ? "Bạn không được để trống thông tin này" : string.Empty);
            }

            if (flatButtonAddEdit.Text == @"Thêm")
            {
                using (NhanVienBUS nhanvienBUS = new NhanVienBUS())
                {
                    if(nhanvienBUS.IsUserNameExist(textBoxUserName.Text))
                        errorProvider1.SetError(textBoxUserName, "Tên đăng nhập đã tồn tại");
                }
            }

            if (panel1.Controls.Cast<Control>().Any(c => errorProvider1.GetError(c) != string.Empty)) return;

            using (NhanVienBUS nhanvienBUS = new NhanVienBUS())
            {
                NhanVienDTO info = new NhanVienDTO
                {
                    UserName = textBoxUserName.Text,
                    Password = textBoxPassword.Text,
                    FullName = textBoxFullName.Text,
                    Gender = radioButtonFemale.Checked,
                    Birthday = timePickerBirthday.Value,
                    CMND = textBoxCMND.Text,
                    Address = textBoxAddress.Text,
                    Phone = textBoxPhone.Text,
                    WorkSince = timePickerWorkSince.Value,
                    Position = radioButtonCashier.Checked
                };

                if (dataGridView1.SelectedRows.Count == 0)
                    nhanvienBUS.InsertNhanVien(info);
                else
                {
                    string msnv = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    nhanvienBUS.EditNhanVien(info, msnv);              
                }
            }

            RefreshNhanVien();
        }

        private void textFieldSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = $"TenNV LIKE '%{textFieldSearch.Text}%' OR MSNV + '' LIKE '%{textFieldSearch.Text}%' OR SoDienThoai LIKE '%{textFieldSearch.Text}%'";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText != @"Chức vụ") return;
            e.Value = (bool)e.Value ? "Thu ngân" : "Quản lý";
            e.FormattingApplied = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (!dataGridView1.Focused)
            {
                dataGridView1.ClearSelection();
                panel1.Visible = false;
                return;
            }

            foreach (Control c in panel1.Controls)
                errorProvider1.SetError(c, string.Empty);

            panel1.Visible = true;
            flatButtonAddEdit.Text = @"Sửa";

            using (NhanVienBUS nhanvienBUS = new NhanVienBUS())
            {
                if (dataGridView1.CurrentRow == null) return;

                string msnv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                NhanVienDTO info = nhanvienBUS.LoadNhanVien(msnv);
                textBoxUserName.Text = info.UserName;
                textBoxPassword.Text = info.Password;
                textBoxFullName.Text = info.FullName;
                if (info.Gender) radioButtonFemale.Checked = true;
                else radioButtonMale.Checked = true;
                timePickerBirthday.Value = info.Birthday;
                textBoxCMND.Text = info.CMND;
                textBoxAddress.Text = info.Address;
                textBoxPhone.Text = info.Phone;
                timePickerWorkSince.Value = Convert.ToDateTime(info.WorkSince);
                if (info.Position) radioButtonCashier.Checked = true;
                else radioButtonManager.Checked = true;
            }
        }

        private void flatButtonCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.ClearSelection();
        }

        private void textboxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textboxIDCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

    }
}
