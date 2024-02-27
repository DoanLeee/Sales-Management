using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_NHANVIENBH
    {
        LOPDUNGCHUNG lopChung;
        public DAL_NHANVIENBH()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public DataTable DAL_Data()
        {
            string sqlLoadNVBH = "select * from NHANVIEN";
            return lopChung.LoadDuLieu(sqlLoadNVBH);
        }
    }
}
