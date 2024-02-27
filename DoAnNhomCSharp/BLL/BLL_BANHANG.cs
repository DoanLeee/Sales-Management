using DoAnNhomCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhomCSharp.BLL
{
    class BLL_BANHANG
    {
        DAL.DAL_BANHANG DalBH;
        frm_BanHang BH;
        public BLL_BANHANG(frm_BanHang fBH)
        {
            DalBH = new DAL.DAL_BANHANG();
            BH = fBH;
        }
        public void Bll_Data()
        {
            BH.dataGridView1.DataSource = DalBH.DAL_Data();
        }
        public void Bll_Them()
        {
            if(int.Parse(BH.txt_soLuong.Text)<= int.Parse(BH.txt_soLuongTon.Text))
            {
                DalBH.DAL_Them(BH.txt_maHoaDon.Text, BH.dateTimePicker1.Value, BH.cbb_nhanVien.SelectedValue.ToString(),
               BH.cbb_tenHang.SelectedValue.ToString(), float.Parse(BH.txt_giaBan.Text), int.Parse(BH.txt_soLuong.Text), float.Parse(BH.txt_thanhTien.Text));
            }
            else MessageBox.Show("Không Đủ Hàng");
        }
        public void BLL_Tim()
        {
            BH.dataGridView1.DataSource = DalBH.DAL_Tim(BH.txt_tim.Text);
        }
    }
}
