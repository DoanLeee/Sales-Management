using DoAnNhomCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.BLL
{
    class BLL_TINHTHANH
    {
        DAL.DAL_TINHTHANH DalTT;
        frm_NhanVien NV;
        public BLL_TINHTHANH(frm_NhanVien fNV)
        {
            DalTT = new DAL.DAL_TINHTHANH();
            NV = fNV;
        }
        public void Bll_Data()
        {
            NV.lb_tinhThanh.DataSource = DalTT.DAL_Data();
            NV.lb_tinhThanh.DisplayMember = "TenTT";
            NV.lb_tinhThanh.ValueMember = "MaTT";
        }
    }
}
