using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIS_Production.Data.Configurations;
using SIS_Production.Data.Entities;
using System;

namespace SIS_Production.Data.EF
{
    public class SisSqlDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public SisSqlDbContext(DbContextOptions<SisSqlDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SisProErrorRecordConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AspNetUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AspNetUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AspNetUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AspNetRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AspNetUserTokens").HasKey(x => x.UserId);
        }

        public DbSet<SisProErrorRecord> SisProErrorRecords { get; set; }
    }
}
