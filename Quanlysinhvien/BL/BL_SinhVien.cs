using _LTNET.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LTNET.BL
{
    public class BL_SinhVien
    {

        public DataTable HienThi()
        {
            string Query = "select * from hocsinh";
            return DB_Connect.Load(Query);
        }
        public DataTable DanhSachLop()
        {
            string Query = "select * from lop";
            return DB_Connect.Load(Query);
        }
        public DataTable TimKiem(string hoten, string quequan)
        {
            string Query = "select * from hocsinh WHERE hoten like N'%"+ hoten + "%' and quequan like N'%"+ quequan + "%'";
            return DB_Connect.Load(Query);
        }
        public DataTable SapXep()
        {
            string Query = "select * from hocsinh order by diemtb desc";
            return DB_Connect.Load(Query);
        }
        public void Xoa(string mahs)
        {
            string Query = string.Format(@"DELETE hocsinh WHERE mahs = '" + mahs + "'");
            DB_Connect.ExecuteNonQuery(Query);
        }
        public void Them(string mahs, string hoten, string ngaysinh, string gioitinh, string quequan, Decimal diemtb, string malop)
        {
            string Query = "INSERT INTO hocsinh(mahs, hoten, ngaysinh, gioitinh, quequan, diemtb, maloplt) VALUES (@mahs, @hoten, @ngaysinh, @gioitinh, @quequan, @diemtb, @malop)";

            string connectionString = DB_Connect.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(Query, connection))
                {
                    cmd.Parameters.AddWithValue("@mahs", mahs);
                    cmd.Parameters.AddWithValue("@hoten", hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@quequan", quequan);
                    cmd.Parameters.AddWithValue("@diemtb", diemtb);
                    cmd.Parameters.AddWithValue("@malop", malop);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public void Sua(string mahs, string hoten, string ngaysinh, string gioitinh, string quequan, Decimal diemtb, string malop)
        {
            string query = "UPDATE hocsinh SET hoten = @hoten, ngaysinh = @ngaysinh, gioitinh = @gioitinh, quequan = @quequan, diemtb = @diemtb, maloplt = @malop WHERE mahs = @mahs";
            string connectionString = DB_Connect.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@mahs", mahs);
                    cmd.Parameters.AddWithValue("@hoten", hoten);
                    cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                    cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
                    cmd.Parameters.AddWithValue("@quequan", quequan);
                    cmd.Parameters.AddWithValue("@diemtb", diemtb);
                    cmd.Parameters.AddWithValue("@malop", malop);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public int KiemTraDuLieuTonTai(string mahs)
        {
            int i = 0;
            string Querys = "SELECT * FROM hocsinh WHERE mahs = '" + mahs + "'";  

            DataTable dt = DB_Connect.Load(Querys);

            if (dt != null && dt.Rows.Count > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }

            return i;
        }


    }
}
