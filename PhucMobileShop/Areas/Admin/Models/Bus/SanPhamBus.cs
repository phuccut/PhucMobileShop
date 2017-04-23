using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Areas.Admin.Models.Bus
{
    public class SanPhamBus
    {
        public static IEnumerable<PhucMobileConnection.sanpham> DanhSach()
        {
            var db = new PhucMobileConnectionDB();
            return db.Query<PhucMobileConnection.sanpham>("SELECT * FROM sanpham");
        }
        public static void Them(sanpham sp)
        {
            var db = new PhucMobileConnectionDB();
            db.Insert(sp);
        }
    }
}