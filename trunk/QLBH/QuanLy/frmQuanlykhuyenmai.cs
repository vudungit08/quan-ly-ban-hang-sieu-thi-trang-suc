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
    public partial class frmQuanlykhuyenmai : Form
    {
        DataProcess dp = new DataProcess();
        Boolean chinhsua = false;
        public frmQuanlykhuyenmai()
        {
            InitializeComponent();
        }

        private void frmQuanlykhuyenmai_Load(object sender, EventArgs e)
        {
            this.dgvChuongtrinh.AutoGenerateColumns = false;
            this.dgvSanpham.AutoGenerateColumns = false;
            loadGridCT();
            set_control(false);
        }
        private void loadGridCT() {
            change_Status_btn(true, true, false, true, false);
            DataTable dt = new DataTable();            
            dt = dp.getAllData("getCTKhuyenmai",null);
            dt.Columns.Add("trangthai", typeof(string));            
            foreach (DataRow dr in dt.Rows)
            {
                if (DateTime.Compare(DateTime.Parse(dr["NgayKetThuc"].ToString()),DateTime.Now) < 0)
                {
                    dr["trangthai"] = "Kết thúc.";
                }
                else
                {
                    dr["trangthai"] = "Đang KM.";
                }
            }                        
            dgvChuongtrinh.DataSource = dt;
            if (dgvChuongtrinh.Rows.Count == 0)
            {
                change_Status_btn(true, false, false, false, false);
            }
        }
        private void loadGridSPKM(string MaCT) {
            DataTable dt = new DataTable();
            dt = dp.getAllData("getSPCTKhuyenmai", new List<DbParameter> { new DbParameter("MaCT",MaCT)});
            dgvSanpham.DataSource = dt;
        }

        private void dgvChuongtrinh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtTenCT.Text = dgvChuongtrinh.CurrentRow.Cells[TenCT.Name].Value.ToString();
                txtNoidun.Text = dgvChuongtrinh.CurrentRow.Cells[noidung.Name].Value.ToString();
                txtNgaybatdau.Value =DateTime.Parse(dgvChuongtrinh.CurrentRow.Cells[ngaybatdau.Name].Value.ToString());
                txtNgayketthuc.Value = DateTime.Parse(dgvChuongtrinh.CurrentRow.Cells[ngayketthuc.Name].Value.ToString());
                loadGridSPKM(dgvChuongtrinh.CurrentRow.Cells[MaCT.Name].Value.ToString());
            }
            catch (Exception) { return; }
        }
        private void set_control(bool bl)
        {
            txtTenCT.Enabled = bl;
            txtNoidun.Enabled = bl;
            txtNgaybatdau.Enabled = bl;
            txtNgayketthuc.Enabled = bl;
        }
        private void change_Status_btn(bool them, bool sua, bool capnhat, bool xoa, bool huybo)
        {
            btnThem.Enabled = them;
            btnSua.Enabled = sua;
            btnXoa.Enabled = xoa;
            btnCapnhat.Enabled = capnhat;
            btnHuybo.Enabled = huybo;

        }
        private void clear_control()
        {
            txtTenCT.Text = "";
            txtNoidun.Text = "";
            txtNgaybatdau.Value = DateTime.Now;
            txtNgayketthuc.Value = DateTime.Now;
        }

        private void dgvChuongtrinh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvChuongtrinh.Columns[e.ColumnIndex].Name.Equals(trangthai.Name)) {
                if (e.Value.Equals("Kết thúc.")) {
                    dgvChuongtrinh.Rows[e.RowIndex].Cells[TenCT.Name].Style.BackColor = Color.LightCoral;
                    dgvChuongtrinh.Rows[e.RowIndex].Cells[ngaybatdau.Name].Style.BackColor = Color.LightCoral;
                    dgvChuongtrinh.Rows[e.RowIndex].Cells[ngayketthuc.Name].Style.BackColor = Color.LightCoral;
                    dgvChuongtrinh.Rows[e.RowIndex].Cells[stt.Name].Style.BackColor = Color.LightCoral;
                    e.CellStyle.BackColor = Color.LightCoral;                    
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvChuongtrinh.Enabled = false;
            set_control(true);
            change_Status_btn(false, false, true, false, true);
            clear_control();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (chinhsua) {
                if (dp.executeSQL("updateCTKhuyenmai", new List<DbParameter> {
                                    new DbParameter("MaCT",dgvChuongtrinh.CurrentRow.Cells[MaCT.Name].Value),
                                    new DbParameter("TenCT",txtTenCT.Text),
                                    new DbParameter("NoiDungCT",txtNoidun.Text),
                                    new DbParameter("NgayBatDau",txtNgaybatdau.Value),
                                    new DbParameter("NgayKetThuc",txtNgayketthuc.Value)
                                  }) == 1)
                {
                    MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
            else
            {
                if (dp.executeSQL("addNewCTKhuyenmai", new List<DbParameter> {
                                    new DbParameter("TenCT",txtTenCT.Text),
                                    new DbParameter("NoiDungCT",txtNoidun.Text),
                                    new DbParameter("NgayBatDau",txtNgaybatdau.Value),
                                    new DbParameter("NgayKetThuc",txtNgayketthuc.Value)
                                  }) == 1)
                {
                    MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
            loadGridCT();
            change_Status_btn(true, true, false, true, false);
            set_control(false);
            dgvChuongtrinh.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Chương trình khuyễn mãi này không?\nLưu ý : Các sản phẩm thuộc chương trình khuyễn mãi này sẽ bị loại bỏ chương trình khuyễn mãi này.!", "Xóa chương trình khuyễn mãi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dp.executeSQL("deleteCTKhuyenmai", new List<DbParameter> {
                                new DbParameter("MaCT",dgvChuongtrinh.CurrentRow.Cells[MaCT.Name].Value.ToString())}) == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    loadGridCT();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvChuongtrinh.Enabled = false;            
            set_control(true);            
            change_Status_btn(false, false, true, false, true);
            chinhsua = true;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            loadGridCT();
            dgvChuongtrinh.Enabled = true;
            set_control(false); 
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            frmThemSPvaoCTKM frm = new frmThemSPvaoCTKM(dgvChuongtrinh.CurrentRow.Cells[MaCT.Name].Value.ToString());
            frm.LG = new frmThemSPvaoCTKM.LoadG(loadGridSPKM);
            frm.ShowDialog();
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
          
        }

       
        
    }
}
