using DoAnNhomCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.BLL
{
    class BLL_NHANVIENBH
    {
        DAL.DAL_NHANVIENBH DalNVBH;
        frm_BanHang BH;
        public BLL_NHANVIENBH(frm_BanHang fBH)
        {
            DalNVBH = new DAL.DAL_NHANVIENBH();
            BH = fBH;
        }
        public void Bll_Data()
        {
            BH.cbb_nhanVien.DataSource = DalNVBH.DAL_Data();
            BH.cbb_nhanVien.DisplayMember = "TenNV";
            BH.cbb_nhanVien.ValueMember = "MaNV";
           
        }
    }
}
