using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab02.Models;
using System.Web.Mvc;
using System.IO;

namespace Lab02.Controllers
{
    public class SachController : Controller
    {
        // GET: Sach
        public ActionResult Index()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("SELECT * FROM SACH ORDER BY MASACH DESC");
            ViewBag.listCD = db.get("SELECT * FROM CHUDE");
            ViewBag.listNXB = db.get("SELECT * FROM NHAXUATBAN");
            return View();
        }
        [HttpPost]
        public ActionResult ThemSachMoi(string tensach, string dongia, string mota, HttpPostedFileBase hinhminhhoa , string machude, string manhaxuatban)
        {
            try
            {
                if (hinhminhhoa != null && hinhminhhoa.ContentLength > 0)
                {
                    string filename = Path.GetFileName(hinhminhhoa.FileName);
                    string path = Path.Combine(Server.MapPath("~/Hinh"), filename);
                    hinhminhhoa.SaveAs(path);
                    DataModel db = new DataModel();
                    db.get("EXEC THEMSACH N'" + tensach + "'," + dongia + ",N'" + mota + "','" + hinhminhhoa.FileName + "'," + machude + "," + manhaxuatban + ";");
                }
            }
            catch (Exception) { }
            return RedirectToAction("Index", "Sach");
        }
        public ActionResult XoaSach(string id)

        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("EXEC XOASACHTHEOID " + id);
            return RedirectToAction("Index", "Sach");
        }
    }
}