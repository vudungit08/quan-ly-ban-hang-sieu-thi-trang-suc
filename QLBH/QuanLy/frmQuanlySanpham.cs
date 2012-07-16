using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QLBH.QuanLy
{
    public partial class frmQuanlySanpham : Form
    {
        DataProcess dp = new DataProcess();
        Boolean chinhsua = false;
        public frmQuanlySanpham()
        {
            InitializeComponent();
            
        }

        private void loadGroup() {
            tvLoaiSP.Nodes.Clear();
            DataTable dt = dp.getAllData("getLoaiSPparent", null);
            foreach (DataRow dr in dt.Rows) {
                TreeNode tn = new TreeNode();
                tn.Text = dr["TenLoai"].ToString();
                tn.Tag = dr["PK_MaLoai"].ToString();
                tvLoaiSP.Nodes.Add(tn);                
                loadGroupChild(dr["PK_MaLoai"].ToString(), tn);                
            }
            loadCmb();
        }
        private void loadGroupChild(string IDparent,TreeNode parent) {
            DataTable dt = dp.getAllData("getLoaiSPchild", new List<DbParameter> { new DbParameter("Maloai",IDparent) });
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode tn = new TreeNode();                
                tn.Text = dr["TenLoai"].ToString();
                tn.Tag = dr["PK_MaLoai"].ToString();
                parent.Nodes.Add(tn);
                            
                loadGroupChild(dr["PK_MaLoai"].ToString(), tn);
            }
        }
        private void loadCmb() {
            DataTable dtCmb = dp.getAllData("getLoaiSP", null);
            cmbNhomsp.DataSource = dtCmb;
            cmbNhomsp.ValueMember = "PK_MaLoai";
            cmbNhomsp.DisplayMember = "TenLoai";
        }
        private void loadGrid(string Maloai) {
            change_Status_btn(true, true, false, true, false);
            dtgv.DataSource=dp.getAllData("getSPbyIDLoai",new List<DbParameter>{new DbParameter("Maloai",Maloai)});            
            BindingSource bs=new BindingSource();
            bs.DataSource=dtgv.DataSource;
            Nav.BindingSource = bs;
            if (dtgv.Rows.Count == 0) {
                change_Status_btn(true, false, false, false, false);
            }
            cmbNhomsp.SelectedValue = tvLoaiSP.SelectedNode.Tag;

        }
        private void set_control(bool bl) {
            txtMaH.Enabled = bl;
            txtTenH.Enabled = bl;
            txtDvt.Enabled = bl;
            txtGianhap.Enabled = bl;
            txtmota.Enabled = bl;
            txtThoigianbh.Enabled = bl;
            txtTylelai.Enabled = bl;
            btnChonanh.Enabled = bl;
            cmbNhomsp.Enabled = bl;
        }
        private void change_Status_btn(bool them, bool sua, bool capnhat, bool xoa, bool huybo)
        {
            btnThem.Enabled = them;
            btnSua.Enabled = sua;
            btnXoa.Enabled = xoa;
            btnCapnhat.Enabled = capnhat;
            btnHuybo.Enabled = huybo;

        }
        private void clear_control() {
            txtMaH.Text = "";
            txtTenH.Text = "";
            txtDvt.Text = "Chiếc";
            txtGianhap.Text = "0";
            txtTylelai.Text = "0";
            txtThoigianbh.Text = "0";
            txtmota.Text = "";
        }
        private void frmQuanlySanpham_Load(object sender, EventArgs e)
        {
            //
            
            //
            loadGroup();
            this.dtgv.AutoGenerateColumns = false;
            set_control(false);
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (tvLoaiSP.SelectedNode != null)
            {
                QuanLy.frmThemnhomSP frm = new frmThemnhomSP(tvLoaiSP.SelectedNode.Tag.ToString());
                frm.LG = new frmThemnhomSP.LoadGroup(loadGroup);
                frm.ShowDialog();
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            QuanLy.frmThemnhomSP frm = new frmThemnhomSP(tvLoaiSP.SelectedNode.Tag.ToString(), "sua");
            frm.LG = new frmThemnhomSP.LoadGroup(loadGroup);
            frm.ShowDialog();
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            string ma = tvLoaiSP.SelectedNode.Tag.ToString();
            DataTable dt = dp.getAllData("getLoaiSPchild", new List<DbParameter> { new DbParameter("Maloai", ma) });
            if (ma.Equals("000000")) { MessageBox.Show("Không được phép xóa nhóm này!", "Lỗi"); return; }
            if (dt.Rows.Count > 0)
            {
                if (MessageBox.Show("Di chuyển các nhóm con của nhóm [" + tvLoaiSP.SelectedNode.Text + "] về trạng thái [Chưa phân nhóm] trước khi xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dp.executeSQL("dichuyenLoai", new List<DbParameter> { new DbParameter("MaLoai", ma) });
                    dp.executeSQL("deleteLoai", new List<DbParameter> { new DbParameter("MaLoai", ma) });
                    MessageBox.Show("Xóa thành công!");
                    loadGroup();
                }
            }
            else { 
                if(MessageBox.Show("Di chuyển các sản phẩm của nhóm ["+tvLoaiSP.SelectedNode.Text+"] về [Chưa phân nhóm] trước khi xóa?","Xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
                    dp.executeSQL("dichuyenSP", new List<DbParameter> { new DbParameter("MaLoai", ma) });
                    dp.executeSQL("deleteLoai", new List<DbParameter> { new DbParameter("MaLoai", ma) });
                    MessageBox.Show("Xóa thành công!");
                    loadGroup();

                }
            }
            
        }

        private void tvLoaiSP_AfterSelect(object sender, TreeViewEventArgs e)
        {
            clear_control();
            loadGrid(tvLoaiSP.SelectedNode.Tag.ToString());
            
        }

        private void dtgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                set_control(false);
                change_Status_btn(true, true, false, true, false);                
                txtMaH.Text = dtgv.CurrentRow.Cells[MaH.Name].Value.ToString();
                txtTenH.Text = dtgv.CurrentRow.Cells[TenH.Name].Value.ToString();
                txtDvt.Text = dtgv.CurrentRow.Cells[dvt.Name].Value.ToString();
                txtGianhap.Text = dtgv.CurrentRow.Cells[gianhap.Name].Value.ToString();
                txtTylelai.Text = dtgv.CurrentRow.Cells[tylelai.Name].Value.ToString();
                txtThoigianbh.Text = dtgv.CurrentRow.Cells[thoigianbh.Name].Value.ToString();
                txtmota.Text = dtgv.CurrentRow.Cells[Mota.Name].Value.ToString();
                anhsp.ImageLocation = System.Windows.Forms.Application.StartupPath + "/" + @dtgv.CurrentRow.Cells[anh_url.Name].Value.ToString();
            }
            catch (Exception) { return; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dtgv.Enabled = false;
            set_control(true);
            change_Status_btn(false, false, true, false, true);
            clear_control();
        }

        private void txtGianhap_TextChanged(object sender, EventArgs e)
        {
            err.Clear();
            if (txtGianhap.Text.Equals("")) { err.SetError(txtGianhap, "Chưa nhập."); return; }
            txtGiaban.Text = (Convert.ToDecimal("0" + txtGianhap.Text) + (Convert.ToDecimal("0" + txtGianhap.Text) * Convert.ToDecimal("0" + txtTylelai.Text) / 100)).ToString();
            txtGianhap.Text = string.Format("{0:0,0}", Convert.ToDecimal("0" + txtGianhap.Text));
            txtGianhap.SelectionStart = txtGianhap.Text.Length;
            
        }

        private void txtGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtTylelai_TextChanged(object sender, EventArgs e)
        {
            txtGiaban.Text = (Convert.ToDecimal("0" + txtGianhap.Text) + (Convert.ToDecimal("0" + txtGianhap.Text) * Convert.ToDecimal("0" + txtTylelai.Text) / 100)).ToString();
        }

        private void txtGiaban_TextChanged(object sender, EventArgs e)
        {
            txtGiaban.Text = string.Format("{0:0,0}", Convert.ToDecimal("0" + txtGiaban.Text));
        }

        private void btnChonanh_Click(object sender, EventArgs e)
        {
                        
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                anhsp.ImageLocation = fileOpen.FileName;
            }
        }
        private bool validate_input() {
            err.Clear();
            if (txtMaH.Text.Trim().Equals("")) { err.SetError(txtMaH, "Chưa nhập Mã hàng."); return false; }
            if (txtTenH.Text.Trim().Equals("")) {err.SetError(txtTenH,"Chưa nhập Tên hàng.");return false; }
            if (txtGianhap.Text.Trim().Equals("")) { err.SetError(txtGianhap, "Chưa nhập giá."); return false; }
            if (txtTylelai.Text.Trim().Equals("")) { err.SetError(txtTylelai, "Chưa nhập."); return false; }
            if (txtThoigianbh.Text.Trim().Equals("")) { err.SetError(txtThoigianbh, "Chưa nhập Thời gian BH."); return false; }
            return true;
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (!validate_input()) { return; }          
                if (chinhsua) {
                    if (File.Exists(anhsp.ImageLocation) && !Path.Combine(anhsp.ImageLocation,"").Equals(Path.Combine(System.Windows.Forms.Application.StartupPath + @"/Images/" + txtMaH.Text + ".jpg","")))
                    {
                        File.Copy(anhsp.ImageLocation, System.Windows.Forms.Application.StartupPath + @"/Images/" + txtMaH.Text + ".jpg", true);
                    }                    
                    if (dp.executeSQL("updateSP", new List<DbParameter> {
                                new DbParameter("MaH",txtMaH.Text),
                                new DbParameter("MaLoai",cmbNhomsp.SelectedValue.ToString()),
                                new DbParameter("TenH",txtTenH.Text),
                                new DbParameter("DonVT",txtDvt.Text),
                                new DbParameter("GiaNhap",Convert.ToDouble(txtGianhap.Text).ToString()),
                                new DbParameter("TyLeLai",txtTylelai.Text),
                                new DbParameter("ThoiGianBH",txtThoigianbh.Text),
                                new DbParameter("Mota",txtmota.Text),
                                new DbParameter("anh_url","Images/"+txtMaH.Text+".jpg")
                              }) == 1)
                    {
                        MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadGrid(tvLoaiSP.SelectedNode.Tag.ToString());
                        change_Status_btn(true, true, false, true, false);
                        set_control(false);
                        dtgv.Enabled = true;
                    }
                }
                else
                {
                  if (dp.getAllData("getSPbyID", new List<DbParameter> { new DbParameter("MaSP",txtMaH.Text)}).Rows.Count == 0)           
                  {
                        if (File.Exists(anhsp.ImageLocation))
                        {
                            File.Copy(anhsp.ImageLocation, System.Windows.Forms.Application.StartupPath + @"/Images/" + txtMaH.Text + ".jpg", true);
                        }
                        if (dp.executeSQL("addNewSP", new List<DbParameter> {
                                    new DbParameter("MaSP",txtMaH.Text),
                                    new DbParameter("Maloai",cmbNhomsp.SelectedValue.ToString()),
                                    new DbParameter("TenH",txtTenH.Text),
                                    new DbParameter("DonVT",txtDvt.Text),
                                    new DbParameter("GiaNhap",Convert.ToDouble(txtGianhap.Text).ToString()),
                                    new DbParameter("tylelai",txtTylelai.Text),
                                    new DbParameter("thoigianBH",txtThoigianbh.Text),
                                    new DbParameter("mota",txtmota.Text),
                                    new DbParameter("anh_url","Images/"+txtMaH.Text+".jpg")
                                  }) == 1)
                        {
                            MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadGrid(tvLoaiSP.SelectedNode.Tag.ToString());
                            change_Status_btn(true, true, false, true, false);
                            set_control(false);
                            dtgv.Enabled = true;
                        }
                    }
                      else
                      {
                          err.SetError(txtMaH, "Mã SP này đã có.");
                          return;
                      }
                }
           

        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            loadGrid(tvLoaiSP.SelectedNode.Tag.ToString());
            dtgv.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dtgv.Enabled = false;
            chinhsua = true;
            set_control(true);
            txtMaH.Enabled = false;
            change_Status_btn(false, false, true, false, true);
            chinhsua = true;
        }

        private void txtTylelai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtThoigianbh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xóa Sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dp.executeSQL("deleteSP", new List<DbParameter> {
                                new DbParameter("MaH",dtgv.CurrentRow.Cells[MaH.Name].Value.ToString())}) == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    loadGrid(tvLoaiSP.SelectedNode.Tag.ToString());
                }
            }
        }

        private void frmQuanlySanpham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) btnThem_Click(null, null);
            if (e.KeyCode == Keys.F2) btnSua_Click(null, null);
            if (e.KeyCode == Keys.F5) btnCapnhat_Click(null, null);
            if (e.KeyCode == Keys.F6) btnXoa_Click(null, null);
            if (e.KeyCode == Keys.Escape) btnHuybo_Click(null, null);
        }

       
    }
}
