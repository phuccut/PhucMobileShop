using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Areas.Admin.Models.Bus
{
    public class BrandBus
    {
        public static IEnumerable<nhasanxuat> DanhSach()
        {
            using (var db = new PhucMobileConnectionDB())
            {
                return db.Query<PhucMobileConnection.nhasanxuat>("SELECT * FROM nhasanxuat WHERE bixoa<>1");
            }
        }
        public static nhasanxuat ChiTiet(int id)
        {
            var db = new PhucMobileConnectionDB();
            return db.SingleOrDefault<nhasanxuat>("SELECT * FROM nhasanxuat WHERE MaNSX = @0", id);
        }
        public static void Them(nhasanxuat nsx)
        {
            var db = new PhucMobileConnectionDB();
            db.Insert(nsx);
        }
        public static void Xoa(int id)
        {
            var db = new PhucMobileConnectionDB();
            var a = db.SingleOrDefault<nhasanxuat>("SELECT * FROM nhasanxuat WHERE MaNSX=@0", id);
            a.bixoa = 1;
            db.Update("nhasanxuat", "MaNSX", a);
        }
        public static void Sua(int id, nhasanxuat nsx)
        {
            var db = new PhucMobileConnectionDB();
            db.Update("nhasanxuat", "MaNSX", nsx);
        }
    }
}