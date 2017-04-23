using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Models.Bus
{
    public class MenuBus
    {
        public static IEnumerable<PhucMobileConnection.loaisanpham> DanhSachLoaiSanPham()
        {
            var db = new PhucMobileConnectionDB();
            return db.Query<PhucMobileConnection.loaisanpham>("SELECT * FROM loaisanpham");
        }
        public static IEnumerable<PhucMobileConnection.nhasanxuat> DanhSachNhaSanXuat()
        {
            var db = new PhucMobileConnectionDB();
            return db.Query<PhucMobileConnection.nhasanxuat>("SELECT * FROM nhasanxuat");
        }
    }
}