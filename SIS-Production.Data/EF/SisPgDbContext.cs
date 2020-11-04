using Microsoft.EntityFrameworkCore;
using SIS_Production.Data.Configurations;
using SIS_Production.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS_Production.Data.EF
{
    public class SisPgDbContext : DbContext
    {
        public SisPgDbContext(DbContextOptions<SisPgDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SiProErrorDetailConfiguration());

            modelBuilder.ApplyConfiguration(new SiProErrorMasterConfiguration());
            modelBuilder.ApplyConfiguration(new TdCurMoldLogConfiguration());
            modelBuilder.ApplyConfiguration(new TdCurMoldWashingTimeConfiguration());
            modelBuilder.ApplyConfiguration(new TdCurProgressCheckConfiguration());

            modelBuilder.ApplyConfiguration(new TdCurProgressConfiguration());
            modelBuilder.ApplyConfiguration(new TdCurProgressMasterConfiguration());
            modelBuilder.ApplyConfiguration(new TdJobPrmoldOsConfiguration());
            modelBuilder.ApplyConfiguration(new TdJobProductOsLogConfiguration());
            modelBuilder.ApplyConfiguration(new TdSis4mMasterConfiguration());
            modelBuilder.ApplyConfiguration(new TdSisCurMenuConfiguration());
            modelBuilder.ApplyConfiguration(new TdSisCurRecordConfiguration());

            modelBuilder.ApplyConfiguration(new TdSisErrorMenuConfiguration());
            modelBuilder.ApplyConfiguration(new TdSisSectionLineConfiguration());
            modelBuilder.ApplyConfiguration(new TdSisSectionMasterConfiguration());
            modelBuilder.ApplyConfiguration(new TrCurJobNbcsConfiguration());
            modelBuilder.ApplyConfiguration(new TrLblInfoNbcsConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            //base.OnModelCreating(modelBuilder);
        }

        public DbSet<SiProErrorDetail> SiProErrorDetails { get; set; }
        public DbSet<SiProErrorMaster> SiProErrorMasters { get; set; }
        public DbSet<TdCurMoldLog> TdCurMoldLogs { get; set; }
        public DbSet<TdCurMoldWashingTime> TdCurMoldWashingTimes { get; set; }
        public DbSet<TdCurProgressCheck> TdCurProgressChecks { get; set; }
        public DbSet<TdCurProgressMaster> TdCurProgressMasters { get; set; }
        public DbSet<TdJobPrmoldOs> TdJobPrmoldOs { get; set; }
        public DbSet<TdJobProductOsLog> TdJobProductOsLogs { get; set; }
        public DbSet<TdSis4mMaster> TdSis4MMasters { get; set; }
        public DbSet<TdSisCurMenu> TdSisCurMenus { get; set; }
        public DbSet<TdSisCurRecord> TdSisCurRecords { get; set; }
        public DbSet<TdSisErrorMenu> TdSisErrorMenus { get; set; }
        public DbSet<TdSisSectionLine> TdSisSectionLines { get; set; }
        public DbSet<TdSisSectionMaster> TdSisSectionMasters { get; set; }
        public DbSet<TrCurJobNbcs> TrCurJobNbcs { get; set; }
        public DbSet<TrLblInfoNbcs> TrLblInfoNbcs { get; set; }

        public DbSet<Language> Languages { get; set; }

    }
}
