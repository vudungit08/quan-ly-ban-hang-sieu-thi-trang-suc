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
        string Matkhau = "";
        public static string MaNV { set; get; }
        public static bool IsAdmin { set; get; }
        DataProcess dp = new DataProcess();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblngay.Text = "Ngày : "+DateTime.Now.ToShortDateString();
            
        }
        private void Init_menu(bool bl) {
            mnuBaocao.Enabled = bl;
            nmuThongke.Enabled = bl;
            mnuQuanglychuongtrinhkhuyenmai.Enabled = bl;
            mnuQuanlynhanvien.Enabled = bl;
            mnuQuanglychuongtrinhkhuyenmai.Enabled = bl;
            mnuQuanlysanpham.Enabled = bl;
        }
        private void Init_User(string MaNV) {                        
            DataTable dt = dp.getAllData("dbo.getNVbyID", new List<DbParameter>() { new DbParameter("MaNV", MaNV) });
            if (dt.Rows.Count == 1) {
                frmMain.MaNV = MaNV;
                this.Matkhau = dt.Rows[0]["Matkhau"].ToString();
                lblnhanvien.Text ="Nhân viên : "+dt.Rows[0]["TenNV"].ToString()+" - Chức vụ :"+(dt.Rows[0]["Chucvu"].ToString().ToLower()=="admin"?"Quản lý":"Nhân viên bán hàng");
                if (dt.Rows[0]["Chucvu"].ToString().ToLower() != "admin")
                {
                    Init_menu(false);
                    IsAdmin = false;
                }
                else { Init_menu(true); IsAdmin = true; }
            }
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.getID = new frmLogin.GetIDsignIn(Init_User);
            frm.ShowDialog();
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
            HeThong.frmChangePassword frm = new HeThong.frmChangePassword(frmMain.MaNV,this.Matkhau);            
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

        private void mnuQuanglychuongtrinhkhuyenmai_Click(object sender, EventArgs e)
        {
            QuanLy.frmQuanlykhuyenmai frm = new QLBH.QuanLy.frmQuanlykhuyenmai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQuanlybanhang_Click(object sender, EventArgs e)
        {
            QuanLy.frmQuanlybanhang frm = new QLBH.QuanLy.frmQuanlybanhang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuBaocao_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLy.frmDanhSachHoaDon frm = new QLBH.QuanLy.frmDanhSachHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thốngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe.frmThongkeSP frm = new QLBH.ThongKe.frmThongkeSP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe.frmTimKiem frm = new QLBH.ThongKe.frmTimKiem();
            frm.MdiParent = this;
            frm.Show();
        }

     



      
       

      
       

     
      
    }
}
