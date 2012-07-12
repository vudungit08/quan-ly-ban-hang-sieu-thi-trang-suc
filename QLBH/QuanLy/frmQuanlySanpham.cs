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
    public partial class frmQuanlySanpham : Form
    {
        DataProcess dp = new DataProcess();
        public frmQuanlySanpham()
        {
            InitializeComponent();
            
        }

        private void loadGroup() {
            tvLoaiSP.Nodes.Clear();
            DataTable dt = dp.getAllData("getLoaiSPparent", null);
            foreach (DataRow dr in dt.Rows) {
                TreeNode tn = new TreeNode();
                tn.Text = dr["TenLoai"].ToString();
                tn.Tag = dr["PK_MaLoai"].ToString();
                tvLoaiSP.Nodes.Add(tn);
                loadGroupChild(dr["PK_MaLoai"].ToString(), tn);
            }
        }
        private void loadGroupChild(string IDparent,TreeNode parent) {
            DataTable dt = dp.getAllData("getLoaiSPchild", new List<DbParameter> { new DbParameter("Maloai",IDparent) });
            foreach (DataRow dr in dt.Rows)
            {
                TreeNode tn = new TreeNode();                
                tn.Text = dr["TenLoai"].ToString();
                tn.Tag = dr["PK_MaLoai"].ToString();
                parent.Nodes.Add(tn);
                loadGroupChild(dr["PK_MaLoai"].ToString(), tn);
            }
        }
        private void frmQuanlySanpham_Load(object sender, EventArgs e)
        {
            loadGroup();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (tvLoaiSP.SelectedNode != null)
            {
                QuanLy.frmThemnhomSP frm = new frmThemnhomSP(tvLoaiSP.SelectedNode.Tag.ToString());
                frm.LG = new frmThemnhomSP.LoadGroup(loadGroup);
                frm.ShowDialog();
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {

            QuanLy.frmThemnhomSP frm = new frmThemnhomSP(tvLoaiSP.SelectedNode.Tag.ToString(), "sua");
            frm.ShowDialog();
        }

       
    }
}
