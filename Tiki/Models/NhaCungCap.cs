//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tiki.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            this.KhuyenMais = new HashSet<KhuyenMai>();
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int MaNCC { get; set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string Avatar { get; set; }
    
        public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
