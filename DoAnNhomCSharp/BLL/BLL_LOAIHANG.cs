using DoAnNhomCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.BLL
{
    class BLL_LOAIHANG
    {
        DAL.DAL_LOAIHANG DalLH;
        frm_MatHang MH;
        public BLL_LOAIHANG(frm_MatHang fMH)
        {
            DalLH = new DAL.DAL_LOAIHANG();
            MH = fMH;
        }
        public void Bll_Data()
        {
            MH.cbb_loaiHang.DataSource = DalLH.DAL_Data();
            MH.cbb_loaiHang.DisplayMember = "TenLoaiHang";
            MH.cbb_loaiHang.ValueMember = "MaLoaiHang";
        }
    }
}
