using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            BinhLuan = new HashSet<BinhLuan>();
            ChiTietMxh = new HashSet<ChiTietMxh>();
            CtntroChuyen = new HashSet<CtntroChuyen>();
            CtthongBao = new HashSet<CtthongBao>();
            CttroChuyenNguoiGuiNavigation = new HashSet<CttroChuyen>();
            CttroChuyenNguoiNhanNavigation = new HashSet<CttroChuyen>();
            GopY = new HashSet<GopY>();
            ThanhVienNhomTc = new HashSet<ThanhVienNhomTc>();
            TheoDoiMaNguoiDuocTdNavigation = new HashSet<TheoDoi>();
            TheoDoiMaNguoiTdNavigation = new HashSet<TheoDoi>();
            ThongBao = new HashSet<ThongBao>();
            TinTuc = new HashSet<TinTuc>();
            TroChuyenThanhVien1Navigation = new HashSet<TroChuyen>();
            TroChuyenThanhVien2Navigation = new HashSet<TroChuyen>();
        }

        public string HoTen { get; set; }
        public DateTime? SinhNhat { get; set; }
        public string Nickname { get; set; }
        public string GtbanThan { get; set; }
        public string NgheNghiep { get; set; }
        public byte[] HinhAnh { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int? MaLoai { get; set; }
        public string VaiTro { get; set; }

        public virtual LoaiTaiKhoan MaLoaiNavigation { get; set; }
        public virtual ICollection<BinhLuan> BinhLuan { get; set; }
        public virtual ICollection<ChiTietMxh> ChiTietMxh { get; set; }
        public virtual ICollection<CtntroChuyen> CtntroChuyen { get; set; }
        public virtual ICollection<CtthongBao> CtthongBao { get; set; }
        public virtual ICollection<CttroChuyen> CttroChuyenNguoiGuiNavigation { get; set; }
        public virtual ICollection<CttroChuyen> CttroChuyenNguoiNhanNavigation { get; set; }
        public virtual ICollection<GopY> GopY { get; set; }
        public virtual ICollection<ThanhVienNhomTc> ThanhVienNhomTc { get; set; }
        public virtual ICollection<TheoDoi> TheoDoiMaNguoiDuocTdNavigation { get; set; }
        public virtual ICollection<TheoDoi> TheoDoiMaNguoiTdNavigation { get; set; }
        public virtual ICollection<ThongBao> ThongBao { get; set; }
        public virtual ICollection<TinTuc> TinTuc { get; set; }
        public virtual ICollection<TroChuyen> TroChuyenThanhVien1Navigation { get; set; }
        public virtual ICollection<TroChuyen> TroChuyenThanhVien2Navigation { get; set; }
    }
}
