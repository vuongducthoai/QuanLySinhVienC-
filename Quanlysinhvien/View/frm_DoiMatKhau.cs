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
    public partial class frm_DoiMatKhau : UserControl
    {
      
        public static frm_DoiMatKhau uctDoiMatKhau = new frm_DoiMatKhau();
        BL_DangNhap db = new BL_DangNhap();
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtpassword_old.Text == "")
            {
                MessageBox.Show("Mật khẩu cũ không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword_old.Focus();
                return;
            }
            if (txtpassword_new.Text == "")
            {
                MessageBox.Show("Mật khẩu mới không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword_new.Focus();
                return;
            }
            if ((txtpassword_new.Text != txtpassword_renew.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword_renew.Focus();
                return;
            }
            if (txtpassword_old.Text != frmDangNhap.password_save)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword_old.Focus();
                return;
            }
            db.DoiMatKhau(txtpassword_new.Text.Trim(), frmDangNhap.username_save);
            MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtpassword_old.Text = "";
            txtpassword_new.Text = "";
            txtpassword_renew.Text = "";
            txtpassword_old.Focus();
        }
    }
}
