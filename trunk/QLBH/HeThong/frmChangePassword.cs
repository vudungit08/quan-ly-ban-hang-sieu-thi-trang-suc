using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH.HeThong
{
    public partial class frmChangePassword : Form
    {
        DataProcess dp = new DataProcess();
        private string MaNV = "", Matkhau = "";
        public frmChangePassword(string MaNV,string Matkhau)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.Matkhau = Matkhau;
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (txtMaNV.Text.Trim().Equals("")){ return;}

            if (txtMatkhaucu.Text.Trim().Equals(""))
            {   err.SetError(txtMatkhaucu, "Chưa nhập mật khẩu cũ.");
                return;
            }
            
            if(!txtMatkhaucu.Text.Trim().Equals(dp.getOneData("SELECT Matkhau From tblNhanVien WHERE PK_MaNV=N'"+frmMain.MaNV+"'").ToString())) {
                err.SetError(txtMatkhaucu, "Sai mật khẩu cũ.");
                return;
            }
            if (!txtMatkhaumoi.Text.Trim().Equals(txtMatkhaumoiRE.Text.Trim())) {
                err.SetError(txtMatkhaumoi, "Hai mật khẩu mới không giống nhau.");
                return;
            }
            if (dp.executeSQL("changePassWordNV", new List<DbParameter>{new DbParameter("MaNV",this.MaNV),
                                                                    new DbParameter("Matkhaumoi",txtMatkhaumoi.Text)
                                                                    }) > 1) {
                                                                        MessageBox.Show("Mật khẩu thay đổi thành công","Thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                                                        this.Close();
            }

            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 || e.KeyCode == Keys.Enter) btnDoi_Click(null, null);
            else if (e.KeyCode == Keys.Escape) btnThoat_Click(null, null);            
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = this.MaNV;
        }
    }
}
