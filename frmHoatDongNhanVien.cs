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
    public partial class frmHoatDongNhanVien : Form
    {
        public frmHoatDongNhanVien()
        {
            InitializeComponent();
        }


        private void frmHoatDongNhanVien_Load(object sender, EventArgs e)
        {

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            //this.DS.Clear();
            this.DS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            this.cbbMaNV.DataSource = DS.NhanVien;
            this.cbbMaNV.DisplayMember = "MANV";
            this.cbbMaNV.ValueMember = "MANV";

            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";


            cbbChiNhanh.DataSource = Program.bds_dspm;
            cbbChiNhanh.SelectedIndex = Program.mChinhanhDN;

            cbbLoaiPhieu.SelectedIndex = 0;
            if (Program.servername == "DESKTOP-VC4KFV7\\DSON_2")
            {
                cbbChiNhanh.SelectedIndex = 1;
            }
            else
            {
                cbbChiNhanh.SelectedIndex = 0;
            }
            if (Program.mGroup == "CONGTY")
            {
                cbbChiNhanh.Enabled = true;
            }
            else 
            {
                cbbChiNhanh.Enabled = false;
            }

            txbHoTen.Text = Program.mHoten;
            txbHoTen.Enabled = false;
            //string command = $"select HO+TEN from NhanVien where MANV = '{cbbMaNV.Text.Trim()}'";
            //Program.myReader = Program.ExecSqlDataReader(command);
            //Program.myReader.Read();
            //txbHoTen.Text = Program.myReader.GetString(0);
            //txbHoTen.Enabled = false;
            //Program.myReader.Close();
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string loai = "";
            if (cbbLoaiPhieu.SelectedIndex == 0)
            {
                loai = "N";
            }
            else
            {
                loai = "X";
            }
            ReportHDcuaNV rpt = new ReportHDcuaNV(int.Parse(cbbMaNV.Text.Trim()),char.Parse(loai.Trim()), dtpNgayBatDau.Text, dtpNgayDen.Text);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                Program.servername = cbbChiNhanh.SelectedValue.ToString();
                if (cbbChiNhanh.SelectedIndex != Program.mChinhanhDN)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi kết nối với chi nhánh mới", "", MessageBoxButtons.OK);
                }
                else
                {
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.constr;
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    this.cbbMaNV.DataSource = nhanVienTableAdapter.GetData();
                    this.cbbMaNV.DisplayMember = "MANV";
                    this.cbbMaNV.ValueMember = "MANV";
                }
            }
            catch (NullReferenceException exc)
            {
                return;
            }
        }
    }
}
