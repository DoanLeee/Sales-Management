using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_MATHANG
    {
        LOPDUNGCHUNG lopChung;
        public DAL_MATHANG()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public DataTable DAL_Data()
        {
            string sqlLoad = "select * from MATHANG";
            return lopChung.LoadDuLieu(sqlLoad);
        }
        public void DAL_Them(string MaHang, string TenHang, float GiaBan, int SoLuong, string TenHinh, string MaLoaiHang, string MaNCC)
        {
            string sqlThem = "insert into MATHANG values ('" + MaHang + "','" + TenHang + "','"
                + GiaBan + "' ,'" + SoLuong + "','" + TenHinh +
                "','" + MaLoaiHang + "','" + MaNCC + "')";
            lopChung.Nonquery(sqlThem);

        }
        public void DAL_Sua(string MaHang, string TenHang, float GiaBan, int SoLuong, string TenHinh, string MaLoaiHang, string MaNCC)
        {
            string sqlSua = "update MATHANG set TenHang = N'" + TenHang + "',Gia='"
               + GiaBan + "', SoLuong = '" + SoLuong + "' ,TenHinh ='" + TenHinh +
               "', MaLoaiHang = '" + MaLoaiHang + "',MaNCC='" + MaNCC + "' where MaHang = '" + MaHang + "'";
            lopChung.Nonquery(sqlSua);
        }
        public void DAL_Xoa(string MaHang)
        {
            string sqlXoa1 = " delete from BANHANG where MaHang = '" + MaHang + "'";
            lopChung.CapNhat(sqlXoa1);
            string sqlXoa = " delete from MATHANG where MaHang = '" + MaHang + "'";
            lopChung.Nonquery(sqlXoa);
        }
        public DataTable DAL_Tim(string Tim)
        {
            string sqlTim = "select * from MATHANG where MaHang like  '%" + Tim + "%' OR TenHang like N'%" + Tim + "%' ";
            return lopChung.LoadDuLieu(sqlTim);
        }
    }
}
