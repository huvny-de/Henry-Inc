using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Henry_Inc.Data.Contexts
{
    public class MyAppContextFactory : IDesignTimeDbContextFactory<MyAppContext>
    {
        public MyAppContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

            var connectionString = configuration.GetConnectionString("ConnectionString");

            var optionsBuilder = new DbContextOptionsBuilder<MyAppContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MyAppContext(optionsBuilder.Options);
        }
    }
}
