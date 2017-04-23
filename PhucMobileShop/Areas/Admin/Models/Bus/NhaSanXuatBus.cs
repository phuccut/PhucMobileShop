using PhucMobileConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhucMobileShop.Areas.Admin.Models.Bus
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
    }
}