using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TestUserCRUD.Model
{
    public class TestUserContextFactory : IDesignTimeDbContextFactory<TestUserContext>
    {
        public TestUserContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                           .SetBasePath(Directory.GetCurrentDirectory())
                           .AddJsonFile("appsettings.json")
                           .Build();
            var optionsBuilder = new DbContextOptionsBuilder<TestUserContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ConnStrTestUserContext"));

            return new TestUserContext(optionsBuilder.Options);
        }
    }
}