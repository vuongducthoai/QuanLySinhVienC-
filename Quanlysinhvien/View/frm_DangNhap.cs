using _LTNET.BL;
using _LTNET.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LTNET
{
    public partial class frmDangNhap : Form
    {
     
        
        BL_DangNhap db = new BL_DangNhap();
        public static string username_save;
        public static string password_save;
        public static string mod_save;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }
        private void LoadQuyen()
        {
            DataTable dataTable = new DataTable();
            cbomod.Items.Clear();
            dataTable.Columns.Add("ma", typeof(string));
            dataTable.Columns.Add("ten", typeof(string));
            dataTable.Rows.Add("QUANLY", "Quản trị viên");
            dataTable.Rows.Add("NGUOIDUNG", "Người dùng");
            cbomod.DataSource = dataTable;
            cbomod.DisplayMember = "ten";
            cbomod.ValueMember = "ma";
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
            LoadQuyen();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Mã đăng nhập không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
                return;
            }
            DataTable dt = new DataTable();
            dt = db.DangNhap(txtusername.Text.Trim(), txtpassword.Text.Trim(), cbomod.Text.ToString());
            if (dt == null || dt.Rows.Count > 0)
            {
                this.Hide();
                frm_Main frm = new frm_Main();
                username_save = txtusername.Text.Trim();
                password_save = txtpassword.Text.Trim();
                mod_save = cbomod.SelectedValue.ToString();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Không đúng tên người dùng hoặc mật khẩu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
            }
        }
    }
}
