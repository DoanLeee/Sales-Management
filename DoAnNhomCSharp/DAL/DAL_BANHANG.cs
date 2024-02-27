using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_BANHANG
    {
        LOPDUNGCHUNG lopChung;
        public DAL_BANHANG()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public DataTable DAL_Data()
        {
            string sqlLoad = "select * from BANHANG";
            return lopChung.LoadDuLieu(sqlLoad);
        }
        public void DAL_Them(string MaHoaDon, DateTime NgayBan, string MaNV, string MaHang, float GiaBan, int SoLuong, float ThanhTien)
        {
            
            string sqlThem = "insert into BANHANG values ('" + MaHoaDon + "','" + NgayBan + "','"
                + MaNV + "' ,'" + MaHang + "','" + GiaBan +
                "','" + SoLuong + "','" + ThanhTien + "') ";

            if (lopChung.ThemTraVe(sqlThem) > 0)
            {
                string sqlSua = "update MATHANG set SoLuong = SoLuong - '" + SoLuong + "' where MaHang = '" + MaHang + "'";
                lopChung.Nonquery(sqlSua);
            }
        }
        public DataTable DAL_Tim(string Tim)
        {
            string sqlTim = "select * from BANHANG where MaHoaDon like  '%" + Tim + "%' ";
            return lopChung.LoadDuLieu(sqlTim);
        }
    }
}
