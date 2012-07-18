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
    public partial class frmThemSPvaoCTKM : Form
    {
        DataProcess dp = new DataProcess();
        string MactKM = "";
        public frmThemSPvaoCTKM(string MaCT)
        {
            this.MactKM = MaCT;
            InitializeComponent();
        }

        private void frmThemSPvaoCTKM_Load(object sender, EventArgs e)
        {
            this.dgvGroup.AutoGenerateColumns = false;
            this.dgvSanPham.AutoGenerateColumns = false;
            lbltect.Text = "Chương trình:" + dp.getOneData("SELECT TenCT FROM tblChuongTrinhKhuyenMai WHERE PK_MaKM="+this.MactKM);
            loadGridGroup();
        }
        private void loadGridGroup() {
            DataTable dtCmb = dp.getAllData("getLoaiSP", null);
            dgvGroup.DataSource = dtCmb;
        }
        private void loadGrid(string Maloai)
        {           
            DataTable dt=dp.getAllData("getSPbyIDLoai", new List<DbParameter> { new DbParameter("Maloai", Maloai) });
            dt.Columns.Add("check_sp", typeof(Boolean));          
            dt.Columns.Add("Giamgia", typeof(Int32));          
            dgvSanPham.DataSource = dt;
            DataTable dtkm = dp.getAllData("getSPCTKhuyenmai", new List<DbParameter> { new DbParameter("MaCT", this.MactKM) });
            foreach (DataGridViewRow dr in dgvSanPham.Rows)
            {
                dr.Cells[check_sp.Name].Value = false;
                dr.Cells[giamgia.Name].Value = 0;                    
                foreach (DataRow r in dtkm.Rows)
                {
                    if(r["FK_MaH"].Equals(dr.Cells[MaH.Name].Value)){
                        dr.Cells[check_sp.Name].Value = true;
                        dr.Cells[giamgia.Name].Value = r["Giamgia"].ToString();
                    }                        
                }
            }
        }

        private void dgvGroup_SelectionChanged(object sender, EventArgs e)
        {            
            try{

                loadGrid(dgvGroup.CurrentRow.Cells[MaNhom.Name].Value.ToString());
            }catch(Exception){return;}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvSanPham.Rows)
            {
               dr.Cells[check_sp.Name].Value = true;
            }
        }

        public delegate void LoadG(string MaCT);
        public LoadG LG;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dgvSanPham.EndEdit();
            if (MessageBox.Show("Bạn có muốn cập nhật các SP này vào chương trình khuyến mãi không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                foreach(DataGridViewRow dr in dgvSanPham.Rows){                    
                    if (dr.Cells[check_sp.Name].Value.ToString().ToLower().Equals("true"))
                    {
                        dp.executeSQL("addNewSPKhuyenmai", new List<DbParameter> { 
                        new DbParameter("MaCT",this.MactKM),
                        new DbParameter("MaH",dr.Cells[MaH.Name].Value),
                        new DbParameter("Giamgia",dr.Cells[giamgia.Name].Value)
                        });
                    }
                }
                MessageBox.Show("Thêm thành công!");
                LG(this.MactKM);                
                
            }
        }

        private void dgvSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.Rows.Count > 0)
            {
                dgvSanPham.UpdateCellValue(e.ColumnIndex, e.RowIndex);                
                
                
            }
        }

        private void dgvSanPham_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.Rows.Count > 0)
            {
                dgvSanPham.UpdateCellValue(e.ColumnIndex, e.RowIndex);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemSPvaoCTKM_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F2) toolStripButton1_Click(null, null);
            if (e.KeyCode == Keys.F3) toolStripButton2_Click(null, null);
            if (e.KeyCode == Keys.Escape) toolStripButton3_Click(null, null);
        }

      
      

       

    
      
        




      


       
    }
}
