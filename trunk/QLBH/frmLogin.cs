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
    public partial class frmLogin : Form
    {
        DataProcess dp = new DataProcess();
        bool signIn = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
        public delegate void GetIDsignIn(string ID);
        public GetIDsignIn getID;
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (txtTendangnhap.Text.Trim().Equals("")) {
                err.SetError(txtTendangnhap, "Chưa nhập tên đăng nhập");
                return;
            }
            if (txtMatkhau.Text.Trim().Equals("")) {
                err.SetError(txtMatkhau, "Chưa nhập mật khẩu");
                return;
            }
            List<DbParameter> lst = new List<DbParameter>();
            lst.Add(new DbParameter("MaNV", ParameterDirection.Input, txtTendangnhap.Text));
            DataTable dt = dp.getAllData("dbo.getNVbyID", lst);
            if (dt.Rows.Count > 0 && dt.Rows[0]["Matkhau"].Equals(txtMatkhau.Text))
            {
                getID(txtTendangnhap.Text);
                signIn = true;
                btnThoat_Click(null, null);
            }
            else {
                MessageBox.Show("Đăng nhập không thành công!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 || e.KeyCode == Keys.Enter) btnDangnhap_Click(null, null);
            else if (e.KeyCode == Keys.Escape) btnThoat_Click(null, null);
            else if (e.Alt && e.KeyCode == Keys.F4) e.Handled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!signIn) {
                Application.Exit();
            }
        }

       

       

       

        

       
    }
}
