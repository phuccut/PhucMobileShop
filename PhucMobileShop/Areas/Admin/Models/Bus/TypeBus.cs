using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Areas.Admin.Models.Bus
{
    public class TypeBus
    {
        public static IEnumerable<loaisanpham> DanhSach()
        {
            using (var db = new PhucMobileConnectionDB())
            {
                return db.Query<PhucMobileConnection.loaisanpham>("SELECT * FROM loaisanpham WHERE bixoa<>1");
            }
        }
        public static loaisanpham ChiTiet(int id)
        {
            var db = new PhucMobileConnectionDB();
            return db.SingleOrDefault<loaisanpham>("SELECT * FROM loaisanpham WHERE MaLSP = @0", id);
        }
        public static void Them(loaisanpham lsp)
        {
            var db = new PhucMobileConnectionDB();
            db.Insert(lsp);
        }
        public static void Xoa(int id)
        {
            var db = new PhucMobileConnectionDB();
            var a = db.SingleOrDefault<loaisanpham>("SELECT * FROM loaisanpham WHERE MaLSP=@0", id);
            a.bixoa = 1;
            db.Update("loaisanpham", "MaLSP", a);
        }
        public static void Sua(int id, loaisanpham lsp)
        {
            var db = new PhucMobileConnectionDB();
            db.Update("loaisanpham", "MaLSP", lsp);
        }
    }
}