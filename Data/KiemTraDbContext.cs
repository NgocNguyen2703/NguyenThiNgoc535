using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenThiNgoc535.Models;

    public class KiemTraDbContext : DbContext
    {
        public KiemTraDbContext (DbContextOptions<KiemTraDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenThiNgoc535.Models.CompanyNTN535> CompanyNTN535 { get; set; }
    }
