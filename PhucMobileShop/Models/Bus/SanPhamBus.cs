using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Models.Bus
{
    public class SanPhamBus
    {
        public static IEnumerable<PhucMobileConnection.sanpham> DanhSach()
        {
            var db = new PhucMobileConnectionDB();
            return db.Query<PhucMobileConnection.sanpham>("SELECT * FROM sanpham");
        }
        public static sanpham ChiTiet(int id)
        {
            var db = new PhucMobileConnectionDB();
            return db.SingleOrDefault<sanpham>("SELECT * FROM sanpham WHERE MaSanPham = @0", id);
        }
        public static void Them(sanpham sp)
        {
            var db = new PhucMobileConnectionDB();
            db.Insert(sp);
        }
    }
}