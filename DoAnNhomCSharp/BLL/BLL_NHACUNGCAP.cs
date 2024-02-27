using DoAnNhomCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.BLL
{
    class BLL_NHACUNGCAP
    {
        DAL.DAL_NHACUNGCAP DalNCC;
        frm_MatHang MH;
        public BLL_NHACUNGCAP(frm_MatHang fMH)
        {
            DalNCC = new DAL.DAL_NHACUNGCAP();
            MH = fMH;
        }
        public void Bll_Data()
        {
            MH.lb_nhaCungCap.DataSource = DalNCC.DAL_Data();
            MH.lb_nhaCungCap.DisplayMember = "TenNCC";
            MH.lb_nhaCungCap.ValueMember = "MaNCC";
        }
    }
}
