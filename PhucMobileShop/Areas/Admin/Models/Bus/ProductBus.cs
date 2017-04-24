using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Areas.Admin.Models.Bus
{
    public class ProductBus
    {
        public static IEnumerable<PhucMobileConnection.sanpham> DanhSach()
        {
            var db = new PhucMobileConnectionDB();
            return db.Query<PhucMobileConnection.sanpham>("SELECT * FROM sanpham WHERE bixoa = 0");
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
        public static void Xoa(int id)
        {
            var db = new PhucMobileConnectionDB();
            var a = db.SingleOrDefault<sanpham>("SELECT * FROM sanpham WHERE MaSanPham=@0", id);
            a.bixoa = 1;
            db.Update("sanpham","MaSanPham",a);
        }
        public static void Sua(int id,sanpham sp)
        {
            var db = new PhucMobileConnectionDB();
            var a = db.SingleOrDefault<sanpham>("SELECT * FROM sanpham WHERE MaSanPham=@0", id);
            a = sp;
            db.Update("sanpham", "MaSanPham", sp);
        }
    }
}