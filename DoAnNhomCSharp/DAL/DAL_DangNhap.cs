using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_DangNhap
    {
        LOPDUNGCHUNG lopChung;
        public DAL_DangNhap()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public int Dal_DangNhap(string tenDangNhap, string matKhau)
        {
            string sqlDN = " select count (*) from TAIKHOAN where TenDangNhap ='" + tenDangNhap
               + "' and MatKhau = '" + matKhau + "'";
            return (int)lopChung.Scalar(sqlDN);
        }
    }
}
