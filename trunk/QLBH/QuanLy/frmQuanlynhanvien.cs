using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH.QuanLy
{
    public partial class frmQuanlynhanvien : Form
    {
        DataProcess dp = new DataProcess();
        bool chinhsua = false;
        public frmQuanlynhanvien()
        {
            InitializeComponent();


        }

        private void frmQuanlynhanvien_Load(object sender, EventArgs e)
        {
            loadCmbChucvu();
            loadG();
        }
        private void loadG()
        {
            DataTable dt = new DataTable();
            dt = dp.getAllData("getDanhsachNV", null);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            Nav.BindingSource = bs;
            dtgr.DataSource = Nav.BindingSource;
        }

        private void loadCmbChucvu()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("chucvu", typeof(string));
            dt.Columns.Add("tenchucvu", typeof(string));
            DataRow r = dt.NewRow();
            r["chucvu"] = "ADMIN";
            r["tenchucvu"] = "Quản lý";
            dt.Rows.Add(r);
            r = dt.NewRow();
            r["chucvu"] = "NHANVIEN";
            r["tenchucvu"] = "Nhân viên bán hàng";
            dt.Rows.Add(r);

            cmbChucvu.DataSource = dt;
            cmbChucvu.DisplayMember = "tenchucvu";
            cmbChucvu.ValueMember = "chucvu";

            Chucvu.DataSource = dt;
            Chucvu.DisplayMember = "tenchucvu";
            Chucvu.ValueMember = "chucvu";
        }

        private void dtgr_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                change_Status_Input(false);
                change_Status_btn(true, true, false, true, false);
                txtMaNV.Text = dtgr.CurrentRow.Cells[1].Value.ToString();
                txtTenNV.Text = dtgr.CurrentRow.Cells[2].Value.ToString();
                txtMatkhau.Text = dtgr.CurrentRow.Cells[3].Value.ToString();
                txtNgaysinh.Text = dtgr.CurrentRow.Cells[4].Value.ToString();
                txtDiachi.Text = dtgr.CurrentRow.Cells[5].Value.ToString();
                txtSodienthoai.Text = dtgr.CurrentRow.Cells[6].Value.ToString();
                txtEmail.Text = dtgr.CurrentRow.Cells[7].Value.ToString();
                cmbChucvu.SelectedValue = dtgr.CurrentRow.Cells[8].Value.ToString();
                txtTyleHH.Text = dtgr.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception)
            {
                return;
            }

        }
        private bool Validate_Status_Input()
        {
            err.Clear();
            if (txtMaNV.Text.Trim().Equals("")) { err.SetError(txtMaNV, "Chưa nhập!"); return false; }
            if (txtTenNV.Text.Trim().Equals("")) { err.SetError(txtTenNV, "Chưa nhập!"); return false; }
            if (txtMatkhau.Text.Trim().Equals("")) { err.SetError(txtMatkhau, "Chưa nhập!"); return false; }
            if (txtNgaysinh.Text.Trim().Equals("")) { err.SetError(txtNgaysinh, "Chưa nhập!"); return false; }
            if (txtTyleHH.Text.Trim().Equals("")) { err.SetError(txtTyleHH, "Chưa nhập!"); return false; }
            return true;
        }
        private void change_Status_Input(bool bl)
        {
            txtMaNV.Enabled = bl;
            txtTenNV.Enabled = bl;
            txtMatkhau.Enabled = bl;
            txtNgaysinh.Enabled = bl;
            txtDiachi.Enabled = bl;
            txtSodienthoai.Enabled = bl;
            txtEmail.Enabled = bl;
            cmbChucvu.Enabled = bl;
            txtTyleHH.Enabled = bl;
        }
        private void change_Status_btn(bool them, bool sua, bool capnhat, bool xoa, bool huybo)
        {
            btnThem.Enabled = them;
            btnSua.Enabled = sua;
            btnXoa.Enabled = xoa;
            btnCapnhat.Enabled = capnhat;
            btnHuybo.Enabled = huybo;

        }
        private void Clear_Input()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtMatkhau.Text = "";
            txtNgaysinh.Text = "";
            txtDiachi.Text = "";
            txtSodienthoai.Text = "";
            txtEmail.Text = "";
            cmbChucvu.SelectedIndex = 0;
            txtTyleHH.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            loadG();
            dtgr.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dtgr.Enabled = false;
            chinhsua = true;
            change_Status_Input(true);
            change_Status_btn(false, false, true, false, true);
            txtMaNV.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dtgr.Enabled = false;
            change_Status_Input(true);
            change_Status_btn(false, false, true, false, true);
            Clear_Input();
        }


        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!Validate_Status_Input()) return;
            if (chinhsua)
            {
                if (dp.executeSQL("updateNV", new List<DbParameter> {
                                new DbParameter("MaNV",txtMaNV.Text),
                                new DbParameter("TenNV",txtTenNV.Text),
                                new DbParameter("Matkhau",txtMatkhau.Text),
                                new DbParameter("Ngaysinh",txtNgaysinh.Text),
                                new DbParameter("Diachi",txtDiachi.Text),
                                new DbParameter("Dienthoai",txtSodienthoai.Text),
                                new DbParameter("Email",txtEmail.Text),
                                new DbParameter("Chucvu",cmbChucvu.SelectedValue),
                                new DbParameter("TyleHH",txtTyleHH.Text)
                              }) == 1)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadG();
                    change_Status_btn(true, true, false, true, false);
                    change_Status_Input(false);
                    dtgr.Enabled = true;
                    chinhsua = false;
                }
            }
            else
            {
                if (dp.getAllData("getNVbyID", new List<DbParameter> { new DbParameter("MaNV", txtMaNV.Text) }).Rows.Count == 0)
                {
                    if (dp.executeSQL("addNewNV", new List<DbParameter> {
                                new DbParameter("MaNV",txtMaNV.Text),
                                new DbParameter("TenNV",txtTenNV.Text),
                                new DbParameter("Matkhau",txtMatkhau.Text),
                                new DbParameter("Ngaysinh",txtNgaysinh.Text),
                                new DbParameter("Diachi",txtDiachi.Text),
                                new DbParameter("Dienthoai",txtSodienthoai.Text),
                                new DbParameter("Email",txtEmail.Text),
                                new DbParameter("Chucvu",cmbChucvu.SelectedValue),
                                new DbParameter("TyleHH",txtTyleHH.Text)
                              }) == 1)
                    {
                        MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadG();
                        change_Status_btn(true, true, false, true, false);
                        change_Status_Input(false);
                        dtgr.Enabled = true;
                    }
                }
                else
                {
                    err.SetError(txtMaNV, "Mã Nhân viên này đã có.");
                    return;
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xóa NV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (dp.executeSQL("deleteNV", new List<DbParameter> {
                                new DbParameter("MaNV",txtMaNV.Text)}) == 1) {
                                    MessageBox.Show("Xóa thành công!");
                                    loadG();
                }
            }
        }

        private void frmQuanlynhanvien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) btnThem_Click(null,null);
            if (e.KeyCode == Keys.F2) btnSua_Click(null, null);
            if (e.KeyCode == Keys.F5) btnCapnhat_Click(null, null);
            if (e.KeyCode == Keys.F6) btnXoa_Click(null, null);
            if (e.KeyCode == Keys.Escape) btnThoat_Click(null, null);
        }


    }
}

