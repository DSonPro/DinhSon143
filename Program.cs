using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace QLVT_form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String constr;
        public static SqlDataReader myReader;
        public static DataTable myTable;

        public static String servername="";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLVT_DH";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;
        public static int mChinhanhDN = 0;

        public static int MaNV_old = -1;
        public static string MaCN_cu = "";

        public static BindingSource bds_dspm = new BindingSource();
        // giữ bdsPM khi đăng nhập
        public static frmMain frmChinh;
        public static Form_login frmDN;
        public static frmNHANVIEN frmNV;
        public static frmBaoCao frmBC;
        public static int KetNoi()
        {
            if(Program.conn!=null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.constr = "Data Source=" + Program.servername + ";Initial Catalog= " +
                                Program.database + ";User ID= " +
                                Program.mlogin + ";password= " +
                                Program.password;
               // MessageBox.Show("" + Program.constr);
                Program.conn.ConnectionString = Program.constr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception e)
            {
              //  MessageBox.Show(""+ Program.mlogin);
             //   MessageBox.Show("" + Program.password);
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \n Bạn xem lại Username và Password. \n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            //ưu: truy vấn nhanh
            //khuyết: chỉ được xem, không cho thêm xóa sửa , nếu như có nhiều dòng thì chỉ cho phép đi xuống ko cho phép đi ngc lại
            //-> dùng trong ngữ cảnh lấy ra để sử dụng hoặc in báo cáo
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn); // gọi 1 sp hoặc chạy 1 cậu lệnh truy vấn
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;   // thời gian chạy sẽ là 10p thời gian mặc định là 3p phogn2 trường hợp có quá nhiều tập tin
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd, string connstr)
        {
            //sử dụng: khi ta tải dữ liệu về xong và ta muốn sửa trên dataTable đó và cập nhật về cơ sở dữ liệu lại
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        } 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             frmChinh = new frmMain();
            frmDN = new Form_login();
            Application.Run(frmChinh);
           // Application.Run(frmDN);
        }
    }
}
