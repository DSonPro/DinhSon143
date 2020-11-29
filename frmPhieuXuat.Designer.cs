namespace QLVT_form
{
    partial class frmPhieuXuat
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuXuat));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemCTPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave_PX = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaCTPX_PX = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCTPX_PX = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload_PX = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit_PX = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChiNhanh_PX = new System.Windows.Forms.ComboBox();
            this.DS = new QLVT_form.DS();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT_form.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT_form.DSTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new QLVT_form.DSTableAdapters.CTPXTableAdapter();
            this.vattuTableAdapter = new QLVT_form.DSTableAdapters.VattuTableAdapter();
            this.gcPX = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.gcCTPX = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbMaNV_PX = new System.Windows.Forms.TextBox();
            this.txbHTKhachang_PX = new System.Windows.Forms.TextBox();
            this.dtpNgay_PX = new System.Windows.Forms.DateTimePicker();
            this.txbMaPX_PX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbDonGia_PX = new System.Windows.Forms.TextBox();
            this.txbSoLuong_PX = new System.Windows.Forms.TextBox();
            this.txbMaVT_PX = new System.Windows.Forms.TextBox();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.gcVT = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChotPhieu_PX = new System.Windows.Forms.Button();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(47, 30);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(100, 17);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "Mã Phiếu Xuất";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(95, 144);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(41, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(5, 67);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(141, 17);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "Họ_Tên Khách Hàng";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(96, 107);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(50, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Mã NV";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(45, 27);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(49, 17);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "Mã VT";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(30, 69);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(64, 17);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "Số lượng";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(37, 110);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(57, 17);
            dONGIALabel.TabIndex = 6;
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
            this.btnThemPX,
            this.btnThemCTPX,
            this.btnSave_PX,
            this.btnSuaCTPX_PX,
            this.btnXoaCTPX_PX,
            this.btnReload_PX,
            this.btnExit_PX});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCTPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave_PX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaCTPX_PX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaCTPX_PX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload_PX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit_PX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemPX
            // 
            this.btnThemPX.Caption = "Thêm Phiếu Xuất";
            this.btnThemPX.Id = 0;
            this.btnThemPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemPX.ImageOptions.SvgImage")));
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemPX_ItemClick);
            // 
            // btnThemCTPX
            // 
            this.btnThemCTPX.Caption = "Thêm CTPX";
            this.btnThemCTPX.Id = 1;
            this.btnThemCTPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemCTPX.ImageOptions.SvgImage")));
            this.btnThemCTPX.Name = "btnThemCTPX";
            this.btnThemCTPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCTPX_ItemClick);
            // 
            // btnSave_PX
            // 
            this.btnSave_PX.Caption = "Save";
            this.btnSave_PX.Id = 2;
            this.btnSave_PX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave_PX.ImageOptions.SvgImage")));
            this.btnSave_PX.Name = "btnSave_PX";
            this.btnSave_PX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_PX_ItemClick);
            // 
            // btnSuaCTPX_PX
            // 
            this.btnSuaCTPX_PX.Caption = "Sửa CTPX";
            this.btnSuaCTPX_PX.Id = 3;
            this.btnSuaCTPX_PX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaCTPX_PX.ImageOptions.SvgImage")));
            this.btnSuaCTPX_PX.Name = "btnSuaCTPX_PX";
            this.btnSuaCTPX_PX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaCTPX_PX_ItemClick);
            // 
            // btnXoaCTPX_PX
            // 
            this.btnXoaCTPX_PX.Caption = "Xóa CTPX";
            this.btnXoaCTPX_PX.Id = 4;
            this.btnXoaCTPX_PX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaCTPX_PX.ImageOptions.SvgImage")));
            this.btnXoaCTPX_PX.Name = "btnXoaCTPX_PX";
            this.btnXoaCTPX_PX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaCTPX_PX_ItemClick);
            // 
            // btnReload_PX
            // 
            this.btnReload_PX.Caption = "Reload";
            this.btnReload_PX.Id = 5;
            this.btnReload_PX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload_PX.ImageOptions.SvgImage")));
            this.btnReload_PX.Name = "btnReload_PX";
            this.btnReload_PX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_PX_ItemClick);
            // 
            // btnExit_PX
            // 
            this.btnExit_PX.Caption = "Thoát";
            this.btnExit_PX.Id = 6;
            this.btnExit_PX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit_PX.ImageOptions.SvgImage")));
            this.btnExit_PX.Name = "btnExit_PX";
            this.btnExit_PX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_PX_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1851, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 754);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1851, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 703);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1851, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 703);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbChiNhanh_PX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1851, 50);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHI NHÁNH";
            // 
            // cbbChiNhanh_PX
            // 
            this.cbbChiNhanh_PX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh_PX.FormattingEnabled = true;
            this.cbbChiNhanh_PX.Location = new System.Drawing.Point(420, 6);
            this.cbbChiNhanh_PX.Name = "cbbChiNhanh_PX";
            this.cbbChiNhanh_PX.Size = new System.Drawing.Size(606, 24);
            this.cbbChiNhanh_PX.TabIndex = 0;
            this.cbbChiNhanh_PX.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_PX_SelectedIndexChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.DS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLVT_form.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // gcPX
            // 
            this.gcPX.DataSource = this.bdsPX;
            this.gcPX.Location = new System.Drawing.Point(3, 107);
            this.gcPX.MainView = this.gridView1;
            this.gcPX.MenuManager = this.barManager1;
            this.gcPX.Name = "gcPX";
            this.gcPX.Size = new System.Drawing.Size(688, 422);
            this.gcPX.TabIndex = 6;
            this.gcPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV});
            this.gridView1.GridControl = this.gcPX;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPX
            // 
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 25;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 94;
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
            // colHOTENKH
            // 
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 25;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 94;
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
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_PX";
            this.bdsCTPX.DataSource = this.bdsPX;
            // 
            // gcCTPX
            // 
            this.gcCTPX.DataSource = this.bdsCTPX;
            this.gcCTPX.Location = new System.Drawing.Point(764, 107);
            this.gcCTPX.MainView = this.gridView2;
            this.gcCTPX.MenuManager = this.barManager1;
            this.gcCTPX.Name = "gcCTPX";
            this.gcCTPX.Size = new System.Drawing.Size(468, 422);
            this.gcCTPX.TabIndex = 6;
            this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gcCTPX;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPX1
            // 
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.MinWidth = 25;
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            this.colMAPX1.Width = 94;
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
            this.groupBox1.Controls.Add(this.txbMaNV_PX);
            this.groupBox1.Controls.Add(hOTENKHLabel);
            this.groupBox1.Controls.Add(this.txbHTKhachang_PX);
            this.groupBox1.Controls.Add(nGAYLabel);
            this.groupBox1.Controls.Add(this.dtpNgay_PX);
            this.groupBox1.Controls.Add(mAPXLabel);
            this.groupBox1.Controls.Add(this.txbMaPX_PX);
            this.groupBox1.Location = new System.Drawing.Point(3, 554);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 170);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txbMaNV_PX
            // 
            this.txbMaNV_PX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MANV", true));
            this.txbMaNV_PX.Location = new System.Drawing.Point(166, 107);
            this.txbMaNV_PX.Name = "txbMaNV_PX";
            this.txbMaNV_PX.Size = new System.Drawing.Size(452, 22);
            this.txbMaNV_PX.TabIndex = 7;
            // 
            // txbHTKhachang_PX
            // 
            this.txbHTKhachang_PX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "HOTENKH", true));
            this.txbHTKhachang_PX.Location = new System.Drawing.Point(166, 64);
            this.txbHTKhachang_PX.Name = "txbHTKhachang_PX";
            this.txbHTKhachang_PX.Size = new System.Drawing.Size(452, 22);
            this.txbHTKhachang_PX.TabIndex = 5;
            // 
            // dtpNgay_PX
            // 
            this.dtpNgay_PX.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsPX, "NGAY", true));
            this.dtpNgay_PX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_PX.Location = new System.Drawing.Point(166, 142);
            this.dtpNgay_PX.Name = "dtpNgay_PX";
            this.dtpNgay_PX.Size = new System.Drawing.Size(453, 22);
            this.dtpNgay_PX.TabIndex = 3;
            // 
            // txbMaPX_PX
            // 
            this.txbMaPX_PX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAPX", true));
            this.txbMaPX_PX.Location = new System.Drawing.Point(166, 27);
            this.txbMaPX_PX.Name = "txbMaPX_PX";
            this.txbMaPX_PX.Size = new System.Drawing.Size(452, 22);
            this.txbMaPX_PX.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(dONGIALabel);
            this.groupBox2.Controls.Add(this.txbDonGia_PX);
            this.groupBox2.Controls.Add(sOLUONGLabel);
            this.groupBox2.Controls.Add(this.txbSoLuong_PX);
            this.groupBox2.Controls.Add(mAVTLabel);
            this.groupBox2.Controls.Add(this.txbMaVT_PX);
            this.groupBox2.Location = new System.Drawing.Point(1250, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 180);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txbDonGia_PX
            // 
            this.txbDonGia_PX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "DONGIA", true));
            this.txbDonGia_PX.Location = new System.Drawing.Point(109, 107);
            this.txbDonGia_PX.Name = "txbDonGia_PX";
            this.txbDonGia_PX.Size = new System.Drawing.Size(441, 22);
            this.txbDonGia_PX.TabIndex = 7;
            // 
            // txbSoLuong_PX
            // 
            this.txbSoLuong_PX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "SOLUONG", true));
            this.txbSoLuong_PX.Location = new System.Drawing.Point(109, 69);
            this.txbSoLuong_PX.Name = "txbSoLuong_PX";
            this.txbSoLuong_PX.Size = new System.Drawing.Size(441, 22);
            this.txbSoLuong_PX.TabIndex = 5;
            // 
            // txbMaVT_PX
            // 
            this.txbMaVT_PX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "MAVT", true));
            this.txbMaVT_PX.Location = new System.Drawing.Point(109, 30);
            this.txbMaVT_PX.Name = "txbMaVT_PX";
            this.txbMaVT_PX.Size = new System.Drawing.Size(441, 22);
            this.txbMaVT_PX.TabIndex = 3;
            // 
            // bdsVT
            // 
            this.bdsVT.DataMember = "Vattu";
            this.bdsVT.DataSource = this.DS;
            // 
            // gcVT
            // 
            this.gcVT.DataSource = this.bdsVT;
            this.gcVT.Location = new System.Drawing.Point(1250, 107);
            this.gcVT.MainView = this.gridView3;
            this.gcVT.MenuManager = this.barManager1;
            this.gcVT.Name = "gcVT";
            this.gcVT.Size = new System.Drawing.Size(575, 422);
            this.gcVT.TabIndex = 9;
            this.gcVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gcVT.Click += new System.EventHandler(this.gcVT_Click);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT1,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView3.GridControl = this.gcVT;
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
            // btnChotPhieu_PX
            // 
            this.btnChotPhieu_PX.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChotPhieu_PX.Location = new System.Drawing.Point(802, 598);
            this.btnChotPhieu_PX.Name = "btnChotPhieu_PX";
            this.btnChotPhieu_PX.Size = new System.Drawing.Size(297, 101);
            this.btnChotPhieu_PX.TabIndex = 10;
            this.btnChotPhieu_PX.Text = "CHỐT PHIẾU";
            this.btnChotPhieu_PX.UseVisualStyleBackColor = false;
            this.btnChotPhieu_PX.Click += new System.EventHandler(this.btnChotPhieu_PX_Click);
            // 
            // frmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 774);
            this.Controls.Add(this.btnChotPhieu_PX);
            this.Controls.Add(this.gcVT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcCTPX);
            this.Controls.Add(this.gcPX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhieuXuat";
            this.Text = "frmPhieuXuat";
            this.Load += new System.EventHandler(this.frmPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemPX;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsPX;
        private DS DS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChiNhanh_PX;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DevExpress.XtraGrid.GridControl gcCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.BarButtonItem btnThemCTPX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbDonGia_PX;
        private System.Windows.Forms.TextBox txbSoLuong_PX;
        private System.Windows.Forms.TextBox txbMaVT_PX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMaNV_PX;
        private System.Windows.Forms.TextBox txbHTKhachang_PX;
        private System.Windows.Forms.DateTimePicker dtpNgay_PX;
        private System.Windows.Forms.TextBox txbMaPX_PX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.BindingSource bdsVT;
        private System.Windows.Forms.Button btnChotPhieu_PX;
        private DevExpress.XtraGrid.GridControl gcVT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraBars.BarButtonItem btnSave_PX;
        private DevExpress.XtraBars.BarButtonItem btnSuaCTPX_PX;
        private DevExpress.XtraBars.BarButtonItem btnXoaCTPX_PX;
        private DevExpress.XtraBars.BarButtonItem btnReload_PX;
        private DevExpress.XtraBars.BarButtonItem btnExit_PX;
    }
}