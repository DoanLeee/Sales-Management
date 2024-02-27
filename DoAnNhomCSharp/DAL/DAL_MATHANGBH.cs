using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhomCSharp.DAL
{
    class DAL_MATHANGBH
    {
        LOPDUNGCHUNG lopChung;
        public DAL_MATHANGBH()
        {
            lopChung = new LOPDUNGCHUNG();
        }
        public DataTable DAL_Data()
        {
            string sqlLoadMHBH = "select * from MATHANG";
            return lopChung.LoadDuLieu(sqlLoadMHBH);
        }
    }
}
