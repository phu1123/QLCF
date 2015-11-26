using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyQuanCafe.QuanLy
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();      
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(@"Server = .\SQLEXPRESS; Database = QLCF; Trusted_Connection = True"))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
                var r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var cmd2 = new SqlCommand("SELECT PhanQuyen FROM TaiKhoan WHERE MSNV=" + r["MSNV"], conn);
                    MessageBox.Show(cmd2.ExecuteScalar().ToString());
                    dataGridView1.Rows.Add(r["MSNV"], r["TenNV"], r["SoDienThoai"], (bool)cmd2.ExecuteScalar() == false ? "Quản lý" : "Thu Ngân");
                }
            }
        }

        private void raisedButtonAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //flatButtonAddEdit.Text = @"Thêm";

            //foreach (Control c in panel1.Controls)
            //{
            //    errorProvider1.SetError(c, string.Empty);
            //    if (!(c is MaterialSingleLineTextField)) continue;
            //    var tf = c as MaterialSingleLineTextField;
            //    tf.Clear();
            //}
        }

        private void raisedButtonEdit_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.CurrentRow == null)
            //    return;

            //foreach (Control c in panel1.Controls)
            //{
            //    errorProvider1.SetError(c, string.Empty);
            //}

            //panel1.Visible = true;
            //flatButtonAddEdit.Text = @"Sửa";
            //textboxIdentifyNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //textboxPassword.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //textboxFullName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Nam") radioButtonMale.Checked = true;
            //else radioButtonFemale.Checked = true;
            //timePickerBirthday.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            //textboxIDCardNumber.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //textboxAddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //textboxPhone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //timePickerFirstDayWorking.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            //if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Quản lý") radioButtonAdmin.Checked = true;
            //else radioButtonEmployee.Checked = true;
        }

        private void raisedButtonDelete_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.CurrentRow == null)
            //    return;
            //dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            //using (var conn = new SQLiteConnection("Data Source = DB"))
            //{
            //    conn.Open();
            //    var da = new SQLiteDataAdapter("SELECT * FROM NHANVIEN", conn);
            //    using (new SQLiteCommandBuilder(da))
            //        da.Update(employeeTable);
            //}
        }

        private void flatButtonAddEdit_Click(object sender, EventArgs e)
        {
            //foreach (Control c in panel1.Controls)
            //{
            //    if (c is MaterialSingleLineTextField)
            //        errorProvider1.SetError(c, string.IsNullOrEmpty(c.Text) ? "Bạn không được để trống thông tin này" : string.Empty);
            //    if (!(c is Panel)) continue;
            //    if (c.Controls.OfType<MaterialRadioButton>().All(chk => chk.Checked == false))
            //        errorProvider1.SetError(c, "Bạn không được để trống thông tin này");
            //}

            //if (dataGridView1.Rows.Cast<DataGridViewRow>().Any(r => r.Cells[0].Value.ToString() == textboxIdentifyNumber.Text))
            //    errorProvider1.SetError(textboxIdentifyNumber, "Mã số đã tồn tại");

            //if (panel1.Controls.Cast<Control>().Any(c => errorProvider1.GetError(c) != "")) return;

            //if (flatButtonAddEdit.Text == @"Thêm")
            //dang edit ,select row khac.
            // check cmnd 9/ 12 so
        }

        private void flatButtonCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

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
