namespace QLVT_form
{
    partial class frmPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem_PN = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemCTPN_PN = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave_PN = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaCTPN_PN = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCTPN_PN = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadCTDDH_PN = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit_PN = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnThoat_PN = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChiNhanh_PN = new System.Windows.Forms.ComboBox();
            this.DS = new QLVT_form.DS();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT_form.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT_form.DSTableAdapters.TableAdapterManager();
            this.cTPNTableAdapter = new QLVT_form.DSTableAdapters.CTPNTableAdapter();
            this.datHangTableAdapter = new QLVT_form.DSTableAdapters.DatHangTableAdapter();
            this.gcPN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.gcDH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.gcCTPN = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbMaNV_PN = new System.Windows.Forms.TextBox();
            this.txbMasoDDH_PN = new System.Windows.Forms.TextBox();
            this.dtpNgay_PN = new System.Windows.Forms.DateTimePicker();
            this.txbMaPN_PN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbDonGia_PN = new System.Windows.Forms.TextBox();
            this.txbSoLuong_PN = new System.Windows.Forms.TextBox();
            this.txbMaVT_PN = new System.Windows.Forms.TextBox();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT_form.DSTableAdapters.CTDDHTableAdapter();
            this.gcCTDDH = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChotPN = new System.Windows.Forms.Button();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(43, 35);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(50, 17);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "Mã PN";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(43, 73);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(41, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(6, 110);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(80, 17);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Mã số DDH";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(43, 148);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(50, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã NV";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(29, 35);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(49, 17);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã VT";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(6, 69);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(69, 17);
            sOLUONGLabel.TabIndex = 2;
            sOLUONGLabel.Text = "Số Lượng";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(12, 113);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(57, 17);
            dONGIALabel.TabIndex = 4;
            dONGIALabel.Text = "Đơn giá";
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
            this.btnThem_PN,
            this.btnThemCTPN_PN,
            this.btnSave_PN,
            this.btnSuaCTPN_PN,
            this.btnXoaCTPN_PN,
            this.btnThoat_PN,
            this.btnReloadCTDDH_PN,
            this.btnExit_PN});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem_PN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCTPN_PN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave_PN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaCTPN_PN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaCTPN_PN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadCTDDH_PN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit_PN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem_PN
            // 
            this.btnThem_PN.Caption = "Thêm Phiếu Nhập";
            this.btnThem_PN.Id = 0;
            this.btnThem_PN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem_PN.ImageOptions.SvgImage")));
            this.btnThem_PN.Name = "btnThem_PN";
            this.btnThem_PN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_PN_ItemClick);
            // 
            // btnThemCTPN_PN
            // 
            this.btnThemCTPN_PN.Caption = "Thêm CTPN";
            this.btnThemCTPN_PN.Id = 1;
            this.btnThemCTPN_PN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemCTPN_PN.ImageOptions.SvgImage")));
            this.btnThemCTPN_PN.Name = "btnThemCTPN_PN";
            this.btnThemCTPN_PN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCTPN_PN_ItemClick);
            // 
            // btnSave_PN
            // 
            this.btnSave_PN.Caption = "Save";
            this.btnSave_PN.Id = 2;
            this.btnSave_PN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave_PN.ImageOptions.SvgImage")));
            this.btnSave_PN.Name = "btnSave_PN";
            this.btnSave_PN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_PN_ItemClick);
            // 
            // btnSuaCTPN_PN
            // 
            this.btnSuaCTPN_PN.Caption = "Sửa CTPN";
            this.btnSuaCTPN_PN.Id = 3;
            this.btnSuaCTPN_PN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaCTPN_PN.ImageOptions.SvgImage")));
            this.btnSuaCTPN_PN.Name = "btnSuaCTPN_PN";
            this.btnSuaCTPN_PN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaCTPN_PN_ItemClick);
            // 
            // btnXoaCTPN_PN
            // 
            this.btnXoaCTPN_PN.Caption = "Xóa CTPN";
            this.btnXoaCTPN_PN.Id = 4;
            this.btnXoaCTPN_PN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaCTPN_PN.ImageOptions.SvgImage")));
            this.btnXoaCTPN_PN.Name = "btnXoaCTPN_PN";
            this.btnXoaCTPN_PN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaCTPN_PN_ItemClick);
            // 
            // btnReloadCTDDH_PN
            // 
            this.btnReloadCTDDH_PN.Caption = "Reload";
            this.btnReloadCTDDH_PN.Id = 6;
            this.btnReloadCTDDH_PN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReloadCTDDH_PN.ImageOptions.SvgImage")));
            this.btnReloadCTDDH_PN.Name = "btnReloadCTDDH_PN";
            this.btnReloadCTDDH_PN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadCTDDH_PN_ItemClick);
            // 
            // btnExit_PN
            // 
            this.btnExit_PN.Caption = "Thoát";
            this.btnExit_PN.Id = 7;
            this.btnExit_PN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit_PN.ImageOptions.SvgImage")));
            this.btnExit_PN.Name = "btnExit_PN";
            this.btnExit_PN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_PN_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1827, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 738);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1827, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 687);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1827, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 687);
            // 
            // btnThoat_PN
            // 
            this.btnThoat_PN.Caption = "Thoát";
            this.btnThoat_PN.Id = 5;
            this.btnThoat_PN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat_PN.ImageOptions.SvgImage")));
            this.btnThoat_PN.Name = "btnThoat_PN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbChiNhanh_PN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1827, 44);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI NHÁNH";
            // 
            // cbbChiNhanh_PN
            // 
            this.cbbChiNhanh_PN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh_PN.FormattingEnabled = true;
            this.cbbChiNhanh_PN.Location = new System.Drawing.Point(363, 4);
            this.cbbChiNhanh_PN.Name = "cbbChiNhanh_PN";
            this.cbbChiNhanh_PN.Size = new System.Drawing.Size(795, 24);
            this.cbbChiNhanh_PN.TabIndex = 0;
            this.cbbChiNhanh_PN.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_PN_SelectedIndexChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PhieuNhap";
            this.bdsPhieuNhap.DataSource = this.DS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_form.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // gcPN
            // 
            this.gcPN.DataSource = this.bdsPhieuNhap;
            this.gcPN.Location = new System.Drawing.Point(0, 91);
            this.gcPN.MainView = this.gridView1;
            this.gcPN.MenuManager = this.barManager1;
            this.gcPN.Name = "gcPN";
            this.gcPN.Size = new System.Drawing.Size(502, 354);
            this.gcPN.TabIndex = 6;
            this.gcPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV});
            this.gridView1.GridControl = this.gcPN;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "DatHang";
            this.bdsDH.DataSource = this.DS;
            // 
            // gcDH
            // 
            this.gcDH.DataSource = this.bdsDH;
            this.gcDH.Location = new System.Drawing.Point(522, 91);
            this.gcDH.MainView = this.gridView2;
            this.gcDH.MenuManager = this.barManager1;
            this.gcDH.Name = "gcDH";
            this.gcDH.Size = new System.Drawing.Size(703, 354);
            this.gcDH.TabIndex = 6;
            this.gcDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colNGAY1,
            this.colNhaCC,
            this.colMANV1});
            this.gridView2.GridControl = this.gcDH;
            this.gridView2.Name = "gridView2";
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.MinWidth = 25;
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            this.colMasoDDH1.Width = 94;
            // 
            // colNGAY1
            // 
            this.colNGAY1.FieldName = "NGAY";
            this.colNGAY1.MinWidth = 25;
            this.colNGAY1.Name = "colNGAY1";
            this.colNGAY1.Visible = true;
            this.colNGAY1.VisibleIndex = 1;
            this.colNGAY1.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
            // 
            // colMANV1
            // 
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.MinWidth = 25;
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 3;
            this.colMANV1.Width = 94;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPhieuNhap;
            // 
            // gcCTPN
            // 
            this.gcCTPN.DataSource = this.bdsCTPN;
            this.gcCTPN.Location = new System.Drawing.Point(0, 451);
            this.gcCTPN.MainView = this.gridView3;
            this.gcCTPN.MenuManager = this.barManager1;
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.Size = new System.Drawing.Size(502, 307);
            this.gcCTPN.TabIndex = 7;
            this.gcCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView3.GridControl = this.gcCTPN;
            this.gridView3.Name = "gridView3";
            // 
            // colMAPN1
            // 
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.txbMaNV_PN);
            this.groupBox1.Controls.Add(masoDDHLabel);
            this.groupBox1.Controls.Add(this.txbMasoDDH_PN);
            this.groupBox1.Controls.Add(nGAYLabel);
            this.groupBox1.Controls.Add(this.dtpNgay_PN);
            this.groupBox1.Controls.Add(mAPNLabel);
            this.groupBox1.Controls.Add(this.txbMaPN_PN);
            this.groupBox1.Location = new System.Drawing.Point(544, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 187);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // txbMaNV_PN
            // 
            this.txbMaNV_PN.Location = new System.Drawing.Point(100, 145);
            this.txbMaNV_PN.Name = "txbMaNV_PN";
            this.txbMaNV_PN.Size = new System.Drawing.Size(524, 22);
            this.txbMaNV_PN.TabIndex = 7;
            // 
            // txbMasoDDH_PN
            // 
            this.txbMasoDDH_PN.Location = new System.Drawing.Point(100, 110);
            this.txbMasoDDH_PN.Name = "txbMasoDDH_PN";
            this.txbMasoDDH_PN.Size = new System.Drawing.Size(524, 22);
            this.txbMasoDDH_PN.TabIndex = 5;
            // 
            // dtpNgay_PN
            // 
            this.dtpNgay_PN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_PN.Location = new System.Drawing.Point(100, 69);
            this.dtpNgay_PN.Name = "dtpNgay_PN";
            this.dtpNgay_PN.Size = new System.Drawing.Size(524, 22);
            this.dtpNgay_PN.TabIndex = 3;
            // 
            // txbMaPN_PN
            // 
            this.txbMaPN_PN.Location = new System.Drawing.Point(100, 32);
            this.txbMaPN_PN.Name = "txbMaPN_PN";
            this.txbMaPN_PN.Size = new System.Drawing.Size(524, 22);
            this.txbMaPN_PN.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(dONGIALabel);
            this.groupBox2.Controls.Add(this.txbDonGia_PN);
            this.groupBox2.Controls.Add(sOLUONGLabel);
            this.groupBox2.Controls.Add(this.txbSoLuong_PN);
            this.groupBox2.Controls.Add(mAVTLabel);
            this.groupBox2.Controls.Add(this.txbMaVT_PN);
            this.groupBox2.Location = new System.Drawing.Point(1199, 471);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 187);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // txbDonGia_PN
            // 
            this.txbDonGia_PN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "DONGIA", true));
            this.txbDonGia_PN.Location = new System.Drawing.Point(94, 110);
            this.txbDonGia_PN.Name = "txbDonGia_PN";
            this.txbDonGia_PN.Size = new System.Drawing.Size(502, 22);
            this.txbDonGia_PN.TabIndex = 5;
            // 
            // txbSoLuong_PN
            // 
            this.txbSoLuong_PN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "SOLUONG", true));
            this.txbSoLuong_PN.Location = new System.Drawing.Point(94, 68);
            this.txbSoLuong_PN.Name = "txbSoLuong_PN";
            this.txbSoLuong_PN.Size = new System.Drawing.Size(502, 22);
            this.txbSoLuong_PN.TabIndex = 3;
            // 
            // txbMaVT_PN
            // 
            this.txbMaVT_PN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAVT", true));
            this.txbMaVT_PN.Location = new System.Drawing.Point(94, 34);
            this.txbMaVT_PN.Name = "txbMaVT_PN";
            this.txbMaVT_PN.Size = new System.Drawing.Size(502, 22);
            this.txbMaVT_PN.TabIndex = 1;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDH;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.DataSource = this.bdsCTDDH;
            this.gcCTDDH.Location = new System.Drawing.Point(1241, 91);
            this.gcCTDDH.MainView = this.gridView4;
            this.gcCTDDH.MenuManager = this.barManager1;
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.Size = new System.Drawing.Size(583, 354);
            this.gcCTDDH.TabIndex = 13;
            this.gcCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH2,
            this.colMAVT1,
            this.colSOLUONG1,
            this.colDONGIA1});
            this.gridView4.GridControl = this.gcCTDDH;
            this.gridView4.Name = "gridView4";
            // 
            // colMasoDDH2
            // 
            this.colMasoDDH2.FieldName = "MasoDDH";
            this.colMasoDDH2.MinWidth = 25;
            this.colMasoDDH2.Name = "colMasoDDH2";
            this.colMasoDDH2.Visible = true;
            this.colMasoDDH2.VisibleIndex = 0;
            this.colMasoDDH2.Width = 94;
            // 
            // colMAVT1
            // 
            this.colMAVT1.FieldName = "MAVT";
            this.colMAVT1.MinWidth = 25;
            this.colMAVT1.Name = "colMAVT1";
            this.colMAVT1.Visible = true;
            this.colMAVT1.VisibleIndex = 1;
            this.colMAVT1.Width = 94;
            // 
            // colSOLUONG1
            // 
            this.colSOLUONG1.FieldName = "SOLUONG";
            this.colSOLUONG1.MinWidth = 25;
            this.colSOLUONG1.Name = "colSOLUONG1";
            this.colSOLUONG1.Visible = true;
            this.colSOLUONG1.VisibleIndex = 2;
            this.colSOLUONG1.Width = 94;
            // 
            // colDONGIA1
            // 
            this.colDONGIA1.FieldName = "DONGIA";
            this.colDONGIA1.MinWidth = 25;
            this.colDONGIA1.Name = "colDONGIA1";
            this.colDONGIA1.Visible = true;
            this.colDONGIA1.VisibleIndex = 3;
            this.colDONGIA1.Width = 94;
            // 
            // btnChotPN
            // 
            this.btnChotPN.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChotPN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChotPN.Location = new System.Drawing.Point(804, 664);
            this.btnChotPN.Name = "btnChotPN";
            this.btnChotPN.Size = new System.Drawing.Size(164, 94);
            this.btnChotPN.TabIndex = 18;
            this.btnChotPN.Text = "CHỐT PHIẾU";
            this.btnChotPN.UseVisualStyleBackColor = false;
            this.btnChotPN.Click += new System.EventHandler(this.btnChotPN_Click);
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 758);
            this.Controls.Add(this.btnChotPN);
            this.Controls.Add(this.gcCTDDH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcCTPN);
            this.Controls.Add(this.gcDH);
            this.Controls.Add(this.gcPN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DS DS;
        private System.Windows.Forms.Panel panel1;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource bdsDH;
        private DevExpress.XtraGrid.GridControl gcDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DevExpress.XtraGrid.GridControl gcCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.BarButtonItem btnThem_PN;
        private System.Windows.Forms.TextBox txbMaNV_PN;
        private System.Windows.Forms.TextBox txbMasoDDH_PN;
        private System.Windows.Forms.DateTimePicker dtpNgay_PN;
        private System.Windows.Forms.TextBox txbMaPN_PN;
        private System.Windows.Forms.TextBox txbDonGia_PN;
        private System.Windows.Forms.TextBox txbSoLuong_PN;
        private System.Windows.Forms.TextBox txbMaVT_PN;
        private DevExpress.XtraBars.BarButtonItem btnThemCTPN_PN;
        private DevExpress.XtraBars.BarButtonItem btnSave_PN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChiNhanh_PN;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA1;
        private DevExpress.XtraBars.BarButtonItem btnSuaCTPN_PN;
        private DevExpress.XtraBars.BarButtonItem btnXoaCTPN_PN;
        private DevExpress.XtraBars.BarButtonItem btnThoat_PN;
        private DevExpress.XtraBars.BarButtonItem btnReloadCTDDH_PN;
        private DevExpress.XtraBars.BarButtonItem btnExit_PN;
        private System.Windows.Forms.Button btnChotPN;
    }
}