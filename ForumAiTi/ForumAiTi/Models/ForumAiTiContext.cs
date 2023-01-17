using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ForumAiTi.Models
{
    public partial class ForumAiTiContext : DbContext
    {
        public ForumAiTiContext()
        {
        }

        public ForumAiTiContext(DbContextOptions<ForumAiTiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BinhLuan> BinhLuan { get; set; }
        public virtual DbSet<ChiTietMxh> ChiTietMxh { get; set; }
        public virtual DbSet<ChuDe> ChuDe { get; set; }
        public virtual DbSet<CthoiDap> CthoiDap { get; set; }
        public virtual DbSet<CtntroChuyen> CtntroChuyen { get; set; }
        public virtual DbSet<CttinTuc> CttinTuc { get; set; }
        public virtual DbSet<CttroChuyen> CttroChuyen { get; set; }
        public virtual DbSet<DanhMucHoiDap> DanhMucHoiDap { get; set; }
        public virtual DbSet<GopY> GopY { get; set; }
        public virtual DbSet<HoiDap> HoiDap { get; set; }
        public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoan { get; set; }
        public virtual DbSet<MangXaHoi> MangXaHoi { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<NhomTroChuyen> NhomTroChuyen { get; set; }
        public virtual DbSet<NoiDungHoiDap> NoiDungHoiDap { get; set; }
        public virtual DbSet<NoiDungTinTuc> NoiDungTinTuc { get; set; }
        public virtual DbSet<TheoDoi> TheoDoi { get; set; }
        public virtual DbSet<TinTuc> TinTuc { get; set; }
        public virtual DbSet<TroChuyen> TroChuyen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NQ9EDMG\\SQLEXPRESS;Initial Catalog=ForumAiTi;User ID=sa;Password=5995");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BinhLuan>(entity =>
            {
                entity.HasKey(e => e.MaBinhLuan);

                entity.Property(e => e.LoaiFile)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NoiDung).HasMaxLength(1000);

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TenFile).HasMaxLength(1000);

                entity.Property(e => e.ThoiGianBinhLuan).HasColumnType("datetime");

                entity.HasOne(d => d.MaHoiDapNavigation)
                    .WithMany(p => p.BinhLuan)
                    .HasForeignKey(d => d.MaHoiDap)
                    .HasConstraintName("FK_BinhLuan_HoiDap");

                entity.HasOne(d => d.TaiKhoanNavigation)
                    .WithMany(p => p.BinhLuan)
                    .HasForeignKey(d => d.TaiKhoan)
                    .HasConstraintName("FK_BinhLuan_NguoiDung");
            });

            modelBuilder.Entity<ChiTietMxh>(entity =>
            {
                entity.HasKey(e => e.MaCt);

                entity.ToTable("ChiTietMXH");

                entity.Property(e => e.MaCt).HasColumnName("MaCT");

                entity.Property(e => e.HoTenMxh)
                    .HasColumnName("HoTenMXH")
                    .HasMaxLength(50);

                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.MaMxh).HasColumnName("MaMXH");

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaMxhNavigation)
                    .WithMany(p => p.ChiTietMxh)
                    .HasForeignKey(d => d.MaMxh)
                    .HasConstraintName("FK_ChiTietMXH_MangXaHoi");

                entity.HasOne(d => d.TaiKhoanNavigation)
                    .WithMany(p => p.ChiTietMxh)
                    .HasForeignKey(d => d.TaiKhoan)
                    .HasConstraintName("FK_ChiTietMXH_NguoiDung");
            });

            modelBuilder.Entity<ChuDe>(entity =>
            {
                entity.HasKey(e => e.MaChuDe);

                entity.Property(e => e.TenChuDe).HasMaxLength(200);
            });

            modelBuilder.Entity<CthoiDap>(entity =>
            {
                entity.HasKey(e => e.MaCt);

                entity.ToTable("CTHoiDap");

                entity.Property(e => e.MaCt).HasColumnName("MaCT");

                entity.HasOne(d => d.MaDanhMucNavigation)
                    .WithMany(p => p.CthoiDap)
                    .HasForeignKey(d => d.MaDanhMuc)
                    .HasConstraintName("FK_CTHoiDap_DanhMucHoiDap");

                entity.HasOne(d => d.MaHoiDapNavigation)
                    .WithMany(p => p.CthoiDap)
                    .HasForeignKey(d => d.MaHoiDap)
                    .HasConstraintName("FK_CTHoiDap_HoiDap");
            });

            modelBuilder.Entity<CtntroChuyen>(entity =>
            {
                entity.HasKey(e => e.MaCt);

                entity.ToTable("CTNTroChuyen");

                entity.Property(e => e.MaCt).HasColumnName("MaCT");

                entity.Property(e => e.LoaiFile)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NguoiGui)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ThoiGianGui).HasColumnType("datetime");

                entity.HasOne(d => d.MaNhomNavigation)
                    .WithMany(p => p.CtntroChuyen)
                    .HasForeignKey(d => d.MaNhom)
                    .HasConstraintName("FK_CTNTroChuyen_NhomTroChuyen");

                entity.HasOne(d => d.NguoiGuiNavigation)
                    .WithMany(p => p.CtntroChuyen)
                    .HasForeignKey(d => d.NguoiGui)
                    .HasConstraintName("FK_CTNTroChuyen_NguoiDung");
            });

            modelBuilder.Entity<CttinTuc>(entity =>
            {
                entity.HasKey(e => e.MaCt)
                    .HasName("PK_CTChuDe");

                entity.ToTable("CTTinTuc");

                entity.Property(e => e.MaCt).HasColumnName("MaCT");

                entity.HasOne(d => d.MaChuDeNavigation)
                    .WithMany(p => p.CttinTuc)
                    .HasForeignKey(d => d.MaChuDe)
                    .HasConstraintName("FK_CTTinTuc_ChuDe");

                entity.HasOne(d => d.MaChuDe1)
                    .WithMany(p => p.CttinTuc)
                    .HasForeignKey(d => d.MaChuDe)
                    .HasConstraintName("FK_CTTinTuc_TinTuc");
            });

            modelBuilder.Entity<CttroChuyen>(entity =>
            {
                entity.HasKey(e => e.MaCt);

                entity.ToTable("CTTroChuyen");

                entity.Property(e => e.MaCt).HasColumnName("MaCT");

                entity.Property(e => e.LoaiFile)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NguoiGui)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NguoiNhan)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ThoiGianGui).HasColumnType("datetime");

                entity.HasOne(d => d.MaTroChuyenNavigation)
                    .WithMany(p => p.CttroChuyen)
                    .HasForeignKey(d => d.MaTroChuyen)
                    .HasConstraintName("FK_CTTroChuyen_TroChuyen");

                entity.HasOne(d => d.NguoiNhanNavigation)
                    .WithMany(p => p.CttroChuyen)
                    .HasForeignKey(d => d.NguoiNhan)
                    .HasConstraintName("FK_CTTroChuyen_NguoiDung");
            });

            modelBuilder.Entity<DanhMucHoiDap>(entity =>
            {
                entity.HasKey(e => e.MaDanhMuc);

                entity.Property(e => e.TenDanhMuc).HasMaxLength(100);
            });

            modelBuilder.Entity<GopY>(entity =>
            {
                entity.HasKey(e => e.MaGopY);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.NguoiGui)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TieuDe).HasMaxLength(200);

                entity.HasOne(d => d.NguoiGuiNavigation)
                    .WithMany(p => p.GopY)
                    .HasForeignKey(d => d.NguoiGui)
                    .HasConstraintName("FK_GopY_NguoiDung");
            });

            modelBuilder.Entity<HoiDap>(entity =>
            {
                entity.HasKey(e => e.MaHoiDap);

                entity.Property(e => e.NguoiDang)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TenHinh1).HasMaxLength(1000);

                entity.Property(e => e.TenHinh2).HasMaxLength(1000);

                entity.Property(e => e.TenHinh3).HasMaxLength(1000);

                entity.Property(e => e.TieuDe).HasMaxLength(200);
            });

            modelBuilder.Entity<LoaiTaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.Property(e => e.TenLoai).HasMaxLength(50);
            });

            modelBuilder.Entity<MangXaHoi>(entity =>
            {
                entity.HasKey(e => e.MaMxh);

                entity.Property(e => e.MaMxh).HasColumnName("MaMXH");

                entity.Property(e => e.TenMxh)
                    .HasColumnName("TenMXH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.TaiKhoan);

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.Nickname).HasMaxLength(50);

                entity.Property(e => e.SinhNhat).HasColumnType("date");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.NguoiDung)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK_NguoiDung_LoaiTaiKhoan");
            });

            modelBuilder.Entity<NhomTroChuyen>(entity =>
            {
                entity.HasKey(e => e.MaNhom);

                entity.Property(e => e.TenNhom).HasMaxLength(1000);

                entity.Property(e => e.ThoiGianTao).HasColumnType("datetime");
            });

            modelBuilder.Entity<NoiDungHoiDap>(entity =>
            {
                entity.HasKey(e => e.MaNoiDungHd);

                entity.Property(e => e.MaNoiDungHd).HasColumnName("MaNoiDungHD");

                entity.Property(e => e.LoaiFile)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaHoiDapNavigation)
                    .WithMany(p => p.NoiDungHoiDap)
                    .HasForeignKey(d => d.MaHoiDap)
                    .HasConstraintName("FK_NoiDungHoiDap_HoiDap");
            });

            modelBuilder.Entity<NoiDungTinTuc>(entity =>
            {
                entity.HasKey(e => e.MaNoiDungTt);

                entity.Property(e => e.MaNoiDungTt).HasColumnName("MaNoiDungTT");

                entity.Property(e => e.LoaiFile)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaTinTucNavigation)
                    .WithMany(p => p.NoiDungTinTuc)
                    .HasForeignKey(d => d.MaTinTuc)
                    .HasConstraintName("FK_NoiDungTinTuc_TinTuc");
            });

            modelBuilder.Entity<TheoDoi>(entity =>
            {
                entity.HasKey(e => e.MaTheoDoi);

                entity.Property(e => e.MaNguoiDuocTd)
                    .HasColumnName("MaNguoiDuocTD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MaNguoiTd)
                    .HasColumnName("MaNguoiTD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ThoiGianTd)
                    .HasColumnName("ThoiGianTD")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.MaNguoiDuocTdNavigation)
                    .WithMany(p => p.TheoDoiMaNguoiDuocTdNavigation)
                    .HasForeignKey(d => d.MaNguoiDuocTd)
                    .HasConstraintName("FK_TheoDoi_NguoiDung1");

                entity.HasOne(d => d.MaNguoiTdNavigation)
                    .WithMany(p => p.TheoDoiMaNguoiTdNavigation)
                    .HasForeignKey(d => d.MaNguoiTd)
                    .HasConstraintName("FK_TheoDoi_NguoiDung");
            });

            modelBuilder.Entity<TinTuc>(entity =>
            {
                entity.HasKey(e => e.MaTinTuc);

                entity.Property(e => e.NguoiDang)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TenFile).HasMaxLength(1000);

                entity.Property(e => e.TieuDe).HasMaxLength(1000);

                entity.HasOne(d => d.NguoiDangNavigation)
                    .WithMany(p => p.TinTuc)
                    .HasForeignKey(d => d.NguoiDang)
                    .HasConstraintName("FK_TinTuc_NguoiDung");
            });

            modelBuilder.Entity<TroChuyen>(entity =>
            {
                entity.HasKey(e => e.MaTroChuyen);

                entity.Property(e => e.BdnguoiGui)
                    .HasColumnName("BDNguoiGui")
                    .HasMaxLength(250);

                entity.Property(e => e.BdnguoiNhan)
                    .HasColumnName("BDNguoiNhan")
                    .HasMaxLength(250);

                entity.Property(e => e.ThoiGianTao).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
