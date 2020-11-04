using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SIS_Production.Data.Configurations;
using SIS_Production.Data.Entities;
using System;
using System.Security.Cryptography.X509Certificates;

namespace SIS_Production.Data.EF
{
    public class SisSqlDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public SisSqlDbContext(DbContextOptions<SisSqlDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SisProErrorRecordConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());

            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("AspNetUserClaims").HasKey(x=>x.Id);
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("AspNetUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("AspNetUserLogins").HasKey(x => new { x.LoginProvider, x.ProviderKey });

            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("AspNetRoleClaims").HasKey(x => x.Id);
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("AspNetUserTokens").HasKey(x =>  x.UserId);

            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<SisProErrorRecord> SisProErrorRecords { get; set; }

        public DbSet<Language> Languages { get; set; }
    }
}
