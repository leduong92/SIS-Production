using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SIS_Production.Data.EF
{
    public class SisSqlDbContextFactory : IDesignTimeDbContextFactory<SisSqlDbContext>
    {
        public SisSqlDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("SisSqlDb");

            var optionsBuilder = new DbContextOptionsBuilder<SisSqlDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SisSqlDbContext(optionsBuilder.Options);
        }
    }
}
