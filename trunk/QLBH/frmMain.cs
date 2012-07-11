using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmMain : Form
    {
        string MaNV = "", Matkhau = "";
        DataProcess dp = new DataProcess();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblngay.Text = "Ngày : "+DateTime.Now.ToShortDateString();
            
        }
        private void Init_User(string MaNV) {                        
            DataTable dt = dp.getAllData("dbo.getNVbyID", new List<DbParameter>() { new DbParameter("MaNV", MaNV) });
            if (dt.Rows.Count == 1) {
                this.MaNV = MaNV;
                this.Matkhau = dt.Rows[0]["Matkhau"].ToString();
                lblnhanvien.Text ="Nhân viên : "+dt.Rows[0]["TenNV"].ToString()+" - Chức vụ :"+dt.Rows[0]["Chucvu"].ToString();
            }
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            //frmLogin frm = new frmLogin();
            //frm.getID = new frmLogin.GetIDsignIn(Init_User);
            //frm.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDangxuat_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.getID = new frmLogin.GetIDsignIn(Init_User);
            frm.ShowDialog();
        }

        private void mnuDoimatkhau_Click(object sender, EventArgs e)
        {            
            HeThong.frmChangePassword frm = new HeThong.frmChangePassword(this.MaNV,this.Matkhau);            
            frm.MdiParent = this;            
            frm.Show();
        }

        private void mnuQuanlynhanvien_Click(object sender, EventArgs e)
        {
            QuanLy.frmQuanlynhanvien frm = new QLBH.QuanLy.frmQuanlynhanvien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQuanlysanpham_Click(object sender, EventArgs e)
        {
            QuanLy.frmQuanlySanpham frm = new QLBH.QuanLy.frmQuanlySanpham();
            frm.MdiParent = this;
            frm.Show();
        }

     



      
       

      
       

     
      
    }
}
