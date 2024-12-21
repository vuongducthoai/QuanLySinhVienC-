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
    public partial class frm_QuanLyTaiKhoan : UserControl
    {
       
        public static frm_QuanLyTaiKhoan uctQuanLyTaiKhoan = new frm_QuanLyTaiKhoan();
        BL_DangNhap db = new BL_DangNhap();
        DataTable dt;
        public static Boolean save;
        public static string username_save;
        public static string password_save;
        public static string fullname_save;
        public static string email_save;
        public static string mod_save;
        public static string state_save;
        public frm_QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void frm_QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiTaiKhoan();
        }
        private void HienThiTaiKhoan()
        {
            dt = db.HienThi();
            dtGVTK.DataSource = dt;
            dtGVTK.Columns[0].HeaderText = "Tên đăng nhập";
            dtGVTK.Columns[1].HeaderText = "Họ tên người dùng";
            dtGVTK.Columns[2].HeaderText = "Email";
            dtGVTK.Columns[3].HeaderText = "Phân quyền";
            dtGVTK.Columns[4].HeaderText = "Trạng thái ";
            dtGVTK.Columns[0].Width = 150;
            dtGVTK.Columns[1].Width = 150;
            dtGVTK.Columns[2].Width = 100;
            dtGVTK.Columns[3].Width = 150;
            dtGVTK.Columns[4].Width = 100;
            try
            {
                txtusername.Text = dt.Rows[0]["username"].ToString();
                txtfullname.Text = dt.Rows[0]["fullname"].ToString();
                txtemail.Text = dt.Rows[0]["email"].ToString();
                txtmod.Text = dt.Rows[0]["mod"].ToString();
                txtstate.Text = dt.Rows[0]["state"].ToString();
            }
            catch
            {
                txtusername.Text = "";
                txtfullname.Text = "";
                txtemail.Text = "";
                txtmod.Text = "";
                txtstate.Text = "";
            }
            CaiDatDataGridView(dtGVTK);
        }
        public static void CaiDatDataGridView(DataGridView dgvMain)
        {
            dgvMain.AllowUserToAddRows = false;
            dgvMain.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMain.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMain.ColumnHeadersHeight = 30;
            dgvMain.ReadOnly = true;
            dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dgvMain.EnableHeadersVisualStyles = false;
            dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMain.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            frm_QuanLyTaiKhoan_Sua frm = new frm_QuanLyTaiKhoan_Sua();
            frm.Text = "Thêm mới tài khoản";
            frm.ShowDialog();
            HienThiTaiKhoan();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVTK.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.dtGVTK.Rows[dtGVTK.CurrentCell.RowIndex];
            save = false;
            frm_QuanLyTaiKhoan_Sua frm = new frm_QuanLyTaiKhoan_Sua();
            username_save = row.Cells[0].Value.ToString();
            if (row.Cells[0].Value.ToString() == "AD" || row.Cells[0].Value.ToString() == "US")
            {
                MessageBox.Show("Không được phép sửa dữ liệu mẫu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt2 = db.MạtKhau(row.Cells[0].Value.ToString());
            
            fullname_save = row.Cells[1].Value.ToString();
            email_save = row.Cells[2].Value.ToString();
            mod_save = row.Cells[3].Value.ToString();
            state_save = row.Cells[4].Value.ToString();
            frm.Text = "Sửa thông tin tài khoản";
            frm.ShowDialog();
            HienThiTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVTK.Rows.Count == 0)
            {
                return;
            }
            if (dtGVTK.Rows[dtGVTK.CurrentCell.RowIndex].Cells[0].Value.ToString() == "AD" || dtGVTK.Rows[dtGVTK.CurrentCell.RowIndex].Cells[0].Value.ToString() == "US")
            {
                MessageBox.Show("Không được phép xóa dữ liệu mẫu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Xoa(dtGVTK.Rows[dtGVTK.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiTaiKhoan();
            }
            else
                return;
        }

        private void dtGVTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGVTK.Rows[e.RowIndex];
                txtusername.Text = row.Cells[0].Value.ToString();
                txtfullname.Text = row.Cells[1].Value.ToString();
                txtemail.Text = row.Cells[2].Value.ToString();
                txtmod.Text = row.Cells[3].Value.ToString();
                txtstate.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
