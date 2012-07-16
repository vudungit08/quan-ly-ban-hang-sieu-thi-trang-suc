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
        public frmQuanlykhuyenmai()
        {
            InitializeComponent();
        }

        private void frmQuanlykhuyenmai_Load(object sender, EventArgs e)
        {
            this.dgvChuongtrinh.AutoGenerateColumns = false;
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
                if (Convert.ToDateTime(dr["NgayKetThuc"].ToString()).CompareTo(DateTime.Now) < 0)
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

        private void dgvChuongtrinh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtTenCT.Text = dgvChuongtrinh.CurrentRow.Cells[TenCT.Name].Value.ToString();
                txtNoidun.Text = dgvChuongtrinh.CurrentRow.Cells[noidung.Name].Value.ToString();
                txtNgaybatdau.Text = dgvChuongtrinh.CurrentRow.Cells[ngaybatdau.Name].Value.ToString();
                txtNgayketthuc.Text = dgvChuongtrinh.CurrentRow.Cells[ngayketthuc.Name].Value.ToString();
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
            txtNgaybatdau.Text = "";
            txtNgayketthuc.Text = "";
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
            if (dp.executeSQL("addNewCTKhuyenmai", new List<DbParameter> {
                                    new DbParameter("TenCT",txtTenCT.Text),
                                    new DbParameter("NoiDungCT",txtNoidun.Text),
                                    new DbParameter("NgayBatDau",DateTime.Parse(txtNgaybatdau.Text).ToString()),
                                    new DbParameter("NgayKetThuc",DateTime.Parse(txtNgayketthuc.Text).ToString())
                                  }) == 1)
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadGridCT();
                change_Status_btn(true, true, false, true, false);
                set_control(false);
                dgvChuongtrinh.Enabled = true;
            }
        }

       
        
    }
}
