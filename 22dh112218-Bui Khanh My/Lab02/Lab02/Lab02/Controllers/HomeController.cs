using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using Lab02.Models;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("SELECT * FROM SACH");
            return View();
        }

        public ActionResult SanPham()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("EXEC xuatdulieu");
            return View();
        }
        public ActionResult ChuDe()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("SELECT * FROM CHUDE");
            return View();
        }
        public ActionResult NhaXuatBan()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("SELECT * FROM NHAXUATBAN");
            return View();
        }
        public ActionResult Tacgia()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("SELECT * FROM TACGIA");
            return View();
        }
        public ActionResult Vietsach()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("SELECT * FROM VIETSACH");
            return View();
        }
        public ActionResult DonDatHang()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("SELECT * FROM DONDATHANG");
            return View();
        }
        public ActionResult CTDatHang()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("SELECT * FROM CTDATHANG");
            return View();
        }

        public ActionResult KhachHang()
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("SELECT * FROM KHACHHANG");
            ViewBag.listcd = db.get("SELECT * FROM CHUDE");
            return View();
        }
        public ActionResult TimKiemSach(string tensach)
        {
            DataModel db = new DataModel();
            ViewBag.list = db.get("EXEC TIMKIEMSACHTHEOTEN '" + tensach + "'");
            return View();
        }
        public ActionResult ChiTietSach(string id)
        {
            DataModel db=new DataModel();
            ViewBag.list = db.get("EXEC TIMKIEMSACHTHEOID " + id +";");
            return View();
        }

    }
}

