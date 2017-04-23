using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Models.Bus
{
    public class NhaSanXuatBus
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
        public static nhasanxuat NSXbyHang(int id)
        {
            var db = new PhucMobileConnectionDB();
            return db.SingleOrDefault<nhasanxuat>("SELECT * FROM nhasanxuat WHERE MaNSX = @0", id);
        }
    }
}