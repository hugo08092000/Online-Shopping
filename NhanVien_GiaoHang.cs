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
    
    public partial class NhanVien_GiaoHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien_GiaoHang()
        {
            this.DonGiaoHangs = new HashSet<DonGiaoHang>();
        }
    
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public System.DateTime DOB_NV { get; set; }
        public string SDT_NV { get; set; }
        public string DiaChi_NV { get; set; }
        public string Email_NV { get; set; }
        public decimal Luong { get; set; }
        public bool TinhTrang { get; set; }
        public string PhamViHoatDong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonGiaoHang> DonGiaoHangs { get; set; }
    }
}
