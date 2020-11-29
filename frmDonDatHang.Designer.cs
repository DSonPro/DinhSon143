namespace QLVT_form
{
    partial class frmDonDatHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonDatHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnGroupThem = new DevExpress.XtraBars.BarSubItem();
            this.btnThem_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem_CTDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btSuaChiTiet_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.btXoaChiTiet_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.btReload_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btThem_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.btXoa_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.btSua_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.btChiTiet_DDH = new DevExpress.XtraBars.BarButtonItem();
            this.DS = new QLVT_form.DS();
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT_form.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT_form.DSTableAdapters.TableAdapterManager();
            this.gcDathang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbNhaCC = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.txbMaSoDDH = new System.Windows.Forms.TextBox();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.bdsChiTietDDH = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHTableAdapter = new QLVT_form.DSTableAdapters.CTDDHTableAdapter();
            this.gcCTDDH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbSoLuongVT = new System.Windows.Forms.TextBox();
            this.txbDongia_DDH = new System.Windows.Forms.TextBox();
            this.txbMaVT_CTDDH = new System.Windows.Forms.TextBox();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_form.DSTableAdapters.VattuTableAdapter();
            this.gcVatTu = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhanVienTableAdapter = new QLVT_form.DSTableAdapters.NhanVienTableAdapter();
            this.btnAddVatTuxuong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChinhanh_DDH = new System.Windows.Forms.ComboBox();
            this.btChotDon_DDH = new System.Windows.Forms.Button();
            this.txbMANV_DDH = new System.Windows.Forms.TextBox();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDathang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(33, 54);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(102, 17);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã Số Đơn DH";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(94, 152);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(41, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(39, 102);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(96, 17);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà cung cấp";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(38, 195);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(97, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã Nhân Viên";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(16, 44);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(73, 17);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã Vật Tư";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(20, 92);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(69, 17);
            sOLUONGLabel.TabIndex = 2;
            sOLUONGLabel.Text = "Số Lượng";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(23, 142);
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
            this.btThem_DDH,
            this.btXoa_DDH,
            this.btSua_DDH,
            this.btChiTiet_DDH,
            this.btnGroupThem,
            this.btnThem_DDH,
            this.btnThem_CTDDH,
            this.btSuaChiTiet_DDH,
            this.btXoaChiTiet_DDH,
            this.btnSave_DDH,
            this.btReload_DDH,
            this.btnThoat_DDH});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 12;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGroupThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btSuaChiTiet_DDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btXoaChiTiet_DDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave_DDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btReload_DDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat_DDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnGroupThem
            // 
            this.btnGroupThem.Caption = "Thêm";
            this.btnGroupThem.Id = 4;
            this.btnGroupThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGroupThem.ImageOptions.SvgImage")));
            this.btnGroupThem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem_DDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem_CTDDH)});
            this.btnGroupThem.Name = "btnGroupThem";
            // 
            // btnThem_DDH
            // 
            this.btnThem_DDH.Caption = "Đơn Đặt Hàng";
            this.btnThem_DDH.Id = 5;
            this.btnThem_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem_DDH.ImageOptions.SvgImage")));
            this.btnThem_DDH.Name = "btnThem_DDH";
            this.btnThem_DDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnThem_CTDDH
            // 
            this.btnThem_CTDDH.Caption = "Chi Tiết DDH";
            this.btnThem_CTDDH.Id = 6;
            this.btnThem_CTDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem_CTDDH.ImageOptions.SvgImage")));
            this.btnThem_CTDDH.Name = "btnThem_CTDDH";
            this.btnThem_CTDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_CTDDH_ItemClick);
            // 
            // btSuaChiTiet_DDH
            // 
            this.btSuaChiTiet_DDH.Caption = "Sửa Chi Tiết DDH";
            this.btSuaChiTiet_DDH.Id = 7;
            this.btSuaChiTiet_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btSuaChiTiet_DDH.ImageOptions.SvgImage")));
            this.btSuaChiTiet_DDH.Name = "btSuaChiTiet_DDH";
            this.btSuaChiTiet_DDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSuaChiTiet_DDH_ItemClick);
            // 
            // btXoaChiTiet_DDH
            // 
            this.btXoaChiTiet_DDH.Caption = "Xóa Chi Tiết DDH";
            this.btXoaChiTiet_DDH.Id = 8;
            this.btXoaChiTiet_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btXoaChiTiet_DDH.ImageOptions.SvgImage")));
            this.btXoaChiTiet_DDH.Name = "btXoaChiTiet_DDH";
            this.btXoaChiTiet_DDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btXoaChiTiet_DDH_ItemClick);
            // 
            // btnSave_DDH
            // 
            this.btnSave_DDH.Caption = "Save";
            this.btnSave_DDH.Id = 9;
            this.btnSave_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave_DDH.ImageOptions.SvgImage")));
            this.btnSave_DDH.Name = "btnSave_DDH";
            this.btnSave_DDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_DDH_ItemClick);
            // 
            // btReload_DDH
            // 
            this.btReload_DDH.Caption = "Reload";
            this.btReload_DDH.Id = 10;
            this.btReload_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btReload_DDH.ImageOptions.SvgImage")));
            this.btReload_DDH.Name = "btReload_DDH";
            this.btReload_DDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btReload_DDH_ItemClick);
            // 
            // btnThoat_DDH
            // 
            this.btnThoat_DDH.Caption = "Thoát";
            this.btnThoat_DDH.Id = 11;
            this.btnThoat_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat_DDH.ImageOptions.SvgImage")));
            this.btnThoat_DDH.Name = "btnThoat_DDH";
            this.btnThoat_DDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_DDH_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1792, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 770);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1792, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 719);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1792, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 719);
            // 
            // btThem_DDH
            // 
            this.btThem_DDH.Caption = "Thêm";
            this.btThem_DDH.Id = 0;
            this.btThem_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btThem_DDH.ImageOptions.SvgImage")));
            this.btThem_DDH.Name = "btThem_DDH";
            // 
            // btXoa_DDH
            // 
            this.btXoa_DDH.Caption = "Xóa";
            this.btXoa_DDH.Id = 1;
            this.btXoa_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btXoa_DDH.ImageOptions.SvgImage")));
            this.btXoa_DDH.Name = "btXoa_DDH";
            // 
            // btSua_DDH
            // 
            this.btSua_DDH.Caption = "Sửa";
            this.btSua_DDH.Id = 2;
            this.btSua_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btSua_DDH.ImageOptions.SvgImage")));
            this.btSua_DDH.Name = "btSua_DDH";
            // 
            // btChiTiet_DDH
            // 
            this.btChiTiet_DDH.Caption = "Xem Chi Tiết";
            this.btChiTiet_DDH.Id = 3;
            this.btChiTiet_DDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btChiTiet_DDH.ImageOptions.SvgImage")));
            this.btChiTiet_DDH.Name = "btChiTiet_DDH";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "DatHang";
            this.bdsDH.DataSource = this.DS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_form.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcDathang
            // 
            this.gcDathang.DataSource = this.bdsDH;
            this.gcDathang.Location = new System.Drawing.Point(0, 77);
            this.gcDathang.MainView = this.gridView1;
            this.gcDathang.MenuManager = this.barManager1;
            this.gcDathang.Name = "gcDathang";
            this.gcDathang.Size = new System.Drawing.Size(649, 369);
            this.gcDathang.TabIndex = 6;
            this.gcDathang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcDathang.Click += new System.EventHandler(this.gcDathang_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV});
            this.gridView1.GridControl = this.gcDathang;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã Số DDH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà Cung Cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMANV_DDH);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(nhaCCLabel);
            this.groupBox1.Controls.Add(this.txbNhaCC);
            this.groupBox1.Controls.Add(nGAYLabel);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(masoDDHLabel);
            this.groupBox1.Controls.Add(this.txbMaSoDDH);
            this.groupBox1.Location = new System.Drawing.Point(0, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 272);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txbNhaCC
            // 
            this.txbNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDH, "NhaCC", true));
            this.txbNhaCC.Location = new System.Drawing.Point(151, 99);
            this.txbNhaCC.Name = "txbNhaCC";
            this.txbNhaCC.Size = new System.Drawing.Size(521, 22);
            this.txbNhaCC.TabIndex = 5;
            // 
            // dtpNgay
            // 
            this.dtpNgay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDH, "NGAY", true));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(151, 147);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(521, 22);
            this.dtpNgay.TabIndex = 3;
            // 
            // txbMaSoDDH
            // 
            this.txbMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDH, "MasoDDH", true));
            this.txbMaSoDDH.Location = new System.Drawing.Point(151, 51);
            this.txbMaSoDDH.Name = "txbMaSoDDH";
            this.txbMaSoDDH.Size = new System.Drawing.Size(521, 22);
            this.txbMaSoDDH.TabIndex = 1;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            // 
            // bdsChiTietDDH
            // 
            this.bdsChiTietDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsChiTietDDH.DataSource = this.bdsDH;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // gcCTDDH
            // 
            this.gcCTDDH.DataSource = this.bdsChiTietDDH;
            this.gcCTDDH.Location = new System.Drawing.Point(669, 77);
            this.gcCTDDH.MainView = this.gridView2;
            this.gcCTDDH.MenuManager = this.barManager1;
            this.gcCTDDH.Name = "gcCTDDH";
            this.gcCTDDH.Size = new System.Drawing.Size(524, 369);
            this.gcCTDDH.TabIndex = 15;
            this.gcCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gcCTDDH;
            this.gridView2.Name = "gridView2";
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.Caption = "Mã Số DDH";
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.MinWidth = 25;
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            this.colMasoDDH1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã Vật Tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số Lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn Giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbSoLuongVT);
            this.groupBox2.Controls.Add(dONGIALabel);
            this.groupBox2.Controls.Add(this.txbDongia_DDH);
            this.groupBox2.Controls.Add(sOLUONGLabel);
            this.groupBox2.Controls.Add(mAVTLabel);
            this.groupBox2.Controls.Add(this.txbMaVT_CTDDH);
            this.groupBox2.Location = new System.Drawing.Point(1015, 483);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 272);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txbSoLuongVT
            // 
            this.txbSoLuongVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietDDH, "SOLUONG", true));
            this.txbSoLuongVT.Location = new System.Drawing.Point(106, 89);
            this.txbSoLuongVT.Name = "txbSoLuongVT";
            this.txbSoLuongVT.Size = new System.Drawing.Size(653, 22);
            this.txbSoLuongVT.TabIndex = 6;
            // 
            // txbDongia_DDH
            // 
            this.txbDongia_DDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietDDH, "DONGIA", true));
            this.txbDongia_DDH.Location = new System.Drawing.Point(106, 139);
            this.txbDongia_DDH.Name = "txbDongia_DDH";
            this.txbDongia_DDH.Size = new System.Drawing.Size(653, 22);
            this.txbDongia_DDH.TabIndex = 5;
            // 
            // txbMaVT_CTDDH
            // 
            this.txbMaVT_CTDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsChiTietDDH, "MAVT", true));
            this.txbMaVT_CTDDH.Location = new System.Drawing.Point(106, 41);
            this.txbMaVT_CTDDH.Name = "txbMaVT_CTDDH";
            this.txbMaVT_CTDDH.Size = new System.Drawing.Size(653, 22);
            this.txbMaVT_CTDDH.TabIndex = 1;
            this.txbMaVT_CTDDH.TextChanged += new System.EventHandler(this.txbMaVT_CTDDH_TextChanged);
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // gcVatTu
            // 
            this.gcVatTu.DataSource = this.bdsVatTu;
            this.gcVatTu.Location = new System.Drawing.Point(1210, 77);
            this.gcVatTu.MainView = this.gridView3;
            this.gcVatTu.MenuManager = this.barManager1;
            this.gcVatTu.Name = "gcVatTu";
            this.gcVatTu.Size = new System.Drawing.Size(582, 369);
            this.gcVatTu.TabIndex = 16;
            this.gcVatTu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gcVatTu.Click += new System.EventHandler(this.gcVatTu_Click);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT1,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView3.GridControl = this.gcVatTu;
            this.gridView3.Name = "gridView3";
            // 
            // colMAVT1
            // 
            this.colMAVT1.FieldName = "MAVT";
            this.colMAVT1.MinWidth = 25;
            this.colMAVT1.Name = "colMAVT1";
            this.colMAVT1.Visible = true;
            this.colMAVT1.VisibleIndex = 0;
            this.colMAVT1.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 94;
            // 
            // colDVT
            // 
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 25;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 94;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 25;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 94;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddVatTuxuong
            // 
            this.btnAddVatTuxuong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddVatTuxuong.Location = new System.Drawing.Point(1463, 452);
            this.btnAddVatTuxuong.Name = "btnAddVatTuxuong";
            this.btnAddVatTuxuong.Size = new System.Drawing.Size(131, 31);
            this.btnAddVatTuxuong.TabIndex = 21;
            this.btnAddVatTuxuong.Text = "Chọn vật tư";
            this.btnAddVatTuxuong.UseVisualStyleBackColor = false;
            this.btnAddVatTuxuong.Click += new System.EventHandler(this.btnAddVatTuxuong_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChinhanh_DDH);
            this.panel1.Location = new System.Drawing.Point(249, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 39);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI NHÁNH";
            // 
            // cmbChinhanh_DDH
            // 
            this.cmbChinhanh_DDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChinhanh_DDH.FormattingEnabled = true;
            this.cmbChinhanh_DDH.Location = new System.Drawing.Point(261, 12);
            this.cmbChinhanh_DDH.Name = "cmbChinhanh_DDH";
            this.cmbChinhanh_DDH.Size = new System.Drawing.Size(838, 24);
            this.cmbChinhanh_DDH.TabIndex = 0;
            this.cmbChinhanh_DDH.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_DDH_SelectedIndexChanged);
            // 
            // btChotDon_DDH
            // 
            this.btChotDon_DDH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btChotDon_DDH.Location = new System.Drawing.Point(814, 532);
            this.btChotDon_DDH.Name = "btChotDon_DDH";
            this.btChotDon_DDH.Size = new System.Drawing.Size(137, 92);
            this.btChotDon_DDH.TabIndex = 31;
            this.btChotDon_DDH.Text = "CHỐT ĐƠN";
            this.btChotDon_DDH.UseVisualStyleBackColor = false;
            this.btChotDon_DDH.Click += new System.EventHandler(this.btChotDon_DDH_Click);
            // 
            // txbMANV_DDH
            // 
            this.txbMANV_DDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDH, "MANV", true));
            this.txbMANV_DDH.Location = new System.Drawing.Point(151, 192);
            this.txbMANV_DDH.Name = "txbMANV_DDH";
            this.txbMANV_DDH.Size = new System.Drawing.Size(521, 22);
            this.txbMANV_DDH.TabIndex = 8;
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 790);
            this.Controls.Add(this.btChotDon_DDH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddVatTuxuong);
            this.Controls.Add(this.gcVatTu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gcCTDDH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcDathang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDonDatHang";
            this.Text = "frmDonDatHang";
            this.Load += new System.EventHandler(this.frmDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDathang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btThem_DDH;
        private DevExpress.XtraBars.BarButtonItem btXoa_DDH;
        private DevExpress.XtraBars.BarButtonItem btSua_DDH;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDH;
        private DS DS;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcDathang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btChiTiet_DDH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMaSoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.TextBox txbNhaCC;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.BindingSource bdsChiTietDDH;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gcCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.TextBox txbDongia_DDH;
        private System.Windows.Forms.TextBox txbMaVT_CTDDH;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraBars.BarSubItem btnGroupThem;
        private DevExpress.XtraBars.BarButtonItem btnThem_DDH;
        private DevExpress.XtraBars.BarButtonItem btnThem_CTDDH;
        private DevExpress.XtraBars.BarButtonItem btSuaChiTiet_DDH;
        private DevExpress.XtraBars.BarButtonItem btXoaChiTiet_DDH;
        private DevExpress.XtraGrid.GridControl gcVatTu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraBars.BarButtonItem btnSave_DDH;
        private DevExpress.XtraBars.BarButtonItem btReload_DDH;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.TextBox txbSoLuongVT;
        private System.Windows.Forms.Button btnAddVatTuxuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChinhanh_DDH;
        private System.Windows.Forms.Button btChotDon_DDH;
        private DevExpress.XtraBars.BarButtonItem btnThoat_DDH;
        private System.Windows.Forms.TextBox txbMANV_DDH;
    }
}