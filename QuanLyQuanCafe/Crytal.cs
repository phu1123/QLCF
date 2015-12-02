using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace QuanLyQuanCafe
{
    public partial class Crytal : Form
    {
        public Crytal()
        {
            InitializeComponent();
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Users\Q\Desktop\QLCF\QuanLyQuanCafe\CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            cryRpt.PrintToPrinter(5, false, 1, 5);
        }
    }
}
