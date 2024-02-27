using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomCSharp.BLL
{
    class BLL_DangNhap
    {
        DAL.DAL_DangNhap Dal_DN;
        frm_DangNhap DN;
        public BLL_DangNhap(frm_DangNhap fDN)
        {
            Dal_DN = new DAL.DAL_DangNhap();
            DN = fDN;
        }
        public void Bll_DangNhap()
        {
            int ketQua = Dal_DN.Dal_DangNhap(DN.txt_tenDangNhap.Text, DN.txt_matKhau.Text );
            if (ketQua >= 1)
            {
                GUI.frm_TapHoa SV = new GUI.frm_TapHoa();
                SV.Show();
                DN.Hide();
            }
            else MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu");
        }
    }
}
