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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void btnInDSNV_BC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportInDSNV baoCao = new ReportInDSNV();
            baoCao.lbTenChiNhanh_BC.Text = cbbChiNhanh_BC.Text.ToString();
            ReportPrintTool rpt = new ReportPrintTool(baoCao);
            rpt.ShowPreviewDialog();
        }

        private void cbbChiNhanh_BC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanh_BC.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                // Gán chi nhánh mới
                Program.servername = cbbChiNhanh_BC.SelectedValue.ToString();
                // Dùng HTKN để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên combobox
                if (cbbChiNhanh_BC.SelectedIndex != Program.mChinhanhDN)
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

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            cbbChiNhanh_BC.DisplayMember = "TENCN";
            cbbChiNhanh_BC.ValueMember = "TENSERVER";
            cbbChiNhanh_BC.DataSource = Program.bds_dspm;
            cbbChiNhanh_BC.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup == "CONGTY")
            {
                cbbChiNhanh_BC.Enabled = true;
            }
            else
            {
                cbbChiNhanh_BC.Enabled = false;
            }
        }

        private void btnThoat_BC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbbChiNhanh_BC.DataSource = null;
            this.Close();
        }

        private void btnInDSVT_BC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportInDSVT baoCao = new ReportInDSVT();
            ReportPrintTool rpt = new ReportPrintTool(baoCao);
            rpt.ShowPreviewDialog();
        }

        private void btnDDHmotPN_BC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReportInPhieuNhapchuacoDDH baoCao = new ReportInPhieuNhapchuacoDDH();
            ReportPrintTool rpt = new ReportPrintTool(baoCao);
            baoCao.lbChiNhanh_BC.Text = "CHI NHÁNH " + (cbbChiNhanh_BC.SelectedIndex + 1).ToString();
            rpt.ShowPreviewDialog();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void btnBangkeCTSLvaTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBangkeCTSL_TG_hangNX));
            if (frm != null) frm.Activate();
            else
            {
                frmBangkeCTSL_TG_hangNX f = new frmBangkeCTSL_TG_hangNX();
              //  f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHoatDongNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHoatDongNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmHoatDongNhanVien f = new frmHoatDongNhanVien();
                //  f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTongHopNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTongHopNhapXuatTheoNgay));
            if (frm != null) frm.Activate();
            else
            {
                frmTongHopNhapXuatTheoNgay f = new frmTongHopNhapXuatTheoNgay();
                //  f.MdiParent = this;
                f.Show();
            }
        }
    }
}
