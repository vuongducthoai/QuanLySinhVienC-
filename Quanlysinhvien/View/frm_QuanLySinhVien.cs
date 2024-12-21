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
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Globalization;


namespace _LTNET.View
{
    public partial class frm_QuanLySinhVien : UserControl
    {

        
        public static frm_QuanLySinhVien uctQuanLyHocSinh = new frm_QuanLySinhVien();
        BL_SinhVien db = new BL_SinhVien();
        DataTable dt;
        int iRow = 0;
        public static Boolean save;
        public static string mahs_save;
        public static string hoten_save;
        public static string ngaysinh_save;
        public static string gioitinh_save;
        public static string quequan_save;
        public static decimal diemtb_save;
        public static string malop_save;
        public frm_QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frm_QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            HienThiHọcSinh();
        }
        private void HienThiHọcSinh()
        {
            dt = db.HienThi();
            dtGVHS.DataSource = dt;
            dtGVHS.Columns[0].HeaderText = "Mã sinh viên";
            dtGVHS.Columns[1].HeaderText = "Họ tên sinh viên";
            dtGVHS.Columns[2].HeaderText = "Ngày sinh";
            dtGVHS.Columns[3].HeaderText = "Giới tính";
            dtGVHS.Columns[4].HeaderText = "Quê quán";
            dtGVHS.Columns[5].HeaderText = "Điểm trung bình";
            dtGVHS.Columns[6].HeaderText = "Mã lớp";
            dtGVHS.Columns[0].Width = 150;
            dtGVHS.Columns[1].Width = 150;
            dtGVHS.Columns[2].Width = 100;
            dtGVHS.Columns[3].Width = 100;
            dtGVHS.Columns[4].Width = 150;
            dtGVHS.Columns[5].Width = 100;
            dtGVHS.Columns[6].Width = 100;

            try
            {
                txtmahs.Text = dt.Rows[0]["mahs"].ToString();
                txthoten.Text = dt.Rows[0]["hoten"].ToString();

                string ngaySinhStr = dt.Rows[0]["ngaysinh"].ToString();
                DateTime ngaySinh;
                if (DateTime.TryParseExact(ngaySinhStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
                {
                    dtngaysinh.Value = ngaySinh;
                }
                else
                {
                    dtngaysinh.Value = DateTime.Now; // Hoặc một giá trị mặc định khác
                }

                txtgioitinh.Text = dt.Rows[0]["gioitinh"].ToString();
                txtquequan.Text = dt.Rows[0]["quequan"].ToString();
                txtdiemtb.Text = dt.Rows[0]["diemtb"].ToString();
                txtmalop.Text = dt.Rows[0]["malop"].ToString();
            }
            catch
            {
                txtmahs.Text = "";
                txthoten.Text = "";
                dtngaysinh.Value = DateTime.Now;
                txtgioitinh.Text = "";
                txtquequan.Text = "";
                txtdiemtb.Text = "";
                txtmalop.Text = "";
            }

            frm_QuanLyTaiKhoan.CaiDatDataGridView(dtGVHS);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            save = true;
            frm_QuanLySinhVien_Sua frm = new frm_QuanLySinhVien_Sua();
            frm.Text = "Thêm mới sinh viên";
            frm.ShowDialog();
            HienThiHọcSinh();
        }

        private static readonly HashSet<string> restrictedIDs = new HashSet<string> { "SV01", "SV02", "SV03" };
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGVHS.Rows.Count == 0) return;

            DataGridViewRow row = dtGVHS.Rows[dtGVHS.CurrentCell.RowIndex];

            if (restrictedIDs.Contains(row.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Không được phép sửa dữ liệu mẫu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assign current row data to form properties
            frm_QuanLySinhVien_Sua frm = new frm_QuanLySinhVien_Sua
            {
                mahs = row.Cells[0].Value.ToString(),
                hoten = row.Cells[1].Value.ToString(),
                ngaysinh = row.Cells[2].Value.ToString(),
                gioitinh = row.Cells[3].Value.ToString(),
                quequan = row.Cells[4].Value.ToString(),
                diemtb = decimal.Parse(row.Cells[5].Value.ToString()),
                malop = row.Cells[6].Value.ToString()
            };

            frm.Text = "Sửa thông tin sinh viên";
            frm.ShowDialog();
            HienThiHọcSinh();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGVHS.Rows.Count == 0)
            {
                return;
            }
            if (dtGVHS.Rows[dtGVHS.CurrentCell.RowIndex].Cells[0].Value.ToString() == "SV01" || dtGVHS.Rows[dtGVHS.CurrentCell.RowIndex].Cells[0].Value.ToString() == "SV02" || dtGVHS.Rows[dtGVHS.CurrentCell.RowIndex].Cells[0].Value.ToString() == "SV03")
            {
                MessageBox.Show("Không được phép xóa dữ liệu mẫu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc chắn xóa dòng dữ liệu này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Xoa(dtGVHS.Rows[dtGVHS.CurrentCell.RowIndex].Cells[0].Value.ToString());
                MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                HienThiHọcSinh();
            }
            else
                return;
        }

        private void dtGVHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGVHS.Rows[e.RowIndex];
                txtmahs.Text = row.Cells[0].Value.ToString();
                txthoten.Text = row.Cells[1].Value.ToString();
                dtngaysinh.Value = DateTime.Parse(row.Cells[2].Value.ToString() + "");
                txtgioitinh.Text = row.Cells[3].Value.ToString();
                txtquequan.Text = row.Cells[4].Value.ToString();
                txtdiemtb.Text = row.Cells[5].Value.ToString();
                txtmalop.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frm_TimKiemSinhVien frm = new frm_TimKiemSinhVien();
            frm.ShowDialog();
            if(frm_TimKiemSinhVien.islog == false)
            {
                dtGVHS.DataSource = frm_TimKiemSinhVien.dtTK;
            }    
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            HienThiHọcSinh();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            dtGVHS.DataSource = db.SapXep();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            iRow = 0;
            dtGVHS.ClearSelection();
            int nRowIndex = iRow;
            dtGVHS.Rows[nRowIndex].Selected = true;
            dtGVHS.Rows[nRowIndex].Cells[0].Selected = true;
            txtmahs.Text = dt.Rows[iRow]["mahs"].ToString();
            txthoten.Text = dt.Rows[iRow]["hoten"].ToString();
            dtngaysinh.Value = DateTime.Parse(dt.Rows[iRow]["ngaysinh"].ToString() + "");
            txtgioitinh.Text = dt.Rows[iRow]["gioitinh"].ToString();
            txtquequan.Text = dt.Rows[iRow]["quequan"].ToString();
            txtdiemtb.Text = dt.Rows[iRow]["diemtb"].ToString();
            txtmalop.Text = dt.Rows[iRow]["maloplt"].ToString();
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            iRow = dtGVHS.Rows.Count - 1;
            dtGVHS.ClearSelection();
            int nRowIndex = iRow;
            dtGVHS.Rows[nRowIndex].Selected = true;
            dtGVHS.Rows[nRowIndex].Cells[0].Selected = true;
            txtmahs.Text = dt.Rows[iRow]["mahs"].ToString();
            txthoten.Text = dt.Rows[iRow]["hoten"].ToString();
            dtngaysinh.Value = DateTime.Parse(dt.Rows[iRow]["ngaysinh"].ToString() + "");
            txtgioitinh.Text = dt.Rows[iRow]["gioitinh"].ToString();
            txtquequan.Text = dt.Rows[iRow]["quequan"].ToString();
            txtdiemtb.Text = dt.Rows[iRow]["diemtb"].ToString();
            txtmalop.Text = dt.Rows[iRow]["maloplt"].ToString();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (iRow == 0)
            {
                return;
            }
            iRow = iRow - 1;
            dtGVHS.ClearSelection();
            int nRowIndex = iRow;
            dtGVHS.Rows[nRowIndex].Selected = true;
            dtGVHS.Rows[nRowIndex].Cells[0].Selected = true;
            txtmahs.Text = dt.Rows[iRow]["mahs"].ToString();
            txthoten.Text = dt.Rows[iRow]["hoten"].ToString();
            dtngaysinh.Value = DateTime.Parse(dt.Rows[iRow]["ngaysinh"].ToString() + "");
            txtgioitinh.Text = dt.Rows[iRow]["gioitinh"].ToString();
            txtquequan.Text = dt.Rows[iRow]["quequan"].ToString();
            txtdiemtb.Text = dt.Rows[iRow]["diemtb"].ToString();
            txtmalop.Text = dt.Rows[iRow]["maloplt"].ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(iRow == dtGVHS.Rows.Count - 1)
            {
                return;
            }    
            iRow = iRow + 1;
            dtGVHS.ClearSelection();
            int nRowIndex = iRow;
            dtGVHS.Rows[nRowIndex].Selected = true;
            dtGVHS.Rows[nRowIndex].Cells[0].Selected = true;
            txtmahs.Text = dt.Rows[iRow]["mahs"].ToString();
            txthoten.Text = dt.Rows[iRow]["hoten"].ToString();
            dtngaysinh.Value = DateTime.Parse(dt.Rows[iRow]["ngaysinh"].ToString() + "");
            txtgioitinh.Text = dt.Rows[iRow]["gioitinh"].ToString();
            txtquequan.Text = dt.Rows[iRow]["quequan"].ToString();
            txtdiemtb.Text = dt.Rows[iRow]["diemtb"].ToString();
            txtmalop.Text = dt.Rows[iRow]["maloplt"].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            int[] columnWidths = new int[dtGVHS.Columns.Count];

            for (int j = 0; j < dtGVHS.Columns.Count; j++)
            {
                int maxWidth = dtGVHS.Columns[j].HeaderText.Length; 
                for (int i = 0; i < dtGVHS.Rows.Count - 1; i++)
                {
                    string cellValue = dtGVHS.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                    if (cellValue.Length > maxWidth)
                    {
                        maxWidth = cellValue.Length;
                    }
                }
                columnWidths[j] = maxWidth + 3;
            }

            using (TextWriter writer = new StreamWriter(@"D:\table.txt"))
            {
                for (int j = 0; j < dtGVHS.Columns.Count; j++)
                {
                    string header = dtGVHS.Columns[j].HeaderText;
                    writer.Write(header.PadRight(columnWidths[j]));
                }
                writer.WriteLine();

                for (int i = 0; i < dtGVHS.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtGVHS.Columns.Count; j++)
                    {
                        string cellValue = dtGVHS.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;

                        if (dtGVHS.Columns[j].HeaderText.Contains("Ngày sinh") && DateTime.TryParse(cellValue, out DateTime dateValue))
                        {
                            cellValue = dateValue.ToString("MM/dd/yyyy");
                        }

                        writer.Write(cellValue.PadRight(columnWidths[j])); 
                    }
                    writer.WriteLine();
                }
            }

            MessageBox.Show("Export completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = false;

            Word.Document document = wordApp.Documents.Add();

            Word.Paragraph title = document.Content.Paragraphs.Add();
            title.Range.Text = "Student Data";
            title.Range.Font.Bold = 1;
            title.Range.Font.Size = 16;
            title.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            title.Range.InsertParagraphAfter();

            int rows = dtGVHS.Rows.Count; 
            int columns = dtGVHS.Columns.Count;
            Word.Table table = document.Tables.Add(document.Bookmarks["\\endofdoc"].Range, rows + 1, columns);

            table.Borders.Enable = 1; 

            for (int j = 0; j < columns; j++)
            {
                table.Cell(1, j + 1).Range.Text = dtGVHS.Columns[j].HeaderText;
                table.Cell(1, j + 1).Range.Bold = 1;
                table.Cell(1, j + 1).Range.Font.Size = 12;
                table.Cell(1, j + 1).Shading.BackgroundPatternColor = Word.WdColor.wdColorGray25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string cellValue = dtGVHS.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;

                    if (dtGVHS.Columns[j].HeaderText.Contains("Ngày sinh") && DateTime.TryParse(cellValue, out DateTime dateValue))
                    {
                        cellValue = dateValue.ToString("MM/dd/yyyy");
                    }

                    table.Cell(i + 2, j + 1).Range.Text = cellValue;
                    table.Cell(i + 2, j + 1).Range.Font.Size = 12;
                }
            }

            string filePath = @"D:\StudentData.docx";
            document.SaveAs2(filePath);
            document.Close();
            wordApp.Quit();

            MessageBox.Show("Export completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
