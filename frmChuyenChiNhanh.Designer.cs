namespace QLVT_form
{
    partial class frmChuyenChiNhanh
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
            System.Windows.Forms.Label mACNLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMaNV_cu = new System.Windows.Forms.TextBox();
            this.txbMaNV_moi = new System.Windows.Forms.TextBox();
            this.btnThoatChangeCN = new System.Windows.Forms.Button();
            this.btnChangeCN = new System.Windows.Forms.Button();
            this.qLVT_DHDataSet = new QLVT_form.QLVT_DHDataSet();
            this.bdsDSPM = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLVT_form.QLVT_DHDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.cbbMACN_changeCN = new System.Windows.Forms.ComboBox();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(200, 94);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(116, 17);
            mACNLabel.TabIndex = 1;
            mACNLabel.Text = "Chuyển Sang CN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Nhân Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Nhân Viên Mới";
            // 
            // txbMaNV_cu
            // 
            this.txbMaNV_cu.Location = new System.Drawing.Point(322, 140);
            this.txbMaNV_cu.Name = "txbMaNV_cu";
            this.txbMaNV_cu.Size = new System.Drawing.Size(532, 22);
            this.txbMaNV_cu.TabIndex = 5;
            this.txbMaNV_cu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbMaNV_moi
            // 
            this.txbMaNV_moi.Location = new System.Drawing.Point(323, 184);
            this.txbMaNV_moi.Name = "txbMaNV_moi";
            this.txbMaNV_moi.Size = new System.Drawing.Size(531, 22);
            this.txbMaNV_moi.TabIndex = 6;
            // 
            // btnThoatChangeCN
            // 
            this.btnThoatChangeCN.Location = new System.Drawing.Point(322, 295);
            this.btnThoatChangeCN.Name = "btnThoatChangeCN";
            this.btnThoatChangeCN.Size = new System.Drawing.Size(148, 58);
            this.btnThoatChangeCN.TabIndex = 7;
            this.btnThoatChangeCN.Text = "Thoát";
            this.btnThoatChangeCN.UseVisualStyleBackColor = true;
            this.btnThoatChangeCN.Click += new System.EventHandler(this.btnThoatChangeCN_Click);
            // 
            // btnChangeCN
            // 
            this.btnChangeCN.Location = new System.Drawing.Point(706, 295);
            this.btnChangeCN.Name = "btnChangeCN";
            this.btnChangeCN.Size = new System.Drawing.Size(148, 58);
            this.btnChangeCN.TabIndex = 8;
            this.btnChangeCN.Text = "Chuyển";
            this.btnChangeCN.UseVisualStyleBackColor = true;
            this.btnChangeCN.Click += new System.EventHandler(this.btnChangeCN_Click);
            // 
            // qLVT_DHDataSet
            // 
            this.qLVT_DHDataSet.DataSetName = "QLVT_DHDataSet";
            this.qLVT_DHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDSPM
            // 
            this.bdsDSPM.DataMember = "V_DS_PHANMANH";
            this.bdsDSPM.DataSource = this.qLVT_DHDataSet;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // cbbMACN_changeCN
            // 
            this.cbbMACN_changeCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSPM, "TENCN", true));
            this.cbbMACN_changeCN.DataSource = this.bdsDSPM;
            this.cbbMACN_changeCN.DisplayMember = "TENCN";
            this.cbbMACN_changeCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMACN_changeCN.FormattingEnabled = true;
            this.cbbMACN_changeCN.Location = new System.Drawing.Point(323, 91);
            this.cbbMACN_changeCN.Name = "cbbMACN_changeCN";
            this.cbbMACN_changeCN.Size = new System.Drawing.Size(531, 24);
            this.cbbMACN_changeCN.TabIndex = 9;
            this.cbbMACN_changeCN.ValueMember = "TENSERVER";
            this.cbbMACN_changeCN.SelectedIndexChanged += new System.EventHandler(this.cbbMACN_changeCN_SelectedIndexChanged_1);
            // 
            // frmChuyenChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 678);
            this.Controls.Add(this.cbbMACN_changeCN);
            this.Controls.Add(this.btnChangeCN);
            this.Controls.Add(this.btnThoatChangeCN);
            this.Controls.Add(this.txbMaNV_moi);
            this.Controls.Add(this.txbMaNV_cu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(mACNLabel);
            this.Name = "frmChuyenChiNhanh";
            this.Text = "frmChuyenChiNhanh";
            this.Load += new System.EventHandler(this.frmChuyenChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaNV_cu;
        private System.Windows.Forms.TextBox txbMaNV_moi;
        private System.Windows.Forms.Button btnThoatChangeCN;
        private System.Windows.Forms.Button btnChangeCN;
        private QLVT_DHDataSet qLVT_DHDataSet;
        private System.Windows.Forms.BindingSource bdsDSPM;
        private QLVT_DHDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private System.Windows.Forms.ComboBox cbbMACN_changeCN;
    }
}