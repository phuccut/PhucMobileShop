using PhucMobileConnection;
using PhucMobileShop.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhucMobileShop.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult Index()
        {
            var dsSanPham = SanPhamBus.DanhSach();
            return View(dsSanPham);
        }

        // GET: SanPham/Details/5
        public ActionResult Details(int id)
        {
            return View(SanPhamBus.ChiTiet(id));
        }

        // GET: SanPham/Create
        public ActionResult Create()
        {
            ViewBag.MaNSX = new SelectList(NhaSanXuatBus.DanhSach(), "MaNSX", "TenNSX");
            return View();
        }

        // POST: SanPham/Create
        [HttpPost]
        public ActionResult Create(sanpham sp)
        {
            //try
            //{
                // TODO: Add insert logic here
                SanPhamBus.Them(sp);
                return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: SanPham/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SanPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SanPham/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
