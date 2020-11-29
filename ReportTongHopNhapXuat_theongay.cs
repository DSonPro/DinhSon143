using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_form
{
    public partial class ReportTongHopNhapXuat_theongay : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportTongHopNhapXuat_theongay(DateTime start, DateTime end)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.constr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = start;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = end;
            this.sqlDataSource1.Fill();
        }

    }
}
