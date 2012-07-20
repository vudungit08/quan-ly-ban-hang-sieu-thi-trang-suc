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
    public partial class ChonSP : Form
    {
        DataProcess dp = new DataProcess();
        DataTable dt;
        public ChonSP()
        {
            InitializeComponent();
        }

        private void ChonSP_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            dt = new DataTable();
            dt = dp.getAllData("SELECT * FROM tblSanPham");
            dgv.DataSource = dt;
            
        }


        private void txtMaH_KeyUp(object sender, KeyEventArgs e)
        {
            dt = dp.getAllData("SELECT * FROM tblSanPham WHERE PK_MaH like '%" + txtMaH.Text + "%'");
            dgv.DataSource = dt;
        }

        private void txtTenH_KeyUp(object sender, KeyEventArgs e)
        {
            dt = dp.getAllData("SELECT * FROM tblSanPham WHERE TenH like N'%" + txtTenH.Text + "%'");
            dgv.DataSource = dt;
        }
        public delegate void SetText(string str);
        public SetText st;
        private void button1_Click(object sender, EventArgs e)
        {
            st(dgv.CurrentRow.Cells[MaH.Name].Value.ToString());
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            st(dgv.CurrentRow.Cells[MaH.Name].Value.ToString());
            this.Close();
        }

        private void ChonSP_FormClosed(object sender, FormClosedEventArgs e)
        {
            st(dgv.CurrentRow.Cells[MaH.Name].Value.ToString());
            this.Close();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            st(dgv.CurrentRow.Cells[MaH.Name].Value.ToString());
            this.Close();
        }
    }
}
