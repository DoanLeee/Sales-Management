using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_NHANVIEN
    {
        LOPDUNGCHUNG lopChung;
        public DAL_NHANVIEN()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public DataTable DAL_Data()
        {
            string sqlLoad = "select * from NHANVIEN";
            return lopChung.LoadDuLieu(sqlLoad);
        }
        public void DAL_Them(string MaNV, string TenNV, string MaCV, string MucLuong, DateTime NgayVaoLam, string MaTT, string TenHinh)
        {
          string sqlThem = "insert into NHANVIEN values ('" + MaNV + "','" + TenNV + "','"
              + MaCV + "' ,'" + MucLuong + "','" + NgayVaoLam +
              "','" + MaTT + "','" + TenHinh + "')";
            lopChung.Nonquery(sqlThem);
            
        }
        public void DAL_Sua(string MaNV, string TenNV, string MaCV, string MucLuong, DateTime NgayVaoLam, string MaTT, string TenHinh)
        {
            string sqlSua = "update NHANVIEN set TENNV = N'" + TenNV + "',MaCV='"
               + MaCV + "', MucLuong = '" + MucLuong + "' ,NgayVaoLam ='" + NgayVaoLam +
               "', MaTT = '" + MaTT + "',TenHinh='" + TenHinh + "' where MaNV = '" + MaNV + "'";
            lopChung.Nonquery(sqlSua);
        }
        public void DAL_Xoa(string MaNV)
        {
            string sqlxoa = " delete from BANHANG where MaNV = '" + MaNV + "'";
            lopChung.CapNhat(sqlxoa);
            string sqlXoa = " delete from NHANVIEN where MaNV = '" + MaNV + "'";
            lopChung.Nonquery(sqlXoa);
        }
        public DataTable DAL_Tim(string Tim)
        {
            string sqlTim = "select * from NHANVIEN where MaNV like  '%" + Tim + "%' OR TenNV like N'%" + Tim + "%' ";
            return lopChung.LoadDuLieu(sqlTim);
        }
    }
}
