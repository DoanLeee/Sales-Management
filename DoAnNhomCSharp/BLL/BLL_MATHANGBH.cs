using DoAnNhomCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.BLL
{
    class BLL_MATHANGBH
    {
        DAL.DAL_MATHANGBH DalMHBH;
        frm_BanHang BH;
        public BLL_MATHANGBH(frm_BanHang fBH)
        {
            DalMHBH = new DAL.DAL_MATHANGBH();
            BH = fBH;
        }
        public void Bll_Data()
        {
            BH.cbb_tenHang.DataSource = DalMHBH.DAL_Data();
            BH.cbb_tenHang.DisplayMember = "TenHang";
            BH.cbb_tenHang.ValueMember = "MaHang";

        }
    }
}
