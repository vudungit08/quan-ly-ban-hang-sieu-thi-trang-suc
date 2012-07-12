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
        string Manhom="",NhomCha="",action="";
        DataProcess dp = new DataProcess();

        public frmThemnhomSP(string NhomCha)
        {
            this.NhomCha = NhomCha.Equals("000000")?"":NhomCha;
            InitializeComponent();
        }
        public frmThemnhomSP(string Manhom, string action)
        {

            this.action = action;
            this.Manhom = Manhom;
            InitializeComponent();
            this.txtNhom.Enabled = false;
            this.txtNhom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
                DataTable dt = dp.getAllData("getLoaibyID", new List<DbParameter> { new DbParameter("Maloai",this.Manhom) });
                if(dt.Rows.Count>0){
                    this.txtMa.Text = dt.Rows[0]["Maloai_parent"].ToString();
                    this.txtNhom.Text = dt.Rows[0]["PK_MaLoai"].ToString().Remove(0, txtMa.Text.Length);
                    this.txtTenNhom.Text = dt.Rows[0]["TenLoai"].ToString();
                    this.txtMaNhomCha.Text = txtMa.Text;
                    this.txtDiengiai.Text = dt.Rows[0]["Diengiai"].ToString();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public delegate void LoadGroup();
        public LoadGroup LG;
        private void btnCapNhat_Click(object sender, EventArgs e)
        {            
            err.Clear();
            if (txtNhom.Text.Trim().Equals("")) { err.SetError(txtNhom, "Chưa nhập mã nhóm."); return; };
            if (txtTenNhom.Text.Trim().Equals("")) { err.SetError(txtTenNhom,"Chưa nhập tên nhóm."); return; }

            if (action.Equals("sua")) {
                if (dp.executeSQL("updateLoai", new List<DbParameter> {
                                                    new DbParameter("Maloai",txtMa.Text+"-"+txtNhom.Text),
                                                    new DbParameter("Tenloai",txtTenNhom.Text),                                                    
                                                    new DbParameter("Diengiai",txtDiengiai.Text)
                                                    }) == 1)
                {
                    MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DataTable dt = dp.getAllData("getLoaibyID", new List<DbParameter> { new DbParameter("Maloai", txtMaNhomCha.Text) });
                if (dt.Rows.Count > 0)
                {
                    if (dp.executeSQL("addNewLoai", new List<DbParameter> {
                                                    new DbParameter("Maloai",txtMa.Text+"-"+txtNhom.Text),
                                                    new DbParameter("Tenloai",txtTenNhom.Text),
                                                    new DbParameter("Maloai_parent",txtMaNhomCha.Text),
                                                    new DbParameter("Bac",(Convert.ToInt32(dt.Rows[0]["Bac"].ToString())+1).ToString()),
                                                    new DbParameter("Diengiai",txtDiengiai.Text)
                                                    }) == 1)
                    {
                        MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (dp.executeSQL("addNewLoai", new List<DbParameter> {
                                                    new DbParameter("Maloai",txtNhom.Text),
                                                    new DbParameter("Tenloai",txtTenNhom.Text),
                                                    new DbParameter("Maloai_parent",txtMaNhomCha.Text),
                                                    new DbParameter("Bac","0"),
                                                    new DbParameter("Diengiai",txtDiengiai.Text)
                                                    }) == 1)
                    {
                        MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                LG();
                this.Close();
            }
        }
    }
}
