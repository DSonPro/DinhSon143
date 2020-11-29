using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_form
{
    public partial class ReportHDcuaNV : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHDcuaNV(int manv, char loai, string begin, string end)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.constr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = manv;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = loai;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = begin;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = end;
            this.sqlDataSource1.Fill();
        }

    }
}
