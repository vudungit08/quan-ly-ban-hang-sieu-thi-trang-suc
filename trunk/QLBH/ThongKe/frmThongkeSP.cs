using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH.ThongKe
{
    public partial class frmThongkeSP : Form
    {
        DataProcess dp = new DataProcess();
       
        public frmThongkeSP()
        {
            InitializeComponent();
        }

        private void frmThongkeSP_Load(object sender, EventArgs e)
        {
            dgv_t1.AutoGenerateColumns=false;
            dgv_t2.AutoGenerateColumns=false;
            dgv_t3.AutoGenerateColumns = false;
            
            cmbthang.SelectedIndex = 0;
            cmbNam.SelectedIndex = 0;
            load_Gt1();
            load_Gt2();

        }
        
        private void load_Gt1() {
            DataTable dt = dp.getAllData("SELECT TOP 10 ROW_NUMBER() OVER(ORDER BY TenH)AS stt,FK_MaH,tblSanPham.TenH,SUM(SoLg)AS soluong,SUM(soLg*(GiaBan-(GiaBan*KM/100))) AS TongGT FROM tblChiTietHoadon INNER JOIN tblSanPham ON FK_MaH=PK_MaH GROUP BY FK_MaH,tblSanPham.TenH");
            dgv_t1.DataSource = dt;
        }
        private void load_Gt2()
        {
            DataTable dt = dp.getAllData("SELECT ROW_NUMBER() OVER(ORDER BY TenH)AS stt, * FROM tblSanPham WHERE PK_MaH NOT IN(SELECT DISTINCT(FK_MaH) FROM tblChiTietHoaDon)");
            dgv_t2.DataSource = dt;
        }
        private void load_Gt3(string month,string year) {
            DataTable dt = dp.getAllData("SELECT tblSanPham.PK_MaH, tblSanPham.TenH, ISNULL(tblChiTietHoaDon.SoLg,0) as Solg, ISNULL(tblChiTietHoaDon.GiaBan,0) as GiaBan, ISNULL(tblChiTietHoaDon.KM,0) as KM, tblHoaDon.NgayLap FROM tblChiTietHoaDon INNER JOIN  tblHoaDon ON tblChiTietHoaDon.FK_MaHD = tblHoaDon.PK_MaHD RIGHT OUTER JOIN tblSanPham ON tblChiTietHoaDon.FK_MaH = tblSanPham.PK_MaH WHERE Month(NgayLap)=" + month + " AND Year(NgayLap)=" + year);
            DataTable dt_sp = dp.getAllData("SELECT * FROM tblSanPham");
            DataTable dt_source = new DataTable();
            dt_source.Columns.Add("stt", typeof(int));
            dt_source.Columns.Add("MaH", typeof(string));
            dt_source.Columns.Add("TenH", typeof(string));
            dt_source.Columns.Add("SoLg", typeof(int));
            dt_source.Columns.Add("TongGT", typeof(double));
            DataRow r_source;
            foreach(DataRow r_sp in dt_sp.Rows){
                r_source = dt_source.NewRow();
                r_source["stt"] = dt_source.Rows.Count + 1;
                r_source["MaH"] = r_sp["PK_MaH"];
                r_source["TenH"] = r_sp["TenH"];
                foreach (DataRow r in dt.Rows) {
                    if (r_sp["PK_MaH"].ToString().Equals(r["PK_MaH"].ToString())) {
                        r_source["SoLg"] = int.Parse("0" + r_source["SoLg"].ToString()) + int.Parse("0" + r["Solg"].ToString());
                        r_source["TongGT"] = double.Parse("0" + r_source["TongGT"].ToString()) + ((double.Parse("0" + r["Giaban"].ToString()) - (double.Parse("0" + r["Giaban"].ToString()) * double.Parse("0" + r["KM"].ToString()) / 100)) * double.Parse("0" + r["Solg"].ToString()));
                    }
                }
                dt_source.Rows.Add(r_source);
            }
            dgv_t3.DataSource = dt_source;
        }
   

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNam.SelectedItem != null && cmbthang.SelectedItem != null)
            {
                load_Gt3(cmbthang.SelectedItem.ToString(), cmbNam.SelectedItem.ToString());
            }

        }

        private void cmbthang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNam.SelectedItem != null && cmbthang.SelectedItem != null)
            {
                load_Gt3(cmbthang.SelectedItem.ToString(), cmbNam.SelectedItem.ToString());
            }
        }

        private void dgv_t3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
