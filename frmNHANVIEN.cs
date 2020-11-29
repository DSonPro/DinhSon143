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
    public partial class frmNHANVIEN : Form
    {
        public int vitri,sokt;
        public string macn;
        public string kiemtra = "";
        //    private LastPressedButton lastPressed;
        public frmNHANVIEN()
        {
            InitializeComponent();
            vitri =sokt= 0;
            macn = "";
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNHANVIEN_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            this.datHangTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";


            cmbChinhanh.DataSource = Program.bds_dspm;
            cmbChinhanh.SelectedIndex = Program.mChinhanhDN;
            
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSave.Enabled = btnReload.Enabled = btnUndo.Enabled= btnHieuchinh.Enabled= btnChangeCN_NV.Enabled = false;
            }
            else
            {
                cmbChinhanh.Enabled = false;
                btnSave.Enabled = btnUndo.Enabled = false;
            }

        }

        private void refreshTableAdapter()
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.constr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            //MessageBox.Show(Program.mGroup);
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
                groupBox1.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSave.Enabled = btnReload.Enabled = btnUndo.Enabled = btnHieuchinh.Enabled = btnChangeCN_NV.Enabled = false;
            }
            else
            {
                cmbChinhanh.Enabled = false;
                btnSave.Enabled = btnUndo.Enabled = false;
            }
        }
        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                // Gán chi nhánh mới
                Program.servername = cmbChinhanh.SelectedValue.ToString();
                // Dùng HTKN để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên combobox
                if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
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
                else
                {
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.constr;
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    // Lấy mã chi nhánh hiện tại
                    macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
                    //MessageBox.Show(macn);
                }
            }
            catch (NullReferenceException ex)
            {
                return;
            }
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;
            bdsNV.AddNew();
            btnThem.Enabled = btnHieuchinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            // Vô hiệu hóa phần xem grid
            gcNV.Enabled = false;
            // Cho phép nhập mới mã nhân viên và mà chi nhánh
            txtMACN.Text = macn;
            txtTTXoa.Text = "0";
            txtTTXoa.Enabled = false;
            kiemtra = "them";
            dtpNGAYSINH.Value = DateTime.Today;
        }
        // update dữ liệu vào database
        private void updateTableAdapter()
        {
            bdsNV.EndEdit();
            bdsNV.ResetCurrentItem();
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.constr;
            this.nhanVienTableAdapter.Update(this.DS.NhanVien);
        }
        // start session
        private void startModifyingBDSMode()
        {
            btnSave.Enabled = btnUndo.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnHieuchinh.Enabled = btnReload.Enabled = false;
                //buttonChangeBranch.Enabled = false;
        }
        //end session
        private void endModifyingBDSMode()
        {
            btnSave.Enabled = btnUndo.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnHieuchinh.Enabled = btnReload.Enabled = true;
                //buttonChangeBranch.Enabled = true;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMANV.Focus();
                return;
            }
            else if (!int.TryParse(txtMANV.Text.Trim(), out sokt))
            {
                MessageBox.Show("Mã NV phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMANV.Focus();
                return;
            }
            else if (int.Parse(txtMANV.Text.Trim())<=0)
            {
                MessageBox.Show("Mã NV không được <=0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMANV.Focus();
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHO.Focus();
                return;
            }
            else if (txtHO.Text.Trim().Length > 40)
            {
                MessageBox.Show("Họ quá dài", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTEN.Focus();
                return;
            }
            else if (txtTEN.Text.Trim().Length>10)
            {
                MessageBox.Show("Tên quá dài", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTEN.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDIACHI.Focus();
                return;
            }
            if (txtLUONG.Text.Trim() == "")
            {
                MessageBox.Show("Lương không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLUONG.Focus();
                return;
            }
            else if (!int.TryParse(txtLUONG.Text.Trim(), out sokt))
            {
                MessageBox.Show("Lương phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLUONG.Focus();
                return;
            }
            else if (int.Parse(txtLUONG.Text.Trim())<=0)
            {
                MessageBox.Show("Lương không được <=0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLUONG.Focus();
                return;
            }
            if (txtMACN.Text.Trim() == "")
            {
                MessageBox.Show("Mã chi nhánh không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMACN.Text = macn;
                txtMACN.Focus();
                return;
            }
            else if (txtMACN.Text.Trim().Length>10)
            {
                MessageBox.Show($"Mã chi nhánh quá dài", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMACN.Text = macn;
                txtMACN.Focus();
                return;
            }
            else if (txtMACN.Text.Trim() != macn.Trim())
            {
                MessageBox.Show($"Mã chi nhánh không chính xác đối với chi nhánh hiện tại, bạn nên sửa lại thành {macn}", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMACN.Text = macn;
                txtMACN.Focus();
                return;
            }
            if(dtpNGAYSINH.Text.Trim() == "" || dtpNGAYSINH.Text.Trim() == DateTime.Now.ToString())
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNGAYSINH.Focus();
                return;
            }
            if (kiemtra == "them")
            {
                try
                {
                    string command = "exec dbo.sp_KiemtraMaNV_TonTai " + "'" + txtMANV.Text.ToString().Trim('.') + "'";
                    // MessageBox.Show(command);
                    Program.myReader = Program.ExecSqlDataReader(command);
                    Program.myReader.Read();
                    try
                    {
                        if (Program.myReader.HasRows == true)
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại");
                            Program.myReader.Close();
                            return;
                        }
                        Program.myReader.Close();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    // Cập nhật xuống database

                    updateTableAdapter();
                    MessageBox.Show("Thêm nhân viên thành công");
                    // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                    gcNV.Enabled = true;
                    endModifyingBDSMode();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                updateTableAdapter();
                MessageBox.Show("Update thành công");
                endModifyingBDSMode();
                gcNV.Enabled = true;
                txtMANV.Enabled = true;
                txtMACN.Enabled = true;
            }
        }

        private void btnHieuchinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            startModifyingBDSMode();
            gcNV.Enabled = false;
            txtMANV.Enabled = false;
            txtTTXoa.Enabled = false;
            txtMACN.Enabled = false;
            btnReload.Enabled = true;
           
        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // Đưa BindingSource của nhân viên về mặc định
               
                bdsNV.RemoveFilter();
                refreshTableAdapter();
                gcNV.Enabled = true; 
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Nếu nhân viên đã được tạo tài khoản đăng nhập hệ thống thì không được phép xóa
            // Chạy SP kiểm tra sự tồn tại tài khoản đăng nhập cho nhân viên hiện tại 
            string command = $"exec dbo.SP_THONGTINDANGNHAP 'NV{txtMANV.Text}'";
          //  MessageBox.Show(command);
            Program.myReader = Program.ExecSqlDataReader(command);
            Program.myReader.Read();
                if (Program.myReader.HasRows == true)
                {
                    MessageBox.Show("Nhân viên đã được tạo tài khoản -> Không thể xóa !!!");
                    Program.myReader.Close();
                    return;
                }
                // Nếu nhân viên đã lập bất kì một phiếu nào thì không đươc phép xóa
                if (bdsDH.Count > 0 || bdsPN.Count > 0 || bdsPX.Count > 0)
                {
                    MessageBox.Show($"Nhân viên {txtHO.Text} {txtTEN.Text} đã tạo phiếu nên không thể xóa !!", "Xóa nhân viên thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int delMaNV = 0;
                    if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        try
                        {
                            delMaNV = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
                            bdsNV.RemoveCurrent();
                            this.nhanVienTableAdapter.Connection.ConnectionString = Program.constr;
                            this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xóa nhân viên không thành công !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                            bdsNV.Position = bdsNV.Find("MANV", delMaNV);
                        }
                    }
                    Program.myReader.Close();
            }
            if (bdsNV.Count == 0)
            {
                btnXoa.Enabled = false;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void txtMACN_TextChanged(object sender, EventArgs e)
        {

        }

        //thoát
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbChinhanh.DataSource = null;
            Close();
        }

        // chuyển chi nhánh
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.MaNV_old = int.Parse(txtMANV.Text);
            Program.MaCN_cu = txtMACN.Text.Trim();
                btnChangeCN_NV.Enabled = false;
                frmChuyenChiNhanh f = new frmChuyenChiNhanh();
                f.Show();

        }
    }
}
