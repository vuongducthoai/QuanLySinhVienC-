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
    public partial class frm_QuanLyLop_Sua : Form
    {
       
        BL_Lop db = new BL_Lop();
        public frm_QuanLyLop_Sua()
        {
            InitializeComponent();
        }

        private void frm_QuanLyLop_Sua_Load(object sender, EventArgs e)
        {
            txtmalop.Focus();
            if (frm_QuanLyLop.save == false)
            {
                txtmalop.Text = frm_QuanLyLop.malop_save;
                txttenlop.Text = frm_QuanLyLop.tenlop_save;
                txtemail.Text = frm_QuanLyLop.email_save;
                txthotenlt.Text = frm_QuanLyLop.hotenlt_save;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtmalop.Text == "")
            {
                MessageBox.Show("Mã lớp không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmalop.Focus();
                return;
            }
            if (txttenlop.Text == "")
            {
                MessageBox.Show("Tên lớp không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenlop.Focus();
                return;
            }
            if (frm_QuanLyLop.save == true)
            {
                if (db.KiemTraDuLieuTonTai(txtmalop.Text) == 0)
                {
                    MessageBox.Show("Thêm thất bại, Lớp này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Them(txtmalop.Text.Trim(),txttenlop.Text.Trim(),txtemail.Text.Trim(),txthotenlt.Text.Trim());
                MessageBox.Show("Thêm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            if (frm_QuanLyLop.save == false)
            {
                if (db.KiemTraDuLieuTonTai(txtmalop.Text) == 0 && txtmalop.Text != frm_QuanLyLop.malop_save)
                {
                    MessageBox.Show("Sửa thất bại, sinh viên này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.Sua(txtmalop.Text.Trim(),frm_QuanLyLop.malop_save, txttenlop.Text.Trim(), txtemail.Text.Trim(), txthotenlt.Text.Trim());
                MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }

        private void frmHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
