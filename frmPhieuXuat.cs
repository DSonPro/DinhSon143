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
    public partial class frmPhieuXuat : Form
    {
        public string loaithem;
        public string MaPXNEW;
        public int parsedValue,soluongCTPX;
        public frmPhieuXuat()
        {
            InitializeComponent();
            loaithem = MaPXNEW = "";
            parsedValue =soluongCTPX = 0;
        }

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.DS.CTPX);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

            cbbChiNhanh_PX.DisplayMember = "TENCN";
            cbbChiNhanh_PX.ValueMember = "TENSERVER";
            cbbChiNhanh_PX.DataSource = Program.bds_dspm;
            cbbChiNhanh_PX.SelectedIndex = Program.mChinhanhDN;

            btnSave_PX.Enabled = btnReload_PX.Enabled = btnXoaCTPX_PX.Enabled = btnSuaCTPX_PX.Enabled = btnThemCTPX.Enabled = btnChotPhieu_PX.Enabled = false;
            if (Program.mGroup == "CONGTY")
            {
                cbbChiNhanh_PX.Enabled = true;
                groupBox1.Enabled = groupBox2.Enabled = false;
                btnSave_PX.Enabled = btnThemCTPX.Enabled = btnThemPX.Enabled = false;
            }
            else
            {
                cbbChiNhanh_PX.Enabled = false;
            }
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPX.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnThemPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txbMaPX_PX.Text =txbHTKhachang_PX.Text= "";
            txbMaNV_PX.Text = Program.username;
            btnSave_PX.Enabled = true;
            loaithem = "PX";
            dtpNgay_PX.Value = DateTime.Today;
            dtpNgay_PX.Enabled = txbMaNV_PX.Enabled= btnChotPhieu_PX.Enabled =btnThemPX.Enabled=false;
            gcCTPX.Enabled = gcPX.Enabled = gcVT.Enabled =groupBox2.Enabled= false;
        }

        private void btnSave_PX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string com = "";
            if(loaithem=="PX")
            {
                if (txbMaPX_PX.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phiếu xuất không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaPX_PX.Focus();
                    return;
                }
                else if (txbMaPX_PX.Text.Trim().Length > 8)
                {

                    MessageBox.Show("Mã phiếu xuất không được nhiều hơn 8 kí tự", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaPX_PX.Focus();
                    return;
                }
                else
                {
                    com = $"select MAPX from PhieuXuat where MAPX = '{txbMaPX_PX.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(com);
                    Program.myReader.Read();
                    try
                    {
                        if (Program.myReader.HasRows == true)
                        {
                            MessageBox.Show("Mã phiếu xuất đã tồn tại ", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Program.myReader.Close();
                            txbMaPX_PX.Focus();
                            return;
                        }
                        Program.myReader.Close();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                // kiểm tra mã PX đã tồn tại ở chi nhánh còn lại hay chưa
                string CNconlai = "";
                if (cbbChiNhanh_PX.SelectedIndex == 0)
                {
                    CNconlai = "CN2";
                }
                else
                {
                    CNconlai = "CN1";
                }
                string laycn = (cbbChiNhanh_PX.SelectedIndex + 1).ToString();
                com = $"exec dbo.sp_MPX_kiemtra '{txbMaPX_PX.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                try
                {
                    if (Program.myReader.HasRows == true && txbMaPX_PX.Text.Trim().Length < 8)
                    {
                        if (MessageBox.Show($"Mã PX đã tồn tại ở server {CNconlai}. Bạn có muốn thêm PX này ko ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Program.myReader.Close();
                            txbMaPX_PX.Text += laycn;
                        }
                        else
                        {
                            Program.myReader.Close();
                            cbbChiNhanh_PX.Focus();
                            return;
                        }
                    }
                    else if (Program.myReader.HasRows == true && cbbChiNhanh_PX.Text.Trim().Length > 8)
                    {
                        MessageBox.Show($"Mã PX đã tồn tại ở server {CNconlai} và đã đủ 8 kí tự nên không thể tự đồng chèn");
                        Program.myReader.Close();
                        cbbChiNhanh_PX.Focus();
                        return;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }









                com = $"exec dbo.sp_addpx '{txbMaPX_PX.Text.Trim()}', '{dtpNgay_PX.Text}', '{txbHTKhachang_PX.Text.Trim()}', '{txbMaNV_PX.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                if (Program.myReader != null)
                {
                    MaPXNEW = txbMaPX_PX.Text.Trim();
                    MessageBox.Show($"Tạo phiếu xuất thành công ", " Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    btnThemCTPX.Enabled = btnChotPhieu_PX.Enabled =groupBox2.Enabled= true;
                    btnSave_PX.Enabled = btnThemPX.Enabled =btnExit_PX.Enabled= false;
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.constr;
                    // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
                    this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                    gcCTPX.Enabled = gcPX.Enabled = gcVT.Enabled  = true;
                }
                else
                {
                    MessageBox.Show("Tạo phiếu xuất thất bại, hãy kiểm tra lại thông tin", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.myReader.Close();
                }
            }
            else if(loaithem=="CTPX")
            {
                if (txbMaVT_PX.Text.Trim() == "")
                {
                    MessageBox.Show("Mã vật tư không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaVT_PX.Focus();
                    return;
                }
                else
                {
                    com = $"select * from CTPX where MAVT = '{txbMaVT_PX.Text.Trim()}' AND MAPX = '{MaPXNEW}'";
                    Program.myReader = Program.ExecSqlDataReader(com);
                    Program.myReader.Read();
                    if (Program.myReader.HasRows == true)
                    {
                            MessageBox.Show("Đã có chi tiết phiếu xuất của vật tư này", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Program.myReader.Close();
                        btnThemCTPX.Enabled = btnSuaCTPX_PX.Enabled = btnXoaCTPX_PX.Enabled = btnChotPhieu_PX.Enabled = true;
                        gcCTPX.Enabled = gcPX.Enabled = txbMaPX_PX.Enabled = groupBox1.Enabled = txbMaVT_PX.Enabled = true;
                        btnSave_PX.Enabled = false;
                        return;
                    }
                    Program.myReader.Close();
                }
                //số lượng
                if (txbSoLuong_PX.Text.Trim() == "")
                {
                    MessageBox.Show("Số lượng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuong_PX.Focus();
                    return;
                }
                else if (!int.TryParse(txbSoLuong_PX.Text, out parsedValue))
                {
                    MessageBox.Show("Số lượng không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuong_PX.Focus();
                    return;
                }
                else if (int.Parse(txbSoLuong_PX.Text.Trim()) < 0)
                {
                    MessageBox.Show("Số lượng không được nhỏ hơn 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuong_PX.Focus();
                    return;
                }
                else
                {
                    com = $"select SOLUONGTON from VATTU where MAVT = '{txbMaVT_PX.Text.Trim()}'";
                    Program.myReader = Program.ExecSqlDataReader(com);
                    Program.myReader.Read();
                    int soluongton = 0;
                    soluongton = Program.myReader.GetInt32(0);
                    if(int.Parse(txbSoLuong_PX.Text.Trim()) > soluongton)
                    {
                        MessageBox.Show("Số lượng không được lớn hơn số lượng tồn", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbSoLuong_PX.Focus();
                        Program.myReader.Close();
                        return;
                    }
                    Program.myReader.Close();

                }
                // đơn giá
                if (txbDonGia_PX.Text.Trim() == "")
                {
                    MessageBox.Show("Đơn giá không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDonGia_PX.Focus();
                    return;
                }
                else if (!int.TryParse(txbDonGia_PX.Text, out parsedValue))
                {
                    MessageBox.Show("Đơn giá không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDonGia_PX.Focus();
                    return;
                }
                else if (int.Parse(txbDonGia_PX.Text.Trim()) <= 0)
                {
                    MessageBox.Show("Đơn giá không được nhỏ hơn hoặc bằng 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbDonGia_PX.Focus();
                    return;
                }
                com = $"exec dbo.sp_addctpx '{txbMaPX_PX.Text.Trim()}', '{txbMaVT_PX.Text.Trim()}', '{txbSoLuong_PX.Text.Trim()}', '{txbDonGia_PX.Text.Trim()}'";
                //MessageBox.Show(command);
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                if (Program.myReader != null)
                {
                    MessageBox.Show($"Tạo chi tiết phiếu xuất thành công ", " Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.myReader.Close();
                    btnThemCTPX.Enabled = btnSuaCTPX_PX.Enabled = btnXoaCTPX_PX.Enabled = btnChotPhieu_PX.Enabled = true;
                    gcCTPX.Enabled = gcPX.Enabled = txbMaPX_PX.Enabled = groupBox1.Enabled = txbMaVT_PX.Enabled = true;
                    btnSave_PX.Enabled = false;
                    this.cTPXTableAdapter.Connection.ConnectionString = Program.constr;
                    // TODO: This line of code loads data into the 'DS.CTPX' table. You can move, or remove it, as needed.
                    this.cTPXTableAdapter.Fill(this.DS.CTPX);

                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.constr;
                    // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
                    this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);

                    this.vattuTableAdapter.Connection.ConnectionString = Program.constr;
                    // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
                    this.vattuTableAdapter.Fill(this.DS.Vattu);
                }
                else
                {
                    MessageBox.Show("Tạo chi tiết phiếu xuất thất bại, hãy kiểm tra lại thông tin", "Đăng ký thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.myReader.Close();
                }
            }
        }

        private void btnThemCTPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((MaPXNEW.Trim() == ((DataRowView)bdsPX[bdsPX.Position])["MAPX"].ToString().Trim()))
            {
                txbMaVT_PX.Text = ((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString().Trim();
                txbMaPX_PX.Text = ((DataRowView)bdsPX[bdsPX.Position])["MAPX"].ToString().Trim();
                txbMaNV_PX.Text = Program.username;
                loaithem = "CTPX";
                txbMaPX_PX.Enabled = groupBox1.Enabled = txbMaVT_PX.Enabled = txbMaVT_PX.Enabled = false;
                btnSave_PX.Enabled = true;
                btnThemCTPX.Enabled  = btnSuaCTPX_PX.Enabled = btnXoaCTPX_PX.Enabled = btnChotPhieu_PX.Enabled = false;
                gcCTPX.Enabled = gcPX.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể thêm CTPX cho phiếu xuất vừa thêm", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void gcVT_Click(object sender, EventArgs e)
        {
            txbMaVT_PX.Text = ((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString();
        }

        private void btnReload_PX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int a = 0;
            a = soluongCTPX;
            string com = "";
            MessageBox.Show(a.ToString());
            if (txbSoLuong_PX.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoLuong_PX.Focus();
                return;
            }
            else if (!int.TryParse(txbSoLuong_PX.Text, out parsedValue))
            {
                MessageBox.Show("Số lượng không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoLuong_PX.Focus();
                return;
            }
            else if (int.Parse(txbSoLuong_PX.Text.Trim()) < 0)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoLuong_PX.Focus();
                return;
            }
            else
            {
                com = $"select SOLUONGTON from VATTU where MAVT = '{txbMaVT_PX.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                int soluongton = 0;
                soluongton = Program.myReader.GetInt32(0);
                if (int.Parse(txbSoLuong_PX.Text.Trim()) > soluongton)
                {
                    MessageBox.Show("Số lượng không được lớn hơn số lượng tồn", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbSoLuong_PX.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }
            // đơn giá
            if (txbDonGia_PX.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDonGia_PX.Focus();
                return;
            }
            else if (!int.TryParse(txbDonGia_PX.Text, out parsedValue))
            {
                MessageBox.Show("Đơn giá không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDonGia_PX.Focus();
                return;
            }
            else if (int.Parse(txbDonGia_PX.Text.Trim()) < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDonGia_PX.Focus();
                return;
            }
            try
            {
                com = $"exec dbo.sp_suaCTPX '{MaPXNEW}','{txbMaVT_PX.Text.Trim()}', '{a}', '{txbSoLuong_PX.Text.Trim()}'";
                //MessageBox.Show(command);
                Program.myReader = Program.ExecSqlDataReader(com);
                Program.myReader.Read();
                if (Program.myReader != null)
                {
                    Program.myReader.Close();
                }
                else
                {
                    Program.myReader.Close();
                }

                bdsCTPX.RemoveFilter();
                bdsPX.RemoveFilter();
                soluongCTPX = 0;
                btnReload_PX.Enabled = false;
                btnThemCTPX.Enabled = btnXoaCTPX_PX.Enabled = btnSuaCTPX_PX.Enabled = btnChotPhieu_PX.Enabled = groupBox1.Enabled = true;
                gcCTPX.Enabled = gcPX.Enabled = gcVT.Enabled =true;
                this.vattuTableAdapter.Connection.ConnectionString = Program.constr;
                // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
                this.vattuTableAdapter.Fill(this.DS.Vattu);

                this.cTPXTableAdapter.Connection.ConnectionString = Program.constr;
                // TODO: This line of code loads data into the 'DS.CTPX' table. You can move, or remove it, as needed.
                this.cTPXTableAdapter.Fill(this.DS.CTPX);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaCTPX_PX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnChotPhieu_PX.Enabled = false;
            string slcu = txbSoLuong_PX.Text = ((DataRowView)bdsCTPX[bdsCTPX.Position])["SOLUONG"].ToString().Trim();
            string mvt = ((DataRowView)bdsCTPX[bdsCTPX.Position])["MAVT"].ToString().Trim();
            if (bdsCTPX.Count == 0)
            {
                btnXoaCTPX_PX.Enabled = false;
                return;
            }
            if ((MaPXNEW == ((DataRowView)bdsCTPX[bdsCTPX.Position])["MAPX"].ToString().Trim()))
            {
                string delCTPX = "";
                int b = 0;
                if (MessageBox.Show("Bạn có thật sự muốn xóa chi tiết phiếu xuất này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        delCTPX = ((DataRowView)bdsCTPX[bdsCTPX.Position])["MAPX"].ToString();
                        bdsCTPX.RemoveCurrent();
                        //Sửa lại số lượng vật tư
                        string com = $"exec dbo.sp_xoaCTPX '{mvt.Trim()}', '{slcu.Trim()}',{b}";
                        //MessageBox.Show(command);
                        Program.myReader = Program.ExecSqlDataReader(com);
                        Program.myReader.Read();
                            Program.myReader.Close();
                        //
                        this.vattuTableAdapter.Connection.ConnectionString = Program.constr;
                        this.vattuTableAdapter.Update(this.DS.Vattu);

                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.constr;
                        this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);

                        this.cTPXTableAdapter.Connection.ConnectionString = Program.constr;
                        this.cTPXTableAdapter.Update(this.DS.CTPX);

                        MessageBox.Show("Xóa chi tiết phiếu xuất thành công !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnChotPhieu_PX.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa chi tiết phiếu xuất không thành công !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.cTPXTableAdapter.Fill(this.DS.CTPX);
                        bdsCTPX.Position = bdsCTPX.Find("MAPX", delCTPX);
                        btnChotPhieu_PX.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chỉ có thể xóa chi tiết phiếu xuất vừa thêm", "", MessageBoxButtons.OK);
                    btnChotPhieu_PX.Enabled = true;
                    return;
                }
            }
        }

        private void btnExit_PX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnChotPhieu_PX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xác nhận Phiếu Xuất này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if ((MaPXNEW.Trim() == ((DataRowView)bdsPX[bdsPX.Position])["MAPX"].ToString().Trim()))
                {
                    if (bdsCTPX.Count == 0)
                    {
                        try
                        {
                            bdsPX.RemoveCurrent();
                            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.constr;
                            this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);
                            MessageBox.Show("Đã xóa PX vì không có CTPX nào !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                MaPXNEW = "";
                btnThemPX.Enabled = true;
                frmPhieuXuat_Load(sender, e);
                btnExit_PX.Enabled = true;
            }
        }

        private void cbbChiNhanh_PX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaCTPX_PX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPX.Count == 0)
            {
                MessageBox.Show("Chưa có chi tiết phiếu xuất nào cả", "", MessageBoxButtons.OK);
                return;
            }
            if ((MaPXNEW == ((DataRowView)bdsCTPX[bdsCTPX.Position])["MAPX"].ToString().Trim()))
            {
                btnReload_PX.Enabled = true;
                soluongCTPX = int.Parse(((DataRowView)bdsCTPX[bdsCTPX.Position])["SOLUONG"].ToString().Trim());
                btnSave_PX.Enabled = btnThemCTPX.Enabled = btnThemPX.Enabled = btnXoaCTPX_PX.Enabled = btnSuaCTPX_PX.Enabled = btnChotPhieu_PX.Enabled = groupBox1.Enabled =txbMaVT_PX.Enabled= false;
                gcCTPX.Enabled = gcPX.Enabled =gcVT.Enabled= false;
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể chỉnh sửa phiếu nhập vừa thêm", "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
