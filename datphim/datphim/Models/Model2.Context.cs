﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace datphim.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class datphimchuanEntities : DbContext
    {
        public datphimchuanEntities()
            : base("name=datphimchuanEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tb_HoaDon> Tb_HoaDon { get; set; }
        public virtual DbSet<Tb_LichChieu_PhongChieu> Tb_LichChieu_PhongChieu { get; set; }
        public virtual DbSet<Tb_LoaiGhe> Tb_LoaiGhe { get; set; }
        public virtual DbSet<Tb_NguoiDung> Tb_NguoiDung { get; set; }
        public virtual DbSet<Tb_PhanLoaiPhim> Tb_PhanLoaiPhim { get; set; }
        public virtual DbSet<Tb_phim> Tb_phim { get; set; }
        public virtual DbSet<Tb_Phong> Tb_Phong { get; set; }
        public virtual DbSet<Tb_PhongGhe> Tb_PhongGhe { get; set; }
        public virtual DbSet<Tb_ThanhToan> Tb_ThanhToan { get; set; }
        public virtual DbSet<Tb_TheLoai> Tb_TheLoai { get; set; }
        public virtual DbSet<Tb_Ve> Tb_Ve { get; set; }
    }
}
