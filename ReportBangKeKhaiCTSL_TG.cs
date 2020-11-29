using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_form
{
    public partial class ReportBangKeKhaiCTSL_TG : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBangKeKhaiCTSL_TG(char loai, string start, string end)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.constr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = loai;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = start;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = end;
            this.sqlDataSource1.Fill();
        }

    }
}
