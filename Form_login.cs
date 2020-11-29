using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_form
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e) // khi kéo cái combobox chi nhánh sẽ có cái này
        {
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DHDataSet.V_DS_PHANMANH);
            cmb_Chinhanh.SelectedIndex = 1; //tự động chọn dòng số 2
            cmb_Chinhanh.SelectedIndex = 0; //tự động chọn dòng số 1
            // muốn không cho gõ chữ thì vào chọn DropDowList (ban đầu là dropdown)
        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Chinhanh.SelectedValue != null)
            {
                Program.servername = cmb_Chinhanh.SelectedValue.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được rỗng", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }
            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu đăng nhập không được rỗng. Kiểm tra lại !", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtPass.Focus();
                return;
            }
            else
            {
                Program.mlogin = txtLogin.Text;
                Program.password = txtPass.Text;
                if (Program.KetNoi() == 0) return;
                // MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);
                // khi đăng nhập thành công thì chạy form main và ẩn form đăng nhập và khi tắt chương trình nhớ tắt cả form main và login
                Program.frmChinh.Show();
                Program.mChinhanh = cmb_Chinhanh.SelectedIndex;
                Program.mChinhanhDN= cmb_Chinhanh.SelectedIndex;
                // Program.frmDN.Hide();
                SqlDataReader myReader;
                //   Program.mChinhanh;
                Program.bds_dspm = bds_DSPM;
                //MessageBox.Show(Program.bds_dspm.ToString());
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                String strLenh = "EXEC SP_THONGTINDANGNHAP '" + Program.mlogin + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null) return;
                myReader.Read(); // đọc 1 dòng , khi có nhiều dòng thì để trong vòng lặp bằng TRUE là đọc thành công, bằng FALSE là hết dòng.
                // => while(myReader.Read()==true) {}
                Program.username = myReader.GetString(0);
                //đọc dữ liệu cột đầu tiên
                if(Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("LogiN bạn nhập không có quyền truy cập dữ liệu. \n Bạn xem lại.");
                    return;
                }
                Program.mHoten = myReader.GetString(1);
                Program.mGroup = myReader.GetString(2);
                myReader.Close();
                Program.conn.Close();
                Program.frmChinh.MaNV.Text = "Mã nhân viên: " + Program.username;
                Program.frmChinh.HoTen.Text = "Họ tên: " + Program.mHoten;
                Program.frmChinh.Nhom.Text = "Nhóm: "+ Program.mGroup;
                MessageBox.Show("Đăng nhập thành công");
                Program.frmChinh.btNhanVien_DMuc.Enabled = true;
                Program.frmChinh.btVattu_DMuc.Enabled = true;
                Program.frmChinh.btnDangXuat.Enabled = true;
                Program.frmChinh.btnKho_DMuc.Enabled = true;
                Program.frmChinh.btnDonDH_DM.Enabled = true;
                Program.frmChinh.btnPhieuNhap_DM.Enabled = true;
                Program.frmChinh.btnPhieuXuat.Enabled = true;
                Program.frmChinh.btnXoaTaiKhoan.Enabled = true;
                Program.frmChinh.btnBaoCao.Enabled = true;
                if (Program.mGroup!="USER")
                {
                    Program.frmChinh.btnTaotaikhoan.Enabled = true;
                }
                this.Hide();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
