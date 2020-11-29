namespace QLVT_form
{
    partial class frmBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnInDSNV_BC = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat_BC = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSVT_BC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDDHmotPN_BC = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangkeCTSLvaTG = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoatDongNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnTongHopNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbChiNhanh_BC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInDSNV_BC,
            this.btnThoat_BC,
            this.btnInDSVT_BC,
            this.btnDDHmotPN_BC,
            this.barButtonItem1,
            this.btnBangkeCTSLvaTG,
            this.btnHoatDongNV,
            this.btnTongHopNhapXuat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSNV_BC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat_BC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSVT_BC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDDHmotPN_BC, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBangkeCTSLvaTG, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoatDongNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTongHopNhapXuat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnInDSNV_BC
            // 
            this.btnInDSNV_BC.Caption = "In Danh Sách Nhân Viên";
            this.btnInDSNV_BC.Id = 0;
            this.btnInDSNV_BC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDSNV_BC.ImageOptions.SvgImage")));
            this.btnInDSNV_BC.Name = "btnInDSNV_BC";
            this.btnInDSNV_BC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSNV_BC_ItemClick);
            // 
            // btnThoat_BC
            // 
            this.btnThoat_BC.Caption = "Thoát";
            this.btnThoat_BC.Id = 1;
            this.btnThoat_BC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat_BC.ImageOptions.SvgImage")));
            this.btnThoat_BC.Name = "btnThoat_BC";
            this.btnThoat_BC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_BC_ItemClick);
            // 
            // btnInDSVT_BC
            // 
            this.btnInDSVT_BC.Caption = "In Danh Sách Vật Tư";
            this.btnInDSVT_BC.Id = 2;
            this.btnInDSVT_BC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInDSVT_BC.ImageOptions.SvgImage")));
            this.btnInDSVT_BC.Name = "btnInDSVT_BC";
            this.btnInDSVT_BC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSVT_BC_ItemClick);
            // 
            // btnDDHmotPN_BC
            // 
            this.btnDDHmotPN_BC.Caption = "In DDH chua có Phiếu Nhập";
            this.btnDDHmotPN_BC.Id = 3;
            this.btnDDHmotPN_BC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDDHmotPN_BC.ImageOptions.SvgImage")));
            this.btnDDHmotPN_BC.Name = "btnDDHmotPN_BC";
            this.btnDDHmotPN_BC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDDHmotPN_BC_ItemClick);
            // 
            // btnBangkeCTSLvaTG
            // 
            this.btnBangkeCTSLvaTG.Caption = "Bảng Kê CTSL và Trị Giá";
            this.btnBangkeCTSLvaTG.Id = 5;
            this.btnBangkeCTSLvaTG.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangkeCTSLvaTG.ImageOptions.SvgImage")));
            this.btnBangkeCTSLvaTG.Name = "btnBangkeCTSLvaTG";
            this.btnBangkeCTSLvaTG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBangkeCTSLvaTG_ItemClick);
            // 
            // btnHoatDongNV
            // 
            this.btnHoatDongNV.Caption = "Hoạt Động Nhân Viên";
            this.btnHoatDongNV.Id = 6;
            this.btnHoatDongNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoatDongNV.ImageOptions.SvgImage")));
            this.btnHoatDongNV.Name = "btnHoatDongNV";
            this.btnHoatDongNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoatDongNV_ItemClick);
            // 
            // btnTongHopNhapXuat
            // 
            this.btnTongHopNhapXuat.Caption = "Tổng Hợp Nhập Xuất";
            this.btnTongHopNhapXuat.Id = 7;
            this.btnTongHopNhapXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTongHopNhapXuat.ImageOptions.SvgImage")));
            this.btnTongHopNhapXuat.Name = "btnTongHopNhapXuat";
            this.btnTongHopNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTongHopNhapXuat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1445, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 695);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1445, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 644);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1445, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 644);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbChiNhanh_BC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 54);
            this.panel1.TabIndex = 4;
            // 
            // cbbChiNhanh_BC
            // 
            this.cbbChiNhanh_BC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh_BC.FormattingEnabled = true;
            this.cbbChiNhanh_BC.Location = new System.Drawing.Point(361, 17);
            this.cbbChiNhanh_BC.Name = "cbbChiNhanh_BC";
            this.cbbChiNhanh_BC.Size = new System.Drawing.Size(708, 24);
            this.cbbChiNhanh_BC.TabIndex = 1;
            this.cbbChiNhanh_BC.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_BC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI NHÁNH";
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnInDSNV_BC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.BarButtonItem btnThoat_BC;
        public System.Windows.Forms.ComboBox cbbChiNhanh_BC;
        private DevExpress.XtraBars.BarButtonItem btnInDSVT_BC;
        private DevExpress.XtraBars.BarButtonItem btnDDHmotPN_BC;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnBangkeCTSLvaTG;
        private DevExpress.XtraBars.BarButtonItem btnHoatDongNV;
        private DevExpress.XtraBars.BarButtonItem btnTongHopNhapXuat;
    }
}