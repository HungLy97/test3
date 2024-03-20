using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHVL_Lib.Model;
using System.Data.SqlClient;

namespace NHVL_Lib.Dao
{
    public class DoanhNghiep_Dao
    {
        NHVL db;
        public DoanhNghiep_Dao()
        {
            db = new NHVL();
        }

        public IQueryable<DoanhNghiep> getAll()
        {
            return db.DoanhNghiep;
        }

        public int Insert_DoanhNghiep(string Doanhnghiep)
        {
            object[] sqlParams = {
               new SqlParameter("@Insert_DoanhNghiep", Doanhnghiep),
            };
            return db.Database.SqlQuery<int>("Insert_DoanhNghiep @Doanhnghiep", sqlParams).First();
        }
    }
}
