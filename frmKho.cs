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
    public partial class frmKho : Form
    {
        public int vitri;
        public string macn;
        public frmKho()
        {
            InitializeComponent();
            vitri = 0;
            macn = "";
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.DS.Kho);

            macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
            cbbChinhanh_kho.DisplayMember = "TENCN";
            cbbChinhanh_kho.ValueMember = "TENSERVER";

            cbbChinhanh_kho.DataSource = Program.bds_dspm;
            cbbChinhanh_kho.SelectedIndex = Program.mChinhanhDN;

            if (Program.mGroup == "CONGTY")
            {
                cbbChinhanh_kho.Enabled = true;
                groupBox1.Enabled = false;
                btnThem_kho.Enabled = btnXoa_kho.Enabled = btnSave_kho.Enabled = btnReload_kho.Enabled = btnUndo_kho.Enabled = false;
            }
            else
            {
                cbbChinhanh_kho.Enabled = false;
                btnSave_kho.Enabled = btnUndo_kho.Enabled = false;
            }
        }

        private void mACNLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENKHOLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENKHOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoat_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbbChinhanh_kho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChinhanh_kho.SelectedValue.ToString() == "System.Data.DataRowView")
                {
                    return;
                }
                // Gán chi nhánh mới
                Program.servername = cbbChinhanh_kho.SelectedValue.ToString();
                // Dùng HTKN để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên combobox
                if (cbbChinhanh_kho.SelectedIndex != Program.mChinhanh)
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
                    this.khoTableAdapter.Connection.ConnectionString = Program.constr;
                    this.khoTableAdapter.Fill(this.DS.Kho);
                    // Lấy mã chi nhánh hiện tại
                    macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
                    //MessageBox.Show(macn);
                }
            }
            catch (NullReferenceException ex)
            {
                return;
            }
        }

        private void btnThem_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            groupBox1.Enabled = true;
            bdsKho.AddNew();
            btnThem_kho.Enabled  = btnXoa_kho.Enabled = btnReload_kho.Enabled = false;
            btnSave_kho.Enabled = btnUndo_kho.Enabled = true;
            // Vô hiệu hóa phần xem grid
            gcKho.Enabled = false;
            // Cho phép nhập mới mã nhân viên và mà chi nhánh
            txbMACN_kho.Text = macn;
        }
        // update dữ liệu vào database
        private void updateTableAdapter()
        {
            bdsKho.EndEdit();
            bdsKho.ResetCurrentItem();
            this.khoTableAdapter.Connection.ConnectionString = Program.constr;
            this.khoTableAdapter.Update(this.DS.Kho);
        }
        private void btnSave_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbMaKho_kho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaKho_kho.Focus();
                return;
            }
            else if(txbMaKho_kho.Text.Trim().Length>4)
            {
                MessageBox.Show("Mã kho không được hơn 4 kí tự", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaKho_kho.Focus();
                return;
            }
            if (txbTenkho_kho.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenkho_kho.Focus();
                return;
            }
            else if(txbTenkho_kho.Text.Trim().Length>30)
            {
                MessageBox.Show("Tên kho không được dài hơn 30 kí tự", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenkho_kho.Focus();
                return;
            }
            if (txbDiachi_kho.Text.Trim() == "")
            {
                MessageBox.Show("Đại chỉ kho không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDiachi_kho.Focus();
                return;
            }
            if (txbMACN_kho.Text.Trim() == "")
            {
                MessageBox.Show("Mã chi nhánh không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMACN_kho.Text = macn;
                txbMACN_kho.Focus();
                return;
            }
            else if (txbMACN_kho.Text.Trim() != macn.Trim())
            {
                MessageBox.Show($"Mã chi nhánh không chính xác đối với chi nhánh hiện tại, bạn nên sửa lại thành {macn}", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMACN_kho.Text = macn;
                txbMACN_kho.Focus();
                return;
            }
                try
                {
                    string command = $"exec dbo.sp_KiemtraMaKho_TonTai  '{txbMaKho_kho.Text.Trim()}'";
                    // MessageBox.Show(command);
                    Program.myReader = Program.ExecSqlDataReader(command);
                        Program.myReader.Read();
                        try
                        {
                            if (Program.myReader.HasRows == true)
                            {
                                MessageBox.Show("Mã kho đã tồn tại");
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
                        MessageBox.Show("Thêm kho thành công");
                        Program.myReader.Close();
                        // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                        gcKho.Enabled = true;
                    btnThem_kho.Enabled = btnXoa_kho.Enabled = btnReload_kho.Enabled = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        private void btnXoa_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                string delMaNV = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa kho này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        delMaNV = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
                        bdsKho.RemoveCurrent();
                        this.khoTableAdapter.Connection.ConnectionString = Program.constr;
                        this.khoTableAdapter.Update(this.DS.Kho);
                    MessageBox.Show("Xóa kho thành công !!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa kho không thành công !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.khoTableAdapter.Fill(this.DS.Kho);
                        bdsKho.Position = bdsKho.Find("MAKHO", delMaNV);
                    }
                }
                Program.myReader.Close();
                if (bdsKho.Count == 0)
                {
                    btnXoa_kho.Enabled = false;
                }
        }
        private void refreshTableAdapter()
        {
            this.khoTableAdapter.Connection.ConnectionString = Program.constr;
            this.khoTableAdapter.Fill(this.DS.Kho);
            //MessageBox.Show(Program.mGroup);
            if (Program.mGroup == "CONGTY")
            {
                cbbChinhanh_kho.Enabled = true;
                groupBox1.Enabled = false;
                btnThem_kho.Enabled = btnXoa_kho.Enabled = btnSave_kho.Enabled = btnReload_kho.Enabled = btnUndo_kho.Enabled = false;
            }
            else
            {
                cbbChinhanh_kho.Enabled = false;
                btnSave_kho.Enabled = btnUndo_kho.Enabled = false;
            }
        }
        private void btnReload_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // Đưa BindingSource của nhân viên về mặc định

                bdsKho.RemoveFilter();
                refreshTableAdapter();
                gcKho.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
