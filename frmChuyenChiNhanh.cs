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
    public partial class frmChuyenChiNhanh : Form
    {
        public frmChuyenChiNhanh()
        {
            InitializeComponent();
        }


        private void frmChuyenChiNhanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DHDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DHDataSet.V_DS_PHANMANH);
            txbMaNV_cu.Text = Program.MaNV_old.ToString();
            txbMaNV_cu.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbbMACN_changeCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoatChangeCN_Click(object sender, EventArgs e)
        {
            this.Close();
            //Program.frmNV.btnChangeCN_NV.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnChangeCN_Click(object sender, EventArgs e)
        {
            if(txbMaNV_moi.Text.Trim()=="")
            {
                MessageBox.Show("Mã nhân viên mới chưa được nhập");
                txbMaNV_moi.Focus();
                return;
            }
            else if(int.Parse(txbMaNV_moi.Text.ToString())<0)
            {
                MessageBox.Show("Mã nhân viên mới không được nhỏ hơn không");
                txbMaNV_moi.Focus();
                return;
            }
                string command = "exec dbo.sp_KiemtraMaNV_TonTai " + "'" + txbMaNV_moi.Text.ToString().Trim('.') + "'";
                // MessageBox.Show(command);
                Program.myReader = Program.ExecSqlDataReader(command);
                Program.myReader.Read();
                try
                {
                    if (Program.myReader.HasRows == true)
                    {
                        MessageBox.Show("Mã nhân viên mới đã tồn tại");
                        Program.myReader.Close();
                        return;
                    }
                    Program.myReader.Close();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
             command = $"select TrangThaiXoa from NhanVien where MANV = '{txbMaNV_cu.Text.Trim()}'";
                Program.myReader = Program.ExecSqlDataReader(command);
                Program.myReader.Read();
            int trangthaixoa = Program.myReader.GetInt32(0);
            Program.myReader.Close();
            String maCN = "CN" + (cbbMACN_changeCN.SelectedIndex + 1).ToString();
            if(maCN.Trim()==Program.MaCN_cu)
            {
                MessageBox.Show("Nhân Viên đang ở chi nhánh "+maCN+"không thể chuyển");
                cbbMACN_changeCN.Focus();
                return;
            }
            // MessageBox.Show(""+trangthaixoa);
            if (trangthaixoa==0&& maCN.Trim() != Program.MaCN_cu) // cho chuyển
            {

                command = "";
                 command = $"exec dbo.sp_chuyenchinhanh {txbMaNV_cu.Text}, '{maCN}', {txbMaNV_moi.Text}";
                Program.myReader = Program.ExecSqlDataReader(command);
                Program.myReader.Read();
                        if (Program.myReader != null)
                        {
                            MessageBox.Show("Chuyển chi nhánh thành công", "", MessageBoxButtons.OK);
                        }
                        Program.myReader.Close();
                        this.Close();
            }
            else
            {
                MessageBox.Show("Nhân viên đã được chuyển sang 1 chi nhánh khác trước đó nên không thể chuyển");
                return;
            }
        }

        private void phieuNhapBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbbMACN_changeCN_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
