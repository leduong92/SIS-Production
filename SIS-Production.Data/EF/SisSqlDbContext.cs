using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIS_Production.Data.Configurations;
using SIS_Production.Data.Entities;
using System;

namespace SIS_Production.Data.EF
{
    public class SisSqlDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public SisSqlDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SisProErrorRecordConfiguration());
        }

        public DbSet<SisProErrorRecord> SisProErrorRecords { get; set; }
    }
}
