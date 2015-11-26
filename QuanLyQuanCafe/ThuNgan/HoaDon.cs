using System.Windows.Forms;

namespace QuanLyQuanCafe.ThuNgan
{
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();

            dataGridView1.Rows.Add("1", "1234", "Nguyễn Văn A", "17/04/2015", "50000");
            dataGridView1.Rows.Add("2", "1235", "Thúy Vân", "17/04/2015", "40000");
            dataGridView1.Rows.Add("3", "1236", "Nguyễn Thị Ngọc", "18/04/2015", "30000");
            dataGridView1.Rows.Add("4", "1237", "Nguyễn Ánh", "19/04/2015", "35000");
            dataGridView1.Rows.Add("5", "1238", "Thế Anh", "20/04/2015", "30000");
            dataGridView1.Rows.Add("6", "1239", "Nguyễn Đông", "20/04/2015", "15000");
            dataGridView1.Rows.Add("7", "1240", "Kim Anh", "21/04/2015", "20000");

            dataGridView2.Rows.Add("1", "2345", "BigC", "17/04/2015", "50000");
            dataGridView2.Rows.Add("2", "2346", "Lotte", "17/04/2015", "400000");
            dataGridView2.Rows.Add("3", "2347", "Đại lý C", "18/04/2015", "300000");
            dataGridView2.Rows.Add("4", "2348", "Đại lý A", "19/04/2015", "350000");
            dataGridView2.Rows.Add("5", "2349", "Đại lý B", "20/04/2015", "300000");
        }
    }
}
