using Microsoft.EntityFrameworkCore;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Context
{
    public class VanPhongPhamContext : DbContext
    {
        public VanPhongPhamContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<LoaiSanPham> loaiSanPhams { get; set; }
        public DbSet<SanPham> sanPhams { get; set; }
        public DbSet<NguoiDung> nguoiDungs { get; set; }
        public DbSet<DonHang> donHangs {  get; set; }
        public DbSet<ChiTietDonHang> chiTietDonHangs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSanPham>(e =>
            {
                e.ToTable("LoaiSanPham");
                e.HasKey(e => e.LoaiSanPhamId);

            });
            modelBuilder.Entity<SanPham>(e =>
            {
                e.ToTable("SanPham");
                e.HasKey(e => e.SanPhamId);
                e.HasOne(e => e.LoaiSanPham).WithMany(e => e.sanPhams).HasForeignKey(e => e.LoaiSanPhamId).OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<NguoiDung>(e =>
            {
                e.ToTable("NguoiDung");
                e.HasKey(e => e.NguoiDungId);
            });
            modelBuilder.Entity<DonHang>(e =>
            {
                e.ToTable("DonHang");
                e.HasKey(e => e.DonHangId);
                e.HasOne(e => e.nguoiDung).WithMany(e => e.donHangs).HasForeignKey(e => e.NguoiDungId).OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<ChiTietDonHang>(e =>
            {
                e.ToTable("ChiTietDonHang");
                e.HasKey(e => e.ChiTietDonHangId);
                e.HasOne(e=>e.donHang).WithMany(e=>e.chiTietDonHangs).HasForeignKey(e=>e.DonHangId).OnDelete(DeleteBehavior.ClientSetNull);
                e.HasOne(e => e.sanPham).WithMany(e => e.chiTietDonHangs).HasForeignKey(e => e.SanPhamId).OnDelete(DeleteBehavior.ClientSetNull);
            });
            base.OnModelCreating(modelBuilder);
        }
    }

}
