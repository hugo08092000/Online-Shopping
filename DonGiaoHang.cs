//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Shopping
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonGiaoHang
    {
        public int MaVanChuyen { get; set; }
        public int MaDon { get; set; }
        public int MaNhanVien { get; set; }
        public System.DateTime NgayGiao { get; set; }
        public string TinhTrangGiaoHang { get; set; }
        public string LyDoHuy { get; set; }
        public decimal TongTien { get; set; }
    
        public virtual DonDatHang DonDatHang { get; set; }
        public virtual NhanVien_GiaoHang NhanVien_GiaoHang { get; set; }
    }
}
