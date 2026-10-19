namespace FormChiTieu
{
    partial class FormChiTieu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            
            grpThongTin = new System.Windows.Forms.GroupBox();
            btnLamMoi = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            txtGhiChu = new System.Windows.Forms.TextBox();
            lblGhiChu = new System.Windows.Forms.Label();
            nudSoTien = new System.Windows.Forms.NumericUpDown();
            lblSoTien = new System.Windows.Forms.Label();
            txtNoiDung = new System.Windows.Forms.TextBox();
            lblNoiDung = new System.Windows.Forms.Label();
            cboLoaiChi = new System.Windows.Forms.ComboBox();
            lblLoaiChi = new System.Windows.Forms.Label();
            dtpNgayChi = new System.Windows.Forms.DateTimePicker();
            lblNgayChi = new System.Windows.Forms.Label();
            
            grpTimKiem = new System.Windows.Forms.GroupBox();
            btnTim = new System.Windows.Forms.Button();
            dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            lblDenNgay = new System.Windows.Forms.Label();
            dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            lblTuNgay = new System.Windows.Forms.Label();
            cboTimLoaiChi = new System.Windows.Forms.ComboBox();
            lblTimLoaiChi = new System.Windows.Forms.Label();
            txtTimNoiDung = new System.Windows.Forms.TextBox();
            lblTimNoiDung = new System.Windows.Forms.Label();
            
            dgvChiTieu = new System.Windows.Forms.DataGridView();
            colMaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNgayChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colLoaiChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
            lblTongChi = new System.Windows.Forms.Label();
            btnMoLogs = new System.Windows.Forms.Button();

            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).BeginInit();
            grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTieu).BeginInit();
            SuspendLayout();

            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(btnLamMoi);
            grpThongTin.Controls.Add(btnXoa);
            grpThongTin.Controls.Add(btnSua);
            grpThongTin.Controls.Add(btnThem);
            grpThongTin.Controls.Add(txtGhiChu);
            grpThongTin.Controls.Add(lblGhiChu);
            grpThongTin.Controls.Add(nudSoTien);
            grpThongTin.Controls.Add(lblSoTien);
            grpThongTin.Controls.Add(txtNoiDung);
            grpThongTin.Controls.Add(lblNoiDung);
            grpThongTin.Controls.Add(cboLoaiChi);
            grpThongTin.Controls.Add(lblLoaiChi);
            grpThongTin.Controls.Add(dtpNgayChi);
            grpThongTin.Controls.Add(lblNgayChi);
            grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            grpThongTin.Location = new System.Drawing.Point(16, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new System.Drawing.Size(550, 202);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin khoản chi";

            // 
            // lblNgayChi
            // 
            lblNgayChi.AutoSize = true;
            lblNgayChi.Location = new System.Drawing.Point(15, 27);
            lblNgayChi.Name = "lblNgayChi";
            lblNgayChi.Size = new System.Drawing.Size(61, 17);
            lblNgayChi.TabIndex = 0;
            lblNgayChi.Text = "Ngày chi";

            // 
            // dtpNgayChi
            // 
            dtpNgayChi.CustomFormat = "dd/MM/yyyy";
            dtpNgayChi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpNgayChi.Location = new System.Drawing.Point(82, 23);
            dtpNgayChi.Name = "dtpNgayChi";
            dtpNgayChi.Size = new System.Drawing.Size(140, 24);
            dtpNgayChi.TabIndex = 1;

            // 
            // lblLoaiChi
            // 
            lblLoaiChi.AutoSize = true;
            lblLoaiChi.Location = new System.Drawing.Point(240, 27);
            lblLoaiChi.Name = "lblLoaiChi";
            lblLoaiChi.Size = new System.Drawing.Size(56, 17);
            lblLoaiChi.TabIndex = 2;
            lblLoaiChi.Text = "Loại chi:";

            // 
            // cboLoaiChi
            // 
            cboLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboLoaiChi.FormattingEnabled = true;
            cboLoaiChi.Location = new System.Drawing.Point(302, 23);
            cboLoaiChi.Name = "cboLoaiChi";
            cboLoaiChi.Size = new System.Drawing.Size(232, 24);
            cboLoaiChi.TabIndex = 3;

            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new System.Drawing.Point(15, 61);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new System.Drawing.Size(62, 17);
            lblNoiDung.TabIndex = 4;
            lblNoiDung.Text = "Nội dung";

            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new System.Drawing.Point(82, 58);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new System.Drawing.Size(140, 24);
            txtNoiDung.TabIndex = 5;

            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new System.Drawing.Point(240, 61);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new System.Drawing.Size(48, 17);
            lblSoTien.TabIndex = 6;
            lblSoTien.Text = "Số tiền";

            // 
            // nudSoTien
            // 
            nudSoTien.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSoTien.Location = new System.Drawing.Point(302, 58);
            nudSoTien.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudSoTien.Name = "nudSoTien";
            nudSoTien.Size = new System.Drawing.Size(232, 24);
            nudSoTien.TabIndex = 7;
            nudSoTien.ThousandsSeparator = true;

            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new System.Drawing.Point(15, 95);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new System.Drawing.Size(51, 17);
            lblGhiChu.TabIndex = 8;
            lblGhiChu.Text = "Ghi chú";

            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new System.Drawing.Point(82, 92);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtGhiChu.Size = new System.Drawing.Size(452, 50);
            txtGhiChu.TabIndex = 9;

            // 
            // btnThem
            // 
            btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnThem.Location = new System.Drawing.Point(82, 153);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(85, 33);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // 
            // btnSua
            // 
            btnSua.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnSua.Location = new System.Drawing.Point(180, 153);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(85, 33);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;

            // 
            // btnXoa
            // 
            btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnXoa.Location = new System.Drawing.Point(278, 153);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(85, 33);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnLamMoi.Location = new System.Drawing.Point(376, 153);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new System.Drawing.Size(85, 33);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;

            // 
            // grpTimKiem
            // 
            grpTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            grpTimKiem.Controls.Add(btnTim);
            grpTimKiem.Controls.Add(dtpDenNgay);
            grpTimKiem.Controls.Add(lblDenNgay);
            grpTimKiem.Controls.Add(dtpTuNgay);
            grpTimKiem.Controls.Add(lblTuNgay);
            grpTimKiem.Controls.Add(cboTimLoaiChi);
            grpTimKiem.Controls.Add(lblTimLoaiChi);
            grpTimKiem.Controls.Add(txtTimNoiDung);
            grpTimKiem.Controls.Add(lblTimNoiDung);
            grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            grpTimKiem.Location = new System.Drawing.Point(580, 12);
            grpTimKiem.Name = "grpTimKiem";
            grpTimKiem.Size = new System.Drawing.Size(370, 202);
            grpTimKiem.TabIndex = 1;
            grpTimKiem.TabStop = false;
            grpTimKiem.Text = "Tìm kiếm";

            // 
            // lblTimNoiDung
            // 
            lblTimNoiDung.AutoSize = true;
            lblTimNoiDung.Location = new System.Drawing.Point(15, 27);
            lblTimNoiDung.Name = "lblTimNoiDung";
            lblTimNoiDung.Size = new System.Drawing.Size(53, 17);
            lblTimNoiDung.TabIndex = 0;
            lblTimNoiDung.Text = "TextBox";

            // 
            // txtTimNoiDung
            // 
            txtTimNoiDung.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTimNoiDung.Location = new System.Drawing.Point(85, 23);
            txtTimNoiDung.Name = "txtTimNoiDung";
            txtTimNoiDung.PlaceholderText = "Nhập nội dung...";
            txtTimNoiDung.Size = new System.Drawing.Size(269, 24);
            txtTimNoiDung.TabIndex = 1;

            // 
            // lblTimLoaiChi
            // 
            lblTimLoaiChi.AutoSize = true;
            lblTimLoaiChi.Location = new System.Drawing.Point(15, 61);
            lblTimLoaiChi.Name = "lblTimLoaiChi";
            lblTimLoaiChi.Size = new System.Drawing.Size(53, 17);
            lblTimLoaiChi.TabIndex = 2;
            lblTimLoaiChi.Text = "Loại chi";

            // 
            // cboTimLoaiChi
            // 
            cboTimLoaiChi.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboTimLoaiChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTimLoaiChi.FormattingEnabled = true;
            cboTimLoaiChi.Location = new System.Drawing.Point(85, 58);
            cboTimLoaiChi.Name = "cboTimLoaiChi";
            cboTimLoaiChi.Size = new System.Drawing.Size(269, 24);
            cboTimLoaiChi.TabIndex = 3;

            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Location = new System.Drawing.Point(15, 95);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new System.Drawing.Size(55, 17);
            lblTuNgay.TabIndex = 4;
            lblTuNgay.Text = "Từ ngày";

            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new System.Drawing.Point(85, 92);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new System.Drawing.Size(140, 24);
            dtpTuNgay.TabIndex = 5;

            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Location = new System.Drawing.Point(15, 133);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new System.Drawing.Size(63, 17);
            lblDenNgay.TabIndex = 6;
            lblDenNgay.Text = "Đến ngày";

            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new System.Drawing.Point(85, 130);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new System.Drawing.Size(140, 24);
            dtpDenNgay.TabIndex = 7;

            // 
            // btnTim
            // 
            btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnTim.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnTim.Location = new System.Drawing.Point(245, 126);
            btnTim.Name = "btnTim";
            btnTim.Size = new System.Drawing.Size(109, 33);
            btnTim.TabIndex = 8;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;

            // 
            // dgvChiTieu
            // 
            dgvChiTieu.AllowUserToAddRows = false;
            dgvChiTieu.AllowUserToDeleteRows = false;
            dgvChiTieu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvChiTieu.BackgroundColor = System.Drawing.SystemColors.Window;
            dgvChiTieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgvChiTieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colMaCT,
                colNgayChi,
                colNoiDung,
                colLoaiChi,
                colSoTien,
                colGhiChu
            });
            dgvChiTieu.Location = new System.Drawing.Point(16, 226);
            dgvChiTieu.MultiSelect = false;
            dgvChiTieu.Name = "dgvChiTieu";
            dgvChiTieu.ReadOnly = true;
            dgvChiTieu.RowHeadersWidth = 40;
            dgvChiTieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvChiTieu.Size = new System.Drawing.Size(934, 280);
            dgvChiTieu.TabIndex = 2;
            dgvChiTieu.CellClick += dgvChiTieu_CellClick;

            // 
            // colMaCT
            // 
            colMaCT.DataPropertyName = "MaHienThi";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            colMaCT.DefaultCellStyle = dataGridViewCellStyle1;
            colMaCT.HeaderText = "Mã";
            colMaCT.Name = "colMaCT";
            colMaCT.ReadOnly = true;
            colMaCT.Width = 80;

            // 
            // colNgayChi
            // 
            colNgayChi.DataPropertyName = "NgayChiHienThi";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            colNgayChi.DefaultCellStyle = dataGridViewCellStyle2;
            colNgayChi.HeaderText = "Ngày chi";
            colNgayChi.Name = "colNgayChi";
            colNgayChi.ReadOnly = true;
            colNgayChi.Width = 110;

            // 
            // colNoiDung
            // 
            colNoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colNoiDung.DataPropertyName = "NoiDung";
            colNoiDung.HeaderText = "Nội dung";
            colNoiDung.Name = "colNoiDung";
            colNoiDung.ReadOnly = true;

            // 
            // colLoaiChi
            // 
            colLoaiChi.DataPropertyName = "LoaiChi";
            colLoaiChi.HeaderText = "Loại chi";
            colLoaiChi.Name = "colLoaiChi";
            colLoaiChi.ReadOnly = true;
            colLoaiChi.Width = 130;

            // 
            // colSoTien
            // 
            colSoTien.DataPropertyName = "SoTienHienThi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colSoTien.DefaultCellStyle = dataGridViewCellStyle3;
            colSoTien.HeaderText = "Số tiền";
            colSoTien.Name = "colSoTien";
            colSoTien.ReadOnly = true;
            colSoTien.Width = 130;

            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.Name = "colGhiChu";
            colGhiChu.ReadOnly = true;
            colGhiChu.Width = 180;

            // 
            // lblTongChi
            // 
            lblTongChi.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblTongChi.AutoSize = true;
            lblTongChi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTongChi.ForeColor = System.Drawing.Color.Firebrick;
            lblTongChi.Location = new System.Drawing.Point(700, 518);
            lblTongChi.Name = "lblTongChi";
            lblTongChi.Size = new System.Drawing.Size(185, 25);
            lblTongChi.TabIndex = 3;
            lblTongChi.Text = "Tổng chi: 0 đ";
            lblTongChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // btnMoLogs
            // 
            btnMoLogs.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnMoLogs.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnMoLogs.Location = new System.Drawing.Point(16, 514);
            btnMoLogs.Name = "btnMoLogs";
            btnMoLogs.Size = new System.Drawing.Size(140, 30);
            btnMoLogs.TabIndex = 4;
            btnMoLogs.Text = "📁 Mở thư mục Logs";
            btnMoLogs.UseVisualStyleBackColor = true;
            btnMoLogs.Click += btnMoLogs_Click;

            // 
            // FormChiTieu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(968, 554);
            Controls.Add(btnMoLogs);
            Controls.Add(lblTongChi);
            Controls.Add(dgvChiTieu);
            Controls.Add(grpTimKiem);
            Controls.Add(grpThongTin);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            MinimumSize = new System.Drawing.Size(880, 520);
            Name = "FormChiTieu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sổ chi tiêu cá nhân";
            Load += FormChiTieu_Load;

            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoTien).EndInit();
            grpTimKiem.ResumeLayout(false);
            grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblNgayChi;
        private System.Windows.Forms.DateTimePicker dtpNgayChi;
        private System.Windows.Forms.Label lblLoaiChi;
        private System.Windows.Forms.ComboBox cboLoaiChi;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.NumericUpDown nudSoTien;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTimNoiDung;
        private System.Windows.Forms.TextBox txtTimNoiDung;
        private System.Windows.Forms.Label lblTimLoaiChi;
        private System.Windows.Forms.ComboBox cboTimLoaiChi;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnTim;

        private System.Windows.Forms.DataGridView dgvChiTieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;

        private System.Windows.Forms.Label lblTongChi;
        private System.Windows.Forms.Button btnMoLogs;
    }
}
