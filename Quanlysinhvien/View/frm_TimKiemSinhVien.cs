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
    public partial class frm_TimKiemSinhVien : Form
    {
       
        BL_SinhVien db = new BL_SinhVien();
        public static DataTable dtTK;
        public static Boolean islog = true;
        public frm_TimKiemSinhVien()
        {
            InitializeComponent();
        }

        private void frmHuy_Click(object sender, EventArgs e)
        {
            islog = true;
            this.Close();
        }

        private void frm_TimKiemHocSinh_Load(object sender, EventArgs e)
        {
            txthoten.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            islog = false;
            dtTK = db.TimKiem(txthoten.Text.Trim(),txtquequan.Text.Trim());
            this.Close();
        }
    }
}
