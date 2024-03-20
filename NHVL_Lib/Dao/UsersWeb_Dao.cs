using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHVL_Lib.Model;
using System.Data.SqlClient;

namespace NHVL_Lib.Dao
{
    public class UsersWeb_Dao
    {
        NHVL db;
        public UsersWeb_Dao()
        {
            db = new NHVL();
        }

        public IQueryable<UserWeb> getAll()
        {
            return db.UserWeb;
        }

        public int Insert_UserWeb(string usersweb)
        {
            object[] sqlParams = {
               new SqlParameter("@UserName", usersweb),
            };
            return db.Database.SqlQuery<int>("Insert_UserWeb @UserName", sqlParams).First();
        }
    }
}
