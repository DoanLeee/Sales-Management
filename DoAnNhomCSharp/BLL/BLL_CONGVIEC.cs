using DoAnNhomCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.BLL
{
    class BLL_CONGVIEC
    {
        DAL.DAL_CONGVIEC DalCV;
        frm_NhanVien NV;
        public BLL_CONGVIEC(frm_NhanVien fNV)
        {
            DalCV = new DAL.DAL_CONGVIEC();
            NV = fNV;
        }
        public void Bll_Data()
        {
            NV.cbb_congViec.DataSource = DalCV.DAL_Data();
            NV.cbb_congViec.DisplayMember = "TenCV";
            NV.cbb_congViec.ValueMember = "MaCV";
        }
    }
}
