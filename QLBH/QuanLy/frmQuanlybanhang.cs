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
        public frmQuanlybanhang()
        {
            InitializeComponent();
        }

        private void frmQuanlybanhang_Load(object sender, EventArgs e)
        {            
            
            loadInfo();
            loadAutoComplate();
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
        private void loadInfo() {
            txtShd.Text = "HD-"+(Convert.ToInt32("0"+dp.getOneData("SELECT MAX(PK_MaHD) FROM tblHoaDon").ToString())+1).ToString();
//            txtNhanvien.Text = dp.getOneData("SELECT TenNV FROM tblNhanVien WHERE PK_MaNV='"+frmMain.MaNV+"'").ToString();
        }
        private void LoadCTKM(string MaH) { 
            DataTable dt=
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
    }
}
