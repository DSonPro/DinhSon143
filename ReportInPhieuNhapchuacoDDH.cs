using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT_form
{
    public partial class ReportInPhieuNhapchuacoDDH : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportInPhieuNhapchuacoDDH()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.constr;
            this.sqlDataSource1.Fill();
        }

    }
}
