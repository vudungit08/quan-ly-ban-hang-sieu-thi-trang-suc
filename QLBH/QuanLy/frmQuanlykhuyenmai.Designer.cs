namespace QLBH.QuanLy
{
    partial class frmQuanlykhuyenmai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlykhuyenmai));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvChuongtrinh = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nav = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCapnhat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHuybo = new System.Windows.Forms.ToolStripButton();
            this.txtNgayketthuc = new System.Windows.Forms.DateTimePicker();
            this.txtNgaybatdau = new System.Windows.Forms.DateTimePicker();
            this.txtNoidun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.sttSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemLoai = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoaLoai = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongtrinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nav)).BeginInit();
            this.Nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSanpham);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(733, 438);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvChuongtrinh);
            this.splitContainer2.Panel1.Controls.Add(this.Nav);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.txtNgayketthuc);
            this.splitContainer2.Panel2.Controls.Add(this.txtNgaybatdau);
            this.splitContainer2.Panel2.Controls.Add(this.txtNoidun);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.txtTenCT);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(455, 438);
            this.splitContainer2.SplitterDistance = 252;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvChuongtrinh
            // 
            this.dgvChuongtrinh.AllowUserToAddRows = false;
            this.dgvChuongtrinh.AllowUserToDeleteRows = false;
            this.dgvChuongtrinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuongtrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuongtrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.TenCT,
            this.ngaybatdau,
            this.ngayketthuc,
            this.trangthai,
            this.noidung,
            this.MaCT});
            this.dgvChuongtrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuongtrinh.EnableHeadersVisualStyles = false;
            this.dgvChuongtrinh.Location = new System.Drawing.Point(0, 0);
            this.dgvChuongtrinh.MultiSelect = false;
            this.dgvChuongtrinh.Name = "dgvChuongtrinh";
            this.dgvChuongtrinh.ReadOnly = true;
            this.dgvChuongtrinh.RowHeadersVisible = false;
            this.dgvChuongtrinh.Size = new System.Drawing.Size(455, 227);
            this.dgvChuongtrinh.TabIndex = 0;
            this.dgvChuongtrinh.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvChuongtrinh_CellFormatting);
            this.dgvChuongtrinh.SelectionChanged += new System.EventHandler(this.dgvChuongtrinh_SelectionChanged);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stt.DataPropertyName = "tt";
            this.stt.HeaderText = "TT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 46;
            // 
            // TenCT
            // 
            this.TenCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCT.DataPropertyName = "TenCT";
            this.TenCT.HeaderText = "Tên chương trình";
            this.TenCT.Name = "TenCT";
            this.TenCT.ReadOnly = true;
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ngaybatdau.DataPropertyName = "NgayBatDau";
            this.ngaybatdau.HeaderText = "Ngày bắt đầu";
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.ReadOnly = true;
            this.ngaybatdau.Width = 72;
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ngayketthuc.DataPropertyName = "NgayKetThuc";
            this.ngayketthuc.HeaderText = "Ngày kết thúc";
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.ReadOnly = true;
            this.ngayketthuc.Width = 72;
            // 
            // trangthai
            // 
            this.trangthai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Width = 74;
            // 
            // noidung
            // 
            this.noidung.DataPropertyName = "NoiDungCT";
            this.noidung.HeaderText = "Nội dung";
            this.noidung.Name = "noidung";
            this.noidung.ReadOnly = true;
            this.noidung.Visible = false;
            // 
            // MaCT
            // 
            this.MaCT.DataPropertyName = "PK_MaKM";
            this.MaCT.HeaderText = "MaCT";
            this.MaCT.Name = "MaCT";
            this.MaCT.ReadOnly = true;
            this.MaCT.Visible = false;
            // 
            // Nav
            // 
            this.Nav.AddNewItem = null;
            this.Nav.CountItem = null;
            this.Nav.CountItemFormat = "trong số {0} Nhân viên";
            this.Nav.DeleteItem = null;
            this.Nav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator3,
            this.btnSua,
            this.toolStripSeparator4,
            this.btnCapnhat,
            this.toolStripSeparator5,
            this.btnXoa,
            this.toolStripSeparator6,
            this.btnHuybo});
            this.Nav.Location = new System.Drawing.Point(0, 227);
            this.Nav.MoveFirstItem = null;
            this.Nav.MoveLastItem = null;
            this.Nav.MoveNextItem = null;
            this.Nav.MovePreviousItem = null;
            this.Nav.Name = "Nav";
            this.Nav.PositionItem = null;
            this.Nav.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Nav.Size = new System.Drawing.Size(455, 25);
            this.Nav.TabIndex = 6;
            this.Nav.Text = "bindingNavigator1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeftAutoMirrorImage = true;
            this.btnThem.Size = new System.Drawing.Size(95, 22);
            this.btnThem.Text = "Thêm mới [F3]";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLBH.Properties.Resources.hammer_screwdriver;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 22);
            this.btnSua.Text = "Chỉnh sửa [F2]";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Image = global::QLBH.Properties.Resources.disk;
            this.btnCapnhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(94, 22);
            this.btnCapnhat.Text = "Cập nhật [F5]";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeftAutoMirrorImage = true;
            this.btnXoa.Size = new System.Drawing.Size(68, 22);
            this.btnXoa.Text = "Xóa [F6]";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHuybo
            // 
            this.btnHuybo.Image = global::QLBH.Properties.Resources.huybo;
            this.btnHuybo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(91, 20);
            this.btnHuybo.Text = "Hủy bỏ [ESC]";
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // txtNgayketthuc
            // 
            this.txtNgayketthuc.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.txtNgayketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayketthuc.Location = new System.Drawing.Point(114, 151);
            this.txtNgayketthuc.Name = "txtNgayketthuc";
            this.txtNgayketthuc.Size = new System.Drawing.Size(155, 21);
            this.txtNgayketthuc.TabIndex = 4;
            // 
            // txtNgaybatdau
            // 
            this.txtNgaybatdau.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.txtNgaybatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaybatdau.Location = new System.Drawing.Point(114, 125);
            this.txtNgaybatdau.Name = "txtNgaybatdau";
            this.txtNgaybatdau.Size = new System.Drawing.Size(155, 21);
            this.txtNgaybatdau.TabIndex = 3;
            // 
            // txtNoidun
            // 
            this.txtNoidun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoidun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoidun.Location = new System.Drawing.Point(114, 39);
            this.txtNoidun.Multiline = true;
            this.txtNoidun.Name = "txtNoidun";
            this.txtNoidun.Size = new System.Drawing.Size(326, 78);
            this.txtNoidun.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nội dung :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày kết thúc :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày bắt đầu :";
            // 
            // txtTenCT
            // 
            this.txtTenCT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCT.Location = new System.Drawing.Point(114, 12);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(326, 21);
            this.txtTenCT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chương trình :";
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.AllowUserToAddRows = false;
            this.dgvSanpham.AllowUserToDeleteRows = false;
            this.dgvSanpham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttSP,
            this.TenSP,
            this.Giamgia,
            this.MaSP});
            this.dgvSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanpham.EnableHeadersVisualStyles = false;
            this.dgvSanpham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanpham.MultiSelect = false;
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersVisible = false;
            this.dgvSanpham.Size = new System.Drawing.Size(274, 413);
            this.dgvSanpham.TabIndex = 0;
            // 
            // sttSP
            // 
            this.sttSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sttSP.DataPropertyName = "tt";
            this.sttSP.HeaderText = "TT";
            this.sttSP.Name = "sttSP";
            this.sttSP.ReadOnly = true;
            this.sttSP.Width = 46;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenH";
            this.TenSP.HeaderText = "Tên Sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // Giamgia
            // 
            this.Giamgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Giamgia.DataPropertyName = "Giamgia";
            this.Giamgia.HeaderText = "Giảm giá(%)";
            this.Giamgia.Name = "Giamgia";
            this.Giamgia.ReadOnly = true;
            this.Giamgia.Width = 87;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "FK_MaH";
            this.MaSP.HeaderText = "MASP";
            this.MaSP.Name = "MaSP";
            this.MaSP.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemLoai,
            this.toolStripSeparator1,
            this.btnXoaLoai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 413);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(274, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Image = global::QLBH.Properties.Resources.them;
            this.btnThemLoai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(71, 22);
            this.btnThemLoai.Text = "Cập nhật";
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.Image = global::QLBH.Properties.Resources.huybo;
            this.btnXoaLoai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.Size = new System.Drawing.Size(45, 22);
            this.btnXoaLoai.Text = "Xóa";
            this.btnXoaLoai.Click += new System.EventHandler(this.btnXoaLoai_Click);
            // 
            // frmQuanlykhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 438);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmQuanlykhuyenmai";
            this.Text = "Quản lý chương trình khuyễn mãi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanlykhuyenmai_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmQuanlykhuyenmai_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongtrinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nav)).EndInit();
            this.Nav.ResumeLayout(false);
            this.Nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.DataGridView dgvChuongtrinh;
        private System.Windows.Forms.TextBox txtNoidun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator Nav;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCapnhat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnHuybo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemLoai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnXoaLoai;
        private System.Windows.Forms.DateTimePicker txtNgaybatdau;
        private System.Windows.Forms.DateTimePicker txtNgayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn noidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
    }
}