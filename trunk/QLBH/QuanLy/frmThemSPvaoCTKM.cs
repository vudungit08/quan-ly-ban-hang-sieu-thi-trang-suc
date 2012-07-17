﻿using System;
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
            loadGridGroup();
        }
        private void loadGridGroup() {
            DataTable dtCmb = dp.getAllData("getLoaiSP", null);
            dgvGroup.DataSource = dtCmb;
        }
        private void loadGrid(string Maloai)
        {           
            DataTable dt=dp.getAllData("getSPbyIDLoai", new List<DbParameter> { new DbParameter("Maloai", Maloai) });          
            dt.Columns.Add("Giamgia", typeof(Int32));          
            dgvSanPham.DataSource = dt;
            foreach (DataGridViewRow dr in dgvSanPham.Rows)
            {
                dr.Cells[check_sp.Name].Value = false;
                dr.Cells[giamgia.Name].Value = 0;
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
            if (MessageBox.Show("Bạn có muốn thêm các SP này vào chương trình khuyến mãi không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
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
                this.Close();
                
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

       

    
      
        




      


       
    }
}
