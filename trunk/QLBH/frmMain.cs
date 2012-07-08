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
            List<DbParameter> lst = new List<DbParameter>();
            lst.Add(new DbParameter("MaNV", ParameterDirection.Input, MaNV));
            DataTable dt = dp.getAllData("dbo.getNVbyID", lst);
            if (dt.Rows.Count == 1) {
                lblnhanvien.Text ="Nhân viên :"+dt.Rows[0]["TenNV"].ToString()+" - Chức vụ:"+dt.Rows[0]["Chucvu"].ToString();
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

      
       

      
       

     
      
    }
}
