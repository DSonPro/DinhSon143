using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT_form
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            btNhanVien_DMuc.Enabled = false;
            btnTaotaikhoan.Enabled = false;
            btnDangXuat.Enabled = false;
            btVattu_DMuc.Enabled = false;
            btnKho_DMuc.Enabled = false;
            btnDonDH_DM.Enabled = false;
            btnPhieuNhap_DM.Enabled = false;
            btnPhieuXuat.Enabled = false;
            btnXoaTaiKhoan.Enabled = false;
            btnBaoCao.Enabled = false;
        }
        private Form CheckExists(Type ftype)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.GetType()==ftype)
                {
                    return f;
                }
            }
            return null;
        }
      private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnDangnhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Form_login));
            if (frm != null) frm.Activate();
            else
            {
                Form_login f = new Form_login();
                f.MdiParent = this;
                f.Show();
            }

        }


        private void btnTaotaikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmAddAccount));
            if (frm != null) frm.Activate();
            else
            {
                frmAddAccount f = new frmAddAccount();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btNhanVien_DMuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNHANVIEN));
            if (frm != null) frm.Activate();
            else
            {
                frmNHANVIEN f = new frmNHANVIEN();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
            Program.frmDN.Close();
        }
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
            Program.frmDN.Close();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int a = 0;
            a = Program.KetNoi();
            Program.frmChinh.btNhanVien_DMuc.Enabled = false;
            Program.frmChinh.btnDangXuat.Enabled = false;
            Program.frmChinh.btnTaotaikhoan.Enabled = false;
            Program.frmChinh.btVattu_DMuc.Enabled = false;
            Program.frmChinh.btnKho_DMuc.Enabled = false;
            Program.frmChinh.btnDonDH_DM.Enabled = false;
            Program.frmChinh.btnPhieuNhap_DM.Enabled = false;
            Program.frmChinh.btnPhieuXuat.Enabled = false;
            Program.frmChinh.btnXoaTaiKhoan.Enabled = false;
            Program.frmChinh.btnBaoCao.Enabled = false;
            Program.frmChinh.MaNV.Text = "Mã nhân viên: " ;
            Program.frmChinh.HoTen.Text = "Họ tên: ";
            Program.frmChinh.Nhom.Text = "Nhóm: ";
            Form frm = this.CheckExists(typeof(Form_login));
            if (frm != null)
            {
                frm.Activate();
                frm.Show();
            }
            else
            {
                Form_login f = new Form_login();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btVattu_DMuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu f = new frmVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnKho_DMuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho f = new frmKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDonDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDonDatHang));
            if (frm != null) frm.Activate();
            else
            {
                frmDonDatHang f = new frmDonDatHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void MaNV_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuNhap_DM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuNhap f = new frmPhieuNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                frmPhieuXuat f = new frmPhieuXuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBaoCao));
            if (frm != null) frm.Activate();
            else
            {
                frmBaoCao f = new frmBaoCao();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
