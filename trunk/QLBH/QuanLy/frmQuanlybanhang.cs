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
    public partial class frmQuanlybanhang : Form
    {
        DataProcess dp = new DataProcess();
        DataTable dtCart;
        public frmQuanlybanhang()
        {
            InitializeComponent();
        }

        private void frmQuanlybanhang_Load(object sender, EventArgs e)
        {
            this.dgv.AutoGenerateColumns = false;
            InitCart();
            loadInfo();
            loadAutoComplate();
            LoadCTKM("chuaco");
            
        }
        private void InitCart() {
            dtCart = new DataTable();
            dtCart.Columns.Add("stt",typeof(Int32));
            dtCart.Columns.Add("MaH", typeof(String));
            dtCart.Columns.Add("TenH", typeof(String));
            dtCart.Columns.Add("DVT", typeof(String));
            dtCart.Columns.Add("soluong", typeof(Int32));
            dtCart.Columns.Add("Dongia", typeof(Double));
            dtCart.Columns.Add("KM", typeof(Int32));
            dtCart.Columns.Add("Thanhtoan", typeof(Double));
            dtCart.Columns.Add("Thanhtien", typeof(Double));
        }
        private void loadAutoComplate() {
            DataTable dt = dp.getAllData("SELECT * FROM tblSanPham");
            AutoCompleteStringCollection acsc_masp = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acsc_tensp = new AutoCompleteStringCollection();
            foreach (DataRow dr in dt.Rows) {
                acsc_masp.Add(dr["PK_MaH"].ToString());
                acsc_tensp.Add(dr["TenH"].ToString());
            }
            txtMaSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMaSP.AutoCompleteCustomSource = acsc_masp;
            txtTenSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTenSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenSP.AutoCompleteCustomSource = acsc_tensp;
            
            
        }
        private void setTxtMaH(string str) {
            txtMaSP.Text = str;
        }
        private void loadInfo() {
            txtShd.Text = "HD-" + (Convert.ToInt32("0" + dp.getOneData("SELECT IDENT_CURRENT('tblHoadon')").ToString()) + 1).ToString();
            txtNhanvien.Text = dp.getOneData("SELECT TenNV FROM tblNhanVien WHERE PK_MaNV='"+frmMain.MaNV+"'").ToString();
        }
        private void LoadCTKM(string MaH) {
            DataTable dt = dp.getAllData("SELECT tblKhuyenMaiSP.FK_MaH,tblChuongTrinhKhuyenMai.TenCT,tblChuongTrinhKhuyenMai.PK_MaKM FROM tblKhuyenMaiSP INNER JOIN tblChuongTrinhKhuyenMai ON tblKhuyenMaiSP.FK_MaKM=tblChuongTrinhKhuyenMai.PK_MaKM WHERE tblKhuyenMaiSP.FK_MaH='" + MaH + "' AND CURRENT_TIMESTAMP BETWEEN tblChuongTrinhKhuyenMai.NgayBatDau AND tblChuongTrinhKhuyenMai.NgayKetThuc");
            if (dt.Rows.Count <= 0) {
                DataRow r = dt.NewRow();
                r["TenCT"] = "-- Không có chương trình KM --";
                r["PK_MaKM"] = -1;
                dt.Rows.Add(r);
            }
           
                cmbKhuyenmain.DataSource = dt;
                cmbKhuyenmain.DisplayMember = "TenCT";
                cmbKhuyenmain.ValueMember = "PK_MaKM";
            
        }
        private void CalcGiaban() {
            object tmp = dp.getOneData("SELECT (GiaNhap+(GiaNhap*TyLeLai/100)) FROM tblSanPham WHERE PK_MaH='" + txtMaSP.Text + "'");
            txtDongia.Text = string.Format("{0:0,0}", Convert.ToDecimal("0" + tmp));
        }
        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            object tmp=dp.getOneData("SELECT TenH FROM tblSanPham WHERE PK_MaH='"+txtMaSP.Text+"'");
            if (tmp != null)
            {
                txtTenSP.Text = tmp.ToString();
                CalcGiaban();
                LoadCTKM(txtMaSP.Text);
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            object tmp = dp.getOneData("SELECT PK_MaH FROM tblSanPham WHERE TenH=N'" + txtTenSP.Text + "'");
            if (tmp != null)
            {
                txtMaSP.Text = tmp.ToString();
                CalcGiaban();
            }
        }
        private void cal_Tongtien() {
            double tongtien = 0;
            foreach (DataGridViewRow vr in dgv.Rows) { 
                tongtien+=Convert.ToDouble(vr.Cells[thanhtien.Name].Value.ToString());
            }
            txtTongtien.Text = string.Format("{0:0,0}", Convert.ToDouble("0"+tongtien.ToString())) ;
            txtTongtien.SelectionStart = txtTongtien.Text.Length;
        }
        private void clear_input() {
            txtTenSP.Text = "";
            txtMaSP.Text = "";
            txtSoluong.Text = "0";
            txtDongia.Text = "0";
            txtTienKhachtra.Text = "0";
            txtTralai.Text = "0";            
            cmbKhuyenmain.DataSource = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check_duplicate = false;
            err.Clear();
            if (txtMaSP.Text.Trim().Equals("")) { err.SetError(txtMaSP, "Chưa nhập."); return; }
            if (txtTenSP.Text.Trim().Equals("")) { err.SetError(txtTenSP, "Chưa nhập."); return; }
            if (txtSoluong.Text.Trim().Equals("")) { err.SetError(txtSoluong, "Chưa nhập."); return; }
            if (txtDongia.Text.Trim().Equals("")) { err.SetError(txtDongia, "Chưa nhập."); return; }



            foreach (DataRow dr in dtCart.Rows) {
                if (dr["MaH"].ToString().ToLower().Equals(txtMaSP.Text.ToLower())) {
                    check_duplicate = true;
                    dr["soluong"] = Convert.ToInt32(dr["soluong"].ToString()) + Convert.ToInt32(txtSoluong.Text);
                    dr["Thanhtien"] = double.Parse(dr["soluong"].ToString()) * double.Parse(dr["Thanhtoan"].ToString());
                }
            }
            if (!check_duplicate)
            {
                DataRow r = dtCart.NewRow();
                r["stt"] = dtCart.Rows.Count + 1;
                r["MaH"] = txtMaSP.Text;
                r["TenH"] = txtTenSP.Text;
                r["DVT"] = dp.getOneData("SELECT DonVT FROM tblSanPham WHERE PK_MaH=N'" + txtMaSP.Text + "'").ToString();
                r["soluong"] = txtSoluong.Text;
                r["Dongia"] = txtDongia.Text;
                r["KM"] = cmbKhuyenmain.SelectedValue.ToString() == "-1" ? 0 : double.Parse(dp.getOneData("SELECT Giamgia FROM tblKhuyenMaiSP WHERE FK_MaH=N'" + txtMaSP.Text + "' AND FK_MaKM=" + cmbKhuyenmain.SelectedValue.ToString()).ToString());
                r["Thanhtoan"] = double.Parse(r["Dongia"].ToString()) - (double.Parse(r["Dongia"].ToString()) * double.Parse(r["KM"].ToString()) / 100);
                r["Thanhtien"] = double.Parse(r["soluong"].ToString()) * double.Parse(r["Thanhtoan"].ToString());
                dtCart.Rows.Add(r);
            }
            dgv.DataSource = dtCart;
            cal_Tongtien();

            clear_input();

        }

        private void txtDongia_TextChanged(object sender, EventArgs e)
        {
            txtDongia.Text = string.Format("{0:0,0}", Convert.ToDecimal("0" + txtDongia.Text));
            txtDongia.SelectionStart = txtDongia.Text.Length;
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaSP_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dp.getOneData("SELECT COUNT(*) FROM tblSanPham WHERE PK_MaH='" + txtMaSP.Text + "'").ToString()) <= 0) {
                ChonSP frm = new ChonSP();
                frm.st = new ChonSP.SetText(setTxtMaH);
                frm.ShowDialog();
            }
        }

        private void txtMaSP_DoubleClick(object sender, EventArgs e)
        {
            ChonSP frm = new ChonSP();
            frm.st = new ChonSP.SetText(setTxtMaH);
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataRow dr in dtCart.Rows)
                    {
                        if (dr["MaH"].ToString().Equals(dgv.CurrentRow.Cells[MaH.Name].Value.ToString()))
                        {
                            dr.Delete();
                            break;
                        }
                    }
                    dgv.DataSource = dtCart;
                    cal_Tongtien();
                }
            
        }

        private void txtTienKhachtra_KeyUp(object sender, KeyEventArgs e)
        {            
            txtTralai.Text = String.Format("{0:0,0}",Convert.ToDouble("0"+txtTienKhachtra.Text)-Convert.ToDouble(txtTongtien.Text));
            txtTralai.SelectionStart = txtTralai.Text.Length;
            txtTienKhachtra.Text=String.Format("{0:0,0}",Convert.ToDouble(txtTienKhachtra.Text));
            txtTienKhachtra.SelectionStart = txtTienKhachtra.Text.Length;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {            
            if (dtCart.Rows.Count > 0)
            {
                if(MessageBox.Show("Bạn muốn hủy bỏ không thanh toán hóa đơn bán hàng này ?","hủy bỏ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    this.Close();
            }else{
                this.Close();
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (dtCart.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn muốn thanh toán hóa đơn này ?", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dp.executeSQL("INSERT INTO tblHoadon(FK_MaNV,Ngaylap) VALUES(N'" + frmMain.MaNV + "','" + String.Format("{0:MM/dd/yyyy HH:mm:ss tt}", txtNgayban.Value) + "')") == 1)
                    {
                        foreach (DataRow dr in dtCart.Rows)
                        {
                            dp.executeSQL("INSERT INTO tblChiTietHoaDon(FK_MaHD,FK_MaH,SoLg,GiaBan,KM) VALUES(" + txtShd.Text.Remove(0, 3) + ",N'" + dr["MaH"].ToString() + "'," + dr["soluong"].ToString() + "," + dr["Dongia"].ToString() + ","+dr["KM"].ToString()+")");
                        }
                        MessageBox.Show("Thanh toán thành công!!");
                        dtCart.Clear();
                        dgv.DataSource = dtCart;
                        clear_input();
                        cal_Tongtien();
                    }
                }
            }
            else {
                MessageBox.Show("Chưa có sản phẩm nào để thanh toán.");
                return;
            }
        }

        private void frmQuanlybanhang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) btnThem_Click(null, null);            
            if (e.KeyCode == Keys.F5) btnThanhtoan_Click(null, null);
            if (e.KeyCode == Keys.F7) ;
            if (e.KeyCode == Keys.Escape) btnHuybo_Click(null, null);            
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) btnXoa_Click(null, null);
        }

        
    }
}
