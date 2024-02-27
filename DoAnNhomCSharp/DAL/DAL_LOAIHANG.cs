using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_LOAIHANG
    {
        LOPDUNGCHUNG lopChung;
        public DAL_LOAIHANG()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public DataTable DAL_Data()
        {
            string sqlLoadCV = "select * from LOAIHANG";
            return lopChung.LoadDuLieu(sqlLoadCV);
        }
    }
}
