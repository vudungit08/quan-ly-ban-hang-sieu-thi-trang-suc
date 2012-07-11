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
    public partial class frmThemnhomSP : Form
    {
        string Manhom="",NhomCha="";

        public frmThemnhomSP(string NhomCha)
        {
            this.NhomCha = NhomCha;
            InitializeComponent();
        }
        public frmThemnhomSP(string NhomCha,string Manhom)
        {
   
            this.Manhom = Manhom;
            InitializeComponent();
        }

        private void frmThemnhomSP_Load(object sender, EventArgs e)
        {
            if (Manhom.Equals("")) { 
                this.Text = "Thêm Nhóm Sản phẩm";
                txtMa.Text = NhomCha;
                txtMaNhomCha.Text = NhomCha;
            }
            else
            {
                this.Text = "Sửa Nhóm sản phẩm";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
