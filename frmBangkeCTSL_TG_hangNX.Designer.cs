namespace QLVT_form
{
    partial class frmBangkeCTSL_TG_hangNX
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemBangKeKhai = new System.Windows.Forms.Button();
            this.dtpNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TỪ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ĐẾN:";
            // 
            // btnXemBangKeKhai
            // 
            this.btnXemBangKeKhai.Location = new System.Drawing.Point(539, 70);
            this.btnXemBangKeKhai.Name = "btnXemBangKeKhai";
            this.btnXemBangKeKhai.Size = new System.Drawing.Size(103, 47);
            this.btnXemBangKeKhai.TabIndex = 15;
            this.btnXemBangKeKhai.Text = "XEM";
            this.btnXemBangKeKhai.UseVisualStyleBackColor = true;
            this.btnXemBangKeKhai.Click += new System.EventHandler(this.btnXemBangKeKhai_Click);
            // 
            // dtpNgaybatdau
            // 
            this.dtpNgaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaybatdau.Location = new System.Drawing.Point(156, 63);
            this.dtpNgaybatdau.Name = "dtpNgaybatdau";
            this.dtpNgaybatdau.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaybatdau.TabIndex = 16;
            // 
            // dtpNgayEnd
            // 
            this.dtpNgayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayEnd.Location = new System.Drawing.Point(156, 98);
            this.dtpNgayEnd.Name = "dtpNgayEnd";
            this.dtpNgayEnd.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayEnd.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "LOẠI:";
            // 
            // cbbLoai
            // 
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.cbbLoai.Location = new System.Drawing.Point(156, 37);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(200, 24);
            this.cbbLoai.TabIndex = 20;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(156, 6);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(200, 24);
            this.cbbChiNhanh.TabIndex = 21;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "CHI NHÁNH:";
            // 
            // frmBangkeCTSL_TG_hangNX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 888);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbChiNhanh);
            this.Controls.Add(this.cbbLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayEnd);
            this.Controls.Add(this.dtpNgaybatdau);
            this.Controls.Add(this.btnXemBangKeKhai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBangkeCTSL_TG_hangNX";
            this.Text = "frmBangkeCTSL_TG_hangNX";
            this.Load += new System.EventHandler(this.frmBangkeCTSL_TG_hangNX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXemBangKeKhai;
        private System.Windows.Forms.DateTimePicker dtpNgaybatdau;
        private System.Windows.Forms.DateTimePicker dtpNgayEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label4;
    }
}