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
        public frmQuanlynhanvien()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            
        }

        private void frmQuanlynhanvien_Load(object sender, EventArgs e)
        {
            loadCmbChucvu();

        }
        private void loadCmbChucvu() {
            DataTable dt = new DataTable();
            dt.Columns.Add("chucvu",typeof(string));
            dt.Columns.Add("tenchucvu",typeof(string));
            DataRow r = dt.NewRow();
            r["chucvu"] = "ADMIN";
            r["tenchucvu"] = "Quản lý";
            dt.Rows.Add(r);
            r = dt.NewRow();
            r["chucvu"] = "NHANVIEN";
            r["tenchucvu"] = "Nhân viên bán hàng";
            dt.Rows.Add(r);
            Chucvu.DataSource = dt;
            Chucvu.DisplayMember = "tenchucvu";
            Chucvu.ValueMember = "chucvu";
        }

     

       
    }
}
