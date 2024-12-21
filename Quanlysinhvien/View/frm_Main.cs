using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LTNET.View
{
    public partial class frm_Main : Form
    {
       
        public frm_Main()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            if(frmDangNhap.mod_save == "NGUOIDUNG")
            {
                quảnLýTàiKhoảnToolStripMenuItem.Enabled = false;
            }
            //LabelHeight(lblLeft, 32);
            //LabelHeight(lblRight, 32);
            //lblUser.Text = "Người sử dụng" + " : " + frmDangNhap.username_save;
            //lblDate.Text = "Ngày làm việc" + " : " + DateTime.Now.ToString("dd/MM/yyyy");
            ThemTabPages(View.frm_QuanLySinhVien.uctQuanLyHocSinh, 4, "QUẢN LÝ sinh viên");
        }
        public static void LabelHeight(Label label, int size)
        {
            label.AutoSize = false;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Width = 1;
            label.Height = size;
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frm_QuanLyTaiKhoan.uctQuanLyTaiKhoan, 4, "QUẢN LÝ TÀI KHOẢN");
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frm_DoiMatKhau.uctDoiMatKhau, 4, "ĐỔI MẬT KHẨU");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frm_QuanLySinhVien.uctQuanLyHocSinh, 4, "QUẢN LÝ sinh viên");
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemTabPages(View.frm_QuanLyLop.uctQuanLyLop, 4, "QUẢN LÝ LỚP");
        }

        private void menuItemDongTrang_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void menuItemDongTrangAll_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Word 2013");
            }
            catch
            {
                MessageBox.Show("Chưa đúng đường dẫn", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Excel 2013");
            }
            catch
            {
                MessageBox.Show("Chưa đúng đường dẫn", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void bảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản đang sử dụng là : 1.0", "Thông báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
