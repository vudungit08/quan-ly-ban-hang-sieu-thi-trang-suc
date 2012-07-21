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
    public partial class frmDanhSachHoaDon : Form
    {
        DataProcess dp = new DataProcess();
        public frmDanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void frmDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            this.dgv_hoadon.AutoGenerateColumns=false;
            this.dgv_chitiethoadon.AutoGenerateColumns = false;
            load_hoadon();
            if (!frmMain.IsAdmin) toolStripButton1.Enabled = false;
            else toolStripButton1.Enabled = true;
        }
        private void load_hoadon() {
            DataTable dt = dp.getAllData("SELECT TenNV,ROW_NUMBER() OVER(ORDER BY NgayLap) as stt,'HD-'+CAST(PK_MaHD AS VARCHAR(15)) as MaHD,PK_MaHD,FK_MaNV,NgayLap FROM tblHoaDon INNER JOIN tblNhanVien ON tblHoaDon.FK_MaNV=tblNhanVien.PK_MaNV WHERE tblHoaDon.FK_MaNV=N'" + frmMain.MaNV + "'");
            dgv_hoadon.DataSource = dt;
        }
        private void load_chitiethoadon(string MaHD) {
            DataTable dt = dp.getAllData("SELECT ROW_NUMBER() OVER(ORDER BY GiaBan) AS stt,Solg,KM,TenH,FK_MaH,DonVT,GiaNhap+(GiaNhap*TyLeLai/100) as Dongia,Solg *(GiaNhap+(GiaNhap*TyLeLai/100)) as Thanhtien FROM tblChiTietHoaDon INNER JOIN tblSanPham ON tblChiTietHoaDon.FK_MaH=tblSanPham.PK_MaH WHERE FK_MaHD=N'" + MaHD.Remove(0, 3) + "'");
            dgv_chitiethoadon.DataSource = dt;
        }
        private void dgv_hoadon_SelectionChanged(object sender, EventArgs e)
        {
            try {
                load_chitiethoadon(dgv_hoadon.CurrentRow.Cells[MaHD.Name].Value.ToString());
            }
            catch (Exception) { return; }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn huỷ hoá đơn này không?","Huỷ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
                dp.executeSQL("DELETE FROM tblChiTietHoaDon WHERE FK_MaHD="+dgv_hoadon.CurrentRow.Cells[MaHD.Name].Value.ToString().Remove(0,3));
                dp.executeSQL("DELETE FROM tblHoaDon WHERE PK_MaHD=" + dgv_hoadon.CurrentRow.Cells[MaHD.Name].Value.ToString().Remove(0, 3));
                MessageBox.Show("Huỷ thành công!");
                load_hoadon();
            }
        }
    }
}
