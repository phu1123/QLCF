﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            using (var conn = new SqlConnection(@"Server = .\SQLEXPRESS; Database = QLCF; Trusted_Connection = True"))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM KhuVuc", conn);
                var r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var group = new ListViewGroup(r["TenKhuVuc"].ToString());
                    listView1.Groups.Add(group);

                    for (var i = 1; i <= Convert.ToInt32(r["SoBan"]); i = i + 1)
                    {
                        listView1.Items.Add(new ListViewItem("Bàn" + i, 0, group));
                    }
                }

                r.Close();
                cmd = new SqlCommand("SELECT * FROM HangHoa", conn);
                r = cmd.ExecuteReader();

                while (r.Read())
                {
                    dataGridViewMenu.Rows.Add(r["TenHH"], r["DonViTinh"], r["GiaBan"]);
                }
            }
        }
    }
}
