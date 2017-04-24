using PhucMobileConnection;
using PhucMobileShop.Areas.Admin.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhucMobileShop.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/SanPham
        public ActionResult Index()
        {
            var ds = ProductBus.DanhSach();
            return View(ds);
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            ProductBus.Xoa(id);
            var ds = ProductBus.DanhSach();
            return View(ds);
        }

        // GET: Admin/SanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/SanPham/Create
        public ActionResult Create()
        {
            ViewBag.MaNSX = new SelectList(BrandBus.DanhSach(), "MaNSX", "TenNSX");
            ViewBag.MaLSP = new SelectList(TypeBus.DanhSach(), "MaLSP", "TenLSP");
            return View();
        }

        // POST: Admin/SanPham/Create
        [HttpPost]
        public ActionResult Create(sanpham sp)
        {
            if (HttpContext.Request.Files.Count > 0)
            {
                var hpf = HttpContext.Request.Files[0];
                if (hpf.ContentLength > 0)
                {
                    string filename = Guid.NewGuid().ToString();
                    string fullpathwithfilename = "/Images/chitietsanpham/" + filename + ".jpg";
                    hpf.SaveAs(Server.MapPath(fullpathwithfilename));
                    sp.HinhAnh = fullpathwithfilename;
                }
            }
            ProductBus.Them(sp);
            return RedirectToAction("Index");
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Admin/SanPham/Edit/5
        public ActionResult Edit(int id)
        {
            var ds = ProductBus.ChiTiet(id);
            var selectnsx = ds.MaNSX;
            var selectlsp = ds.MaLSP;
            ViewBag.MaNSX = new SelectList(BrandBus.DanhSach(), "MaNSX", "TenNSX",selectnsx);
            ViewBag.MaLSP = new SelectList(TypeBus.DanhSach(), "MaLSP", "TenLSP",selectlsp);
            return View(ds);
        }

        // POST: Admin/SanPham/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, sanpham sp)
        {
            ProductBus.Sua(id, sp);
            return RedirectToAction("Index");
        }

        // GET: Admin/SanPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/SanPham/Delete/5
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
