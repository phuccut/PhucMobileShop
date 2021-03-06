﻿using PhucMobileShop.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhucMobileShop.Controllers
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public PartialViewResult GetLoaiSanPham()
        {
            ViewBag.menuLSP = MenuBus.DanhSachLoaiSanPham();
            return PartialView("~/Views/Shared/_LoaiSanPham.cshtml");
        }
        public PartialViewResult GetNhaSanXuat()
        {
            ViewBag.menuHDT = MenuBus.DanhSachNhaSanXuat();
            return PartialView("~/Views/Shared/_NhaSanXuat.cshtml");
        }
    }
}