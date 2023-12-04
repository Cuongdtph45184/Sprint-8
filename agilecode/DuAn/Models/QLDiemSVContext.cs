using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DuAn.Models
{
    public partial class QLDiemSVContext : DbContext
    {
        public QLDiemSVContext()
        {
        }

        public QLDiemSVContext(DbContextOptions<QLDiemSVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MonHoc> MonHocs { get; set; } = null!;
        public virtual DbSet<SinhVien> SinhViens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=QLDiemSV;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MonHoc>(entity =>
            {
                entity.HasKey(e => e.MaMh)
                    .HasName("PK__MonHoc__2725DF3921666E79");

                entity.ToTable("MonHoc");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenMh).HasMaxLength(255);
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSv)
                    .HasName("PK__SinhVien__2725087A0C9411A4");

                entity.ToTable("SinhVien");

                entity.Property(e => e.MaSv)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.HoTen).HasMaxLength(255);

                entity.Property(e => e.Lop).HasMaxLength(20);

                entity.Property(e => e.MaMh)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.MaMh)
                    .HasConstraintName("FK__SinhVien__MaMh__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
