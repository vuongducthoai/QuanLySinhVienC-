using _LTNET.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LTNET.BL
{
    public class BL_Lop
    {

        public DataTable HienThi()
        {
            string Query = "select * from lop";
            return DB_Connect.Load(Query);
        }

        public DataTable TimKiem(string tenlop)
        {
            string Query = "select * from lop WHERE tenlop like N'%" + tenlop + "%'";
            return DB_Connect.Load(Query);
        }
        public DataTable SapXep()
        {
            string Query = "select * from lop order by tenlop";
            return DB_Connect.Load(Query);
        }
        public void Xoa(string malop)
        {
            string Query = string.Format(@"DELETE lop WHERE malop = '" + malop + "'");
            DB_Connect.ExecuteNonQuery(Query);
        }
        public void Them(string malop, string tenlop, string email, string hotenlt)
        {
            string Query = "INSERT INTO lop(malop,tenlop,email,hotenlt)  VALUES ( '" + malop + "',N'" + tenlop + "','" + email + "',N'" + hotenlt + "')";
            DB_Connect.ExecuteNonQuery(Query);
        }
        public void Sua(string malop, string malop2, string tenlop, string email, string hotenlt)
        {
            string Query = "UPDATE lop SET malop = '" + malop + "',tenlop=N'" + tenlop + "',email = '" + email + "',hotenlt=N'" + hotenlt + "' WHERE malop = '" + malop2 + "'";
            DB_Connect.ExecuteNonQuery(Query);
        }
        public int KiemTraDuLieuTonTai(string malop)
        {
            int i = 0;
            string Querys = "SELECT * FROM lop WHERE malop = '" + malop + "'";
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
    }
}
