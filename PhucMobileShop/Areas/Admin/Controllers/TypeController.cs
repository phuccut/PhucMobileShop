using PhucMobileConnection;
using PhucMobileShop.Areas.Admin.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhucMobileShop.Areas.Admin.Controllers
{
    public class TypeController : Controller
    {
        // GET: Admin/Type
        public ActionResult Index()
        {
            var ds = TypeBus.DanhSach();
            return View(ds);
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            TypeBus.Xoa(id);
            var ds = TypeBus.DanhSach();
            return View(ds);
        }
        // GET: Admin/Brand/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Brand/Create
        [HttpPost]
        public ActionResult Create(loaisanpham lsp)
        {
            lsp.bixoa = 0;
            TypeBus.Them(lsp);
            return RedirectToAction("Index");
        }

        // GET: Admin/Brand/Edit/5
        public ActionResult Edit(int id)
        {
            var ds = TypeBus.ChiTiet(id);
            return View(ds);
        }

        // POST: Admin/Brand/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, loaisanpham lsp)
        {
            TypeBus.Sua(id, lsp);
            return RedirectToAction("Index");
        }
    }
}
