using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using NHVL_Lib.Dao;
using System.Data.Sql;
using System.Data.SqlClient;
using NHVL_Lib.Model;

namespace ThongTinDN.Controllers
{
    public class UsersWebController : Controller
    {
        // GET: UsersWeb
        UsersWeb_Dao db = new UsersWeb_Dao();         
        public ActionResult Index()
        {
            ViewBag.userwebb = db.getAll();
            return View();
        }

        [HttpPost]
        public JsonResult InsertUserWeb(string UsersWeb1)
        {
            string message = string.Empty;
            int kq = db.Insert_UserWeb(UsersWeb1);
            return Json(new { data = message }, JsonRequestBehavior.AllowGet);
        }
    }
}