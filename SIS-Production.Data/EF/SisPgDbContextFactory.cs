using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SIS_Production.Data.EF
{
    public class SisPgDbContextFactory : IDesignTimeDbContextFactory<SisPgDbContext>
    {
        public SisPgDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("SisPgDb");

            var optionsBuilder = new DbContextOptionsBuilder<SisPgDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SisPgDbContext(optionsBuilder.Options);
        }
    }
}
