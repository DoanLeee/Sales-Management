using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_TINHTHANH
    {
        LOPDUNGCHUNG lopChung;
        public DAL_TINHTHANH()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public DataTable DAL_Data()
        {
            string sqlLoadTT = "select * from TINHTHANH";
            return lopChung.LoadDuLieu(sqlLoadTT);
        }
    }
}
