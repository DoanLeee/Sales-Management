using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_CONGVIEC
    {
        LOPDUNGCHUNG lopChung;
        public DAL_CONGVIEC()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public DataTable DAL_Data()
        {
            string sqlLoadCV = "select * from CONGVIEC";
            return lopChung.LoadDuLieu(sqlLoadCV);
        }
    }
}
