using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Models.Bus
{
    public class SanPhamBus
    {
        public static IEnumerable<sanpham> DanhSach()
        {
            var db = new PhucMobileConnectionDB();
            return db.Query<sanpham>("SELECT * FROM sanpham");
        }
        public static sanpham ChiTiet(int id)
        {
            var db = new PhucMobileConnectionDB();
            return db.SingleOrDefault<sanpham>("SELECT * FROM sanpham WHERE MaSanPham = @0", id);
            
        }
    }
}