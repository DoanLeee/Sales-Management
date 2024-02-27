using DoAnNhomCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.BLL
{
    class BLL_NHANVIEN
    {
        DAL.DAL_NHANVIEN DalNV;
        frm_NhanVien NV;
        public BLL_NHANVIEN(frm_NhanVien fNV)
        {
            DalNV = new DAL.DAL_NHANVIEN();
            NV = fNV;
        }
        public void Bll_Data()
        {
            NV.dataGridView1.DataSource = DalNV.DAL_Data();
        }
        public void Bll_Them()
        {
            DalNV.DAL_Them(NV.txt_maNhanVien.Text, NV.txt_tenNhanVien.Text, NV.cbb_congViec.SelectedValue.ToString(), 
                NV.txt_mucLuong.Text,NV.dateTimePicker1.Value, NV.lb_tinhThanh.SelectedValue.ToString(),NV.txt_Hinh.Text);
        }
        public void Bll_Sua()
        {

            DalNV.DAL_Sua(NV.txt_maNhanVien.Text, NV.txt_tenNhanVien.Text, NV.cbb_congViec.SelectedValue.ToString(),
                NV.txt_mucLuong.Text, NV.dateTimePicker1.Value, NV.lb_tinhThanh.SelectedValue.ToString(), NV.txt_Hinh.Text);
        }
        public void Bll_Xoa()
        {
            DalNV.DAL_Xoa(NV.txt_maNhanVien.Text);
        }
        public void Bll_Tim()
        {
            NV.dataGridView1.DataSource =  DalNV.DAL_Tim(NV.txt_tim.Text);
        }
    }
}
