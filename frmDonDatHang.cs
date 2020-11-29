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
    public partial class frmDonDatHang : Form
    {
        public int vitri;
        public string loaithem;
        public int parsedValue;
        public string MadonhangNEW;
        public frmDonDatHang()
        {
            InitializeComponent();
            loaithem = "";
            vitri = 0;
            MadonhangNEW="";
            parsedValue = 0;
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.datHangTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            btnAddVatTuxuong.Enabled = false;
            btReload_DDH.Enabled = btnSave_DDH.Enabled= false;

            cmbChinhanh_DDH.DisplayMember = "TENCN";
            cmbChinhanh_DDH.ValueMember = "TENSERVER";


            cmbChinhanh_DDH.DataSource = Program.bds_dspm;
            cmbChinhanh_DDH.SelectedIndex = Program.mChinhanhDN;

            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh_DDH.Enabled = true;
                groupBox1.Enabled =groupBox2.Enabled= false;
                btnGroupThem.Enabled = btnSave_DDH.Enabled  = btReload_DDH.Enabled = btSuaChiTiet_DDH.Enabled=btXoaChiTiet_DDH.Enabled = false;
            }
            else
            {
                cmbChinhanh_DDH.Enabled = false;
            }
            btnThem_CTDDH.Enabled=btSuaChiTiet_DDH.Enabled =btXoaChiTiet_DDH.Enabled=btChotDon_DDH.Enabled= txbMANV_DDH.Enabled= false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // thêm DDH
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupBox1.Enabled = true;
            txbMaSoDDH.Text =txbNhaCC.Text= "";
            txbMANV_DDH.Text = Program.username;
            btnGroupThem.Enabled = btXoaChiTiet_DDH.Enabled = btSuaChiTiet_DDH.Enabled = btReload_DDH.Enabled = btnThoat_DDH.Enabled= btChotDon_DDH.Enabled = false;
            btnSave_DDH.Enabled = true;
            // Vô hiệu hóa phần xem grid
            gcDathang.Enabled =gcCTDDH.Enabled =gcVatTu.Enabled = groupBox2.Enabled = false;
            loaithem = "DDH";
            dtpNgay.Value = DateTime.Today;
            dtpNgay.Enabled = false;

        }
   
        private void btnSave_DDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command = "";
            vitri = bdsDH.Position;
            if (loaithem=="DDH")
            {
                if (txbMaSoDDH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã đơn đặt hàng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaSoDDH.Focus();
                    return;
                }
                else if(txbMaSoDDH.Text.Trim().Length>8)
                {
                    MessageBox.Show("Mã đơn đặt hàng không được nhiều hơn 8 kí tự", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaSoDDH.Focus();
                    return;
                }
                if (txbNhaCC.Text.Trim() == "")
                {
                    MessageBox.Show("Nhà cung cấp không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbNhaCC.Focus();
                    return;
                }
                else if (txbNhaCC.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Nhà cung cấp quá dài", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbNhaCC.Focus();
                    return;
                }
                if(txbMANV_DDH.Text=="")
                {
                    MessageBox.Show("Chưa chọn mã nhân viên", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMANV_DDH.Focus();
                    return;
                }
                else
                {
                    command = $"select TrangThaiXoa from NhanVien where MANV = '{txbMANV_DDH.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(command);
                    Program.myReader.Read();
                    int trangthaixoa = Program.myReader.GetInt32(0);
                    Program.myReader.Close();
                    if (trangthaixoa == 1)
                    {
                        MessageBox.Show("Nhân viên không còn làm việc ở chi nhánh này", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbMANV_DDH.Focus();
                        return;
                    }
                }

                command = $"exec dbo.sp_KiemtraMasoDDH_TonTai N'{txbMaSoDDH.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(command);
                Program.myReader.Read();
                try
                {
                    if (Program.myReader.HasRows == true)
                    {
                        MessageBox.Show("Mã số đơn đặt hàng đã tồn tại ", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.myReader.Close();
                        return;
                    }
                    Program.myReader.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // kiểm tra xem đã tồn tại ở sv còn lại kia chưa nếu có thì thêm vào để cho khác
                string CNconlai = "";
                if(cmbChinhanh_DDH.SelectedIndex==0)
                {
                    CNconlai = "CN2";
                }
                else
                {
                    CNconlai = "CN1";
                }
                string laycn =(cmbChinhanh_DDH.SelectedIndex + 1).ToString();
                command = $"exec dbo.sp_MDDH_kiemtra '{txbMaSoDDH.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(command);
                Program.myReader.Read();
                try
                {
                    if (Program.myReader.HasRows == true && txbMaSoDDH.Text.Trim().Length<8)
                    {
                        if (MessageBox.Show($"Mã DDH đã tồn tại ở server {CNconlai}. Bạn có muốn thêm DDH này ko ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            txbMaSoDDH.Text +=laycn;
                            Program.myReader.Close();
                        }
                        else
                        {
                            Program.myReader.Close();
                            txbMaSoDDH.Focus();
                            return;
                        }
                    }
                    else if(Program.myReader.HasRows == true && txbMaSoDDH.Text.Trim().Length > 8)
                    {
                        MessageBox.Show($"Mã DDH đã tồn tại ở server {CNconlai} và đã đủ 8 kí tự nên không thể tự đồng chèn");
                        Program.myReader.Close();
                        txbMaSoDDH.Focus();
                        return;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Program.myReader.Close();
                command = $"exec dbo.sp_addddh '{txbMaSoDDH.Text.Trim()}', '{dtpNgay.Text}', '{txbNhaCC.Text.Trim()}', '{txbMANV_DDH.Text.Trim()}'";
                //MessageBox.Show(command);
                Program.myReader = Program.ExecSqlDataReader(command);
                Program.myReader.Read();
                if (Program.myReader != null)
                {
                    MadonhangNEW = txbMaSoDDH.Text;
                    MessageBox.Show($"Tạo đơn đặt hàng thành công ", " Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.constr;
                    // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
                    this.datHangTableAdapter.Fill(this.DS.DatHang);
                    btnGroupThem.Enabled= btChotDon_DDH.Enabled = true;
                    btnSave_DDH.Enabled = btnThem_DDH.Enabled = btnThoat_DDH.Enabled = false;
                    btnThem_CTDDH.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Tạo đơn đặt hàng thất bại, hãy kiểm tra lại thông tin", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.myReader.Close();
                }
                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                gcDathang.Enabled = gcCTDDH.Enabled = gcVatTu.Enabled = groupBox2.Enabled = true;
            }
            // thêm ctDDH
            else if(loaithem=="CTDDH")
            {
                if (txbMaSoDDH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã đơn đặt hàng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaSoDDH.Focus();
                    return;
                }
                else if (txbMaSoDDH.Text.Trim().Length > 8)
                {
                    MessageBox.Show("Mã đơn đặt hàng không được nhiều hơn 8 kí tự", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaSoDDH.Focus();
                    return;
                }
                if (txbMaVT_CTDDH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã vật tư không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaVT_CTDDH.Focus();
                    return;
                }
                else if (txbMaVT_CTDDH.Text.Trim().Length > 4)
                {
                    MessageBox.Show("Mã vật tư không được nhiều hơn 4 kí tự", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaVT_CTDDH.Focus();
                    return;
                }
                else
                {
                    string com = $"exec dbo.sp_KiemtraVT_TonTai '{txbMaVT_CTDDH.Text.Trim()}',N'{""}' ";
                    Program.myReader = Program.ExecSqlDataReader(com);
                    Program.myReader.Read();
                    try
                    {
                        if (Program.myReader.HasRows == false)
                        {
                            MessageBox.Show("Mã vật tư không tồn tại ", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Program.myReader.Close();
                            txbMaVT_CTDDH.Focus();
                            return;
                        }
                        Program.myReader.Close();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                //số lượng
                if (txbSoLuongVT.Text.Trim() == "")
                {
                    MessageBox.Show("Số lượng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuongVT.Focus();
                    return;
                }
                else if (!int.TryParse(txbSoLuongVT.Text.Trim(), out parsedValue))
                {
                    MessageBox.Show("Số lượng không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuongVT.Focus();
                    return;
                }
                else if (int.Parse(txbSoLuongVT.Text.Trim()) <= 0)
                {
                    MessageBox.Show("Số lượng không được nhỏ hơn hoặc bằng 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuongVT.Focus();
                    return;
                }
                // đơn giá
                if (txbDongia_DDH.Text.Trim() == "")
                {
                    MessageBox.Show("Đơn giá không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDongia_DDH.Focus();
                    return;
                }
                else if (!int.TryParse(txbDongia_DDH.Text.Trim(), out parsedValue))
                {
                    MessageBox.Show("Đơn giá không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDongia_DDH.Focus();
                    return;
                }
                else if (int.Parse(txbDongia_DDH.Text.Trim()) < 0)
                {
                    MessageBox.Show("Đơn giá không được nhỏ hơn 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDongia_DDH.Focus();
                    return;
                }
                // kiểm tra mã DDH có tồn tại
                command = $"exec dbo.sp_KiemtraMasoDDH_TonTai N'{txbMaSoDDH.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(command);
                Program.myReader.Read();
                try
                {
                    if (Program.myReader.HasRows == true)
                    {
                        Program.myReader.Close();
                        command = $"exec dbo.sp_addctddh '{txbMaSoDDH.Text.Trim()}', '{txbMaVT_CTDDH.Text.Trim()}', '{txbSoLuongVT.Text.Trim()}', '{txbDongia_DDH.Text.Trim()}'";
                        //MessageBox.Show(command);
                        Program.myReader = Program.ExecSqlDataReader(command);
                        Program.myReader.Read();
                        if (Program.myReader != null)
                        {
                            MessageBox.Show($"Tạo chi tiết đơn đặt hàng thành công ", " Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Program.myReader.Close();
                            btnGroupThem.Enabled = btXoaChiTiet_DDH.Enabled = btSuaChiTiet_DDH.Enabled  = btChotDon_DDH.Enabled = true;
                            gcCTDDH.Enabled = gcDathang.Enabled = dtpNgay.Enabled = txbNhaCC.Enabled = true;
                             btnSave_DDH.Enabled = false;
                            this.datHangTableAdapter.Connection.ConnectionString = Program.constr;
                            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
                            this.datHangTableAdapter.Fill(this.DS.DatHang);

                            this.cTDDHTableAdapter.Connection.ConnectionString = Program.constr;
                            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
                            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
                        }
                        else
                        {
                            MessageBox.Show("Tạo chi tiết đơn đặt hàng thất bại, hãy kiểm tra lại thông tin", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Program.myReader.Close();
                        }
                    }
                    Program.myReader.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Mã số DDH không tồn tại");
                    txbMaSoDDH.Focus();
                    return;
                }

            }
        }

        private void btnThem_CTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(MadonhangNEW+"5" + "===" + ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString()+"5");
            if (String.Compare(MadonhangNEW,((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString().Trim(),true) ==0)
            {
                groupBox2.Enabled = true;
                txbDongia_DDH.Text = txbMaVT_CTDDH.Text = txbSoLuongVT.Text = "";
                txbMaVT_CTDDH.Text = ((DataRowView)bdsVatTu[bdsVatTu.Position])["MAVT"].ToString().Trim();

                string com = $"select * from CTDDH where MAVT = '{txbMaVT_CTDDH.Text.Trim()}' AND MasoDDH = '{MadonhangNEW.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                if (Program.myReader.HasRows == true)
                {
                    MessageBox.Show("Đã có chi tiết DDH của vật tư này", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();


                btnGroupThem.Enabled = btXoaChiTiet_DDH.Enabled = btSuaChiTiet_DDH.Enabled = btReload_DDH.Enabled = btChotDon_DDH.Enabled = false;
                btnSave_DDH.Enabled = true;
                // Vô hiệu hóa phần xem grid
                loaithem = "CTDDH";
                gcCTDDH.Enabled = gcDathang.Enabled = dtpNgay.Enabled = txbNhaCC.Enabled= txbMANV_DDH.Enabled= txbMaSoDDH.Enabled = false;
                btnAddVatTuxuong.Enabled = true;
            }
            else if(String.Compare(MadonhangNEW, ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString().Trim(), true) != 0)
            {
                MessageBox.Show("Chỉ thêm chi tiết đơn hàng cho đơn hàng mới thêm của bạn");
            }
        }

        private void gcVatTu_Click(object sender, EventArgs e)
        {
            vitri = bdsVatTu.Position;
            txbMaVT_CTDDH.Text = ((DataRowView)bdsVatTu[vitri])["MAVT"].ToString();
        }

        private void txbMaVT_CTDDH_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAddVatTuxuong_Click(object sender, EventArgs e)
        {
            vitri = bdsVatTu.Position;
            txbMaVT_CTDDH.Text = ((DataRowView)bdsVatTu[vitri])["MAVT"].ToString();
        }

        private void cmbChinhanh_DDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbChinhanh_DDH.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                // Gán chi nhánh mới
                Program.servername = cmbChinhanh_DDH.SelectedValue.ToString();
                // Dùng HTKN để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên combobox
                if (cmbChinhanh_DDH.SelectedIndex != Program.mChinhanhDN)
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
                    this.datHangTableAdapter.Connection.ConnectionString = Program.constr;
                    this.datHangTableAdapter.Fill(this.DS.DatHang);
                }
            }
            catch (NullReferenceException ex)
            {
                return;
            }
        }

        private void btSuaChiTiet_DDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsChiTietDDH.Count == 0)
            {
                MessageBox.Show("Chưa có chi tiết đơn đặt hàng nào cả", "", MessageBoxButtons.OK);
                return;
            }
            if ((MadonhangNEW == ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString().Trim()) && bdsChiTietDDH.Count>0)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
                btnGroupThem.Enabled = btXoaChiTiet_DDH.Enabled = btSuaChiTiet_DDH.Enabled = btnSave_DDH.Enabled= btChotDon_DDH.Enabled = false;
                btnSave_DDH.Enabled = true;
                // Vô hiệu hóa phần xem grid
                gcVatTu.Enabled = gcCTDDH.Enabled = gcDathang.Enabled = dtpNgay.Enabled = txbNhaCC.Enabled = false;
                btReload_DDH.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể chỉnh sửa đơn hàng mới lập", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void refreshTableAdapter()
        {
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.constr;
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
            //MessageBox.Show(Program.mGroup);
        }

        private void btReload_DDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbMaVT_CTDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaVT_CTDDH.Focus();
                return;
            }
            else if (txbMaVT_CTDDH.Text.Trim().Length > 4)
            {
                MessageBox.Show("Mã vật tư không được nhiều hơn 4 kí tự", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaVT_CTDDH.Focus();
                return;
            }
            else
            {
                string com = $"select TENVT from VATTU where MAVT = '{txbMaVT_CTDDH.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                try
                {
                    if (Program.myReader.HasRows == false)
                    {
                        MessageBox.Show("Mã vật tư không tồn tại ", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.myReader.Close();
                        txbMaVT_CTDDH.Focus();
                        return;
                    }
                    Program.myReader.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //số lượng
            if (txbSoLuongVT.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng tồn không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoLuongVT.Focus();
                return;
            }
            else if (!int.TryParse(txbSoLuongVT.Text, out parsedValue))
            {
                MessageBox.Show("Số lượng tồn không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoLuongVT.Focus();
                return;
            }
            else if (int.Parse(txbSoLuongVT.Text.Trim()) <= 0)
            {
                MessageBox.Show("Số lượng tồn không được nhỏ hơn hoặc bằng 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoLuongVT.Focus();
                return;
            }
            // đơn giá
            if (txbDongia_DDH.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDongia_DDH.Focus();
                return;
            }
            else if (!int.TryParse(txbDongia_DDH.Text, out parsedValue))
            {
                MessageBox.Show("Đơn giá không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDongia_DDH.Focus();
                return;
            }
            else if (int.Parse(txbDongia_DDH.Text.Trim()) < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDongia_DDH.Focus();
                return;
            }
            try
            {
                bdsDH.RemoveFilter();
                bdsChiTietDDH.RemoveFilter();
                bdsVatTu.RemoveFilter();
               // refreshTableAdapter();
                groupBox1.Enabled = true;
                gcVatTu.Enabled=gcCTDDH.Enabled = gcDathang.Enabled = dtpNgay.Enabled = txbNhaCC.Enabled = true;
                btnGroupThem.Enabled = btXoaChiTiet_DDH.Enabled = btSuaChiTiet_DDH.Enabled  = btChotDon_DDH.Enabled = true;
                btReload_DDH.Enabled = false;
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btChotDon_DDH.Enabled = true;
            }
        }

        private void gcDathang_Click(object sender, EventArgs e)
        {
        }

        private void btXoaChiTiet_DDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btChotDon_DDH.Enabled = false;
            if (bdsChiTietDDH.Count == 0)
            {
                MessageBox.Show("Không có chi tiết đơn đặt hàng nào để xóa", "Lỗi khi xóa", MessageBoxButtons.OK);
                btXoaChiTiet_DDH.Enabled = false;
                return;
            }
            if ((MadonhangNEW == ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString().Trim()))
            {
                string delCTDDH = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết DDH này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        delCTDDH = ((DataRowView)bdsChiTietDDH[bdsChiTietDDH.Position])["MasoDDH"].ToString();
                        bdsChiTietDDH.RemoveCurrent();
                        this.cTDDHTableAdapter.Connection.ConnectionString = Program.constr;
                        this.cTDDHTableAdapter.Update(this.DS.CTDDH);
                        MessageBox.Show("Xóa chi tiết DDH thành công !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa chi tiết DDH không thành công !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
                        bdsChiTietDDH.Position = bdsChiTietDDH.Find("MasoDDH", delCTDDH);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể xóa chi tiết DDH vừa thêm", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btChotDon_DDH.Enabled = true;
                return;
            }
            btChotDon_DDH.Enabled = true;
        }

        private void btChotDon_DDH_Click(object sender, EventArgs e)
        {
            if ((MadonhangNEW.Trim() == ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString().Trim()))
            {
                if (MessageBox.Show("Bạn có thật sự muốn xác nhận DDH này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (bdsChiTietDDH.Count == 0)
                    {
                        try
                        {
                            bdsDH.RemoveCurrent();
                            this.datHangTableAdapter.Connection.ConnectionString = Program.constr;
                            this.datHangTableAdapter.Update(this.DS.DatHang);
                            MessageBox.Show("Đã xóa DDH vì không có CTDDH nào !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                MadonhangNEW = "";
                btnThem_DDH.Enabled = true;
                frmDonDatHang_Load(sender, e);
                btnThoat_DDH.Enabled = true;
            }
            else
            {
                MessageBox.Show("Hãy Chọn đơn vừa thêm !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_DDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
