using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHVL_Lib.Dao;
namespace ThongTinDN.Controllers
{
    public class DoanhNghiepController : Controller
    {
        // GET: DanhSach
        DoanhNghiep_Dao db = new DoanhNghiep_Dao();
        public ActionResult Index()
        {
            ViewBag.doanhnghiep_viewbag = db.getAll();
            return View();
        }

        [HttpPost]
        public JsonResult Insert_DoanhNghiep(string Doanhnghiep)
        {
            string message = string.Empty;
            int kq = db.Insert_DoanhNghiep(Doanhnghiep);
            if (kq > 0)
                message = "ok";
            else
                message = "no ok";
            return Json(new { data = message }, JsonRequestBehavior.AllowGet);
        }


    }
}