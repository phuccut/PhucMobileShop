using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Areas.Admin.Models.Bus
{
    public class LoaiSanPhamBus
    {
        public static IEnumerable<loaisanpham> DanhSach()
        {
            using (var db = new PhucMobileConnectionDB())
            {
                return db.Query<PhucMobileConnection.loaisanpham>("SELECT * FROM loaisanpham WHERE bixoa<>1");
            }
        }
    }
}