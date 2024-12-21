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
    public partial class frm_QuanLyTaiKhoan_Sua : Form
    {
      
        BL_DangNhap db = new BL_DangNhap();
        public frm_QuanLyTaiKhoan_Sua()
        {
            InitializeComponent();
        }

        private void frm_QuanLyTaiKhoan_Sua_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
            if (frm_QuanLyTaiKhoan.save == true)
            {
                LoadQuyen();
                LoadTrangThai();
            }
            else
            {
                LoadQuyen();
                LoadTrangThai();
                txtusername.Text = frm_QuanLyTaiKhoan.username_save;
                txtpassword.Text = frm_QuanLyTaiKhoan.password_save;
                txtrepassword.Text = frm_QuanLyTaiKhoan.password_save;
                txtfullname.Text = frm_QuanLyTaiKhoan.fullname_save;
                txtemail.Text = frm_QuanLyTaiKhoan.email_save;
                cbomod.Text = frm_QuanLyTaiKhoan.mod_save;
                cbostate.Text = frm_QuanLyTaiKhoan.state_save;
            } 
                
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
        private void LoadTrangThai()
        {
            DataTable dataTable = new DataTable();
            cbostate.Items.Clear();
            dataTable.Columns.Add("ma", typeof(string));
            dataTable.Columns.Add("ten", typeof(string));
            dataTable.Rows.Add("CONSUDUNG", "Còn sử dụng");
            dataTable.Rows.Add("KHONGSUDUNG", "Không sử dụng");
            cbostate.DataSource = dataTable;
            cbostate.DisplayMember = "ten";
            cbostate.ValueMember = "ma";
        }

        private void frmHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
                return;
            }
            if (txtfullname.Text == "")
            {
                MessageBox.Show("THọ tên người dùng không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfullname.Focus();
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
                return;
            }
            if ((txtpassword.Text != txtrepassword.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtrepassword.Focus();
                return;
            }
            if (frm_QuanLyTaiKhoan.save == true)
            {
                if (db.KiemTraDuLieuTonTai(txtusername.Text) == 0)
                {
                    MessageBox.Show("Thêm thất bại, Tài khoản này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(txtusername.Text.Trim(),txtpassword.Text.Trim(), txtfullname.Text.Trim(), txtemail.Text.Trim(), cbomod.Text.Trim(), cbostate.Text.Trim());
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (frm_QuanLyTaiKhoan.save == false)
            {
                if (db.KiemTraDuLieuTonTai(txtusername.Text) == 0 && txtusername.Text != frm_QuanLyTaiKhoan.username_save)
                {
                    MessageBox.Show("Sửa thất bại, Tài khoản này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Sua(txtusername.Text.Trim(), frm_QuanLyTaiKhoan.username_save, txtpassword.Text.Trim(), txtfullname.Text.Trim(), txtemail.Text.Trim(), cbomod.Text.Trim(), cbostate.Text.Trim());
                MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }
    }
}
