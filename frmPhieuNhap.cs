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
    public partial class frmPhieuNhap : Form
    {
        public string MaPNNEW;
        public String loaithem;
        public int soluong_CTPN;
        public int soluongcu_CTPN;
        public int b;
        public frmPhieuNhap()
        {
            InitializeComponent();
            loaithem = MaPNNEW= "";
            soluong_CTPN =soluongcu_CTPN=b= 0;
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.DS.CTPN);

            this.datHangTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);



            btnSave_PN.Enabled =btnReloadCTDDH_PN.Enabled=btnXoaCTPN_PN.Enabled=btnSuaCTPN_PN.Enabled=btnThemCTPN_PN.Enabled=btnExit_PN.Enabled= false;
            cbbChiNhanh_PN.DisplayMember = "TENCN";
            cbbChiNhanh_PN.ValueMember = "TENSERVER";


            cbbChiNhanh_PN.DataSource = Program.bds_dspm;
            cbbChiNhanh_PN.SelectedIndex = Program.mChinhanhDN;

            if (Program.mGroup == "CONGTY")
            {
                cbbChiNhanh_PN.Enabled = true;
                groupBox1.Enabled = groupBox2.Enabled = false;
                btnSave_PN.Enabled  = btnThemCTPN_PN.Enabled = btnThem_PN.Enabled =btnChotPN.Enabled= false;
            }
            else
            {
                cbbChiNhanh_PN.Enabled = false;
            }

        }

        private void phieuNhapBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnThemCTPN_PN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((MaPNNEW == ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position])["MAPN"].ToString().Trim()))
            {
                txbMasoDDH_PN.Text = "";
                txbMasoDDH_PN.Text = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MasoDDH"].ToString().Trim();
                txbMasoDDH_PN.Enabled = false;
                groupBox1.Enabled = false;
                txbMaVT_PN.Text = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MAVT"].ToString().Trim();
                txbMaVT_PN.Enabled = false;
                txbMaPN_PN.Text = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position])["MAPN"].ToString().Trim();
                //
                string com = $"select * from CTPN where MAVT = '{txbMaVT_PN.Text.Trim()}' AND MAPN = '{MaPNNEW.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                if (Program.myReader.HasRows == true)
                { 
                        MessageBox.Show("Đã có chi tiết phiếu nhập của vật tư này trong phiếu nhập hiện tại", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.myReader.Close();
                        return;
                }
                Program.myReader.Close();
                //
                txbMaNV_PN.Text = Program.username;
                txbSoLuong_PN.Text = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["SOLUONG"].ToString().Trim();
                txbDonGia_PN.Text = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["DONGIA"].ToString().Trim();
                txbMasoDDH_PN.Text = ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString().Trim();
                loaithem = "CTPN";
                btnSave_PN.Enabled = true;
                btnThemCTPN_PN.Enabled = btnThem_PN.Enabled =btnSuaCTPN_PN.Enabled=btnXoaCTPN_PN.Enabled= btnChotPN.Enabled = false;
                gcCTDDH.Enabled = gcCTPN.Enabled = gcDH.Enabled = gcPN.Enabled = false;
                soluong_CTPN = int.Parse(((DataRowView)bdsCTDDH[bdsCTDDH.Position])["SOLUONG"].ToString().Trim());
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể chỉnh sửa phiếu nhập vừa thêm", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThem_PN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTDDH.Count == 0)
            {
                MessageBox.Show("Đơn hàng không có chi tiết đơn hàng không thể lập phiếu", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txbMasoDDH_PN.Text = "";
            txbMasoDDH_PN.Text = ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString().Trim();
            txbMasoDDH_PN.Enabled = false;
            //kiểm tra DDH đã dc lập phiếu nhập chưa
            string com = $"select * from PhieuNhap where MasoDDH = '{txbMasoDDH_PN.Text.Trim()}'";
            Program.myReader = Program.ExecSqlDataReader(com);
            Program.myReader.Read();
            if (Program.myReader.HasRows == true)
            {
                MessageBox.Show("Đơn hàng đã được lập phiếu nhập nên không thể lập thêm phiếu", " Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Close();
            groupBox2.Enabled = false;
            txbMaNV_PN.Text = Program.username;
            btnThem_PN.Enabled = btnThemCTPN_PN.Enabled =btnExit_PN.Enabled= btnChotPN.Enabled = false;
            btnSave_PN.Enabled = true;
            // Vô hiệu hóa phần xem grid
            loaithem = "PN";
            dtpNgay_PN.Value = DateTime.Today;
            dtpNgay_PN.Enabled = false;
            gcCTDDH.Enabled = gcCTPN.Enabled = gcDH.Enabled = gcPN.Enabled =txbMaNV_PN.Enabled= false;
        }

        private void btnSave_PN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string com = "";
            if(loaithem=="PN")
            {
                if(txbMaPN_PN.Text.Trim()=="")
                {
                    MessageBox.Show("Mã phiếu nhập không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaPN_PN.Focus();
                    return;
                }
                else if(txbMaPN_PN.Text.Trim().Length>8)
                {

                    MessageBox.Show("Mã phiếu nhập không được nhiều hơn 8 kí tự", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaPN_PN.Focus();
                    return;
                }
                else
                {
                    com = $"select MAPN from PhieuNhap where MAPN = '{txbMaPN_PN.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(com);
                    Program.myReader.Read();
                    try
                    {
                        if (Program.myReader.HasRows == true)
                        {
                            MessageBox.Show("Mã phiếu nhập đã tồn tại ", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Program.myReader.Close();
                            txbMaPN_PN.Focus();
                            return;
                        }
                        Program.myReader.Close();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                // kiểm tra mã PN đã tồn tại ở chi nhánh còn lại hay chưa
                string CNconlai = "";
                if (cbbChiNhanh_PN.SelectedIndex == 0)
                {
                    CNconlai = "CN2";
                }
                else
                {
                    CNconlai = "CN1";
                }
                string laycn = (cbbChiNhanh_PN.SelectedIndex + 1).ToString();
                com = $"exec dbo.sp_MPN_kiemtra '{txbMaPN_PN.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                try
                {
                    if (Program.myReader.HasRows == true && txbMaPN_PN.Text.Trim().Length < 8)
                    {
                        if (MessageBox.Show($"Mã PN đã tồn tại ở server {CNconlai}. Bạn có muốn thêm PN này ko ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Program.myReader.Close();
                            txbMaPN_PN.Text += laycn;
                        }
                        else
                        {
                            Program.myReader.Close();
                            cbbChiNhanh_PN.Focus();
                            return;
                        }
                    }
                    else if (Program.myReader.HasRows == true && cbbChiNhanh_PN.Text.Trim().Length > 8)
                    {
                        MessageBox.Show($"Mã PN đã tồn tại ở server {CNconlai} và đã đủ 8 kí tự nên không thể tự đồng chèn");
                        Program.myReader.Close();
                        cbbChiNhanh_PN.Focus();
                        return;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }






                com = $"exec dbo.sp_addpn '{txbMaPN_PN.Text.Trim()}', '{dtpNgay_PN.Text}', '{txbMasoDDH_PN.Text.Trim()}', '{txbMaNV_PN.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(com);
                    Program.myReader.Read();
                    if (Program.myReader != null)
                    {
                        MaPNNEW = txbMaPN_PN.Text.Trim();
                        MessageBox.Show($"Tạo phiếu nhập thành công ", " Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.myReader.Close();
                        btnThemCTPN_PN.Enabled = btnChotPN.Enabled = true;
                        btnSave_PN.Enabled = btnThem_PN.Enabled = false;
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.constr;
                        // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
                        this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                        gcCTDDH.Enabled = gcCTPN.Enabled = gcDH.Enabled = gcPN.Enabled = groupBox2.Enabled= true;
                    }
                    else
                    {
                        MessageBox.Show("Tạo phiếu nhập thất bại, hãy kiểm tra lại thông tin", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.myReader.Close();
                    }
                }
            else if(loaithem=="CTPN")
            {
                int a = 0;
                a = soluong_CTPN;
                if(txbSoLuong_PN.Text.Trim()=="")
                {
                    MessageBox.Show("Số lượng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaPN_PN.Focus();
                    return;
                }
                else if (!int.TryParse(txbSoLuong_PN.Text, out soluong_CTPN))
                {
                    MessageBox.Show("Số lượng không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuong_PN.Focus();
                    return;
                }
                else if (int.Parse(txbSoLuong_PN.Text.Trim())<=0)
                {
                    MessageBox.Show("Số lượng không được nhỏ hơn hoặc bằng 0 ", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuong_PN.Focus();
                    return;
                }
                else if (int.Parse(txbSoLuong_PN.Text.Trim())> a)
                {
                    MessageBox.Show("Số lượng không được lớn hơn số lượng ban đầu", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuong_PN.Focus();
                    return;
                }
                if (txbDonGia_PN.Text.Trim() == "")
                {
                    MessageBox.Show("Đơn giá không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDonGia_PN.Focus();
                    return;
                }
                else if (!int.TryParse(txbDonGia_PN.Text, out soluong_CTPN))
                {
                    MessageBox.Show("Đơn giá không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDonGia_PN.Focus();
                    return;
                }
                else if (int.Parse(txbDonGia_PN.Text.Trim()) < 0)
                {
                    MessageBox.Show("Đơn giá không được nhỏ hơn 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDonGia_PN.Focus();
                    return;
                }
                com = $"exec dbo.sp_addctpn '{txbMaPN_PN.Text.Trim()}', '{txbMaVT_PN.Text.Trim()}', '{txbSoLuong_PN.Text.Trim()}', '{txbDonGia_PN.Text.Trim()}'";
                //MessageBox.Show(command);
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                if (Program.myReader != null)
                {
                    MessageBox.Show($"Tạo CTPN thành công ", " Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    this.cTPNTableAdapter.Connection.ConnectionString = Program.constr;
                    // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
                    this.cTPNTableAdapter.Fill(this.DS.CTPN);
                     btnThemCTPN_PN.Enabled = btnXoaCTPN_PN.Enabled = btnSuaCTPN_PN.Enabled = btnChotPN.Enabled = true;
                    gcCTDDH.Enabled = gcCTPN.Enabled = gcDH.Enabled = gcPN.Enabled = true;
                    btnSave_PN.Enabled = false;
                    soluong_CTPN = 0;
                }
                else
                {
                    MessageBox.Show("Tạo CTPN thất bại, hãy kiểm tra lại thông tin", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.myReader.Close();
                }
            }
        }

        private void cbbChiNhanh_PN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanh_PN.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                // Gán chi nhánh mới
                Program.servername = cbbChiNhanh_PN.SelectedValue.ToString();
                // Dùng HTKN để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên combobox
                if (cbbChiNhanh_PN.SelectedIndex != Program.mChinhanhDN)
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
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.constr;
                    this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                    this.datHangTableAdapter.Connection.ConnectionString = Program.constr;
                    // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
                    this.datHangTableAdapter.Fill(this.DS.DatHang);
                }
            }
            catch (NullReferenceException ex)
            {
                return;
            }
        }

        private void btnSuaCTPN_PN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPN.Count == 0)
            {
                MessageBox.Show("Chưa có chi tiết phiếu nhập nào cả", "", MessageBoxButtons.OK);
                return;
            }
            if ((MaPNNEW == ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAPN"].ToString().Trim()))
            {
                txbMasoDDH_PN.Text = "";
                txbMasoDDH_PN.Text = ((DataRowView)bdsCTDDH[bdsCTDDH.Position])["MasoDDH"].ToString().Trim();
                txbMasoDDH_PN.Enabled = false;
                groupBox1.Enabled = false;
                txbMaVT_PN.Text = ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAVT"].ToString().Trim();
                txbMaVT_PN.Enabled = false;
                //
                txbMaNV_PN.Text = Program.username;
                txbSoLuong_PN.Text = ((DataRowView)bdsCTPN[bdsCTPN.Position])["SOLUONG"].ToString().Trim();
                txbDonGia_PN.Text = ((DataRowView)bdsCTPN[bdsCTPN.Position])["DONGIA"].ToString().Trim();
                txbMaPN_PN.Text = ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAPN"].ToString().Trim();
                txbMasoDDH_PN.Text = ((DataRowView)bdsDH[bdsDH.Position])["MasoDDH"].ToString().Trim();
                btnReloadCTDDH_PN.Enabled = true;
                btnSave_PN.Enabled = btnThemCTPN_PN.Enabled = btnThem_PN.Enabled = btnXoaCTPN_PN.Enabled = btnSuaCTPN_PN.Enabled = btnChotPN.Enabled = false;
                gcCTDDH.Enabled = gcCTPN.Enabled = gcDH.Enabled = gcPN.Enabled = false;
                soluong_CTPN = int.Parse(((DataRowView)bdsCTDDH[bdsCTDDH.Position])["SOLUONG"].ToString().Trim());
                soluongcu_CTPN= int.Parse(((DataRowView)bdsCTPN[bdsCTPN.Position])["SOLUONG"].ToString().Trim());
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể chỉnh sửa phiếu nhập vừa thêm", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnReloadCTDDH_PN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int a = 0;
            b = soluongcu_CTPN;
            a = soluong_CTPN;
            if (txbSoLuong_PN.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaPN_PN.Focus();
                return;
            }
            else if (!int.TryParse(txbSoLuong_PN.Text, out soluong_CTPN))
            {
                MessageBox.Show("Số lượng không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoLuong_PN.Focus();
                return;
            }
            else if (int.Parse(txbSoLuong_PN.Text.Trim()) <= 0)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn hoặc bằng 0 ", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoLuong_PN.Focus();
                return;
            }
            else if (int.Parse(txbSoLuong_PN.Text.Trim()) > a)
            {
                MessageBox.Show("Số lượng không được lớn hơn số lượng đặt", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoLuong_PN.Focus();
                return;
            }
            if (txbDonGia_PN.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDonGia_PN.Focus();
                return;
            }
            else if (!int.TryParse(txbDonGia_PN.Text, out soluong_CTPN))
            {
                MessageBox.Show("Đơn giá không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDonGia_PN.Focus();
                return;
            }
            else if (int.Parse(txbDonGia_PN.Text.Trim()) < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDonGia_PN.Focus();
                return;
            }
            try
            {
                string com = $"exec dbo.sp_suaCTPN '{txbMaVT_PN.Text.Trim()}', '{b}', '{txbSoLuong_PN.Text.Trim()}'";
                //MessageBox.Show(command);
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                if (Program.myReader != null)
                {
                    //MessageBox.Show("123");
                    Program.myReader.Close();
                    soluong_CTPN = 0;
                    soluongcu_CTPN = 0;
                }
                else
                {
                    Program.myReader.Close();
                }

                bdsCTPN.RemoveFilter();
                bdsPhieuNhap.RemoveFilter();
                btnThemCTPN_PN.Enabled =btnXoaCTPN_PN.Enabled=btnSuaCTPN_PN.Enabled= btnChotPN.Enabled = true;
                gcCTDDH.Enabled = gcCTPN.Enabled = gcDH.Enabled = gcPN.Enabled = true;
                soluong_CTPN = 0;
                btnReloadCTDDH_PN.Enabled = false;
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaCTPN_PN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnChotPN.Enabled = false;
            string slcu=txbSoLuong_PN.Text = ((DataRowView)bdsCTPN[bdsCTPN.Position])["SOLUONG"].ToString().Trim();
            string mvt = ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAVT"].ToString().Trim();
            if (bdsCTPN.Count == 0)
            {
                btnXoaCTPN_PN.Enabled = false;
                return;
            }
            if ((MaPNNEW == ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAPN"].ToString().Trim()))
            {
                string delCTPN = "";
                b = 0;
                if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết phiếu nhập này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        delCTPN = ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAPN"].ToString();
                        bdsCTPN.RemoveCurrent();
                        //Sửa lại số lượng vật tư
                        string com = $"exec dbo.sp_suaCTPN '{mvt.Trim()}', '{slcu.Trim()}',{b}";
                        MessageBox.Show(com);
                        //MessageBox.Show(command);
                        Program.myReader = Program.ExecSqlDataReader(com);
                        Program.myReader.Read();
                        if (Program.myReader != null)
                        {
                            Program.myReader.Close();
                            soluong_CTPN = 0;
                            soluongcu_CTPN = 0;
                        }
                        else
                        {
                            Program.myReader.Close();
                        }
                        //
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.constr;
                        this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);

                        this.cTPNTableAdapter.Connection.ConnectionString = Program.constr;
                        this.cTPNTableAdapter.Update(this.DS.CTPN);
                        MessageBox.Show("Xóa chi tiết phiếu nhập thành công !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnChotPN.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa chi tiết phiếu nhập không thành công !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cTDDHTableAdapter.Fill(this.DS.CTDDH);
                        bdsCTPN.Position = bdsCTPN.Find("MAPN", delCTPN);
                        btnChotPN.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chỉ có thể xóa chi tiết phiếu nhập vừa thêm", "", MessageBoxButtons.OK);
                    btnChotPN.Enabled = true;
                    return;
                }
            }
        }

        private void btnExit_PN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnChotPN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xác nhận Phiếu Nhập này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if ((MaPNNEW.Trim() == ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position])["MAPN"].ToString().Trim()))
                {
                    if (bdsCTPN.Count == 0)
                    {
                        try
                        {
                            bdsPhieuNhap.RemoveCurrent();
                            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.constr;
                            this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);
                            MessageBox.Show("Đã xóa PN vì không có CTPN nào !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                MaPNNEW = "";
                btnThem_PN.Enabled = true;
                frmPhieuNhap_Load(sender, e);
                btnExit_PN.Enabled = true;
            }
        }
    }
}
