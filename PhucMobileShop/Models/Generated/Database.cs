




















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `PhucMobileConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=.;Initial Catalog=PhucMobileShop;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace PhucMobileConnection
{

	public partial class PhucMobileConnectionDB : Database
	{
		public PhucMobileConnectionDB() 
			: base("PhucMobileConnection")
		{
			CommonConstruct();
		}

		public PhucMobileConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			PhucMobileConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static PhucMobileConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new PhucMobileConnectionDB();
        }

		[ThreadStatic] static PhucMobileConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static PhucMobileConnectionDB repo { get { return PhucMobileConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.chitietsanpham")]



	[PrimaryKey("MaSanPham", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class chitietsanpham : PhucMobileConnectionDB.Record<chitietsanpham>  
    {



		[Column] public int MaSanPham { get; set; }





		[Column] public string TenSanPham { get; set; }





		[Column] public string ManHinh { get; set; }





		[Column] public string CameraTruoc { get; set; }





		[Column] public string CameraSau { get; set; }





		[Column] public string HeDieuHanh { get; set; }





		[Column] public string CPU { get; set; }





		[Column] public string ChipDoHoa { get; set; }





		[Column] public string Ram { get; set; }





		[Column] public string BoNhoTrong { get; set; }





		[Column] public string HoTroTheNho { get; set; }





		[Column] public string SoSim { get; set; }





		[Column] public string DungLuongPin { get; set; }





		[Column] public string KetNoi { get; set; }



	}

    

	[TableName("dbo.giohang")]



	[PrimaryKey("MaGioHang", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class giohang : PhucMobileConnectionDB.Record<giohang>  
    {



		[Column] public int MaKhachHang { get; set; }





		[Column] public int MaGioHang { get; set; }





		[Column] public int TongTien { get; set; }





		[Column] public DateTime NgayMua { get; set; }





		[Column] public int TinhTrang { get; set; }



	}

    

	[TableName("dbo.giohangchitiet")]



	[PrimaryKey("MaGioHangChiTiet", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class giohangchitiet : PhucMobileConnectionDB.Record<giohangchitiet>  
    {



		[Column] public int MaGioHangChiTiet { get; set; }





		[Column] public int MaSanPham { get; set; }





		[Column] public int SoLuong { get; set; }





		[Column] public int MaGioHang { get; set; }



	}

    

	[TableName("dbo.hangdienthoai")]



	[PrimaryKey("MaHang", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class hangdienthoai : PhucMobileConnectionDB.Record<hangdienthoai>  
    {



		[Column] public int MaHang { get; set; }





		[Column] public string Hang { get; set; }





		[Column] public int? MaNSX { get; set; }





		[Column] public int? bixoa { get; set; }



	}

    

	[TableName("dbo.khachhang")]



	[PrimaryKey("MaKhachHang", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class khachhang : PhucMobileConnectionDB.Record<khachhang>  
    {



		[Column] public int MaKhachHang { get; set; }





		[Column] public int MaTaiKhoan { get; set; }





		[Column] public string HoTen { get; set; }





		[Column] public DateTime NgaySinh { get; set; }





		[Column] public string DiaChi { get; set; }



	}

    

	[TableName("dbo.loaisanpham")]



	[PrimaryKey("MaLSP", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class loaisanpham : PhucMobileConnectionDB.Record<loaisanpham>  
    {



		[Column] public int MaLSP { get; set; }





		[Column] public string TenLSP { get; set; }





		[Column] public int bixoa { get; set; }



	}

    

	[TableName("dbo.nhasanxuat")]



	[PrimaryKey("MaNSX", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class nhasanxuat : PhucMobileConnectionDB.Record<nhasanxuat>  
    {



		[Column] public int MaNSX { get; set; }





		[Column] public string TenNSX { get; set; }





		[Column] public string MoTa { get; set; }





		[Column] public int bixoa { get; set; }



	}

    

	[TableName("dbo.sanpham")]



	[PrimaryKey("MaSanPham", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class sanpham : PhucMobileConnectionDB.Record<sanpham>  
    {



		[Column] public int MaNSX { get; set; }





		[Column] public int MaSanPham { get; set; }





		[Column] public string TenSanPham { get; set; }





		[Column] public string HinhAnh { get; set; }





		[Column] public double Gia { get; set; }





		[Column] public string XuatXu { get; set; }





		[Column] public int bixoa { get; set; }





		[Column] public int SoLuotXem { get; set; }





		[Column] public int? SoLuotMua { get; set; }





		[Column] public DateTime NgayNhap { get; set; }





		[Column] public int SoLuong { get; set; }



	}

    

	[TableName("dbo.sysdiagrams")]



	[PrimaryKey("diagram_id")]




	[ExplicitColumns]

    public partial class sysdiagram : PhucMobileConnectionDB.Record<sysdiagram>  
    {



		[Column] public string name { get; set; }





		[Column] public int principal_id { get; set; }





		[Column] public int diagram_id { get; set; }





		[Column] public int? version { get; set; }





		[Column] public byte[] definition { get; set; }



	}

    

	[TableName("dbo.taikhoan")]



	[PrimaryKey("MaTaiKhoan", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class taikhoan : PhucMobileConnectionDB.Record<taikhoan>  
    {



		[Column] public int MaTaiKhoan { get; set; }





		[Column] public string TenDangNhap { get; set; }





		[Column] public string MatKhau { get; set; }





		[Column] public int bixoa { get; set; }





		[Column] public int? LoaiTaiKhoan { get; set; }





		[Column] public string HoTen { get; set; }





		[Column] public DateTime? NgaySinh { get; set; }





		[Column] public string DiaChi { get; set; }



	}


}
