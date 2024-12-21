using _LTNET.BL;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace _LTNET.View
{
    public partial class frm_QuanLySinhVien_Sua : Form
    {
        BL_SinhVien db = new BL_SinhVien();

        public frm_QuanLySinhVien_Sua()
        {
            InitializeComponent();
        }

        public string mahs { get; set; }
        public string hoten { get; set; }
        public string ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string quequan { get; set; }
        public decimal diemtb { get; set; }
        public string malop { get; set; }

        private void frmHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (mahs == null)
                {
                    // Adding a new student
                    db.Them(txtmahs.Text.Trim(), txthoten.Text.Trim(), dtngaysinh.Value.ToString("yyyy-MM-dd"),
                        cbogioitinh.Text.Trim(), txtquequan.Text.Trim(), nmdiemtb.Value, cbomalop.SelectedValue.ToString());
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Editing existing student
                    db.Sua(txtmahs.Text.Trim(), txthoten.Text.Trim(), dtngaysinh.Value.ToString("yyyy-MM-dd"),
                        cbogioitinh.Text.Trim(), txtquequan.Text.Trim(), nmdiemtb.Value, cbomalop.SelectedValue.ToString());
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtmahs.Text))
            {
                MessageBox.Show("Mã sinh viên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmahs.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txthoten.Text))
            {
                MessageBox.Show("Họ tên sinh viên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthoten.Focus();
                return false;
            }
            if (nmdiemtb.Value < 0)
            {
                MessageBox.Show("Điểm trung bình không được nhỏ hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmdiemtb.Focus();
                return false;
            }
            return true;
        }

        private void frm_QuanLySinhVien_Sua_Load(object sender, EventArgs e)
        {
          
        }

        private void LoadGioiTinh()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ma", typeof(string));
            dataTable.Columns.Add("ten", typeof(string));
            dataTable.Rows.Add("NAM", "Nam");
            dataTable.Rows.Add("NU", "Nữ");
            cbogioitinh.DataSource = dataTable;
            cbogioitinh.DisplayMember = "ten";
            cbogioitinh.ValueMember = "ma";
        }

        private void LoadLop()
        {
            DataTable dt = db.DanhSachLop();
            cbomalop.DataSource = dt;
            cbomalop.DisplayMember = "tenlop";
            cbomalop.ValueMember = "malop";
        }

        private void frm_QuanLySinhVien_Sua_Load_1(object sender, EventArgs e)
        {
            LoadGioiTinh();
            LoadLop();

            if (mahs != null)
            {
                txtmahs.Text = mahs;
                txthoten.Text = hoten;
                dtngaysinh.Text = ngaysinh;
                cbogioitinh.Text = gioitinh;
                txtquequan.Text = quequan;
                nmdiemtb.Value = diemtb;
                cbomalop.SelectedValue = malop;
                txtmahs.ReadOnly = true; 
            }
            else
            {
                txtmahs.ReadOnly = false;
            }
        }
    }
}