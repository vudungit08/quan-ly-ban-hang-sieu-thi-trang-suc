namespace QLBH.QuanLy
{
    partial class frmQuanlySanpham
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Danh mục sản phẩm", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlySanpham));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvLoaiSP = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemLoai = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSuaLoai = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoaLoai = new System.Windows.Forms.ToolStripButton();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tylelai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianbh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anh_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNhomsp = new System.Windows.Forms.ComboBox();
            this.btnChonanh = new System.Windows.Forms.Button();
            this.anhsp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoigianbh = new System.Windows.Forms.TextBox();
            this.txtTenH = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtTylelai = new System.Windows.Forms.TextBox();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.txtMaH = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.fileOpen = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nav)).BeginInit();
            this.Nav.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.tvLoaiSP);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgv);
            this.splitContainer1.Panel2.Controls.Add(this.Nav);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(862, 488);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvLoaiSP
            // 
            this.tvLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvLoaiSP.Location = new System.Drawing.Point(0, 0);
            this.tvLoaiSP.Name = "tvLoaiSP";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Node0";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Node1";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Danh mục sản phẩm";
            this.tvLoaiSP.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvLoaiSP.Size = new System.Drawing.Size(222, 463);
            this.tvLoaiSP.TabIndex = 0;
            this.tvLoaiSP.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLoaiSP_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemLoai,
            this.toolStripSeparator1,
            this.btnSuaLoai,
            this.toolStripSeparator2,
            this.btnXoaLoai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 463);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(222, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Image = global::QLBH.Properties.Resources.them;
            this.btnThemLoai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(58, 22);
            this.btnThemLoai.Text = "Thêm";
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.Image = global::QLBH.Properties.Resources.hammer_screwdriver;
            this.btnSuaLoai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.Size = new System.Drawing.Size(46, 22);
            this.btnSuaLoai.Text = "Sửa";
            this.btnSuaLoai.Click += new System.EventHandler(this.btnSuaLoai_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.Image = global::QLBH.Properties.Resources.huybo;
            this.btnXoaLoai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.Size = new System.Drawing.Size(47, 22);
            this.btnXoaLoai.Text = "Xóa";
            this.btnXoaLoai.Click += new System.EventHandler(this.btnXoaLoai_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.MaH,
            this.Maloai,
            this.TenH,
            this.dvt,
            this.gianhap,
            this.tylelai,
            this.thoigianbh,
            this.Mota,
            this.anh_url});
            this.dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv.Location = new System.Drawing.Point(0, 0);
            this.dtgv.MultiSelect = false;
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.Size = new System.Drawing.Size(636, 218);
            this.dtgv.TabIndex = 0;
            this.dtgv.SelectionChanged += new System.EventHandler(this.dtgv_SelectionChanged);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stt.DataPropertyName = "tt";
            this.stt.HeaderText = "TT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 46;
            // 
            // MaH
            // 
            this.MaH.DataPropertyName = "PK_MaH";
            this.MaH.HeaderText = "Mã SP";
            this.MaH.Name = "MaH";
            this.MaH.ReadOnly = true;
            this.MaH.Visible = false;
            // 
            // Maloai
            // 
            this.Maloai.DataPropertyName = "FK_MaLoai";
            this.Maloai.HeaderText = "Mã loại";
            this.Maloai.Name = "Maloai";
            this.Maloai.ReadOnly = true;
            this.Maloai.Visible = false;
            // 
            // TenH
            // 
            this.TenH.DataPropertyName = "TenH";
            this.TenH.HeaderText = "Tên Sản phẩm";
            this.TenH.Name = "TenH";
            this.TenH.ReadOnly = true;
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "DonVT";
            this.dvt.HeaderText = "DVT";
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            // 
            // gianhap
            // 
            this.gianhap.DataPropertyName = "GiaNhap";
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.Name = "gianhap";
            this.gianhap.ReadOnly = true;
            // 
            // tylelai
            // 
            this.tylelai.DataPropertyName = "TyLeLai";
            this.tylelai.HeaderText = "Lãi(%)";
            this.tylelai.Name = "tylelai";
            this.tylelai.ReadOnly = true;
            // 
            // thoigianbh
            // 
            this.thoigianbh.DataPropertyName = "ThoiGianBH";
            this.thoigianbh.HeaderText = "Bảo hành";
            this.thoigianbh.Name = "thoigianbh";
            this.thoigianbh.ReadOnly = true;
            // 
            // Mota
            // 
            this.Mota.DataPropertyName = "Mota";
            this.Mota.HeaderText = "Mô tả";
            this.Mota.Name = "Mota";
            this.Mota.ReadOnly = true;
            this.Mota.Visible = false;
            // 
            // anh_url
            // 
            this.anh_url.DataPropertyName = "anh_url";
            this.anh_url.HeaderText = "anh_url";
            this.anh_url.Name = "anh_url";
            this.anh_url.ReadOnly = true;
            this.anh_url.Visible = false;
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
            this.Nav.Location = new System.Drawing.Point(0, 218);
            this.Nav.MoveFirstItem = null;
            this.Nav.MoveLastItem = null;
            this.Nav.MoveNextItem = null;
            this.Nav.MovePreviousItem = null;
            this.Nav.Name = "Nav";
            this.Nav.PositionItem = null;
            this.Nav.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Nav.Size = new System.Drawing.Size(636, 25);
            this.Nav.TabIndex = 5;
            this.Nav.Text = "bindingNavigator1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.RightToLeftAutoMirrorImage = true;
            this.btnThem.Size = new System.Drawing.Size(105, 22);
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
            this.btnSua.Size = new System.Drawing.Size(103, 22);
            this.btnSua.Text = "Chỉnh sửa [F2]";
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
            this.btnCapnhat.Size = new System.Drawing.Size(98, 22);
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
            this.btnXoa.Size = new System.Drawing.Size(70, 22);
            this.btnXoa.Text = "Xóa [F6]";
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
            this.btnHuybo.Size = new System.Drawing.Size(97, 22);
            this.btnHuybo.Text = "Hủy bỏ [ESC]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbNhomsp);
            this.groupBox2.Controls.Add(this.btnChonanh);
            this.groupBox2.Controls.Add(this.anhsp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtThoigianbh);
            this.groupBox2.Controls.Add(this.txtTenH);
            this.groupBox2.Controls.Add(this.txtGiaban);
            this.groupBox2.Controls.Add(this.txtGianhap);
            this.groupBox2.Controls.Add(this.txtmota);
            this.groupBox2.Controls.Add(this.txtTylelai);
            this.groupBox2.Controls.Add(this.txtDvt);
            this.groupBox2.Controls.Add(this.txtMaH);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 245);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết :";
            // 
            // cmbNhomsp
            // 
            this.cmbNhomsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhomsp.FormattingEnabled = true;
            this.cmbNhomsp.Location = new System.Drawing.Point(288, 43);
            this.cmbNhomsp.Name = "cmbNhomsp";
            this.cmbNhomsp.Size = new System.Drawing.Size(165, 21);
            this.cmbNhomsp.TabIndex = 3;
            // 
            // btnChonanh
            // 
            this.btnChonanh.Location = new System.Drawing.Point(496, 181);
            this.btnChonanh.Name = "btnChonanh";
            this.btnChonanh.Size = new System.Drawing.Size(128, 23);
            this.btnChonanh.TabIndex = 9;
            this.btnChonanh.Text = "Chọn ảnh...";
            this.btnChonanh.UseVisualStyleBackColor = true;
            this.btnChonanh.Click += new System.EventHandler(this.btnChonanh_Click);
            // 
            // anhsp
            // 
            this.anhsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anhsp.Location = new System.Drawing.Point(496, 16);
            this.anhsp.Name = "anhsp";
            this.anhsp.Size = new System.Drawing.Size(128, 159);
            this.anhsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anhsp.TabIndex = 31;
            this.anhsp.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên SP :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "(tháng)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(217, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nhóm SP :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Thời gian BH :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Giá bán :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giá nhập :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(364, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "(%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Mô tả :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tỷ lệ lãi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Đơn VT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã SP :";
            // 
            // txtThoigianbh
            // 
            this.txtThoigianbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoigianbh.Location = new System.Drawing.Point(288, 97);
            this.txtThoigianbh.Name = "txtThoigianbh";
            this.txtThoigianbh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtThoigianbh.Size = new System.Drawing.Size(113, 21);
            this.txtThoigianbh.TabIndex = 7;
            this.txtThoigianbh.Text = "0";
            // 
            // txtTenH
            // 
            this.txtTenH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenH.Location = new System.Drawing.Point(288, 16);
            this.txtTenH.Name = "txtTenH";
            this.txtTenH.Size = new System.Drawing.Size(165, 21);
            this.txtTenH.TabIndex = 1;
            // 
            // txtGiaban
            // 
            this.txtGiaban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaban.Location = new System.Drawing.Point(81, 97);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.ReadOnly = true;
            this.txtGiaban.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGiaban.Size = new System.Drawing.Size(100, 21);
            this.txtGiaban.TabIndex = 6;
            this.txtGiaban.Text = "0";
            this.txtGiaban.TextChanged += new System.EventHandler(this.txtGiaban_TextChanged);
            // 
            // txtGianhap
            // 
            this.txtGianhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGianhap.Location = new System.Drawing.Point(81, 70);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGianhap.Size = new System.Drawing.Size(100, 21);
            this.txtGianhap.TabIndex = 4;
            this.txtGianhap.Text = "0";
            this.txtGianhap.TextChanged += new System.EventHandler(this.txtGianhap_TextChanged);
            this.txtGianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGianhap_KeyPress);
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.Location = new System.Drawing.Point(81, 125);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(397, 110);
            this.txtmota.TabIndex = 8;
            // 
            // txtTylelai
            // 
            this.txtTylelai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTylelai.Location = new System.Drawing.Point(288, 70);
            this.txtTylelai.Name = "txtTylelai";
            this.txtTylelai.Size = new System.Drawing.Size(68, 21);
            this.txtTylelai.TabIndex = 5;
            this.txtTylelai.Text = "0";
            this.txtTylelai.TextChanged += new System.EventHandler(this.txtTylelai_TextChanged);
            // 
            // txtDvt
            // 
            this.txtDvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDvt.Location = new System.Drawing.Point(81, 43);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(100, 21);
            this.txtDvt.TabIndex = 2;
            this.txtDvt.Text = "Chiếc";
            // 
            // txtMaH
            // 
            this.txtMaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaH.Location = new System.Drawing.Point(81, 16);
            this.txtMaH.Name = "txtMaH";
            this.txtMaH.Size = new System.Drawing.Size(100, 21);
            this.txtMaH.TabIndex = 0;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // fileOpen
            // 
            this.fileOpen.Filter = "(*.jpg)|*.jpg|(Tất cả các file)|*.*";
            this.fileOpen.Title = "Chọn file ảnh cho sản phẩm";
            // 
            // frmQuanlySanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 488);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanlySanpham";
            this.Text = "Quản lý sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanlySanpham_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nav)).EndInit();
            this.Nav.ResumeLayout(false);
            this.Nav.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvLoaiSP;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemLoai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSuaLoai;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnXoaLoai;
        private System.Windows.Forms.DataGridView dtgv;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThoigianbh;
        private System.Windows.Forms.TextBox txtTenH;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.TextBox txtTylelai;
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.TextBox txtMaH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.PictureBox anhsp;
        private System.Windows.Forms.Button btnChonanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tylelai;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn anh_url;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.ComboBox cmbNhomsp;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog fileOpen;
    }
}