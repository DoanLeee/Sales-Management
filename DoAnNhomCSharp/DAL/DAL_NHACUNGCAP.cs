using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_NHACUNGCAP
    {
        LOPDUNGCHUNG lopChung;
        public DAL_NHACUNGCAP()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public DataTable DAL_Data()
        {
            string sqlLoadTT = "select * from NHACUNGCAP";
            return lopChung.LoadDuLieu(sqlLoadTT);
        }
    }
}
