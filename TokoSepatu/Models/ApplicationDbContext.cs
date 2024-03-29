﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokoSepatu.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Merk> Merks { get; set; }
        public DbSet<Penjualan> tb_Penjualan { get; set; }
        public DbSet<PenjualanDetail> tb_PenjualanDetail { get; set; }
        public DbSet<Pembeli> Pembelis { get; set; }
    }
}
