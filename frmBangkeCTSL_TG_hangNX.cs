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
    public partial class frmBangkeCTSL_TG_hangNX : Form
    {
        public int so;
        public static string start, end;
        public frmBangkeCTSL_TG_hangNX()
        {
            InitializeComponent();
            so = 0;
            start = end = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                // Gán chi nhánh mới
                Program.servername = cbbChiNhanh.SelectedValue.ToString();
                // Dùng HTKN để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên combobox
                if (cbbChiNhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                // Dùng tài khoản khi đăng nhập nếu như chọn lại chi nhánh chọn khi đăng nhập
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi kết nối với chi nhánh mới", "", MessageBoxButtons.OK);
                }
            }
            catch (NullReferenceException ex)
            {
                return;
            }
        }

        private void frmBangkeCTSL_TG_hangNX_Load(object sender, EventArgs e)
        {
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.DataSource = Program.bds_dspm;
            cbbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                cbbChiNhanh.Enabled = true;
            }
            else
            {
                cbbChiNhanh.Enabled = false;
            }
        }

        private void btnXemBangKeKhai_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(dtpNgayEnd.Value.Date.Day.ToString());
            string loai = "";
            if(cbbLoai.SelectedIndex==0)
            {
                loai = "N";
            }
            else
            {
                loai = "X";
            }
            ReportBangKeKhaiCTSL_TG rpt = new ReportBangKeKhaiCTSL_TG(char.Parse(loai.Trim()), dtpNgaybatdau.Text,dtpNgayEnd.Text);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}
