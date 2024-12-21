using _LTNET.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LTNET.BL
{
    public class BL_DangNhap
    {
        public DataTable DangNhap(string username, string password, string mod)
        {
            string Query = "select * from dangnhap where username='" + username + "' and password='" + password + "' and mod = N'" + mod + "'";
            return DB_Connect.Load(Query);
        }
        public DataTable MạtKhau(string password)
        {
            string Query = "select password from dangnhap WHERE password = '"+ password + "'";
            return DB_Connect.Load(Query);
        }
        public DataTable HienThi()
        {
            string Query = "select username,fullname,email,mod,state from dangnhap";
            return DB_Connect.Load(Query);
        }
        public void Xoa(string username)
        {
            string Query = string.Format(@"DELETE dangnhap WHERE username = '" + username + "'");
            DB_Connect.ExecuteNonQuery(Query);
        }
        public void Them(string username, string password, string fullname, string email, string mod, string state)
        {
            string Query = "INSERT INTO dangnhap(username,password,fullname,email,mod,state)  VALUES ( '" + username + "','" + password + "',N'" + fullname + "','" + email + "',N'" + mod + "',N'" + state + "')";
            DB_Connect.ExecuteNonQuery(Query);
        }
        public void Sua(string username,string username2, string password, string fullname, string email, string mod, string state)
        {
            string Query = "UPDATE dangnhap SET username = '" + username + "',password='" + password + "',fullname = N'" + fullname + "',email='" + email + "',mod =N'" + mod + "',state =N'" + state + "' WHERE username = '" + username2 + "'";
            DB_Connect.ExecuteNonQuery(Query);
        }
        public int KiemTraDuLieuTonTai(string username)
        {
            int i = 0;
            string Querys = "SELECT * FROM dangnhap WHERE username = '" + username + "'";
            DataTable dt = DB_Connect.Load(Querys);
            if (dt == null || dt.Rows.Count > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
            return i;
        }
        public void DoiMatKhau(string password, string username)
        {
            string Querys = string.Format(@"UPDATE dangnhap set password = '" + password + "' where username = '" + username + "'");
            DB_Connect.ExecuteNonQuery(Querys);
        }
    }
}
