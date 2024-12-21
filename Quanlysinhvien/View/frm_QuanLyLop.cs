using _LTNET.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LTNET.View
{
    public partial class frm_QuanLyLop : UserControl
    {
        
        public static frm_QuanLyLop uctQuanLyLop = new frm_QuanLyLop();
        BL_Lop db = new BL_Lop();
        DataTable dt;
        int iRow = 0;
        public static Boolean save;
        public static string malop_save;
        public static string tenlop_save;
        public static string email_save;
        public static string hotenlt_save;
        public frm_QuanLyLop()
        {
            InitializeComponent();
        }

        private void frm_QuanLyLop_Load(object sender, EventArgs e)
        {
            HienThiLop();
        }
        private void HienThiLop()
        {
            dt = db.HienThi();
            dtGVLop.DataSource = dt;
            dtGVLop.Columns[0].HeaderText = "Mã lớp";
            dtGVLop.Columns[1].HeaderText = "Tên lớp";
            dtGVLop.Columns[2].HeaderText = "Email lớp";
            dtGVLop.Columns[3].HeaderText = "Họ tên lớp trưởng";
            dtGVLop.Columns[0].Width = 100;
            dtGVLop.Columns[1].Width = 150;
            dtGVLop.Columns[2].Width = 150;
            dtGVLop.Columns[3].Width = 150;
            try
            {
                txtmalop.Text = dt.Rows[0]["malop"].ToString();
                txttenlop.Text = dt.Rows[0]["tenlop"].ToString();
                txtemail.Text = dt.Rows[0]["email"].ToString();
                txthotenlt.Text = dt.Rows[0]["hotenlt"].ToString();
            }
            catch
            {
                txtmalop.Text = "";
                txttenlop.Text = "";
                txtemail.Text = "";
                txthotenlt.Text = "";
            }
            frm_QuanLyTaiKhoan.CaiDatDataGridView(dtGVLop);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            frm_QuanLyLop_Sua frm = new frm_QuanLyLop_Sua();
            frm.Text = "Thêm mới lớp";
            frm.ShowDialog();
            HienThiLop();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVLop.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtGVLop.Rows[dtGVLop.CurrentCell.RowIndex];
            save = false;
            frm_QuanLyLop_Sua frm = new frm_QuanLyLop_Sua();
            malop_save = row.Cells[0].Value.ToString();
            if (row.Cells[0].Value.ToString() == "LOP01" || row.Cells[0].Value.ToString() == "LOP02")
            {
                MessageBox.Show("Không được phép sửa dữ liệu mẫu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tenlop_save = row.Cells[1].Value.ToString();
            email_save = row.Cells[2].Value.ToString();
            hotenlt_save = row.Cells[3].Value.ToString();
            frm.Text = "Sửa thông tin lớp";
            frm.ShowDialog();
            HienThiLop();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVLop.Rows.Count == 0)
            {
                return;
            }
            if (dtGVLop.Rows[dtGVLop.CurrentCell.RowIndex].Cells[0].Value.ToString() == "LOP01" || dtGVLop.Rows[dtGVLop.CurrentCell.RowIndex].Cells[0].Value.ToString() == "LOP01")
            {
                MessageBox.Show("Không được phép xóa dữ liệu mẫu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Xoa(dtGVLop.Rows[dtGVLop.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiLop();
            }
            else
                return;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            HienThiLop();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frm_TimKiemLop frm = new frm_TimKiemLop();
            frm.ShowDialog();
            if (frm_TimKiemLop.islog == false)
            {
                dtGVLop.DataSource = frm_TimKiemLop.dtLop;
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            dtGVLop.DataSource = db.SapXep();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            iRow = 0;
            dtGVLop.ClearSelection();
            int nRowIndex = iRow;
            dtGVLop.Rows[nRowIndex].Selected = true;
            dtGVLop.Rows[nRowIndex].Cells[0].Selected = true;
            txtmalop.Text = dt.Rows[iRow]["malop"].ToString();
            txttenlop.Text = dt.Rows[iRow]["tenlop"].ToString();
            txtemail.Text = dt.Rows[iRow]["email"].ToString();
            txthotenlt.Text = dt.Rows[iRow]["hotenlt"].ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (iRow == 0)
            {
                return;
            }
            iRow = iRow - 1;
            dtGVLop.ClearSelection();
            int nRowIndex = iRow;
            dtGVLop.Rows[nRowIndex].Selected = true;
            dtGVLop.Rows[nRowIndex].Cells[0].Selected = true;
            txtmalop.Text = dt.Rows[iRow]["malop"].ToString();
            txttenlop.Text = dt.Rows[iRow]["tenlop"].ToString();
            txtemail.Text = dt.Rows[iRow]["email"].ToString();
            txthotenlt.Text = dt.Rows[iRow]["hotenlt"].ToString();
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            iRow = dtGVLop.Rows.Count - 1;
            dtGVLop.ClearSelection();
            int nRowIndex = iRow;
            dtGVLop.Rows[nRowIndex].Selected = true;
            dtGVLop.Rows[nRowIndex].Cells[0].Selected = true;
            txtmalop.Text = dt.Rows[iRow]["malop"].ToString();
            txttenlop.Text = dt.Rows[iRow]["tenlop"].ToString();
            txtemail.Text = dt.Rows[iRow]["email"].ToString();
            txthotenlt.Text = dt.Rows[iRow]["hotenlt"].ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (iRow == dtGVLop.Rows.Count - 1)
            {
                return;
            }
            iRow = iRow + 1;
            dtGVLop.ClearSelection();
            int nRowIndex = iRow;
            dtGVLop.Rows[nRowIndex].Selected = true;
            dtGVLop.Rows[nRowIndex].Cells[0].Selected = true;
            txtmalop.Text = dt.Rows[iRow]["malop"].ToString();
            txttenlop.Text = dt.Rows[iRow]["tenlop"].ToString();
            txtemail.Text = dt.Rows[iRow]["email"].ToString();
            txthotenlt.Text = dt.Rows[iRow]["hotenlt"].ToString();
        }

        private void dtGVLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGVLop.Rows[e.RowIndex];
                txtmalop.Text = row.Cells[0].Value.ToString();
                txttenlop.Text = row.Cells[1].Value.ToString();
                txtemail.Text = row.Cells[2].Value.ToString();
                txthotenlt.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
