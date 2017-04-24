using PhucMobileConnection;
using PhucMobileShop.Areas.Admin.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhucMobileShop.Areas.Admin.Controllers
{
    public class BrandController : Controller
    {
        // GET: Admin/Brand
        public ActionResult Index()
        {
            var ds = BrandBus.DanhSach();
            return View(ds);
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            BrandBus.Xoa(id);
            var ds = BrandBus.DanhSach();
            return View(ds);
        }
        // GET: Admin/Brand/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Brand/Create
        [HttpPost]
        public ActionResult Create(nhasanxuat nsx)
        {
            nsx.bixoa = 0;
            BrandBus.Them(nsx);
            return RedirectToAction("Index");
        }

        // GET: Admin/Brand/Edit/5
        public ActionResult Edit(int id)
        {
            var ds = BrandBus.ChiTiet(id);
            return View(ds);
        }

        // POST: Admin/Brand/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, nhasanxuat nsx)
        {
            BrandBus.Sua(id, nsx);
            return RedirectToAction("Index");
        }
    }
}
