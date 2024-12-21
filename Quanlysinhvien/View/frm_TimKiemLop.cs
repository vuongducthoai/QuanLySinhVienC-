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
    public partial class frm_TimKiemLop : Form
    {
       
        BL_Lop db = new BL_Lop();
        public static DataTable dtLop;
        public static Boolean islog = true;
        public frm_TimKiemLop()
        {
            InitializeComponent();
        }

        private void frm_TimKiemLop_Load(object sender, EventArgs e)
        {
            txttenlop.Focus();
        }

        private void frmHuy_Click(object sender, EventArgs e)
        {
            islog = true;
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            islog = false;
            dtLop = db.TimKiem(txttenlop.Text.Trim());
            this.Close();
        }
    }
}
