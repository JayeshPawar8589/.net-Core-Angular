using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestUserCRUD.Model
{
    public class TestUserContext : DbContext
    {
        public TestUserContext(DbContextOptions<TestUserContext> options)
            : base(options)
        {
        }

        public DbSet<TestUser> TestUsers { get; set; }
    }
}
