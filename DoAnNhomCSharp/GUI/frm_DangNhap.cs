using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomCSharp
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
            Bll_DN = new BLL.BLL_DangNhap(this);
        }
        BLL.BLL_DangNhap Bll_DN;
        private void btn_dangNhap_Click_1(object sender, EventArgs e)
        {
            Bll_DN.Bll_DangNhap();
        }

        private void txt_tenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
