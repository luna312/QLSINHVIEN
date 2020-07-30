namespace BTTH3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gPhieuDatBao = new System.Windows.Forms.GroupBox();
            this.gChiTietDatBao = new System.Windows.Forms.GroupBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSDT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cbTapChi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nudThangKT = new System.Windows.Forms.NumericUpDown();
            this.nudThangBD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvCTDB = new System.Windows.Forms.DataGridView();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateDB = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteTC = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTC = new DevExpress.XtraEditors.SimpleButton();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.gPhieuDatBao.SuspendLayout();
            this.gChiTietDatBao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDB)).BeginInit();
            this.SuspendLayout();
            // 
            // gPhieuDatBao
            // 
            this.gPhieuDatBao.Controls.Add(this.btnSave);
            this.gPhieuDatBao.Controls.Add(this.btnUpdateDB);
            this.gPhieuDatBao.Controls.Add(this.btnCancel);
            this.gPhieuDatBao.Controls.Add(this.btnDeleteDB);
            this.gPhieuDatBao.Controls.Add(this.btnExit);
            this.gPhieuDatBao.Controls.Add(this.btnNewDB);
            this.gPhieuDatBao.Controls.Add(this.btnPrevious);
            this.gPhieuDatBao.Controls.Add(this.btnNext);
            this.gPhieuDatBao.Controls.Add(this.btnLast);
            this.gPhieuDatBao.Controls.Add(this.btnFirst);
            this.gPhieuDatBao.Controls.Add(this.txtTenKH);
            this.gPhieuDatBao.Controls.Add(this.txtDiaChi);
            this.gPhieuDatBao.Controls.Add(this.label5);
            this.gPhieuDatBao.Controls.Add(this.label4);
            this.gPhieuDatBao.Controls.Add(this.dtNgayDat);
            this.gPhieuDatBao.Controls.Add(this.label3);
            this.gPhieuDatBao.Controls.Add(this.label2);
            this.gPhieuDatBao.Controls.Add(this.cbSDT);
            this.gPhieuDatBao.Controls.Add(this.label1);
            this.gPhieuDatBao.Controls.Add(this.txtSoPhieu);
            this.gPhieuDatBao.Location = new System.Drawing.Point(6, 51);
            this.gPhieuDatBao.Name = "gPhieuDatBao";
            this.gPhieuDatBao.Size = new System.Drawing.Size(952, 203);
            this.gPhieuDatBao.TabIndex = 0;
            this.gPhieuDatBao.TabStop = false;
            this.gPhieuDatBao.Text = "Phiếu đặt báo";
            // 
            // gChiTietDatBao
            // 
            this.gChiTietDatBao.Controls.Add(this.btnAddTC);
            this.gChiTietDatBao.Controls.Add(this.btnDeleteTC);
            this.gChiTietDatBao.Controls.Add(this.dgvCTDB);
            this.gChiTietDatBao.Controls.Add(this.label10);
            this.gChiTietDatBao.Controls.Add(this.txtTong);
            this.gChiTietDatBao.Controls.Add(this.label9);
            this.gChiTietDatBao.Controls.Add(this.label8);
            this.gChiTietDatBao.Controls.Add(this.label7);
            this.gChiTietDatBao.Controls.Add(this.nudThangBD);
            this.gChiTietDatBao.Controls.Add(this.nudThangKT);
            this.gChiTietDatBao.Controls.Add(this.nudSoLuong);
            this.gChiTietDatBao.Controls.Add(this.label6);
            this.gChiTietDatBao.Controls.Add(this.cbTapChi);
            this.gChiTietDatBao.Location = new System.Drawing.Point(6, 260);
            this.gChiTietDatBao.Name = "gChiTietDatBao";
            this.gChiTietDatBao.Size = new System.Drawing.Size(952, 269);
            this.gChiTietDatBao.TabIndex = 1;
            this.gChiTietDatBao.TabStop = false;
            this.gChiTietDatBao.Text = "Chi tiết Đặt Báo";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(100, 28);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(121, 20);
            this.txtSoPhieu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Số Phiếu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbSDT
            // 
            this.cbSDT.FormattingEnabled = true;
            this.cbSDT.Location = new System.Drawing.Point(100, 66);
            this.cbSDT.Name = "cbSDT";
            this.cbSDT.Size = new System.Drawing.Size(121, 21);
            this.cbSDT.TabIndex = 2;
            this.cbSDT.SelectedIndexChanged += new System.EventHandler(this.cbSDT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm theo SĐT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Location = new System.Drawing.Point(391, 25);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(196, 20);
            this.dtNgayDat.TabIndex = 5;
            this.dtNgayDat.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày Đặt Hàng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(391, 67);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(196, 59);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(101, 106);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(121, 20);
            this.txtTenKH.TabIndex = 9;
            this.txtTenKH.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cbTapChi
            // 
            this.cbTapChi.FormattingEnabled = true;
            this.cbTapChi.Location = new System.Drawing.Point(100, 20);
            this.cbTapChi.Name = "cbTapChi";
            this.cbTapChi.Size = new System.Drawing.Size(121, 21);
            this.cbTapChi.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tìm tên Tạp Chí";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(319, 21);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(52, 20);
            this.nudSoLuong.TabIndex = 5;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudThangKT
            // 
            this.nudThangKT.Location = new System.Drawing.Point(550, 21);
            this.nudThangKT.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThangKT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThangKT.Name = "nudThangKT";
            this.nudThangKT.Size = new System.Drawing.Size(47, 20);
            this.nudThangKT.TabIndex = 6;
            this.nudThangKT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThangKT.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // nudThangBD
            // 
            this.nudThangBD.Location = new System.Drawing.Point(437, 21);
            this.nudThangBD.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThangBD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThangBD.Name = "nudThangBD";
            this.nudThangBD.Size = new System.Drawing.Size(48, 20);
            this.nudThangBD.TabIndex = 7;
            this.nudThangBD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tháng KT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tháng BĐ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Số Lượng:";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(100, 47);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(121, 20);
            this.txtTong.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tổng Tiền";
            // 
            // dgvCTDB
            // 
            this.dgvCTDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenTC,
            this.ThangBD,
            this.ThangKT,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvCTDB.Location = new System.Drawing.Point(4, 76);
            this.dgvCTDB.Name = "dgvCTDB";
            this.dgvCTDB.Size = new System.Drawing.Size(947, 192);
            this.dgvCTDB.TabIndex = 13;
            this.dgvCTDB.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCTDB_DataBindingComplete);
            // 
            // btnFirst
            // 
            this.btnFirst.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage1")));
            this.btnFirst.Location = new System.Drawing.Point(13, 144);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(48, 41);
            this.btnFirst.TabIndex = 10;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage1")));
            this.btnLast.Location = new System.Drawing.Point(175, 144);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(48, 41);
            this.btnLast.TabIndex = 11;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage1")));
            this.btnNext.Location = new System.Drawing.Point(121, 144);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(48, 41);
            this.btnNext.TabIndex = 12;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage1")));
            this.btnPrevious.Location = new System.Drawing.Point(67, 144);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(48, 41);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNewDB
            // 
            this.btnNewDB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnNewDB.Location = new System.Drawing.Point(623, 20);
            this.btnNewDB.Name = "btnNewDB";
            this.btnNewDB.Size = new System.Drawing.Size(95, 46);
            this.btnNewDB.TabIndex = 14;
            this.btnNewDB.Text = "New";
            this.btnNewDB.Click += new System.EventHandler(this.btnNewDB_Click);
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.btnExit.Location = new System.Drawing.Point(748, 139);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 46);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.btnDeleteDB.Location = new System.Drawing.Point(623, 139);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(95, 46);
            this.btnDeleteDB.TabIndex = 16;
            this.btnDeleteDB.Text = "Delete";
            this.btnDeleteDB.Click += new System.EventHandler(this.btnDeleteDB_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton4.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(748, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 46);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateDB
            // 
            this.btnUpdateDB.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.btnUpdateDB.Location = new System.Drawing.Point(623, 80);
            this.btnUpdateDB.Name = "btnUpdateDB";
            this.btnUpdateDB.Size = new System.Drawing.Size(95, 46);
            this.btnUpdateDB.TabIndex = 18;
            this.btnUpdateDB.Text = "Update";
            this.btnUpdateDB.Click += new System.EventHandler(this.btnUpdateDB_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(748, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 46);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteTC
            // 
            this.btnDeleteTC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage2")));
            this.btnDeleteTC.Location = new System.Drawing.Point(748, 19);
            this.btnDeleteTC.Name = "btnDeleteTC";
            this.btnDeleteTC.Size = new System.Drawing.Size(95, 46);
            this.btnDeleteTC.TabIndex = 17;
            this.btnDeleteTC.Text = "Delete";
            this.btnDeleteTC.Click += new System.EventHandler(this.btnDeleteTC_Click);
            // 
            // btnAddTC
            // 
            this.btnAddTC.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage2")));
            this.btnAddTC.Location = new System.Drawing.Point(623, 20);
            this.btnAddTC.Name = "btnAddTC";
            this.btnAddTC.Size = new System.Drawing.Size(95, 46);
            this.btnAddTC.TabIndex = 18;
            this.btnAddTC.Text = "Add";
            this.btnAddTC.Click += new System.EventHandler(this.btnAddTC_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // TenTC
            // 
            this.TenTC.DataPropertyName = "TenTC";
            this.TenTC.HeaderText = "Tên Tạp Chí";
            this.TenTC.Name = "TenTC";
            this.TenTC.ReadOnly = true;
            this.TenTC.Width = 300;
            // 
            // ThangBD
            // 
            this.ThangBD.DataPropertyName = "ThangBD";
            this.ThangBD.HeaderText = "Tháng Bắt Đầu";
            this.ThangBD.Name = "ThangBD";
            this.ThangBD.Width = 120;
            // 
            // ThangKT
            // 
            this.ThangKT.DataPropertyName = "ThangKT";
            this.ThangKT.HeaderText = "Tháng Kết Thúc";
            this.ThangKT.Name = "ThangKT";
            this.ThangKT.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá Tháng";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 541);
            this.Controls.Add(this.gChiTietDatBao);
            this.Controls.Add(this.gPhieuDatBao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.gPhieuDatBao.ResumeLayout(false);
            this.gPhieuDatBao.PerformLayout();
            this.gChiTietDatBao.ResumeLayout(false);
            this.gChiTietDatBao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.GroupBox gPhieuDatBao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.GroupBox gChiTietDatBao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudThangBD;
        private System.Windows.Forms.NumericUpDown nudThangKT;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTapChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTong;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUpdateDB;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnDeleteDB;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnNewDB;
        private DevExpress.XtraEditors.SimpleButton btnPrevious;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnAddTC;
        private DevExpress.XtraEditors.SimpleButton btnDeleteTC;
        private System.Windows.Forms.DataGridView dgvCTDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}

