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
    public partial class frmVatTu : Form
    {
        public int vitri;
        public int parsedValue;
        public frmVatTu()
        {
            vitri=parsedValue = 0;
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
              DS.EnforceConstraints = false;

            this.vattuTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.cTDDHTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.cTPNTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.DS.CTPN);

            this.cTPXTableAdapter.Connection.ConnectionString = Program.constr;
            // TODO: This line of code loads data into the 'DS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.DS.CTPX);
            if (Program.mGroup == "CONGTY")
            {
                groupBox1.Enabled = false;
                btnThemvt.Enabled = btnXoavt.Enabled = btnSavevt.Enabled = btnReloadvt.Enabled = btnUndovt.Enabled = false;
            }
            else
            {
                btnSavevt.Enabled = btnUndovt.Enabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThoatvt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        // update dữ liệu vào database
        private void updateTableAdapter()
        {
            bdsVatTu.EndEdit();
            bdsVatTu.ResetCurrentItem();
            this.vattuTableAdapter.Connection.ConnectionString = Program.constr;
            this.vattuTableAdapter.Update(this.DS.Vattu);
        }
        private void btnThemvt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             
        }

        private void btnSavevt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txbMaVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaVT.Focus();
                return;
            }
            else if(txbMaVT.Text.Trim().Length>4)
            {
                MessageBox.Show("Mã vật tư quá dài <5", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaVT.Focus();
                return;
            }
            if (txbTenVT.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenVT.Focus();
                return;
            }
            else if (txbTenVT.Text.Trim().Length > 30)
            {
                MessageBox.Show("Tên vật tư quá dài <31", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenVT.Focus();
                return;
            }
            /*
            else
            {
                string command1 = $"select MAVT from VATTU where TENVT = N'{txbTenVT.Text.Trim().ToString()}'";
                Program.myReader = Program.ExecSqlDataReader(command1);
                Program.myReader.Read();
                try
                {
                    if (Program.myReader.HasRows == true)
                    {
                        MessageBox.Show("Tên vật tư đã tồn tại ", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Program.myReader.Close();
                        return;
                    }
                    Program.myReader.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }*/
            if (txbDVTinh.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDVTinh.Focus();
                return;
            }
            else if (txbDVTinh.Text.Trim().Length > 15)
            {
                MessageBox.Show("Đơn vị tính quá dài <16", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbDVTinh.Focus();
                return;
            }
            if (txbSoluongTon.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng tồn không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoluongTon.Focus();
                return;
            }
            else if (!int.TryParse(txbSoluongTon.Text, out parsedValue))
            {
                MessageBox.Show("Số lượng tồn không phải là số", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoluongTon.Focus();
                return;
            }
            else if(int.Parse(txbSoluongTon.Text.Trim())<0)
            {
                MessageBox.Show("Số lượng tồn không được nhỏ hơn 0", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbSoluongTon.Focus();
                return;
            }
             try
            {
                string command = $"exec dbo.sp_KiemtraVT_TonTai '{txbMaVT.Text.Trim()}',N'{txbTenVT.Text.Trim()}' ";
                Program.myReader = Program.ExecSqlDataReader(command);
                Program.myReader.Read();
                try
                {
                    if (Program.myReader.HasRows == true)
                    {
                        MessageBox.Show("Mã vật tư đã tồn tại hoặc tên vật tư đã tồn tại", "Lỗi thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Thêm vật tư thành công");
                Program.myReader.Close();
                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                gcvVatTu.Enabled = true;
                btnSavevt.Enabled = btnUndovt.Enabled = false;
                btnThemvt.Enabled = btnXoavt.Enabled = btnReloadvt.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnThemvt_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                vitri = bdsVatTu.Position;
                groupBox1.Enabled = true;
                bdsVatTu.AddNew();
                btnThemvt.Enabled = btnXoavt.Enabled = btnReloadvt.Enabled = false;
                btnSavevt.Enabled = btnUndovt.Enabled = true;
                // Vô hiệu hóa phần xem grid
                gcvVatTu.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoavt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCTPX.Count > 0 || bdsCTPN.Count > 0 || bdsCTDDH.Count > 0)
            {
                MessageBox.Show($"Vật Tư {txbTenVT.Text} đã tạo phiếu nên không thể xóa !!", "Xóa vật tư thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string delMaVT = "";
                if (MessageBox.Show("Bạn có thật sự muốn xóa vật tư này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        delMaVT = ((DataRowView)bdsVatTu[bdsVatTu.Position])["MAVT"].ToString();
                        bdsVatTu.RemoveCurrent();
                        this.vattuTableAdapter.Connection.ConnectionString = Program.constr;
                        this.vattuTableAdapter.Update(this.DS.Vattu);
                        MessageBox.Show("Đã xóa");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa vật tư không thành công !!!", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.vattuTableAdapter.Fill(this.DS.Vattu);
                        bdsVatTu.Position = bdsVatTu.Find("MAVT", delMaVT);
                    }
                }
                btnThemvt.Enabled = btnXoavt.Enabled = btnReloadvt.Enabled = true;
            }
            if (bdsVatTu.Count == 0)
            {
                btnXoavt.Enabled = false;
            }
        }

        private void btnReloadvt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.vattuTableAdapter.Connection.ConnectionString = Program.constr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            if (Program.mGroup == "CONGTY")
            {
                groupBox1.Enabled = false;
                btnThemvt.Enabled = btnXoavt.Enabled = btnSavevt.Enabled = btnReloadvt.Enabled = btnUndovt.Enabled = false;
            }
            else
            {
                btnSavevt.Enabled = btnUndovt.Enabled = false;
            }
        }
    }
}
