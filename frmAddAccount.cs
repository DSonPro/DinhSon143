using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_form
{
    public partial class frmAddAccount : Form
    {
        int tam = -1;
        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void btnThoatCreateTK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (txtPassWord.Text.Trim() == "")
            {
                MessageBox.Show("PassWord không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassWord.Focus();
                return;
            }
            if (txtConfirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("PassWord chưa được xác nhận", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }
            else if(txtConfirmPassword.Text!=txtPassWord.Text)
            {
                MessageBox.Show("PassWord xác nhận không đúng", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }
            if (Program.username == cbbMaNV.Text.ToString())
            {
                MessageBox.Show($"Bạn không thể tạo tài khoản cho bản thân", "Tạo tài khoản thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Thực thi SP tạo login
            try
            {
                // Chạy SP kiểm tra sự tồn tại tài khoản đăng nhập cho nhân viên hiện tại 
                string command = $"exec dbo.SP_THONGTINDANGNHAP 'NV{cbbMaNV.Text}'";
                Program.myReader = Program.ExecSqlDataReader(command);
                if (Program.myReader != null)
                {
                    if (Program.myReader.Read()) // Đã tồn tại
                    {
                        MessageBox.Show($"Nhân viên này đã có tài khoản đăng nhập. \nKhông được phép tạo thêm tài khoản", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Program.myReader.Close();
                        return;
                    }
                    Program.myReader.Close();
                }
                else
                {
                    return;
                }
                string loginname = "NV"+cbbMaNV.Text;
                // Chạy SP tạo tài khoản nếu như thỏa điều kiện 
                command = $"exec dbo.sp_TaoTaiKhoan '{loginname.Trim()}', '{txtPassWord.Text}', '{cbbMaNV.Text}', '{cbbRole.SelectedValue}'";
                //MessageBox.Show(command);
                Program.myReader = Program.ExecSqlDataReader(command);
                if (Program.myReader != null)
                {
                    MessageBox.Show($"Tạo tài khoản thành công với tên đăng nhập là {loginname.Trim()}", " Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản đăng nhập thất bại, hãy kiểm tra lại tên đăng nhập và mã nhân viên", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.myReader.Close();
                }
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void frmAddAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DHDataSet.V_DS_PHANMANH);
            //MessageBox.Show(Program.constr);
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            //this.DS.Clear();
            this.DS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            if(Program.servername== "DESKTOP-VC4KFV7\\DSON_2")
            {
                cbbChinhanh.SelectedIndex = 1;
                tam = 1;
            }
            else
            {
                cbbChinhanh.SelectedIndex = 0;
                tam = 0;
            }
            if (Program.mGroup == "CONGTY")
            {
                cbbChinhanh.Enabled = true;
                Dictionary<string, string> map = new Dictionary<string, string>();
                map.Add("CONGTY", "CONGTY");
                cbbRole.DataSource = new BindingSource(map, null);
                cbbRole.DisplayMember = "Value";
                cbbRole.ValueMember = "Key";
            }
            else if (Program.mGroup == "CHINHANH")
            {
                cbbChinhanh.Enabled = false;
                Dictionary<string, string> map = new Dictionary<string, string>();
                map.Add("USER", "USER");
                map.Add("CHINHANH", "CHINHANH");
                cbbRole.DataSource = new BindingSource(map, null);
                cbbRole.DisplayMember = "Value";
                cbbRole.ValueMember = "Key";
            }
            this.cbbMaNV.DataSource = DS.NhanVien;
            this.cbbMaNV.DisplayMember = "MANV";
            this.cbbMaNV.ValueMember = "MANV";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cbbChinhanh_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            /*
            Dictionary<string, string> map1 = new Dictionary<string, string>();
          //  MessageBox.Show(tam + "==" + cbbChinhanh.SelectedIndex);
            if (cbbChinhanh.SelectedIndex!=tam)
            {
                string command = "exec dbo.sp_NVserver_conlai";
                // MessageBox.Show(command);
                Program.myReader = Program.ExecSqlDataReader(command);

                while (Program.myReader.Read())
                {
                    map1.Add(Program.myReader.GetInt32(0).ToString(), Program.myReader.GetInt32(0).ToString());
                }
                cbbMaNV.DataSource = new BindingSource(map1, null);
                cbbMaNV.DisplayMember = "Value";
                cbbMaNV.ValueMember = "Key";
                Program.myReader.Close();
            }
            else
            {
                cbbMaNV.DataSource = DS.NhanVien;
                this.cbbMaNV.DisplayMember = "MANV";
                this.cbbMaNV.ValueMember = "MANV";
            }*/
            try
            {
                if (cbbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                Program.servername = cbbChinhanh.SelectedValue.ToString();
                if (cbbChinhanh.SelectedIndex != Program.mChinhanhDN)
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

        private void cbbMaNV_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
