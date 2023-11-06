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
    using System.ComponentModel.DataAnnotations;


    public partial class KhachHang
    {
        public KhachHang()
        {
            this.BinhLuans = new HashSet<BinhLuan>();
            this.GioHangs = new HashSet<GioHang>();
            this.HoaDons = new HashSet<HoaDon>();
        }

        public int MaKH { get; set; }

        [Required]
        [Display(Name = "T�n kh�ch h�ng")]
        public string TenKhachHang { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "SDT khong hop le")]
        public string SoDienThoai { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }


        public string SoThe { get; set; }
        public Nullable<System.DateTime> NgayHH { get; set; }
        public Nullable<short> CVV { get; set; }

        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        public virtual ICollection<GioHang> GioHangs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
