using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLVT_form
{
    public partial class frmTongHopNhapXuatTheoNgay : Form
    {
        public frmTongHopNhapXuatTheoNgay()
        {
            InitializeComponent();
        }

        private void frmTongHopNhapXuatTheoNgay_Load(object sender, EventArgs e)
        {
            cbbChinhanh.DisplayMember = "TENCN";
            cbbChinhanh.ValueMember = "TENSERVER";


            cbbChinhanh.DataSource = Program.bds_dspm;
            cbbChinhanh.SelectedIndex = Program.mChinhanhDN;

            if (Program.servername == "DESKTOP-VC4KFV7\\DSON_2")
            {
                cbbChinhanh.SelectedIndex = 1;
            }
            else
            {
                cbbChinhanh.SelectedIndex = 0;
            }
            if (Program.mGroup == "CONGTY")
            {
                cbbChinhanh.Enabled = true;
            }
            else
            {
                cbbChinhanh.Enabled = false;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Parse(dtpNgayStart.Text);
            DateTime end = DateTime.Parse(dtpNgayDen.Text);
            ReportTongHopNhapXuat_theongay rpt = new ReportTongHopNhapXuat_theongay(start, end);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
