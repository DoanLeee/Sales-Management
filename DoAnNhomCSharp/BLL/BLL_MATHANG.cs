using DoAnNhomCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.BLL
{
    class BLL_MATHANG
    {
        DAL.DAL_MATHANG DalMH;
        frm_MatHang MH;
        public BLL_MATHANG(frm_MatHang fMH)
        {
            DalMH = new DAL.DAL_MATHANG();
            MH = fMH;
        }
        public void Bll_Data()
        {
            MH.dataGridView1.DataSource = DalMH.DAL_Data();
        }
        public void Bll_Them()
        {
            DalMH.DAL_Them(MH.txt_maHang.Text, MH.txt_tenHang.Text,float.Parse(MH.txt_GiaBan.Text),
                int.Parse(MH.txt_soLuong.Text),MH.txt_Hinh.Text,MH.cbb_loaiHang.SelectedValue.ToString(),MH.lb_nhaCungCap.SelectedValue.ToString());

        }
        public void Bll_Sua()
        {

            DalMH.DAL_Sua(MH.txt_maHang.Text, MH.txt_tenHang.Text, float.Parse(MH.txt_GiaBan.Text),
                int.Parse(MH.txt_soLuong.Text), MH.txt_Hinh.Text, MH.cbb_loaiHang.SelectedValue.ToString(), MH.lb_nhaCungCap.SelectedValue.ToString());
        }
        public void Bll_Xoa()
        {
            DalMH.DAL_Xoa(MH.txt_maHang.Text);

        }
        public void BLL_Tim()
        {
            MH.dataGridView1.DataSource = DalMH.DAL_Tim(MH.txt_tim.Text);
        }
    }
}
