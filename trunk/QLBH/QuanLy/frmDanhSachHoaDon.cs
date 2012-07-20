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
        }
        private void load_hoadon() {
            DataTable dt = dp.getAllData("SELECT TenNV,ROW_NUMBER() OVER(ORDER BY NgayLap) as stt,'HD-'+CAST(PK_MaHD AS VARCHAR(15)) as MaHD,PK_MaHD,FK_MaNV,NgayLap FROM tblHoaDon INNER JOIN tblNhanVien ON tblHoaDon.FK_MaNV=tblNhanVien.PK_MaNV WHERE tblHoaDon.FK_MaNV=N'" + frmMain.MaNV + "'");
            dgv_hoadon.DataSource = dt;
        }
    }
}
